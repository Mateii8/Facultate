#include <iostream>

using namespace std;
int d[30][30],a[30][30],n,m,i,j,k,c[30][30];

void creareMatrice(int n,int m,int a[30][30])
{
    int x,y;
    for( i = 1; i <= m; i++)
    {
        cout<<"dati extremitatile muchiei "<<i<<":";
        cin>>x>>y;
        a[x][y]=1;
        ///pt neorientat
       ///a[y][x]=1;
    }
}

void royWarshall(int n,int a[30][30],int d[30][30])
{
    for(i=1; i<=n; i++)
        for(j=1; j<=n; j++)
            d[i][j]=a[i][j];
    for(k=1; k<=n; k++)
        for(i=1; i<=n; i++)
            for(j=1; j<=n; j++)
                d[i][j]=d[i][j] | (d[i][k] & d[k][j]);
}

void afisareMatrice(int n, int m[30][30])
{
    int i,j;
    for(i=1; i<=n; i++)
    {
        for(j=1; j<=n; j++)
            cout<<m[i][j]<<" ";
        cout<<endl;
    }
}
void Roy_Floyd(int n.int c[50][50],int c2[50][50])
{
    for(int i=1;i<=n;i++)
    {
         for(j=1;j<=n;j++)
         {
              c2[i][j]=c[i][j];
         }
    }

    for(int k=1; k<=n; k++)
        for(int i=1; i<=n; i++)
        {


            {
                for(int j=1; j<=n; j++)
                {
                    if(c2[i][k]+c2[k][i]<c2[i][j])
                        c2[i][j]=c2[i][k]+c2[k][j];
                }
            }

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
    Roy_Floyd();
    cout<<"\n Matricea costurilor minime(Roy-Floyd) : "<<endl;
    afisareMatrice(n,c);
    return 0;
}
