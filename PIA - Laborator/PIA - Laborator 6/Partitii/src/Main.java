import java.util.Scanner;
public class Main
{
    static int m, n;
    static int[] x = new int[100];
    public static void Afisare(int[] x, int n)
    {
        for (int i = 1; i <= n; i++)
            System.out.print(x[i] + " ");
        System.out.println();
    }
    public static void Partitii(int m, int n)
    {
        int k = 1;
        x[1] = 0;
        int s = 0;
        while (k > 0)
        {
            if (k <= n-1)
            {
                if (x[k] < (m-s)/(n-k+1))
                {
                    x[k] = x[k] + 1;
                    s += x[k];
                    k++;
                    x[k] = x[k-1] - 1;
                }
                else
                {
                    k = k - 1;
                    s = s - x[k];
                }
            }
            else
            {
                x[n] = m - s;
                Afisare(x, n);
                k = k - 1;
                s = s - x[k];
            }
        }
    }
    public static void main(String[] args)
    {
        Scanner cin = new Scanner(System.in);
        m = cin.nextInt();
        n = cin.nextInt();

        Partitii(m, n);
    }
}