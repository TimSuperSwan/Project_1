//_____________Итоговый проект по 1 четверти____________________
Console.WriteLine("Введите массив строк через пробел:");
string Text = Console.ReadLine();
Console.WriteLine();
string[] Words = Text.Split(new char[] { ' ' });
Console.WriteLine("В массиве");
PrintArray(Words);
Console.WriteLine();
Console.WriteLine("сохранены данные:");
string[] Words_Result = SortArray(Words);
PrintArray(Words_Result);

//Создаем метод печати одномерного массива
void PrintArray (string[] array)
{
    //Console.Write("|");
    for (int i = 0; i < array.GetLength(0); i++) Console.Write($"{(array[i])} "); //печатаем
}
//Создаем метод сортировки массива строк
string[] SortArray (string[] array){
    string[] result = new string[array.GetLength(0)];
    int count =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length<=3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}