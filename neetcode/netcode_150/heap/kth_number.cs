
public class KthLargest {
    public PriorityQueue<int, int> pq { get; set; }
    public int K { get; set; }

    public KthLargest(int k, int[] nums)
    {
        Array.Sort(nums);
        K = k;
        pq = new();
        foreach(var num in nums)
        {
            pq.Enqueue(num, num);
        }
        while(pq.Count > k) { pq.Dequeue(); }
    }
    
    public int Add(int val)
    {
        pq.Enqueue(val, val);
        if (pq.Count > K){pq.Dequeue();}

        return pq.Peek();
    }
}




//Brute Force
// public class KthLargest {
//     public List<int> l { get; set; }
//     private int K {get; set;}

//     public KthLargest(int k, int[] nums) {
//         l = [.. nums];
//         K = k;
//     }
    
//     public int Add(int val) {
//         l.Add(val);
//         l.Sort();
//         return l.TakeLast(K).First();
//     }
// }
