
import java.util.Scanner;
 class NrPrim
{
    public  boolean estePrim(int n)
    {
        if(n==1) return false;
        if(n%2==0) return false;
        if(n%2==1) return true;
        int i;
        for(i=3;i*i<=n;i=+2);
        if(n%i==0) return false;
        return true;
    }
}
public class Main {
    public static void main(String[] args) {
         Scanner cin = new Scanner(System.in);
         int n = cin.nextInt();
         NrPrim np = new NrPrim();
         System.out.println("Numerele prime din intervalul [" + n + "," + (2 * n) + "] sunt :");
         boolean exista=false;
                 for(int i=n;i<=2*n;i++)
                 {
                     if(np.estePrim(i))
                     {
                         System.out.println(i + " ");
                         exista=true;
                     }
                 }
                 if(!exista)
                 {
                     System.out.print("Nu exista numere prime");
                 }
        }
}