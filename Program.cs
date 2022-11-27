//_____________Итоговый проект по 1 четверти____________________
Console.WriteLine("Введите массив строк через пробел:");
string text = Console.ReadLine();
Console.WriteLine();
//Console.WriteLine(text);
string[] Words = text.Split(new char[] { ' ' });
PrintArray(Words);
//Создаем метод печати одномерного массива
void PrintArray (string[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.GetLength(0); i++) Console.Write($"{(array[i])}|"); //печатаем
}