import java.util.Scanner;
public class Main {

    static int p = 0;


    public static void ACOPERIRE(int[][] S, int i, int j, int n, int ip, int jp) {

        if (n > 1) {

            p = p + 1;
            int m = n / 2;

            int i1 = i,     j1 = j;
            int i2 = i,     j2 = j + m;
            int i3 = i + m, j3 = j;
            int i4 = i + m, j4 = j + m;

            int ip1 = ip, jp1 = jp;
            int ip2 = ip, jp2 = jp;
            int ip3 = ip, jp3 = jp;
            int ip4 = ip, jp4 = jp;



            if (i3 <= ip) {

                ip1 = i1 + m - 1;   jp1 = j1 + m - 1;
                ip2 = i2 + m - 1;   jp2 = j2;

                S[ip1][jp1] = p;
                S[ip2][jp2] = p;

            } else {

                ip3 = i3;          jp3 = j3 + m - 1;
                ip4 = i4;          jp4 = j4;

                S[ip3][jp3] = p;
                S[ip4][jp4] = p;
            }

            if (j2 <= jp) {

                ip1 = i1 + m - 1;  jp1 = j1 + m - 1;
                ip3 = i3;          jp3 = j3 + m - 1;

                S[ip1][jp1] = p;
                S[ip3][jp3] = p;

            } else {

                ip2 = i2 + m - 1;  jp2 = j2;
                ip4 = i4;          jp4 = j4;

                S[ip2][jp2] = p;
                S[ip4][jp4] = p;
            }



            ACOPERIRE(S, i1, j1, m, ip1, jp1);
            ACOPERIRE(S, i2, j2, m, ip2, jp2);
            ACOPERIRE(S, i3, j3, m, ip3, jp3);
            ACOPERIRE(S, i4, j4, m, ip4, jp4);
        }
    }

    public static void main(String[] args) {

        int n = 8;
        int[][] S = new int[n][n];

        int ip = 2, jp = 3;
        S[ip][jp] = -1;

        ACOPERIRE(S, 0, 0, n, ip, jp);

        for (int[] row : S) {
            for (int x : row)
                System.out.printf("%4d", x);
            System.out.println();
        }
    }
}