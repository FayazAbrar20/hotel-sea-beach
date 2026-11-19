using System.Data.SqlClient;

namespace hotelseabeach
{
    internal class CustomerRoomBook
    {
        public SqlConnection ConnectionOn()
        {
            return Db.Open();
        }
    }
}
