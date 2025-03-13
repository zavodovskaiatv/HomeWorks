namespace Task5_09
//Матрицу A(m,n) (m и n – константы со значением на ваш выбор) заполнить натуральными числами от 1 до n*m по спирали, начинающейся в левом верхнем углу и закрученной по часовой стрелке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во солбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int value = 1; //начальное значение
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = m - 1;
            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    matrix[top, i] = value++;
                }
                top++;
                for (int i = top; i <= bottom; i++)
                { 
                    matrix[i, right] = value++; 
                }
                right--;
                if (top<=bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom, i]= value++;
                    }
                    bottom--;
                }
                if(left<=right)
                {
                    for(int i=bottom; i>=top; i--)
                    {
                        matrix[i, left]= value++;
                    }
                    left++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
