using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new int[,]
        {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 9, 10, 11, 12, 13, 14, 15 },
            { 13, 14, 15, 16, 17, 18, 19 },
            { 0, 1, 2, 3, 4, 5, 6 }
        });
    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return 0;
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > 0) answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) != 4 && A.GetLength(1) != 4) return 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j == i) answer += A[i, j];
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int[] arr = new int[4];
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7) return answer;
        
        for (int i = 0; i < 4; i++)
        {
            int minElement = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < minElement)
                {
                    minElement = A[i, j];
                    index = j;
                }
            }

            arr[i] = index;
        }

        answer = arr;
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int maxElement = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > maxElement)
                {
                    maxElement = A[i, j];
                    index = j;
                }
            }
            A[i, index] = A[i, 0];
            A[i, 0] = maxElement;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 7) return null;
        
        int maxElement = A[0, 0];
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i < 6; i++)
        {
            int foo = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > foo)
                {
                    foo = A[i, j];
                    index = j;
                }
            }

            if (foo > maxElement)
            {
                maxElement = foo;
                index1 = i;
                index2 = index;
            }
        }

        // int[,] arr = new int[5, 6];
        //
        // int ii = 0;
        // int jj = 0;
        // for (int i = 0; i < 6; i++, ii++)
        // {
        //     if (i == index1)
        //     {
        //         ii--;
        //         continue;
        //     }
        //     for (int j = 0; j < 7; j++, jj++)
        //     {
        //         if (j == index2)
        //         {
        //             jj--;
        //             continue;
        //         }
        //         arr[ii, jj] = A[i, j];
        //     }
        // }

        // A = arr;
        
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j == index2 || i == index1)
                {
                    A[i, j] = 0;
                }
            }
        }
        // end  

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        for (int i = 0; i < 5; i++)
        {
            int foo = A[i, 0];
            int index = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] > foo)
                {
                    foo = A[i, j];
                    index = j;
                }
            }

            A[i, index] *= (i+1);
        }
        
        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here
        if (D.GetLength(0) != n && D.GetLength(1) != m) return null;

        for (int i = 0; i < n; i++)
        {
            bool isTrue = false;
            int foo = -9999;
            int index = -1;

            int bar = 0;
            int index2 = -1;
            for (int j = 0; j < m; j++)
            {
                if (D[i, j] < 0)
                {
                    isTrue = true;
                    bar = D[i, j];
                    index2 = j;
                }

                if (D[i, j] > foo && !isTrue)
                {
                    foo = D[i, j];
                    index = j;
                }
            }
            if (index2 == -1 || index == -1) continue;
            D[i, index] = bar;
            D[i, index2] = foo;
        }
        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here
        if (H.GetLength(0) != 5 && H.GetLength(1) != 7) return null;

        for (int i = 0; i < 5; i++)
        {
            int foo = H[i, 0];
            int index = 0;

            for (int j = 0; j < 7; j++)
            {
                if (H[i, j] > foo)
                {
                    foo = H[i, j];
                    index = j;
                }
            }

            H[i, 6] = H[i, 5];
            H[i, 5] = foo;
        }
        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here
        if (Y.GetLength(0) != 6 && Y.GetLength(1) != 5) return null;
        
        for (int i = 0; i < 6; i++)
        {
            double maxFoo = Y[0, 0];
            int index = -1;

            for (int j = 0; j < 5; j++)
            {
                if (Y[i, j] > maxFoo)
                {
                    maxFoo = Y[i, j];
                    index = j;
                }
            }

            int count = 0;
            double summa = 0;
            for (int j = index + 1; j < 5; j++)
            {
                if (Y[i, j] > 0)
                {
                    summa += Y[i, j];
                    count++;
                }
            }

            if (count > 0) summa /= count;
            for (int j = 0; j < index; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = summa;
            }
        }
        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here
        int[] arr = new int[5];
        
        if (B.GetLength(0) != 5 && B.GetLength(1) != 7) return null;

        int index = 0;
        for (int i = 4; i >= 0; i--)
        {
            int maxFoo = B[i, 0];
            for (int j = 0; j < 7; j++)
            {
                maxFoo = Math.Max(B[i, j], maxFoo);
            }

            arr[index] = maxFoo;
            index++;
        }

        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = arr[i];
        }
        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here
        if (B.GetLength(0) != 5 && B.GetLength(1) != 5) return null;

        int index = 0;
        for (int i = 0; i < 5; i++)
        {
            int maxFoo = 0;
            int maxFooIndex = -1;
            for (int j = 0; j < 5; j++)
            {
                if (i == j && maxFoo < B[i, j])
                {
                    maxFoo = B[i, j];
                    maxFooIndex = j;
                }
            }

        }

        for (int i = 0; i < 5; i++)
        {
            B[i, 3] = arr[i];
        }
        
        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null;
        
        int count = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    count++;
                }
            }
        }

        int[] arr = new int[count];
        int index = 0;
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < 0)
                {
                    arr[index] = A[i, j];
                    index++;
                }
            }
        }

        answer = arr;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}