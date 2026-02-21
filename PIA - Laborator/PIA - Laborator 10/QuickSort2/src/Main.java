import java.util.Scanner;

public class Main {

    public void QuickSort2(int[] A, int p, int u)
    {
        int k = (u + p) / 2;

        int med = A[k];
        int min = p;
        int max = u;

        do
        {
            while (A[min] < med)
            {
                min++;
            }
            while (A[max] > med)
            {
                max--;
            }

            if (min <= max)
            {
                int temp = A[min];
                A[min] = A[max];
                A[max] = temp;

                min++;
                max--;
            }
        } while (min <= max);

        if (p < max)
            QuickSort2(A, p, max);

        if (u > min)
            QuickSort2(A, min, u);
    }

    public void main(String[] args) {
        Scanner cin = new Scanner(System.in);

        System.out.println("Introduceti dimensiunea vectorului: ");
        int n = cin.nextInt();

        System.out.println("Introduceti elementele vectorului: ");
        int[] A = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            A[i] = cin.nextInt();
        }

        QuickSort2(A, 1, n);

        for (int i = 1; i <= n; i++)
        {
            System.out.print(A[i] + " ");
        }
    }
}



