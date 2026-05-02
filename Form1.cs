namespace TP_LP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chau mundo, manana es mi cumple ndea",
                "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "hola";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
