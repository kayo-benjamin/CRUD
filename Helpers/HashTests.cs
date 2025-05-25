using Xunit;
using CRUD.Helpers; // Assuming Helpers namespace
using System;
using System.Security.Cryptography;
using System.Text;

namespace CRUD.Tests
{
    public class HashTests
    {
        // Teste para verificar se o método CriptografarSenha retorna uma hash SHA256 válida (64 caracteres hexadecimais).
        [Theory]
        [InlineData("senha123")]
        [InlineData("umaSenhaMuitoLongaComCaracteresEspeciais!@#$%^&*()")]
        [InlineData("curta")]
        public void CriptografarSenha_ShouldReturnValidSHA256Hash_ForValidInput(string password)
        {
            // Arrange
            var hashHelper = new Hash(); // Instancia a classe Hash (se não for estática)
                                        // Se CriptografarSenha for estático, chamar diretamente: Hash.CriptografarSenha(password)

            // Act
            string hashedPassword = hashHelper.CriptografarSenha(password);

            // Assert
            Assert.NotNull(hashedPassword);
            Assert.Equal(64, hashedPassword.Length); // SHA256 hash em hexadecimal tem 64 caracteres
            Assert.Matches("^[a-f0-9]{64}$", hashedPassword); // Verifica se contém apenas caracteres hexadecimais minúsculos

            // Verifica se o hash gerado corresponde ao esperado para a senha de entrada
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // A implementação original faz Replace("-", "").ToLower().Substring(0, 64)
                // O BitConverter.ToString retorna hifens, ex: "AB-CD-EF"
                // O Substring(0, 64) parece redundante se o Replace e ToLower já foram feitos, pois o hash SHA256 tem 32 bytes -> 64 hex chars.
                var expectedHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                // Se a implementação original realmente usasse Substring(0, 64) após o Replace/ToLower, o assert seria:
                // var expectedHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower().Substring(0, 64);
                Assert.Equal(expectedHash, hashedPassword);
            }
        }

        // Teste para verificar o comportamento com entrada nula ou vazia.
        // A implementação atual provavelmente lançará uma exceção (ex: ArgumentNullException) se a entrada for nula.
        // Se a entrada for vazia, deve gerar um hash para a string vazia.
        [Fact]
        public void CriptografarSenha_ShouldHandleEmptyString()
        {
            // Arrange
            var hashHelper = new Hash();
            string emptyPassword = "";

            // Act
            string hashedPassword = hashHelper.CriptografarSenha(emptyPassword);

            // Assert
            Assert.NotNull(hashedPassword);
            Assert.Equal(64, hashedPassword.Length);
            Assert.Matches("^[a-f0-9]{64}$", hashedPassword);

            // Verifica o hash esperado para string vazia
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(emptyPassword));
                var expectedHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                Assert.Equal(expectedHash, hashedPassword);
            }
        }

        // Teste para verificar se entradas diferentes produzem hashes diferentes.
        [Fact]
        public void CriptografarSenha_ShouldProduceDifferentHashes_ForDifferentInputs()
        {
            // Arrange
            var hashHelper = new Hash();
            string passwordA = "senhaA";
            string passwordB = "senhaB";

            // Act
            string hashA = hashHelper.CriptografarSenha(passwordA);
            string hashB = hashHelper.CriptografarSenha(passwordB);

            // Assert
            Assert.NotNull(hashA);
            Assert.NotNull(hashB);
            Assert.Equal(64, hashA.Length);
            Assert.Equal(64, hashB.Length);
            Assert.NotEqual(hashA, hashB);
        }

        // Teste para verificar se a mesma entrada produz sempre o mesmo hash (determinístico).
        [Fact]
        public void CriptografarSenha_ShouldBeDeterministic()
        {
            // Arrange
            var hashHelper = new Hash();
            string password = "senhaDeterminística123!@#";

            // Act
            string hash1 = hashHelper.CriptografarSenha(password);
            string hash2 = hashHelper.CriptografarSenha(password);

            // Assert
            Assert.Equal(hash1, hash2);
        }

        // Teste para verificar o comportamento com entrada nula (espera-se uma exceção).
        [Fact]
        public void CriptografarSenha_ShouldThrowException_ForNullInput()
        {
            // Arrange
            var hashHelper = new Hash();
            string nullPassword = null;

            // Act & Assert
            // Verifica se uma exceção (provavelmente ArgumentNullException ou NullReferenceException dependendo da implementação exata do GetBytes)
            // é lançada quando a entrada é nula.
            Assert.ThrowsAny<Exception>(() => hashHelper.CriptografarSenha(nullPassword));
            // Poderia ser mais específico: Assert.Throws<ArgumentNullException>(() => hashHelper.CriptografarSenha(nullPassword));
        }
    }
}

