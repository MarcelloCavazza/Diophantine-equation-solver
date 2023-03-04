// See https://aka.ms/new-console-template for more information
int a = 0, b = 0, c = 0;
byte index = 0;
char[] letters = new char[] {
    'a',
    'b',
    'c'
};
bool insertNumbers = true, valueInsertedByUser = false;

Console.WriteLine("Diophantine equation solver!");
while (insertNumbers)
{
    Console.Write($"Insert {letters[index].ToString().ToUpper()}:");
    var aValueInserted = Console.ReadLine();
    int valueAsNumber = 0;
    valueInsertedByUser = int.TryParse(aValueInserted, out valueAsNumber);

    if (valueInsertedByUser)
    {
        switch (letters[index]) 
        {
            case 'a':
                a = valueAsNumber;
                break;
            case 'b':
                b = valueAsNumber;
                break;
            case 'c':
                c = valueAsNumber;
                insertNumbers = false;
                break;
        }
        index++;
    }
}
Console.Clear();
Console.WriteLine($"Equation:  {a}x + {b}y = {c}");
double result = (double)a / (double)b;
char[] resultAsString = result.ToString().ToCharArray();
//char[] resultAsChar= resultAsString.ToCharArray();
var teste =1;