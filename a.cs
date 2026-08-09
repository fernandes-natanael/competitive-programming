var input = int.Parse(Console.ReadLine());

for(int i = 1 ; i <= input ; ++i)
{
    if(i % 3 == 0) Console.WriteLine("Fizz");
    else Console.WriteLine(i);
}