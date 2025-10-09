using TransformeseApp2.BLL;
using TransformeseApp2.DAL;

namespace TransformeseApp2.Desktop
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Olá, " + (Session.UsuarioLogado.Nome ?? "Usuário");
            ContarAlunos();
            ContarCursos();
            ContarUnidades();
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

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
