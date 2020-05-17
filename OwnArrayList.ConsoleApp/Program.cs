using System;
using OwnArrayList.Core;

namespace OwnArrayList.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string headLine = $"{"KatNr",5} | {"Vorname",-20} | {"Nachname",-20} | {"Alter",5}";

            Console.WriteLine("Dynamische Schülerliste");
            for (int k = 0; k < headLine.Length; k++)
            {
                Console.Write("=");
            }
            Console.WriteLine();

            //Testdaten
            PupilList pupils = new PupilList();
            Pupil pupil1 = new Pupil(1, "Simon", "P", 17);
            pupils.Add(pupil1);
            Pupil pupil2 = new Pupil(2, "Anna", "Lutz", 16);
            Pupil pupil3 = new Pupil(3, "Fritz", "Auer", 15);
            Pupil pupil4 = new Pupil(6, "Hans", "Huber", 14);
            Pupil pupil5 = new Pupil(5, "Moritz", "Maier", 13);
            pupils.Add(pupil2);
            pupils.Remove(pupil1);
            pupils.Add(pupil5);
            pupils.Insert(1, pupil4);
            pupils.GetAt(1);
            pupils.Sort();
            pupils.Add(pupil3);

            Console.WriteLine(headLine);
            for (int k = 0; k < headLine.Length; k++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            for (int i = 0; i < pupils.Count; i++)
            {
                Console.WriteLine($"{pupils.GetAt(i).CatalogNumber,5} | {pupils.GetAt(i).FirstName,-20} | {pupils.GetAt(i).LastName,-20} | {pupils.GetAt(i).Age,5}");
            }
        }
    }
}