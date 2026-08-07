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
     * Complete the 'countResponseTimeRegressions' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY responseTimes as parameter.
     */

    public static int countResponseTimeRegressions(List<int> responseTimes)
    {
        var res = 0;
         for(var i = 0;i < responseTimes.Count;i++){
                
                if(i == 0){continue;}
                var curr = responseTimes[i];
                long sum = 0;
                var l = 0;
                for(var e = i-1;e>=0;e--){
                    sum += responseTimes[e];
                    l++;
                }
                double mean = sum / l;

                if(mean < curr){
                    res++;
                }
                
         }
         return res; 
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int responseTimesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> responseTimes = new List<int>();

        for (int i = 0; i < responseTimesCount; i++)
        {
            int responseTimesItem = Convert.ToInt32(Console.ReadLine().Trim());
            responseTimes.Add(responseTimesItem);
        }

        int result = Result.countResponseTimeRegressions(responseTimes);

        Console.WriteLine(result);
    }
}
