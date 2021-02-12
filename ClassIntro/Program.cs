﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 75;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 75;
            
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            
            foreach ( var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }

}
