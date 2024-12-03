namespace CourseDeLevrierGraphique
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ligneArrivee = new Panel();
            SuspendLayout();
            // 
            // ligneArrivee
            // 
            ligneArrivee.BackColor = Color.Red;
            ligneArrivee.Location = new Point(655, 2);
            ligneArrivee.Name = "ligneArrivee";
            ligneArrivee.Size = new Size(15, 508);
            ligneArrivee.TabIndex = 0;
            ligneArrivee.Paint += panel1_Paint;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 512);
            Controls.Add(ligneArrivee);
            Name = "CourseForm";
            Text = "CourseForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel ligneArrivee;
    }
}