#include <iostream>

using namespace std;
int cc[30];
void creareMatrice(int n,int m,int a[20][100])
{
    int x,y;
    for(int i = 1; i <= m; i++)
    {
        cout<<"dati extremitatile muchiei "<<i<<":";
        cin>>x>>y;
        a[x][y]++;
        ///doar la neorientat
        if(x!=y) a[y][x]++;
    }
}

void viziteaza(int y,int x,int a[30][30])
{
    cc[x]=1;
    if(y)
    {
        a[y][x]=2;
        a[x][y]=2;
    }
}
void df(int x,int S,int a[30][30])
{
    int viz[30]={0},urm[30]={0},S[30],varf,i,j;
    viziteaza(0,x,a);
    viz[x]=1;
    tata[x]=0;
    varf=1;
    S[varf]=x;
    while(varf>0)
    {
        i=S[varf];
        j=urm[i]+1;
        while(a[i][j]==0 && j<=n) j++;
        if(j>n)
            varf--;
        else
        {
            urm[i]=j;
            if(viz[j]==0)
            {
                viziteaza(j);
                viz[j]=1;
                tata[j]=i;
                varf++;
                S[varf]=j;
            }
        }
    }
}
void compConexe(int n, int m, int a[30][30])
{
    ///?
        if(cc[i]==0)
            return false;
        return true;

}

int grad(int x,int n,int a[30][30])
{
    int s=0;
    for(int i=1;i<=n;i++)
    {
        if(a[x][i]==0) continue;
        s+=(x==i) ? 2:1
    }
    return x;
}

bool esteGrafPar(int n,int a[30][30])
{
    for(int x=1;x<=n;x++)
        if(grad(x,n,a)%2) return false;
    return true;
}

void viziteaza2(int x)
{
    cout<<x<<" ";
}
void ciclu_eulerian(int x,int n,int a[30][30])
{
    int i=x;
    int j;
    do{
        viziteaza2(i);
        j=1;
        while(a[i][j] != 1 && j<=n)
            j++;
        if(j<=n)
        {
            a[i][j]=0;
            a[j][i]=0;
            i=j;
        }
        else
        {
            j=1;
            while(a[i][j] != 2 && j<=n)
                j++;
            if(j<=n)
            {
                a[i][j]=0;
                a[j][i]=0;
                i=j;
            }
        }
    }while(j<=n);
}
int main()
{
    int n,m,a[30][30]={};
    cout<<"nr de noduri ";
    cin>>n;
    cout<<"nr de muchii "
    cin>>m;

    creeareMatrice(n,m,a);

    DF_nerecursiv(1,n,a);
    if((n!=1 || a[1][1] !=0) && esteConex(n,a) && esteGrafPar(n,a))
    {
        cout<<"graful este ciclu eulerian! un ciclu: ";
        ciclu_eulerian(1,n,a);
    }
    else cout<<"graful nu este ciclu eulerian";
    return 0;
}
