string[] FormNewArray(string[] array)
{
  int count = 0;
  string strTmp = "";
  for(int i=0; i < array.Length; i++ )
  {
    strTmp = array[i];
    if (strTmp.Length <= 3) count ++;
  }

  string[] resultArray = new string[count];
  int j = 0;
  for(int i=0; i<array.Length; i++ )
  {
    strTmp = array[i];
    if (strTmp.Length <= 3)
    {
        resultArray[j] = strTmp;
        j ++;
    } 
  }
return resultArray;
}
 
string PrintArray(string[] array)
  {
    int i = 0;
    string result = "[ ";

    while (i < array.Length)
    {
      if (i == array.Length-1)
       {
        result += ($"'{array[i]}'");
        i++;
       }
       else
       {
        result += ($"'{array[i]}', ");
        i++;
       } 
    }
    return result + "]";
  }

string[] strArr = {"hello", "world", "2", "-2", "computer science", ":-)"};


Console.WriteLine(PrintArray(strArr));
Console.WriteLine(PrintArray(FormNewArray(strArr)));
