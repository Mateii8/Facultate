#include <iostream>
#include <iomanip>

using namespace std;

int a[20][100], y, x, VIZ[100], TATA[100], n, m, nrc, i, CC[100];

void creareMatrice(int n, int m, int a[20][100])
{
    int x, y;
    for (int i = 1; i <= m; i++)
    {
        cout << "Dati extremitatile muchiei " << i << ": ";
        cin >> x >> y;
        a[x][y]--;
        ///NEORIENTAT
        if (x != y)
            a[y][x]--;
    }
}

void Matrice_Admitanta()
{
    for (int i = 1; i <= n; i++)
    {
        int sum = 0;
        for (int j = 1; j <= n; j++)
            sum += a[i][j];
        a[i][i] = sum - 2 * sum;
    }
}

void afisareMatrice(int n, int a[20][100])
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
            cout << setw(2) << a[i][j] << " ";
        cout << endl;
    }
}

int main()
{
    cout << "Nr. noduri: ";
    cin >> n;
    cout << "Nr. muchii: ";
    cin >> m;

    creareMatrice(n, m, a);

    Matrice_Admitanta();

    afisareMatrice(n, a);
}
