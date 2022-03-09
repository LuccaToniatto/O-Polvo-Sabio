namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOpcao1.Text))
            {
                MessageBox.Show("Preencha todos os campos!!");
            }

            else if (String.IsNullOrEmpty(txtOpcao2.Text))
            {
                MessageBox.Show("Preencha todos os campos!!");
            }

            else
            {
                Random rd = new Random();
                int rand_num = rd.Next(1, 3);

                switch (rand_num) 
                {
                    case 1:
                        MessageBox.Show(txtOpcao1.Text);
                    break;

                    case 2:
                        MessageBox.Show(txtOpcao2.Text);
                    break;
                }
            }
        }
    }
}