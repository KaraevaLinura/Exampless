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

// namespace HelloApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите первое число: ");
//             int a = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите второе число: ");
//             int b = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Введите третье число: ");
//             int c = Convert.ToInt32(Console.ReadLine());
             
//             if(a > b && a > c)
//             {
//                 Console.WriteLine(a);
//             }
//             else if (b > a && b > c)
//             {
//                 Console.WriteLine(b);
//             }
//             else
//             {
//                 Console.WriteLine(c);
//             }
            
//             Console.ReadKey();
//         }
//     }
// }
// ДЗ 3 Определение четности, но с двузначными числами не работает????

// namespace ConsoleApplication1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a;
//             Console.Write("введите число: ");
//             a= Console.Read();
 
//             if (a % 2==1)
//             {
//                 Console.WriteLine("нет");
           
//             }
//             else
//             {
//                 Console.WriteLine("да");
//             }
 
//             Console.ReadKey();
//         }
//     }
// }

// ДЗ 4

Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);