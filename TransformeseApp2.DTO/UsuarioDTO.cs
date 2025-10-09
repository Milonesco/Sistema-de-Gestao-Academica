namespace TransformeseApp2.DTO
{
    public class UsuarioDTO : PessoaDTO
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"ID:{Id} ,Usuário: {Nome}, Login: {Login}, Senha: {Senha}");
        }
    }
}
