namespace GestaoJogadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader leitor = new StreamReader("Jogadores.dat");
            string linha;
            string[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));

                textBox_listaJogador.AppendText(vetorDados[0]);

            } while (!leitor.EndOfStream);

            leitor.Close();
        }

        private void button_inserir_Click(object sender, EventArgs e)

        {
            if (textBox_nomeJogador.Text.Equals(" "))
            {
                MessageBox.Show("Campo não pode estar Vazio", "ALERTA!");
                return;
            }

            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();
            
            string email;

            if(Jogador.jaCadastrado(textBox_nomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador Já Cadastrado", "ALERTA!");

            }
            else
            {
                string[] vetorNomes = textBox_nomeJogador.Text.ToLower().Split(" ");

                if(vetorNomes.Length > 1)
                {
                email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";

                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";

                }

                listaJogadores.Add(new Jogador(textBox_nomeJogador.Text, email));
                textBox_listaJogador.AppendText(textBox_nomeJogador.Text + " -  " + email +  Environment.NewLine);



                StreamWriter escritor = new StreamWriter("Jogadores.dat", true);
                escritor.WriteLine( textBox_nomeJogador.Text + ";" + email );
                escritor.Close();

                } 
            textBox_nomeJogador.Text = "";

     
        }
        List<Jogador> listaJogadores = new List<Jogador>(); 

        private void button_limparTudo_Click(object sender, EventArgs e)
        {
            textBox_listaJogador.Clear();
            textBox_nomeJogador.Clear();
            label_totalNomes.Text = "Total de Jogadores: 0";
            listaJogadores.Clear();
        }
    }
}