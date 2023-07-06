using System;
class Course
{
    int [] week = new int[] { 1, 2, 3, 4, 5, 6, 0 };
    int[] start = new int[] { 14, 10, 17, 19, 20, 20, 10 };
    int[] price = new int[] { 1000, 1000, 800, 800, 1000, 1200, 1500 };

    public int weeknum(int i) 
    {
        return week[i];
    }
    public int startnum(int i) 
    {
        return start[i];
    }
    public int pricenum(int i) 
    {
        return price[i];
    }
}