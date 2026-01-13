public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> mylist=new List<int>(); 
        int num=nums[0];
        mylist.Add(num);
        int k=0;
        for(int i=1;i<nums.Length;i++)
        {
            if(num==nums[i])
            {
                k++;   
            }
            else
            {
                num=nums[i];
                mylist.Add(num);
            }
        }
        for(int i=0;i<mylist.Count();i++)
        {
            nums[i]=mylist[i];
        }
        return nums.Length-k;
    }
}