namespace pz_05
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Введите 1 положительное целое число");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 положительное целое число");
            int n2 = int.Parse(Console.ReadLine());
            int product = 1;
            if ( n1 > n2 )
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int originalN1 = n1;
            while ( n1 <= n2 )
            {
                product *= n1;
                n1++;
            }
            Console.WriteLine("Произведение всех целых чисел oт {0} до {1} равно {2}", originalN1, n2, product);

        }
    }
}