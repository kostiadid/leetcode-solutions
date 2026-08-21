using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    public static bool areBracketsProperlyMatched(string code_snippet)
    {
        var allowed = new HashSet<char>{'(',')','{','}','[',']'};
        var filtered = new string(code_snippet.Where(x=>allowed.Contains(x)).ToArray());
        Stack<char> s = new Stack<char>();
        Dictionary<char,char> d = new Dictionary<char, char>{
            {'(',')'},
            {'{','}'},
            {'[',']'},
        };
        
        foreach(char c in filtered){
            if( d.ContainsKey(c)){
                s.Push(c);
            }
            if(d.ContainsValue(c)){                
                if (s.Count == 0) return false;
                char open = s.Pop();
                if (d[open] != c) return false;    
            }
        }
        if(s.Count()==0){return true;}else return false;
    
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code_snippet = Console.ReadLine();

        bool result = Result.areBracketsProperlyMatched(code_snippet);

        Console.WriteLine((result ? 1 : 0));
    }
}
