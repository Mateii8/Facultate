import java.util.Scanner;
public class Main {
    static boolean esteFibonacci(long n)
    {
        if(n==0 || n==1) return true;
        long a=1,b=1,c=0;
        while(b<n)
        {
            c=a+b;
            a=b;
            b=c;
        }
        return c==n;
    }
    public static void main(String[] args) {
    Scanner cin=new Scanner(System.in);
    System.out.println("Introduceti n :");
    int n=cin.nextInt();
    long[] v=new long[n+1];
    for(int i=1;i<=n;i++)
    {
        v[i]=cin.nextLong();
    }
        int count=0;
    for(int i=1;i<=n;i++)
    {
        if(esteFibonacci(v[i]))
        {
            count++;
        }
    }
    System.out.println("Numarul elementelor Fibonacci din vector este");
    System.out.println(count);
    }
}