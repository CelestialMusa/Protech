using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protech_Pets4U
{
    public partial class PanelWindow : Form
    {
        private static int position;
        private static string name;
        private static string surname;
        private static string empNum;
        private static string typeUser;
        public PanelWindow()
        {
            InitializeComponent();
        }

        public static void PopDISP(int Position, string Name, string Surname, string EmpNum, string TypeUser)
        {
            name = Name;
            position = Position;
            surname = Surname;
            empNum = EmpNum;
            typeUser = TypeUser;
        }

        private void PanelWindow_Load(object sender, EventArgs e)
        {

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
            if(MessageBox.Show("Would you like to log out?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                HomePage child = new HomePage();
                ActiveForm.Hide();
                child.Show();
            }            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(1056, 10);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\icomoon_e656(1)_2561.png");
            pictureBox1.BackgroundImage = image;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(1063, 12);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\icomoon_e656(1)_256.png");
            pictureBox1.BackgroundImage = image;
        }

        private void PanelWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(1056, 80);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f037(4)_2561.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(1063, 83);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f037(4)_256.png");
            pictureBox2.BackgroundImage = image;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(1056, 152);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0b2(5)_2561.png");
            pictureBox3.BackgroundImage = image;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(1063, 154);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f0b2(5)_256.png");
            pictureBox3.BackgroundImage = image;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(1056, 223);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_2561.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(1063, 225);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\octicons_f068(3)_256.png");
            pictureBox4.BackgroundImage = image;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(1056, 294);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e6dc(0)_256.png");
            pictureBox5.BackgroundImage = image;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(1063, 296);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e6dc(0)_258.png");
            pictureBox5.BackgroundImage = image;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox6.Size = size;
            pictureBox6.Location = new Point(1056, 365);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e0d2(2)_2561.png");
            pictureBox6.BackgroundImage = image;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox6.Size = size;
            pictureBox6.Location = new Point(1063, 367);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e0d2(2)_256.png");
            pictureBox6.BackgroundImage = image;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox7.Size = size;
            pictureBox7.Location = new Point(1056, 436);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e062(0)_2561.png");
            pictureBox7.BackgroundImage = image;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox7.Size = size;
            pictureBox7.Location = new Point(1063, 438);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Typicons_e062(0)_256.png");
            pictureBox7.BackgroundImage = image;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox8.Size = size;
            pictureBox8.Location = new Point(1056, 507);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e69b(0)_56.png");
            pictureBox8.BackgroundImage = image;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox8.Size = size;
            pictureBox8.Location = new Point(1063, 509);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\themify_e69b(0)_256.png");
            pictureBox8.BackgroundImage = image;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(79, 75);
            pictureBox9.Size = size;
            pictureBox9.Location = new Point(1056, 578);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e548(0)_256.png");
            pictureBox9.BackgroundImage = image;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(69, 65);
            pictureBox9.Size = size;
            pictureBox9.Location = new Point(1063, 580);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Material Icons_e548(0)_2561.png");
            pictureBox9.BackgroundImage = image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee child = new Employee();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxSystem_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(178, 141);
            pictureBoxSystem.Size = size;
            pictureBoxSystem.Location = new Point(515, 75);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\linecons_e00a(0)_2561.png");
            pictureBoxSystem.BackgroundImage = image;
        }

        private void pictureBoxSystem_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(168, 131);
            pictureBoxSystem.Size = size;
            pictureBoxSystem.Location = new Point(522, 77);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\linecons_e00a(0)_256.png");
            pictureBoxSystem.BackgroundImage = image;
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(178, 141);
            pictureBox20.Size = size;
            pictureBox20.Location = new Point(304, 3);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Entypo_2139(0)_256.png");
            pictureBox20.BackgroundImage = image;
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(168, 131);
            pictureBox20.Size = size;
            pictureBox20.Location = new Point(312, 5);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\Entypo_2139(0)_2561.png");
            pictureBox20.BackgroundImage = image;
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(178, 141);
            pictureBox19.Size = size;
            pictureBox19.Location = new Point(716, 216);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\linecons_e02f(1)_256.png");
            pictureBox19.BackgroundImage = image;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(168, 131);
            pictureBox19.Size = size;
            pictureBox19.Location = new Point(724, 218);
            Image image = Image.FromFile("C:\\Protech-Pets4U\\Resources\\linecons_e02f(1)_2561.png");
            pictureBox19.BackgroundImage = image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Customers child = new Customers();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pets child = new Pets();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Appointments child = new Appointments();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Invoices child = new Invoices();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Supplies child = new Supplies();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Examinations child = new Examinations();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Clinics child = new Clinics();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Treatments child = new Treatments();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Information child = new Information();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxSystem_Click(object sender, EventArgs e)
        {
            if(typeUser.Equals("Administrator"))
            {
                SystemSettings child = new SystemSettings();
                ActiveForm.Hide();
                child.Show();
            }
            else
            {
                MessageBox.Show("Please note that you are not a system administrator and may not use this function.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Webbrowser child = new Webbrowser();
            ActiveForm.Hide();
            child.Show();
        }
    }
}
