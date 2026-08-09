var input = int.Parse(Console.ReadLine()!);
var list = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Dictionary<int, int> dict = new();
int sum = 0, most =0, b = 0;

foreach(var c in list)
{
    if(!dict.ContainsKey(c)) dict[c] = 0;
    dict[c]++;
    if(dict[c] > b) {most = c; b = dict[c];}
}

if(dict.Count == 1)
{
    Console.WriteLine("0");
    return;
} 

foreach(var kp in dict)
{
    if (kp.Key == most) continue; 
    sum += kp.Value;
}
Console.WriteLine(sum);
