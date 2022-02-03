using System;

namespace UserGDPR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Arvutab sellega kasutaja vanuse ning kuvab konsoolis;

            Console.WriteLine("Sisestage oma sünniaasta");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearofBirth;

            //Console.WriteLine("You are " + userAge + " years old :) ");

            //String interpolation

            Console.WriteLine($"You are {userAge} years old :) ");




        }
    }
}
