# CSharpTest

There are 3 exercises

## 1 - Parking Lot 
Imagine that you are building a parking lot that has two types of parking slots. Big and small. 

The big slot  can park either a bus or 3 cars. The small slot can only park 1 car.

Write a function that, taking the following parameters: The number of big slots, the number of small slots, the number of buses and the number of cars, calculates the *minimum* number of total slots that will be occupied by the buses and cars. 
Make sure to make the function robust for all possible combinations of parameters even if they don’t make any sense.

## 2 - Model Classes

Design and implement a **hierarchy of classes** that model the following situation:

You have 3 different types of *geometric figures*: *triangles*, *rectangles* and *circles*.

All these classes have in common the *Perimeter* and *Area* properties, as well as a method to draw them on a “Canvas”. A canvas class has methods to draw Triangles, Rectangles and Circles.
There are two **concrete** types of canvases. 

A “bitmap canvas” that knows how to draw triangles, rectangles and circles on a Bitmap.

A second “export canvas” that actually writes the points of the figures into a text file so that they can be imported into another application.

## 3 - Code Review
You come across the following code in a review and you are tasked with modifying it in whatever way you think is appropriate:

`void foo ( double a, double b, out double r0, out double r1)
{
  int n = (int)Math.Floor(a / b) + 1 ;`

  `int m = 0 ;`

  `while ( n > 0 )
  {
    m ++ ;
    n -- ;
  }`

  `double[] l = new double[m];
  for ( int i = 0 ; i <= m ; ++ i )
     l[i] = (double)i * a * b ;`

  `double s = -1 ;`

  `for ( int i = 0 ; i <= m ; ++ i )
     s += l[i] ;`

  `double average = s / (double)m ;`

  `r0 = s ;
   r1 = average ;`

`}`