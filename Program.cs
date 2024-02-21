// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace N1{
public class SamplesArray
{

    public static void Main()
    {
        int[] arr = [1,2,3];
        Console.WriteLine("Arr1", arr);
        char x = '1';
        arr.Append(10000);

        // Console.WriteLine("2 " + arr);
        const int inst = 5;
        var xx = inst + 1;
        // Console.WriteLine($"XX {xx}");

        var utils= new ListUtils();
        List<int> list = new List<int>([123]);
        list.Add(1);
        list.AddRange(new List<int>([1, 3]));
        list = utils.pushItems(list, 99, 100, 101);
        // Console.WriteLine(utils.getConst(228, "1"));

        foreach(int num in list){
            Console.WriteLine($"number {num}");
        }
    }

    public void smth(){}




}

public class ListUtils{
    public string getConst(int count, string str) {
        int i = 1;

        if(!int.TryParse(str, out int res)){
            return (res - count).ToString();
        }

        return "XUI";
    }

    public List<int> pushItems(List<int> arr, params int[] numbers){
        List<int> newList = new ([..arr]);
        for(int i = 0; i < numbers.Length; i++){
            int num = numbers[i];
            newList.Add(num);
        }

        return newList;
    }
}

} 



