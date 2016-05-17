using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Protech_Pets4U
{
    public partial class Clinics : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;

        public Clinics()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
            comboBoxClinicToBeMaintained.Enabled = false;
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

        private void pictureBoxInsertClinic_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxInsertClinic.Size = size;
            pictureBoxInsertClinic.Location = new Point(702, 522);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Entypo_d83d(0)_256.png");
            pictureBoxInsertClinic.BackgroundImage = image;           
        }

        private void pictureBoxInsertClinic_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxInsertClinic.Size = size;
            pictureBoxInsertClinic.Location = new Point(711, 524);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Entypo_d83d(0)_2561.png");
            pictureBoxInsertClinic.BackgroundImage = image;            
        }

        private void pictureBoxInsertClinic_Click(object sender, EventArgs e)
        {
            panelClinicInsert.Visible = true;
            panelClinicViewClinicDetails.Visible = false;
            panelViewClinicManagers.Visible = false;
            labelClinicsActivePanel.Text = "Insert a clinic";
        }

        private void pictureBoxListClinics_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxListClinics.Size = size;
            pictureBoxListClinics.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f01c(0)_2561.png");
            pictureBoxListClinics.BackgroundImage = image;
        }

        private void pictureBoxListClinics_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxListClinics.Size = size;
            pictureBoxListClinics.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f01c(0)_256.png");
            pictureBoxListClinics.BackgroundImage = image;
        }

        private void pictureBoxViewClinicManagers_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxViewClinicManagers.Size = size;
            pictureBoxViewClinicManagers.Location = new Point(996, 454);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0e8(0)_256.png");
            pictureBoxViewClinicManagers.BackgroundImage = image;
           
        }

        private void pictureBoxViewClinicManagers_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxViewClinicManagers.Size = size;
            pictureBoxViewClinicManagers.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0e8(0)_2561.png");
            pictureBoxViewClinicManagers.BackgroundImage = image;
        }

        private void pictureBoxListClinics_Click(object sender, EventArgs e)
        {
            panelClinicInsert.Visible = false;
            panelClinicViewClinicDetails.Visible = true;
            panelViewClinicManagers.Visible = false;
            labelClinicsActivePanel.Text = "List clinic details";
        }

        private void pictureBoxViewClinicManagers_Click(object sender, EventArgs e)
        {
            panelClinicInsert.Visible = false;
            panelClinicViewClinicDetails.Visible = false;
            panelViewClinicManagers.Visible = true;
            labelClinicsActivePanel.Text = "View clinic managers";
        }

        private void pictureBoxpens_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxpens.Size = size;
            pictureBoxpens.Location = new Point(555, 545);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e88a(0)_2561.png");
            pictureBoxpens.BackgroundImage = image;
        }

        private void pictureBoxpens_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxpens.Size = size;
            pictureBoxpens.Location = new Point(562, 547);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e88a(0)_256.png");
            pictureBoxpens.BackgroundImage = image;
        }

        private void pictureBoxpens_Click(object sender, EventArgs e)
        {
            Pens child = new Pens();
            ActiveForm.Hide();
            child.Show();
        }

        private void Clinics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet3.list_clinic_details' table. You can move, or remove it, as needed.
            this.list_clinic_detailsTableAdapter.Fill(this.protechDataSet3.list_clinic_details);
            // TODO: This line of code loads data into the 'protechDataSet2.view_clinic_managers' table. You can move, or remove it, as needed.
            this.view_clinic_managersTableAdapter.Fill(this.protechDataSet2.view_clinic_managers);

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string tel = textBoxClinicTell.Text;
            string fax = textBoxClinicFax.Text;            
            string street = textBoxStreet.Text;
            string city = textBoxCity.Text;
            string state = textBoxState.Text;           
            string zipCode = textBoxZipCode.Text;
            string clinic_name = textBoxClinicname.Text;
            
            if (radioButtonInsert.Checked)
            {
                insert_Clinic(tel, fax, street, city, state, zipCode, clinic_name);
            }
            else if (radioButtonUpdate.Checked)
            {
                int staff_num = (int)comboBoxClinicToBeMaintained.SelectedValue;
                //update_employee(staff_num, name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if (radioButtonDelete.Checked)
            {
                int staff_num = (int)comboBoxClinicToBeMaintained.SelectedValue;
                //Delete
            }
        }

        private void insert_Clinic(string tel, string fax, string street, string city, string state, string zipCode, string clinic_name)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "`insert_clinic`";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@clinic_tel_num", MySqlDbType.VarChar)).Value = tel;
                command.Parameters.Add(new MySqlParameter("@clinic_fax", MySqlDbType.VarChar)).Value = fax;
                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zip_code", MySqlDbType.VarChar)).Value = zipCode;
                command.Parameters.Add(new MySqlParameter("@clinic_name", MySqlDbType.VarChar)).Value = clinic_name;

                reader = command.ExecuteReader();
                MessageBox.Show("The clinic has been successfuly been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxCity.Text = "";
                textBoxClinicFax.Text = "";
                textBoxClinicTell.Text = "";
                textBoxState.Text = "";
                textBoxStreet.Text = "";
                textBoxZipCode.Text = "";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clinic registration has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBoxState_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelState_Click(object sender, EventArgs e)
        {

        }
    }
}
