/* Задание

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа

*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string [] InitArray(int num)
{
    string [] array = new string [num];
    Random rnd = new Random();
    Console.WriteLine ("Введите " + num + " элемента(-ов)");
    for (int i = 0; i < num; i++)
    {
        array[i] = Console.ReadLine() ?? ""; 
    }
    Console.WriteLine();
    return array;
}

int ElementsCounter(string[] array, int numLenght)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numLenght)
            count++;
    }
    return count;
}

string [] FillResultArray(string [] array, int arrayLength, int stringLength)
{
string [] resultArray = new string [arrayLength];
int resultArrayIndex = 0;
for (int i = 0; i < arrayLength; i++)
{
    if (array[i].Length<=stringLength)
    {
        resultArray[resultArrayIndex]=array[i];
        resultArrayIndex++;
    }
}
return resultArray;
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}


int length = GetNumber("Введите длину массива");
string [] userArray = InitArray (length);
PrintArray(userArray);
int resultArrayLenght = ElementsCounter(userArray, 3);
Console.WriteLine();
string [] resultArray = FillResultArray(userArray, resultArrayLenght, 3);
PrintArray(resultArray);