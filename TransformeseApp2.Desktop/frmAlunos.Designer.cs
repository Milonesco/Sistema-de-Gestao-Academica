namespace TransformeseApp2.Desktop
{
    partial class frmAlunos
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
            txtNome = new TextBox();
            cboUnidade = new ComboBox();
            cboCurso = new ComboBox();
            btnCadastrar = new Button();
            label3 = new Label();
            label1 = new Label();
            label = new Label();
            dgAlunos = new DataGridView();
            txtBusca = new TextBox();
            btnBusca = new Button();
            pictureBox1 = new PictureBox();
            btnExcluir = new Button();
            label2 = new Label();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 244);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(305, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // cboUnidade
            // 
            cboUnidade.FormattingEnabled = true;
            cboUnidade.Location = new Point(12, 387);
            cboUnidade.Name = "cboUnidade";
            cboUnidade.Size = new Size(305, 23);
            cboUnidade.TabIndex = 1;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(12, 315);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(305, 23);
            cboCurso.TabIndex = 1;
            cboCurso.SelectedIndexChanged += cboCurso_SelectedIndexChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.ForeColor = SystemColors.Desktop;
            btnCadastrar.Location = new Point(12, 426);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(91, 50);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(193, 30);
            label3.TabIndex = 3;
            label3.Text = "Unidade do Curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 282);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 3;
            label1.Text = "Curso do Aluno:";
            label1.Click += label1_Click_1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(12, 211);
            label.Name = "label";
            label.Size = new Size(172, 30);
            label.TabIndex = 3;
            label.Text = "Nome do Aluno:";
            label.Click += label1_Click_1;
            // 
            // dgAlunos
            // 
            dgAlunos.BackgroundColor = SystemColors.ControlDarkDark;
            dgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlunos.Location = new Point(323, 211);
            dgAlunos.Name = "dgAlunos";
            dgAlunos.Size = new Size(647, 265);
            dgAlunos.TabIndex = 4;
            dgAlunos.CellClick += dgAlunos_CellClick;
            dgAlunos.CellContentClick += dgAlunos_CellContentClick;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(323, 182);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(518, 23);
            txtBusca.TabIndex = 5;
            txtBusca.TextChanged += textBox2_TextChanged;
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.DarkTurquoise;
            btnBusca.Location = new Point(847, 181);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(123, 23);
            btnBusca.TabIndex = 6;
            btnBusca.Text = "Pesquisar";
            btnBusca.UseVisualStyleBackColor = false;
            btnBusca.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(226, 426);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 50);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F);
            label2.Location = new Point(365, 59);
            label2.Name = "label2";
            label2.Size = new Size(537, 65);
            label2.TabIndex = 9;
            label2.Text = "CADASTRO DE ALUNOS";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Cyan;
            btnAtualizar.Enabled = false;
            btnAtualizar.ForeColor = SystemColors.Desktop;
            btnAtualizar.Location = new Point(124, 426);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(81, 50);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += button1_Click_1;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 493);
            Controls.Add(btnAtualizar);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(pictureBox1);
            Controls.Add(btnBusca);
            Controls.Add(txtBusca);
            Controls.Add(dgAlunos);
            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCadastrar);
            Controls.Add(cboCurso);
            Controls.Add(cboUnidade);
            Controls.Add(txtNome);
            Name = "frmAlunos";
            Text = "S";
            Load += frmAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private ComboBox cboUnidade;
        private ComboBox cboCurso;
        private Button btnCadastrar;
        private Label label3;
        private Label label1;
        private Label label;
        private DataGridView dgAlunos;
        private TextBox txtBusca;
        private Button btnBusca;
        private PictureBox pictureBox1;
        private Button btnExcluir;
        private Label label2;
        private Button btnAtualizar;
    }
}