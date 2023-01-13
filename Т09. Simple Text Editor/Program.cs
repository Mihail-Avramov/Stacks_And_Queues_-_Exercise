using System;
using System.Collections.Generic;
using System.Text;


int operationsCount = int.Parse(Console.ReadLine());

Stack<string> undoStack = new Stack<string>();

StringBuilder text = new StringBuilder();

for (int i = 0; i < operationsCount; i++)
{
    string[] inputArguments = Console.ReadLine().Split(' ', 2);
    string command = inputArguments[0];

    switch (command)
    {
        case "1":
            string textToAdd = inputArguments[1];
            undoStack.Push(text.ToString());
            text.Append(textToAdd);
            break;
        case "2":
            int charsToRemove = int.Parse(inputArguments[1]);
            int startIndex = text.Length - charsToRemove;
            undoStack.Push(text.ToString());
            text = text.Remove(startIndex, charsToRemove);
            break;
        case "3":
            int indexToShow = int.Parse(inputArguments[1]) - 1;
            Console.WriteLine(text[indexToShow]);
            break;
        case "4":
            text = new StringBuilder(undoStack.Pop());
            break;
    }
}
