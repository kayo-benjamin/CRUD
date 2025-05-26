using System;
using Npgsql;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Helpers;

namespace CRUD.Testers
{
    public class DatabaseHelperTests
    {
        [Fact]
        public void TestDatabaseConnectionReturnTrue()
        {
            Assert.True(DatabaseHelper.TestConnection(), "A conexão deveria ser bem-sucedida, mas falhou. Verifique a string de conexão e a disponibilidade do banco de dados.");
        }

        [Fact]
        public void TestConnectionPropertiesNotNullAfterSuccess()
        {
            bool connected = DatabaseHelper.TestConnection();

            if (connected)
            {
                Assert.NotNull(DatabaseHelper.DatabaseName);
                Assert.False(string.IsNullOrEmpty(DatabaseHelper.DatabaseName), "O nome do banco de dados não deveria ser nulo ou vazio após conexão bem-sucedida.");
                Assert.NotNull(DatabaseHelper.PostgreSqlVersion);
                Assert.False(string.IsNullOrEmpty(DatabaseHelper.PostgreSqlVersion), "A versão do PostgreSQL não deveria ser nula ou vazia após conexão bem-sucedida.");
                Assert.NotNull(DatabaseHelper.DatabaseSize);
                Assert.False(string.IsNullOrEmpty(DatabaseHelper.DatabaseSize), "O tamanho do banco de dados não deveria ser nulo ou vazio após conexão bem-sucedida.");
                
                Assert.NotEqual(-1, DatabaseHelper.ActiveConnections);
            }
            else
            {
                 Assert.True(connected, "A conexão falhou, portanto as propriedades não puderam ser verificadas. Verifique a configuração e disponibilidade do banco de dados.");
            }
        }

        [Fact]
        public void TestConnectionSetsIsConnectedFlagCorrectly()
        {
            bool connectionResult = DatabaseHelper.TestConnection();

            Assert.Equal(connectionResult, DatabaseHelper.IsConnected);
        }

    }
}
