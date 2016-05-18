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
    public partial class Invoices : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=protech; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;
        MySqlDataAdapter adapter;

        public Invoices()
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

        private void pictureBoxClinicDetails_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(119, 98);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(847, 487);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e6dc(0)_256.png");
            pictureBoxClinicDetails.BackgroundImage = image;
        }

        private void pictureBoxClinicDetails_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(109, 88);
            pictureBoxClinicDetails.Size = size;
            pictureBoxClinicDetails.Location = new Point(854, 489);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e6dc(0)_258.png");
            pictureBoxClinicDetails.BackgroundImage = image;
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

        private void pictureBoxClinicDetails_Click(object sender, EventArgs e)
        {
            panelDetailsOfUnpaidInvoiceForPetOwner.Visible = true;
            panelInvoicesNotPaidByGivenDate.Visible = false;           
            labelClinicsActivePanel.Location = new Point(490, 23);
            labelClinicsActivePanel.Text = "Unpaid invoice for pet owner";
        }

        private void pictureBoxTotMonthSal_Click(object sender, EventArgs e)
        {
            panelDetailsOfUnpaidInvoiceForPetOwner.Visible = false;
            panelInvoicesNotPaidByGivenDate.Visible = true;
            labelClinicsActivePanel.Location = new Point(500, 23);
            labelClinicsActivePanel.Text = "Unpaid invoice by date";
        }

        private void buttonGoInvByPetOwner_Click(object sender, EventArgs e)
        {
            try
            {

                int owner = (int)comboBoxPetOwner.SelectedValue;

                String SQLQuery = "call protech.list_details_of_unpaid_invoice_for_pet_owner(" + owner + ");";
                command = new MySqlCommand(SQLQuery, connection);
                adapter = new MySqlDataAdapter(command);
                connection.Open();

                command.ExecuteNonQuery();
                myDataTable = new DataTable();
                adapter.Fill(myDataTable);

                dataGridViewPetOwner.Columns.Add("Treatment description", "Treatment description");
                dataGridViewPetOwner.Columns.Add("Treatment quantity", "Treatment quantity");
                dataGridViewPetOwner.Columns.Add("Comment", "Comment");
                dataGridViewPetOwner.Columns.Add("Begin date", "Begin date");
                dataGridViewPetOwner.Columns.Add("End date", "End date");

                for (int i = 0; i < myDataTable.Rows.Count; i++)
                {
                    String[] values = { myDataTable.Rows[i][0].ToString(), myDataTable.Rows[i][1].ToString(), myDataTable.Rows[i][2].ToString(), myDataTable.Rows[i][3].ToString(), myDataTable.Rows[i][4].ToString(), /*myDataTable.Rows[i][5].ToString()*/};
                    dataGridViewPetOwner.Rows.Add(values);
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

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protechDataSet28.list_names_of_pet_owners_with_pet_details' table. You can move, or remove it, as needed.
            this.list_names_of_pet_owners_with_pet_detailsTableAdapter.Fill(this.protechDataSet28.list_names_of_pet_owners_with_pet_details);

        }

        private void buttonGoInvBydate_Click(object sender, EventArgs e)
        {
            try
            {

                string date = dateTimePickerInvoiceDate.Value.ToShortDateString();

                string a = date.Substring(0, 4);
                string b = date.Substring(5, 2);
                string c = date.Substring(8, 2);

                string date2 = a + "-" + b + "-" + c;

                MessageBox.Show(date2); 

                String SQLQuery = "call protech.list_invoices_not_paid_by_given_date(" + date + ");";
                command = new MySqlCommand(SQLQuery, connection);
                adapter = new MySqlDataAdapter(command);
                connection.Open();

                command.ExecuteNonQuery();
                myDataTable = new DataTable();
                adapter.Fill(myDataTable);

                dataGridViewByDate.Columns.Add("Owner address", "Owner address");
                dataGridViewByDate.Columns.Add("Pet number", "Pet number");
                dataGridViewByDate.Columns.Add("Pet name", "Comment");
                dataGridViewByDate.Columns.Add("Begin date", "Begin date");
                dataGridViewByDate.Columns.Add("End date", "End date");

                dataGridViewByDate.Columns.Add("Treatment description", "Treatment description");
                dataGridViewByDate.Columns.Add("Treatment quantity", "Treatment quantity");
                dataGridViewByDate.Columns.Add("Comment", "Comment");
                dataGridViewByDate.Columns.Add("Begin date", "Begin date");
                dataGridViewByDate.Columns.Add("End date", "End date");

                dataGridViewByDate.Columns.Add("Treatment description", "Treatment description");
                dataGridViewByDate.Columns.Add("Treatment quantity", "Treatment quantity");
                dataGridViewByDate.Columns.Add("Comment", "Comment");
                dataGridViewByDate.Columns.Add("Begin date", "Begin date");
                dataGridViewByDate.Columns.Add("End date", "End date");

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
