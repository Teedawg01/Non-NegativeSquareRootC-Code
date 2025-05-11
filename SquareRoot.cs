using System; 

public class Square {
    public int Sqrt(int x) {
        if (x == 0) return 0;
        if (x == 1) return 1;
        
        long left = 1;
        long right = x;
        
        while (left <= right) {
            long mid = left + (right - left) / 2;
            long square = mid * mid;
            
            if (square == x) {
                return (int)mid;
            }
            else if (square < x) {
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        
        return (int)right;
    }
}

class Program
{
    static void Main(string[] args)
    {
       int x = 16;
        Square code = new Square();
        int result = code.Sqrt(x);
        Console.WriteLine(result);
    }
}