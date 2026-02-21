#include <iostream>

using namespace std;
int n,c[100],m[100];
void afisare(int c[],int n)
{
    for(int i=1; i<=n;i++)
        cout<<c[i]<<" ";
    cout<<endl;
}

void produsCartezian(int n,int m[])
{
    int k;
    for(int i=1;i<=n;i++)
        c[i]=1;
    afisare (c,n);
    do
    {
        k=n;
        while(c[k]==m[k] && k>0)
            k--;
        if(k>0)
        {
            c[k]++;
            for(int i=k+1;i<=n;i++)
                c[i]=1;
            afisare(c,n);
        }
    }while(k>0);
}

int main()
{
    cin>>n;
    for(int i=1;i<=n;i++)
        cin>>m[i];
    produsCartezian(n,m);
    return 0;
}
