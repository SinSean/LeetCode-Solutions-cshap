public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string ans="";
        bool flag=false;
        for(int i=0;i<strs[0].Length;i++)
        {
            int t=0;
            for(int j=0;j<strs.Length;j++)
            {
                if(i>=strs[j].Length)
                {
                    flag=true;
                    break;
                }
                if(strs[0][i]!=strs[j][i])
                {
                    flag=true;
                    break;
                }
                else
                {
                    t++;
                }
            }
            if(flag)
            {
                break;
            }
            if(t==strs.Length)
            {
                ans+=strs[0][i];
            }
        }
        return ans;
    }
}
/*
沒搞懂之前怎麼寫的
*/