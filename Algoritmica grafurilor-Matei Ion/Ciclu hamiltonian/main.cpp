#include <iostream>
using namespace std;

void creeareMatrice(int n,int m,int a[30][30])
{
        int x,y;
        for(int i=1;i<=m;i++)
        {
            cout<<"dati extremitatile muchiei ";
            cin>>x>>y;
            a[x][y]++;
            ///neorientat
            if(x!=y) a[y][x]++;
        }
}

int grad(int x,int n,int a[30][30])
{
    int s=0;
    for(int i=1;i<=n;i++)
        if(x==i)
            s+=a[x][i]*2;
        else
            s+=a[x][i];
    return s;
}

void inchidere(int a[30][30],int n)
{
    bool ok;
    int x,y,grad_x;
    do
    {
        ok=true;
        for(x=1;x<=n;x++)
        {
            grad_x=grad(x,n,a);
            for(y=1;y<=n;y++)
            {
                if(x==y) continue;
                if(a[x][y] || a[y][x]) continue;
                if(grad_x + grad(y,n,a)>=n)
                {
                    a[x][y]=1;
                    a[y][x]=1;
                    grad_x++;
                    ok=false;
                }
            }
        }
    }while(!ok);
}

void afisareMatrice(int n, int a[30][30])
{
    int i,j;
    for(i=1;i<=n;i++)
    {
        for(j=1;j<=n;j++)
            cout<<a[i][j]<<" ";
        cout<<endl;
    }
}

bool esteGrafComplet(int n,int a[30][30])
{
    int i,j;
    for(i=2;i<=n;i++)
        for(j=1;j<i;j++)
        {
            if(a[i][j]) return false;
        }
    return true;
}

int main()
{
    int n,m,a[30][30]={};
    cout<<"nr de noduri ";
    cin>>n;
    cout<<"nr de muchii ";
    cin>>m;
    creeareMatrice(n,m,a);
    inchidere(a,n);
    cout<<"matricea adiacenta cu inchidere "<<endl;
    afisareMatrice(n,a);
    if(esteGrafComplet(n,a))
        cout<<"inchiderea este completa, deci este hamiltonian";
    else
        cout<<"inchiderea nu este completa";
    return 0;
}
