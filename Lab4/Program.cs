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

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        if (A.GetLength(0) == 0 || A.GetLength(1) == 0) 
        {
            return answer;

        }
        
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for  (int j = 0; j < A.GetLength(1); j++)
            {
                answer += A[i, j];
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

        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 6) 
        {
            return (0, 0);
        }
        
        int min = 100000;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    col = j;
                    row = i; 
                    
                }
            }
        }

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

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        if (A.GetLength(0) != 3 || A.GetLength(1) != 5) 
        {
            return answer;

        }
        
        int a = 0;
        answer = new int[5];
        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (A[i, j] > A[a, j])
                {
                    a = i;
                }
            }
            answer[j] = A[a, j];
        }
        
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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 7) return null;
        int max = 0;
        for(int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i, 2] > A[max, 2])
            {
                max = i;
            }
        }
        int p;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            p = A[3, i];
            A[3, i] = A[max,j];
            A[max, j] = p;

        }


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

        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 5) return null;
        int max = -100000;
        int max_index = 0;
        for (int i = 0; i < A.GetLength(0); i++)
        {
            if (A[i,i] > max)
            {
                max = A[i, i];
                max_index = i;

            }
        }
        for (int i = 0; i < A.GetLength(0); i++)
        {
            var p = A[i, 3];
            A[i, 3] = A[i, max_index];
            A[i, max_index] = p;
        }


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

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here
        for (int i = 0; i < n; i++)
        {
            int max = 0;
            for (int j = 0; j < m; j++)
            {
                if (A[i, j] > A[i, max])
                {
                    max = j;
                }
            }
            var b = A[i, max];
            for (int j = max; j < m - 1; j++)
            {
                A[i, j] = A[i, j + 1];
            }
            A[i, m - 1] = b;
        }


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

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here
        if (C.GetLength(0) != n || C.GetLength(1) != m)
        {
            return null;
        }
        for (int i = 0; i < n; i++)
        {
            int max = 0;
            for (int j = 0; j < m; j++)
            {
                if (C[i, j] > C[i, max])
                {
                    max = j;
                }
            }
            for (int j = 0; j < max; j++)
            {
                if (C[i, j] < 0) C[i, j] /= C[i, max];
            }
        }

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

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        int i_max = 0;
        int j_max = 0;
        int k = 0;
        double sum = 0;
        for (int i = 0; i < Z.GetLength(0); i++)
        {
            for (int j = 0; j < Z.GetLength(1); j++)
            {
                if (Z[i, j] > Z[i_max, j_max])
                {
                    i_max = i;
                    j_max = j;
                }
                if (Z[i, j] > 0)
                {
                    sum += Z[i, j];
                    k++;
                }
            }
        }
        if (k != 0)
        {
            Z[i_max, j_max] = sum / k;
        } 

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

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here
        if (X.GetLength(0) != 6 || X.GetLength(1) != 5)
        {
            return null;
        }
        int min_k = 100;
        int max_k = -100;
        int min = -1;
        int max = -1;

        for (int i = 0; i < 6; i++)
        {
            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                if (X[i, j] < 0)
                {
                    k++;
                }
            }
            if (k < min_k)
            {
                min_k = k;
                min = i;
            }
            if (k > max_k)
            {
                max_k = k;
                max = i;
            }
        }
        for (int j = 0; j < 5; j++)
        {
            int p = X[min, j];
            X[min, j] = X[max, j];
            X[max, j] = p;
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

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 7 || A.GetLength(1) != 5)
        {
            return null;
        }
        int max_i = -1;
        int sum_max = -1;

        int[,] C = new int[6, 5];

        for (int i = 0; i < 7; i++)
        {
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (A[i, j] > 0)
                {
                    sum += A[i, j];
                }
            }
            if (sum > sum_max)
            {
                sum_max = sum;
                max_i = i;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i < max_i)
                {
                    C[i, j] = A[i, j];
                } 
                else 
                {
                    C[i, j] = A[i + 1, j];
                }
            }
        }
        A = C;
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

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here
        if (A.GetLength(0) != 5 || A.GetLength(1) != 8 || B.Length != 5)
        {
            return null;
        }

        int min = 0;

        for (int j = 0; j < 7; j++)
        {
            if (A[4, j] < A[4, min])
            {
                min = j;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 7; j > min + 1; j--)
            {
                A[i, j] = A[i, j - 1];
            }
            A[i, min + 1] = B[i];
        }
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

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1);
        if (n != 5 || m!=7) 
        {
            return null;
        }

        for (int i = 0; i < n; i++)
        {
            int max_in = 0;
            double max = A[i,0];
            
            for (int i = 0; i < m; i++)
            {
                if (max < A[i, j])
                {
                    max_in = j;
                    max = A[i, j];
                    
                }
            }
            if (max_in == 0 && A[i, max_in + 1] > 0)
            {
                A[i, max_in + 1] *= 2;
            }
                
            else if (max_in == 0 && A[i, max_in + 1] < 0)
            {   
                A[i, max_in + 1] /= 2;
            }
            else if (max_in == (m-1) && A[i, max_in + 1] > 0)
            {
                A[i, max_in - 1] *= 2;
            }
            else if (max_in == (m-1) && A[i, max_in + 1] < 0)
                A[i,max_in- 1] /= 2;
            else
            {
                int index = (A[i, max_in - 1]<A[i,max_in + 1])?max_in-1:max_in+1;
                if (A[i, index] > 0)
                {
                    A[i, index] *=2;
                }
                else
                {
                    A[i,index] /=2;
                }
            }
        }


        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1);
        if (n != 7 || m != 5) 
        {
            return null;
        }

        for (int i = 0; i < m; i++)
        {
            int max = A[0,i];
            int max_index = 0;
            int k = 0;
            int count = 0;
            
            for (int j = 0; j < n; j++)
            {
                if (max < A[j, i])
                {
                    max = A[j, i];
                    max_index = j;
                }
                if (A[j, i] > 0)
                {
                    count++;
                }
                else if (A[j, i] == 0)
                {
                    k++;
                }
            }
            if (count > (n - count - k))
            {
                A[max_index, i] = 0;
            }
            else
            {
                A[max_index, i] = max_index;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here
        int n = A.GetLength(0);
        int m = A.GetLength(1);
        if (n != 10 || m != 5)
        {
            return null;
        }
        for (int i = 0; i < m; i++)
        {
            int max = A[0, i];
            int max_index = 0;
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                if (max < A[j, i])
                {
                    max = A[j, i];
                    max_index = j;
                    sum = 0;
                }
                else
                    sum += A[j, i];
            }
            if (max_index <= n / 2)
            {
                A[0,i] = sum;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1); 
        int c = B.Length;
        if (n != 7 || m != 5 || c != 5) 
        {
            return null;
        }

        for (int i = 0; i < m; i++)
        {
            int max = A[0, i];
            int max_index = 0;
            for (int j = 0; j < n; j++)
            {
                if (max < A[j, i])
                {
                    max = A[j, i];
                    max_index = j;
                }
            }
            if (max < B[i])
            {
                A[max_index, i] = B[i];
            }
        }

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1);
        if (n != 7 || m != 5) 
        {
            return null;
        }

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += A[i, 0] + A[i, m - 1];
        }
        sum = sum / 2;
        for (int i = 0; i < m; i++)
        {
            int max_index = 0;
            double max = A[0, i];
           
            for (int j = 0; j < n; j++)
            {
                if (max < A[j,i])
                {
                    max = A[j,i];
                    max_index = j;
                }
            }
            if (max < sum)
                A[max_index,i] = sum;
            else
                A[max_index, i] = max_index;
        }
        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here
        if (n <= 0)
        {
            return null;
        }
        int[,] answer = new int[n, 3 * n];
        for (int i = 0; i < 3 * n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == i % n)
                    answer[j, i] = 1;
                else
                    answer[j, i] = 0;
            }
        }
        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here
        int n = A.GetLength(0); 
        int m = A.GetLength(1);

        if (n != 6 || m != 6) 
        {
            return null;
        }
        int max = A[0,0];
        int max_index = 0;

        for (int i = 0; i < n; i++)
        {
            if (max < A[i, i])
            {
                max = A[i, i];
                max_index = i;
            }
        }
        for (int i = 0; i < max_index; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                A[i, j] = 0;
            }
        }

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here
        int n = B.GetLength(0);
        int m = B.GetLength(1);

        if (n != 6 || m != 6)
        {
            return null;
        }

        for (int i = 1; i < n; i += 2)
        {
            int max = B[i - 1,0]; 
            int mAx = B[i, 0];
            int index1 = 0; 
            int index2 = 0;

            for (int j = 0; j < m; j++)
            {
                if (max < B[i - 1,j])
                {
                    max = B[i - 1,j];
                    index1 = j;
                }
                if (mAx < B[i, j])
                {
                    mAx = B[i, j];
                    index2 = j;
                }
            }
            B[i - 1, index1] = mAx;
            B[i, index2] = max;
        }
        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 6 || b != 7)
        {
            return null;
        }

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < (b / 2); j++)
            {
                int p = A[i, j];
                A[i, j] = A[i, b - 1 - j];
                A[i, b - 1 - j] = p;
            }
        }

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here
        if (matrix.GetLength(0) != 7 || matrix.GetLength(1) != 5)
        {
            return null;
        }
            
        int[,] min_num = new int[matrix.GetLength(0), 2];
        int[,] A = new int[7, 5];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int min = 100000;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (min > matrix[i, j])
                {
                    min = matrix[i, j];
                    min_num[i, 1] = min;
                    min_num[i, 0] = i;
                }
            }
        }
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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m) 
        {
            return answer;
        }

        answer = new int[2 * n - 1];

        for (int i = 0; i < 2 * n - 1; i++)
        {
            answer[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[j - i + (n - 1)] = answer[j - i + (n - 1)] + matrix[i, j];
            }
        }

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        if (n != m || k < 1)
        {
            return null;
        }

        int max = int.MinValue;
        int l = 0;
        int st = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(matrix[i, j]) > max)
                {
                    max = Math.Abs(matrix[i, j]);
                    l = i;
                    st = j;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            int p = matrix[l, i];
            matrix[l, i] = matrix[k-1, i];
            matrix[k-1, i] = p;
        }

        for (int i = 0; i < n; i++)
        {
            int t = matrix[i, l];
            matrix[i, l] = matrix[i, k - 1];
            matrix[i, k - 1] = t;
        }

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
        if (A.Length != B.Length || A.Length != (n * n) / 2 + (n + 1) / 2 || n < 1) 
        {
            return answer;
        }
        answer = new int[n * n];
        int[,] matrix_A = new int[n, n];
        int[,] matrix_B = new int[n, n];

        Console.WriteLine("A");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int index = j >= i ? i * n + j - (i * i) / 2 - (i + 1) / 2 : j * n + i - (j * j) / 2 - (j + 1) / 2;

                matrix_A[i, j] = A[index];
                matrix_B[i, j] = B[index];

                Console.Write(A[index]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("B");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix_B[i, j]);
                Console.Write("   ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                answer[i * n + j] = sum;

                if (j == 0 && i != 0) Console.WriteLine();
                Console.Write(sum);
                Console.Write("   ");
            }
        }

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
        int l = matrix.GetLength(0);
        int c = matrix.GetLength(1);

        if (l != 5 || c != 7) 
        {
            return null;
        }

        int[,] d = new int[c, 2];

        for (int i = 0; i < c; i++)
        {
            int count = 0;
            for (int j = 0; j < l; j++)
            {
                if (matrix[j, i] < 0) countr++;
            }
            d[i, 0] = i;
            d[i, 1] = count;
        }

        for (int i = 0; i < c - 1; i++)
        {
            for (int j = 0; j < c - i - 1; j++)
            {
                if (d[j, 1] > d[j + 1, 1])
                {
                    int p1 = d[j, 0];
                    int p2 = d[j, 1];

                    d[j, 0] = d[j + 1, 0];
                    d[j, 1] = d[j + 1, 1];

                    d[j + 1, 0] = p1;
                    d[j + 1, 1] = p2;
                }
            }
        }

        int[,] newM = new int[l, c];

        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < l; j++)
            {
                newM[j, i] = matrix[j, d[i, 0]];
            }
        }

        matrix = newM;

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
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, 0] = 0;
                    k++;
                    break;
                }
            }
        }

        if (k == 0)
        {
            return matrix;
        }

        int[,] new_matrix = new int[n - k, m];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            if (matrix[i, 0] == 0)
            {
                continue;
            }
            for (int j = 0; j < m; j++)
            {
                new_matrix[count, j] = matrix[i, j];
            }
            count++;
        }

        return new_matrix;
        // end

        
    }
    #endregion
}
