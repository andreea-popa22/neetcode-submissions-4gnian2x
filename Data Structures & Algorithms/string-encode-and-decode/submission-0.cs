public class Solution {

        public  string Encode(IList<string> strs)
        {
        var result = "";
        foreach (var str in strs)
        {
                result = result + str.Length + "#" + str;
        }

        return result;
        }

public List<string> Decode(string s)
{
    var result = new List<string>();
    while (s.Length > 0)
    {
        var j = 0;
        while (s[j] != '#')
        {
            j += 1;
        }
        var wordLength = 0;
        var res = Int32.TryParse(s.Substring(0, j), out wordLength);
        j += 1; // for '#'

        s = s.Substring(j); // remove number and '#'

        result.Add(s.Substring(0, wordLength));
        s = s.Substring(wordLength); // remove word
    }
    return result;                                                                                                                                                                              }
}