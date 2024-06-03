/*LINQ (Language Integrated Query) là một phần quan trọng của .NET Framework,
 * cho phép bạn thực hiện các truy vấn trên các nguồn dữ liệu như các mảng.
 * Trong LINQ, có một số hàm tổng quát (aggregate functions) để thực hiện các phép toán thống kê trên dữ liệu.
 * */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Tính tổng của mảng
        var sum = numbers.Sum();
        Console.WriteLine("Tổng của mảng là: " + sum);

        // Tìm giá trị lớn nhất trong mảng
        var max = numbers.Max();
        Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max);

        // Tìm giá trị nhỏ nhất trong mảng
        var min = numbers.Min();
        Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + min);

        // Tính trung bình của các phần tử trong mảng
        var average = numbers.Average();
        Console.WriteLine("Trung bình của mảng là: " + average);

        // Tính tổng số lần phần tử xuất hiện trong mảng
        var count = numbers.Count();
        Console.WriteLine("Số lượng phần tử trong mảng là: " + count);

        // Sử dụng Aggregate để tính tích của các phần tử trong mảng
        var product = numbers.Aggregate((a, b) => a * b);
        Console.WriteLine("Tích của mảng là: " + product);

        // Sử dụng Aggregate để tính tổng của tất cả các phần tử trong mảng
        int sum1 = numbers.Aggregate((acc, x) => acc + x);
        Console.WriteLine("Tổng của mảng là: " + sum1);

        // Sử dụng Aggregate để tìm phần tử lớn nhất trong mảng
        int max1 = numbers.Aggregate((acc, x) => acc > x ? acc : x);
        Console.WriteLine("Giá trị lớn nhất trong mảng là: " + max1);

        // Sử dụng Aggregate để ghép các số thành một chuỗi
        string concatenated = numbers.Aggregate("", (acc, x) => acc + x.ToString() + ", ");

        // Loại bỏ dấu ',' cuối cùng
        concatenated = concatenated.TrimEnd(' ', ',');
        Console.WriteLine("Chuỗi kết hợp từ các phần tử trong mảng: " + concatenated);
    }
}
