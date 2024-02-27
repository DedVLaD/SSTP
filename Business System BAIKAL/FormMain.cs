using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Business_System_BAIKAL.BD;
using Business_System_BAIKAL.Forms;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Business_System_BAIKAL
{

    public partial class FormMain : Form
    {

        //поля приватности
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        

        //конструктор
        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //форма
            this.Text = string.Empty;
            this.ControlBox = false; //убрать блок управления
            this.DoubleBuffered = true; //уменьшить мерцание формы
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //при развороте на весь экран, не перекрывать панель задач   
        }

        //структуры
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176); 
            public static Color color3 = Color.FromArgb(253, 138, 114); 
            public static Color color4 = Color.FromArgb(95, 77, 221); 
            public static Color color5 = Color.FromArgb(249, 88, 155); 
        }

        //методы
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //настройки кнопок
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color; 
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; //смена местами текста и картинки
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //выравнить значок по правому краю
                //левая панель
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);//получаем текущее положение по Y
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //иконка дочерних форм с левой панели
                iconCurrentChildForm.IconChar = currentBtn.IconChar; //замена иконки
                iconCurrentChildForm.IconColor = color; //замена цвета
            } 
        }

        private void DisableButton() //к исходным значениям
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(188, 233, 255);//исходный цвет фона
                currentBtn.ForeColor = Color.FromArgb(22, 104, 220); //исходный цвет текста
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; //по левому краю
                currentBtn.IconColor = Color.FromArgb(22, 104, 220);  //исходный цвет иконки
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; //иконка перед текстом
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; //выравнить значок по левому краю
            }
        }

        private void OpenChildForm(Form childform) 
        {
            if(currentChildForm!= null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false; 
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);   
            panelDesktop.Tag= childform;
            childform.BringToFront();
            childform.Show();
            lblTitleChildForm.Text = childform.Text;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormOrders());
        }
        private void btnProductions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormProductions());
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormLaboratory());
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormStatistics());
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormParametrs());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset() //метод для скрытия видимости 
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(22, 104, 220);
            lblTitleChildForm.Text = "Home";
        }

        // библиотеки интернациональной совместимости
        [DllImport ("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void exit_Click(object sender, EventArgs e)
        {
            DBconnection.CloseDB();
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)  //развернуть окно на весь экран или до нормального
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);  //перенос формы за панель
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();

            lblUserName.Text = Authorization.us_lname + " " + Authorization.us_fname + " " + Authorization.us_otch;
            lblPositionUser.Text= FormAuthorization.whois;
        }

        private void btnCloseUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAuthorization().Show();
        }   
    }
}
