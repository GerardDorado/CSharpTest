void foo(double a, double b, out double rsum, out double rAverage)
{
    
    int numberOfValues = (int)Math.Floor(a / b) + 1;

    double[] values = new double[numberOfValues];

    for (int i = 0; i < numberOfValues; ++i)
        values[i] = (double)i * a * b;

    double sum = 0;

    foreach (double value in values)
    {
       sum += value 
    }

    double average = sum / (double)numberOfValues;

    rsum = sum;
    rAverage = average;
}