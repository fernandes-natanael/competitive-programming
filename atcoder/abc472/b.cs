var inp = Console.ReadLine();
var nums = Console.ReadLine()!.Split().Select(int.Parse);

var less = int.MaxValue;
var x = 0;

foreach(var n in nums.SkipLast(1))
{
    x += n;
    var diff = sum - x;
    var y = int.Abs(diff - x);
    if(y < less) less = y;
}
