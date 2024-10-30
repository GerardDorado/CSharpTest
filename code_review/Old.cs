void foo(double a, double b, out double r0, out double r1)
{
    //The names of the variables should be more clear    
    int n = (int)Math.Floor(a / b) + 1;
    
    int m = 0;

    //Unnecesary step, you can assign m directly in line 4
    while (n > 0)
    {
        m++;
        n--;
    }

    double[] l = new double[m];
    //This for will throw an error in l[m], it should be i < m so the last step is [m-1]
    for (int i = 0; i <= m; ++i)
        l[i] = (double)i * a * b;

    //-1 is not the best value to initialize this since the first value of the array will always be 0
    //0 is a better option
    double s = -1;

    for (int i = 0; i <= m; ++i)
        s += l[i];

    double average = s / (double)m;

    r0 = s;
    r1 = average;
}