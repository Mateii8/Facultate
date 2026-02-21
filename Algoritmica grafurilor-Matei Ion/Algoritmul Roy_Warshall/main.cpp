#include <iostream>

using namespace std;
int d[30][30],a[30][30],n,m,i,j,k;

void creareMatrice(int n,int m,int a[30][30])
{
    int x,y;
    for( i = 1; i <= m; i++)
    {
        cout<<"dati extremitatile muchiei "<<i<<":";
        cin>>x>>y;
        a[x][y]=1;
        ///pt neorientat
        a[y][x]=1;
    }
}

void royWarshall(int n,int a[30][30],int d[30][30])
{
    for(i=1;i<=n;i++)
        for(j=1;j<=n;j++)
            d[i][j]=a[i][j];
    for(k=1;k<=n;k++)
        for(i=1;i<=n;i++)
            for(j=1;j<=n;j++)
                d[i][j]=d[i][j] | (d[i][k] & d[k][j]);
}

void afisareMatrice(int n, int m[30][30])
{
    int i,j;
    for(i=1;i<=n;i++)
    {
        for(j=1;j<=n;j++)
            cout<<m[i][j]<<" ";
        cout<<endl;
    }
}

int main()
{
    cout<<"dati nr de noduri: ";
    cin>>n;
    cout<<"dati nr de muchii: ";
    cin>>m;

    creareMatrice(n,m,a);
    royWarshall(n,a,d);

    afisareMatrice(n,d);

    return 0;
}
