using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
namespace ConsoleApp11
{
    class Program
    {
        
        static void InmätningStudent(Student s)
        {
            Console.WriteLine("Ange studentinformation:");
            Console.Write("Namn: ");
            s.GetSetNamn = Console.ReadLine();
            Console.Write("Antal poäng på provet: - heltal (0,60): ");
            s.GetSetAntPoäng = short.Parse(Console.ReadLine()); //double.Parse - konvertera från string till dubbel
            Console.Write("Medelpoäng i gymnasiet: ");
            s.GetSetMedPoäng = float.Parse(Console.ReadLine()); //long.Parse - konvertera från string till long
        }
        static void UtskriftStudent(Student s)
        {
            Console.WriteLine("Namn: {0}", s.GetSetNamn);
            Console.WriteLine("Antal poäng på provet: {0}", s.GetSetAntPoäng);
            Console.WriteLine("Medelpoäng i gymnasiet: {0}", s.GetSetMedPoäng);
            Console.WriteLine("Antal poäng i rankinglistan: {0}", s.poängRank());
        }
        //
        //Kollar om det är över genomsnittet
        static void överGenomsnittet(Student[] array, int n)
        {
            float snittet = 0.0f;//float literal
            bool finns = false;
            int i;
            for (i = 0; i < n; i++)
            {
                snittet += array[i].poängRank();
            }
            if (n > 0) snittet /= n;
            else return;
            Console.WriteLine("Data om studerande vars antal poäng i rankningslistan är över genomsnittet: {0} och som inte var utmärkta är:",
                snittet); //utmärkta >4,5
            for (i = 0; i < n; i++)
            {
                if (array[i].poängRank() > snittet && array[i].GetSetMedPoäng < 4.5)
                {
                    finns = true;
                    UtskriftStudent(array[i]);
                }
            }
            if (finns == false)
                
        Console.WriteLine("Det finns inga!");
        }
        static float Skillnad(Student[] array, int n, Student s)
        {
            float max = array[0].poängRank();
            for (int i = 1; i < n; i++)
            {
                if (array[i].poängRank() > max)
                    max = array[i].poängRank();
            }
            return (max - s.poängRank());
        }
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("Ange antal studerande: ");
            n = int.Parse(Console.ReadLine()); //int.Parse - konvertera från sträng till int
            Student[] array = new Student[n];//en array av n pekare till data av typen Student - KONSTRUKTOR ANROPAS INTE
            Student s = new Student("Johan Johannson", 55, 5);//ANROP AV initieringskonstruktor
            for (i = 0; i < n; i++)
            {
                array[i] = new Student();//*** ANROP AV standardkonstruktor
                InmätningStudent(array[i]);
            }
            Console.WriteLine();
            överGenomsnittet(array, n);
            Console.WriteLine();
            Console.WriteLine("Skillnaden i antal poäng på rankinglistan över bästa elev i årets och förra årets prov är: {0}", 
                Skillnad(array, n, s));
        Console.ReadKey();
        }
    }
}