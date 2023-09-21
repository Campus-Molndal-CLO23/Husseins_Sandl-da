
//Ett program som tar emot fem tal från användaren och returnerar summan mellan det minsta och största talet

using System.Diagnostics.CodeAnalysis;

int[] numbers = new int[5];  // initerna tom int array


int i = 0;                  // initiera räknare till 0

while (i < 5)               // loopa så länge i är mindre än 5
{
    numbers[i] = int.Parse(Console.ReadLine()); //ta emot input från användaren
    i++;
}
Console.WriteLine(numbers.Min() + numbers.Max());   //returna min + max


