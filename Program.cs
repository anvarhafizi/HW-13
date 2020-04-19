using System;

namespace HW_13
{
    class Program
    {
        static void Main()
        {
             //Using the SLICE operator;
            ArrayHelper<string> List = new ArrayHelper<string>();
            string[]    K= {"Hello","World","and","Republic","of","Tajikistan"};
            List.Slice(ref K, 1, -3);
            foreach(var i in K)
            {
                System.Console.Write(i+",");
            }
        }
    }
    class ArrayHelper<M>
{
    public M Pop(ref M[] arr1)
    {
        M[] arr = new M[arr1.Length - 1];
        for (int x = 0; x < arr1.Length - 1; x++)
        {
            arr[x] = arr1[x];
        }
        M L = arr1[arr1.Length - 1];
        arr1 = arr;
        return L;
    }
    public void Push(ref M[] arr, M n)
    {
        M[] a = new M[arr.Length + 1];
        for (int x = 0; x < arr.Length; x++)
        {
            a[x] = arr[x];
        }
        a[a.Length - 1] = n;
        arr = a;
    }
    public M Shift(ref M[] arr)
    {
        M[] a = new M[arr.Length - 1];
        for (int x = 0; x < a.Length; x++)
        {
            a[x] = arr[x + 1];
        }
        M first= arr[0];
        arr = a;
        return first;
    }
    public void UnShift(ref M[] arr, M n)
    {
        M[] a = new M[arr.Length + 1];
        a[0] = n;
        for (int x = 0; x < a.Length - 1; x++)
        {
            a[x + 1] = arr[x];
        }
        arr = a;
    }
    public M[] Slice(ref M[] arr, int x)
    {
        if (x < 0)
        {
            M[] arr1 = new M[Math.Abs(x)];
            int b = 0;
            bool bul = true;
            for (int i = arr.Length - 1; bul; i--)
            {
                bul = !(b == Math.Abs(x) - 1);
                arr1[b] = arr[i];
                b++;
            }
            return arr1;
        }
        else if (x > 0)
        {
            M[] arr1 = new M[arr.Length - x + 1];
            int b = 0;
            for (int i = 0; i <= x; i++)
            {
                arr1[b] = arr[i];
                b++;
            }
            return arr1;
        }
        else
        {
            return arr;
        }
    }
    public M[] Slice(ref M[] arr, int x, int y)
    {
        if (x > 0 && y > 0)
        {
            M[] arr1 = new M[y - x + 1];
            int c = 0;
            for (int i = x; i <= y; i++)
            {
                arr1[c] = arr[i];
                c++;
            }
            return arr1;
        }
        else if (x > 0 && y < 0)
        {
            M[] arr1 = new M[arr.Length - Math.Abs(y) - 1];
            int b = 0;
            for (int i = x; i <= arr1.Length; i++)
            {
                arr1[b] = arr[i];
                b++;
            }
            return arr1;
        }
        else
        {
            return arr;
        }
    }
    }
}
