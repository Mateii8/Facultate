#include <iostream>
using namespace std;
int p[100],n,m,c[100];
void afisare (int a[],int p[], int n)
{
    for(int i=1; i<=n; i++)
        cout<<a[p[i]]<<" ";
    cout<<endl;
}
void permutari (int n)
{
    int k,j;
    for(int i=1; i<=n; i++)
        p[i]=i;
    afisare(c,p,n);
    do
    {
        k=n-1;
        while(p[k]>=p[k+1] && k>0)
            k--;
        if(k>0)
        {
            j=n;
            while(p[j]<=p[k])
                j--;
            swap(p[k],p[j]);
            for(int i=1; i<= (n-k)/2 ; i++)
                swap(p[k+i],p[n-i+1]);
            afisare(c,p,n);
        }
    }
    while(k>0);
}
void aranjamente (int m, int n)
{
    int k;
    for(int i=1; i<=n; i++)
        c[i]=i;
    permutari(n);
    do
    {
        k=n;
        while(c[k] == m-n+k && k>0)
            k--;
        if(k>0)
        {
            c[k]++;
            for(int i=k+1; i<=n; i++)
                c[i]=c[i-1]+1;
            permutari(n);
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
    for(int i=1; i<=n; i++)
        cin>>c[i];
    aranjamente(m,n);
    return 0;
}
