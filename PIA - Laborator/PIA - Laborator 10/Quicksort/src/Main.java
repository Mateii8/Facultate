import java.util.Scanner;

public class Main {

    public int Pivot(int[] A, int p, int u)
    {
        int cp = 0, cu = -1;

        while (p < u)
        {
            if (A[p] > A[u])
            {
                int temp = A[p];
                A[p] = A[u];
                A[u] = temp;

                int m = cp;
                cp = -cu;
                cu = -m;
            }

            p += cp;
            u += cu;
        }

        return p;
    }

    public void QuickSort(int[] A, int p, int u)
    {
        if (p < u)
        {
            int k = Pivot(A, p, u);
            QuickSort(A, p, k - 1);
            QuickSort(A, k + 1, u);
        }
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

        QuickSort(A, 1, n);

        for (int i = 1; i <= n; i++)
        {
            System.out.print(A[i] + " ");
        }
    }
}



