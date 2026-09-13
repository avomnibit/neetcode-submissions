public record Tweet(int tweetId, int timestamp);

public class Twitter {
    private Dictionary<int,HashSet<int>> fList;
    private Dictionary<int,List<Tweet>> tList;
    int tTimestamp=0;

    public Twitter() {
        fList=new();
        tList=new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!fList.ContainsKey(userId)){
            fList.Add(userId,new HashSet<int>());
        }
        if(!tList.ContainsKey(userId)){
            tList.Add(userId,new List<Tweet>());
        }
        tList[userId].Add(new Tweet(tweetId,tTimestamp++));
    }
    
    public List<int> GetNewsFeed(int userId) {
        if(!fList.ContainsKey(userId)){
            fList.Add(userId,new HashSet<int>());
        }
        if(!tList.ContainsKey(userId)){
            tList.Add(userId,new List<Tweet>());
        }
        List<int> result = new();
        int[] indexes = new int[fList[userId].Count+1];
        indexes[0] = tList[userId].Count-1;
        int i,j;
        List<int> follows = new List<int>(fList[userId]);
        for(i=0;i<fList[userId].Count;i++){
            if(!tList.ContainsKey(follows[i])){
                tList.Add(follows[i], new List<Tweet>());
            }
            indexes[i+1] = tList[follows[i]].Count-1;
        }
        for(i=0;i<10;i++){
            int tId = indexes[0]>-1 ? tList[userId][indexes[0]].tweetId : -1;
            int max = indexes[0]>-1 ? tList[userId][indexes[0]].timestamp : int.MinValue;
            int index=0;

            for(j=0;j<follows.Count;j++){
                if(indexes[j+1]>-1 && max<tList[follows[j]][indexes[j+1]].timestamp){
                    max=tList[follows[j]][indexes[j+1]].timestamp;
                    tId=tList[follows[j]][indexes[j+1]].tweetId;
                    index = j+1;
                }
            }

            if(tId == -1) break;

            result.Add(tId);
            indexes[index]--;
        }
        return result;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(followerId==followeeId) return;
        if(!fList.ContainsKey(followerId)) {
            fList.Add(followerId,new HashSet<int>());
        }
        fList[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(!fList.ContainsKey(followerId)) return;
        fList[followerId].Remove(followeeId);
    }
}
