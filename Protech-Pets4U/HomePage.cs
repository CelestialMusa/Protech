using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Protech_Pets4U
{
    public partial class HomePage : Form
    {
        StreamReader inputStream;
        string[] a = new string[7];
        List<ClassUsers> array = new List<ClassUsers>();

        ClassUsers user;
        string selecteduser = "";
        string password = "";
        string answer = "";
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxExitHome_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(120, 81);
            pictureBoxExitHome.Size = size;
            pictureBoxExitHome.Location = new Point(1024, 1);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f011(0)_256.png");
            pictureBoxExitHome.BackgroundImage = image;
        }

        private void pictureBoxExitHome_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(110, 71);
            pictureBoxExitHome.Size = size;
            pictureBoxExitHome.Location = new Point(1031, 3);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\FontAwesome_f011(0)_2561.png");
            pictureBoxExitHome.BackgroundImage = image;
        }

        private void pictureBoxExitHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you realy want exit the system?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabelHavingTrouble_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelHomeHavingTrouble.Visible = true;
            panelHomeInformation.Visible = false;

            comboBoxHomeHavingTroubleUserName.SelectedItem = null;
            labelHomeHavingTroubleQuestion.Text = "Select a user to retrieve password.";
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            panelHomeHavingTrouble.Visible = false;
            panelHomeInformation.Visible = true;

            inputStream = File.OpenText("C:\\Protech-Pets4U\\Files\\Users.txt");

            string line;
            int count = 0;

            line = inputStream.ReadLine();

            while (line != null)
            {
                a = line.Split(',');

                string typeUser = a[0];
                string name = a[1];
                string lastName = a[2];
                string userName = a[3];
                string password = a[4];
                string question = a[5];
                string answer = a[6];

                array.Add(user = new ClassUsers(typeUser, name, lastName, userName, password, question, answer));

                line = inputStream.ReadLine();
                count++;
            }
            inputStream.Close();

            for (int i = 0; i < array.Count; i++)
            {
                comboBoxHomeUserNames.Items.Add(array[i].getUserName());
                comboBoxHomeHavingTroubleUserName.Items.Add(array[i].getUserName());
            }
        }

        private void buttonHomeHavingTroubleSubmitAnswer_Click(object sender, EventArgs e)
        {
            selecteduser = comboBoxHomeHavingTroubleUserName.SelectedIndex.ToString();

            if (!(textBoxHomeHavingTroubleAnswer.Text == ""))
            {
                password = array[Convert.ToInt32(selecteduser)].getPassword();
                answer = array[Convert.ToInt32(selecteduser)].getAnswer();

                if (answer.Equals(textBoxHomeHavingTroubleAnswer.Text))
                {
                    MessageBox.Show("Your password is: " + password,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBoxHomeHavingTroubleAnswer.Clear();

                    panelHomeHavingTrouble.Visible = false;
                    panelHomeInformation.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your answer is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxHomeHavingTroubleAnswer.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter an answer.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonHomeLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = comboBoxHomeUserNames.SelectedItem.ToString();
                string arrayUser;

                for (int i = 0; i < array.Count; i++)
                {
                    if ((arrayUser = array[i].getUserName()).Equals(user))
                    {
                        if (textBoxHomePassword.Text == array[i].getPassword())
                        {
                            PanelWindow.PopDISP(i, array[i].getName(), array[i].getLastName(), array[i].getUserName(), array[i].getTypeUser());

                            PanelWindow child1 = new PanelWindow();
                            ActiveForm.Hide();
                            child1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxHomePassword.Text = "";
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user to proceed", "Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBoxHomeHavingTroubleUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user;

            for (int i = 0; i < array.Count; i++)
            {
                user = array[i].getUserName();
                try
                {
                    if (user.Equals(comboBoxHomeHavingTroubleUserName.SelectedItem.ToString()))
                    {
                        labelHomeHavingTroubleQuestion.Text = array[i].getQuestion() + "? (Note answer is case sensitive)";
                    }
                }
                catch(Exception)
                {

                }
            }
        }
    }
}
