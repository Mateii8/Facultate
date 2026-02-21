#include <iostream>
using namespace std;
int n,m,c[100];
void afisare(int c[], int n)
{
    for(int i=1; i<=n; i++)
        cout<<c[i]<<" ";
    cout<<endl;
}
void combinari_cu_repetitie(int m, int n)
{
    int k;
    for(int i=1; i<=n; i++)
        c[i]=1;
    afisare(c,n);
    do
    {
        k=n;
        while(c[k]==m && k>0) k--;
        if(k>0)
        {
            c[k]++;
            for(int i=k+1; i<=n; i++) c[i]=c[k];
            afisare(c,n);
        }
    }
    while(k>0);
}
int main()
{
    cout << "m= ";
    cin>>m;
    cout<<"n= ";
    cin>>n;
    combinari_cu_repetitie(m,n);
    return 0;
}
