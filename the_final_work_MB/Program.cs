Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];

void array(string [] stringArray)
{
  for (int i = 0; i<stringArray.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива: ");
     stringArray[i] = Console.ReadLine();
  }
}


void printA(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0; i<stringArray.Length; i++)
    {
    Console.Write($"‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}

void Main()
{
    array(stringArray);
    printA(stringArray);

}

Main ();

