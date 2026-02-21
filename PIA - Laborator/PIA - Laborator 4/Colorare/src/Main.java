import java.util.Scanner;

public class Main
{
    public static void Colorare(int[][] A, int n, int m){
        int k;
        int[] x;
        x = new int[n + 1];

        k = 1;
        x[1] = 0;

        while (k > 0) {
            if (x[k] < m) {
                x[k]++;
                if (valid(A, x, k)) {
                    if (k == n) {
                        afis(x, n);
                    } else {
                        k++;
                        x[k] = 0;
                    }
                }
            } else
                k--;
        }
    }

    public static boolean valid(int[][] A, int[] x, int k){
        for (int i = 1; i <= k - 1; i++)
            if (A[i][k] >= 1 && x[i] == x[k])
                return false;
        return true;
    }

    public static void afis(int[] x, int n){
        System.out.print("Colorare valida: ");
        for (int i = 1; i <= n; i++) {
            System.out.print("N" + i + "=" + x[i] + " ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        int n, m, e;
        int[][] a;
        Scanner cin = new Scanner(System.in);

        n = cin.nextInt();
        e = cin.nextInt();
        m = cin.nextInt();

        a = new int[n + 1][n + 1];

        for (int i = 1; i <= e; i++) {
            int x = cin.nextInt();
            int y = cin.nextInt();

            a[x][y] = 1;
            a[y][x] = 1;
        }

        Colorare(a, n, m);
    }
}