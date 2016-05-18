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
    public partial class Treatments : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;
        MySqlDataAdapter adapter;

        public Treatments()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();            
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
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_2561.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
        }

        private void pictureBoxTotMonthSal_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxTotMonthSal.Size = size;
            pictureBoxTotMonthSal.Location = new Point(1006, 456);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_256.png");
            pictureBoxTotMonthSal.BackgroundImage = image;
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

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelDetailOfTreatmentToPet.Visible = true;
            panelMinMaxAverageCost.Visible = false;
            labelClinicsActivePanel.Location = new Point(460, 23);
            labelClinicsActivePanel.Text = "Details of a treatment to a pet";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelDetailOfTreatmentToPet.Visible = false;
            panelMinMaxAverageCost.Visible = true;
            labelClinicsActivePanel.Location = new Point(380, 23);
            labelClinicsActivePanel.Text = "Min, Max and average cost of treatment";
        }

        private void Treatments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet27.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.protechDataSet27.pet);
            // TODO: This line of code loads data into the 'protechDataSet12.list_max_min_average_cost_of_treatments' table. You can move, or remove it, as needed.
            this.list_max_min_average_cost_of_treatmentsTableAdapter1.Fill(this.protechDataSet12.list_max_min_average_cost_of_treatments);
            // TODO: This line of code loads data into the 'protechDataSet4.list_max_min_average_cost_of_treatments' table. You can move, or remove it, as needed.
            this.list_max_min_average_cost_of_treatmentsTableAdapter.Fill(this.protechDataSet4.list_max_min_average_cost_of_treatments);

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {

                int pet = (int)comboBoxPet.SelectedValue;

                String SQLQuery = "call protech.list_details_of_treatment_to_pet(" + pet + ");";
                command = new MySqlCommand(SQLQuery, connection);
                adapter = new MySqlDataAdapter(command);
                connection.Open();

                command.ExecuteNonQuery();
                myDataTable = new DataTable();
                adapter.Fill(myDataTable);
               
                dataGridViewtopet.Columns.Add("Treatment description", "Treatment description");
                dataGridViewtopet.Columns.Add("Treatment quantity", "Treatment quantity");
                dataGridViewtopet.Columns.Add("Comment", "Comment");
                dataGridViewtopet.Columns.Add("Begin date", "Begin date");
                dataGridViewtopet.Columns.Add("End date", "End date");

                for (int i = 0; i < myDataTable.Rows.Count; i++)
                {
                    String[] values = { myDataTable.Rows[i][0].ToString(), myDataTable.Rows[i][1].ToString(), myDataTable.Rows[i][2].ToString(), myDataTable.Rows[i][3].ToString(), myDataTable.Rows[i][4].ToString(), /*myDataTable.Rows[i][5].ToString()*/};
                    dataGridViewtopet.Rows.Add(values);
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
