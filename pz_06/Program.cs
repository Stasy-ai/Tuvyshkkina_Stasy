namespace pz_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int size = int.Parse(Console.ReadLine());

            // Создание массивов
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            int[] sumArray = new int[size];

            // Заполнение первого массива случайными числами
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                array1[i] = random.Next(100); // Генерация случайного числа от 0 до 99
            }

            // Заполнение второго массива числами, введенными с клавиатуры
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите число для индекса {i}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Вычисление суммы соответствующих элементов двух массивов
            for (int i = 0; i < size; i++)
            {
                sumArray[i] = array1[i] + array2[i];
            }

            // Вывод содержимого массивов на экран
            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            Console.WriteLine("Массив сумм:");
            PrintArray(sumArray);

            Console.ReadLine();

            // Метод для вывода содержимого массива
            static void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}