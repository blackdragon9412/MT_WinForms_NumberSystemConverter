namespace MT_WinForms_Zahlensystemumrechner
{
    partial class Form2
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
            Switch = new Button();
            Zahl1 = new TextBox();
            Ergebniss = new TextBox();
            Dropdown = new ComboBox();
            ConvertZs = new Button();
            SuspendLayout();
            // 
            // Switch
            // 
            Switch.Location = new Point(43, 342);
            Switch.Name = "Switch";
            Switch.Size = new Size(110, 62);
            Switch.TabIndex = 0;
            Switch.Text = "Switch";
            Switch.UseVisualStyleBackColor = true;
            Switch.Click += Switch_Click;
            // 
            // Zahl1
            // 
            Zahl1.Location = new Point(53, 86);
            Zahl1.Name = "Zahl1";
            Zahl1.Size = new Size(100, 23);
            Zahl1.TabIndex = 1;
            // 
            // Ergebniss
            // 
            Ergebniss.Location = new Point(431, 86);
            Ergebniss.Name = "Ergebniss";
            Ergebniss.Size = new Size(100, 23);
            Ergebniss.TabIndex = 2;
            // 
            // Dropdown
            // 
            Dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            Dropdown.FormattingEnabled = true;
            Dropdown.Items.AddRange(new object[] { "Dez ->Bin", "Dez ->Okt", "Dez ->Hex", "Bin->Dez", "Bin->Hex", "Bin->Okt", "Okt->Dez", "Okt->Bin", "Okt->Hex", "Hex->Dez", "Hez->Bin", "Hez->Okt" });
            Dropdown.Location = new Point(181, 86);
            Dropdown.Name = "Dropdown";
            Dropdown.Size = new Size(121, 23);
            Dropdown.TabIndex = 3;
            // 
            // ConvertZs
            // 
            ConvertZs.Location = new Point(329, 86);
            ConvertZs.Name = "ConvertZs";
            ConvertZs.Size = new Size(75, 23);
            ConvertZs.TabIndex = 4;
            ConvertZs.Text = "Convert";
            ConvertZs.UseVisualStyleBackColor = true;
            ConvertZs.Click += ConvertZs_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConvertZs);
            Controls.Add(Dropdown);
            Controls.Add(Ergebniss);
            Controls.Add(Zahl1);
            Controls.Add(Switch);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Switch;
        private TextBox Zahl1;
        private TextBox Ergebniss;
        private ComboBox Dropdown;
        private Button ConvertZs;
    }
}