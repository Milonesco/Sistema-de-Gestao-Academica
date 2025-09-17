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
    }
}

static void pause()
{
    Console.WriteLine("\n Pressione qualquer tecla para continuar...");
    Console.ReadKey();
}