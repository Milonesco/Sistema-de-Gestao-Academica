namespace TransformeseApp2.Desktop
{
    partial class frmUnidades
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
            dataGridView1 = new DataGridView();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            btnBusca = new Button();
            pictureBox1 = new PictureBox();
            txtId = new TextBox();
            cboNome = new ComboBox();
            cboEndereco = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 394);
            dataGridView1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.ForeColor = SystemColors.Desktop;
            btnExcluir.Location = new Point(581, 329);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(196, 109);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.ForeColor = SystemColors.Desktop;
            btnCadastrar.Location = new Point(581, 202);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(196, 109);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(191, 12);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(61, 26);
            btnBusca.TabIndex = 1;
            btnBusca.Text = "Pesquisar";
            btnBusca.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(581, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.Location = new Point(258, 202);
            txtId.Name = "txtId";
            txtId.Size = new Size(306, 23);
            txtId.TabIndex = 3;
            // 
            // cboNome
            // 
            cboNome.FormattingEnabled = true;
            cboNome.Location = new Point(258, 270);
            cboNome.Name = "cboNome";
            cboNome.Size = new Size(306, 23);
            cboNome.TabIndex = 4;
            // 
            // cboEndereco
            // 
            cboEndereco.FormattingEnabled = true;
            cboEndereco.Location = new Point(258, 329);
            cboEndereco.Name = "cboEndereco";
            cboEndereco.Size = new Size(306, 23);
            cboEndereco.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(258, 169);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 5;
            label1.Text = "Id da Unidade:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(258, 237);
            label2.Name = "label2";
            label2.Size = new Size(195, 30);
            label2.TabIndex = 5;
            label2.Text = "Nome da Unidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(258, 296);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 5;
            label3.Text = "Endereço da Unidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28F);
            label4.Location = new Point(258, 12);
            label4.Name = "label4";
            label4.Size = new Size(180, 153);
            label4.TabIndex = 6;
            label4.Text = "Cadastro \r\nde \r\nUnidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 7;
            // 
            // frmUnidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboEndereco);
            Controls.Add(cboNome);
            Controls.Add(txtId);
            Controls.Add(pictureBox1);
            Controls.Add(btnBusca);
            Controls.Add(btnCadastrar);
            Controls.Add(btnExcluir);
            Controls.Add(dataGridView1);
            Name = "frmUnidades";
            Text = "frmUnidades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnExcluir;
        private Button btnCadastrar;
        private Button btnBusca;
        private PictureBox pictureBox1;
        private TextBox txtId;
        private ComboBox cboNome;
        private ComboBox cboEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}