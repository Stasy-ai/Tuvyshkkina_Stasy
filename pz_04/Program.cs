namespace pz_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 4 
            for (int i = -500; i <= -300; i++)
            {
              if (i % 15 == 0)
                {
                    Console.Write(i + " ");
                }
            }
/*задание 5
            Console.WriteLine("значение 2х переменных");
            int i, j;
            for (i = 0, j=55; Math.Abs(i-j) >= 9; i++, j--)
            {
               Console.WriteLine(" i = " +i+ " j = " +j);
            }
/задание 3
  Console.WriteLine("# много раз");
            int n = 5;
            int m = 8;
            for ( int i = 0; i<m; i++)
            {
                for ( int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
/задание 2
            Console.WriteLine("Вывод символов в авфавитном порядке");
            for (char c = 'к'; c <= 'с'; c++)
            {
                Console.Write(c);
            }
            
/задача 1
             Console.WriteLine("вывод диапозона"); 
             int start = -100;
             int end = 0;
             int step = 2;
             for (int i = start; i <= end; i+= step)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();*/
        }
    }
}
