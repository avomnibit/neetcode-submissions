public record Tweet(int userId, int tweetId);

public class Twitter {
    private Dictionary<int,HashSet<int>> fList;
    private List<Tweet> nFeed;

    public Twitter() {
        fList=new();
        nFeed=new();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!fList.ContainsKey(userId)){
            fList.Add(userId,new HashSet<int>());
        }
        nFeed.Add(new Tweet(userId,tweetId));
    }
    
    public List<int> GetNewsFeed(int userId) {
        if(!fList.ContainsKey(userId)){
            fList.Add(userId,new HashSet<int>());
            return new List<int>();
        }
        List<int> result = new();
        int i=0,j=nFeed.Count-1;
        while(i<10 && j>-1){
            if(nFeed[j].userId!=userId && !fList[userId].Contains(nFeed[j].userId)) {j--; continue;}
            result.Add(nFeed[j].tweetId);
            i++;
            j--;
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
