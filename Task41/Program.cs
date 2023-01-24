using static System.Console;
Clear();
WriteLine("Введите числа через пробел (хоть сколько, хоть отрицательные: ");
string numbersEnteredUser = ReadLine()!;
string[] parameter = numbersEnteredUser.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);



int[] array = GetArray(parameter);
WriteLine($"Количество чисел введенные вами которые больше нуля:  {CheckNumbers(array)}.");



int[] GetArray(string[] par)
{
    int[] arrayUser = new int[par.Length];
    for (int i = 0; i < par.Length; i++)
    {
        arrayUser[i] = int.Parse(parameter[i]);
    }
    return arrayUser;
}

int CheckNumbers(int[] arr1)
{
    int counter = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > 0) counter++;
    }
    return counter;
}