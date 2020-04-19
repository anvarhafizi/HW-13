using System;

namespace HW_13
{
    class Program
    {
        static void Main()
        {

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

    }
}
