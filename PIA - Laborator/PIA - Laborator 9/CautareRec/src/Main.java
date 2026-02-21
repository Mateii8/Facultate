import java.util.Scanner;

public class Main {

    public static void citire(int[] A, int n) {
        Scanner cin = new Scanner(System.in);
        for (int i = 1; i <= n; i++) {
            System.out.print("A[" + i + "] = ");
            A[i] = cin.nextInt();
        }
    }

    public static int cautbin_rec(int[] A, int n, int p, int u, int x) {
        if (p > u) return -1;
        else
        {
            int m = (p + u) / 2;
            if (x == A[m]) return m;
            else
            {
                if (x < A[m])
                    return cautbin_rec(A, n, p, m - 1, x);
                else
                    return cautbin_rec(A, n, m + 1, u, x);
            }
        }
    }

    public static int cautbin(int[] A, int n, int x)
    {
        int p = 1;
        int u = n;
        while (p <= u)
        {
            int m = (p+u) / 2;
            if (x == A[m]) return m;
            else
            {
                if (x < A[m]) u = m - 1;
                else p = m + 1;
            }
        }

        return -1;
    }

    public static void main(String[] args) {
        Scanner cin = new Scanner(System.in);
        int n = cin.nextInt();
        int[] A = new int[n+1];
        citire(A, n);
        int p=1;
        int u=n;
        System.out.print("Cauta elementul = ");
        int x = cin.nextInt();
        System.out.println("Element pe poz =" + cautbin_rec(A, n, p, u, x));
        System.out.println("Element pe poz =" + cautbin(A,n,x));
        cin.close();
    }
}



