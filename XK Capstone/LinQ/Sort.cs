class Sort
{
    public delegate int MyCompare(object o, object o2);
    public static void bubbleSort(object[] arr, MyCompare compare)
    {
        int i, j;
        object temp;
        bool swapped;
        for (i = 0; i < arr.Length - 1; i++)
        {
            swapped = false;
            for (j = 0; j < arr.Length - i - 1; j++)
            {
                if (compare(arr[j], arr[j + 1]) < 0)
                {

                    // Swap arr[j] and arr[j+1]
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were
            // swapped by inner loop, then break
            if (swapped == false)
                break;
        }
    }
}