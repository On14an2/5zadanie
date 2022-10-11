using System;

Random rnd = new Random();
int n1 = rnd.Next(2, 21);
int n2 = rnd.Next(2, 21);
int n3 = rnd.Next(2, 21);
int n4 = rnd.Next(2, 21);

int[,,,] massive = new int[n1, n2, n3, n4];

int[] count = new int[11];

for (int i1 = 0; i1 < n1; i1++)
{
    for (int i2 = 0; i2 < n2; i2++)
    {
        for (int i3 = 0; i3 < n3; i3++)
        {
            for (int i4 = 0; i4 < n4; i4++)
            {
                massive[i1, i2, i3, i4] = rnd.Next(0, 101);
            }
        }
    }
}
foreach (int i in massive)
{
    if (i % 10 == 0)
    {
        if (i == 0) count[0]++;
        else if (i == 10) count[1]++;
        else if (i == 20) count[2]++;
        else if (i == 30) count[3]++;
        else if (i == 40) count[4]++;
        else if (i == 50) count[5]++;
        else if (i == 60) count[6]++;
        else if (i == 70) count[7]++;
        else if (i == 80) count[8]++;
        else if (i == 90) count[9]++;
        else if (i == 100) count[10]++;
    }
}
for (int i = 0; i < count.Length; i++)
{
    Console.Write($"{i * 10} - {count[i]}\n");
}
