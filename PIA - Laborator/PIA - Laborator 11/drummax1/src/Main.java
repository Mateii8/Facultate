import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public void DrumMax1(int[][] a, int m, int n) {
        int[][] S = new int[m][n];
        int[][] P = new int[m][n];


        for (int j = 0; j < n; j++) {
            S[m - 1][j] = a[m - 1][j];
        }


        for (int i = m - 2; i >= 0; i--) {
            for (int j = 0; j < n; j++) {
                int maxS = S[i + 1][j];
                P[i][j] = 0;


                if (j > 0 && S[i + 1][j - 1] > maxS) {
                    maxS = S[i + 1][j - 1];
                    P[i][j] = -1;
                }


                if (j < n - 1 && S[i + 1][j + 1] > maxS) {
                    maxS = S[i + 1][j + 1];
                    P[i][j] = 1;
                }

                S[i][j] = a[i][j] + maxS;
            }
        }


        int maxM = S[0][0];
        int startCol = 0;
        for (int j = 1; j < n; j++) {
            if (S[0][j] > maxM) {
                maxM = S[0][j];
                startCol = j;
            }
        }


        int[] t = new int[m];
        t[0] = startCol;
        for (int i = 1; i < m; i++) {
            t[i] = t[i - 1] + P[i - 1][t[i - 1]];
        }


        System.out.println("Suma maxima: " + maxM);
        System.out.print("Drum maxim: ");
        for (int i = 0; i < m; i++) {
            System.out.print(a[i][t[i]] + " ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        Scanner cin = new Scanner(System.in);
        System.out.print("Introduceți numărul de linii (m) și coloane (n): ");
        int m = cin.nextInt();
        int n = cin.nextInt();

        int[][] a = new int[m][n];
        System.out.println("Introduceți matricea:");
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                a[i][j] = cin.nextInt();
            }
        }

        Main obj = new Main();
        obj.DrumMax1(a, m, n);
    }
}

