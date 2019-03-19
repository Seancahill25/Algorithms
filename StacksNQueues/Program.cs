﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksNQueues
{
    class Solution
    {
        public Stack<char> stack = new Stack<char>();
        public Queue<char> queue = new Queue<char>();

        void pushCharacter(char c)
        {
            stack.Push(c);
        }

        char popCharacter()
        {
            return stack.Pop();
        }
        void enqueueCharacter(char c)
        {
            queue.Enqueue(c);
        }

        char dequeueCharacter()
        {
            return queue.Dequeue();
        }


        static void Main(String[] args)
        {
            string s = Console.ReadLine();

            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}