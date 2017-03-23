using System;
namespace SomeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter matrix A dimension:");
            int rowA = Convert.ToInt32(Console.ReadLine());
            int colA= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter matrix B dimension:");
            int rowB = Convert.ToInt32(Console.ReadLine());
            int colB= Convert.ToInt32(Console.ReadLine());
            
            Matrix A = new Matrix(rowA,colA,1);
            Matrix B = new Matrix(rowB,colB,1);
            Console.WriteLine( A.ToString());
            Console.WriteLine(B.ToString());
            if(A.Columns==B.Rows)
                Console.WriteLine(A.Multiply(B).ToString());
            else
            {
                Console.WriteLine("Can't be multiplied");
            }
            Console.ReadLine();


        }
    }
}
