using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseDeLevrierGraphique
{
    public partial class Form1 : Form
    {
        private TextBox txtNombreLevrier;
        private Button button_Start;


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            txtNombreLevrier = new TextBox
            {
                Location = new Point((this.ClientSize.Width - 88) / 2, 30),
                Size = new Size(88, 31)
            };
            txtNombreLevrier.TextChanged += textBox1justnumero_TextChanged;
            this.Controls.Add(txtNombreLevrier);

            button_Start = new Button
            {
                Size = new Size(229, 34),
                Location = new Point((this.ClientSize.Width - 229) / 2, 70),
                Text = "Commencer la course",
                Enabled = false
            };
            button_Start.Click += button_Start_Click;
            this.Controls.Add(button_Start);


        }




        private void button_Start_Click(object sender, EventArgs e)
        {
            int nombreLevrier;
            if (int.TryParse(txtNombreLevrier.Text, out nombreLevrier) && nombreLevrier >= 2 && nombreLevrier <= 5)
            {
                CourseForm courseForm = new CourseForm(nombreLevrier);
                courseForm.Show();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nombre valide de lévriers entre 2 et 5.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1justnumero_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNombreLevrier.Text, out int numero) && numero >= 2 && numero <= 5)
            {
                button_Start.Enabled = true;
            }
            else
            {
                button_Start.Enabled = false;
            }

        }

        
    }


}
