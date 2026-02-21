package com.company;
import  java.util.Scanner;
public class Main {

    int i, j;

    public void Sortare(float[] g,float[] c) {
        float aux;
        for (i = 0; i < c.length-1; i++)
            for (j = i+1; j<c.length; j++)
                if (c[i] / g[i] < c[j] / g[j])
                {
                    aux = c[i];
                    c[i] = c[j];
                    c[j] = aux;
                    aux = g[i];
                    g[i] = g[j];
                    g[j] = aux;
                }
    }
    public void Rucsac(int G,float[] g,float[] c)
    {   int R;
        float C;
        float [] x;
        x =new  float[g.length];
        Sortare(g,c);
        R=G;
        C=0;
        i=0;
        while (R>0)
        {
            if(g[i]<=R)
            { x[i]=1;
                C+=c[i];
                R-=g[i];
                i++;
            }
            else
            {
                x[i]=R/g[i];
                C=C+x[i]*c[i];
                R=0;
                for(j=i+1;j<c.length;j++)
                    x[j]=0;
            }
        }
        Afisare(C,x);
    }
    public void Afisare(float C,float[] x){
        System.out.println("Castigul maxim este: " + C);
        System.out.println("Solutia optima este:");
        for(i=0;i<x.length;i++)
        {
            System.out.print(x[i]+" ");
        }
    }

    public static void main(String[] args) {
        Scanner scan =new Scanner(System.in);
        int greutateMaxima;
        int numarObiecte,i;
        System.out.print("Tastati numarul de obiecte: ");
        numarObiecte=scan.nextInt();
        float[] castig=new float[numarObiecte];
        float[] greutate=new float[numarObiecte];
        System.out.print("Tastati greutatea maxima a rucsacului: ");
        greutateMaxima=scan.nextInt();
        System.out.println("Tastati greutatea obiectelor:");
        for(i=0;i<greutate.length;i++)
            greutate[i]=scan.nextFloat();
        System.out.println("Tastati castigul obiectelor:");
        for(i=0;i<castig.length;i++)
            castig[i]=scan.nextFloat();
        System.out.println();
        Main main=new Main();
        main.Rucsac(greutateMaxima,greutate,castig);

    }
}
//10 7 10 5 6 10 8 15 3 12
//27 9 40 20 11 20 50 22 4 33