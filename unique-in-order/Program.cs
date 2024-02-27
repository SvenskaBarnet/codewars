using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string UniqueInOrder<T>(IEnumerable<T> iterable) 
    {
        string retVal = string.Empty;
        for (int i = 0; i < iterable.Count() ;i++)
        {
            if(i == 0)
            {
                retVal = iterable.ElementAt(i).ToString();
            }
            else if(!iterable.ElementAt(i).Equals(iterable.ElementAt(i -1)))
            {
                retVal += iterable.ElementAt(i).ToString();
            }
        }
        return retVal; 
    }
}
