namespace pz_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль для проверки правильности");
            string pass = Console.ReadLine();
            bool correctLength = false; //cсоответствие длины
            bool correctUpper = false; //наличие заглавных букв
            bool correctNumber = false; // наличие цифр
            bool correctDigit = false; //наличие спец. символов
            for (int i = 0; i < pass.Length; i++)
            {
                if (Char.IsDigit(pass[i]))
                {
                    correctNumber = true;
                }
                if (Char.IsUpper(pass[i]))
                {
                    correctUpper = true;
                }
                if (pass[i] == '-' | pass[i] == '_' | pass[i] == '!' | pass[i] == '.')
                {
                    correctDigit = true;
                }
            }

            if (pass.Length > 8)
            {
                correctLength = true;
            }
            if (correctLength && correctDigit && correctNumber && correctUpper)
            {
                Console.WriteLine("Соответствие....Намана");
            }
            else
            {
                Console.WriteLine("Несоответствие.....Меняй");
            }
        }
    }
}