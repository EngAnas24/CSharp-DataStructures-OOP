using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qura_an
{
    internal class Word:Taskeeltask
    {
        public string ARABICLETTERS= "اأإآبتةثجحخدذرزسشصضطظعغفقكلمنهويىؤئء";
        private string wordWithOutTeskeel;
        private string wordWihTeskeel;

        public Word(string w) {
            wordWihTeskeel = w;
            wordWithOutTeskeel = clearTaskeel( w);

        }

        public string clearTaskeel(string w)
        {
            string r = "";
            for(int i = 0; i < w.Length; i++)
            {
                char c = w.ToCharArray()[i];
                if(ARABICLETTERS.IndexOf(c)>=0)
                    r+= c;
            }
            return r;
        }

       
        public string getwordWithOutTeskeel() {
            return wordWithOutTeskeel;
        }
        public string getwordWithTeskeel() {
            return wordWihTeskeel;
        }
        public string toString() {
            return wordWihTeskeel;
        }



    }
}
