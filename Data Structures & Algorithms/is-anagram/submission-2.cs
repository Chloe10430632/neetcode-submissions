public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> sCount = new Dictionary<char, int>();
        Dictionary<char, int> tCount = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            char c = char.ToLower(s[i]);
            if (sCount.ContainsKey(c)) {
                sCount[c]++;
            } else {
                sCount[c] = 1;
            }
        }
        for (int j = 0; j < t.Length; j++) {
            char c = char.ToLower(t[j]);
            if (tCount.ContainsKey(c)) {
                tCount[c]++;
            } else {
                tCount[c] = 1;
            }
        }

        if (sCount.Count != tCount.Count)
            return false;
        foreach (var pair in sCount) {
            if (!tCount.ContainsKey(pair.Key) || tCount[pair.Key] != pair.Value)
                return false;
        }
        return true;
    }
}