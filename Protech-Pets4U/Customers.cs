using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Protech_Pets4U
{
    public partial class Customers : Form
    {
        public Customers()
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

        private void pictureBoxInsertCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxInsertCustomer.Size = size;
            pictureBoxInsertCustomer.Location = new Point(846, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f037(4)_2561.png");
            pictureBoxInsertCustomer.BackgroundImage = image;
        }

        private void pictureBoxInsertCustomer_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxInsertCustomer.Size = size;
            pictureBoxInsertCustomer.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f037(4)_256.png");
            pictureBoxInsertCustomer.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_256.png");
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

        private void pictureBoxInsertCustomer_Click(object sender, EventArgs e)
        {
            panelPetOwnerBetweenDates.Visible = false;
            panelViewPetOwnerWithPetDetails.Visible = false;
            panelVetsInsertPetOwner.Visible = true;
            labelClinicsActivePanel.Location = new Point(570, 23);
            labelClinicsActivePanel.Text = "Insert a pet owner";
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelPetOwnerBetweenDates.Visible = true;
            panelViewPetOwnerWithPetDetails.Visible = false;
            panelVetsInsertPetOwner.Visible = false;
            labelClinicsActivePanel.Location = new Point(400, 23);
            labelClinicsActivePanel.Text = "Details of pet owners between dates";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelPetOwnerBetweenDates.Visible = false;
            panelViewPetOwnerWithPetDetails.Visible = true;
            panelVetsInsertPetOwner.Visible = false;
            labelClinicsActivePanel.Location = new Point(400, 23);
            labelClinicsActivePanel.Text = "Names of pet owners with pet details";
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            tabControlInsertEmployee.SelectedTab = tabPageStep2Of2;
        }

        private void pictureBoxDone_Click(object sender, EventArgs e)
        {
            tabControlInsertEmployee.SelectedTab = tabPageStep1Of2;
        }

        private void pictureBoxNext_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBoxNext.Size = size;
            pictureBoxNext.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_2561.png");
            pictureBoxNext.BackgroundImage = image;
        }

        private void pictureBoxNext_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBoxNext.Size = size;
            pictureBoxNext.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_256.png");
            pictureBoxNext.BackgroundImage = image;
        }

        private void pictureBoxDone_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBoxDone.Size = size;
            pictureBoxDone.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBoxDone.BackgroundImage = image;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet.list_names_of_pet_owners_with_pet_details' table. You can move, or remove it, as needed.
            this.list_names_of_pet_owners_with_pet_detailsTableAdapter.Fill(this.protechDataSet.list_names_of_pet_owners_with_pet_details);

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //string stDate = dateTimePickerStart.Text;
            //string endDate = dateTimePickerEnd.Text;

            //MessageBox.Show(stDate);

            /*DataTable dt = new DataTable();
            String conStr = "server=196.253.61.51;user id=root;password=inteltechs;persistsecurityinfo=True;database=protech";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand com = new SqlCommand("list_details_of_pet_owners_between_dates", con);
            com.Parameters.AddWithValue("@start_date", stDate);
            com.Parameters.AddWithValue("@end_date", endDate);           
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            try
            {
                con.Open();
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            dataGridViewBetweenDates.DataSource = dt;
            //dataGridViewBetweenDates.;*/
        }
    }
}
