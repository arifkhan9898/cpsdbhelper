using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CpsDbHelper
{
    public class NonQueryHelper : DbHelper<NonQueryHelper>
    {
        public NonQueryHelper(string text, string connectionString)
            : base(text, connectionString)
        {
        }

        public NonQueryHelper(string text, SqlConnection connection, SqlTransaction transaction)
            : base(text, connection, transaction)
        {
        }

        protected override void BeginExecute(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }

        protected override async Task BeginExecuteAsync(SqlCommand cmd)
        {
            await cmd.ExecuteNonQueryAsync();
        }
    }
}