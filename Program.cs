string input = "*+12-34"; //"(1+2) * (3-4)"

Stack<int> stack = new Stack<int>();

for(int i = input.Length-1; i >= 0;)
{
    if(input[i] == '+')
    {
        int a = stack.Pop();
        int b = stack.Pop();
        stack.Push(a+b);
    }
    else if(input[i] == '-')
    {
        int a = stack.Pop();
        int b = stack.Pop();
        stack.Push(a-b);
    }
    else if(input[i] == '/')
    {
        int a = stack.Pop();
        int b = stack.Pop();
        stack.Push(a/b);
    }
    else if(input[i] == '*')
    {
        int a = stack.Pop();
        int b = stack.Pop();
        stack.Push(a*b);
    }
    else{
        int num = int.Parse(input[i].ToString());
        stack.Push(num);
    }
}
Console.WriteLine(stack.Pop());