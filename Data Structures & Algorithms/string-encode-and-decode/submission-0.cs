public class Solution {

    public string Encode(List<string> strs) {
        StringBuilder res = new StringBuilder();
        foreach (string str in strs){
            res.Append(str.Length);
            res.Append('#');
            res.Append(str);
        }
        return res.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while (i < s.Length){
            int j = i;
            while (s[j] != '#'){
                j++;
            }
            int sizeOfString = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            string word = s.Substring(i, sizeOfString);
            res.Add(word);
            i = i + sizeOfString;
        }

        return res;
   }
}