using System.Collections.Generic;
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      Dictionary<int, int> intOccurences = new Dictionary<int, int>();
      foreach (int integer in seq)
        {
       if(intOccurences.ContainsKey(integer))
       {
           intOccurences[integer] += 1;
       }
       else
       {
           intOccurences.Add(integer, 1);
       }
      }

      KeyValuePair <int, int> retVal = new KeyValuePair <int, int>();

      foreach(KeyValuePair <int, int> kvp in intOccurences)
      {
          if(kvp.Value % 2 != 0)
          {
              retVal = kvp;
          }
      }
      int intRetVal = retVal.Key;
      return intRetVal;
      }
       
    }
}
