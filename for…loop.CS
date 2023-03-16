using System;

class Program {
    static void Main(string[] args) {
        int sum = 0;
        
        for (int num = 1; num <= 15; num++) {
            sum += num*num;
        }
        
        Console.WriteLine("The sum of squares of first 15 positive integers is: {0}", sum);
    }
}
