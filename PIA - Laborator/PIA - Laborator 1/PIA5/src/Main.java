//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        int x;
        Scanner cin = new Scanner(System.in);
        System.out.print("x=");
        x = cin.nextInt();
        int u=x%10;
        int z=(x/10)%10;
        if(u==z)
        {
            System.out.println((x+1)+ " " + (x+2));
        }
        else {
            System.out.println(Math.max(u,z));
        }
        }
    }
