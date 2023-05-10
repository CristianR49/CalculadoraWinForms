namespace CalculadoraWinForms
{
    public partial class Calculadora : Form
    {
        string numero = "0";
        double n1;
        double n2;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirCaractere("1");
        }

        private void InserirCaractere(string numero)
        {
            if(this.numero == "0")
                LimparTexto();
            textBox1.Text += numero;
            this.numero += numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InserirCaractere("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InserirCaractere("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InserirCaractere("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InserirCaractere("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InserirCaractere("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InserirCaractere("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InserirCaractere("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InserirCaractere("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InserirCaractere("0");
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            InserirCaractere(",");
        }


        private delegate double Operacao(double n1, double n2);
        private Operacao operacao;


        private static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        private static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        private static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        private static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            ProcessamentoOperacao();
            operacao = Somar;
        }

        private void ProcessamentoOperacao()
        {
            n1 = Convert.ToDouble(numero);
            ZerarTexto();
        }

        private void ZerarTexto()
        {
            numero = "0";
            textBox1.Text = "0";
        }
        private void LimparTexto()
        {
            numero = "";
            textBox1.Text = "";
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(numero);
            double resultado = operacao(n1, n2);
            ZerarTexto();
            InserirCaractere(Convert.ToString(resultado));
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            ProcessamentoOperacao();
            operacao = Subtrair;
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            ProcessamentoOperacao();
            operacao = Multiplicar;

        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            ProcessamentoOperacao();
            operacao = Dividir;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ZerarTexto();
        }

    }
}