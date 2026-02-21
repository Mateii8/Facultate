import java.util.Scanner;

public class Main
{
    static int m,n,k;
    static int[] y=new int[100];
    static int[] x=new int[100];
    static int[] a=new int[100];
    public static void Afisare(int[] x,int[] a,int n)
    {
        for(int i=1;i<=n;i++)
        {
            System.out.print(a[x[i]]+" ");
        }
        System.out.println();
    }
    public static void Aranjamente2(int m,int n)
    {
        for(int i=1;i<=m;i++) y[i]=0;
        k=1;
        x[1]=0;
        while(k>0)
        {
            if(x[k]<m)
            {
                x[k]++;
                if(y[x[k]]==0)
                {
                    if(k==n)
                    {
                        Afisare(x,a,n);
                    }
                    else
                    {
                      y[x[k]]=1;
                      k++;
                      x[k]=0;
                    }
                }
            }
            else
            {
                k--;
                if(k>0)
                {
                    y[x[k]]=0;
                }
            }
        }
    }
    public static void main(String[] args)
    {
        Scanner cin=new  Scanner(System.in);
        m=cin.nextInt();
        n=cin.nextInt();
        for(int i=1;i<=m;i++)
        {
            a[i]=cin.nextInt();
        }
        Aranjamente2(m,n);
    }
}