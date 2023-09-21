
//Ett program som sorterar en arry med siffror från, minst till störst

int[] numbers = { 1, 4, 6, 3, 9, 8, 7, 5, 6 };

for(int i = 0; i<numbers.Length -1; i++)
{
    for(int j = 0; j<numbers.Length -i - 1; j++)
    {
        if (numbers[j] > numbers[j +1])
        {
            int temp = numbers[j];
            numbers[j] = numbers[j +1];
            numbers[j + 1] = temp;
        }
    }
 }
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

