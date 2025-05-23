namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int TipoId { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Status { get; set; } = "S";

        public User() { }

        public User(
            int id, string nome, string email, string senha, int tipoId, string cpf,
            string telefone, string endereco, DateTime dataNascimento, string sexo, string status)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            TipoId = tipoId;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Status = status;
        }
    }
}
