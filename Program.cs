int n = GetNumber($"Enter number element array", "Input error!");
string [] array = GetArray(n);
System.Console.WriteLine($"[{String.Join(",", array)}]");
FinalArray(array);

int GetNumber(string message, string errorMessage)
{
    while (true)
    {
        System.Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
        {
         return Math.Abs(userNumber);
         System.Console.WriteLine(errorMessage);   
        }
    }
}
    string[] GetArray(int size)
    {
        string[] result = new String[size];
        for (int i = 0; i < size; i++)
        {
            System.Console.WriteLine($"Input words: ");
            result[i]= $"'{Console.ReadLine()}'";
        }
        return result;
    }
void FinalArray(string[]Arr)
{
    int size = 0;
    int k = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
     if(Arr[i].Length <= 3) size ++;
    }
    string[] final = new String[size];
    for (int j = 0; j < Arr.Length; j++)
    {
        if (Arr[j].Length <=3)
        {
            final[k] = Arr[j];
            k++;
        }
    }
    System.Console.WriteLine($"[{String.Join(",", final)}]");
}