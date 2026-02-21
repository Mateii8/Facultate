#include <iostream>
using namespace std;
int c[100],n,m;
void afisare(int c[],int n)
{
for(int i=1;i<=n;i++)
cout<<c[i]<<” “;
cout<<endl;
}
void combinari(int m,int n)
{
int k;
for(int i=1;i<=n;i++)
 c[i]=i;
afisare(c,n);
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
 afisare(c,n);
 }
 }while (k>0);
}
int main()
{
 cin>>m>>n;
 combinari(m,n);
 return 0;
}
