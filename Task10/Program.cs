// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Write("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число позиции: ");
int positionN = Convert.ToInt32(Console.ReadLine());
if (positionN <= 0) positionN = 1;

int numberOnPos = Number10x(numberN, positionN);
//Console.Write($"0 Число на позиции {positionN} в числе {numberN}: {numberOnPos}");
Console.Write($"{numberN} -> {numberOnPos}");

int Number10x(int num, int position)
{
    //************** если задаваемый номер позиции болше значности - не обрабатывается; выводит цифру последне позиции
    if (num < 0) { num = -num; }
    if (num == 0) { return num; }
    else
    { //*********** определяем значность num
        int numCopy = num;
        int degree10 = 0;
        //Console.WriteLine($"1 numCopy: {numCopy}");
              while (numCopy > 9)
        {
            //Console.WriteLine($"2 numCopy: {numCopy}");
            int rest = numCopy % 10;
            if (rest > 0)
            {
                numCopy = numCopy / 10;
                degree10 = degree10 + 1;
            }
 
        }
        degree10 = degree10 + 1;
        //Console.WriteLine($"3 число разрядов всего: {degree10} в числе {num}");
        //*********** вернуть число на позиции position
        int restDegree = degree10 - positionN + 0;   //число разрядов до position (справа)
        //Console.WriteLine($"4 restDegree: {restDegree}");
        //*********** снять" разряды справа
        int index = restDegree;
        while (index > 0 )
        {
            num = num / 10;
            //Console.WriteLine($"3 num: {num}");
            index = index - 1;
        }
        int restN = num % 10;
        return restN;
    }
}