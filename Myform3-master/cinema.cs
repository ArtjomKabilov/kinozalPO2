using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyVorm
{
    public partial class cinema :Form
    {
        public cinema()
        {
            this.Size = new System.Drawing.Size(500,500);
            this.BackgroundImage = new Bitmap(@"../../image/kinozal.jpg");
            Button room_btn = new Button
            {
                Text = "saali valimine ja pileti ostmine",
                Location = new System.Drawing.Point(250, 150),
                Size = new Size(100,40)
                
            };
            room_btn.BackColor = Color.White;
            room_btn.Click += Start_btn_Click;
            this.Controls.Add(room_btn);
            Label lbl = new Label()
            {
                Text = "Tere tulemast kinno",
                Location = new System.Drawing.Point(130, 30),
                Size = new Size(240, 40),
                Font = new Font("Arial", 18, FontStyle.Bold)

            };
            this.Controls.Add(lbl);
            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(130, 60)
            };
            this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;

        }

        private void Start_btn_2_Click(object sender, EventArgs e)
        {

            MyForm uus_aken = new MyForm(8, 5);

            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Mina olen ilus aken", "Vali midagi", "Üks", "Kaks", "Kolm", "Neli");
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
