using System;
using System.Collections.Generic;
using System.Linq;

string input = Console.ReadLine();
Stack<char> openBrackets = new Stack<char>();

foreach (var ch in input)
{
    switch (ch)
    {
        case '(':
        case '{':
        case '[':
            openBrackets.Push(ch);
            break;
        case ')':
            if (openBrackets.Any() && openBrackets.Peek() == '(')
            {
                openBrackets.Pop();
                break;
            }
            Console.WriteLine("NO");
            return;
        case '}':
            if (openBrackets.Any() && openBrackets.Peek() == '{')
            {
                openBrackets.Pop();
                break;
            }
            Console.WriteLine("NO");
            return;
        case ']':
            if (openBrackets.Any() && openBrackets.Peek() == '[')
            {
                openBrackets.Pop();
                break;
            }
            Console.WriteLine("NO");
            return;
    }
}

if (openBrackets.Any())
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}
