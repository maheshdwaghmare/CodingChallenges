﻿// C# program for checking 
// balanced Parenthesis 
using System; 
using System.Collections.Generic; 

namespace CodingChallenges
{
    public class Parenthesis
    {
        /* Returns true if character1 and character2 
        are matching left and right Parenthesis */
        static Boolean isMatchingPair(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')')
                return true;
            else if (character1 == '{' && character2 == '}')
                return true;
            else if (character1 == '[' && character2 == ']')
                return true;
            else
                return false;
        }

        /* Return true if expression has balanced 
        Parenthesis */
        static Boolean areParenthesisBalanced(char[] exp)
        {
            /* Declare an empty character stack */
            Stack<char> st = new Stack<char>();

            /* Traverse the given expression to 
                check matching parenthesis */
            for (int i = 0; i < exp.Length; i++)
            {

                /*If the exp[i] is a starting parenthesis then push it*/
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                    st.Push(exp[i]);

                /* If exp[i] is an ending parenthesis 
                    then pop from stack and check if the 
                    popped parenthesis is a matching pair*/
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {

                    /* If we see an ending parenthesis without 
                        a pair then return false*/
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    /* Pop the top element from stack, if 
                        it is not a pair parenthesis of character 
                        then there is a mismatch. This happens for 
                        expressions like {(}) */
                    else if (!isMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            /* If there is something left in expression 
                then there is a starting parenthesis without 
                a closing parenthesis */

            if (st.Count == 0)
                return true; /*balanced*/
            else
            { /*not balanced*/
                return false;
            }
        }

        /* UTILITY FUNCTIONS */
        /*driver program to test above functions*/
        //public static void Main(String[] args)
        //{
        //    char[] exp = { '{', '(', ')', '}', '[', ']' };
        //    if (areParenthesisBalanced(exp))
        //        Console.WriteLine("Balanced ");
        //    else
        //        Console.WriteLine("Not Balanced ");
        //}
    }

    // This code is contributed by 29AjayKumar 

}