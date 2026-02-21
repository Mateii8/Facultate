//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
         int a,b;
        Scanner cin = new Scanner(System.in);
        System.out.print("a=");
        a=cin.nextInt();
        System.out.print("b=");
        b=cin.nextInt();
        int x=a*10+b;
        int z=b*10+a;
        if(x<z)
        {
         System.out.println(x+" " + z);
        }
        else {
            System.out.println(z+" "+x);
             }
        }
    }
