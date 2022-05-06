namespace SpaModel
{
    public class userProfile
    {
        public int userId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string userRank
        {
            get;
            set;
        }
        public string Roles
        {
            get;
            set;
        }
        public override string ToString()
        {
           return $"Id: {userId} \nName: {Name} \n Rank: {userRank} \n Roles: {Roles}";
        }
    }
}