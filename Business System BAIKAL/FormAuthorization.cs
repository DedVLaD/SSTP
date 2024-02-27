using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_System_BAIKAL.BD;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Security.Cryptography;

namespace Business_System_BAIKAL
{
    public partial class FormAuthorization : Form
    {

        public FormAuthorization()
        {
            InitializeComponent();

        }

        //начало блока для перетаскивания формы по экрану
        int iFormX, iFormY, iMouseX, iMouseY;//глобальные переменные для перетаскивания формы

        private void FormAuthorization_MouseDown(object sender, MouseEventArgs e) //за форму
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void FormAuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
            this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //за изображение
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }
        //конец блока для перетаскивания формы по экрану



        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();

            txtPassword.PasswordChar = '●';

            txtUserName.MaxLength = 50;
            txtPassword.MaxLength= 50;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e) //по нажатию энтер
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButton4_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) //по нажатию энтер
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButton4_Click(sender, e);
            }
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            iconButton2.ForeColor = Color.FromArgb(188, 233, 255);
            iconButton2.IconColor = Color.FromArgb(188, 233, 255);
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)
        {
            iconButton2.ForeColor = Color.FromArgb(255, 255, 255);
            iconButton2.IconColor = Color.FromArgb(255, 255, 255);
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(188, 233, 255);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(255, 255, 255);
        }

        static public string loginActive;
        static public string whois;

        private void iconButton4_MouseLeave_1(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.FromArgb(255, 255, 255);
            iconButton4.IconColor = Color.FromArgb(255, 255, 255);
        }

        private void iconButton4_MouseEnter_1(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.FromArgb(188, 233, 255);
            iconButton4.IconColor = Color.FromArgb(188, 233, 255);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                string hashTxtPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text.ToString())); //хешировать

                Authorization.AuthorizationUser(txtUserName.Text, hashTxtPassword);
                

                switch (Authorization.position)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверьте данные и попробуйте снова!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPassword.Text = "";
                            txtUserName.Text = "";
                            break;
                        }
                    case "Мастер производства эмульгатора":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Мастер производства эмульгатора";
                            Authorization.user = txtUserName.Text;
                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, 
                                                            authorization_users WHERE login = '" + txtUserName + "' and " +
                                                            "authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;
                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois +  ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Генеральный директор":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Генеральный директор";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Старший мастер":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Старший мастер";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Лаборант":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Лаборант";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Главный химик-технолог":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Главный химик-технолог";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Главный инженер":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Главный инженер";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Главный энергетик":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Главный энергетик";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Главный бухгалтер":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Главный бухгалтер";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Заведующий складом":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Заведующий складом";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Начальник лаборатории":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Начальник лаборатории";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Специалист по охране труда":
                        {
                            loginActive = txtUserName.Text;
                            whois = "Специалист по охране труда";
                            Authorization.user = txtUserName.Text;


                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;


                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                    case "Юрист":
                        {
                            Authorization.user = loginActive = txtUserName.Text;
                            whois = "Юрист";

                            Authorization.AuthorizationFIO(@"SELECT us_lname, us_fname, us_otch FROM users, authorization_users WHERE login = '" + txtUserName + "' and authorization_users.id_user = users.id_user");
                            string us_lname = Authorization.us_lname;
                            string us_fname = Authorization.us_fname;
                            string us_otch = Authorization.us_otch;

                            MessageBox.Show(us_lname + " " + us_fname + " " + us_otch + ", " + whois + ", " +
                                "Добро пожаловать!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new FormMain().Show();
                            break;
                        }
                }    
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Не все поля заполнены!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }
}
