import java.util.Scanner;
public class Main
{
    static int cmmdc(int a, int b) {
        if (b == 0) return a;
        return cmmdc(b, a % b);
    }

    static int cmmdcDivide(int[] v, int st, int dr) {

        if (st == dr)
            return v[st];
        int mid = (st + dr) / 2;
        int cmmdcSt = cmmdcDivide(v, st, mid);
        int cmmdcDr = cmmdcDivide(v, mid + 1, dr);
        return cmmdc(cmmdcSt, cmmdcDr);
    }

    public static void main(String[] args) {
        Scanner cin = new Scanner(System.in);
        System.out.print("Introduceti numarul n: ");

        int n = cin.nextInt();
        int[] v = new int[n];

        System.out.println("Introduceti cele " + n + " numere:");
        for (int i = 0; i < n; i++) {
            v[i] = cin.nextInt();
        }

        System.out.print("Vectorul citit este: ");
        for (int x : v) System.out.print(x + " ");
        System.out.println();

        int rezultat = cmmdcDivide(v, 0, n - 1);
        System.out.println("CMMDC-ul numerelor este: " + rezultat);
    }
}