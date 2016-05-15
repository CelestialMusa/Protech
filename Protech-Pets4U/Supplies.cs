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
    public partial class Supplies : Form
    {
        public Supplies()
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
            PanelWindow child = new PanelWindow();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e548(0)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e548(0)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(996, 454);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e0d2(2)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e0d2(2)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelTotCostSurgNonSurgeSup.Visible = true;
            panelPharmToBeReOrdered.Visible = false;
            labelClinicsActivePanel.Location = new Point(290, 23);
            labelClinicsActivePanel.Text = "Cost of surgical and non surgical supplies";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelTotCostSurgNonSurgeSup.Visible = false;
            panelPharmToBeReOrdered.Visible = true;
            labelClinicsActivePanel.Location = new Point(150, 23);
            labelClinicsActivePanel.Text = "Pharmaceutical supplies to be reordered by each clinic";
        }

        private void Supplies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet13.list_pharm_supplies_to_be_reordered_at_each_clinic' table. You can move, or remove it, as needed.
            this.list_pharm_supplies_to_be_reordered_at_each_clinicTableAdapter1.Fill(this.protechDataSet13.list_pharm_supplies_to_be_reordered_at_each_clinic);
            // TODO: This line of code loads data into the 'protechDataSet10.total_cost_of_surgical_non_surgical_supplies_in_stock' table. You can move, or remove it, as needed.
            this.total_cost_of_surgical_non_surgical_supplies_in_stockTableAdapter.Fill(this.protechDataSet10.total_cost_of_surgical_non_surgical_supplies_in_stock);
            // TODO: This line of code loads data into the 'protechDataSet9.list_pharm_supplies_to_be_reordered_at_each_clinic' table. You can move, or remove it, as needed.
            this.list_pharm_supplies_to_be_reordered_at_each_clinicTableAdapter.Fill(this.protechDataSet9.list_pharm_supplies_to_be_reordered_at_each_clinic);

        }
    }
}
