﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CourseDeLevrierGraphique
{
    public partial class CourseForm : Form
    {
        private PictureBox[] levriers;
        private const int DistanceCourse = 1000;
        private Random random = new Random();
        private int[] distancesParcourues;
        private Thread[] threads;
        private bool[] courseTerminee;
        private Mutex mutex = new Mutex();
        private int nombreLevrier;
        private int placesFinies = 0;
        

        public CourseForm(int nombreLevrier)
        {
            InitializeComponent();
            this.nombreLevrier = nombreLevrier;
            InitialiserCourse(nombreLevrier);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void InitialiserCourse(int nombreLevrier)
        {
            this.Text = "Course de Lévriers";
            this.ClientSize = new Size(800, nombreLevrier * 60 + 50);

            levriers = new PictureBox[nombreLevrier];
            distancesParcourues = new int[nombreLevrier];
            threads = new Thread[nombreLevrier];
            courseTerminee = new bool[nombreLevrier];
           

            string[] imagePaths = new string[]
            {
                "C:\\Users\\spirgari\\Source\\Repos\\CourseDeLevrierGraphique\\CourseDeLevrierGraphique\\ImagesLevrier\\levrier1.jpg",
                "C:\\Users\\spirgari\\Source\\Repos\\CourseDeLevrierGraphique\\CourseDeLevrierGraphique\\ImagesLevrier\\levrier2.png",
                "C:\\Users\\spirgari\\Source\\Repos\\CourseDeLevrierGraphique\\CourseDeLevrierGraphique\\ImagesLevrier\\levrier3.png",
                "C:\\Users\\spirgari\\Source\\Repos\\CourseDeLevrierGraphique\\CourseDeLevrierGraphique\\ImagesLevrier\\levrier4.png",
                "C:\\Users\\spirgari\\Source\\Repos\\CourseDeLevrierGraphique\\CourseDeLevrierGraphique\\ImagesLevrier\\levrier5.jpg"
            };

            for (int i = 0; i < nombreLevrier; i++)
            {
                levriers[i] = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(10, 50 + (i * 60)),
                    BackColor = Color.Transparent,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                try
                {
                    levriers[i].Image = Image.FromFile(imagePaths[i % imagePaths.Length]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de l'image : {ex.Message}",
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                mutex.WaitOne();
                try
                {
                    if (distancesParcourues[index] < 665)
                    {
                        distancesParcourues[index] += random.Next(1, 10);
                    } else
                    {
                        break;
                    }
                    
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(() =>
                    {
                        levriers[index].Left = distancesParcourues[index];
                    }));
                }
               /* if (levriers[index].Left>=777 && levriers[index].Top == 12)
                {
                    AfficherClassement();
                    break;
                }*/

                Thread.Sleep(50);
            }
            mutex.WaitOne();
            try
            {
                if (!courseTerminee[index])
                {
                    courseTerminee[index] = true;
                    placesFinies++;

                    if (placesFinies == nombreLevrier)
                    {
                        AfficherClassement();
                    }
                }
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }

        private void AfficherClassement()
        {
            var classement = distancesParcourues
                .Select((distance, index) => new { Levrier = index + 1, Distance = distance })
                .OrderByDescending(l => l.Distance)
                .ToList();

            string resultat = "Classement final :\n";
            int position = 1;

            foreach (var item in classement)
            {
                resultat += $"Position {position}: Lévrier {item.Levrier}\n";
                position++;
            }

            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show(resultat, "Classement final", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
