#include <iostream>

using namespace std;

int a[20][100], n, m, i, j, k, CTC[100], nrc;

void creareMatrice(int n, int m, int a[20][100])
{
    int x, y;
    for (int i = 1; i <= m; i++)
    {
        cout << "Dati extremitatile muchiei " << i << ": ";
        cin >> x >> y;
        a[x][y]++;
    }
}

void Ray_Warshall()
{
    for (i = 1; i <= n; i++)
        for (j = 1; j <= n; j++)
            d[i][j] = a[i][j];
    for (k = 1; k <= n; k++)
        for (i = 1; i <= n; i++)
            d[i][j] = d[i][j] || (d[i][k] * d[k][j])
}

void Componente_Tare_Conexe()
{
    nrc = 0;
    for (i = 1; i <= n; i++)
        CTC[i] = 0;
    Roy_Warshall();
    for (i = 1; i <= n; i++)
    {
        if (CTC[i] == 0)
        {
            nrc++;
            CTC[i] = nrc;
            for (j = i + 1; j <= n; j++)
                if (CTC[j] == 0 && d[i][j] == 1 && d[j][i] == 1)
                    CTC[j] = nrc;
            cout << i << " ";
        }
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

    Componente_Tare_Conexe();
}
