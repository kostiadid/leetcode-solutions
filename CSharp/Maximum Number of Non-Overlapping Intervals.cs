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
    public static int maximizeNonOverlappingMeetings(List<List<int>> meetings)
    {
        var sorted = meetings.OrderBy(a=>a[1]).ToList(); 
        
        int c = 1;
        var p = sorted[0];
        for(var i=1;i<=sorted.Count-1;i++){
            var current = sorted[i];
            if(p[1] <= current[0]){
                c++;
                p = current;
            }
            
        }
        
        return c;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int meetingsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int meetingsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> meetings = new List<List<int>>();

        for (int i = 0; i < meetingsRows; i++)
        {
            meetings.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(meetingsTemp => Convert.ToInt32(meetingsTemp)).ToList());
        }

        int result = Result.maximizeNonOverlappingMeetings(meetings);

        Console.WriteLine(result);
    }
}
