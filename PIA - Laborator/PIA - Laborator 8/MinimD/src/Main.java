import java.util.Scanner;
public class Main {
    public static int minD(int[] v, int st, int dr)
    {

        if (st == dr) {
            return v[st];
        }


        int mid = (st + dr) / 2;
        int minSt = minD(v, st, mid);
        int minDr = minD(v, mid + 1, dr);
        return Math.min(minSt, minDr);
    }

    public static void main(String[] args) {


        int[] v = {70, -3, 5, 0, 7, -6, };


        System.out.print("Vectorul este: ");
        for (int i = 0; i < v.length; i++)
        {
            int x = v[i];
            System.out.print(x + " ");
        }
        System.out.println();


        int minim = minD(v, 0, v.length - 1);


        System.out.println("Minimul din vector (Divide et Impera) este: " + minim);
    }
}