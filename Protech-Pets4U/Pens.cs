using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protech_Pets4U
{
    public partial class Pens : Form
    {
        public Pens()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxBack.Size = size;
            pictureBoxBack.Location = new Point(7, 10);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f040(0)_2561.png");
            pictureBoxBack.BackgroundImage = image;
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxBack.Size = size;
            pictureBoxBack.Location = new Point(12, 12);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f040(0)_256.png");
            pictureBoxBack.BackgroundImage = image;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Clinics child = new Clinics();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelTotPensByClinicNum.Visible = true;            
            labelClinicsActivePanel.Location = new Point(480, 23);
            labelClinicsActivePanel.Text = "Total number of pens for a clinic";
        }

        private void pictureBoxTotMonthSal_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(996, 454);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e88a(0)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e88a(0)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void Pens_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet8.list_pens_available_on_given_date' table. You can move, or remove it, as needed.
            this.list_pens_available_on_given_dateTableAdapter.Fill(this.protechDataSet8.list_pens_available_on_given_date);

        }
    }
}
