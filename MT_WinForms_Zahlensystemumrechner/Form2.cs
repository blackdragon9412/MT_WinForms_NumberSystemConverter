using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MT_Zahlensystem;

namespace MT_WinForms_Zahlensystemumrechner
{
    public partial class Form2 : Form
    {
        Zahlensystem zs = new Zahlensystem(); // neues Objekt vom Zahlensystem
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Switch_Click(object sender, EventArgs e) // Methode zum Wechseln zum anderen Form zum Bercehnen
        {

            this.Hide();  // Versteckt die From
            Form1 f1 = new Form1(); // Erstellt Objekt von Form2
            f1.ShowDialog(); // Zeigt From2 als neues Fenster
            this.Close(); // Schließt form1 wenn die bei form2 geswitcht wird

        }

        private void ConvertZs_Click(object sender, EventArgs e) // Methode zum Convertieren
        {

            switch (Dropdown.SelectedIndex) // Switch mit den ganzen Varianten des Umwandelns
            {
                case 0: Ergebniss.Text = zs.ConvertToBinary(Zahl1.Text, 10); break;
                case 1: Ergebniss.Text = zs.ConvertToOctal(Zahl1.Text, 10); break;
                case 2: Ergebniss.Text = zs.ConvertToHexadecimal(Zahl1.Text, 10); break;
                case 3: Ergebniss.Text = zs.ConvertToDecimal(Zahl1.Text, 2); break;
                case 4: Ergebniss.Text = zs.ConvertToHexadecimal(Zahl1.Text, 2); break;
                case 5: Ergebniss.Text = zs.ConvertToOctal(Zahl1.Text, 2); break;
                case 6: Ergebniss.Text = zs.ConvertToDecimal(Zahl1.Text, 8); break;
                case 7: Ergebniss.Text = zs.ConvertToBinary(Zahl1.Text, 8); break;
                case 8: Ergebniss.Text = zs.ConvertToHexadecimal(Zahl1.Text, 8); break;
                case 9: Ergebniss.Text = zs.ConvertToDecimal(Zahl1.Text, 16); break;
                case 10: Ergebniss.Text = zs.ConvertToBinary(Zahl1.Text, 16); break;
                case 11: Ergebniss.Text = zs.ConvertToOctal(Zahl1.Text, 16); break;

            }

        }
    }
}
