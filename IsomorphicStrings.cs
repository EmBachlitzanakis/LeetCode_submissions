public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var Dict = new Dictionary <char , char>();
       
        for(int i=0; i <s.Length ; i++){
         
            if(!Dict.ContainsKey(t[i])){
                Dict[t[i]]=s[i]; 
            }
            else{
                char userIDFromDictionaryByKey = Dict[t[i]];
                if(userIDFromDictionaryByKey!=s[i]){
                return false;
                }
            }
        }
  if(Dict.Values.Distinct().Count() == Dict.Count())
    {
        return true;
    }
        return false;
       
 }
}