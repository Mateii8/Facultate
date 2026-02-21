package com.company;
import java.text.DecimalFormat;
import java.util.Date;
import java.util.Scanner;

public class Main {
    int i, j;

    public void Sortare(double[] a, double[] b) {
        double aux;
        for(i = 0; i < b.length - 1; i++)
        {
            for(j = i + 1; j <b.length; j++)
            {
                if (b[i] > b[j])
                {
                    aux = b[i];
                    b[i] = b[j];
                    b[j] = aux;
                    aux = a[i];
                    a[i] = a[j];
                    a[j] = aux;
                }
            }
        }
    }

    public void Spectacole1(double[] a, double[] b) {
        Sortare(a, b);
        int m = 0;
        double t;
        int[] c = new int[a.length];
        for (i = 0; i < a.length; i++)
            c[i] = 0;
        t = a[0] - 1;
        for (i = 0; i < a.length; i++) {
            if (a[i] > t) {
                c[i] = 1;
                m++;
                t = b[i];
            }
        }
        Afisare(m, c, a, b);
    }
    public void Afisare(int nrspectacole, int[] c, double[]inceput,double[] sfarsit) {
        for (i = 0; i <inceput.length; i++)
            if (c[i] == 1)
                System.out.println(inceput[i] + " "+sfarsit[i]);
        System.out.println("Numarul de spectacole este: " + nrspectacole);
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int numarSpectacole, i;
        System.out.print("Tastati numarul de spectacole: ");
        numarSpectacole = scan.nextInt();
        double[] inceput = new double[numarSpectacole];
        double[] sfarsit = new double[numarSpectacole];
        System.out.println("Tastati orele de inceput pentru spectacole: ");
        for (i = 0; i < inceput.length; i++) {
            inceput[i] = scan.nextDouble();

        }
        System.out.println("Tastati orele de terminare pentru spectacole:");
        for (i = 0; i < sfarsit.length; i++) {
            sfarsit[i] = scan.nextDouble();

        }

        Main main=new Main();
        System.out.println("Solutia optima este :");
        main.Spectacole1(inceput,sfarsit);
    }
}
//8.00 8.10 8.15 8.50 9.10 9.20 9.20 10.45 11.00 12.00 12.10 12.30 13.00 13.40
//9.10 9.00 9.00 10.20 10.40 10.30 11.00 12.00 12.30 13.30 14.00 13.50 14.30 15.00