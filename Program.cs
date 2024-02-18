using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text.Json.Serialization.Metadata;
using System.Xml.XPath;
using Microsoft.Win32.SafeHandles;

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

        Console.WriteLine(ReverseWord("message"));

        Console.WriteLine(BasicSum(20, 20));

        Console.WriteLine(Division(12, 6));

        Console.WriteLine(PalindromeChecker("racecar"));

        Console.WriteLine(Fibonacci(5));

        int[] age = new int[5];
        age[0] = 12;
        age[1] = 14;
        age[2] = 34;
        age[3] = 21;
        age[4] = 55;
        
        Console.WriteLine(age[0]);

        //Average
        int result = Average(arr);
        Console.WriteLine(result);

        //find max and min
        MaxMin(arr);

        int[] number1 = [2, 4, 6, 7, 8];
        int[] number2 = [6, 9, 8, 1, 4];
        
        int[] intersection = ArrayIntersection(number1, number2);

        Console.WriteLine("Intersection of the array: ");
        
        foreach (int num in intersection) {
            Console.WriteLine(num + "");
        }

        int[] sameValue = [2, 5, 8, 7, 2];
        int sameinArr = SameValue(sameValue);
        Console.WriteLine("The same value in the array is: " + sameinArr);

        Console.WriteLine(Search(sameValue, 7));
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
        foreach (int num in arr) {
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

    static int Fibonacci(int num) {
        int firstTerm = 0;
        int secondTerm = 1;

        for (int i = 0; i <= num; i++) {
            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }

        return num;
    }

    //String Normalization
    static string Normalize(string str) {
        return new string(str.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
    }

    static Dictionary<char, int> CountCharacters(string str) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in str) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }
        return charCount;
    }

    //return average
    static int Average(int[] arr) {
        int sum = 0;
        int average = 0;

        for (int i = 0; i < arr.Length; i++) {
            sum += arr[i];
        }
        
        average = sum / arr.Length;

        return average;
    }

    //Find the maximum & minimum
    static void MaxMin(int[] arr) {
        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] < min) {
                min = arr[i];
            }

            if (arr[i] > max) {
                max = arr[i];
            }
        }

        Console.WriteLine("Minimum: " + min);
        Console.WriteLine("Maximum: " + max); 
    }

    static int[] ArrayIntersection(int[] arr1, int[] arr2) {
        int[] intersection = new int[Math.Min(arr1.Length, arr2.Length)];
        int count = 0;

        foreach (int num1 in arr1) {
            if (Contains(arr2, num1)) {
                intersection[count++] = num1;
            }
        }

        Array.Resize(ref intersection, count);
        
        return intersection;
    }

    static bool Contains(int[] array, int value) {
        foreach (int item in array) {
            if (item == value) {
                return true;
            }
        }
        
        return false;
    }

    static int SameValue(int[] array) {
        int starting = array[0];
        int same = starting;

        for (int i = 0; i < array.Length; i++) {
            if (starting == array[i]) {
                same = array[i];
            }
        }

        return same;
    }

    static int Search(int[] array, int target) {
        int index = -1;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == target) {
                index = i;
            }
        }

        return index;
    }

}