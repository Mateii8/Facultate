//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        int n;
        Scanner cin = new Scanner(System.in);
        System.out.print("n=");
        n=cin.nextInt();
        int c1 =  n/1000;
        int c2 = (n%100)/10;
        int c3 = (n%10)%10;
        int c4 =  n%10;
        int[] cifre ={c1,c2,c3,c4};
        int pare=0,impare=0;
        for(int c : cifre)
        {
            if(c%2==0) pare++;
            else impare++;
        }
        boolean echilibrat =(pare==impare);
        boolean pitic = (c1 < 4 && c2 < 4 && c3 < 4 && c4 < 4);
        int suma = c1+c2+c3+c4;
        boolean generos=(suma > n+2);
        int produs = c1*c2*c3*c4;
        boolean corect=isPerfectSquare(suma) && isPerfectSquare(produs);
        System.out.println("Echilibrat : "+echilibrat);
        System.out.println("Pitic : "+pitic);
        System.out.println("Generos : "+generos);
        System.out.println("Corect : "+corect);
        }
        private static boolean isPerfectSquare(int x)
        {
            int r=(int) Math.sqrt(x);
            return r*r==x;
        }
    }
