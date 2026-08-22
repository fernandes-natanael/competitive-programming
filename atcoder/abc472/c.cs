var nums = Console.ReadLine()!
    .Split()
    .Select(long.Parse)
    .ToArray();

int n = (int)nums[0];
int m = (int)nums[1];
long k = nums[2];

var cals = Console.ReadLine()!
    .Split()
    .Select(long.Parse)
    .ToArray();

Queue<long> queue = new();
Queue<long> queueDay = new();
long sum = 0;

for(int i = 0, day = 1; i < cals.Length; ++i, ++day)
{
    if(queue.Count != 0 && day - queueDay.Peek() >= m )
    {
        sum -= queue.Dequeue();
        queueDay.Dequeue();
    }

    if(sum + cals[i]  <= k)
    {
        sum += cals[i];
        queue.Enqueue(cals[i]);
        queueDay.Enqueue(day);
        Console.WriteLine("Yes");
    }else
    {
        Console.WriteLine("No");
    }

}