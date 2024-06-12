using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quran
{
    internal class Quran
    {
        private string line;
        private int count;
        private List<Surah> quranArray;
        public static readonly string[] soor
            = {"الفـاتحة", "البقرة", "آل عمران", "النساء", "المائدة", "الأنعام",
                "الأعراف", "الأنفال", "التوبة", "يونس", "هود", "يوسف", "الرعد",
                "إبراهيم", "الحجر", "النحل", "الإسراء", "الكهف", "مريم", "طه",
                "الانبياء", "الحج", "المؤمنون", "النور", "الفرقان", "الشعراء",
                "النمل", "القصص", "العنكبوت", "الروم", "لقمان", "السجدة",
                "الأحزاب", "سبأ", "فاطر", "يس", "الصافات", "ص", "الزمر", "غافر",
                "فصلت", "الشورى", "الزخرف", "الدخان", "الجاثية", "الأحقاف", "محمد",
                "الفتح", "الحجرات", "ق", "الذاريات", "الطور", "النجم", "القمر",
                "الرحمن", "الواقعة", "الحديد", "المجادلة", "الحشر", "الممتحنة",
                "الصف", "الجمعة", "المنافقون", "التغابن", "الطلاق", "التحريم",
                "الملك", "القلم", "الحاقة", "المعارج", "نوح", "الجن", "المزمل",
                "المدثر", "القيامة", "الإنسان", "المرسلات", "النبأ", "النازعات",
                "عبس", "التكوير", "الإنفطار", "المطففين", "الإنشقاق", "البروج",
                "الطارق", "الأعلى", "الغاشية", "الفجر", "البلد", "الشمس", "الليل",
                "الضحى", "الشرح", "التين", "العلق", "القدر", "البينة", "الزلزلة",
                "العاديات", "القارعة", "التكاثر", "العصر", "الهمزة", "الفيل",
                "قريش", "الماعون", "الكوثر", "الكافرون", "النصر", "المسد",
                "الإخلاص", "الفلق", "الناس",};

        public static readonly int[] numbers
            = {7, 286, 200, 176, 120, 165, 206, 75, 129, 109, 123, 111, 43, 52, 99, 128,
                111, 110, 98, 135, 112, 78, 118, 64, 77, 227, 93, 88, 69, 60, 34,
                30, 73, 54, 45, 83, 182, 88, 75, 85, 54, 53, 89, 59, 37, 35, 38,
                29, 18, 45, 60, 49, 62, 55, 78, 96, 29, 22, 24, 13, 14, 11, 11, 18,
                12, 12, 30, 52, 52, 44, 28, 28, 20, 56, 40, 31, 50, 40, 46, 42, 29,
                19, 36, 25, 22, 17, 19, 26, 30, 20, 15, 21, 11, 8, 8, 19, 5, 8, 8,
                11, 11, 8, 3, 9, 5, 4, 7, 3, 6, 3, 5, 4, 5, 6,};
        public Quran()
        {
            quranArray = new List<Surah>();
            count = 0;
        }
        public void AddSurah(Surah s)
        {
            quranArray.Add(s);
        }

        public void ReadQuranFile(string pathName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.StartsWith(count + ""))
                        {
                            Surah s = new Surah(soor[count], numbers[count]);
                            AddSurah(s);
                            s.AddVerse(line.Substring(line.LastIndexOf('|') + 1));
                            count++;
                        }
                        else
                        {
                            quranArray[count - 1].AddVerse(line.Substring(line.LastIndexOf('|') + 1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string Find(string s)
        {
            string r = "";
            for (int i = 0; i < quranArray.Count; i++)
            {
                r += quranArray[i].FindWord(s);
            }
            return r;
        }
    }
    internal class Surah
    {
        private int count;
        private string name;
        private List<Verse> surahArr;

        public Surah(string n, int s)
        {
            count = 0;
            name = n;
            surahArr = new List<Verse>();
        }

        public void AddVerse(string v)
        {
            surahArr.Add(new Verse(v));
        }
        public string FindWord(string w)
        {
            int c = 0;
            string r = "";
            for (int i = 0; i < surahArr.Count; i++)
            {
                if (surahArr[i].IsThere(w))
                {
                    r += "Ayah " + (i + 1) + ": " + surahArr[i].ToString() + "\n";
                    c++;
                }

            }
            if (c > 0)
            {
                r += "Surah " + name + "\t" + c + " Time" + "\n" + r + "\n";
            }
            return r;
        }
    }
    internal interface ITaskeelTask
    {
        string ClearTaskeel(string w);
    }
    internal class Verse
    {
        private readonly List<Word> verseArr;
        public Verse(string v)
        {
            string[] arr = v.Split(' ');
            verseArr = new List<Word>();
            foreach (var word in arr)
            {
                verseArr.Add(new Word(word));
            }

        }

        public string GetVerse(bool tashkeel)
        {
            string r = "";
            for (int i = 0; i < verseArr.Count; i++)
            {
                if (tashkeel)
                {
                    r += verseArr[i].GetWordWithTashkeel() + " ";

                }
                else
                {
                    r += verseArr[i].GetWordWithoutTashkeel() + " ";

                }
            }
            return r;

        }
        public bool IsThere(string w)
        {
            for (int i = 0; i < verseArr.Count; i++)
            {
                if (verseArr[i].GetWordWithoutTashkeel().Equals(w))
                {
                    return true;
                }
            }
            return false;

        }
        public string ToString()
        {
            return GetVerse(true);
        }
    }
    internal class Word : ITaskeelTask
    {
        public string ARABICLETTERS = "اأإآبتةثجحخدذرزسشصضطظعغفقكلمنهويىؤئء";
        private string wordWithoutTashkeel;
        private string wordWithTashkeel;

        public Word(string w)
        {
            wordWithTashkeel = w;
            wordWithoutTashkeel = ClearTaskeel(w);
        }

        public string ClearTaskeel(string w)
        {
            string r = "";
            for (int i = 0; i < w.Length; i++)
            {
                char c = w.ToCharArray()[i];
                if (ARABICLETTERS.IndexOf(c) >= 0)
                    r += c;
            }
            return r;
        }

        public string GetWordWithoutTashkeel()
        {
            return wordWithoutTashkeel;
        }
        public string GetWordWithTashkeel()
        {
            return wordWithTashkeel;
        }
        public string ToString()
        {
            return wordWithTashkeel;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Quran quran = new Quran();
            quran.ReadQuranFile("D:\\c#\\Asp.net_Web\\QuranTest\\QuranTest\\quran.txt");
            string r = quran.Find("محمد");
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
