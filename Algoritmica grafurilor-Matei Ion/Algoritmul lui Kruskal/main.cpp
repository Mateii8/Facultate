#include <iostream>

using namespace std;

void sortare(int p[3][50],int m)
{
    int i,aux;
    bool ok;
    do{
        ok=true;
        for(i=1;i<=m;i++)
        {
            if(p[3][i]>p[3][i+1])
                {
                    aux=p[1][i];
                    p[1][i]=p[1][i+1];
                    p[1][i+1]=aux;
                    aux=p[2][i];
                    p[2][i]=p[2][i+1];
                    p[2][i+1]=aux;
                    aux=p[3][i];
                    p[3][i]=p[3][i+1];
                    p[3][i+1]=aux;
                    ok=false;
                }
        }
    }while(ok);
}

int kruskal(int n,int m,int p[3][50])
{
    sortare(p,m);
    int i,k,l, x,y,c,aux,cost=0,poz=0;
    int cc[50];
    for(i=1;i<=n;i++)
        cc[i]=i;
    for(l=1;l<=n-1;l++)
    {
        k=poz;
        do{
            k++;
            x=p[1][k];
            y=p[2][k];
            c=p[3][k];
        }while(cc[x] == cc[y]);
        cost+=c;
        poz=k;
        aux=cc[y];
        for(i=1;i<=n;i++)
            if(cc[i]==aux)
                cc[i]=cc[x];
    }
    return cost;
}

int main()
{
    int n,m,i,p[4][50];
    cout<<"introduce ti nr de noduri: ";
    cin>>n;
    cout<<"introduce ti nr de muchii: ";
    cin>>m;
    for(i=1;i<=m;i++)
    {
        cout<<"muchia "<<i<<" si costul ei: ";
        cin>>p[1][i]>>p[2][i]>>p[3][i];
    }
    cout<<kruskal(n,m,p);
    return 0;
}
