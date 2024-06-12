using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UserInfo.Data
{
    public interface IDataHelper<Tabel>
    {
        List<Tabel> Getdata();
        Tabel Find(int id);
        List<Tabel> Search(string SearchItem);
        public void Add(Tabel user);
        public void Remove(int id);

        public void Edite(int id, Tabel user);

    }
}
