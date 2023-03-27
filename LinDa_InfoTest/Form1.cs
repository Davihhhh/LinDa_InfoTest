namespace LinDa_InfoTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        LinDa_Disoccupato disoccupato;

        private void Form1_Load(object sender, EventArgs e)
        {
            disoccupato = new LinDa_Disoccupato(10, "davide", 111, true);
            textBox1.Text = disoccupato.punteggio().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}