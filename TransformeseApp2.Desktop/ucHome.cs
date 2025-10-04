using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransformeseApp2.DAL;

namespace TransformeseApp2.Desktop
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            ContarAlunos();
            ContarCursos();
            ContarUnidades();
        }

        private void ContarAlunos()
        {
            lblAlunos.Text = Database.Alunos.Count.ToString();
        }
        private void ContarCursos()
        {
            lblCursos.Text = Database.Cursos.Count.ToString();
        }
        private void ContarUnidades()
        {
            lblUnidades.Text = Database.Unidades.Count.ToString();
        }

    }
}
