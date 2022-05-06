using SpaModel;
using SpaDL;

namespace SpaBl
{
    public class SpaBL : ISpaBl
    {
        //============== Dependency Injection =======================
           private readonly IRepository _repo;
        public SpaBL(IRepository info)
        {
            _repo = info;
        }
        public Users Adduser(string username, string password, string pName, string rank)
        {
            throw new NotImplementedException();
        }

        public List<userProfile> GetUsers()
        {
            return _repo.GetUsers();
        }
    }
}