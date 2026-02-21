#include <iostream>

using namespace std;

int a[20][100], x, y, n, m, nrc, CTC[100], d[50][100];

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

void ROY_WARSHALL()
{
    for (int i = 1; i <= n; i++)
        for (int j = 1; j <= n; j++)
            d[i][j] = a[i][j];
    for (int k = 1; k <= n; k++)
        for (int i = 1; i <= n; i++)
            for(int j = 1; j <= n; j++)
                d[i][j] = d[i][j] || d[i][k] && d[k][j];
}

int QUASI_TARE_CONEX (int n, int d[50][100])
{
    int OK;
    for (int i = 1; i <= n; i++)
    {
        OK = 1;
        for (int j = 1; j <= n; j++)
            if (i != j && !d[i][j])
        {
            OK = 0;
            break;
        }
        if (OK)
            return 1;
    }
    return 0;
}

int main()
{
    cout << "Nr. noduri: ";
    cin >> n;
    cout << "Nr. muchii: ";
    cin >> m;
    creareMatrice(n, m, a);

    ROY_WARSHALL();

    int q = QUASI_TARE_CONEX(n, d);

    if (q)
        cout << "Graful este quasi-tare conex.";
    else
        cout << "Graful nu este quasi-tare conex.";
}
