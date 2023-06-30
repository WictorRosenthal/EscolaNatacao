namespace Senac.Consultorio
{
    partial class FormPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpDataNascimento = new DateTimePicker();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            groupBox1 = new GroupBox();
            lblQuantidadedePacientes = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            txtBuscaPorCPF = new TextBox();
            label8 = new Label();
            btnIniciarAtendimento = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(75, 329);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 38);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 110);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 110);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Altura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 181);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 5;
            label5.Text = "Peso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 181);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 252);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 7;
            label7.Text = "Endereço:";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(268, 56);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 8;
            dtpDataNascimento.ValueChanged += dtpDataNascimento_ValueChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 23);
            txtNome.TabIndex = 9;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(75, 128);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(187, 23);
            txtCPF.TabIndex = 10;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(268, 128);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(200, 23);
            txtAltura.TabIndex = 11;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(75, 199);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(187, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(268, 199);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 23);
            txtTelefone.TabIndex = 13;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(75, 270);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(393, 23);
            txtEndereco.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblQuantidadedePacientes);
            groupBox1.Location = new Point(574, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade de Pacientes cadastrados";
            // 
            // lblQuantidadedePacientes
            // 
            lblQuantidadedePacientes.AutoSize = true;
            lblQuantidadedePacientes.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuantidadedePacientes.Location = new Point(89, 41);
            lblQuantidadedePacientes.Name = "lblQuantidadedePacientes";
            lblQuantidadedePacientes.Size = new Size(38, 46);
            lblQuantidadedePacientes.TabIndex = 0;
            lblQuantidadedePacientes.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscaPorCPF);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(574, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(6, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscaPorCPF
            // 
            txtBuscaPorCPF.Location = new Point(6, 36);
            txtBuscaPorCPF.Name = "txtBuscaPorCPF";
            txtBuscaPorCPF.Size = new Size(126, 23);
            txtBuscaPorCPF.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 18);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 0;
            label8.Text = "CPF";
            // 
            // btnIniciarAtendimento
            // 
            btnIniciarAtendimento.Location = new Point(574, 322);
            btnIniciarAtendimento.Name = "btnIniciarAtendimento";
            btnIniciarAtendimento.Size = new Size(200, 23);
            btnIniciarAtendimento.TabIndex = 17;
            btnIniciarAtendimento.Text = "Iniciar um atendimento";
            btnIniciarAtendimento.UseVisualStyleBackColor = true;
            btnIniciarAtendimento.Click += btnIniciarAtendimento_Click;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 369);
            Controls.Add(btnIniciarAtendimento);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormPaciente";
            Text = "Form1";
            Load += FormPaciente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDataNascimento;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private GroupBox groupBox1;
        private Label lblQuantidadedePacientes;
        private GroupBox groupBox2;
        private Label label8;
        private Button btnBuscar;
        private TextBox txtBuscaPorCPF;
        private Button btnIniciarAtendimento;
    }
}