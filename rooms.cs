using System.Data;
using System.Data.SqlClient;

namespace hotelseabeach
{
    internal class rooms
    {
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Db.ConnectionString);
        }

        // Pass only fixed query text here; never build the query from user input.
        // The connection closes when the returned reader is closed.
        public SqlDataReader GetForCombo(string query)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
