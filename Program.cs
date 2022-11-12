// Задача 62 Устройство для спирального заполнения массива 4*4
int m=4;
int [,] array=new int[m,m];
int s=1;
int c = 1;
int d = 1;
for (int y = 0; y < m; y++) 
    {
    array[0,y] = s;
    s++;
    }

for (int x = 1; x < m; x++) 
    {
    array[x, m - 1] = s;
    s++;
    }

for (int y = m - 2; y >= 0; y--) 
    {
    array[m - 1,y] = s;
    s++;
    }

for (int x = m - 2; x > 0; x--) 
    {
    array[x,0] = s;
    s++;
    }
while (s < m * m) 
    {
        while (array[c,d + 1] == 0) 
            {
            array[c,d] = s;
            s++;
            d++;
            }
        while (array[c + 1,d] == 0) 
            {
            array[c,d] = s;
            s++;
            c++;
            }
        while (array[c,d - 1] == 0)
            {
            array[c,d] = s;
            s++;
            d--;
            }
        while (array[c - 1,d] == 0)
            {
            array[c,d] = s;
            s++;
            c--;
            }
        }
        
for (int x = 0; x < m; x++) 
    {
    for (int y = 0; y < m; y++) 
        {
            if (array[x,y] == 0) 
            {
            array[x,y] = s;
            }
        }
    }
Console.WriteLine("Массив 4*4 в спиральном выводе");
for (int i=0;i<m;i++)
    {
    for (int j=0;j<m;j++)
        Console.Write("{0:d2} ",array[i,j]);
    Console.WriteLine();
    } 
 
