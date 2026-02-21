import java.util.Scanner;
public class Main
{

    public static void citire(int[] A, int n)
    {
        Scanner cin = new Scanner(System.in);
        for (int i = 1; i <= n; i++)
        {
            System.out.print("A[" + i + "] = ");
            A[i] = cin.nextInt();
        }
    }

    public static void afisare(int[] A, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            System.out.print(A[i] + " ");
        }
    }

    public static void interclasare(int[] A, int p, int q, int m)
    {
        int i = p;
        int j = m + 1;
        int k = 1;
        int[] B = new int[q - p + 2];
        while (i <= m && j <= q)
        {
            if (A[i] <= A[j])
            {
                B[k] = A[i];
                i++;
            }
            else
            {
                B[k] =A[j];
                j++;
            }
            k++;
        }
        while(i<=m)
        {
            B[k] = A[i];
            i++;
            k++;
        }
        while(j<=q)
        {
            B[k] = A[j];
            j++;
            k++;
        }
        k = 1;
        for(i = p; i <= q; i++)
        {
            A[i] = B[k];
            k++;
        }
    }

    public static void sortint(int[] A, int p, int q)
    {
        if(p<q)
        {
            int m = (p+q )/ 2;
            sortint(A,p,m);
            sortint(A,m+1,q);
            interclasare(A, p, q, m);
        }
    }

    public static void main(String[] args)
    {
        Scanner cin = new Scanner(System.in);
        int m = cin.nextInt();
        int[] A = new int[m+1];
        int p = 1;
        int q = m;
        citire(A, m);
        sortint(A, p, q);
        afisare(A, m);
        cin.close();
    }
}