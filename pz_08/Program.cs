namespace pz_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вариант 23 
            Random random = new Random();
            int izmer1 = 5;
            int izmer2 = random.Next(3, 16);
            // 1. Создание и заполнение ступенчатого массива
            double[][] array = new double[izmer1][];
            for (int i = 0; i < izmer1; i++)
            {
                array[i] = new double[izmer2];
                for (int j = 0; j < izmer2; j++)
                {
                    // Заполнение массива рандомными вещественными числами
                    array[i][j] = random.NextDouble();
                }
            }
            // 2. Вывод сгенерированного массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (var row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            // 3. Создание и вывод нового одномерного массива (последние элементы каждой строки)
            double[] oneDimensionalArray = array.Select(row => row.Last()).ToArray();
            Console.WriteLine("\nОдномерный массив с последними элементами каждой строки:");
            Console.WriteLine(string.Join(" ", oneDimensionalArray));
            // 4. Поиск и вывод максимальных элементов в каждой строке
            double[] maxElements = array.Select(row => row.Max()).ToArray();
            Console.WriteLine("\nМаксимальные элементы в каждой строке:");
            Console.WriteLine(string.Join(" ", maxElements));
            // 5. Обновление массива (первый элемент и максимальный в строке меняются местами)
            for (int i = 0; i < izmer1; i++)
            {
                double maxElement = array[i].Max();
                int maxIndex = Array.IndexOf(array[i], maxElement);
                double temp = array[i][0];
                array[i][0] = maxElement;
                array[i][maxIndex] = temp;
            }
            Console.WriteLine("\nОбновленный массив:");
            foreach (var row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            // 6. Реверс каждой строки массива
            for (int i = 0; i < izmer1; i++)
            {
                Array.Reverse(array[i]);
            }
            Console.WriteLine("\nРеверс каждой строки массива:");
            foreach (var row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            // 7. Подсчет: a. Среднее значение в каждой строке (для чисел)
            double[] averageValues = array.Select(row => row.Average()).ToArray();
            Console.WriteLine("\nСредние значения в каждой строке:");
            Console.WriteLine(string.Join(" ", averageValues));
            // b. Общее количество символов в строках каждой строки массива (для строк)
            int[] charCountPerRow = array.Select(row => string.Join(" ", row).Length).ToArray();
            Console.WriteLine("\nОбщее количество символов в строках каждой строки:");
            Console.WriteLine(string.Join(" ", charCountPerRow));
            // c. Наиболее встречающиеся символы в каждой строке
            char[] mostCommonChars = new char[izmer1];
            for (int i = 0; i < izmer1; i++)
            {
               
            }
            Console.WriteLine("\nНаиболее встречающиеся символы в каждой строке:");
            Console.WriteLine(string.Join(" ", mostCommonChars));
        }
    }
}