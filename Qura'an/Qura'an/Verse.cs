using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qura_an
{
    internal class Verse
    {
        private readonly Word[] verseArr;

        public Verse(string v) {
            string[] arr = v.Split(' ');    
            verseArr = new Word[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                verseArr[i]= new Word(arr[i]);
            }
        
        }

        public string getVerse(bool tashkeel)
        {
            string r = "";
            for(int i = 0;i< verseArr.Length; i++)
            {
                if (tashkeel)
                {
                    r += verseArr[i].getwordWithTeskeel() + " ";

                }
                else
                {
                    r += verseArr[i].getwordWithOutTeskeel() + " ";

                }
            }
            return r;

        }
        public bool isThere(string w)
        {
            for(int i = 0; i < verseArr.Length; i++)
            {
                if (verseArr[i].getwordWithOutTeskeel().Equals(w))
                {
                    return true;
                }
            }
            return false;

        }
        public string toString()
        {
            return getVerse(true);
        }


    }
}
