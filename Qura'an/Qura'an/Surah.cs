using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qura_an
{
    internal class Surah
    {
        private int count ;
        private string name;
        private Verse[] surahArr;

        public Surah(string n, int s)
        {
            count = 0;
            name = n;
            surahArr = new Verse[s];
        }

        public void AddVerse(string v)
        {
            surahArr[count++] = new Verse(v) ;
        }
        public string findWord(string w)
        {
            int c = 0;
            string r = "";
            for(int i = 0; i < surahArr.Length; i++)
            {
                if (surahArr[i].isThere(w))
                {
                    r += "Ayah" + (i + 1) + ": " + surahArr[i].toString() + "\n";
                    c++;
                }
               
            }
            if (c > 0)
            {
                r += "Surah" + name + "\t" + c + "Time" + "\n" + r + "\n";
            }
            return r;
        }
    }
}
