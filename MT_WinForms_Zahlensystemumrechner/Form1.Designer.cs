namespace MT_WinForms_Zahlensystemumrechner
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
            Zahl_1 = new TextBox();
            Zahl_2 = new TextBox();
            Ergebniss = new TextBox();
            Plus = new Button();
            Minus = new Button();
            Mal = new Button();
            Dividieren = new Button();
            Binär = new RadioButton();
            Oktal = new RadioButton();
            Dezimal = new RadioButton();
            Hexadezimal = new RadioButton();
            Switch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Zahl_1
            // 
            Zahl_1.Location = new Point(35, 72);
            Zahl_1.Name = "Zahl_1";
            Zahl_1.Size = new Size(100, 23);
            Zahl_1.TabIndex = 0;
            // 
            // Zahl_2
            // 
            Zahl_2.Location = new Point(166, 72);
            Zahl_2.Name = "Zahl_2";
            Zahl_2.Size = new Size(100, 23);
            Zahl_2.TabIndex = 1;
            // 
            // Ergebniss
            // 
            Ergebniss.Location = new Point(497, 73);
            Ergebniss.Name = "Ergebniss";
            Ergebniss.Size = new Size(100, 23);
            Ergebniss.TabIndex = 2;
            // 
            // Plus
            // 
            Plus.Location = new Point(286, 41);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 23);
            Plus.TabIndex = 3;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(286, 72);
            Minus.Name = "Minus";
            Minus.Size = new Size(75, 23);
            Minus.TabIndex = 4;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Mal
            // 
            Mal.Location = new Point(385, 41);
            Mal.Name = "Mal";
            Mal.Size = new Size(75, 23);
            Mal.TabIndex = 5;
            Mal.Text = "*";
            Mal.UseVisualStyleBackColor = true;
            Mal.Click += Mal_Click;
            // 
            // Dividieren
            // 
            Dividieren.Location = new Point(385, 72);
            Dividieren.Name = "Dividieren";
            Dividieren.Size = new Size(75, 23);
            Dividieren.TabIndex = 6;
            Dividieren.Text = "/";
            Dividieren.UseVisualStyleBackColor = true;
            Dividieren.Click += Div_Click;
            // 
            // Binär
            // 
            Binär.AutoSize = true;
            Binär.Location = new Point(35, 119);
            Binär.Name = "Binär";
            Binär.Size = new Size(52, 19);
            Binär.TabIndex = 7;
            Binär.TabStop = true;
            Binär.Text = "Binär";
            Binär.UseVisualStyleBackColor = true;
            Binär.Click += Binär_Click;
            // 
            // Oktal
            // 
            Oktal.AutoSize = true;
            Oktal.Location = new Point(35, 144);
            Oktal.Name = "Oktal";
            Oktal.Size = new Size(53, 19);
            Oktal.TabIndex = 8;
            Oktal.TabStop = true;
            Oktal.Text = "Oktal";
            Oktal.UseVisualStyleBackColor = true;
            Oktal.Click += Oktal_Click;
            // 
            // Dezimal
            // 
            Dezimal.AutoSize = true;
            Dezimal.Location = new Point(35, 169);
            Dezimal.Name = "Dezimal";
            Dezimal.Size = new Size(67, 19);
            Dezimal.TabIndex = 9;
            Dezimal.TabStop = true;
            Dezimal.Text = "Dezimal";
            Dezimal.UseVisualStyleBackColor = true;
            Dezimal.Click += Dezimal_Click;
            // 
            // Hexadezimal
            // 
            Hexadezimal.AutoSize = true;
            Hexadezimal.Location = new Point(35, 194);
            Hexadezimal.Name = "Hexadezimal";
            Hexadezimal.Size = new Size(93, 19);
            Hexadezimal.TabIndex = 10;
            Hexadezimal.TabStop = true;
            Hexadezimal.Text = "Hexadezimal";
            Hexadezimal.UseVisualStyleBackColor = true;
            Hexadezimal.Click += Hexadezimal_Click;
            // 
            // Switch
            // 
            Switch.Location = new Point(35, 324);
            Switch.Name = "Switch";
            Switch.Size = new Size(149, 69);
            Switch.TabIndex = 11;
            Switch.Text = "Switch";
            Switch.UseVisualStyleBackColor = true;
            Switch.Click += Switch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "erste Zahl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 54);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 13;
            label2.Text = "zweite Zahl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 55);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 14;
            label3.Text = "Ergebniss";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Switch);
            Controls.Add(Hexadezimal);
            Controls.Add(Dezimal);
            Controls.Add(Oktal);
            Controls.Add(Binär);
            Controls.Add(Dividieren);
            Controls.Add(Mal);
            Controls.Add(Minus);
            Controls.Add(Plus);
            Controls.Add(Ergebniss);
            Controls.Add(Zahl_2);
            Controls.Add(Zahl_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Zahl_1;
        private TextBox Zahl_2;
        private TextBox Ergebniss;
        private Button Plus;
        private Button Minus;
        private Button Mal;
        private Button Dividieren;
        private RadioButton Oktal;
        private RadioButton Dezimal;
        private RadioButton Hexadezimal;
        private Button Switch;
        public RadioButton Binär;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
