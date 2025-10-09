namespace TransformeseApp2.Desktop
{
    partial class frmCursos
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
            dgCursos = new DataGridView();
            pictureBox1 = new PictureBox();
            txtBusca = new TextBox();
            btnBusca = new Button();
            label2 = new Label();
            label3 = new Label();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            label4 = new Label();
            txtNome = new TextBox();
            txtCargaHoraria = new TextBox();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgCursos
            // 
            dgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCursos.Location = new Point(258, 175);
            dgCursos.Name = "dgCursos";
            dgCursos.Size = new Size(714, 250);
            dgCursos.TabIndex = 3;
            dgCursos.CellContentClick += dgCursos_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(258, 146);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(569, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(833, 146);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(139, 23);
            btnBusca.TabIndex = 6;
            btnBusca.Text = "Pesquisar";
            btnBusca.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(24, 175);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 8;
            label2.Text = "Nome dos Cursos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(24, 234);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 9;
            label3.Text = "Carga Horaria:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.ForeColor = SystemColors.Desktop;
            btnCadastrar.Location = new Point(24, 319);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(111, 50);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = SystemColors.Desktop;
            btnExcluir.Location = new Point(24, 375);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(111, 50);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F);
            label4.Location = new Point(258, 12);
            label4.Name = "label4";
            label4.Size = new Size(436, 65);
            label4.TabIndex = 11;
            label4.Text = "Cadastro de Cursos";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(24, 208);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(228, 23);
            txtNome.TabIndex = 12;
            // 
            // txtCargaHoraria
            // 
            txtCargaHoraria.Location = new Point(24, 267);
            txtCargaHoraria.Name = "txtCargaHoraria";
            txtCargaHoraria.Size = new Size(228, 23);
            txtCargaHoraria.TabIndex = 13;
            txtCargaHoraria.TextChanged += txtCargaHoraria_TextChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Enabled = false;
            btnAtualizar.Location = new Point(141, 319);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(111, 50);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(txtCargaHoraria);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBusca);
            Controls.Add(txtBusca);
            Controls.Add(pictureBox1);
            Controls.Add(dgCursos);
            Name = "frmCursos";
            Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)dgCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgCursos;
        private PictureBox pictureBox1;
        private TextBox txtBusca;
        private Button btnBusca;
        private Label label2;
        private Label label3;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCargaHoraria;
        private Button btnAtualizar;
    }
}