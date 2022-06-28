// See https://aka.ms/new-console-template for more information
// author : Arthur Leyva
Console.WriteLine("Coding Challenge - Walk on the X Axis\n");

Console.Write("Enter the number of Lights : ");

// n equals the number of lights
int n = Convert.ToInt32(Console.ReadLine());

// n/2 will be the median of the given total lights. 
int median = Convert.ToInt32(n/2);

// if the number of lights is odd, then subtract the median else add the median
int num = 0;
if (n > 2)
{
    switch (n%2)
    {
        case 0:
            num = num + median; //even
            break;
        case 1:
            num = num - median; //odd
            break;
    }
}

// first, get the total or sum of all numbers less than the median (eg, n=8, median is 4, 3,2,1,0)
// second, get the total or sum of all number greater than the median (eg, n=8 median is 4, 5,6,7)
int lmedian = 0; //numbers less than median
int rmedian = 0; //numbers greater than median

for(int i=0; i<n; i++)
{
    if (i < median)
    { lmedian = lmedian + i; } //left of median
    else { rmedian = rmedian + i; } //right of median
}

// Get the total distance walked
int totalwalk = (rmedian * 2) - (lmedian * 2) + num;

//Display the total walk made on turning off the lights.
Console.WriteLine("\nTotal number of lights = " + n);
Console.WriteLine("The total distance walked made was " + totalwalk + " steps.");




