using System;

namespace Juhiluba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvutab kasutaja vanuse
            //Kui kasutaja on noorem kui 18, kuvab konsool - "Oled veel liiga noor"
            //Kui kasutaja on vanem kui 18, kuvab konsool - "Oled piisavalt vana"
            //Kui kasutaja on täpselt 18, kuvab konsool - "Palju õnne! Aeg load teha!"

            Console.Write("Palun sisestage oma sünniaasta: ");
            int userVanus = Convert.ToInt32(Console.ReadLine());

            int YearofBirth = 2022 - userVanus;

            Console.WriteLine($"Sa oled sündinud aastal {YearofBirth} ! ");

            if (userVanus < 18)
                Console.WriteLine("Oled veel liiga noor");

            else if (userVanus > 18)
                Console.WriteLine("Oled piisavalt vana - võid Juhiluba taodelda");

            else 
                Console.WriteLine("Palju õnne! Aeg load teha!");


            Console.WriteLine("Ilusat Päeva ! ");


        }
    }
}
