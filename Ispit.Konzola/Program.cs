using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Ispit.Konzola
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("hr-HR");
            var ucenici = new List<Ucenik>();

            for (int i = 1; i < 4; i++)
            {
                Ucenik ucenik = new Ucenik();

                Console.Clear();

                Console.WriteLine("Unesite ime, prezime, datum rođenja i prosjek za tri učenika. \n");

                Console.WriteLine($"Unesite ime za {i}. učenika");
                ucenik.Ime = Console.ReadLine();

                Console.WriteLine($"Unesite prezime za {i}. učenika");
                ucenik.Prezime = Console.ReadLine();

                Console.WriteLine($"Unesite datum rođenja za {i}. učenika");
                ucenik.DatumRodenja = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine($"Unesite prosjek za {i}. učenika");
                ucenik.Prosjek = double.Parse(Console.ReadLine());

                ucenici.Add(ucenik);
            }

            foreach (var ucenik in ucenici)
            {
                Console.WriteLine($"\n Učenik {ucenik.Ime + " " + ucenik.Prezime}, dob {ucenik.Starost(ucenik.DatumRodenja)} godine, ima prosjek: {ucenik.IspisProsjeka(ucenik.Prosjek)}");
            }


        }
    }
}
