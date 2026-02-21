import java.util.Scanner;
public class Main {
    static int n,k;
    static int[] x=new int[100];
    static int[] m=new int[100];
    public static void Afisare(int[] x,int n) {
        for (int i = 1; i <= n; i++) {
            System.out.print(x[i] + " ");
        }
        System.out.println();
    }
    public static void Produs_Cartezian(int n,int[] m)
    {
        k=1;
        x[1]=0;
        while(k>0)
        {
            if(x[k]<m[k])
            {
                x[k]=x[k]+1;
                if(k==n)
                {
                    Afisare(x,n);
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
       Scanner cin=new  Scanner(System.in);
       n=cin.nextInt();
       for(int i=1;i<=n;i++)
       {
           m[i]=cin.nextInt();
       }
       Produs_Cartezian(n,m);
    }
}