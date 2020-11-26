using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public Form3()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void factureButton(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clientButton(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void quitterButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void metroPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void metroPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }
    }
}
