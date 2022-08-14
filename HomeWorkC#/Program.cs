// // Домашняя работа Максимальное из двух чисел
// namespace HelloApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите первое число: ");
//             int num1 = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите второе число: ");
//             int num2 = Convert.ToInt32(Console.ReadLine());
 
//             if(num1 > num2)
//             {
//                 Console.Write("max = ");
//                 Console.Write(num1);
//             }
//             else if (num1 < num2)
//             {
//                 Console.Write("max = ");
//                 Console.Write(num2);
//             }
//             else
//             {
//                 Console.WriteLine("Оба числа равны");
//             }
//             Console.ReadKey();
//         }
//     }
// }
// ДЗ 2

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
             
            if(a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            
            Console.ReadKey();
        }
    }
}

