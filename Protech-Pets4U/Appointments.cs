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
    public partial class Appointments : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;
        MySqlDataAdapter adapter;

        public Appointments()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
            comboBoxAppointmentToMaintain.Enabled = false;
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
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e062(0)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e062(0)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelCreateAppointment.Visible = true;
            panelAppointmentForDate.Visible = false;
            labelClinicsActivePanel.Location = new Point(500, 23);
            labelClinicsActivePanel.Text = "Create an appointment";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelCreateAppointment.Visible = false;
            panelAppointmentForDate.Visible = true;
            labelClinicsActivePanel.Location = new Point(410, 23);
            labelClinicsActivePanel.Text = "Appointments for a given date";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(552, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int pet = (int)comboBoxPet.SelectedValue;
            int pet_owner = (int)comboBoxPetOwner.SelectedValue;
            int clinic = (int)comboBoxClinic.SelectedValue;
            string date = dateTimePickerAppDate.Value.ToShortDateString();

            if (radioButtonInsert.Checked)
            {
                insert_appointment(pet, pet_owner, clinic, date);
            }
            else if (radioButtonUpdate.Checked)
            {
                int staff_num = (int)comboBoxAppointmentToMaintain.SelectedValue;
                //update_employee(staff_num, name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if (radioButtonDelete.Checked)
            {
                int staff_num = (int)comboBoxAppointmentToMaintain.SelectedValue;
                //Delete
            }
        }

        private void insert_appointment(int pet, int pet_owner, int clinic, string date)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "create_appointment";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@appdate", MySqlDbType.Timestamp)).Value = date;
                command.Parameters.Add(new MySqlParameter("@pet_number", MySqlDbType.Int32)).Value = pet;
                command.Parameters.Add(new MySqlParameter("@clinic_number", MySqlDbType.Int32)).Value = clinic;
                command.Parameters.Add(new MySqlParameter("@owner_number", MySqlDbType.Int32)).Value = pet_owner;

                reader = command.ExecuteReader();
                MessageBox.Show("The appointment has been successfuly been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //comboBoxPet.SelectedIndex = null;
                //comboBoxPetOwner.SelectedIndex = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Appointment registration has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet25.clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.protechDataSet25.clinic);
            // TODO: This line of code loads data into the 'protechDataSet24.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.protechDataSet24.person);
            // TODO: This line of code loads data into the 'protechDataSet23.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.protechDataSet23.pet);

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {

                string date = dateTimePickerAppByGivenDate.Value.ToShortDateString();
                int clinic = (int)comboBoxClinic.SelectedValue;
               
                String SQLQuery = "call protech.list_appointments_for_clinic_and_date(" + date + "," + clinic + ");";
                command = new MySqlCommand(SQLQuery, connection);
                adapter = new MySqlDataAdapter(command);
                connection.Open();

                command.ExecuteNonQuery();
                myDataTable = new DataTable();
                adapter.Fill(myDataTable);



                dataGridViewByDate.Columns.Add("Examination number", "Examination number");
                dataGridViewByDate.Columns.Add("Examination date", "Examination date");
                dataGridViewByDate.Columns.Add("Pet number", "Pet number");
                dataGridViewByDate.Columns.Add("Pet Name", "Pet Namer");
                dataGridViewByDate.Columns.Add("Pet Typer", "Pet Typer");
                dataGridViewByDate.Columns.Add("Treatment Numberr", "Treatment Number");
                dataGridViewByDate.Columns.Add("Treatment Description", "Treatment Description");
                dataGridViewByDate.Columns.Add("Treatment Quantity", "Treatment Quantity");
                dataGridViewByDate.Columns.Add("Start Date", "Start Date");
                dataGridViewByDate.Columns.Add("End Date", "End Date");
                dataGridViewByDate.Columns.Add("Treatment Comments", "Treatment Comments");

                for (int i = 0; i < myDataTable.Rows.Count; i++)
                {
                    String[] values = { myDataTable.Rows[i][0].ToString(), myDataTable.Rows[i][1].ToString(), myDataTable.Rows[i][2].ToString(), myDataTable.Rows[i][3].ToString(), myDataTable.Rows[i][4].ToString(), myDataTable.Rows[i][5].ToString(), myDataTable.Rows[i][6].ToString(), myDataTable.Rows[i][7].ToString(), myDataTable.Rows[i][8].ToString(), myDataTable.Rows[i][9].ToString(), myDataTable.Rows[i][10].ToString(), };
                    dataGridViewByDate.Rows.Add(values);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
