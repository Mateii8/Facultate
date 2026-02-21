//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
         int n,S;
         Scanner cin=new Scanner(System.in);
         System.out.println("n=");
         n=cin.nextInt();
         S=0;
         while(n>0)
         {
           S=S+(n%10);
           n=n/10;
         }
         System.out.println(S);
        }
    }
