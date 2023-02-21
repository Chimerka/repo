string[] array1 = { "lorem", "ipsum", "123", "hi", ":-)", "1234", "1567", "-2", "computer science" };
string[] array2 = new string[9];
int j = 0;

for (int i = 0; i <= array1.Length - 1; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j = j + 1;
    }
}

for (int i = 0; i <= array2.Length - 1; i++)
{
    if (array2[i] != null)
    {
        Console.Write(array2[i] + "; ");
    }
}