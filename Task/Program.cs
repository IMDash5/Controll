string[] array = {"hello", "2", "world", ":-)"};
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
}