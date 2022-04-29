using SpaModel;

namespace SpaDL
{
    public interface IRepository
    {
        Users addUser(string username,string password,string pName, string rank);
    }
}
