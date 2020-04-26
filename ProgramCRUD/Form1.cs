using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;


namespace ProgramCRUD
{
    
    public partial class Dokumenty : MetroFramework.Forms.MetroForm
    {
        BazaTableAdapters.NaglowekTableAdapter naglowekAdapter = new BazaTableAdapters.NaglowekTableAdapter();
        Baza.NaglowekDataTable tableNaglowek = new Baza.NaglowekDataTable();
        BazaTableAdapters.PozycjaTableAdapter pozycjaAdapter = new BazaTableAdapters.PozycjaTableAdapter();
        Baza.PozycjaDataTable tablePozycja = new Baza.PozycjaDataTable();
        int editidNagId = -1, editedPozId = -1;
        public Dokumenty()
        {
            InitializeComponent();
        }


        private void Dokumenty_Load(object sender, EventArgs e)
        {
            InfoFromGIT();
            this.pozycjaTableAdapter.Fill(this.baza.Pozycja);
            refreshData();
        }

        private async Task InfoFromGIT()
        {
            var client = new GitHubClient(new ProductHeaderValue("CRUD"));
            var user = await client.User.Get("elektronika96");
            Console.WriteLine("Cos");
            var request = new SearchRepositoriesRequest()
            {
                User = "elektronika96",
            };
            labUser.Text = "Właściciel repozytorium: " + request.User;
            SearchRepositoryResult result = await client.Search.SearchRepo(request);
            var items = result.Items.Where(x => x.Name == "CRUD");
            foreach (var item in items)
            {
                lab_CreateDate.Text ="Data utworzenia: "+ item.CreatedAt.ToString().Remove(19);
                lab_URL.Text = item.HtmlUrl;
            }

            
        }

        private void refreshData()
        {
            naglowekAdapter.Fill(tableNaglowek);
            mGrid_Naglowki.DataSource = tableNaglowek;
            pozycjaAdapter.Fill(tablePozycja);
            mGrid_Pozycje.DataSource = tablePozycja;
            mComBox_NazNag.Items.Clear();
            foreach (DataRow row in tableNaglowek.Rows)
            {
                mComBox_NazNag.Items.Add(row[3].ToString());
            }
            
        }

        private void clearTextBoxN()
        {
            txt_Nazwa.Text = null;
            txt_NumerKlienta.Text = null;
            editidNagId = -1;
        }

        private void btn_Anuluj_Click(object sender, EventArgs e)
        {
            clearTextBoxN();
            btn_Zapisz.Enabled = false;
            btn_Dodaj.Enabled = true;
            btn_Usun.Enabled = true;
            btn_Edytuj.Enabled = true;
        }

        private void btn_Dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                mGrid_Naglowki.EndEdit();
                ModelNaglowki modelNaglowki = new ModelNaglowki();
                modelNaglowki.Nag_NumerKlienta = int.Parse(txt_NumerKlienta.Text);
                modelNaglowki.Nag_Nazwa = txt_Nazwa.Text;
                modelNaglowki.Nag_Data = DateTime.Parse(dateTime.Text);

