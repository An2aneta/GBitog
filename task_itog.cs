string[] strArr = {"hello", "world", "2", "-2", "computer science", ":-)"};
int count = 0;
string strTmp = "";
string result = "[ ";


for(int i=0; i < strArr.Length; i++ )
{
    strTmp = strArr[i];
    if (strTmp.Length <= 3) count ++;
}

string[] strFin = new string[count];
int j = 0;
for(int i=0; i<strArr.Length; i++ )
{
    strTmp = strArr[i];
    if (strTmp.Length <= 3)
    {
        strFin[j] = strTmp;
        j ++;
    } 
        
}

    j = 0;
    while (j < strArr.Length - 1)
    {
      result += ($"'{strArr[j]}', ");
      j++;
    }
    result += ($"'{strArr[strArr.Length - 1]}' ] -> [ ");

     j = 0;
    while (j < strFin.Length - 1)
    {
      result += ($"'{strFin[j]}', ");
      j++;
    }
    result += ($"'{strFin[strFin.Length - 1]}' ]");

    Console.WriteLine(result);


