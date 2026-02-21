import java.util.Scanner;
public class Main {
    static int n;
    static int[] x = new int[30];
    static int r = 1;
    static int ult;
    static int k;

    public static void Afisare(int[] x) {
        System.out.println("Var: " + r++);
        for (int i = 1; i <= n; i++) {
           System.out.print(x[i] + " ");
        }
        System.out.println();
    }

    public static boolean Valid(int[] x, int k) {
        for (int i = 1; i <= k - 1; i++) {
            if(Math.abs(x[k] - x[i]) == Math.abs(k-i))
                return false;
        }
        return true;
    }

    public static void Nebuni1(int n) {
        k = 1;
        x[k] = 0;
        ult = 2;
        while (k > 0) {
            if(x[k] < ult){
                x[k]++;
                if (Valid(x,k)){
                    if(k==n - 1){
                        Afisare(x);
                    }
                    else{
                        k++;
                        if (k <= n/2)
                        {
                            x[k] = 0;
                            ult = 2*k;
                        }
                        else
                        {
                            x[k] = 2*k - n;
                            ult = n;
                        }
                    }
                }
            }
            else
            {
                k--;
                if(k<=n/2)  ult = 2*k;
                else ult = n;
            }
        }
    }

    public static void main(String[] args) {
        Scanner cin=new Scanner(System.in);
        System.out.println(" ");
        n=cin.nextInt();
        Nebuni1(n);
    }
}

