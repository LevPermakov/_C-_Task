// Task03
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели не существует");
// }


Console.WriteLine("Введите номер дня недели: ");
string numberDay = Console.ReadLine();
/* ???  При первом прогоне - warning CS8600: Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL. */
switch (numberDay)
{
    case "1":
        {
            Console.WriteLine("Понедельник");
            break;
        }
    case "2":
        {
            Console.WriteLine("Вторник");
            break;
        }
    case "3":
        {
            Console.WriteLine("Среда");
            break;
        }
    case "4":
        {
            Console.WriteLine("Четверг");
            break;
        }
    case "5":
        {
            Console.WriteLine("Пятница");
            break;
        }
    case "6":
        {
            Console.WriteLine("Суббота");
            break;
        }
    case "7":
        {
            Console.WriteLine("Воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine("Такого дня недели ни существует");
            break;
        }
}
        


    