namespace Testando.Crud
{
    partial class Buscar
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
            this.maskBuscarCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarCpf = new System.Windows.Forms.Label();
            this.maskBuscarRenavam = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscarRenavam = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // maskBuscarCpf
            // 
            this.maskBuscarCpf.Location = new System.Drawing.Point(129, 76);
            this.maskBuscarCpf.Mask = "000.000.000-00";
            this.maskBuscarCpf.Name = "maskBuscarCpf";
            this.maskBuscarCpf.Size = new System.Drawing.Size(85, 20);
            this.maskBuscarCpf.TabIndex = 6;
            // 
            // lblBuscarCpf
            // 
            this.lblBuscarCpf.AutoSize = true;
            this.lblBuscarCpf.Location = new System.Drawing.Point(70, 79);
            this.lblBuscarCpf.Name = "lblBuscarCpf";
            this.lblBuscarCpf.Size = new System.Drawing.Size(27, 13);
            this.lblBuscarCpf.TabIndex = 5;
            this.lblBuscarCpf.Text = "CPF";
            // 
            // maskBuscarRenavam
            // 
            this.maskBuscarRenavam.Location = new System.Drawing.Point(143, 76);
            this.maskBuscarRenavam.Mask = "00000000-0";
            this.maskBuscarRenavam.Name = "maskBuscarRenavam";
            this.maskBuscarRenavam.Size = new System.Drawing.Size(71, 20);
            this.maskBuscarRenavam.TabIndex = 5;
            // 
            // lblBuscarRenavam
            // 
            this.lblBuscarRenavam.AutoSize = true;
            this.lblBuscarRenavam.Location = new System.Drawing.Point(70, 79);
            this.lblBuscarRenavam.Name = "lblBuscarRenavam";
            this.lblBuscarRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblBuscarRenavam.TabIndex = 4;
            this.lblBuscarRenavam.Text = "Renavam";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(236, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(50, 203);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 31);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(50, 203);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(117, 31);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 312);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.maskBuscarRenavam);
            this.Controls.Add(this.maskBuscarCpf);
            this.Controls.Add(this.lblBuscarRenavam);
            this.Controls.Add(this.lblBuscarCpf);
            this.Controls.Add(this.radioBtnCarro);
            this.Controls.Add(this.radioBtnPessoa);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnPessoa;
        private System.Windows.Forms.RadioButton radioBtnCarro;
        private System.Windows.Forms.MaskedTextBox maskBuscarCpf;
        private System.Windows.Forms.Label lblBuscarCpf;
        private System.Windows.Forms.MaskedTextBox maskBuscarRenavam;
        private System.Windows.Forms.Label lblBuscarRenavam;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnCancelar;
    }
}