namespace TransformeseApp2.DTO
{
    public class UsuarioDTO : PessoaDTO
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string TpUsuario { get; set; } // 1-Admin, 2-Usuário Comum

        public override void ExibirInfo()
        {
            Console.WriteLine($"ID:{Id} ,Usuário: {Nome}, Login: {Login}, Senha: {Senha}");
        }
    }
}
