namespace pz_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрос размерности матрицы
            Console.Write("Введите размерность матрицы: ");
            int size = int.Parse(Console.ReadLine());
            // Создание матрицы
            double[,] matrix = new double[size, size];
            // Заполнение матрицы числами, введенными с клавиатуры
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Введите элемент для индексов [{i}, {j}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            // Переворачивание диагоналей
            for (int i = 0; i < size; i++)
            {
                double temp = matrix[i, i]; 
                matrix[i, i] = matrix[i, size - i - 1];
                matrix[i, size - i - 1] = temp;

                temp = matrix[i, i];
                matrix[i, i] = matrix[size - i - 1, i];
                matrix[size - i - 1, i] = temp;
            }
            // Вывод содержимого матрицы на экран
            Console.WriteLine("Матрица после переворота диагоналей:"); 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}