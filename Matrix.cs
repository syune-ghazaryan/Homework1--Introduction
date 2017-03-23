using System;

namespace SomeProg
{
    public class Matrix
    {
        private int rows;
        private int columns;

        public int Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        
        private double[,] value;

        public Matrix (int r, int c,int ind)
        {
                this.rows = r;
                this.columns = c;
                this.value = new double[r, c];
                double[,]v = new double[r, c];
                if (ind == 0)
                    return;
                else
                {
                    for (int i = 0; i < r; i++)
                    {
                        for (int j = 0; j < c; j++)
                        {
                            v[i,j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < r; i++)
                    {
                        for (int j = 0; j < c; j++)
                        {
                            this.value[i, j] = v[i, j];
                        }
                    }
                }
        }
   
      

       
        public override string ToString()
        {
            string output="\n";
            
           // this.value = new double[this.rows, this.columns];
            for(int i=0;i<this.rows;i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    output += this.value[i, j].ToString()+" ";
                }
                output += "\n";
            }
            return output;
        }
   
        public Matrix Multiply( Matrix b)
        {
            
            int rcolumns = b.columns;
            int rrows = this.rows;
            Matrix result = new Matrix(rrows,rcolumns,0);
                for(int i = 0;i<this.rows; i++)
                {
                    for(int j=0;j<b.columns;j++)
                    {
                       
                        for(int k =0;k<this.columns;k++)
                        {
                            result.value[i,j]  += this.value[i,k] * b.value[k,j];
                        }
                    }
                }
            return result;

        }

    }
}
