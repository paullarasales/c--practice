using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text.Json.Serialization.Metadata;
using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = [4, 5, 3, 1, 2];
        Sort(arr);
        Console.WriteLine("Sorted Array");
        PrintArr(arr);
        Console.WriteLine(Factorial(5));
        int max = FindMax(arr);
        Console.WriteLine(max);
        string message = "hello";
        Console.WriteLine(ReverseWord(message));
        Console.WriteLine(BasicSum(20, 20));
        Console.WriteLine(Division(12, 6));
        Console.WriteLine(PalindromeChecker("racecar"));
    }

    static void Sort(int[] arr) {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArr(int[] arr) {
        foreach (var num in arr) {
            Console.Write(num + "");
        }

        Console.WriteLine();
    }

    static int Factorial(int num) {
        int product = 1;

        for (int i = num; i >= 1; i--) {
            product *= i;
        }
        
        return product;
    }

    static int FindMax(int[] arr) {
        int max = arr[0];

        foreach (int num in arr) {
            if (num > max) {
                max = num;
            }
        }

        return max;
    }

    static string ReverseWord(string str) {
        char[] charArray = str.ToCharArray();
        int n = str.Length;

        for (int i = 0; i < n / 2; i++) {
            char temp = charArray[i];
            charArray[i] = charArray[n - i - 1];
            charArray[n - i - 1] = temp;
        }

        return new string(charArray);
    }

    static bool PalindromeChecker(string str) {
        char[] charArray = str.ToCharArray();
        int n = str.Length;

        for (int i = 0; i < n / 2; i++) {
           if (charArray[i] != charArray[n - i - 1]) {
                return false;
           }
        }
        return true;
    }

    static int BasicSum(int num1, int num2) {
        int sum = num1 + num2;
        return sum;
    }

    static int Division(int num1, int num2) {
        int result = num1/num2;
        return result;
    }
}