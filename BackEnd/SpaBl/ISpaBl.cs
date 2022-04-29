using SpaModel;

namespace SpaBl
{
    public interface ISpaBl
    {
        Users Adduser(string username, string password, string pName, string rank);
    }
}

