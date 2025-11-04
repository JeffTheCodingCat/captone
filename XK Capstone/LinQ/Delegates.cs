class DelegateTest
{
    //public delegate int DoSomething(int x);
    public static void processArray(int[] arr, Func<int, int> ds)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ds(arr[i]);
        }
    } 
}