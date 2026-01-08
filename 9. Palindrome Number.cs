public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
        {
            return false;
        }
        if(x==0)
        {
            return true;
        }
        List<int> ls=new List<int>();
        while(x>0)
        {
            int n=x%10;
            x=x/10;
            ls.Add(n);
        }
        for(int i=0;i<ls.Count/2;i++)
        {
            if(ls[i]!=ls[ls.Count-1-i])
            {
            //    Console.WriteLine($"ls[i] {ls[i]}");
                
            //    Console.WriteLine($"ls[i] {ls[ls.Count-1-i]}");
                return false;
            }   
        }
        return true;
    }
}

