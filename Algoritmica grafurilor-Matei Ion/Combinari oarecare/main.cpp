#include <iostream>
using namespace std;
int c[100],b[100], n,m;
void afisare(int c[],int b[], int n)
{
    for(int i=1; i<=n; i++)
        cout<<b[c[i]]<<" ";
    cout<<endl;
}
void combinari (int m, int n)
{
    int k;
    for(int i=1; i<=n; i++)
        c[i]=i;
    afisare(c,b,n);
    do
    {
        k=n;
        while(c[k]== m-n+k && k>0)
            k=k-1;
        if(k>0)
        {
            c[k]++;
            for(int i= k+1; i<=n; i++)
                c[i]=c[i-1]+1;
            afisare(c,b,n);
        }
    }
    while (k>0);
}
int main()
{
    cin>>m>>n;
    for(int i=1; i<=m; i++)
        cin>>b[i];
    combinari(m,n);
    return 0;
}
