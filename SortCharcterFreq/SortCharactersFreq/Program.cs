using System.Text;

public class Solution
{
    public string FrequencySort(string s)
    {
        Dictionary<char,int> dic = new Dictionary<char, int>();
        foreach(char c in s)
        {
            if(!dic.ContainsKey(c))
                dic.Add(c, 1);
            else
                dic[c]+=1; 
        }
        //Dictionary<char,int> sortedDict = dic.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        //var sortedDict = from entry in myDict orderby entry.Value ascending select entry;
        dic = dic.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        
        StringBuilder res = new StringBuilder();
        foreach(KeyValuePair<char, int> el in dic.Reverse())
        {
            for(int i = 0; i< el.Value; i++)
                res = res.Append(el.Key);

        }

        return res.ToString();
        
    }
    static void Main(string[] args)
    {
        Solution ob = new Solution();
        ob.FrequencySort("zzzbbc");
        // Dictionary < string, int > dict = new Dictionary < string, int > {
        //     {
        //         "apple",
        //         1
        //     },
        //     {
        //         "banana",
        //         2
        //     },
        //     {
        //         "cherry",
        //         3
        //     }
        // };
        // var sortedDict = dict.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
        // foreach(KeyValuePair < string, int > pair in sortedDict) {
        //     Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        // }
    }


}

