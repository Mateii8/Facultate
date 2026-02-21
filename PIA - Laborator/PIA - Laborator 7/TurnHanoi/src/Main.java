import java.util.Scanner;


public class Main
{
    public static void Hanoi(int m,int i,int j)
    {
        if(m==1)
        {
            System.out.println("Move "+i+" to "+j);
        }
        else
        {
            int k=6-i-j;
            Hanoi(m-1,i,k);
            System.out.println("Move "+i+" to "+j);
            Hanoi(m-1,k,j);
        }
    }
    public static void main(String[] args)
    {
        Scanner cin=new Scanner(System.in);
        int n=cin.nextInt();
        Hanoi(n,1,2);
    }
}