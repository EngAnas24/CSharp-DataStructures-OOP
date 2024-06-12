using firstproject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstproject.Data;

namespace firstproject.Data
{
    public class UserEntity : DataHelper<User>
    {
        List<User> listinfo;
        private User user;
        public UserEntity()
        {
            listinfo = new List<User>();
            listinfo = new List<User> { 
            new User{id=1,name="Anas",age=24,phonenumber=54554541 }
            
            };
        }

        public void Add(User tabel)
        {
            listinfo.Add(tabel);


        }

        public void Delete(int id)
        {
            user = Find(id);
            listinfo.Remove(user);

        }

        public void Edite(int id, User tabel)
        {
            user = Find(id);
            user = new User
            {
                id=tabel.id,
                name = tabel.name,
                age = tabel.age,
                phonenumber = tabel.phonenumber,

            };
            var index = listinfo.FindIndex(x => x.id == id);
            listinfo[index] = user; 
        }

        public User Find(int id)
        {
            return listinfo.Where(x => x.id == id).First();
        } 

        public List<User> getdata()
        {
            return listinfo;
        }

    }
}
