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
    public partial class SystemSettings : Form
    {
        string fileName;
        StreamWriter outputStream;

        StreamReader inputStream;
        string[] a = new string[7];
        List<ClassUsers> array = new List<ClassUsers>();
        List<ClassUsers> array2 = new List<ClassUsers>();

        ClassUsers user;
        string selecteduser = "";
        string password = "";
        string answer = "";
        public SystemSettings()
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

        private void pictureBoxSystem_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(178, 141);
            pictureBoxSystem.Size = size;
            pictureBoxSystem.Location = new Point(433, 55);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_2561.png");
            pictureBoxSystem.BackgroundImage = image;
        }

        private void pictureBoxSystem_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(168, 131);
            pictureBoxSystem.Size = size;
            pictureBoxSystem.Location = new Point(441, 57);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Iconic_2795(1)_256.png");
            pictureBoxSystem.BackgroundImage = image;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(178, 141);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(709, 44);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0d0(0)_2561.png");
            pictureBox1.BackgroundImage = image;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(168, 131);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(716, 46);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0d0(0)_256.png");
            pictureBox1.BackgroundImage = image;
        }

        private void pictureBoxSystem_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = true;
            panelRemoveUser.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelRemoveUser.Visible = true;
            panelAddUser.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string userName = "";
            string password = "";
            string typeUser = comboBoxTypeUser.SelectedItem.ToString();
            string question = comboBoxPassRecoveryQuestion.SelectedItem.ToString();
            string answer = textBoxAnswer.Text;

            if (textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
            {
                password = textBoxPassword.Text;

                try
                {
                    outputStream = File.AppendText(@"C:\\Pets4U\\files\\Users.txt");

                    if (typeUser.Equals("Regular"))
                    {
                        userName = firstName.Substring(0, 1) + lastName.Substring(0, 1) + "R" + "100";
                    }
                    else if (typeUser.Equals("Administrator"))
                    {
                        userName = firstName.Substring(0, 1) + lastName.Substring(0, 1) + "A" + "200";
                    }

                    outputStream.WriteLine(typeUser + "," + firstName + "," + lastName + "," + userName + "," + password + "," + question + "," + answer);
                    outputStream.Close();
                    MessageBox.Show("The user with user name : " + userName + " has been created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    outputStream.Close();

                    comboBoxTypeUser.SelectedItem = null;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    comboBoxPassRecoveryQuestion.SelectedItem = null;
                    textBoxAnswer.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("User could not be created, please note every field is required. Please try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxTypeUser.SelectedItem = null;
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxConfirmPassword.Text = "";
                    comboBoxPassRecoveryQuestion.SelectedItem = null;
                    textBoxAnswer.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
            }
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {
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
                comboBoxRemoveUser.Items.Add(array[i].getUserName());                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SelectedUser = comboBoxRemoveUser.SelectedItem.ToString();

            int count = 0;
            
            for(int i = 0; i < array.Count; i++)
            {
                if(!(array[i].getUserName() == selecteduser))
                {
                    //array2[count] = array[1];
                }
                count++;
            }

            File.WriteAllText("C:\\Protech-Pets4U\\Files\\Users.txt", String.Empty);

            for(int i = 0; i < array2.Count; i++)
            {
                outputStream.WriteLine(array2[i].getTypeUser() + "," + array2[i].getName() + "," + array2[i].getLastName() + "," + array2[i].getUserName() + "," + array2[i].getPassword() + "," + array2[i].getQuestion() + "," + array2[i].getAnswer());
                outputStream.Close();
            }

            MessageBox.Show("The user with user name : " + comboBoxRemoveUser.SelectedItem.ToString() + " has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
