import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner cin=new Scanner(System.in);
        long  a,b;
        System.out.println("Introduceti a : ");
        a=cin.nextLong();
        System.out.println("Introduceti b : ");
        b=cin.nextLong();
        long sumaA = 0;
        long produsA = 1;
        long x=a;
        sumaA =0;
        produsA =1;
        boolean Nenul = false;
        while(x>0)
        {
           int c= (int) (x%10);
           if(c!=0) {
               sumaA += c;
               produsA *= c;
               Nenul = true;
           }
           x /=10;
        }
        if(!Nenul) produsA =0;
        System.out.println("Pentru a : suma = " + sumaA + ", produs = " + produsA );
        x=b;
       long sumaB =0;
        long produsB = 1;
        while(x>0)
        {
            int c= (int) (x%10);
            if(c!=0) {
                sumaB += c;
                produsB *= c;
                Nenul = true;
            }
            x /=10;
        }
        if(!Nenul) produsB =0;
        System.out.println("Pentru b : suma = " + sumaB + ", produs = " + produsB);
    }
}