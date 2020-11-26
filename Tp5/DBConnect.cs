using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Tp5
{
    class DBConnect : MetroFramework.Forms.MetroForm
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;
        public DataSet ds;

        public string PathDebug = Directory.GetParent(Program.PathDebug).ToString(); // C:\Users\HP\Desktop\tp5\Tp5\bin\Debug
        public static string PathBin = Directory.GetParent(Program.PathBin).ToString(); // C:\Users\HP\Desktop\tp5\Tp5\bin
        public string PathDirectoryTP5 = Directory.GetParent(PathBin).ToString(); // C:\Users\HP\Desktop\tp5\Tp5

        string path = Program.PathBin;

        public DBConnect()
        {
            //MessageBox.Show(Program.PathBin);
            //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\tp5\Tp5\Database1.mdf;Integrated Security=True");
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ path + @"\Database1.mdf;Integrated Security=True");
            conn.Open();
        }

        public bool check_Existence(string table, string code)
        {
            if (table.Equals("infoClients"))
            {
                cmd = new SqlCommand("select code from infoClients", conn);
            }
            if (table.Equals("facture"))
            {
                cmd = new SqlCommand("select code from facture", conn);
            }
            if (table.Equals("devis"))
            {
                cmd = new SqlCommand("select code from devis", conn);
            }
            if (table.Equals("infoCrystal"))
            {
                cmd = new SqlCommand("select codeDevis from infoCrystal", conn);
            }


            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);

            foreach (DataRow x in ds.Tables[0].Rows)
            {
                if (x[0].ToString() == code) { return true; }

            }
            return false;
            
            
        }



        public string Select_NomClient(string codefacture)
        {
            cmd = new SqlCommand("SELECT idClient FROM facture where code = @code", conn);
            cmd.Parameters.AddWithValue("@code", codefacture);
            cmd.ExecuteNonQuery();
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            cmd.Parameters.Clear();
            string code=  ds.Tables[0].Rows[0][0].ToString();
            if (string.IsNullOrEmpty(code) || !check_Existence("infoClients",code) ) //au cas ou un des clients a ete supprimer de la liste
            {
                return "null";
            }
            else
            {
                
                    cmd = new SqlCommand("SELECT nom FROM infoClients where code = @code", conn);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                    adapt = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adapt.Fill(ds);
                    cmd.Parameters.Clear();
                    return ds.Tables[0].Rows[0][0].ToString();
                
                

            }
           
           
            
        }
        public void Fill_NomClient(MetroFramework.Controls.MetroComboBox combo)
        {
            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom FROM infoClients", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }


        public void Fill_City(MetroFramework.Controls.MetroComboBox combo)
        {
            combo.Items.Clear();
            combo.ResetText();
            cmd = new SqlCommand("SELECT nom FROM ville", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            combo.Items.Add("");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                combo.Items.Add(x[0].ToString());
            }
        }

        public void Afficher_Facture(MetroFramework.Controls.MetroGrid grid)
        {
            
            cmd = new SqlCommand("SELECT code,reference,designation,quantite,prix,total,date,RS FROM facture", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];

        }

        public void Afficher_Devis(MetroFramework.Controls.MetroGrid grid)
        {

            cmd = new SqlCommand("SELECT status,code,RS,qte,total,date FROM devis", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];

        }

        public void Ajouter_Facture(string code, string designation, string reference, int quantite, double prix, double total, string date, string idClient, string rs)
        {

            cmd = new SqlCommand("INSERT INTO facture (code,designation,reference,quantite,prix,date,total,idClient,RS) " +
                "VALUES (@code,@designation,@reference,@quantite,@prix,@date,@total,@idClient,@RS)", conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@reference", reference);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@idClient", idClient);
            cmd.Parameters.AddWithValue("@RS", rs);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();




        }


        public void Ajouter_Devis(string code, string status, string idClient, string date, string rs, int quantite, double total)
        {

            cmd = new SqlCommand("INSERT INTO devis (code,status,idClient,date,RS,qte,total) " +
                "VALUES (@code,@status,@idClient,@date,@RS,@qte,@total)", conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@qte", quantite);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@idClient", idClient);
            cmd.Parameters.AddWithValue("@RS", rs);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void Modifier_Facture(string code, string designation, string reference, int quantite, double prix, double total, string date, string idClient, string rs)
        {


            cmd = new SqlCommand("update facture set designation=@designation,reference=@reference,quantite=@quantite,prix=@prix," +
                "date=@date,total=@total,idClient=@idClient,RS=@RS where code = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@reference", reference);
            cmd.Parameters.AddWithValue("@quantite", quantite);
            cmd.Parameters.AddWithValue("@prix", prix);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@idClient", idClient);
            cmd.Parameters.AddWithValue("@RS", rs);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();




        }

        public void Supprimer_Facture(string code)
        {


            cmd = new SqlCommand("delete from facture where code = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();




        }



        //Client

        public void Afficher_Client(TransparentGrid grid)
        {

            cmd = new SqlCommand("SELECT code,nom,prenom,portable,tele,fax,ice,IFClient,email,adresse,ville,pays," +
                "respo_nom,type_societe,registre,patente,RS FROM infoClients", conn);
            adapt = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];

        }


        public void Afficher_Client_ParFiltre(TransparentGrid grid,string ville)
        {

            cmd = new SqlCommand("SELECT code,nom,prenom,portable,tele,fax,ice,IFClient,email,adresse,ville,pays," +
                "respo_nom,type_societe,registre,patente,RS FROM infoClients where ville = @ville", conn);
            cmd.Parameters.AddWithValue("@ville", ville);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            ds = new DataSet();
            adapt.Fill(ds);
            grid.DataSource = ds.Tables[0];
            cmd.Parameters.Clear();

        }

        public void Ajouter_Client(string code, string nom, string prenom, string portable, string tele, string fax, string ice, string IFClient,
            string email, string adresse, string ville, string pays, string respo_nom, string type_societe, string registre, string patente,string rs)
        {

            cmd = new SqlCommand("INSERT INTO InfoClients (code,nom,prenom,portable,tele,fax,ice,IFClient,email,adresse,ville,pays," +
                "respo_nom,type_societe,registre,patente,RS) VALUES (@code,@nom,@prenom,@portable,@tele,@fax,@ice,@IFClient,@email," +
                "@adresse,@ville,@pays,@respo_nom,@type_societe,@registre,@patente,@rs)", conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@portable", portable);
            cmd.Parameters.AddWithValue("@tele", tele);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@ice", ice);
            cmd.Parameters.AddWithValue("@IFClient", IFClient);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@ville", ville);
            cmd.Parameters.AddWithValue("@pays", pays);
            cmd.Parameters.AddWithValue("@respo_nom", respo_nom);
            cmd.Parameters.AddWithValue("@type_societe", type_societe);
            cmd.Parameters.AddWithValue("@registre", registre);
            cmd.Parameters.AddWithValue("@patente", patente);
            cmd.Parameters.AddWithValue("@rs", rs);

            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void Modifier_Client(string code, string nom, string prenom, string portable, string tele, string fax, string ice, string IFClient,
            string email, string adresse, string ville, string pays, string respo_nom, string type_societe, string registre, string patente, string rs)
        {

            cmd = new SqlCommand("update InfoClients set nom = @nom,prenom = @prenom,portable =@portable ,tele=@tele,fax=@fax,ice=@ice," +
                "IFClient=@IFClient,email=@email,adresse=@adresse,ville=@ville,pays=@pays,respo_nom=@respo_nom,type_societe=@type_societe," +
                "registre=@registre,patente=@patente,RS=@rs where code = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@portable", portable);
            cmd.Parameters.AddWithValue("@tele", tele);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@ice", ice);
            cmd.Parameters.AddWithValue("@IFClient", IFClient);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@adresse", adresse);
            cmd.Parameters.AddWithValue("@ville", ville);
            cmd.Parameters.AddWithValue("@pays", pays);
            cmd.Parameters.AddWithValue("@respo_nom", respo_nom);
            cmd.Parameters.AddWithValue("@type_societe", type_societe);
            cmd.Parameters.AddWithValue("@registre", registre);
            cmd.Parameters.AddWithValue("@patente", patente);
            cmd.Parameters.AddWithValue("@rs", rs);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }

        public void Supprimer_Client(string code)
        {


            cmd = new SqlCommand("delete from infoClients where code = @code", conn);
            cmd.Parameters.AddWithValue("@code", code);
            adapt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();




        }

    }
}
