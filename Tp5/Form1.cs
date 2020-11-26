using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //dragging pour controler le mouvement de la winform
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        DBConnect db = new DBConnect();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelInfo2.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelInfo1.BackColor = Color.FromArgb(100, 0, 0, 0);
            DevisPanel.BackColor = Color.FromArgb(100, 0, 0, 0);

            //remplir le grid des factures
            db.Afficher_Facture(FactureGrid);

            //remplir le grid des devis
            db.Afficher_Devis(DevisGrid);

            //remplir le combobox des clients
            db.Fill_NomClient(NomClient);

            //remplir le comboBox des RS
            //Fill_RS();
            
        }

        
        private void Fill_RS()
        {
            RS.Items.Clear();
            RS.ResetText();
            RS.Items.Add("");
            for(int i = 0; i<3;i++)
            {
                RS.Items.Add("EX" + i);
            }
        }
        
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MetroFramework.Controls.MetroTextBox || control is MetroFramework.Controls.MetroComboBox)
                    {
                        control.ResetText();
                    }

                    else
                        func(control.Controls);

            };

            func(Controls);
        }

        

        

        private void AjouterFactureButton(object sender, EventArgs e)
        {
            
            bool verify1;
            bool verify2;
            try
            {
                int qte;
                double prix;
                string codeFacture = "";
                string reference = "";
                string designation = "";
                string date = "";
                //string nomClient = NomClient.SelectedItem.ToString();
                double tva = 0;
                string idClient = "";
                string rs = "";

                

                if (string.IsNullOrWhiteSpace(FactureCode.Text)) { throw new Ex("vous devez remplir le champ code !!"); } else { codeFacture = FactureCode.Text; }
                if (string.IsNullOrWhiteSpace(Reference.Text)) { throw new Ex("vous devez remplir le champ reference!!"); } else { reference = Reference.Text; }
                if (string.IsNullOrWhiteSpace(Designation.Text)) { throw new Ex("vous devez remplir le champ designation !!"); } else { designation = Designation.Text; }
                verify1 = int.TryParse(QTE.Text, out qte); if (!verify1) { throw new ExQte(); }
                verify2 = double.TryParse(Prix.Text, out prix); if (!verify2) { throw new ExPrix(); }
                if (tvacombobox.SelectedIndex == -1) { throw new Ex("vous devez remplir le champ tva !!"); } else { tva = double.Parse(tvacombobox.SelectedItem.ToString()); }
                if (string.IsNullOrWhiteSpace(Date.Text)) { throw new Ex("vous devez remplir le champ date !!"); } else { date = Date.Text; }
                if (string.IsNullOrWhiteSpace(IDClient.Text)) { idClient = ""; } else { idClient = IDClient.Text; }
                if (RS.SelectedIndex == -1) { rs = ""; } else { rs = RS.SelectedItem.ToString(); }



                double montant = qte * prix;
                MontantTotal.Text = "" + montant;
                double tvaVal = montant * (tva / 100);
                ValeurTva.Text = "" + tvaVal;
                double total = montant + tvaVal;
                TotalAPayer.Text = "" + total;

                if (db.check_Existence("facture", codeFacture))
                {
                    MessageBox.Show("la facture du code " + codeFacture + " existe deja !\n" +
                        "Pour appliquer une modificaton cliquez sur Modifier");
                }
                else
                {
                    MessageBox.Show("succes!!");

                    db.Ajouter_Facture(codeFacture, designation, reference, qte, prix, total, date, idClient, rs);

                    ClearTextBoxes();
                    //Fill_RS();

                    db.Fill_NomClient(NomClient);
                    db.Afficher_Facture(FactureGrid);

                }
            }
            catch (Exception ex)

            {
                
            }






            


        }

        private void NomClient_IndexChanged(object sender, EventArgs e)
        {
            IceClient.Text = "";
            IDClient.Text = "";
            string nom = NomClient.SelectedItem.ToString();
            if(!string.IsNullOrEmpty(nom))
            {
                db.cmd = new SqlCommand("SELECT code,ice FROM infoClients where nom = @nom", db.conn);
                db.cmd.Parameters.AddWithValue("@nom", nom);
                db.adapt = new SqlDataAdapter(db.cmd);
                db.ds = new DataSet();
                db.adapt.Fill(db.ds);
                string code = db.ds.Tables[0].Rows[0][0].ToString();
                string ice = db.ds.Tables[0].Rows[0][1].ToString();
                IceClient.Text = ice;
                IDClient.Text = code;
            }
            Fill_RS();

        }

        private void ModifierFactureButton(object sender, EventArgs e)
        {
            bool verify1;
            bool verify2;
            try
            {
                int qte;
                double prix;
                string codeFacture = "";
                string reference = "";
                string designation = "";
                string date = "";
                //string nomClient = NomClient.SelectedItem.ToString();
                double tva = 0;
                string idClient = "";
                string rs = "";



                if (string.IsNullOrWhiteSpace(FactureCode.Text)) { throw new Ex("vous devez remplir le champ code !!"); } else { codeFacture = FactureCode.Text; }
                if (string.IsNullOrWhiteSpace(Reference.Text)) { throw new Ex("vous devez remplir le champ reference!!"); } else { reference = Reference.Text; }
                if (string.IsNullOrWhiteSpace(Designation.Text)) { throw new Ex("vous devez remplir le champ designation !!"); } else { designation = Designation.Text; }
                verify1 = int.TryParse(QTE.Text, out qte); if (!verify1) { throw new ExQte(); }
                verify2 = double.TryParse(Prix.Text, out prix); if (!verify2) { throw new ExPrix(); }
                if (tvacombobox.SelectedIndex == -1) { throw new Ex("vous devez remplir le champ tva !!"); } else { tva = double.Parse(tvacombobox.SelectedItem.ToString()); }
                if (string.IsNullOrWhiteSpace(Date.Text)) { throw new Ex("vous devez remplir le champ date !!"); } else { date = Date.Text; }
                if (string.IsNullOrWhiteSpace(IDClient.Text)) { idClient = ""; } else { idClient = IDClient.Text; }
                if (string.IsNullOrWhiteSpace(RS.SelectedItem.ToString())) { rs = ""; } else { rs = RS.SelectedItem.ToString(); }


                double montant = qte * prix;
                MontantTotal.Text = "" + montant;
                double tvaVal = montant * (tva / 100);
                ValeurTva.Text = "" + tvaVal;
                double total = montant + tvaVal;
                TotalAPayer.Text = "" + total;


                if (!db.check_Existence("facture", codeFacture))
                {
                    MessageBox.Show("la facture du code " + codeFacture + " n'existe pas !\n" +
                        "Pour Ajouter une facture cliquez sur Ajouter");
                }
                else
                {
                    db.Modifier_Facture(codeFacture, designation, reference, qte, prix, total, date, idClient, rs);

                    MessageBox.Show("succes!!");
                    
                    ClearTextBoxes();
                    //Fill_RS();
                    db.Fill_NomClient(NomClient);
                    db.Afficher_Facture(FactureGrid);
                }

            }
            catch (Exception ex)

            {

            }




            
        }

        private void FactureGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                tvacombobox.SelectedItem = "";
                DataGridViewRow row = this.FactureGrid.Rows[e.RowIndex];

                FactureCode.Text = row.Cells["code"].Value.ToString();
                Designation.Text = row.Cells["designation"].Value.ToString();
                QTE.Text = row.Cells["quantite"].Value.ToString();
                Prix.Text = row.Cells["prix"].Value.ToString();
                TotalAPayer.Text = row.Cells["total"].Value.ToString();
                Date.Text = row.Cells["date"].Value.ToString();
                Reference.Text = row.Cells["reference"].Value.ToString();
                if (db.Select_NomClient(row.Cells["code"].Value.ToString())!="null" )
                {
                    NomClient.SelectedItem = db.Select_NomClient(row.Cells["code"].Value.ToString());
                }
                else { NomClient.SelectedItem = ""; }

                RS.SelectedItem = row.Cells["RS"].Value.ToString();

                double prixApayer = (double.Parse(row.Cells["prix"].Value.ToString()) * int.Parse(row.Cells["quantite"].Value.ToString())); ;
                double pourcentage = double.Parse(row.Cells["total"].Value.ToString()) - prixApayer;
                double tva = (pourcentage * 100) / prixApayer;

                string tv = ""+Convert.ToInt32(tva);

                MontantTotal.Text = ""+prixApayer;
                ValeurTva.Text = "" + pourcentage;

                tvacombobox.SelectedItem =tv;


            }
        }

        private void SupprimerButton(object sender, EventArgs e)
        {
            string code = FactureCode.Text;
            if (!db.check_Existence("facture", code))
            {
                MessageBox.Show("la facture du code " + code + " n'existe pas !\n" );
            }
            else
            {
                db.Supprimer_Facture(code);

                MessageBox.Show("succes!!");
                ClearTextBoxes();
                //Fill_RS();

                db.Fill_NomClient(NomClient);
                db.Afficher_Facture(FactureGrid);

            }
            
        }



        private void QuitterButton(object sender, EventArgs e)
        {
            this.Close();
        }

        //cette partie du code sert a controler le mouvement de notre fenetre

        private void PanelHome_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PanelHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void PanelHome_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
             ClearTextBoxes();
            
        }

        private void PanelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenererDevis(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void NewDevis(object sender, EventArgs e)
        {
            bool verify1;
            bool verify2;
            try
            {
                int qte;
                double prix;
                string codeFacture = "";
                string reference = "";
                string designation = "";
                string date = "";
                //string nomClient = NomClient.SelectedItem.ToString();
                double tva = 0;
                string idClient = "";
                string rs = "";
                string codeDevis = "";
                string dateDevis = "";
                string status = "";




                if (string.IsNullOrWhiteSpace(FactureCode.Text)) { throw new Ex("vous devez remplir le champ code !!"); } else { codeFacture = FactureCode.Text; }
                if (string.IsNullOrWhiteSpace(Reference.Text)) { throw new Ex("vous devez remplir le champ reference!!"); } else { reference = Reference.Text; }
                if (string.IsNullOrWhiteSpace(Designation.Text)) { throw new Ex("vous devez remplir le champ designation !!"); } else { designation = Designation.Text; }
                verify1 = int.TryParse(QTE.Text, out qte); if (!verify1) { throw new ExQte(); }
                verify2 = double.TryParse(Prix.Text, out prix); if (!verify2) { throw new ExPrix(); }
                if (tvacombobox.SelectedIndex == -1) { throw new Ex("vous devez remplir le champ tva !!"); } else { tva = double.Parse(tvacombobox.SelectedItem.ToString()); }
                if (string.IsNullOrWhiteSpace(Date.Text)) { throw new Ex("vous devez remplir le champ date !!"); } else { date = Date.Text; }
                if (string.IsNullOrWhiteSpace(IDClient.Text)) { idClient = ""; } else { idClient = IDClient.Text; }
                if (RS.SelectedIndex == -1) { rs = ""; } else { rs = RS.SelectedItem.ToString(); }

                //Devis part
                if (DevisStatus.SelectedIndex == -1) { status = ""; } else { status = DevisStatus.SelectedItem.ToString(); }
                if (string.IsNullOrWhiteSpace(DevisCode.Text)) { throw new Ex("vous devez remplir le champ code de devis !!"); } else { codeDevis = DevisCode.Text; }
                if (string.IsNullOrWhiteSpace(DevisDate.Text)) { throw new Ex("vous devez remplir le champ date de devis !!"); } else { dateDevis = DevisDate.Text; }



                double montant = qte * prix;
                MontantTotal.Text = "" + montant;
                double tvaVal = montant * (tva / 100);
                ValeurTva.Text = "" + tvaVal;
                double total = montant + tvaVal;
                TotalAPayer.Text = "" + total;

                if (db.check_Existence("devis", codeDevis))
                {
                    MessageBox.Show("Ce code de Devis \" " + codeDevis + " \" existe deja !\n");
                }
                else
                {
                    MessageBox.Show("succes!!");

                    db.Ajouter_Devis(codeDevis, status, idClient,dateDevis, rs, qte, total);

                    ClearTextBoxes();
                    

                    db.Fill_NomClient(NomClient);
                    db.Afficher_Facture(FactureGrid);
                    db.Afficher_Devis(DevisGrid);


                }
            }
            catch (Exception ex)

            {

            }
        }

        private void DevisStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DevisStatus.SelectedItem.ToString() == "En attente")
            {
                GenererDevisButt.Enabled = false;
                GenererDevisButt.Text = "Disabled";
            }
            else
            {
                GenererDevisButt.Text = "Devis=>Facture";

                GenererDevisButt.Enabled = true;

            }

        }

        
    }
}
