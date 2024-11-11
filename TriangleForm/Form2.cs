using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleForm
{
    public partial class Form2 : Form
    {
        Label lblAngle1, lblAngle2, lblAngle3;
        TextBox txtAngle1, txtAngle2, txtAngle3;
        Button btn;
        ListView list;
        public Form2(int X, int Y)
        {
            this.Height = Y;
            this.Width = X;

            lblAngle1 = new Label();
            lblAngle1.Text = "Угол A";
            lblAngle1.Font = new Font("Arial", 24, FontStyle.Underline);
            lblAngle1.Size = new Size(200, 50);
            lblAngle1.Location = new Point(100, 400);
            Controls.Add(lblAngle1);

            lblAngle2 = new Label();
            lblAngle2.Text = "Угол B";
            lblAngle2.Font = new Font("Arial", 24, FontStyle.Underline);
            lblAngle2.Size = new Size(200, 50);
            lblAngle2.Location = new Point(100, 500);
            Controls.Add(lblAngle2);

            lblAngle3 = new Label();
            lblAngle3.Text = "Угол C";
            lblAngle3.Font = new Font("Arial", 24, FontStyle.Underline);
            lblAngle3.Size = new Size(200, 50);
            lblAngle3.Location = new Point(100, 600);
            Controls.Add(lblAngle3);

            txtAngle1 = new TextBox();
            txtAngle1.Font = new Font("Arial", 24);
            txtAngle1.Width = 150;
            txtAngle1.Location = new Point(350, 400);
            Controls.Add(txtAngle1);

            txtAngle2 = new TextBox();
            txtAngle2.Font = new Font("Arial", 24);
            txtAngle2.Width = 150;
            txtAngle2.Location = new Point(350, 500);
            Controls.Add(txtAngle2);

            txtAngle3 = new TextBox();
            txtAngle3.Font = new Font("Arial", 24);
            txtAngle3.Width = 150;
            txtAngle3.Location = new Point(350, 600);
            Controls.Add(txtAngle3);

            btn = new Button();
            btn.BackColor = Color.BlueViolet;
            btn.Text = "Рассчитать";
            btn.Font = new Font("Arial", 20);
            btn.Width = 200;
            btn.Height = 100;
            btn.Location = new Point(600, 180);
            btn.Click += Btn_Click;
            Controls.Add(btn);

            list = new ListView();
            list.View = View.Details;
            list.FullRowSelect = true;
            list.GridLines = true;
            list.Size = new Size(500, 300);
            list.Location = new Point(10, 10);
            list.Columns.Add("Поле", 200, HorizontalAlignment.Left);
            list.Columns.Add("Значение", 200, HorizontalAlignment.Left);
            Controls.Add(list);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            double corna, cornb, cornc, cornd;

            list.Items.Clear();
            corna = Convert.ToDouble(txtAngle1.Text);
            cornb = Convert.ToDouble(txtAngle2.Text);
            cornc = Convert.ToDouble(txtAngle3.Text);
            cornd = 0;

            Triangles triangle = new Triangles(corna, cornb, cornc, cornd);

            list.Items.Add("Угол a");
            list.Items.Add("Угол b");
            list.Items.Add("Угол c");
            list.Items.Add("Существует");
            list.Items.Add("Спецификатор");

            list.Items[0].SubItems.Add(triangle.outputcornA());
            list.Items[1].SubItems.Add(triangle.outputcornB());
            list.Items[2].SubItems.Add(triangle.outputcornC());

            if (triangle.ExistTriangleCorn)
            {
                list.Items[3].SubItems.Add("Существует");
            }
            else
            {
                list.Items[3].SubItems.Add("Не существует");
            }

            list.Items[4].SubItems.Add(triangle.TriangleTypeCorner);
        }
    }
}

