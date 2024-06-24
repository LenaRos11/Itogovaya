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
