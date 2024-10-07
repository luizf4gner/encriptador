namespace meublocodenotas
{
    partial class Form1
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
            Abrir = new Button();
            Salvar = new Button();
            Encriptar = new Button();
            Desencriptar = new Button();
            labelNomeDoArquivo = new Label();
            textBoxConteudo = new TextBox();
            SuspendLayout();
            // 
            // Abrir
            // 
            Abrir.Location = new Point(78, 27);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(75, 23);
            Abrir.TabIndex = 0;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // Salvar
            // 
            Salvar.Location = new Point(159, 27);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(75, 23);
            Salvar.TabIndex = 1;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // Encriptar
            // 
            Encriptar.Location = new Point(240, 27);
            Encriptar.Name = "Encriptar";
            Encriptar.Size = new Size(79, 23);
            Encriptar.TabIndex = 2;
            Encriptar.Text = "Encriptar";
            Encriptar.UseVisualStyleBackColor = true;
            Encriptar.Click += Encriptar_Click;
            // 
            // Desencriptar
            // 
            Desencriptar.Location = new Point(325, 27);
            Desencriptar.Name = "Desencriptar";
            Desencriptar.Size = new Size(99, 23);
            Desencriptar.TabIndex = 3;
            Desencriptar.Text = "Desencriptar";
            Desencriptar.UseVisualStyleBackColor = true;
            Desencriptar.Click += Desencriptar_Click;
            // 
            // labelNomeDoArquivo
            // 
            labelNomeDoArquivo.AutoSize = true;
            labelNomeDoArquivo.Location = new Point(430, 27);
            labelNomeDoArquivo.Name = "labelNomeDoArquivo";
            labelNomeDoArquivo.Size = new Size(108, 15);
            labelNomeDoArquivo.TabIndex = 4;
            labelNomeDoArquivo.Text = "*nome do arquivo*";
            // 
            // textBoxConteudo
            // 
            textBoxConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxConteudo.Location = new Point(78, 56);
            textBoxConteudo.Multiline = true;
            textBoxConteudo.Name = "textBoxConteudo";
            textBoxConteudo.Size = new Size(460, 403);
            textBoxConteudo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxConteudo);
            Controls.Add(labelNomeDoArquivo);
            Controls.Add(Desencriptar);
            Controls.Add(Encriptar);
            Controls.Add(Salvar);
            Controls.Add(Abrir);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Abrir;
        private Button Salvar;
        private Button Encriptar;
        private Button Desencriptar;
        private Label labelNomeDoArquivo;
        private TextBox textBoxConteudo;
    }
}
