namespace Testando.Crud
{
    partial class Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioBtnPessoa = new System.Windows.Forms.RadioButton();
            this.radioBtnCarro = new System.Windows.Forms.RadioButton();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpfPessoa = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.gBoxPessoa = new System.Windows.Forms.GroupBox();
            this.maskCpfPessoa = new System.Windows.Forms.MaskedTextBox();
            this.gBoxPossuiCarroPessoa = new System.Windows.Forms.GroupBox();
            this.maskPessoaCarroRenavam = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCarroPessoa = new System.Windows.Forms.Label();
            this.lblPossuiCarro = new System.Windows.Forms.Label();
            this.radioBtnCarroSim = new System.Windows.Forms.RadioButton();
            this.radioBtnCarroNao = new System.Windows.Forms.RadioButton();
            this.gBoxCarro = new System.Windows.Forms.GroupBox();
            this.maskRenavamCarro = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gBoxPessoa.SuspendLayout();
            this.gBoxPossuiCarroPessoa.SuspendLayout();
            this.gBoxCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnPessoa
            // 
            this.radioBtnPessoa.AutoSize = true;
            this.radioBtnPessoa.Location = new System.Drawing.Point(88, 31);
            this.radioBtnPessoa.Name = "radioBtnPessoa";
            this.radioBtnPessoa.Size = new System.Drawing.Size(60, 17);
            this.radioBtnPessoa.TabIndex = 0;
            this.radioBtnPessoa.TabStop = true;
            this.radioBtnPessoa.Text = "Pessoa";
            this.radioBtnPessoa.UseVisualStyleBackColor = true;
            this.radioBtnPessoa.CheckedChanged += new System.EventHandler(this.radioBtnPessoa_CheckedChanged);
            // 
            // radioBtnCarro
            // 
            this.radioBtnCarro.AutoSize = true;
            this.radioBtnCarro.Location = new System.Drawing.Point(244, 31);
            this.radioBtnCarro.Name = "radioBtnCarro";
            this.radioBtnCarro.Size = new System.Drawing.Size(50, 17);
            this.radioBtnCarro.TabIndex = 1;
            this.radioBtnCarro.TabStop = true;
            this.radioBtnCarro.Text = "Carro";
            this.radioBtnCarro.UseVisualStyleBackColor = true;
            this.radioBtnCarro.CheckedChanged += new System.EventHandler(this.radioBtnCarro_CheckedChanged);
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(63, 25);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(260, 20);
            this.txtNomePessoa.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblCpfPessoa
            // 
            this.lblCpfPessoa.AutoSize = true;
            this.lblCpfPessoa.Location = new System.Drawing.Point(6, 58);
            this.lblCpfPessoa.Name = "lblCpfPessoa";
            this.lblCpfPessoa.Size = new System.Drawing.Size(27, 13);
            this.lblCpfPessoa.TabIndex = 5;
            this.lblCpfPessoa.Text = "CPF";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 28);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Location = new System.Drawing.Point(6, 58);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblRenavam.TabIndex = 7;
            this.lblRenavam.Text = "Renavam";
            // 
            // gBoxPessoa
            // 
            this.gBoxPessoa.Controls.Add(this.maskCpfPessoa);
            this.gBoxPessoa.Controls.Add(this.gBoxPossuiCarroPessoa);
            this.gBoxPessoa.Controls.Add(this.lblPossuiCarro);
            this.gBoxPessoa.Controls.Add(this.radioBtnCarroSim);
            this.gBoxPessoa.Controls.Add(this.radioBtnCarroNao);
            this.gBoxPessoa.Controls.Add(this.txtNomePessoa);
            this.gBoxPessoa.Controls.Add(this.lblNome);
            this.gBoxPessoa.Controls.Add(this.lblCpfPessoa);
            this.gBoxPessoa.Location = new System.Drawing.Point(12, 62);
            this.gBoxPessoa.Name = "gBoxPessoa";
            this.gBoxPessoa.Size = new System.Drawing.Size(351, 200);
            this.gBoxPessoa.TabIndex = 9;
            this.gBoxPessoa.TabStop = false;
            this.gBoxPessoa.Text = "Pessoa";
            // 
            // maskCpfPessoa
            // 
            this.maskCpfPessoa.Location = new System.Drawing.Point(63, 53);
            this.maskCpfPessoa.Mask = "000.000.000-00";
            this.maskCpfPessoa.Name = "maskCpfPessoa";
            this.maskCpfPessoa.Size = new System.Drawing.Size(84, 20);
            this.maskCpfPessoa.TabIndex = 9;
            // 
            // gBoxPossuiCarroPessoa
            // 
            this.gBoxPossuiCarroPessoa.Controls.Add(this.maskPessoaCarroRenavam);
            this.gBoxPossuiCarroPessoa.Controls.Add(this.lblIdCarroPessoa);
            this.gBoxPossuiCarroPessoa.Location = new System.Drawing.Point(9, 125);
            this.gBoxPossuiCarroPessoa.Name = "gBoxPossuiCarroPessoa";
            this.gBoxPossuiCarroPessoa.Size = new System.Drawing.Size(325, 66);
            this.gBoxPossuiCarroPessoa.TabIndex = 8;
            this.gBoxPossuiCarroPessoa.TabStop = false;
            this.gBoxPossuiCarroPessoa.Text = "Carro";
            // 
            // maskPessoaCarroRenavam
            // 
            this.maskPessoaCarroRenavam.Location = new System.Drawing.Point(147, 27);
            this.maskPessoaCarroRenavam.Mask = "00000000-0";
            this.maskPessoaCarroRenavam.Name = "maskPessoaCarroRenavam";
            this.maskPessoaCarroRenavam.Size = new System.Drawing.Size(67, 20);
            this.maskPessoaCarroRenavam.TabIndex = 13;
            // 
            // lblIdCarroPessoa
            // 
            this.lblIdCarroPessoa.AutoSize = true;
            this.lblIdCarroPessoa.Location = new System.Drawing.Point(73, 30);
            this.lblIdCarroPessoa.Name = "lblIdCarroPessoa";
            this.lblIdCarroPessoa.Size = new System.Drawing.Size(53, 13);
            this.lblIdCarroPessoa.TabIndex = 7;
            this.lblIdCarroPessoa.Text = "Renavam";
            // 
            // lblPossuiCarro
            // 
            this.lblPossuiCarro.AutoSize = true;
            this.lblPossuiCarro.Location = new System.Drawing.Point(6, 106);
            this.lblPossuiCarro.Name = "lblPossuiCarro";
            this.lblPossuiCarro.Size = new System.Drawing.Size(72, 13);
            this.lblPossuiCarro.TabIndex = 6;
            this.lblPossuiCarro.Text = "Possui Carro?";
            // 
            // radioBtnCarroSim
            // 
            this.radioBtnCarroSim.AutoSize = true;
            this.radioBtnCarroSim.Location = new System.Drawing.Point(123, 102);
            this.radioBtnCarroSim.Name = "radioBtnCarroSim";
            this.radioBtnCarroSim.Size = new System.Drawing.Size(42, 17);
            this.radioBtnCarroSim.TabIndex = 0;
            this.radioBtnCarroSim.TabStop = true;
            this.radioBtnCarroSim.Text = "Sim";
            this.radioBtnCarroSim.UseVisualStyleBackColor = true;
            this.radioBtnCarroSim.CheckedChanged += new System.EventHandler(this.radioBtnSimCarro_CheckedChanged);
            // 
            // radioBtnCarroNao
            // 
            this.radioBtnCarroNao.AutoSize = true;
            this.radioBtnCarroNao.Location = new System.Drawing.Point(190, 102);
            this.radioBtnCarroNao.Name = "radioBtnCarroNao";
            this.radioBtnCarroNao.Size = new System.Drawing.Size(45, 17);
            this.radioBtnCarroNao.TabIndex = 1;
            this.radioBtnCarroNao.TabStop = true;
            this.radioBtnCarroNao.Text = "Não";
            this.radioBtnCarroNao.UseVisualStyleBackColor = true;
            this.radioBtnCarroNao.CheckedChanged += new System.EventHandler(this.radioButtonCarroNao_CheckedChanged);
            // 
            // gBoxCarro
            // 
            this.gBoxCarro.Controls.Add(this.maskRenavamCarro);
            this.gBoxCarro.Controls.Add(this.txtModelo);
            this.gBoxCarro.Controls.Add(this.lblRenavam);
            this.gBoxCarro.Controls.Add(this.lblModelo);
            this.gBoxCarro.Location = new System.Drawing.Point(12, 62);
            this.gBoxCarro.Name = "gBoxCarro";
            this.gBoxCarro.Size = new System.Drawing.Size(351, 96);
            this.gBoxCarro.TabIndex = 10;
            this.gBoxCarro.TabStop = false;
            this.gBoxCarro.Text = "Carro";
            // 
            // maskRenavamCarro
            // 
            this.maskRenavamCarro.Location = new System.Drawing.Point(63, 55);
            this.maskRenavamCarro.Mask = "00000000-0";
            this.maskRenavamCarro.Name = "maskRenavamCarro";
            this.maskRenavamCarro.Size = new System.Drawing.Size(67, 20);
            this.maskRenavamCarro.TabIndex = 12;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(63, 25);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(264, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(288, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 312);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gBoxCarro);
            this.Controls.Add(this.gBoxPessoa);
            this.Controls.Add(this.radioBtnCarro);
            this.Controls.Add(this.radioBtnPessoa);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.gBoxPessoa.ResumeLayout(false);
            this.gBoxPessoa.PerformLayout();
            this.gBoxPossuiCarroPessoa.ResumeLayout(false);
            this.gBoxPossuiCarroPessoa.PerformLayout();
            this.gBoxCarro.ResumeLayout(false);
            this.gBoxCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnPessoa;
        private System.Windows.Forms.RadioButton radioBtnCarro;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpfPessoa;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.GroupBox gBoxPessoa;
        private System.Windows.Forms.GroupBox gBoxCarro;
        private System.Windows.Forms.GroupBox gBoxPossuiCarroPessoa;
        private System.Windows.Forms.Label lblIdCarroPessoa;
        private System.Windows.Forms.Label lblPossuiCarro;
        private System.Windows.Forms.RadioButton radioBtnCarroSim;
        private System.Windows.Forms.RadioButton radioBtnCarroNao;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskCpfPessoa;
        private System.Windows.Forms.MaskedTextBox maskRenavamCarro;
        private System.Windows.Forms.MaskedTextBox maskPessoaCarroRenavam;
        private System.Windows.Forms.Button btnCancelar;
    }
}