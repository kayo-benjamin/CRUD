namespace CRUD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
<<<<<<< HEAD
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int TipoId { get; set; }
        public string Sexo { get; set; }
=======
        public int TipoId { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Sexo { get; set; }
>>>>>>> 748769813b9f035dddf159b42612a631cd5e0cbf
        public string Status { get; set; } = "S";

        public User() { }

        public User(
            int id, string nome, string email, string senha, int tipoId, string cpf,
            string telefone, string endereco, string dataNascimento, string sexo, string status)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            TipoId = tipoId;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;

            // Tenta converter a string dataNascimento para DateTime
            if (DateTime.TryParse(dataNascimento, out var parsedDate))
            {
                DataNascimento = parsedDate;
            }
            else
            {
                DataNascimento = null; // Define como null se a conversão falhar
            }

            Sexo = sexo;
            Status = status;
        }
    }
}
