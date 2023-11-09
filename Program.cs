using System;

class SelectionSort2PRO
{

    /* Funkcja sortująca tablice używając SelectionSort O(n^2)*/
    static void sort(int[] arr)
    {
        int n = arr.Length;

        /* Przesuwaj subarraya po arrayu kolejno */
        for (int i = 0; i < n - 1; i++)
        {
            /* Znajdz najmniejszy element w nie-posortowanej array */
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] < arr[min_idx])
                    min_idx = j;

            /* Zmien najmniejszy znaleziony elemenent z pierwszym */
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    /* Funkcja wypisujająca tablice */
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // main
    public static void Main()
    {

        /* Zadeklaruj tablice i wypełnij 30 losowymi liczbami z przedziału -50 do 50 */
        int[] arr = new int [30];
        Random r = new Random();
        for ( int i = 0; i < 30; i++ )
        {
            arr[i] = r.Next(-50,50);
        }

        /* Wypisz nie-posortowaną */
        Console.WriteLine("Unsorted Array: ");
        printArray(arr);

        /* Podwójna przerwa w tekscie */
        Console.WriteLine("\n");

        /* Posortuj tablice */
        sort(arr);

        /* Wypisz posortowaną */
        Console.WriteLine("Sorted array: ");
        printArray(arr);

        /* Zakończ program po naciśnieciu dowolnego przycisku*/
        Console.ReadKey();
    }

}