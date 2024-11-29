using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CourseDeLevrierGraphique
{
    public partial class CourseForm : Form
    {
        private PictureBox[] levriers;
        private const int DistanceCourse = 800;
        private Random random = new Random();
        private int[] distancesParcourues;
        private Thread[] threads;

        public CourseForm(int nombreLevrier)
        {
            InitializeComponent();
            InitialiserCourse(nombreLevrier);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void InitialiserCourse(int nombreLevrier)
        {
            this.Text = "Course de Levriers";
            this.ClientSize = new Size(800, 400);
            levriers = new PictureBox[nombreLevrier];
            distancesParcourues = new int[nombreLevrier];
            threads = new Thread[nombreLevrier];

            for (int i = 0; i < nombreLevrier; i++)
            {
                levriers[i] = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(10, 50 + (i * 60)),
                    BackColor = i % 2 == 0 ? Color.Red : Color.Blue,
                };
                this.Controls.Add(levriers[i]);
            }

            for (int i = 0; i < nombreLevrier; i++)
            {
                int index = i;
                threads[i] = new Thread(() => DeplacerLevrier(index));
                threads[i].Start();
            }
        }

        private void DeplacerLevrier(int index)
        {
            while (distancesParcourues[index] < DistanceCourse)
            {
                distancesParcourues[index] += random.Next(1, 10);

                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        levriers[index].Left = distancesParcourues[index];
                    }));
                }

                Thread.Sleep(50);
            }

            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show($"Le lévrier {index + 1} a terminé la course ! \nDistance parcourue: {distancesParcourues[index]} metre", "Fin de la course");
                }));
            }
        }
    }
}
