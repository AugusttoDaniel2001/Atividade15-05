namespace Atividade15_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MMamiferos mf = new MMamiferos();
                mf.ShowDialog();
            }
            if (radioButton2.Checked)
            {
                OOviperos oo = new OOviperos();
                oo.ShowDialog();
            }
        }
    }
}