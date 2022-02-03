using System;

namespace InstaAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust 
            //Programm kontrollib kas kasutaja vanus </> kui 13 a.
            //Programm kuvab teksti vastavalt vanusele


            Console.WriteLine("Palun sisestage oma vanus: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
                Console.WriteLine("Teid suunatakse kohe edasi");

            else if (userAge < 13)
                Console.WriteLine("Lahkuge kohe või me helistame teie Emale!");

            else
                Console.WriteLine("Teid suunatakse kohe edasi - Napikas ! ");


            Console.WriteLine("Ilusat Päeva ! ");


        }
    }
}
