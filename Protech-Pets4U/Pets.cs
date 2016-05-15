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
    public partial class Pets : Form
    {
        public Pets()
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

        private void pictureBoxInsertCustomer_Click(object sender, EventArgs e)
        {
            panelVetsInsertPet.Visible = true;
            panelViewTotalNumberPetsInEachType.Visible = false;
            panelListPetsOwnedByParticularOwner.Visible = false;
            labelClinicsActivePanel.Location = new Point(570, 23);
            labelClinicsActivePanel.Text = "Insert a Pet";
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelVetsInsertPet.Visible = false;
            panelViewTotalNumberPetsInEachType.Visible = true;
            panelListPetsOwnedByParticularOwner.Visible = false;
            labelClinicsActivePanel.Location = new Point(400, 23);
            labelClinicsActivePanel.Text = "Total number of pets per type";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelVetsInsertPet.Visible = false;
            panelViewTotalNumberPetsInEachType.Visible = false;
            panelListPetsOwnedByParticularOwner.Visible = true;
            labelClinicsActivePanel.Location = new Point(400, 23);
            labelClinicsActivePanel.Text = "Pets owned by particular owner";
        }

        private void pictureBoxInsertCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxInsertCustomer.Size = size;
            pictureBoxInsertCustomer.Location = new Point(702, 522);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0b2(5)_2561.png");
            pictureBoxInsertCustomer.BackgroundImage = image;
        }

        private void pictureBoxInsertCustomer_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxInsertCustomer.Size = size;
            pictureBoxInsertCustomer.Location = new Point(711, 524);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0b2(5)_256.png");
            pictureBoxInsertCustomer.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(996, 454);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f092(0)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f092(0)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxNext_MouseMove(object sender, MouseEventArgs e)
        {
            /*Size size = new Size(77, 64);
            pictureBoxNext.Size = size;
            pictureBoxNext.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_2561.png");
            pictureBoxNext.BackgroundImage = image;*/
        }

        private void pictureBoxNext_MouseLeave(object sender, EventArgs e)
        {
            /*Size size = new Size(67, 54);
            pictureBoxNext.Size = size;
            pictureBoxNext.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_256.png");
            pictureBoxNext.BackgroundImage = image;*/
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            //tabControlInsertEmployee.SelectedTab = tabPageStep2Of3;
        }

        private void pictureBoxDone_MouseMove(object sender, MouseEventArgs e)
        {
            /*Size size = new Size(77, 64);
            pictureBoxDone.Size = size;
            pictureBoxDone.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBoxDone.BackgroundImage = image;*/
        }

        private void pictureBoxDone_MouseLeave(object sender, EventArgs e)
        {
            /*Size size = new Size(67, 54);
            pictureBoxDone.Size = size;
            pictureBoxDone.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBoxDone.BackgroundImage = image;*/
        }

        private void pictureBoxDone_Click(object sender, EventArgs e)
        {
            //tabControlInsertEmployee.SelectedTab = tabPageStep1Of1;
        }

        private void pictureBoxDone_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxDone_MouseMove_1(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBoxDone.Size = size;
            pictureBoxDone.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBoxDone.BackgroundImage = image;
        }

        private void pictureBoxDone_MouseLeave_1(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBoxDone.Size = size;
            pictureBoxDone.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBoxDone.BackgroundImage = image;
        }

        private void Pets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet11.total_number_pets_in_each_type' table. You can move, or remove it, as needed.
            this.total_number_pets_in_each_typeTableAdapter.Fill(this.protechDataSet11.total_number_pets_in_each_type);

        }
    }
}
