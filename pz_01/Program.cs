namespace pz_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейной задачи");
           //ввод значений переменных
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            //расчёт частей выражения
            double partA = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
            double partB = Math.Abs(a - b);
            double partC = Math.Sin(c) * Math.Sin(c) + Math.Tan(c);

            //расчёт результата
            double result = partA / (partB * partC);

            //вывод резултаа на экран
            Console.WriteLine($"Результат выражения: {result}");
            Console.ReadLine (); //чтобы программа не закрылась сразу после вывода результата
        }
    }
}