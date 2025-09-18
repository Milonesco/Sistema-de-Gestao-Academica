using TransformeseApp2.BLL;
using TransformeseApp2.DTO;

AlunoBLL alunoBLL = new AlunoBLL();
CursoBLL cursoBLL = new CursoBLL();
UnidadeBLL unidadeBLL = new UnidadeBLL();

while (true)
{
    Console.Clear();
    Console.WriteLine(" === Sistema Transforme-se === ");
    Console.WriteLine(" 1 - Cadastrar Aluno");
    Console.WriteLine(" 2 - Listar Alunos");
    Console.WriteLine(" 3 - Cadastrar Curso");
    Console.WriteLine(" 4 - Listar Cursos");
    Console.WriteLine(" 5 - Cadastrar Unidade");
    Console.WriteLine(" 6 - Listar Unidades");
    Console.WriteLine(" 0 - Sair");
    
    Console.WriteLine(" Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("ID do curso:");
            int cursoId = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ID da unidade:");
            int unidadeId = int.Parse(Console.ReadLine());

            alunoBLL.CadastrarAluno(new AlunoDTO
            {
                Nome = nomeAluno,
                CursoId = cursoId,
                UnidadeId = unidadeId,
            });

            Console.WriteLine($"Aluno {nomeAluno} cadastrado com sucesso!");
            pause();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine(" === Lista de alunos === ");

            var alunos = alunoBLL.ListarAlunos();
            foreach (var aluno in alunos)
            {
                var curso = cursoBLL.GetById(aluno.CursoId);
                var unidade = unidadeBLL.GetById(aluno.UnidadeId);

                Console.WriteLine(
                    $"""
                    ID: {aluno.Id}
                    Nome: {aluno.Nome}
                    Curso: {curso?.Nome ?? "Não encontrado"}
                    Unidade: {unidade?.Nome ?? "Não encontrada"}
                    """
                    );
            }
            pause();
            break;

        case "3":
            Console.WriteLine("Nome do curso: ");
            string nomeCurso = Console.ReadLine();

            Console.WriteLine($"O curso {nomeCurso} foi adicionado com sucesso!");

            pause(); 
            break;

        case "4";
            Console.Clear();
            Console.WriteLine("=== Lista de cursos ===");

            var cursos = cursoBLL.ListarCursos();
            foreach (var curso in cursos)
            {
                Console.WriteLine(
                    $"""
                    ID: {curso.Id}
                    Nome: {curso.Nome}
                    Carga Horaria: {curso.CargaHoraria}
                    """
                    );
            }
            pause();
            break;
    }
}

static void pause()
{
    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}