// ЗАДАЧА:
// Напишите программу,которая из имеющегося массива строк формирует массив из строк,длина которых >= 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении НЕ РЕКОМЕНДУЕТСЯ пользоваться коллекциями,лучше обойтись исключительно массивами.

// ["hello", "2","world",":)"] → ["2",":)"]
// ["1234", "1567","-2","computer science"] → ["-2"]
// ["Russia", "Denmark","Kazan"] → []

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string[size];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите число массива с индексом [{i}]=");
    myArray[i] = Convert.ToString(Console.ReadLine());
}
int ResultArrayLenght = 0; //Длина результирующего массива
int IndexFirstElement = 0; //Индекс первого результирующего элемента

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length > 0 && myArray[i].Length <= 3) ResultArrayLenght++;
}
Console.WriteLine($"Изначальный массив: [{String.Join(";", myArray)}]");
string[] finalArray = new string[ResultArrayLenght];
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length > 0 && myArray[i].Length <= 3)
    {
        finalArray[IndexFirstElement] = myArray[i];
        IndexFirstElement++;
    }
    if (IndexFirstElement == ResultArrayLenght) break;
}
Console.WriteLine($"Отсортированный массив: [{String.Join(",", finalArray)}]");