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
    public partial class Employee : Form
    {
        string connectionstring = @"server=196.253.61.51;user id=root;password=inteltechs;persistsecurityinfo=True;database=protech";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;

        public Employee()
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

        private void pictureBoxTotMonthSal_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(996, 454);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f155(0)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f155(0)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f132(1)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f132(1)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxInsertClinic_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxInsertClinic.Size = size;
            pictureBoxInsertClinic.Location = new Point(702, 522);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0f1(2)_256.png");
            pictureBoxInsertClinic.BackgroundImage = image;
        }

        private void pictureBoxInsertClinic_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxInsertClinic.Size = size;
            pictureBoxInsertClinic.Location = new Point(711, 524);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0f1(2)_2561.png");
            pictureBoxInsertClinic.BackgroundImage = image;
        }

        private void pictureInsertEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureInsertEmployee.Size = size;
            pictureInsertEmployee.Location = new Point(555, 545);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\icomoon_e656(1)_2561.png");
            pictureInsertEmployee.BackgroundImage = image;
        }

        private void pictureInsertEmployee_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureInsertEmployee.Size = size;
            pictureInsertEmployee.Location = new Point(562, 547);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\icomoon_e656(1)_256.png");
            pictureInsertEmployee.BackgroundImage = image;
        }

        private void pictureInsertEmployee_Click(object sender, EventArgs e)
        {
            panelClinicInsertEmployee.Visible = true;
            panelVetsNursesOver50.Visible = false;
            panelTotMonthlySal.Visible = false;
            panelClinicManagers.Visible = false;
            labelClinicsActivePanel.Location = new Point(570, 40);
            labelClinicsActivePanel.Text = "Insert an Employee";
        }

        private void pictureBoxInsertClinic_Click(object sender, EventArgs e)
        {
            panelClinicInsertEmployee.Visible = false;
            panelVetsNursesOver50.Visible = true;
            panelTotMonthlySal.Visible = false;
            panelClinicManagers.Visible = false;
            labelClinicsActivePanel.Location = new Point(500, 40);
            labelClinicsActivePanel.Text = "Vets and nurses over 50 years";
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelClinicInsertEmployee.Visible = false;
            panelVetsNursesOver50.Visible = false;
            panelTotMonthlySal.Visible = false;
            panelClinicManagers.Visible = true;
            labelClinicsActivePanel.Location = new Point(540, 40);
            labelClinicsActivePanel.Text = "Clinic managers";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelClinicInsertEmployee.Visible = false;
            panelVetsNursesOver50.Visible = false;
            panelTotMonthlySal.Visible = true;
            panelClinicManagers.Visible = false;
            labelClinicsActivePanel.Location = new Point(500, 40);
            labelClinicsActivePanel.Text = "Total monthly salary of staff";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_2561.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_256.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_2561.png");
            pictureBox3.BackgroundImage = image;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0da(0)_256.png");
            pictureBox3.BackgroundImage = image;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            /*Size size = new Size(77, 64);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(549, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox4.BackgroundImage = image;*/
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControlInsertEmployee.SelectedTab = tabPageStep2Of3;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControlInsertEmployee.SelectedTab = tabPage3Of3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
            string job = (string)comboBoxJobDescription.SelectedItem;

            

            string salary = textBoxSalary.Text;
            int clinic_id = 2;//(int)comboBoxClinicID.SelectedItem;
            string state = textBoxState.Text;
            string city = textBoxCity.Text;
            string street = textBoxStreet.Text;
            string zip = textBoxZipCode.Text;

            if (radioButtonInsert.Checked)
            {
                insert_staff(name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if (radioButtonUdate.Checked)
            {
                int staff_num = (int)comboBoxEmployeeToBeMaintained.SelectedValue;
                //update_employee(staff_num, name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if (radioButtonDelete.Checked)
            {
                int staff_num = (int)comboBoxEmployeeToBeMaintained.SelectedValue;
                //Delete
            }
            tabControlInsertEmployee.SelectedTab = tabPageStep1Of3;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet7.list_names_staff_numbers_for_vets_nurses_over_50_years' table. You can move, or remove it, as needed.
            this.list_names_staff_numbers_for_vets_nurses_over_50_yearsTableAdapter.Fill(this.protechDataSet7.list_names_staff_numbers_for_vets_nurses_over_50_years);
            // TODO: This line of code loads data into the 'protechDataSet6.view_clinic_managers' table. You can move, or remove it, as needed.
            this.view_clinic_managersTableAdapter.Fill(this.protechDataSet6.view_clinic_managers);
            // TODO: This line of code loads data into the 'protechDataSet5.total_monthly_salary_for_staff' table. You can move, or remove it, as needed.
            this.total_monthly_salary_for_staffTableAdapter.Fill(this.protechDataSet5.total_monthly_salary_for_staff);

        }

        private void insert_staff(string name, string last, string gender, string dob, string tel,
                                    string id, string job, string salary, int clinic_id, string state,
                                    string city, string street, string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_Staff_Member";
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
                command.Parameters.Add(new MySqlParameter("@staff_position", MySqlDbType.VarChar)).Value = job;
                command.Parameters.Add(new MySqlParameter("@staff_salary", MySqlDbType.Double)).Value = salary;
                
                

                reader = command.ExecuteReader();
                MessageBox.Show("The employee has been successfuly been registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee registration has failed please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBoxClinicID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3Of3_Click(object sender, EventArgs e)
        {

        }
    }
}