                if (modelNaglowki != null)
                {
                    naglowekAdapter.Insert(modelNaglowki.Nag_Data, modelNaglowki.Nag_NumerKlienta, modelNaglowki.Nag_Nazwa, 0,0);
                    refreshData();
                    clearTextBoxN();
                }
            }
            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Usun_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Czy chcesz usunąć zaznaczony dokument?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowToRemove = int.Parse(mGrid_Naglowki.CurrentRow.Cells[0].Value.ToString());
                    naglowekAdapter.DeleteQuery(rowToRemove);
                    refreshData();
                }
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number==547)
                    MetroFramework.MetroMessageBox.Show(this, "Nie można usunąć dokumentu, który ma pozycje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edytuj_Click(object sender, EventArgs e)
        {
            txt_Nazwa.Text = mGrid_Naglowki.CurrentRow.Cells[3].Value.ToString();
            txt_NumerKlienta.Text = mGrid_Naglowki.CurrentRow.Cells[2].Value.ToString();
            dateTime.Text = mGrid_Naglowki.CurrentRow.Cells[1].Value.ToString();
            editidNagId = (int)mGrid_Naglowki.CurrentRow.Cells[0].Value;
            btn_Zapisz.Enabled = true;
            btn_Dodaj.Enabled = false;
            btn_Usun.Enabled = false;
            btn_Edytuj.Enabled = false;
        }

        private void btn_Zapisz_Click(object sender, EventArgs e)
        {
            try
            {
                mGrid_Naglowki.EndEdit();
                ModelNaglowki modelNaglowki = new ModelNaglowki();
                modelNaglowki.Nag_NumerKlienta = int.Parse(txt_NumerKlienta.Text);
                modelNaglowki.Nag_Nazwa = txt_Nazwa.Text;
                modelNaglowki.Nag_Data = DateTime.Parse(dateTime.Text);

                if (modelNaglowki != null)
                {
                    naglowekAdapter.UpdateQuery(modelNaglowki.Nag_Data, modelNaglowki.Nag_NumerKlienta, modelNaglowki.Nag_Nazwa, editidNagId);
                    refreshData();
                    clearTextBoxN();
                    editidNagId = -1;
                    btn_Zapisz.Enabled = false;
                    btn_Dodaj.Enabled = true;
                    btn_Usun.Enabled = true;
                    btn_Edytuj.Enabled = true;
                }
            }
            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clearTextBoxP()
        {
            mTxt_CenaBruttoP.Text = null;
            mTxt_CenaNettoP.Text = null;
            mTxt_Liczba.Text = null;
            mTxt_NazwaArtykulu.Text = null;
            editidNagId = -1;
        }

        private void btn_DodajP_Click(object sender, EventArgs e)
        {
            try
            {
                mGrid_Pozycje.EndEdit();
                Baza.NaglowekDataTable table = new Baza.NaglowekDataTable();
                if (mComBox_NazNag.SelectedItem != null)
                {
                    naglowekAdapter.FillByNagNazwa(table, mComBox_NazNag.SelectedItem.ToString());
                    DataRow[] row = table.Select();
                    ModelPozycje modelPozycje = new ModelPozycje(row[0]["Nag_ID"].ToString(), mTxt_Liczba.Text, mTxt_NazwaArtykulu.Text, mTxt_CenaNettoP.Text, mTxt_CenaBruttoP.Text);
                    if (modelPozycje != null)
                    {
                        pozycjaAdapter.InsertQuery(modelPozycje.Poz_NagID, modelPozycje.Poz_NazwaArtykulu, modelPozycje.Poz_Liczba, modelPozycje.Poz_CenaNetto, modelPozycje.Poz_CenaBrutto);
                        refreshData();
                        clearTextBoxP();
                    }
                }
                else
                    throw new Exception("Wybierz nazwe faktury");             
            }
            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.Message, "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EdytujP_Click(object sender, EventArgs e)
        {
            mTxt_CenaBruttoP.Text = mGrid_Pozycje.CurrentRow.Cells[5].Value.ToString();
            mTxt_CenaNettoP.Text = mGrid_Pozycje.CurrentRow.Cells[4].Value.ToString();
            mTxt_NazwaArtykulu.Text = mGrid_Pozycje.CurrentRow.Cells[2].Value.ToString();
            mTxt_Liczba.Text = mGrid_Pozycje.CurrentRow.Cells[3].Value.ToString();
            mComBox_NazNag.Enabled = false;
            editedPozId = (int)mGrid_Pozycje.CurrentRow.Cells[0].Value;
            btn_ZapiszP.Enabled = true;
            btn_DodajP.Enabled = false;
            btn_UsunP.Enabled = false;
            btn_EdytujP.Enabled = false;
        }

        private void btn_UsunP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MetroFramework.MetroMessageBox.Show(this, "Czy chcesz usunąć zaznaczoną pozycję?", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowToRemove = int.Parse(mGrid_Pozycje.CurrentRow.Cells[0].Value.ToString());
                    pozycjaAdapter.DeleteQuery(rowToRemove);
                    refreshData();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
               MetroFramework.MetroMessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AnulujP_Click(object sender, EventArgs e)
        {
            clearTextBoxP();
            btn_ZapiszP.Enabled = false;
            btn_DodajP.Enabled = true;
            btn_UsunP.Enabled = true;
            btn_EdytujP.Enabled = true;
            mComBox_NazNag.Enabled = true;
        }

        private void lab_URL_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lab_URL.Text);
        }

        private void btnZapiszP_Click(object sender, EventArgs e)
        {
            try
            {
                mGrid_Pozycje.EndEdit();
                ModelPozycje modelPozycje = new ModelPozycje(mTxt_Liczba.Text, mTxt_NazwaArtykulu.Text, mTxt_CenaNettoP.Text, mTxt_CenaBruttoP.Text);
                if (modelPozycje != null)
                {
                    pozycjaAdapter.UpdateQuery(modelPozycje.Poz_NazwaArtykulu,modelPozycje.Poz_Liczba,modelPozycje.Poz_CenaNetto,modelPozycje.Poz_CenaBrutto,editedPozId);
                    refreshData();
                    clearTextBoxN();
                    editedPozId = -1;
                    btn_ZapiszP.Enabled = false;
                    btn_DodajP.Enabled = true;
                    btn_UsunP.Enabled = true;
                    btn_EdytujP.Enabled = true;
                    mComBox_NazNag.Enabled = true;
                }
            }
            catch (Exception error)
            {
                MetroFramework.MetroMessageBox.Show(this, error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
