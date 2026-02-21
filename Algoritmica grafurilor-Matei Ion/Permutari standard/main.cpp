#include <iostream>
using namespace std;
int p[100],n;
void afisare (int a[], int n)
{
    for(int i=1; i<=n; i++)
        cout<<a[i]<<" ";
    cout<<endl;
}
void permutari (int n)
{
    int k,j;
    for(int i=1; i<=n; i++)
        p[i]=i;
    afisare(p,n);
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
            afisare(p,n);
        }
    }
    while(k>0);
}
int main()
{
    cin>>n;
    permutari(n);
}
