using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTableKoleksiyonu
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Hashtable ogrenciler = new Hashtable();

            ogrenciler.Add(368,"Ahmet");
            ogrenciler.Add("Ahmet",368);

            ogrenciler.Remove(368);
            ogrenciler.Remove("Ahmet");

            ogrenciler[368] = "Mehmet";

            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Values)
            {
                Console.WriteLine(deger);
            }

            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key+"-"+eleman.Value);
            }
            Console.ReadKey();

        }
    }
}
