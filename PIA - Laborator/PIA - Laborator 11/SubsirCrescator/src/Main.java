public class Main {

    public static void main(String[] args) {
        int[] A = {12, 5, 9, 8, 17, 6, 2, 7, 10, 4}; //vector A
        int n = A.length;


        int[] L = new int[n];
        int[] P = new int[n];


        L[n - 1] = 1;
        P[n - 1] = -1;


        for (int i = n - 2; i >= 0; i--) {
            L[i] = 1;
            P[i] = -1;

            for (int j = i + 1; j < n; j++) {
                if (A[j] >= A[i] && 1 + L[j] > L[i]) {
                    L[i] = 1 + L[j];
                    P[i] = j;
                }
            }
        }
        int k = L[0];
        int t1 = 0;

        for (int i = 1; i < n; i++) {
            if (L[i] > k) {
                k = L[i];
                t1 = i;
            }
        }

        System.out.println("Lungimea maxima k = " + k);
        System.out.print("Subsir crescator maxim: ");

        int index = t1;
        while (index != -1) {
            System.out.print(A[index] + " ");
            index = P[index];
        }
    }
}


