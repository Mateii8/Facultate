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
    public static void Compuneri(int m, int n)
    {
        int k = 1;
        x[1] = 0;
        int s = 0;
        while (k > 0)
        {
            if (x[k] < m - s)
            {
                x[k]++;
                if (k == n - 1)
                {
                    x[n] = m -s - x[k];
                    Afisare(x, n);
                }
                else
                {
                    s+=x[k];
                    k++;
                    x[k] = -1;
                }
            }
            else{
                k--;
                s = s - x[k];
            }
        }
    }
    public static void main(String[] args)
    {
        Scanner cin = new Scanner(System.in);
        m = cin.nextInt();
        n = cin.nextInt();

        Compuneri(m, n);
    }
}