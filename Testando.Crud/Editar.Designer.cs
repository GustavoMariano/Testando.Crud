﻿namespace Testando.Crud
{
    partial class Editar
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
            this.radioBtnCarro = new System.Windows.Forms.RadioButton();
            this.radioBtnPessoa = new System.Windows.Forms.RadioButton();
            this.maskBuscarRenavam = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarRenavam = new System.Windows.Forms.Label();
            this.lblBuscarCpf = new System.Windows.Forms.Label();
            this.maskBuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.gBoxEditarPessoa = new System.Windows.Forms.GroupBox();
            this.maskEditarPessoaCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEditarPessoaNome = new System.Windows.Forms.TextBox();
            this.lblPossuiCarro = new System.Windows.Forms.Label();
            this.radioPossuiCarroSim = new System.Windows.Forms.RadioButton();
            this.radioPossuiCarroNao = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEditarPessoaRenavam = new System.Windows.Forms.Label();
            this.maskEditarPessoaRenavam = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.gBoxEditarCarro = new System.Windows.Forms.GroupBox();
            this.maskEditarCarroRenavam = new System.Windows.Forms.MaskedTextBox();
            this.lblEditarCarroRenavam = new System.Windows.Forms.Label();
            this.lblEditarCarroModelo = new System.Windows.Forms.Label();
            this.txtEditarCarroModelo = new System.Windows.Forms.TextBox();
            this.btnSalvarCarro = new System.Windows.Forms.Button();
            this.gBoxEditarPessoa.SuspendLayout();
            this.gBoxEditarCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnCarro
            // 
            this.radioBtnCarro.AutoSize = true;
            this.radioBtnCarro.Location = new System.Drawing.Point(244, 31);
            this.radioBtnCarro.Name = "radioBtnCarro";
            this.radioBtnCarro.Size = new System.Drawing.Size(50, 17);
            this.radioBtnCarro.TabIndex = 3;
            this.radioBtnCarro.TabStop = true;
            this.radioBtnCarro.Text = "Carro";
            this.radioBtnCarro.UseVisualStyleBackColor = true;
            this.radioBtnCarro.CheckedChanged += new System.EventHandler(this.radioBtnCarro_CheckedChanged);
            // 
            // radioBtnPessoa
            // 
            this.radioBtnPessoa.AutoSize = true;
            this.radioBtnPessoa.Location = new System.Drawing.Point(88, 31);
            this.radioBtnPessoa.Name = "radioBtnPessoa";
            this.radioBtnPessoa.Size = new System.Drawing.Size(60, 17);
            this.radioBtnPessoa.TabIndex = 2;
            this.radioBtnPessoa.TabStop = true;
            this.radioBtnPessoa.Text = "Pessoa";
            this.radioBtnPessoa.UseVisualStyleBackColor = true;
            this.radioBtnPessoa.CheckedChanged += new System.EventHandler(this.radioBtnPessoa_CheckedChanged);
            // 
            // maskBuscarRenavam
            // 
            this.maskBuscarRenavam.Location = new System.Drawing.Point(155, 78);
            this.maskBuscarRenavam.Mask = "00000000-0";
            this.maskBuscarRenavam.Name = "maskBuscarRenavam";
            this.maskBuscarRenavam.Size = new System.Drawing.Size(71, 20);
            this.maskBuscarRenavam.TabIndex = 7;
            // 
            // lblBuscarRenavam
            // 
            this.lblBuscarRenavam.AutoSize = true;
            this.lblBuscarRenavam.Location = new System.Drawing.Point(82, 81);
            this.lblBuscarRenavam.Name = "lblBuscarRenavam";
            this.lblBuscarRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblBuscarRenavam.TabIndex = 6;
            this.lblBuscarRenavam.Text = "Renavam";
            // 
            // lblBuscarCpf
            // 
            this.lblBuscarCpf.AutoSize = true;
            this.lblBuscarCpf.Location = new System.Drawing.Point(82, 81);
            this.lblBuscarCpf.Name = "lblBuscarCpf";
            this.lblBuscarCpf.Size = new System.Drawing.Size(27, 13);
            this.lblBuscarCpf.TabIndex = 8;
            this.lblBuscarCpf.Text = "CPF";
            // 
            // maskBuscarCpf
            // 
            this.maskBuscarCpf.Location = new System.Drawing.Point(155, 78);
            this.maskBuscarCpf.Mask = "000.000.000-00";
            this.maskBuscarCpf.Name = "maskBuscarCpf";
            this.maskBuscarCpf.Size = new System.Drawing.Size(85, 20);
            this.maskBuscarCpf.TabIndex = 9;
            // 
            // gBoxEditarPessoa
            // 
            this.gBoxEditarPessoa.Controls.Add(this.btnSalvarPessoa);
            this.gBoxEditarPessoa.Controls.Add(this.maskEditarPessoaRenavam);
            this.gBoxEditarPessoa.Controls.Add(this.lblEditarPessoaRenavam);
            this.gBoxEditarPessoa.Controls.Add(this.radioPossuiCarroNao);
            this.gBoxEditarPessoa.Controls.Add(this.radioPossuiCarroSim);
            this.gBoxEditarPessoa.Controls.Add(this.lblPossuiCarro);
            this.gBoxEditarPessoa.Controls.Add(this.txtEditarPessoaNome);
            this.gBoxEditarPessoa.Controls.Add(this.lblNome);
            this.gBoxEditarPessoa.Controls.Add(this.lblCpf);
            this.gBoxEditarPessoa.Controls.Add(this.maskEditarPessoaCpf);
            this.gBoxEditarPessoa.Location = new System.Drawing.Point(20, 126);
            this.gBoxEditarPessoa.Name = "gBoxEditarPessoa";
            this.gBoxEditarPessoa.Size = new System.Drawing.Size(420, 131);
            this.gBoxEditarPessoa.TabIndex = 10;
            this.gBoxEditarPessoa.TabStop = false;
            this.gBoxEditarPessoa.Text = "Pessoa";
            // 
            // maskEditarPessoaCpf
            // 
            this.maskEditarPessoaCpf.Location = new System.Drawing.Point(47, 23);
            this.maskEditarPessoaCpf.Mask = "000.000.000-00";
            this.maskEditarPessoaCpf.Name = "maskEditarPessoaCpf";
            this.maskEditarPessoaCpf.Size = new System.Drawing.Size(85, 20);
            this.maskEditarPessoaCpf.TabIndex = 10;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(6, 26);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 11;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome";
            // 
            // txtEditarPessoaNome
            // 
            this.txtEditarPessoaNome.Location = new System.Drawing.Point(47, 55);
            this.txtEditarPessoaNome.Name = "txtEditarPessoaNome";
            this.txtEditarPessoaNome.Size = new System.Drawing.Size(146, 20);
            this.txtEditarPessoaNome.TabIndex = 13;
            // 
            // lblPossuiCarro
            // 
            this.lblPossuiCarro.AutoSize = true;
            this.lblPossuiCarro.Location = new System.Drawing.Point(199, 26);
            this.lblPossuiCarro.Name = "lblPossuiCarro";
            this.lblPossuiCarro.Size = new System.Drawing.Size(65, 13);
            this.lblPossuiCarro.TabIndex = 11;
            this.lblPossuiCarro.Text = "Possui carro";
            // 
            // radioPossuiCarroSim
            // 
            this.radioPossuiCarroSim.AutoSize = true;
            this.radioPossuiCarroSim.Location = new System.Drawing.Point(270, 24);
            this.radioPossuiCarroSim.Name = "radioPossuiCarroSim";
            this.radioPossuiCarroSim.Size = new System.Drawing.Size(42, 17);
            this.radioPossuiCarroSim.TabIndex = 14;
            this.radioPossuiCarroSim.TabStop = true;
            this.radioPossuiCarroSim.Text = "Sim";
            this.radioPossuiCarroSim.UseVisualStyleBackColor = true;
            this.radioPossuiCarroSim.CheckedChanged += new System.EventHandler(this.radioPossuiCarroSim_CheckedChanged);
            // 
            // radioPossuiCarroNao
            // 
            this.radioPossuiCarroNao.AutoSize = true;
            this.radioPossuiCarroNao.Location = new System.Drawing.Point(328, 23);
            this.radioPossuiCarroNao.Name = "radioPossuiCarroNao";
            this.radioPossuiCarroNao.Size = new System.Drawing.Size(45, 17);
            this.radioPossuiCarroNao.TabIndex = 15;
            this.radioPossuiCarroNao.TabStop = true;
            this.radioPossuiCarroNao.Text = "Não";
            this.radioPossuiCarroNao.UseVisualStyleBackColor = true;
            this.radioPossuiCarroNao.CheckedChanged += new System.EventHandler(this.radioPossuiCarroNao_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEditarPessoaRenavam
            // 
            this.lblEditarPessoaRenavam.AutoSize = true;
            this.lblEditarPessoaRenavam.Location = new System.Drawing.Point(211, 58);
            this.lblEditarPessoaRenavam.Name = "lblEditarPessoaRenavam";
            this.lblEditarPessoaRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblEditarPessoaRenavam.TabIndex = 17;
            this.lblEditarPessoaRenavam.Text = "Renavam";
            // 
            // maskEditarPessoaRenavam
            // 
            this.maskEditarPessoaRenavam.Location = new System.Drawing.Point(279, 55);
            this.maskEditarPessoaRenavam.Mask = "00000000-0";
            this.maskEditarPessoaRenavam.Name = "maskEditarPessoaRenavam";
            this.maskEditarPessoaRenavam.Size = new System.Drawing.Size(71, 20);
            this.maskEditarPessoaRenavam.TabIndex = 18;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(173, 92);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoa.TabIndex = 19;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            // 
            // gBoxEditarCarro
            // 
            this.gBoxEditarCarro.Controls.Add(this.btnSalvarCarro);
            this.gBoxEditarCarro.Controls.Add(this.txtEditarCarroModelo);
            this.gBoxEditarCarro.Controls.Add(this.lblEditarCarroModelo);
            this.gBoxEditarCarro.Controls.Add(this.maskEditarCarroRenavam);
            this.gBoxEditarCarro.Controls.Add(this.lblEditarCarroRenavam);
            this.gBoxEditarCarro.Location = new System.Drawing.Point(59, 126);
            this.gBoxEditarCarro.Name = "gBoxEditarCarro";
            this.gBoxEditarCarro.Size = new System.Drawing.Size(328, 113);
            this.gBoxEditarCarro.TabIndex = 17;
            this.gBoxEditarCarro.TabStop = false;
            this.gBoxEditarCarro.Text = "Carro";
            // 
            // maskEditarCarroRenavam
            // 
            this.maskEditarCarroRenavam.Location = new System.Drawing.Point(74, 23);
            this.maskEditarCarroRenavam.Mask = "00000000-0";
            this.maskEditarCarroRenavam.Name = "maskEditarCarroRenavam";
            this.maskEditarCarroRenavam.Size = new System.Drawing.Size(71, 20);
            this.maskEditarCarroRenavam.TabIndex = 20;
            // 
            // lblEditarCarroRenavam
            // 
            this.lblEditarCarroRenavam.AutoSize = true;
            this.lblEditarCarroRenavam.Location = new System.Drawing.Point(6, 26);
            this.lblEditarCarroRenavam.Name = "lblEditarCarroRenavam";
            this.lblEditarCarroRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblEditarCarroRenavam.TabIndex = 19;
            this.lblEditarCarroRenavam.Text = "Renavam";
            // 
            // lblEditarCarroModelo
            // 
            this.lblEditarCarroModelo.AutoSize = true;
            this.lblEditarCarroModelo.Location = new System.Drawing.Point(6, 60);
            this.lblEditarCarroModelo.Name = "lblEditarCarroModelo";
            this.lblEditarCarroModelo.Size = new System.Drawing.Size(42, 13);
            this.lblEditarCarroModelo.TabIndex = 21;
            this.lblEditarCarroModelo.Text = "Modelo";
            // 
            // txtEditarCarroModelo
            // 
            this.txtEditarCarroModelo.Location = new System.Drawing.Point(73, 57);
            this.txtEditarCarroModelo.Name = "txtEditarCarroModelo";
            this.txtEditarCarroModelo.Size = new System.Drawing.Size(209, 20);
            this.txtEditarCarroModelo.TabIndex = 22;
            // 
            // btnSalvarCarro
            // 
            this.btnSalvarCarro.Location = new System.Drawing.Point(122, 85);
            this.btnSalvarCarro.Name = "btnSalvarCarro";
            this.btnSalvarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCarro.TabIndex = 23;
            this.btnSalvarCarro.Text = "Salvar";
            this.btnSalvarCarro.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 312);
            this.Controls.Add(this.gBoxEditarCarro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gBoxEditarPessoa);
            this.Controls.Add(this.maskBuscarCpf);
            this.Controls.Add(this.lblBuscarCpf);
            this.Controls.Add(this.maskBuscarRenavam);
            this.Controls.Add(this.lblBuscarRenavam);
            this.Controls.Add(this.radioBtnCarro);
            this.Controls.Add(this.radioBtnPessoa);
            this.Name = "Editar";
            this.Text = "Editar";
            this.gBoxEditarPessoa.ResumeLayout(false);
            this.gBoxEditarPessoa.PerformLayout();
            this.gBoxEditarCarro.ResumeLayout(false);
            this.gBoxEditarCarro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnCarro;
        private System.Windows.Forms.RadioButton radioBtnPessoa;
        private System.Windows.Forms.MaskedTextBox maskBuscarRenavam;
        private System.Windows.Forms.Label lblBuscarRenavam;
        private System.Windows.Forms.Label lblBuscarCpf;
        private System.Windows.Forms.MaskedTextBox maskBuscarCpf;
        private System.Windows.Forms.GroupBox gBoxEditarPessoa;
        private System.Windows.Forms.RadioButton radioPossuiCarroNao;
        private System.Windows.Forms.RadioButton radioPossuiCarroSim;
        private System.Windows.Forms.Label lblPossuiCarro;
        private System.Windows.Forms.TextBox txtEditarPessoaNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox maskEditarPessoaCpf;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEditarPessoaRenavam;
        private System.Windows.Forms.MaskedTextBox maskEditarPessoaRenavam;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.GroupBox gBoxEditarCarro;
        private System.Windows.Forms.MaskedTextBox maskEditarCarroRenavam;
        private System.Windows.Forms.Label lblEditarCarroRenavam;
        private System.Windows.Forms.TextBox txtEditarCarroModelo;
        private System.Windows.Forms.Label lblEditarCarroModelo;
        private System.Windows.Forms.Button btnSalvarCarro;
    }
}