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
    public static void Combinari_Cu_Repetitie(int m, int n)
    {
        int k = 1;
        x[1] = 0;
        while (k > 0)
        {
            if (x[k] < m)
            {
                x[k]++;
                if (k == n)
                {
                    Afisare(x, n);
                }
                else
                {
                    k++;
                    x[k] = x[k-1] - 1;
                }
            }
            else
                k--;
        }
    }
    public static void main(String[] args)
    {
        Scanner cin = new Scanner(System.in);
        m = cin.nextInt();
        n = cin.nextInt();

        Combinari_Cu_Repetitie(m, n);
    }
}