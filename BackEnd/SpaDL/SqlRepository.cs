
using System.Data.SqlClient;   
using SpaModel;

namespace SpaDL

{
    public class SqlRepository : IRepository
    {
        //============Dependency Injector===================//
            private readonly string _connectionStrings;
            public SqlRepository(string p_connectionStrings)
            {
                _connectionStrings = p_connectionStrings;
            }
        //====================================================//
        public Users addUser(string username, string password, string pName, string rank)
        {
            throw new NotImplementedException();
        }

        public List<userProfile> GetUsers()
        {
            List<userProfile> listOfUsers = new List<userProfile>();
            string sqlQuery = "Select * from Users";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery,con);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                     listOfUsers.Add(new userProfile()
                        {
                            userId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            userRank = reader.GetString(2),
                            Roles = reader.GetString(3)
                        }
                     );   
                }
            }
            return listOfUsers;
        }
    }
}