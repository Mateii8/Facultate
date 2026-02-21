#include <iostream>

using namespace std;
int a[100],n;
void afisare(int c[100],int a[100], int n)
{
    int i;
    for(i=1;i<=n;i++)
        if(c[i]==1)
            cout<<a[i]<<" ";
    cout<<endl;
}
int submult(int a[100],int n)
{
    int k,i,c[100];
    for(i=1;i<=n;i++)
        c[i]=1;
    afisare(c,a,n);
    do{
        k=n;
        while(c[k]==2 && k>0) k--;
        if(k>0)
        {
            c[k]=2;
            for(i=k+1;i<=n;++i)
                c[i]=1;
            afisare(c,a,n);
        }
    }while(k>0);
}
int main()
{
    cin>>n;
    for(int i=1;i<=n;i++)
        cin>>a[i];
    submult(a,n);
    cout<<"multimea vida";
    return 0;
}
