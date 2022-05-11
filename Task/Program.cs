string[] NextArr (string[] arg)
{
    int size = 0;
    string[] TempArray = new string[arg.Length];
    for(int i = 0; i < arg.Length; i++)
    {
        if(arg[i].Length <= 3) 
        {
            size++;
            TempArray[i] = arg[i];
        }
    }
    string[] newArr = new string[size];
    for(int i = 0; i < size; i++)
    {
        newArr[i] = TempArray[i];
    }
    return newArr;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for(int pos = 0; pos < count - 1; pos++)
    {
        Console.Write($"{col[pos]}, ");
    }
    Console.Write($"{col[count - 1]} ");
}

string[] array = {"hello", "2", "world", ":-)"};

string[] array2 = NextArr(array);
