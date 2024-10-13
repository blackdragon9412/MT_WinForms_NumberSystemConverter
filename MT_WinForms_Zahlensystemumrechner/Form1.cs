using MT_Zahlensystem; // using Direktiv zum benutzen von namespace in der File Class1
using System.Runtime.ConstrainedExecution;


namespace MT_WinForms_Zahlensystemumrechner
{
    public partial class Form1 : Form
    {
        Zahlensystem zs = new Zahlensystem(); // Objekt mit den Umrechnungsmethoden und Operationen vom letzten Block
        int Basis; // Varibale mit der aktuell ausgew‰hlten Basis

        public Form1()
        {
            InitializeComponent();
        }


        private void Plus_Click(object sender, EventArgs e) 
        {


            string Zahl1 = Zahl_1.Text; // Eingabe der Zahl
            string Zahl2 = Zahl_2.Text;


            switch (Basis)// switch zum differenzieren der verschiedenen Zahlensystem durch die Basis
            {
                case 2: Ergebniss.Text = zs.Add(Zahl1, Zahl2, 2); break; //addieren
                case 8: Ergebniss.Text = zs.Add(Zahl1, Zahl2, 8); break;
                case 10: Ergebniss.Text = zs.Add(Zahl1, Zahl2, 10); break;
                case 16: Ergebniss.Text = zs.Add(Zahl1, Zahl2, 16); break;
            }

        }

        private void Minus_Click(object sender, EventArgs e)
        {

            string Zahl1 = Zahl_1.Text;// Eingabe der Zahl
            string Zahl2 = Zahl_2.Text;


            switch (Basis)// switch zum differenzieren der verschiedenen Zahlensystem durch die Basis
            {
                case 2: Ergebniss.Text = zs.Sub(Zahl1, Zahl2, 2); break;// subtrahieren
                case 8: Ergebniss.Text = zs.Sub(Zahl1, Zahl2, 8); break;
                case 10: Ergebniss.Text = zs.Sub(Zahl1, Zahl2, 10); break;
                case 16: Ergebniss.Text = zs.Sub(Zahl1, Zahl2, 16); break;
            }


        }

        private void Mal_Click(object sender, EventArgs e)// Methode beim Clicken des Plus Buttons
        {

            string Zahl1 = Zahl_1.Text;// Eingabe der Zahl
            string Zahl2 = Zahl_2.Text;


            switch (Basis)
            {
                case 2: Ergebniss.Text = zs.Mult(Zahl1, Zahl2, 2); break; // multiplizieren
                case 8: Ergebniss.Text = zs.Mult(Zahl1, Zahl2, 8); break;
                case 10: Ergebniss.Text = zs.Mult(Zahl1, Zahl2, 10); break;
                case 16: Ergebniss.Text = zs.Mult(Zahl1, Zahl2, 16); break;
            }


        }

        private void Div_Click(object sender, EventArgs e)// Methode beim Clicken des Plus Buttons
        {

            string Zahl1 = Zahl_1.Text;// Eingabe der Zahl
            string Zahl2 = Zahl_2.Text;

            switch (Basis)
            {
                case 2: Ergebniss.Text = zs.Div(Zahl1, Zahl2, 2); break; // Dividiren 
                case 8: Ergebniss.Text = zs.Div(Zahl1, Zahl2, 8); break;
                case 10: Ergebniss.Text = zs.Div(Zahl1, Zahl2, 10); break;
                case 16: Ergebniss.Text = zs.Div(Zahl1, Zahl2, 16); break;
            }

        }

        private void Switch_Click(object sender, EventArgs e)// Methode zum Wechseln zum anderen Form zum Umwandeln
        {

            this.Hide(); // Versteckt die From
            Form2 f2 = new Form2(); // Erstellt Objekt von Form2
            f2.ShowDialog(); // Zeigt From2 als neues Fenster
            this.Close(); // Schlieﬂt form1 wenn die bei form2 geswitcht wird

        }


        private void Bin‰r_Click(object sender, EventArgs e) // Methoden beim Clicken der Radiobutton, ‰ndert die Basis
        {
            Basis = 2;
        }

        private void Oktal_Click(object sender, EventArgs e)
        {
            Basis = 8;
        }

        private void Dezimal_Click(object sender, EventArgs e)
        {
            Basis = 10;
        }

        private void Hexadezimal_Click(object sender, EventArgs e)
        {
            Basis = 16;
        }
    }
}
