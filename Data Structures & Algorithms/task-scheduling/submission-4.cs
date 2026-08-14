public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        if(n<1) return tasks.Length;
        int i;
        int[] f = new int[26];
        for(i=0;i<tasks.Length;i++){
            f[tasks[i]-'A']++;
        }
        int max=0, nrMax=1, sum=0;
        for(i=0;i<26;i++){
            if(f[i] == max) nrMax++;
            if(f[i] > max) { max= f[i]; nrMax=1;}
            sum+=f[i];
        }
        return Math.Max((max-1)*(n+1) + 1 + nrMax-1,sum);
    }
}
