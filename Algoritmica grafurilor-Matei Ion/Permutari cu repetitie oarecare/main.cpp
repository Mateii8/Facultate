#include <iostream>
using namespace std;
int n,m,i,j,t[100],k,p[100],b[100];
void afisare (int a[],int b[], int n)
{
    for(int i=1; i<=n; i++)
        cout<<b[a[i]]<<" ";
    cout<<endl;
}
void permutari_cu_repetitie(int n, int t[], int m)
{
    n=0;
    for(i=1; i<=m; i++)
        n=n+t[i];
    i=0;
    for(j=1; j<=m; j++)
        for(k=1; k<=t[j]; k++)
        {
            i++;
            p[i]=j;
        }
    afisare(p,b,n);
    do
    {
        k=n-1;
        while(p[k]>=p[k+1] && k>0) k--;
        if(k>0)
        {
            j=n;
            while(p[j]<=p[k]) j--;
            swap(p[k],p[j]);
            for(i=1; i<= (n-k)/2; i++)
                swap(p[k+i],p[n-i+1]);
            afisare(p,b,n);
        }
    }
    while(k>0);
}
int main()
{
    cout<<"m= ";
    cin>>m;
    cout<<"n= ";
    cin>>n;
    for(i=1; i<=m; i++)
        cin>>t[i];
    for(int i=1; i<=n; i++)
        cin>>b[i];
    permutari_cu_repetitie(n,t,m);
    return 0;
}
