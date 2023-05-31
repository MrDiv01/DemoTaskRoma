using DemoTask;
using System.Globalization;
bool exit = false;
User user = new User();
while (exit == false)
{
    bool acses = false;
    while (acses == false)
    {
        //Test
        Console.WriteLine("Login Ucun (1) Register ucun (2)");
        string ProsesNumber = Console.ReadLine();
        if (ProsesNumber == "1")
        {
            if (user.Logined == false)
            {
                Console.WriteLine("Register olunmayib");
            }
            else
            {
                Console.WriteLine("Adinizi Daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("Parolunuzu Daxil edin");
                string password = Console.ReadLine();
                if (name == user.Name && password == user.Password)
                {
                    Console.WriteLine("Xos Gelsiniz");
                    acses = true;
                    exit = true;
                }
                else
                {
                    Console.WriteLine("PArol ve Ya Ad Sehfdir");
                }
                acses = true;
            }
        }
        else if (ProsesNumber == "2")
        {
            Console.WriteLine("Adinizi daxil edin");
            user.Name = Console.ReadLine();
            Console.WriteLine("Soyadiniz daxil edin");
            user.SureName = Console.ReadLine();
            Console.WriteLine("FinCodunuzu daxil edin");
            user.FinCode = Console.ReadLine();
            Console.WriteLine("Yasinizi daxil edin");
            string age = Console.ReadLine();
            bool checkAge = byte.TryParse(age, out user.Age);
            if (user.Age < 18)
            {
                Console.WriteLine("YAsiniz 18 den kicikdir");
            }
            Console.WriteLine("Parolunuzu daxil edin");
            user.Password = Console.ReadLine();
            Console.WriteLine("Tekrar parolunuzu daxil edin");
            user.ConfirmPassword = Console.ReadLine();
            if (user.Password != user.ConfirmPassword)
            {
                Console.WriteLine("Parollar Beraber deyil");
            }
            user.Logined = true;
            acses = true;
        }
        else
        {
            Console.WriteLine("Bele Bir Proses reqemi yoxdur");
        }
    }
}