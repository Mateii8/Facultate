import java.util.Scanner;

public class Main {

    static int n;
    static int[] x = new int[30];
    static int r = 1;


    public static void Afisare(int[] x) {

        System.out.println("Var: " + r++);
        for (int i = 1; i <= n; i++) {
           System.out.print(x[i] + " ");
        }
        System.out.println();
    }

    public static boolean Valid(int[] x, int k) {
        for (int i = 1; i <= k - 1; i++) {
            if (x[k] == x[i] || k-i == Math.abs(x[k] - x[i]))
                return false;
        }
        return true;
    }

    public static void Dame(int n) {
        int k = 1;
        x[k] = 0;

        while (k > 0) {
            if(x[k] < n){
                x[k]++;
                if (Valid(x,k)){
                    if(k==n){
                        Afisare(x);
                        k--;
                    }
                    else{
                        k++;
                        x[k]=0;
                    }
                }
            }
            else
            {
                k--;
            }
        }
    }
    public static void main(String[] args) {
        Scanner cin=new Scanner(System.in);
        System.out.println(" ");
        n=cin.nextInt();
        Dame(n);
    }
}