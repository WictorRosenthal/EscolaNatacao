namespace Senac.Consultorio
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }
        List<Paciente> pacientes = new List<Paciente>();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Paciente pacienteCadastrado = new Paciente();

            pacienteCadastrado.Nome = txtNome.Text;
            pacienteCadastrado.DataNascimento = dtpDataNascimento.Value;
            pacienteCadastrado.CPF = txtCPF.Text;
            pacienteCadastrado.Altura = Convert.ToDecimal(txtAltura.Text);
            pacienteCadastrado.Peso = Convert.ToDecimal(txtPeso.Text);
            pacienteCadastrado.Endereco = txtEndereco.Text;
            pacienteCadastrado.Telefone = txtTelefone.Text;

            pacientes.Add(pacienteCadastrado);

            MessageBox.Show("O paciente: " + pacienteCadastrado.Nome + " foi cadastrado!");

            lblQuantidadedePacientes.Text = pacientes.Count().ToString();
        }
        public void CriarPacientesMockup()
        {

            Paciente paciente = new Paciente();
            paciente.Nome = "Joaquim";
            paciente.Altura = 1.75m;
            //paciente.UltimoProcedimento = "Consulta oftalmo";
            paciente.DataNascimento = new DateTime(1989, 09, 28);
            paciente.Endereco = "Rua 1";
            paciente.CPF = "111.111.111-11";
            paciente.Peso = 50;

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Joana";
            paciente.Altura = 1.65m;
            //paciente.UltimoProcedimento = "Consulta Consulta dentista";
            paciente.DataNascimento = new DateTime(1989, 10, 28);
            paciente.Endereco = "Rua 2";
            paciente.CPF = "111.111.111-12";
            paciente.Peso = 40;

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "João";
            paciente.Altura = 1.95m;
            //paciente.UltimoProcedimento = "Consulta Oculista";
            paciente.DataNascimento = new DateTime(1968, 10, 28);
            paciente.Endereco = "Rua 15";
            paciente.CPF = "111.111.111-13";
            paciente.Peso = 48;

            pacientes.Add(paciente);

            paciente = new Paciente();
            paciente.Nome = "Wictor";
            paciente.Altura = 1.95m;
            //paciente.UltimoProcedimento = "Consulta oftalmo";
            paciente.DataNascimento = new DateTime(1989, 04, 28);
            paciente.Endereco = "Rua 5";
            paciente.CPF = "111.111.111-85";
            paciente.Peso = 40;

            pacientes.Add(paciente);

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CriarPacientesMockup();
            lblQuantidadedePacientes.Text = pacientes.Count().ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Continuar aqui
        }
        private void CarregaDadosPaciente(Paciente paciente)
        {
            txtNome.Text = paciente.Nome;
            txtAltura.Text = paciente.Altura.ToString();
            txtPeso.Text = paciente.Peso.ToString();
            txtCPF.Text = paciente.CPF;
            txtEndereco.Text = paciente.Endereco;
            dtpDataNascimento.Value = paciente.DataNascimento;
            txtTelefone.Text = paciente.Telefone;

        }

        private void btnIniciarAtendimento_Click(object sender, EventArgs e)
        {
            FormAtendimento form = new FormAtendimento(pacientes);
            form.ToString();
        }

        private void dtpDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}