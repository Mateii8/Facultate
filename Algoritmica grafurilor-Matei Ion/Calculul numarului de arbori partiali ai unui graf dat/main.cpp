#include <iostream>
#include <iomanip>

using namespace std;

int a[20][100], x, n, m;

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

int determinant (int mat[20][100], int n)
{
    if (n == 1)
        return mat[1][1];
    if (n == 2)
        return mat[1][1] * mat[2][2] - mat[1][2] * mat[2][1];

    int temp[20][100], sign = 1, det = 0;

    for (int f = 1; f <= n; f++)
    {
        int subi = 1;
        for (int i = 2; i <= n; i++)
        {
            int subj = 1;
            for (int j = 1; j <= n; j++)
            {
                if (j == f)
                    continue;
                temp[subi][subj++] = mat[i][j];
            }
            subi++;
        }
        det += sign * mat[1][f] * determinant(temp, n - 1);
        sign = -sign;
    }
    return det;
}

int main()
{
    cout << "Nr. noduri: ";
    cin >> n;
    cout << "Nr. muchii: ";
    cin >> m;

    creareMatrice(n, m, a);

    Matrice_Admitanta();

    cout << "Numarul de arbori partiali ai grafului este " << determinant(a, n);
}


/**
5 7
1 2
1 3
2 3
2 3
3 4
2 5
2 4
*/
