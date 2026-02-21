import java.util.Scanner;
public class Main
{
    static int m, n, p;
    static int[] x = new int[100];
    static int[] t = new int[100];
    public static void Afisare(int[] x, int n)
    {
        for (int i = 1; i <= n; i++)
            System.out.print(x[i] + " ");
        System.out.println();
    }
    public static boolean Valid(int p, int[] x, int k)
    {
        int q = 0;
        if (p == 0) return false;
        for (int i = 1; i <= k - 1; i++)
            if(x[i]==x[k])
            {
                q++;
                if(q>=p) return false;
            }
        return true;
    }
    public static void Permutari_Cu_Repetitie(int n, int[] t, int m)
    {
        n = 0;
        for (int i = 1; i <= m; i++)
            n += t[i];
        int k = 1;
        x[1] = 0;
        while (k > 0)
        {
            if (x[k] < m)
            {
                x[k]++;
                p = t[x[k]];
                if (Valid(p,x,k))
                {
                    if (k == n)
                    {
                        Afisare(x, n);
                        k--;
                    }
                    else
                    {
                        k++;
                        x[k] = 0;
                    }
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

        for(int i = 1; i <= m; i++)
            t[i] = cin.nextInt();
        Permutari_Cu_Repetitie(n, t, m);
    }
}