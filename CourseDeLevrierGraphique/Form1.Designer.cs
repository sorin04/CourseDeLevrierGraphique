namespace CourseDeLevrierGraphique
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1nombre_a_saisir = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1nombre_a_saisir
            // 
            label1nombre_a_saisir.AutoSize = true;
            label1nombre_a_saisir.Location = new Point(243, 58);
            label1nombre_a_saisir.Margin = new Padding(2, 0, 2, 0);
            label1nombre_a_saisir.Name = "label1nombre_a_saisir";
            label1nombre_a_saisir.Size = new Size(0, 15);
            label1nombre_a_saisir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 2;
            label1.Text = "Choisir Levrier entre 2 et 5:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(631, 348);
            Controls.Add(label1);
            Controls.Add(label1nombre_a_saisir);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1nombre_a_saisir;
        private Label label1;
    }
}
