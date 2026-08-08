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

    /*
     * Complete the 'isAlphabeticPalindrome' function below.
     *
     * The function is expected to return a BOOLEAN.
     * The function accepts STRING code as parameter.
     */

    public static bool isAlphabeticPalindrome(string code)
    {

        var strOnly = new string(code.Where(x=>char.IsLetter(x)).ToArray()).ToLower();
        var l=0;
        var r =strOnly.Length - 1;
        while(l<r){
                if(strOnly[l] != strOnly[r]){
                  return false;   
                }
                l++;
                r--;
        }
        return true;
        // var strOnly = new string(code.Where(x=>char.IsLetter(x)).ToArray()).ToLower();
        // bool flag = false;
        // var mid = strOnly.Length / 2;
        // if(strOnly.Length % 2 == 0){
        //     string result = new string(strOnly.Substring(mid).Reverse().ToArray());

        //     if( strOnly.Substring(0,mid) == result){
        //        return true ;
        //     }
            
        // } else {
        //     var midl =  (strOnly.Length/2);
        //     string res = new string(strOnly.Substring(midl + 1).Reverse().ToArray());
        //     if( strOnly.Substring(0,midl) == res){
        //        return true ;
        //     }
        // }
        
        // return false;


        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();

        bool result = Result.isAlphabeticPalindrome(code);

        Console.WriteLine((result ? 1 : 0));
    }
}

