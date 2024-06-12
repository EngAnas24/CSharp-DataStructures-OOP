using Userinfo.core;

namespace UserInfo.Data
{
    public class UserEntitiy : IDataHelper<User>
    {
       private  User user;
        List<User> PersonInfo;

        public UserEntitiy()
        {
            PersonInfo = new List<User>
            {
                new User{Id = 1,Name="Anas",age=24}
            };
        }

        public void Add(User user)
        {
            PersonInfo.Add(user);
        }

        public void Edite(int id, User s)
        {
            user = Find(id);
            if (user == null)
            {
                user.Id = s.Id; 
                user.Name = s.Name;
                user.age = s.age;

            }
        }

        public User Find(int id)
        {
            return PersonInfo.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<User> Getdata()
        {
            return PersonInfo;
        }

        public void Remove(int id)
        {
        }

        public List<User> Search(string SearchItem)
        {
          return  PersonInfo.Where(x=>x.Id.ToString()==SearchItem
            || x.Name.Equals( SearchItem)
            || x.age.ToString()== SearchItem).ToList();
        }
    }
}