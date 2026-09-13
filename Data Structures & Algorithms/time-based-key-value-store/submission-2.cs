public record TimeValue(int Timestamp, string Val);

public class TimeMap {
    private Dictionary<string, List<TimeValue>> d = new();
    
    public void Set(string key, string value, int timestamp) {
        if(!d.ContainsKey(key)) d.Add(key,new List<TimeValue>());
        d[key].Add(new TimeValue(timestamp,value));
    }
    
    public string Get(string key, int timestamp) {
        if(!d.ContainsKey(key)) return "";
        int l=0,r=d[key].Count-1, mid=0, close=0;
        if(timestamp<d[key][0].Timestamp) return "";
        if(timestamp>=d[key][d[key].Count-1].Timestamp) return d[key][d[key].Count-1].Val;
        while(l<=r){
            mid=l+(r-l)/2;
            if(timestamp==d[key][mid].Timestamp) return d[key][mid].Val;
            if(timestamp<d[key][mid].Timestamp){
                r=mid-1;
                continue;
            }
            close=mid;
            l=mid+1;
        }
        return d[key][close].Val;
    }
}
