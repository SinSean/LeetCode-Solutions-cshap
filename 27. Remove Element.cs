public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> mylist=new List<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==val)
            {
                continue;
            }
            else
            {
                mylist.Add(nums[i]);
            }
        }
        for(int i=0;i<mylist.Count();i++)
        {
            nums[i]=mylist[i];
        }
        return mylist.Count();
    }
}