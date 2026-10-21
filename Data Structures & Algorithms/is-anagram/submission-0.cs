public class Solution {
    public bool IsAnagram(string s, string t) {
        var map = new Dictionary<char, int>();
        var secMap = new Dictionary<char, int>();
        var count = 1;
        if(s.Length != t.Length){
            return false;
        }
        foreach(char ch in s){
            if(map.ContainsKey(ch)){
                map[ch] += count;
            }
            else{
                map.Add(ch, count);
            }
        }
        foreach(char ch in t){
            if(secMap.ContainsKey(ch)){
                secMap[ch] += count;
            }
            else{
                secMap.Add(ch, count);
            }
        }
        if(map.Count == secMap.Count && !map.Except(secMap).Any()){
            return true;
        }
        return false;
    }
}
