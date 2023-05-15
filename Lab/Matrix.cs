using System;

namespace Lab
{
    internal class Matrix
    {
        private int rows; //кол-во строк
        private int columns; //кол-во столбцов
        private int[,] array; //массив матрицы
        public Matrix() 
        {
            rows = 0;
            columns = 0;
            array = null;
        }
        public Matrix(int[,] array) 
        {  
            rows = array.GetLength(0);
            columns = array.GetLength(1);
            this.array = array; 
        }
        public int Rows
        {
            get { return rows; }
        }
        public int Columns
        { 
            get { return columns; } 
        }
        /*public int[,] Array
        { 
            get { return array; } set { array = value; }
        }*/
        public int this[int rows, int columns]
        {
            get { return array[rows, columns]; }
            set { array[rows, columns] = value; }
        }
        public int GetMinimum() //поиск минимума
        {
            int min = array[0, 0];
            foreach (int i in array)
            {
                min = Math.Min(min, i);
            }
            return min;
        }
        public int GetMaximum() //поиск максимума
        {
            int max = array[0, 0];
            foreach(int i in array)
            {
                max = Math.Max(max, i);
            }
            return max;
        }
        public override string ToString() //вывод массива
        {
            string num = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    num += array[i, j].ToString() + "  ";
                }
                num += "\n";
            }
            return num;
        }
        public static Matrix operator+(Matrix m1, Matrix m2) //сложение матриц
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new Exception("In order to add and subtract matrices, the first matrix and the second one must have the same size.");
            }
            int[,] sumArray = new int[m1.Rows, m1.Columns];
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Rows; j++)
                {
                    sumArray[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return new Matrix(sumArray);
        }
        public static Matrix operator-(Matrix m1, Matrix m2) //вычитание матриц
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                throw new Exception("In order to add and subtract matrices, the first matrix and the second one must have the same size.");
            }
            int[,] diffArray = new int[m1.Rows, m1.Columns];
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Rows; j++)
                {
                    diffArray[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return new Matrix(diffArray);
        }
        public static Matrix operator*(Matrix m, int scalar) //умножение матрицы на число (скаляр)
        {
            int[,] multByNumArray = new int[m.Rows, m.Columns];
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    multByNumArray[i, j] = m[i, j] * scalar;
                }
            }
            return new Matrix(multByNumArray);
        }
        public static Matrix operator*(Matrix m1, Matrix m2) //умножение матриц
        {
            if (m1.Columns != m2.Rows)
            {
                throw new Exception("In order to multiply two matrices, the number of columns of the first matrix must be equal to " +
                    "the number of rows of the second matrix.");
            }
            int[,] prodArray = new int[m1.Rows, m2.Columns];
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        prodArray[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return new Matrix(prodArray);
        }
        public static bool operator==(Matrix m1, Matrix m2) //сравнение матриц (если они равны)
        {
            if (ReferenceEquals(m1, m2))
            {
                return true;
            }
            if (m1 is null || m2 is null)
            {
                return false;
            }
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {
                return false;
            }
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    if (m1[i, j] != m2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator!=(Matrix m1, Matrix m2) //сравнение матриц (если они не равны)
        { 
            return !(m1 == m2); 
        }
        public override bool Equals(object obj)
        {
            if (obj is Matrix m)
            {
                return this == m;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + rows.GetHashCode();
                hash = hash * 23 + columns.GetHashCode();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        hash = hash * 23 + array[i, j].GetHashCode();
                    }
                }
                return hash;
            }
        }
    }
}
