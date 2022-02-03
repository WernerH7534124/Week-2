using System;

namespace userAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaasta konsoolis;

            Console.Write("Kui vana sina küll oled?");
            int userVanus = Convert.ToInt32(Console.ReadLine());

            int YearofBirth = 2022 - userVanus;

            Console.WriteLine($"Sa oled sündinud aastal {YearofBirth} ! ");














        }


    }
}
