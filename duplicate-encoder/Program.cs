public class Kata
{
    public static string DuplicateEncode(string word)
    {
        string internalWord = string.Empty;
        for(int i = 0; i < word.Length; i++)
        {
            string charToEncode = word[i].ToString().ToLower();
            bool charExists = false;
            for(int ii = 0; ii < word.Length; ii++)
            {
                string charToCompareTo = word[ii].ToString().ToLower();
                if(i != ii && charToEncode == charToCompareTo)
                {
                    charExists = true;
                }
            }
            if(!charExists)
            {
                internalWord += '(';
            }
            else
            {
                internalWord += ')';
            }
        }
        return internalWord;
    }
}
