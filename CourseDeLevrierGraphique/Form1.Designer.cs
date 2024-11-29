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
            textBox1justnumero = new TextBox();
            label1nombre_a_saisir = new Label();
            label1 = new Label();
            button_Start = new Button();
            SuspendLayout();
            // 
            // textBox1justnumero
            // 
            textBox1justnumero.Location = new Point(385, 114);
            textBox1justnumero.Name = "textBox1justnumero";
            textBox1justnumero.Size = new Size(88, 31);
            textBox1justnumero.TabIndex = 0;
            textBox1justnumero.TextChanged += textBox1justnumero_TextChanged;
            // 
            // label1nombre_a_saisir
            // 
            label1nombre_a_saisir.AutoSize = true;
            label1nombre_a_saisir.Location = new Point(347, 96);
            label1nombre_a_saisir.Name = "label1nombre_a_saisir";
            label1nombre_a_saisir.Size = new Size(0, 25);
            label1nombre_a_saisir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 114);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 2;
            label1.Text = "Choisir Levrier entre 2 et 5:";
            // 
            // button_Start
            // 
            button_Start.Location = new Point(319, 336);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(229, 34);
            button_Start.TabIndex = 3;
            button_Start.Text = "Commencer la course";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(901, 580);
            Controls.Add(button_Start);
            Controls.Add(label1);
            Controls.Add(label1nombre_a_saisir);
            Controls.Add(textBox1justnumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1justnumero;
        private Label label1nombre_a_saisir;
        private Label label1;
    }
}
