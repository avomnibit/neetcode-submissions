public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        Dictionary<int,List<int>> map = new Dictionary<int,List<int>>();
        for(int i=0;i<edges.Length;i++){
            var e1 = edges[i][0];
            var e2 = edges[i][1];
            if(can(map, e1, e2, null)) return edges[i]; 
            if(map.ContainsKey(e1)) map[e1].Add(e2);
            else map.Add(e1, new List<int>{e2});
            if(map.ContainsKey(e2)) map[e2].Add(e1);
            else map.Add(e2, new List<int>{e1});
        }
        return new int[]{-1, -1};
    }

    private bool can(Dictionary<int,List<int>> map, int e1, int e2, int? p){
        if(e1 == e2) return true;
        if(!map.ContainsKey(e1)) return false;
        var m = p==null?map[e1] : map[e1].Where(x => x != p.Value).ToList();
        for(int i=0;i<m.Count;i++){
            if(can(map, m[i], e2, e1)) return true;
        }
        return false;
    }
}
