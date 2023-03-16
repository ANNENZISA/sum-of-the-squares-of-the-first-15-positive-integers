using System;

class Program {
    static void Main(string[] args) {
        int num = 1;
        int sum = 0;
        
        while (num <= 15) {
            sum += num*num;
            num++;
        }
        
        Console.WriteLine("The sum of squares of first 15 positive integers is: {0}", sum);
    }
}           
