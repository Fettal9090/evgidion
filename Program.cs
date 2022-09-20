Console.Clear();
Console.Write("Задайте количество строк: ");
int Length = Convert. ToInt32 (Console.ReadLine());
string [] array = new string [Length];
Console.WriteLine ("Введите значение строки: ");
int counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    if(array[i].Length <= 3) counter++;
}
string[] secondArray = new string [counter];
counter = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[counter] = array[i];
        counter++;
    }
}
PrintArray(array);
Console.Write(" - ");
PrintArray(secondArray);

void PrintArray(string[] array)         //Метод печатает массив
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write(array[i]  + " ");
}
Console.Write("]");
}



