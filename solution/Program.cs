string[] str_array = ["Hello", "2", "world", ":-)"];
int count = 0;

foreach(string str in str_array)
{
    if(str.Length <= 3)
    {
        count++;
    }
}

string[] res_array= new string[count];
int j = 0;

for(int i = 0; i < str_array.Length; i++)
{
   
    if(str_array[i].Length <= 3)
    {
        res_array[j] = str_array[i];
        j++;
    }
}
