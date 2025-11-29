using System;

public class Task4
{
    static Random rand = new Random();
    public static void Run(int[,] mat1 , int[,] mat2)
    {
        if (mat1.GetLength(0) != mat2.GetLength(0))
        {
            Console.WriteLine("First and second matrix must have the same size");
            return;
        }

        for (int i = 0; i < mat1.GetLength(0); i++)
        for (int j = 0; j < mat1.GetLength(1); j++)
        {
            mat1[i, j] = rand.Next(1, 10);
            mat2[i, j] = rand.Next(1, 10);
        }
        Console.WriteLine("First and second matrix:");
        PrintMatrix(mat1);
        Console.WriteLine();
        PrintMatrix(mat2);
        
        Console.Write("Enter a number to multiply matrix: ");
        int number =  Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < mat1.GetLength(0); i++)
        for (int j = 0; j < mat1.GetLength(1); j++)
        {
            mat1[i, j] *= number ;
            mat2[i, j] *= number;
        }
        
        Console.WriteLine("First and second matrix after multiply:");
        PrintMatrix(mat1);
        Console.WriteLine();
        PrintMatrix(mat2);
        
        int[,] sumMat = new int[mat1.GetLength(0), mat1.GetLength(1)];
        
        for (int i = 0; i < mat1.GetLength(0); i++)
        for (int j = 0; j < mat1.GetLength(1); j++)
        {
            sumMat[i, j] = mat1[i, j] + mat2[i, j] ;
        }
        
        Console.WriteLine("Sum matrix:");
        PrintMatrix(sumMat);
        
        int[,] multMat = new int[mat1.GetLength(0), mat1.GetLength(1)];
        
        for (int i = 0; i < mat1.GetLength(0); i++)
        for (int j = 0; j < mat1.GetLength(1); j++)
        {
            multMat[i, j] = mat1[i, j] * mat2[i, j] ;
        }
        
        Console.WriteLine("Multiply matrix:");
        PrintMatrix(multMat);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");
        
            Console.WriteLine();
        }
    }
}