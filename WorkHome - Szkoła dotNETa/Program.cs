using System.Threading.Channels;

namespace WorkHome___Szkoła_dotNETa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }

        public void Tydzien2(string lekcja4)
        {
            //Zadanie 1 
            // Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to

            string name;
            string surname;
            byte age;
            char gender;
            string pesel;
            string ID;

            //Zadanie 2 
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane

            char letter1 = 'A';
            char letter2 = 'B';
            char letter3 = 'C';

            Console.WriteLine($" Reverse result {letter3}, {letter2}, {letter1}");

            //Zadanie 3
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

            double length = 5;
            double width = 3;
            double exponent = 2;


            width = Math.Pow(width, exponent);
            length = Math.Pow(length, exponent);

            double diagonal = Math.Sqrt((Math.Pow(width, exponent) + (Math.Pow(length, exponent))));

            Console.WriteLine($"Result diagonal : {diagonal}");


            // Zadanie 4 
            //Napisz program w którym stworzysz 2 zmienne liczbowe oraz jedną tekstową, a następnie przypiszesz im natępujące wartości

            int number = 10;
            string text = "Szkoła Dotneta";
            double value = 12.5;

            // Zadanie 5 
            // Napisz program w którym poproszisz użytkownika o jego dane personalne tj. imię, nazwisko, nr. tel,e-mail,wzrost etc.

            string name1;
            string surname1;
            byte age1;
            char gender1;
            string pesel1;
            string numberPhone;
            string E_MAIL;
            double weight;
            double shoeSize;

            Console.WriteLine("Hello! Please enter your name, surname, age, number phone, e-mail, weigth, shoe size, gender");

            Console.WriteLine("Enter your name");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            surname1 = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            gender1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number phone");
            numberPhone = Console.ReadLine();
            Console.WriteLine("Enter your e-mail");
            E_MAIL = Console.ReadLine();
            Console.WriteLine("Enter your weigth");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Shoe Size");
            shoeSize = double.Parse(Console.ReadLine());


            Console.WriteLine("Good, thanks for all!");

        }
    }
}