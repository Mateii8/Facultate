import java.util.Scanner;


public class Main
{

    public static int fib1(int n)
    {
        if(n<=1) return n;
        else return fib1(n-1)+fib1(n-2);
    }
    public static int fib2(int n)
    {
       if(n<=1) return n;
       else
       {
           int a = 0;
           int b = 1;
           int c=0;
           for (int i = 2; i <= n; i++) {
               c = b + a;
               a = b;
               b = c;
           }
           return c;
       }
    }
    public static  void  fib3(int[] F,int n)
    {
        F[0]=0;
        F[1]=1;
        for(int i=2;i<=n;i++)
        {
            F[i]=F[i-1] + F[i-2];
        }
        System.out.println(F[n]+ " ");

    }
    public static int fib4(int n)
    {
        int[] t=new int[n+1];

        if(n<=1) return n;
        else
        {
            if (t[n]!=0) return t[n];
            else {
                t[n]=fib4(n-1) + fib4(n-2);
                return t[n];
            }
        }

    }
    public static void main(String[] args)
    {
        Scanner cin=new Scanner(System.in);
        int n= cin.nextInt();
        int[] F = new int[n+1];
         for(int i=2;i<=n;i++)
        {
            System.out.print(fib1(i) + " ");
            System.out.print(fib2(i) + " ");
            System.out.print(fib4(i) + " ");
            fib3(F,i);
        }
    }
}