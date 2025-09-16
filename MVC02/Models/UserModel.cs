
namespace MVC02.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public UserModel()
        {
            Name = UserPassword = String.Empty;
        }
        public UserModel NewUser()
        {
            return new UserModel()
            {
                Name = "user1",
                UserPassword = "pass1"
            };
        }
        public List<UserModel> GetListOfusers()
        {
            List<UserModel> list = new List<UserModel>()
            {
                new UserModel(){Name="user1",UserPassword="pass1"},
                new UserModel(){Name="user2",UserPassword="pass2"},
                new UserModel(){Name="user3",UserPassword="pass3"},
                new UserModel(){Name="user4",UserPassword="pass4"},
            };
            return list;
        }
}
}