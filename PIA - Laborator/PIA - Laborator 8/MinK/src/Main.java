import java.util.Scanner;
import java.util.Arrays;
public class Main
{
    public static void main(String[] args)
    {
        Scanner cin = new Scanner(System.in);

        System.out.print("n = ");
        int n = cin.nextInt();
        int[] arr = new int[n];

        System.out.println("Introduceți elementele:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = cin.nextInt();
        }

        System.out.print("k = ");
        int k = cin.nextInt();

        if (k < 1 || k > n)
        {
            System.out.println("k invalid!");
        } else
        {
            Arrays.sort(arr);              // sortăm array-ul
            System.out.println("Al " + k + "-lea cel mai mic element este: " + arr[k - 1]);
        }
    }
}