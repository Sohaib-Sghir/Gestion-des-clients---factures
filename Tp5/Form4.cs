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
    public partial class Form4 : Form
    {
        DBConnect db = new DBConnect();
        DataSet ds;

        public Form4()
        {
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            Fill_Report();

            db.cmd = new SqlCommand("select * from devis", db.conn);
            db.adapt = new SqlDataAdapter(db.cmd);
            ds = new DataSet();
            db.adapt.Fill(ds);


            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

               

                string code = row.Cells["code"].Value.ToString();

                
                    

                testdataC dss = new testdataC();
                db.cmd = new SqlCommand("select * from infoCrystal where codeDevis = @code", db.conn);
                db.cmd.Parameters.AddWithValue("@code", code);
                db.adapt = new SqlDataAdapter(db.cmd);
                db.cmd.ExecuteNonQuery();
                db.adapt.Fill(dss,"infoCrystal");
                db.cmd.Parameters.Clear();


                testCrystal3 cr = new testCrystal3();
                cr.SetDataSource(dss.Tables["infoCrystal"]);

                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();

            }
        }

        public void Fill_Report()
        {

           db.cmd = new SqlCommand("delete from infoCrystal", db.conn);
            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();

            db.cmd = new SqlCommand("select * from devis", db.conn);
            ds = new DataSet();
            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.adapt.Fill(ds);



            string codeClientEnDevis = ds.Tables[0].Rows[0][3].ToString();
            string codeDevisCr = ds.Tables[0].Rows[0][1].ToString();

            db.cmd = new SqlCommand("insert into infoCrystal (codeDevis,codeClient,dateDevis,totalDevis,qteDevis,status,RS)" +
                "values (@codeDevis,@codeClient,@dateDevis,@totalDevis,@qteDevis,@status,@rs) ", db.conn);
            db.cmd.Parameters.AddWithValue("@codeDevis", codeDevisCr);
            db.cmd.Parameters.AddWithValue("@status", ds.Tables[0].Rows[0][2].ToString());
            db.cmd.Parameters.AddWithValue("@codeClient", codeClientEnDevis);
            db.cmd.Parameters.AddWithValue("@dateDevis", ds.Tables[0].Rows[0][4].ToString());
            db.cmd.Parameters.AddWithValue("@rs", ds.Tables[0].Rows[0][5].ToString());
            db.cmd.Parameters.AddWithValue("@qteDevis", int.Parse(ds.Tables[0].Rows[0][6].ToString()));
            db.cmd.Parameters.AddWithValue("@totalDevis", double.Parse(ds.Tables[0].Rows[0][7].ToString()));

            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.cmd.Parameters.Clear();

           



            //************************************************

            db.cmd = new SqlCommand("select nom,prenom from infoClients where code = @code", db.conn);
            db.cmd.Parameters.AddWithValue("@code", codeClientEnDevis);
            ds = new DataSet();
            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.adapt.Fill(ds);
            db.cmd.Parameters.Clear();
            

            db.cmd = new SqlCommand("update infoCrystal set nomClient = @nom,prenomClient = @prenom where codeDevis = @code", db.conn);
            db.cmd.Parameters.AddWithValue("@nom", ds.Tables[0].Rows[0][0].ToString());
            db.cmd.Parameters.AddWithValue("@prenom", ds.Tables[0].Rows[0][1].ToString());
            db.cmd.Parameters.AddWithValue("@code", codeDevisCr);

            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.cmd.Parameters.Clear();


            //******************************************

            db.cmd = new SqlCommand("select code,designation,reference from facture where idClient = @code", db.conn);
            db.cmd.Parameters.AddWithValue("@code", codeClientEnDevis);
            ds = new DataSet();
            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.adapt.Fill(ds);
            db.cmd.Parameters.Clear();

           

            db.cmd = new SqlCommand("update infoCrystal set codeFacture = @codeF , designation = @designation,reference = @reference where codeDevis = @code", db.conn);
            db.cmd.Parameters.AddWithValue("@codeF", ds.Tables[0].Rows[0][0].ToString());
            db.cmd.Parameters.AddWithValue("@designation", ds.Tables[0].Rows[0][1].ToString());
            db.cmd.Parameters.AddWithValue("@reference", ds.Tables[0].Rows[0][2].ToString());
            db.cmd.Parameters.AddWithValue("@code", codeDevisCr);

            db.adapt = new SqlDataAdapter(db.cmd);
            db.cmd.ExecuteNonQuery();
            db.cmd.Parameters.Clear();


            //***************************************

           
        }
    }
}
