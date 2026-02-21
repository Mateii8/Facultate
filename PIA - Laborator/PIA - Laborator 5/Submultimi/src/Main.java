import java.util.Scanner;
public class Main
{
    static int n,k;
    static int[] x=new int[100];
    static int[] a=new int[100];
    public static void Afisare(int[] x,int[] a, int n) {
        for(int i = 1; i <= n; ++i) {
            if(x[i]==1) System.out.print(a[i] + " ");
        }
        System.out.println();
    }
    public static void Submultimi(int[] a,int n)
    {
        k=1;
        x[1]=0;
        while(k>0)
        {
            if(x[k]<2)
            {
                x[k]=x[k]+1;
                if(k==n)
                {
                    Afisare(x,a,n);
                }
                else
                {
                    k=k+1;
                    x[k]=0;
                }
            }
            else
            {
              k=k-1;
            }
        }
    }
    public static void main(String[] args)
    {
        Scanner cin=new Scanner(System.in);
        n=cin.nextInt();
        for(int i=1;i<=n;i++)
        {
            a[i]=cin.nextInt();
        }
        Submultimi(a,n);
    }
}