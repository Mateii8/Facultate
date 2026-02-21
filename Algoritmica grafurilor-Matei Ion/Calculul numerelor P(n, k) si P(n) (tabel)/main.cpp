#include <iostream>

using namespace std;

///Generarea numerelor P(n, k) si P(n) (tabel)
int n, k, t[100];

void Afisare(int t[], int k)
{
    for (int i = 1; i <= k; i++)
        cout << t[i] << " ";
    cout << endl;
}

int Generare_P_tabel(int n, int k)
{
    int r, j, nr = 0;
    for (int i = 1; i <= k - 1; i++)
        t[i] = 1;
    t[k] = n - k + 1;
    nr++;
    do
    {
        j = k - 1;
        while (t[j] > t[k] - 2 && j > 0)
            j--;
        if (j > 0)
        {
            t[j]++;
            for (int i = j + 1; i <= k - 1; i++)
                t[i] = t[j];
            r = 0;
            for (int i = 1; i <= k - 1; i++)
                r = r + t[i];
            t[k] = n - r;
            nr++;
        }
    } while (j > 0);
    return nr;
}

int main()
{
   cin >> n;
   for (int i = 1; i <= n; i++) {
        int sum = 0;
        for (int j = 1; j <= n; j++) {
            if (j <= i) {
                cout << Generare_P_tabel(i, j) << " ";
                sum += Generare_P_tabel(i, j);
            }
            else
                cout << "0" << " ";
        }
        cout << sum;
        cout << endl;
   }
}
