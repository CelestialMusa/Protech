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
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;

        public Customers()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
            comboBoxEmployeeToBeMaintained.Enabled = false;
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
            string name = textBoxFirstName.Text;
            string last = textBoxLastName.Text;
            string gender;
            if (comboBoxGender.SelectedText == "Male")
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string dob = dateTimePickerDateOfBirth.Value.ToShortDateString();
            string tel = textBoxTelNum.Text;
            string id = textBoxIDNumber.Text;
                        
            int clinic_id = (int)comboBoxClinicID.SelectedValue;
            string state = textBoxState.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            string zip = textBoxZipCode.Text;
            

            if (radioButtonInsert.Checked)
            {                
                comboBoxEmployeeToBeMaintained.Enabled = false;
                insert_Customer(name, last, gender, dob, tel, id, clinic_id, state, city, street, zip);
            }
            else if (radioButtonUpdate.Checked)
            {
                int owner = (int)comboBoxEmployeeToBeMaintained.SelectedValue;
                comboBoxEmployeeToBeMaintained.Enabled = true;
                update_Customer(name, last, gender, dob, tel, id, clinic_id, state, city, street, zip, owner);
            }
            else if (radioButtonDelete.Checked)
            {
                int owner = (int)comboBoxEmployeeToBeMaintained.SelectedValue;
                comboBoxEmployeeToBeMaintained.Enabled = true;
                delete_customer(owner);
            }

            tabControlInsertEmployee.SelectedTab = tabPageStep1Of2;
        }

        private void delete_customer(int app_num)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "delete_pet_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@own_num", MySqlDbType.Int32)).Value = app_num;

                reader = command.ExecuteReader();
                MessageBox.Show("The pet owner has successfuly been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //comboBoxPet.SelectedIndex = null;
                //comboBoxPetOwner.SelectedIndex = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet owner deletion has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
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
            // TODO: This line of code loads data into the 'protechDataSet15.clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.protechDataSet15.clinic);
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

        private void update_Customer(string name, string last, string gender, string dob, string tel,
                                    string id, int clinic_id, string state,
                                    string city, string street, string zip, int owner)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update_pet_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zip_code", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@id_num", MySqlDbType.VarChar)).Value = id;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = name;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = last;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.VarChar)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@tel_num", MySqlDbType.VarChar)).Value = tel;
                command.Parameters.Add(new MySqlParameter("@clinic", MySqlDbType.Int32)).Value = clinic_id;
                command.Parameters.Add(new MySqlParameter("@owner_number", MySqlDbType.Int32)).Value = owner;


                reader = command.ExecuteReader();
                MessageBox.Show("The Pet owner has been successfuly Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxIDNumber.Text = "";
                textBoxState.Text = "";
                textBoxStreet.Text = "";
                textBoxTelNum.Text = "";
                textBoxCity.Text = "";
                textBoxZipCode.Text = "";
                comboBoxClinicID.SelectedItem = null;
                comboBoxGender.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet owner update has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void insert_Customer(string name, string last, string gender, string dob, string tel,
                                    string id, int clinic_id, string state,
                                    string city, string street, string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_pet_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zip_code", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@id_num", MySqlDbType.VarChar)).Value = id;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = name;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = last;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.VarChar)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@tel_num", MySqlDbType.VarChar)).Value = tel;
                command.Parameters.Add(new MySqlParameter("@clinic", MySqlDbType.Int32)).Value = clinic_id; 


                reader = command.ExecuteReader();
                MessageBox.Show("The Pet owner has been successfuly been registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxIDNumber.Text = "";                
                textBoxState.Text = "";
                textBoxStreet.Text = "";
                textBoxTelNum.Text = "";
                textBoxCity.Text = "";
                textBoxZipCode.Text = "";
                comboBoxClinicID.SelectedItem = null;
                comboBoxGender.SelectedItem = null;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pet owner registration has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxEmployeeToBeMaintained.Enabled = true;
            }
        }

        private void comboBoxEmployeeToBeMaintained_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
