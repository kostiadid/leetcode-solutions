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
    public static bool isNonTrivialRotation(string s1, string s2)
    {
        if(s1 == s2){
            return false;
        } 
        if(s1.Length != s1.Length){
            return false;
        }
        
        var res = s1 + s1;
        if(!res.Contains(s2)){
            return false;
        }
        return true;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        bool result = Result.isNonTrivialRotation(s1, s2);

        Console.WriteLine((result ? 1 : 0));
    }
}
