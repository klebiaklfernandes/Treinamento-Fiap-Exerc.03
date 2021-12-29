namespace IfSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;
            idade = byte.Parse(txtIdade.Text);
           
            if (idade >= 12)
            {
                MessageBox.Show("Você pode jogar! ;) ", "Jogo - Drogas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}