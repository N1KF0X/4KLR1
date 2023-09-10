using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init_Button("Абоненты", 9, 96, 96, 24, 1);
            this.Init_Button("Управление оборудованием", 9, 125, 96, 43, 2);
            this.Init_Button("Активы", 9, 173, 96, 24, 3);
            this.Init_Button("Биллинг", 9, 202, 96, 24, 4);
            this.Init_Button("Поддержка пользователей", 9, 232, 96, 43, 5);
            this.Init_Button("CRM", 9, 278, 96, 24, 6);
            this.Init_Button("проф.", 9, 305, 96, 24, 7);
            this.Init_Button("?", 9, 334, 96, 24, 7);
        }

        private void Init_Button(string text, int x, int y, int width, int height, int number)
        {
            Button button = new Button
            {
                Text = text
            };
            button.Click += button_Click;
            button.Location = new Point(x, y);
            button.Size = new System.Drawing.Size(width, height);
            button.Name = "button" + Convert.ToString(number);
            this.Controls.Add(button);
        }
    }
}
