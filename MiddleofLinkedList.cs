public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        int k = 0;
        List<int> list = new List<int>();
        var distinctArray = nums1.Distinct().ToArray();
        var distinctArray2 = nums2.Distinct().ToArray();
        for(int i=0; i < distinctArray.Count() ; i++){
            for(int j=0; j<distinctArray2.Count(); j++){
                    if(distinctArray[i]==distinctArray2[j]){
                        list.Add(distinctArray2[j]);
                        break;
                    }
            }

        }
          int[] results = list.ToArray();
          return results;
    }
}