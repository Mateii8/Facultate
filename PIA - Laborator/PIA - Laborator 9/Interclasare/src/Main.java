import java.util.Scanner;
public class Main {

    public static void citire(int[] A, int n) {
        Scanner cin = new Scanner(System.in);
        for (int i = 1; i <= n; i++) {
            System.out.print("A[" + i + "] = ");
            A[i] = cin.nextInt();
        }
    }

    public static void afisare(int[] A, int n) {
        for (int i = 1; i <= n; i++) {
            System.out.print(A[i] + " ");
        }
    }

    public static void interclasare(int[] A, int[] B, int[] C, int m, int n) {
        int i = 1, j = 1, k = 1;
        while (i <= m && j <= n) {
            if (A[i] <= B[j]) {
                C[k] = A[i];
                i++;
            }
            else {
                C[k] = B[j];
                j++;
            }
            k++;
        }
        while(i<=m) {
            C[k] = A[i];
            i++;
            k++;
        }
        while(j<=n) {
            C[k] = B[j];
            j++;
            k++;
        }
    }

    public static void main(String[] args) {
        Scanner cin = new Scanner(System.in);
        int n = cin.nextInt();
        int m = cin.nextInt();
        int[] A = new int[n+1];
        int[] B = new int[m+1];
        int[] C = new int[n+m + 2];
        citire(A, n);
        citire(B, n);
        interclasare(A, B, C, m, n);
        afisare(C, m+n);
        cin.close();
    }
}
