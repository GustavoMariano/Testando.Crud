namespace Testando.Crud
{
    partial class Excluir
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
            this.lblExcluirCpf = new System.Windows.Forms.Label();
            this.lblExcluirRenavam = new System.Windows.Forms.Label();
            this.maskExcluirCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskExcluirRenavam = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtnCarro
            // 
            this.radioBtnCarro.AutoSize = true;
            this.radioBtnCarro.Location = new System.Drawing.Point(244, 31);
            this.radioBtnCarro.Name = "radioBtnCarro";
            this.radioBtnCarro.Size = new System.Drawing.Size(50, 17);
            this.radioBtnCarro.TabIndex = 5;
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
            this.radioBtnPessoa.TabIndex = 4;
            this.radioBtnPessoa.TabStop = true;
            this.radioBtnPessoa.Text = "Pessoa";
            this.radioBtnPessoa.UseVisualStyleBackColor = true;
            this.radioBtnPessoa.CheckedChanged += new System.EventHandler(this.radioBtnPessoa_CheckedChanged);
            // 
            // lblExcluirCpf
            // 
            this.lblExcluirCpf.AutoSize = true;
            this.lblExcluirCpf.Location = new System.Drawing.Point(121, 115);
            this.lblExcluirCpf.Name = "lblExcluirCpf";
            this.lblExcluirCpf.Size = new System.Drawing.Size(27, 13);
            this.lblExcluirCpf.TabIndex = 6;
            this.lblExcluirCpf.Text = "CPF";
            // 
            // lblExcluirRenavam
            // 
            this.lblExcluirRenavam.AutoSize = true;
            this.lblExcluirRenavam.Location = new System.Drawing.Point(95, 115);
            this.lblExcluirRenavam.Name = "lblExcluirRenavam";
            this.lblExcluirRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblExcluirRenavam.TabIndex = 7;
            this.lblExcluirRenavam.Text = "Renavam";
            // 
            // maskExcluirCpf
            // 
            this.maskExcluirCpf.Location = new System.Drawing.Point(195, 112);
            this.maskExcluirCpf.Mask = "000.000.000-00";
            this.maskExcluirCpf.Name = "maskExcluirCpf";
            this.maskExcluirCpf.Size = new System.Drawing.Size(85, 20);
            this.maskExcluirCpf.TabIndex = 10;
            // 
            // maskExcluirRenavam
            // 
            this.maskExcluirRenavam.Location = new System.Drawing.Point(195, 112);
            this.maskExcluirRenavam.Mask = "00000000-0";
            this.maskExcluirRenavam.Name = "maskExcluirRenavam";
            this.maskExcluirRenavam.Size = new System.Drawing.Size(71, 20);
            this.maskExcluirRenavam.TabIndex = 19;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(149, 207);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 312);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.maskExcluirRenavam);
            this.Controls.Add(this.maskExcluirCpf);
            this.Controls.Add(this.lblExcluirRenavam);
            this.Controls.Add(this.lblExcluirCpf);
            this.Controls.Add(this.radioBtnCarro);
            this.Controls.Add(this.radioBtnPessoa);
            this.Name = "Excluir";
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnCarro;
        private System.Windows.Forms.RadioButton radioBtnPessoa;
        private System.Windows.Forms.Label lblExcluirCpf;
        private System.Windows.Forms.Label lblExcluirRenavam;
        private System.Windows.Forms.MaskedTextBox maskExcluirCpf;
        private System.Windows.Forms.MaskedTextBox maskExcluirRenavam;
        private System.Windows.Forms.Button btnExcluir;
    }
}