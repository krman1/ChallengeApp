int number = 1257857774;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

Console.WriteLine("Wyniki dla liczby " + number);
Console.WriteLine("==================================================");
for (int k = 0; k < 10; k++)
        {
        int numberDigits = 0;
        for (int i = 0; i < letters.Length; i++)
            {
             if (letters[i].ToString() == k.ToString())
                {
             numberDigits ++;
                }
             }
        Console.WriteLine(k + " => " + numberDigits);
        }