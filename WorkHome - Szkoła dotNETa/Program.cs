using System.Security;
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

        public void Tydzien2_1(string lekcja7)
        {
            // Napisz promgram w C#, który stworzy dwie zmienne int i sprawdzi czy sa one równe czy nie

            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine(" 5 i 5 są równe");
            }
            else
            {
                Console.WriteLine("Liczby nie są sobie równe");
            }


            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta

            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba nie jest parzysta");
            }

            //Napisz program w C#, który sprawdzi czy poadana przez uzytkownika liczba jest dodatnia czy ujemna

            int numberTest = 14;

            if (numberTest > 0)
            {
                Console.WriteLine("Liczba jest dodatnia");
            }
            else if (numberTest < 0)
            {
                Console.WriteLine("Liczba jest ujemna");
            }
            else
            {
                Console.WriteLine("Liczba wprowdzona to ZERO");
            }

            //Napisz program w C#, który sprawdzi czy podany rok przez użytkownika jest rokiem przestępnym

            int year = 2016;

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Rok jest przestępny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny");
            }

            // Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, senatora i prezydenta

            byte age = 21;

            if (age >= 21 && age < 30)
            {
                Console.WriteLine("Możesz startować na posła i premiera");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz startować na posła, premiera i senatora");
            }
            else
            {
                Console.WriteLine("Możesz startować na posła, premiera, senatora i prezydenta");
            }

            // Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.

            int wzrost = 140;

            if (wzrost <= 140 || wzrost > 0)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (wzrost <= 170 || wzrost > 0)
            {
                Console.WriteLine("Jesteś większym krasnoludem");
            }
            else if (wzrost <= 220 || wzrost > 0)
            {
                Console.WriteLine("Jesteś wysokim człowiekiem");
            }

            // Napisz program w C#,, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa

            int firstNumber = 25;
            int secondNumber = 63;
            int thirdNumber = 79;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"największa liczba to {firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"największa liczba to {secondNumber}");
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"Najwięszka liczba to {thirdNumber}");
            }

            // Napisz program, który sprawdzi czy kadydat może ubiegać się o miejsce na studiach wg. następująych kryteriów:
            int math = 80;
            int physic = 71;
            int chemistry = 0;
            int allPoints = math + physic + chemistry;

            if ((math > 70 && physic > 55 && chemistry > 45) && allPoints > 180 || math + physic > 150 || math + chemistry > 150)
            {
                Console.WriteLine(" Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Musisz poprawić swoje wyniki");
            }

            // Napisz program, który odczyta temperaturę i zwróci nazwę jak w poniższych kryteriach

            int temperature = 20;

            if (temperature <= 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temperature <= 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature <= 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temperature <= 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temperature <= 40)
            {
                Console.WriteLine("Zaczyna być słabo , bo gorąco");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }

            // Napisz program, który sprawdzi czy z 3 podanych długości można stworzyć trójkąt

            int firstSide = 40;
            int secondSide = 55;
            int thirdSide = 65;

            if ((firstSide + secondSide > thirdSide) && (firstSide + thirdSide > secondSide) && (secondSide + thirdSide > firstSide))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójąkta");
            }

            // Napisz program, który zmieni ocenę ucznia na jej opis wg. podanej tabeli

            int grade = 6;

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;

            }

            // Napisz program, który pobierze numer tygodnia i wyświetli jego nazwę

            int day = 7;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            // Napisz program, który będzie posiadał proste menu i będzie kalkulatorem

            Console.WriteLine("Podaj pierwszą liczbę");
            float firstDigit = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            float secondDigit = float.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz jedną z opcji    1- Dodawanie   2- Odejmowanie   3- Mnożenie   4- Dzielenie");
            string choosenOperation = Console.ReadLine();
            float result;


            switch (choosenOperation)
            {
                case "1":
                    result = firstDigit + secondDigit;
                    Console.WriteLine($"Wynik dodawania : {result}");
                    break;
                case "2":
                    result = firstDigit - secondDigit;
                    Console.WriteLine($"Wynik odejmowania : {result}");
                    break;
                case "3":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Wynik mnożenia : {result}");
                    break;
                case "4":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Wynik dzielenia : {result}");
                    }
                    else
                    {
                        Console.WriteLine("Pamiętaj cholero by nie dzielić przez zero.");
                    }
                    break;
            }
        }
    }
}