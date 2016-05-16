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
    public partial class Examinations : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;

        public Examinations()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
            comboBoxExamToUpdate.Enabled = false;
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
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0f1(2)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f0f1(2)_2561.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelinsertExam.Visible = true;
            panelHistExam.Visible = false;
            labelClinicsActivePanel.Location = new Point(380, 23);
            labelClinicsActivePanel.Text = "Insert an examination for a pet";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelinsertExam.Visible = false;
            panelHistExam.Visible = true;
            labelClinicsActivePanel.Location = new Point(420, 23);
            labelClinicsActivePanel.Text = "Historical pet examinations";
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            /*Size size = new Size(77, 64);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(563, 280);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBox4.BackgroundImage = image;*/
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            /*Size size = new Size(67, 54);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(570, 282);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox4.BackgroundImage = image;*/
        }

        private void pictureBox4_MouseMove_1(object sender, MouseEventArgs e)
        {
            Size size = new Size(77, 64);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(550, 258);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_256.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            Size size = new Size(67, 54);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(559, 260);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f00c(0)_2561.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {              
            string start_date = dateTimePickerBeginDate.Value.ToShortDateString();
            string end_date = dateTimePickerEndDate.Value.ToShortDateString();
            int staff = (int)comboBoxStaff.SelectedValue;
            int pet = (int)comboBoxPet.SelectedValue;
            string results = textBoxResults.Text;

            if (radioButtonInsert.Checked)
            {
                insert_Examination(start_date, end_date, staff, pet, results);
            }
            else if (radioButtonUpdate.Checked)
            {
                int staff_num = (int)comboBoxExamToUpdate.SelectedValue;
                //update_employee(staff_num, name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if (radioButtonDelete.Checked)
            {
                int staff_num = (int)comboBoxExamToUpdate.SelectedValue;
                //Delete
            }
        }

        private void insert_Examination(string start_date, string end_date, int staff, int pet, string results)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_pet_examination";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@start_treatment", MySqlDbType.Date)).Value = start_date;
                command.Parameters.Add(new MySqlParameter("@end_treatment", MySqlDbType.Date)).Value = end_date;
                command.Parameters.Add(new MySqlParameter("@staff", MySqlDbType.Int32)).Value = staff;
                command.Parameters.Add(new MySqlParameter("@pet", MySqlDbType.Int32)).Value = pet;
                command.Parameters.Add(new MySqlParameter("@exam_results", MySqlDbType.MediumText)).Value = results;

                reader = command.ExecuteReader();
                MessageBox.Show("The Examination has been successfuly added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxResults.Text = "";               
                comboBoxPet.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Examination has failed please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Examinations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet22.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.protechDataSet22.pet);
            // TODO: This line of code loads data into the 'protechDataSet21.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.protechDataSet21.person);

        }

        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
        }

        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = false;
            }
            else if (radioButtonDelete.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
            else if (radioButtonUpdate.Checked == true)
            {
                comboBoxExamToUpdate.Enabled = true;
            }
        }
    }
}
