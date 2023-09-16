namespace pz_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стоимость 10 минутного междугороднего разговора");
            Console.WriteLine("Введите код города ( Москва '905', Ростов '194', Краснодар '491', Киров '800')");
            int cityCode = Convert.ToInt32(Console.ReadLine());
            double callCost;
            switch (cityCode)
            {
                case 905:
                    callCost = 4.15;
                    break;

                case 194:
                    callCost = 1.98;
                        break;

                case 491:
                    callCost = 2.69;
                        break;

                case 800:
                    callCost = 5.00;
                    break;

                default:
                    Console.WriteLine("неверно введен код города!!!!!");
                    Console.ReadLine();
                    return;
            }
            double TotalCost = callCost * 10;
            Console.WriteLine($"стоимость 10 минут разговора {TotalCost} рублей");
            Console.ReadLine();
        }   


    }
}