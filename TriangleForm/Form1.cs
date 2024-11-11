using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TriangleForm
{
    public partial class Form1 : Form
    {
        Label lbl1, lbl2, lbl3;
        Button btn, btn2;
        PictureBox pb;
        ListView list;
        TextBox txtA, txtB, txtC;
        public Form1()
        {
            this.Height = 700;
            this.Width = 900;

            btn = new Button();
            btn.Text = "Старт";
            btn.Height = 100;
            btn.Width = 200;
            btn.Location = new Point(600, 180);
            btn.BackColor = Color.LightGreen;
            btn.Font = new Font("Arial", 28);
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Click += Btn_Click;
            Controls.Add(btn);

            pb = new PictureBox();
            pb.Size = new Size(200, 200);
            pb.Location = new Point(600, 300);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(@"..\..\..\kot.png");
            Controls.Add(pb);

            list = new ListView();
            list.View = View.Details;
            list.FullRowSelect = true;
            list.GridLines = true; 
            list.Size = new System.Drawing.Size(500, 300); 
            list.Location = new System.Drawing.Point(10, 10);

            txtA = new TextBox();
            txtA.Location = new Point(350, 400);
            txtA.Font = new Font("Arial", 28);
            txtA.Width = 200;
            Controls.Add(txtA);

            txtB = new TextBox();
            txtB.Location = new Point(350, 500);
            txtB.Font = new Font("Arial", 28);
            txtB.Width = 200;
            Controls.Add(txtB);

            txtC = new TextBox();
            txtC.Location = new Point(350, 600);
            txtC.Font = new Font("Arial", 28);
            txtC.Width = 200;
            Controls.Add(txtC);

            lbl1 = new Label();
            lbl1.Text = "Сторона A";
            lbl1.Font = new Font("Arial", 30, FontStyle.Underline);
            lbl1.Size = new Size(250, 50);
            lbl1.Location = new Point(100, 400);
            Controls.Add(lbl1);

            lbl2 = new Label();
            lbl2.Text = "Сторона B";
            lbl2.Font = new Font("Arial", 30, FontStyle.Underline);
            lbl2.Size = new Size(250, 50);
            lbl2.Location = new Point(100, 500);
            Controls.Add(lbl2);

            lbl3 = new Label();
            lbl3.Text = "Сторона C";
            lbl3.Font = new Font("Arial", 30, FontStyle.Underline);
            lbl3.Size = new Size(250, 50);
            lbl3.Location = new Point(100, 600);
            Controls.Add(lbl3);

            list.Columns.Add("Поле", 250, HorizontalAlignment.Left);
            list.Columns.Add("Значение", 250, HorizontalAlignment.Left);
            Controls.Add(list);

            btn2 = new Button();
            btn2.Text = "форма 2";
            btn2.Height = 100;
            btn2.Width = 200;
            btn2.Location = new Point(600, 50);
            btn2.BackColor = Color.Blue;
            btn2.Font = new Font("Arial", 28);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Click += Btn2_Click;
            Controls.Add(btn2);
        }

        private void Btn2_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2(900, 700);
            form2.Show();
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            double a, b, c;

            list.Items.Clear();
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);

            Triangles triangle = new Triangles(a, b, c);

            list.Items.Add("Сторона a");
            list.Items.Add("Сторона b");
            list.Items.Add("Сторона c");
            list.Items.Add("Периметр");
            list.Items.Add("Площадь");
            list.Items.Add("Существует");
            list.Items.Add("Спецификатор");
            list.Items.Add("Высота");

            list.Items[0].SubItems.Add(triangle.outputA());
            list.Items[1].SubItems.Add(triangle.outputB());
            list.Items[2].SubItems.Add(triangle.outputC());

            list.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));

            list.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));

            if (triangle.ExistTriangle)
            {
                list.Items[5].SubItems.Add("Существует");
            }
            else
            {
                list.Items[5].SubItems.Add("Не существует");
            }

            list.Items[6].SubItems.Add(triangle.TriangleType);

            pb.Image = Image.FromFile(triangle.TrianglePicture);

            list.Items[7].SubItems.Add(Convert.ToString(triangle.GetHeight(a,triangle.Surface())));
        }
    }
}