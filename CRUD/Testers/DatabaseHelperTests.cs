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
            Assert.True(DatabaseHelper.TestConnection(), "A conexão deveria ser verdadeira mas foi falsa.");
        }
    }
}
