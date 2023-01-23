// // //Вид4
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//      while ( i < count)
//      {
//         result = result + text;
//         i++;
//      }
//     return result;
// }

// string res = Method4(10, "tenet");
// Console.WriteLine(res);

//Вид4.1
string Method4(int count, string text)
{
    
    string result = String.Empty;
    for(int i =0; i<count; i++)
     while ( i < count)
     {
        result = result + text;
        i++;
     }
    return result;
}

string res = Method4(10, "tenet");
Console.WriteLine(res);
