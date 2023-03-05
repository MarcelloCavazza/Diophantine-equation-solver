// See https://aka.ms/new-console-template for more information
using Diophantine_equation_solver;
using System.Collections.Generic;

int innitialLetterA = 0, innitialLetterB = 0, innitialLetterC = 0;
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
                innitialLetterA = valueAsNumber;
                break;
            case 'b':
                innitialLetterB = valueAsNumber;
                break;
            case 'c':
                innitialLetterC = valueAsNumber;
                insertNumbers = false;
                break;
        }
        index++;
    }
}
Console.Clear();
Console.WriteLine($"Equation:  {innitialLetterA}x + {innitialLetterB}y = {innitialLetterC}");

Dictionary<int, MDCResults> listOfMDCs = new Dictionary<int, MDCResults>();

int mdcResult = 0;
int r = 0;
int a = 0;
int b = 0;
int q = 0;
Boolean calcularMDC = true;
index = 0;
int dictionaryId = 0;
while (calcularMDC)
{
    if (index == 0)
    {
        dictionaryId = 1;
        a = innitialLetterA;
        b = innitialLetterB;
        index = 1;
    }
    else
    {
        dictionaryId = listOfMDCs.Last().Key + 1;
        a = b;
        b = r;
    }
    q = a / b;
    r = a % b;
    MDCResults mdcCurrentValues = new MDCResults(r, a, b, q);
    listOfMDCs.Add(dictionaryId, mdcCurrentValues);


    if (r == 0)
    {
        mdcResult = q;
        calcularMDC = false;
    }
}

if(mdcResult % innitialLetterC == 0)
{
    Console.WriteLine("First Rule went well, maybe exists a solution!");
}
else
{
    Console.WriteLine("Doesn't exist a solution");
}