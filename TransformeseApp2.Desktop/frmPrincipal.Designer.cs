namespace TransformeseApp2.Desktop
{
    partial class frmPrincipal
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
            pbLogo = new PictureBox();
            pbAlunos = new PictureBox();
            pbCursos = new PictureBox();
            pbUnidades = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUnidades).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(776, 147);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pbAlunos
            // 
            pbAlunos.Image = Properties.Resources.aluno;
            pbAlunos.Location = new Point(12, 165);
            pbAlunos.Name = "pbAlunos";
            pbAlunos.Size = new Size(204, 133);
            pbAlunos.SizeMode = PictureBoxSizeMode.Zoom;
            pbAlunos.TabIndex = 0;
            pbAlunos.TabStop = false;
            pbAlunos.Click += pictureBox2_Click;
            // 
            // pbCursos
            // 
            pbCursos.Image = Properties.Resources.curso1;
            pbCursos.Location = new Point(300, 165);
            pbCursos.Name = "pbCursos";
            pbCursos.Size = new Size(204, 133);
            pbCursos.SizeMode = PictureBoxSizeMode.Zoom;
            pbCursos.TabIndex = 0;
            pbCursos.TabStop = false;
            pbCursos.Click += pictureBox3_Click;
            // 
            // pbUnidades
            // 
            pbUnidades.Image = Properties.Resources.unidade1;
            pbUnidades.Location = new Point(584, 165);
            pbUnidades.Name = "pbUnidades";
            pbUnidades.Size = new Size(204, 133);
            pbUnidades.SizeMode = PictureBoxSizeMode.Zoom;
            pbUnidades.TabIndex = 0;
            pbUnidades.TabStop = false;
            pbUnidades.Click += pbUnidades_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 311);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Alunos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 311);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Cursos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(658, 311);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Unidades";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 343);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbUnidades);
            Controls.Add(pbCursos);
            Controls.Add(pbAlunos);
            Controls.Add(pbLogo);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUnidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private PictureBox pbAlunos;
        private PictureBox pbCursos;
        private PictureBox pbUnidades;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}