// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей 
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число позиции: ");
int positionN = Convert.ToInt32(Console.ReadLine());
if (positionN <= 0) positionN = 1;

int numberOnPos = Number10x(numberN, positionN);
//Console.Write($"0 Число на позиции {positionN} в числе {numberN}: {numberOnPos}");
if (numberOnPos >= 0 )
{
    Console.Write($"{numberN} -> {numberOnPos}");
}


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
        if (position > degree10)
        {
            Console.WriteLine($"Позиции {position} в этом числе нет.");
            return -1;
        }
        //Console.WriteLine($"3 число разрядов всего: {degree10} в числе {num}");
        //***** вернуть число на позиции position
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