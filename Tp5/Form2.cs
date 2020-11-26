using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Tp5
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        //dragging pour controler le mouvement de la winform
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        DBConnect db = new DBConnect();

        public Form2()
        {
            InitializeComponent();
            PanelInfo2.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelInfo1.BackColor = Color.FromArgb(100, 0, 0, 0);
            db.Afficher_Client(ClientGrid);
            db.Fill_City(filtreCombo);
            db.Fill_City(VilleCombo);


        }
        private void HomePanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void HomePanel_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void HomePanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void QuitterButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterButton(object sender, EventArgs e)
        {
            
            try
            {
                string id = "";
                string rs = "";
                string ifClient = "";
                string type_societe = "";
                string ice = "";
                string registre = "";
                string Respo_nom = "";
                string patente = "";
                string nom = "";
                string prenom = "";
                string portable = "";
                string email = "";
                string adresse = "";
                string tele = "";
                string fax = "";
                string ville = "";
                string pays = "";




                if (string.IsNullOrWhiteSpace(ClientId.Text)) { throw new Ex("vous devez remplir le champ Client ID !!"); } else { id = ClientId.Text; }
                if (string.IsNullOrWhiteSpace(RS.Text)) { rs = ""; } else { rs = RS.Text; }
                if (string.IsNullOrWhiteSpace(ClientIf.Text)) { throw new Ex("vous devez remplir le champ IF CLIENT !!"); } else { ifClient = ClientIf.Text; }

                if (string.IsNullOrWhiteSpace(TypeSoc.Text)) { throw new Ex("vous devez remplir le champ Type de societe !!"); } else { type_societe = TypeSoc.Text; }
                if (string.IsNullOrWhiteSpace(IceBox.Text)) { throw new Ex("vous devez remplir le champ ICE !!"); } else { ice = IceBox.Text; }
                if (string.IsNullOrWhiteSpace(RegistreBox.Text)) { throw new Ex("vous devez remplir le registre code !!"); } else { registre = RegistreBox.Text; }

                if (string.IsNullOrWhiteSpace(RespoNameBox.Text)) { throw new Ex("vous devez remplir le champ Nom de Responsable !!"); } else { Respo_nom = RespoNameBox.Text; }
                if (string.IsNullOrWhiteSpace(PatenteBox.Text)) { throw new Ex("vous devez remplir le champ Patente!!"); } else { patente = PatenteBox.Text; }

                if (string.IsNullOrWhiteSpace(Nom.Text)) { throw new Ex("vous devez remplir le champ Nom !!"); } else { nom = Nom.Text; }
                if (string.IsNullOrWhiteSpace(Prenom.Text)) { throw new Ex("vous devez remplir le champ Prenom !!"); } else { prenom = Prenom.Text; }
                if (string.IsNullOrWhiteSpace(Email.Text)) { throw new Ex("vous devez remplir le champ Email !!"); } else { email = Email.Text; }
                if (string.IsNullOrWhiteSpace(Tele.Text)) { throw new Ex("vous devez remplir le champ Tele !!"); } else { tele = Tele.Text; }

                if (string.IsNullOrWhiteSpace(Adresse.Text)) { throw new Ex("vous devez remplir le champ Adresse !!"); } else { adresse = VilleCombo.Text; }
                if (string.IsNullOrWhiteSpace(Portable.Text)) { throw new Ex("vous devez remplir le champ Portable !!"); } else { portable = Portable.Text; }

                if (string.IsNullOrWhiteSpace(VilleCombo.SelectedItem.ToString())) { throw new Ex("vous devez remplir le champ Ville!!"); } else { ville = VilleCombo.SelectedItem.ToString(); }
                if (string.IsNullOrWhiteSpace(Pays.Text)) { throw new Ex("vous devez remplir le champ Pays !!"); } else { pays = Pays.Text; }
                if (string.IsNullOrWhiteSpace(Fax.Text)) { throw new Ex("vous devez remplir le champ Fax !!"); } else { fax = Fax.Text; }



                

                if (db.check_Existence("infoClients", id))
                {
                    MessageBox.Show("le client du code " + id + " existe deja !\n" +
                        "Pour appliquer une modification cliquez sur Modifier");
                }
                else
                {
                    db.Ajouter_Client(id, nom, prenom, portable, tele, fax, ice, ifClient,
                                        email, adresse, ville, pays, Respo_nom, type_societe, registre, patente,rs);

                    MessageBox.Show("succes!!");
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)

            {

            }
            
            db.Afficher_Client(ClientGrid);

        }

        

        private void ModifierButton(object sender, EventArgs e)
        {

            try
            {
                string id = "";
                string rs = "";
                string ifClient = "";
                string type_societe = "";
                string ice = "";
                string registre = "";
                string Respo_nom = "";
                string patente = "";
                string nom = "";
                string prenom = "";
                string portable = "";
                string email = "";
                string adresse = "";
                string tele = "";
                string fax = "";
                string ville = "";
                string pays = "";




                if (string.IsNullOrWhiteSpace(ClientId.Text)) { throw new Ex("vous devez remplir le champ Client ID !!"); } else { id = ClientId.Text; }
                if (string.IsNullOrWhiteSpace(RS.Text)) { rs = ""; } else { rs = RS.Text; }
                if (string.IsNullOrWhiteSpace(ClientIf.Text)) { throw new Ex("vous devez remplir le champ IF CLIENT !!"); } else { ifClient = ClientIf.Text; }

                if (string.IsNullOrWhiteSpace(TypeSoc.Text)) { throw new Ex("vous devez remplir le champ Type de societe !!"); } else { type_societe = TypeSoc.Text; }
                if (string.IsNullOrWhiteSpace(IceBox.Text)) { throw new Ex("vous devez remplir le champ ICE !!"); } else { ice = IceBox.Text; }
                if (string.IsNullOrWhiteSpace(RegistreBox.Text)) { throw new Ex("vous devez remplir le registre code !!"); } else { registre = RegistreBox.Text; }

                if (string.IsNullOrWhiteSpace(RespoNameBox.Text)) { throw new Ex("vous devez remplir le champ Nom de Responsable !!"); } else { Respo_nom = RespoNameBox.Text; }
                if (string.IsNullOrWhiteSpace(PatenteBox.Text)) { throw new Ex("vous devez remplir le champ Patente!!"); } else { patente = PatenteBox.Text; }

                if (string.IsNullOrWhiteSpace(Nom.Text)) { throw new Ex("vous devez remplir le champ Nom !!"); } else { nom = Nom.Text; }
                if (string.IsNullOrWhiteSpace(Prenom.Text)) { throw new Ex("vous devez remplir le champ Prenom !!"); } else { prenom = Prenom.Text; }
                if (string.IsNullOrWhiteSpace(Email.Text)) { throw new Ex("vous devez remplir le champ Email !!"); } else { email = Email.Text; }
                if (string.IsNullOrWhiteSpace(Tele.Text)) { throw new Ex("vous devez remplir le champ Tele !!"); } else { tele = Tele.Text; }

                if (string.IsNullOrWhiteSpace(Adresse.Text)) { throw new Ex("vous devez remplir le champ Adresse !!"); } else { adresse = Adresse.Text; }
                if (string.IsNullOrWhiteSpace(Portable.Text)) { throw new Ex("vous devez remplir le champ Portable !!"); } else { portable = Portable.Text; }

                if (string.IsNullOrWhiteSpace(VilleCombo.SelectedItem.ToString())) { throw new Ex("vous devez remplir le champ Ville!!"); } else { ville = VilleCombo.SelectedItem.ToString(); }
                if (string.IsNullOrWhiteSpace(Pays.Text)) { throw new Ex("vous devez remplir le champ Pays !!"); } else { pays = Pays.Text; }
                if (string.IsNullOrWhiteSpace(Fax.Text)) { throw new Ex("vous devez remplir le champ Fax !!"); } else { fax = Fax.Text; }





                if (!db.check_Existence("infoClients", id))
                {
                    MessageBox.Show("le client du code " + id + " ,n'existe pas !\n" +
                        "Pour l'ajouter cliquez sur Ajouter");
                }
                else
                {
                    db.Modifier_Client(id, nom, prenom, portable, tele, fax, ice, ifClient,
                                        email, adresse, ville, pays, Respo_nom, type_societe, registre, patente,rs);

                    MessageBox.Show("succes!!");
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)

            {

            }
            

            db.Afficher_Client(ClientGrid);
        }

       

        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ClientGrid.Rows[e.RowIndex];

                ClientId.Text = row.Cells["code"].Value.ToString();
                RS.Text = row.Cells["RS"].Value.ToString();
                ClientIf.Text = row.Cells["IFClient"].Value.ToString();

                TypeSoc.Text = row.Cells["type_societe"].Value.ToString();
                IceBox.Text = row.Cells["ice"].Value.ToString();
                RegistreBox.Text = row.Cells["registre"].Value.ToString();

                RespoNameBox.Text = row.Cells["respo_nom"].Value.ToString();
                PatenteBox.Text = row.Cells["patente"].Value.ToString();

                Nom.Text = row.Cells["nom"].Value.ToString();
                Prenom.Text = row.Cells["prenom"].Value.ToString();
                Email.Text = row.Cells["email"].Value.ToString();
                Tele.Text = row.Cells["tele"].Value.ToString();

                Adresse.Text = row.Cells["adresse"].Value.ToString();
                Fax.Text = row.Cells["fax"].Value.ToString();
                Portable.Text = row.Cells["portable"].Value.ToString();

                VilleCombo.Text = row.Cells["ville"].Value.ToString();
                Pays.Text = row.Cells["pays"].Value.ToString();



            }
        }

        private void Quitter(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void vider(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void SupprimerClient(object sender, EventArgs e)
        {
            string code = ClientId.Text;
            if (!db.check_Existence("infoClients", code))
            {
                MessageBox.Show("le client du code " + code + " n'existe pas !\n");
            }
            else
            {
                db.Supprimer_Client(code);
                MessageBox.Show("succes!!");
                ClearTextBoxes();
            }
            
            
            db.Afficher_Client(ClientGrid);
        }
        
        private void ExcelConvert(object sender, EventArgs e)
        {

            SaveFileDialog saveF = new SaveFileDialog();
            


            saveF.InitialDirectory = "C:";
            saveF.Title = "Save Conveting File ";
            saveF.FileName = "";
            saveF.Filter = "Excel Files(2016)|*.xlsx";

            if(saveF.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);

                app.Columns.ColumnWidth = 20;

                int i, j;
                //fill the first row with columns descriptions
                for( i = 1; i< ClientGrid.Columns.Count+1;i++)
                {
                    app.Cells[1, i] = ClientGrid.Columns[i-1].HeaderText;
                }

                //fill our values 
                for ( i = 0; i < ClientGrid.Rows.Count; i++)
                {
                    for ( j = 0; j < ClientGrid.Columns.Count; j++)
                    {
                        app.Cells[i+2, j+1] = ClientGrid.Rows[i].Cells[j].Value;
                    }
                }
                app.ActiveWorkbook.SaveCopyAs(saveF.FileName.ToString());
                app.ActiveWorkbook.Saved = true;
                app.Quit();
            }


        }

        private void filtre(object sender, EventArgs e)
        {
            string value = filtreCombo.SelectedItem.ToString();
            if(string.IsNullOrWhiteSpace(value))
            {
                db.Afficher_Client(ClientGrid);
            }
            else
            {
                db.Afficher_Client_ParFiltre(ClientGrid, value);
            }

        }
    }
}
