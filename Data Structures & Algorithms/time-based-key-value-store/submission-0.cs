public class TimeMap {
    private Dictionary<string,List<(int timestamp,string value)>> map;
    public TimeMap() {
        map = new Dictionary<string,List<(int timestamp,string value)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key)){
            map[key] = new List<(int timestamp, string value)>();
        }
        map[key].Add((timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key)){
            return "";
        }
        List<(int timestamp,string value)> list = map[key];
        string res = "";
        int left = 0;
        int right = list.Count - 1;
        while(left <= right){
            int mid  = left + (right -left)/2;
            if (list[mid].timestamp <= timestamp){
                left = mid + 1;
                res = list[mid].value;
            }
            else{
                right = mid - 1;
            }
        }
        return res;
    }
}
