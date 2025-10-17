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
            CircleProgress();
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

        private void CircleProgress()
        {
            timer.Interval = 50; // Velocidade do progresso
            timer.Start();

            cpbAlunos.Minimum = 0;
            cpbAlunos.Maximum = 100;
            cpbAlunos.Value = Database.Alunos.Count;

            cpbCursos.Minimum = 0;
            cpbCursos.Maximum = 100;
            cpbCursos.Value = Database.Cursos.Count;

            cpbUnidades.Minimum = 0;
            cpbUnidades.Maximum = 100;
            cpbUnidades.Value = Database.Unidades.Count;


        }
    }
}
