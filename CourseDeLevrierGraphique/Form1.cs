using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseDeLevrierGraphique
{
    public partial class Form1 : Form
    {
        private Button boutonStart;

        public Form1()
        {
            InitializeComponent();
            InitialiserInterface();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void InitialiserInterface()
        {
            this.Text = "Course de Levriers";
            this.ClientSize = new Size(800, 400);

            boutonStart = new Button
            {
                Text = "Commencer la course",
                Location = new Point((this.ClientSize.Width / 2) - 100, (this.ClientSize.Height / 2) - 20),
                AutoSize = true
            };
            boutonStart.Click += BtnStart_Click;
            this.Controls.Add(boutonStart);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm(5);
            courseForm.ShowDialog();
        }
    }
}
