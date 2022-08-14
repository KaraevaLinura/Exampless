// Домашняя работа
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            if(num1 > num2)
            {
                Console.Write("max = ");
                Console.Write(num1);
            }
            else if (num1 < num2)
            {
                Console.Write("max = ");
                Console.Write(num2);
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
            Console.ReadKey();
        }
    }
}

