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
            ligneArrivee.Location = new Point(1038, 3);
            ligneArrivee.Margin = new Padding(4, 5, 4, 5);
            ligneArrivee.Name = "ligneArrivee";
            ligneArrivee.Size = new Size(21, 847);
            ligneArrivee.TabIndex = 0;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1345, 853);
            Controls.Add(ligneArrivee);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CourseForm";
            Text = "CourseForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel ligneArrivee;
    }
}