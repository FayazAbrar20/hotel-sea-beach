using System.Configuration;
using System.Data.SqlClient;

namespace hotelseabeach
{
    /// <summary>
    /// Single place that knows how to reach the database.
    /// The connection string lives in App.config (connectionStrings/HotelDb),
    /// so it is never hard-coded in the forms.
    /// </summary>
    internal static class Db
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString; }
        }

        public static SqlConnection Open()
        {
            var con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
    }
}
