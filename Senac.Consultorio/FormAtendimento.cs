using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senac.Consultorio
{
    public partial class FormAtendimento : Form
    {
        public FormAtendimento()
        {
            InitializeComponent();
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            foreach (Paceinte pac in _pacientes)
            {
                cmbPaciente.Itens.Add(pac);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Paciente paciente = cmbPaciente.SelectedItem as Paciente;
            Procedimento procedimento = cmbProcedimento.SelectedItem as procedimento;

            Atendimento atendimento = new Atendimento();
            atendimento.DataHoraAtendimento = DateTime.Now;
            atendimento.PacienteAtendido = paciente;
            atendimento.ProcedimentoEfetuado = procedimento;

            string mensagem = "Foi criado em atendimento para o paciente: " + atendimento.PaceinteAtendido.Nome +
                "\nPara o procedimento: " + atendimento.ProcedimentoEfetuado.Nome +
                "\nCom o médico: " + atendimento.ProcedimentoEfetuado.MedicoProcedimento.Nome +
                "\nNa Data e Hora: " + atendimento.DataHoraAtendimento.ToString();
            
            MessageBox.Show(mensagem);
            //Fecha o Formulãrio
            this.Close();   
        }
    }
}
