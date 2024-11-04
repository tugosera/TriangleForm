using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TriangleForm
{
    public partial class Form1 : Form
    {

        Button btn;
        public Form1()
        {
            this.Height = 700;
            this.Width = 900;

            btn = new Button();
            btn.Text = "Start";
            btn.Height = 100;
            btn.Width = 200;
            btn.Location = new Point(550, 150);
            btn.BackColor = Color.FromArgb(255, 255, 192);
            btn.Font = new Font("Arial", 28);
            btn.Cursor = Cursors.Hand;
            btn.FlatStyle = FlatStyle.Flat;
            Controls.Add(btn);
        }
    }
}
