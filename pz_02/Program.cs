namespace pz_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение выражения"); 
            double i, j, x, y, z;
            Console.WriteLine("Введите целое значение i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действительное значение j"); 
            j = Convert.ToDouble(Console.ReadLine());
            
            if (j > 0)  // первый цикл
            {
                  x = i * j + Math.Sin(j);   // действие, если условие истина
            }
            else
            {
                  x = (i + j) / (Math.Pow(i + 2 * j, 1 / 2));  // действие, если условие ложь
            }
            
            if (x <= 6) // второй цикл
            {
                y = Math.Cos(i + x); // действие, если условие истина
            }
            else
            {
                y = x + 15 * (Math.Pow(x - 0.5 * j, 1 / 2));  // действие, если ус ложь            }
            } 
                
            z = (x + y) / (Math.Pow(i, 2) + Math.Pow(j, 2) + 1);
            
            z = Math.Round(z, 2);  //округление результата до сотых
            
            Console.WriteLine("значение выражения: " + z);
        }

    }
}