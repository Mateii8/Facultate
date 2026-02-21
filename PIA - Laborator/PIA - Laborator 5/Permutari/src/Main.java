import java.util.Scanner;


public class Main
{
    static int n,k;
    static int[] x=new int[100];
    public static void Afisare(int[] x,int n)
    {
        for(int i=1;i<=n;i++)
        {
            System.out.print(x[i]+" ");
        }
        System.out.println();
    }
    public static boolean Valid(int[] x,int k)
    {
        for(int i=1;i<=k-1;i++)
        {
            if(x[k]==x[i])
            {
                return false;
            }
        }
        return true;
    }
    public static void Permutari(int n)
    {
        k=1;
        x[1]=0;
        while(k>0)
        {
            if(x[k]<n)
            {
                x[k]++;
                if(Valid(x,k))
                {
                    if(k==n)
                    {
                        Afisare(x,n);
                        k--;
                    }
                    else
                    {
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
    public static void main(String[] args)
    {
    Scanner cin=new Scanner(System.in);
    n=cin.nextInt();
    Permutari(n);
    }
}