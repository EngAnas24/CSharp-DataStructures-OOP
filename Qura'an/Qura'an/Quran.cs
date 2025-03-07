﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Qura_an
{
    internal class Quran
    {
        private string line;
        private int count;
        private Surah[] quranArray;
        public  static readonly String[] soor
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
        public  Quran() {
            quranArray = new Surah[114];

        }
        public void Addsurah(Surah s)
        {
            quranArray[count++] = s;
        }

        public void ReadQuranFile(string pathName)
        {
            try
            {
                string line;
                using (StreamReader sr = new StreamReader(pathName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.StartsWith(count + ""))
                        {
                            Surah s = new Surah(soor[count], numbers[count]);
                            Addsurah(s);
                            s.AddVerse(line.Substring(line.LastIndexOf('|') + 1));
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
            }
        }
        public string find(string s)
        {
            string r = "";
            for(int i= 0; i < quranArray.Length; i++)
            {
                r += quranArray[i].findWord(s);
            }
            return r;

        }
    }
}
