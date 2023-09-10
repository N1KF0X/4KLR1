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
            this.Init_Radio_Button("Активные", 110, 306, 75, 17, 1);
            this.Init_Radio_Button("Не активные", 191, 306, 88, 17, 2);
            Label label = new Label
            {
                Name = "label",
                Location = new Point(88, 7),
                Size = new System.Drawing.Size(228, 37),
                Text = "Абоненты ТНС",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 24F),

        };
            this.Controls.Add(label);
        }

        private void Init_Button(string text, int x, int y, int width, int height, int number)
        {
            Button button = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new System.Drawing.Size(width, height),
                Name = "button" + Convert.ToString(number),
            };
            button.Click += button_Click;
            this.Controls.Add(button);
        }

        private void Init_Radio_Button(string text, int x, int y, int width, int height, int number)
        {
            RadioButton radioButton = new RadioButton
            {
                Text = text,
                Location = new Point(x, y),
                Size = new System.Drawing.Size (width, height),
                Name = "radioButton" + Convert.ToString(number)
            };
            this.Controls.Add(radioButton);
        }
    }
}
