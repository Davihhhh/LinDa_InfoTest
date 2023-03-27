namespace LinDa_InfoTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        LinDa_Disoccupato disoccupato;
        LinDa_Disoccupato disoccupato2;
        LinDa_Lavoratore lavoratore;

        private void Form1_Load(object sender, EventArgs e)
        {
            disoccupato = new LinDa_Disoccupato(10, "davide", 110, true);
            disoccupato2 = new LinDa_Disoccupato(10, "davide", 10, true);
            lavoratore = new LinDa_Lavoratore(5, "davide", 5);
            textBox1.Text = disoccupato.HashCode().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}