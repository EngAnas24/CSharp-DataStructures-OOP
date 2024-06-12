using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject.Data
{
    public interface DataHelper<Tabel>
    {
        List<Tabel> getdata();

        void Add(Tabel tabel);  
         void Delete(int id) ;
         void Edite(int id ,Tabel tabel);

         Tabel Find(int id);




    }
}
