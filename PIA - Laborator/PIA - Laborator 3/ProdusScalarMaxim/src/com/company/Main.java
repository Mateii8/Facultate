package com.company;
import  java.util.Scanner;
public class Main {
    public  int i, j;
    public void Sortare(int [] multime) {
        for (i = 0; i < multime.length-1; i++)
            for (j = i + 1; j < multime.length; j++)
                if(multime[i]>multime[j])
                {
                    multime[i]=multime[i]+multime[j];
                    multime[j]=multime[i]-multime[j];
                    multime[i]=multime[i]-multime[j];
                }

    }

    public void Maxim2(int[] multime1,int [] multime2,int s)
    {
        Sortare(multime1);
        Sortare(multime2);
        s=0;
        for(i=0;i<multime1.length;i++)
        {
            s=s+multime1[i]*multime2[i];
        }

        afisare(s,multime1,multime2);
    }

    public void afisare(int s,int[] multime1,int[] multime2) {
        for (i = 0; i < multime1.length; i++) {
            System.out.print(multime1[i] + " ");
        }
        System.out.println();
        for (i = 0; i < multime2.length; i++) {
            System.out.print(multime2[i]+" ");
        }
        System.out.println();
        System.out.println("Produsul scalar maxim este:" + s);
    }

    public static void main(String[] args) {
        Scanner scanner=new Scanner(System.in);
        int elemente,i;
        int[] multime1;
        int[] multime2;
        int s=0;
        System.out.print("Dati numarul de elemente ale multimii: ");
        elemente=scanner.nextInt();
        multime1=new int[elemente];
        multime2=new int[elemente];
        System.out.println("Tastati elementele multimii 1: ");
        for (i=0;i<multime1.length;i++) {
            System.out.print("Tastati elementul " +(i + 1)+" :");
            multime1[i]=scanner.nextInt();
        }
        System.out.println("Tastati elementele multimii 2: ");
        for (i=0;i<multime2.length;i++) {
            System.out.print("Tastati elementul " +(i + 1)+" :");
            multime2[i]=scanner.nextInt();
        }
        Main main=new Main();
        main.Maxim2(multime1,multime2,s);

    }

}
