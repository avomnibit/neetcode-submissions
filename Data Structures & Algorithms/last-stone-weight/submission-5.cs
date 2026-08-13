public class Solution {
    public int LastStoneWeight(int[] stones) {
        int maxStone = 0;
        foreach (int stone in stones) {
            maxStone = Math.Max(maxStone, stone);
        }

        int[] bucket = new int[maxStone + 1];
        foreach (int stone in stones) {
            bucket[stone]++;
        }

        int first = maxStone, j;
        while (first > 0) {
            if (bucket[first] % 2 == 0) {
                first--;
                continue;
            }

            j = first - 1;
            while (j > 0 && bucket[j] == 0) {
                j--;
            }

            if (j == 0) {
                return first;
            }

            bucket[first]--;
            bucket[j]--;
            bucket[first - j]++;
            first = Math.Max(first - j, j);
        }

        return first;
    }
}
