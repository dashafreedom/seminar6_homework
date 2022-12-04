Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
char splitSymbol = ',';
int numbersCount = 1;
int positiveCount = 0;

for(int i = 0; i < input.Length; i++)
{
    if(input[i] == splitSymbol)
        numbersCount++;
}
int[] numbers = new int[numbersCount];
int numberIndex = 0;
string subString = "";
for(int i = 0; i < input.Length; i++)
{
    if(input[i] == splitSymbol)
    {
        numbers[numberIndex++] = Convert.ToInt32(subString);
        subString = "";
    }
    else
    {
        subString += input[i];
    }
}
numbers[numberIndex] = Convert.ToInt32(subString);
WriteArray(numbers);

for(numberIndex = 0; numberIndex < numbers.Length; numberIndex++)
{
    if(numbers[numberIndex] > 0)
    {
       positiveCount++;
    }   
}
Console.WriteLine("-> " + positiveCount);


void WriteArray(int[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
}
