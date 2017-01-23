using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rozrah_1
{
    public partial class Form1 : Form
    {
        public int n = 9;
        public double[,] A;
        public double[] b;
        double[] x;
        System.Media.SoundPlayer player;

        //SYSTEM
        double timeStart;
        double timeFinish;
        public Form1()
        {
            //init
            InitializeComponent();
            player = new System.Media.SoundPlayer();
            player.SoundLocation = "background.wav";
            player.Load();

            //fill matrix
            listBoxMatrix.Items.Add("Семестр 1 Матриця 1");//0
            listBoxMatrix.Items.Add("Семестр 1 Матриця 2");//1
            listBoxMatrix.Items.Add("Семестр 1 Матриця 3");//2
            //semestr2
            listBoxMatrix.Items.Add("Семестр 2 Матриця 1 (табл. 2)");//3
            listBoxMatrix.Items.Add("Семестр 2 Матриця 2 (табл. 3)");//4
            listBoxMatrix.Items.Add("test");//5
            listBoxMatrix.SelectedIndex = 3;

            //fill methods
            listBoxMethod.Items.Add("Класичний метод Гаусса");//0
            listBoxMethod.Items.Add("Метод відбиття (QR)");//1
            listBoxMethod.Items.Add("Метод Холецького");//2
            listBoxMethod.Items.Add("Метод прогонки");//3
            listBoxMethod.Items.Add("Обернена методом Гауса");//4
            //semestr2
            listBoxMethod.Items.Add("Степеневий метод (алгоритм 2)");//5
            listBoxMethod.Items.Add("Степеневий метод + delta2 процес Ейткена");//6
            listBoxMethod.Items.Add("Метод зворотних ітерацій (алгоритм 3)");//7
            listBoxMethod.Items.Add("Метод скалярних добутків (алгоритм 2)");//8
            listBoxMethod.Items.Add("Метод Якобі (алгоритм 0)");//9
            listBoxMethod.Items.Add("LU - метод (Одинична діагональ у матрці U )");//10
            listBoxMethod.Items.Add("QR -метод (алгоритм 0)");//11
            listBoxMethod.SelectedIndex = 5;
        }
        void output(string text)
        {
            if (checkBoxLog.Checked)
            {
                consoleTextBox.AppendText(text);
                if(checkBoxCarette.Checked && text.Contains('\n'))
                    consoleTextBox.ScrollToCaret();
                Application.DoEvents();
                //consoleTextBox.
            }
        }
        void timeBegin()
        {
            timeStart = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }
        void timeEnd()
        {
            timeFinish = DateTime.Now.TimeOfDay.TotalMilliseconds;
            labelTime.Text = "Час виконання операції: " + ((timeFinish - timeStart).ToString("n")) + " мс.";
        }
        //LISTENERS
        private void buttonClear_Click(object sender, EventArgs e)
        {
            consoleTextBox.Clear();
        }
        private void buttonGraph_Click(object sender, EventArgs e)
        {
            if (A == null)
            {
                MessageBox.Show("Але ж матриця не обрана!");
                return;
            }
            new graph(A, b).Show();
        }
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            listBoxMatrix.SelectedIndex = -1;
            new matrixAdd(this).Show();
        }
        private void buttonRandomizer_Click(object sender, EventArgs e)
        {
            new Randomizer().Show();
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Font f = consoleTextBox.Font;
            consoleTextBox.Font = new Font(f.FontFamily, f.Size + 1);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Font f = consoleTextBox.Font;
            consoleTextBox.Font = new Font(f.FontFamily, f.Size - 1);
        }
        private void listBoxMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxMatrix.SelectedIndex)
            {
                    //CEМЕСТР 1
                case 0:
                    n = 9;
                    A = new double[9, 9] {
                        {  26,   65,  -32,  -35,   91,   70,   27,  -96,   25 },
                        { -55,   88,  -11,   71,  -15,  -18,  -10,   29,  -46 },
                        { -69,   12,  -78,   52,  -93,  -77,  -95,    3,  -20 },
                        { -86,  -11,  -60,  -83,   -1,  -39,   54,   13,   41 },
                        { -61,  -22,   99,  -56,  -64,  -79,  -46,   53,  -58 },
                        {  41,  -46,  -18,   84,   69,   38,  -71,  -84,  -26 },
                        {  87,  -14,  -60,   40,   12,   13,  -58,  -18,  -50 },
                        {  93,  -91,   65,  -85,  -26,  -12,   91,    4,   58 },
                        {  33,  -34,  -75,  -72,  -66,   15,   84,   11,  -72 }
                    };
                    b = new double[9] { -69, 1, -45, -79, -97, -72, 87, 44, -15 };
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    showMatrix(b, "Обраний вектор b", true);
                    break;


                case 1:
                    n = 10;
                    A = new double[10, 10] {
                        { 188,  -32,   -9,    7,  -61,   49,  -53,   23,  -31,   62 },
                        { -32,  101,   11,  -32,  -80,    1,   53,   -7,   94, -109 },
                        {  -9,   11,  231,   96,  -62,  -12,   72,  -40,   72,  -77 },
                        {   7,  -32,   96,  174,  -37, -119,   19,    7,  -27,   27 },
                        { -61,  -80,  -62,  -37,  184,  -34, -115,   45,  -53,   46 },
                        {  49,    1,  -12, -119,  -34,  182,   80,  -56,   -4,   18 },
                        { -53,   53,   72,   19, -115,   80,  231, -101,   70,  -50 },
                        {  23,   -7,  -40,    7,   45,  -56, -101,  227,  -10,   23 },
                        { -31,   94,   72,  -27,  -53,   -4,   70,  -10,  241, -155 },
                        {  62, -109,  -77,   27,   46,   18,  -50,   23, -155,  212 }
                    };
                    b = new double[10] { -44, 74, 87, 247, -39, 168, 192, -199, -194, 243 };
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    showMatrix(b, "Обраний вектор b", true);
                    break;


                case 2:
                    n = 10;
                    A = new double[10, 10] {
                        { 390,  201,    0,    0,    0,    0,    0,    0,    0,    0},
                        {  21, -135,  -53,    0,    0,    0,    0,    0,    0,    0},
                        {   0, -271,  868, -203,    0,    0,    0,    0,    0,    0},
                        {   0,    0,   -7,  596,  160,    0,    0,    0,    0,    0},
                        {   0,    0,    0,  -47, -208,  -96,    0,    0,    0,    0},
                        {   0,    0,    0,    0,  -24,  347,  -17,    0,    0,    0},
                        {   0,    0,    0,    0,    0,  -96,  220,  -40,    0,    0},
                        {   0,    0,    0,    0,    0,    0,  107,  546, -204,    0},
                        {   0,    0,    0,    0,    0,    0,    0, -301, -740, -364},
                        {   0,    0,    0,    0,    0,    0,    0,    0,   48, -154},
                    };
                    b = new double[10] { 446, 62, -783, 264, -747, -732, -803, -716, -664, -608 };
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    showMatrix(b, "Обраний вектор b", true);
                    break;

                //СЕМЕСТР 2
                case 3: //(table2)
                    n = 5;
                    A = new double[5, 5] {
                        {   318,    10,   -55,   122,   -37}, 
                        {   228,   975,   315,   124,   389}, 
                        {   274,   489,  -106,  -462,   476}, 
                        {  -431,   278,   609,   554,  -117}, 
                        {  -619,   971,   194,  -599,   663},
                    };
                    b = createVector(n, 1);//new double[5] { 0,0,0,0,0 };
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    break;


                case 4://(table3)
                    n = 5;
                    A = new double[5, 5] {
                        {   996,  -168,  -334,  -436,   297 },
                        {  -168,   790,    35,  -401,   -53 },
                        {  -334,    35,   993,   337,   219 },
                        {  -436,  -401,   337,   723,    -6 },
                        {   297,   -53,   219,    -6,   793 },
                    };
                    b = new double[5] { 0, 0, 0, 0, 0 };
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    break;


                case 5://(test)
                    n = 3;
                    A = new double[3, 3] {
                        {   1,      0,      0, },
                        {   0,      2,      1, },
                        {   1,      0,      1, },
                    };
                    b = new double[3] { 0, 0, 0};
                    x = new double[n];
                    showMatrix(A, "Обрана матриця A");
                    break;
            }
        }
        private void buttonDo_Click(object sender, EventArgs e)
        {
            //("Класичний метод Гаусса");//0
            //("Метод відбиття (QR)");//1
            //("Метод Холецького");//2
            //("Метод прогонки");//3
            //("Обернена методом Гауса");//4

            //("Степеневий метод (алгоритм 2)");//5
            //("Степеневий метод + delta2 процес Ейткена");//6
            //("Метод зворотних ітерацій (алгоритм 3)");//7
            //("Метод скалярних добутків (алгоритм 2)");//8
            //("Метод Якобі (алгоритм 0)");//9
            //("LU - метод (Одинична діагональ у матрці U )");//10
            //("QR -метод (алгоритм 0)");//11
            timeBegin();
            switch (listBoxMethod.SelectedIndex)
            {
                case 0://("Класичний метод Гаусса")
                    x = gaussian(A, b);
                    break;
                case 1://("Метод відбиття (QR)"
                    x = reflectionsQR(A, b);
                    break;
                case 2://("Метод Холецького")
                    x = holecky(A, b);
                    break;
                case 3://("Метод прогонки")
                    x = sweep(A, b);
                    break;
                case 4: //("Обернена методом Гауса")
                    if (checkBoxMusic.Checked)
                        player.PlayLooping();
                    inverce(A);
                    player.Stop();
                    break;
                case 5://("Степеневий метод (алгоритм 2)");//5
                    powerMethod(A);
                    break;
                case 6://("Степеневий метод + delta2 процес Ейткена");//6
                    powerEitkinMethod(A);
                    break;
                case 7://("Метод зворотних ітерацій (алгоритм 3)");//7
                    inverseIterationMethod(A);
                    break;
                case 8: //("Метод скалярних добутків (алгоритм 2)");//8
                    scalarMultiplMethod(A);
                    break;
                case 9://("Метод Якобі (алгоритм 0)");//9
                    jacobiMethod(A);
                    break;
                case 10://("LU - метод (Одинична діагональ у матрці U )");//10
                    methodLU(A);
                    break;
                case 11://("QR -метод (алгоритм 0)");//11
                    methodQR(A);
                    break;
            }
            timeEnd();
        }

        //MATRIX FUNCTIONS
        public double[,] createMatrix(int widht, int height, double value)
        {
            double[,] result = new double[height, widht];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < widht; j++)
                {
                    result[i, j] = value;
                }
            }
            return result;
        }
        public double[] createVector(int size, double value)
        {
            double[] result = new double[size];
            for (int i = 0; i < size; i++)
            {
                    result[i] = value;
            }
            return result;
        }
        public double[,] multiply(double[,] a, double[,] b)
        {
            double[,] result = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                double[] row = getRow(a, i);
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = multiply(row, getColumn(b, j));
                }
            }
            return result;
        }
        public double[] multiply(double[,] a, double[] b)
        {
            double[] result = new double[a.GetLength(0)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                result[i] = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    result[i] += a[i, j] * b[j];
                }
            }
            return result;
        }
        public double[] multiply(double[] arr, double a)
        {
            double[] res = new double[arr.Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = arr[i] * a;
            }
            return res;
        }
        public double[,] multiply(double[,] arr, double a)
        {
            double[,] res = new double[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = arr[i, j] * a;
                }
            }
            return res;
        }
        public double multiply(double[] a, double[] b)
        {
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += a[i] * b[i];
            }
            return result;
        }
        public double[,] multiplyInv(double[] a, double[] b)
        {
            double[,] result = new double[a.Length, b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                setRow(result, multiply(b, a[i]), i);
            }
            return result;
        }
        public double[] vectorProjection(double[] a, double[] b)
        {
            double k = multiply(a, b) / multiply(b, b);
            return multiply(b, k);
        }
        public double[,] add(double[,] a, double[,] b)
        {
            double[,] res = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res[i, j] = a[i, j] + b[i, j];
                }
            }
            return res;
        }
        public double[] add(double[] a, double[] b)
        {
            double[] res = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i] + b[i];
            }
            return res;
        }
        public double[] substract(double[] a, double[] b)
        {
            double[] res = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i] - b[i];
            }
            return res;
        }
        public void showMatrix(double[,] a, string name)//показати матрицю
        {
            output("\n");
            output(name + "[" + a.GetLength(0) + ", " + a.GetLength(1) + "] :\n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    output(String.Format("{0,10} ", Math.Round(a[i, j], 4)));
                }
                output("\n");
            }
        }
        public void showMatrix(double[] a, string name, bool vertical = false)//показати вектор
        {
            output("\n");
            output(name + "[" + a.GetLength(0) + "] :\n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                output(String.Format("{0,10} ", Math.Round(a[i], 4)));
                if (vertical)
                    output("\n");
            }
            output("\n");
        }
        public void matrixCopy(double[,] dest, double[,] src)//копіювати матрицю
        {
            for (int i = 0; i < src.GetLength(0); i++)
            {
                for (int j = 0; j < src.GetLength(1); j++)
                {
                    dest[i, j] = src[i, j];
                }
            }
        }
        public double[,] setRow(double[,] a, double[] b, int k)//задати рядок
        {
            for (int i = 0; i < b.Length; i++)
            {
                a[k, i] = b[i];
            }
            return a;
        }
        public double[,] setColumn(double[,] a, double[] b, int k)//задати стовпець
        {
            for (int i = 0; i < b.Length; i++)
            {
                a[i, k] = b[i];
            }
            return a;
        }
        public double[] getRow(double[,] a, int k)//отримати рядок
        {
            double[] result = new double[a.GetLength(1)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a[k, i];
            }
            return result;
        }
        public double[] getColumn(double[,] a, int k)//отримати стовпець
        {
            double[] result = new double[a.GetLength(0)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a[i, k];
            }
            return result;
        }
        public double[] getDiagonal(double[,] a)//отриматидіагональ
        {
            int size = Math.Min( a.GetLength(0), a.GetLength(1));
            double[] x = new double[size];
            for (int i = 0; i < size; i++)
                x[i] = a[i, i];
            return x;
        }
        public double[,] transponate(double[,] a)//транспонувати матрицю
        {
            double[,] res = new double[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res[j, i] = a[i, j];
                }
            }
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    setColumn(res, getRow(a, i), i);
            //}
            return res;
        }
        public double norm(double[] x)//норма вектора
        {
            double res = 0;
            foreach (double xi in x)
                res += xi * xi;
            return Math.Sqrt(res);
        }
        public double[] normalize(double[] x)//нормувати вектор
        {
            return multiply(x, 1 / norm(x));
        }
        public double norm(double[,] in_A)//норма матрицы
        {
            double res = 0;
            for (int i = 0; i < in_A.GetLength(0); i++)
                for (int j = 0; j < in_A.GetLength(1); j++)
                    res += in_A[i, j] * in_A[i, j];
            return Math.Sqrt(res);
        }
        public double[,] getH(double[] x, int k)//отримати матрицю Хаусхолдера
        {
            for (int i = 0; i < k; i++)//nullUp
                x[i] = 0;
            double beta = -Math.Sign(x[k]) * norm(x);
            double mu = 1 / Math.Sqrt(2 * beta * beta - 2 * beta * x[k]);
            double[] wx = new double[x.Length];
            x.CopyTo(wx, 0);
            wx[k] -= beta;
            double[] w = multiply(wx, mu);//некий векотр умницить на МЮ
            //МЮ - удиница на корень с большой фигней
            //БЕТА - 
            return add(getI(x.Length), multiply(multiplyInv(w, w), -2));
        }
        public double[,] getI(int n)//отримати одиничну матрицю
        {
            double[,] res = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                res[i, i] = 1;
            }
            return res;
        }
        public double[,] getWide(double[,] a, double[] b)//приэднати вектор до матрицф
        {
            double[,] Aw = new double[a.GetLength(0), a.GetLength(1) + 1];
            matrixCopy(Aw, a);
            setColumn(Aw, b, a.GetLength(1));
            return Aw;
        }
        static double[,] copy(double[,] matrix)
        {
            // allocates/creates a duplicate of a matrix. assumes matrix is not null.
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); ++i) // copy the values
                for (int j = 0; j < matrix.GetLength(1); ++j)
                    result[i,j] = matrix[i,j];
            return result;
        }
        public void getLU(double[,] in_A, out double[,] L, out double[,] U)//виконати LU розкладання
        {
            int size = in_A.GetLength(0);
            L = new double[size, size];
            U = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    L[i, j] = 0;
                    U[i, j] = 0;
                    if (i == j)
                    {
                        U[i, j] = 1;
                    }
                }
            }
            int length = size;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        double sum = 0;
                        if (i >= k)
                        {
                            L[i, k] = in_A[i, k];
                            for (int m = 0; m < k; m++)
                            {
                                sum += L[i, m] * U[m, k];
                            }
                            L[i, k] -= sum;
                        }
                        if (j >= k)
                        {
                            sum = 0;
                            for (int m = 0; m < k; m++)
                            {
                                sum += L[k, m] * U[m, j];
                            }
                            U[k, j] = (in_A[k, j] - sum) / L[k, k];
                        }
                    }
                }
            }
        }
        public void getQR(double[,] in_A, out double[,] Q, out double[,] R)//виконати QR розкдадання
        {
            int n = in_A.GetLength(0);
            List<double[]> av = new List<double[]>();
            for (int i = 0; i < n; i++)
                av.Add(getColumn(in_A, i));

            List<double[]> u = new List<double[]>();
            u.Add(av[0]);
            List<double[]> e = new List<double[]>();
            e.Add(multiply(u[0], 1 / norm(u[0])));

            for (int i = 1; i < in_A.GetLength(0); i++)
            {

                double[] projAcc = new double[n];
                for (int j = 0; j < projAcc.Length; j++)
                {
                    projAcc[j] = 0;
                }
                for (int j = 0; j < i; j++)
                {
                    double[] proj = vectorProjection(av[i], e[j]);
                    for (int k = 0; k < projAcc.GetLength(0); k++)
                    {
                        projAcc[k] += proj[k];
                    }
                }

                double[] ui = new double[n];
                for (int j = 0; j < ui.Length; j++)
                {
                    ui[j] = in_A[j,i] - projAcc[j];
                }

                u.Add(ui);

                e.Add(multiply( u[i], 1 / norm(u[i])));
            }


            double[,] q = new double[n,n];
            for (int i = 0; i < q.GetLength(0); i++)
            {
                for (int j = 0; j < q.GetLength(1); j++)
                {
                    q[i,j] = e[j][i];
                }
            }


            double[,] r = new double[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                    {
                        r[i,j] = multiply(e[j], av[i]);
                    }
                    else
                    {
                        r[i,j] = 0;
                    }
                }
            }

            r = transponate(r);

            Q = q;
            R = r;
            return;
        }
        public double[] findEigenVectorByEigenNumber(double[,] in_A, double lambda)
        {
            double[,] AmL = copy(in_A);
            double[,] minusLambdaDiagonal = multiply(getI(in_A.GetLength(0)), (-lambda));
            AmL = add(AmL, minusLambdaDiagonal);
            double[] alpha = gaussian(AmL, createVector(in_A.GetLength(1), 1));
            return alpha;
        }
        public double[,] EigenVector(double [,] in_A, double _eigenValue)
        {
            double epsilon = 0.0001;
            int k = 1;
            double[,] A = copy(in_A);
            double lambdaCurrent;
            double lambdaPrevious = 0;
            double u = _eigenValue;
            double[,] y = new double[A.GetLength(0), 1];
            for (int i = 0; i < y.GetLength(0); i++)
            {
                y[i, 0] = 1;
            }
            // set z
            double[,] z = multiply( y, 1 / norm(y));

            while (true)
            {
                double[,] minusLambdaDiagonal = multiply(getI(in_A.GetLength(0)), (-u));
                double[,] B = add(A , minusLambdaDiagonal);
                for(int i=0; i<y.GetLength(0); i++)
                    setColumn(y, gaussian(B, getColumn(z, i)), i);
                //y = gaussian(B, z);

                lambdaCurrent = 0;
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    double[,] _1nY = copy(y);
                    for (int j = 0; j < _1nY.Length; j++)
                        _1nY[0,j] = 1 / _1nY[0,j];
                    lambdaCurrent += multiply(z, _1nY)[i, 0];
                }
                lambdaCurrent /= B.GetLength(0);
                lambdaCurrent += u;

                z = multiply(y, 1 / norm(y));

                if (Math.Abs(lambdaCurrent - lambdaPrevious) <= epsilon)
                    break;
                lambdaPrevious = lambdaCurrent;
                k++;
            }

            return z;
        }
        public void scalarMultiplMethodFirst(double[,] in_A, out double[] eigenVector, out double eigenValue)//("Метод скалярних добутків для пошуку першої власної пари");//
        {
            output("Пошук ПЕРШОЇ власної пари методом скалярних добутків...\n");
            //init
            int size = in_A.GetLength(0);
            List<double[]> y = new List<double[]>();
            List<double[]> z = new List<double[]>();
            List<double> lambda = new List<double>();
            double epsilon = 0.001;
            y.Add(createVector(size, 1));
            lambda.Add(0);
            z.Add(normalize(y[0]));
            int k = 1;
            //out
            output("Ініціалізація...\n");
            output("lambda[0] = " + lambda[0] + "\n");
            output("epsilon = " + epsilon + "\n");
            showMatrix(y[0], "y[0]", true);
            showMatrix(z[0], "z[0]", true);
            while (k < 100)
            {
                output("Ітерація " + k + "\n");
                //calc
                y.Add(multiply(in_A, z[k - 1]));
                lambda.Add(multiply(y[k], z[k - 1]) / multiply(z[k - 1], z[k - 1]));
                z.Add(normalize(y[k]));
                //out
                output("lambda[" + k + "] = " + lambda[k] + "\n");
                showMatrix(y[k], "y[" + k + "]", true);
                showMatrix(z[k], "z[" + k + "]", true);


                //Прийом Гарвіка
                if (checkBoxAll.Checked && k > 2 && (lambda[k] - lambda[k - 1]) > (lambda[k - 1] - lambda[k - 2]))
                    output("Критерій Гарвіка не виконується!\n");

                //stop
                if (Math.Abs(lambda[k] - lambda[k - 1]) < epsilon)
                {
                    output(" КРИТЕРІЙ ЗУПИНКИ ВИКОНАНО! k = " + k + "\n");
                    output("-----------------------------------------------------\n");
                    output("lambda = " + lambda[k] + "\n");
                    showMatrix(z[k], "x", true);
                    //return
                    eigenValue = lambda[k];
                    eigenVector = z[k];
                    return;
                }
                k++;
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            //return
            eigenValue = 0;
            eigenVector = createVector(n, 0);
        }
        public void scalarMultiplMethodNext(double[,] in_A, out double[] eigenVector, out double eigenValue)//("Метод скалярних добутків для пошуку першої власної пари");//
        {
            output("Пошук ПЕРШОЇ власної пари методом скалярних добутків...\n");
            //init
            int size = in_A.GetLength(0);
            List<double[]> y = new List<double[]>();
            List<double[]> z = new List<double[]>();
            List<double> lambda = new List<double>();
            double epsilon = 0.001;
            y.Add(createVector(size, 1));
            lambda.Add(0);
            z.Add(normalize(y[0]));
            int k = 1;
            //out
            output("Ініціалізація...\n");
            output("lambda[0] = " + lambda[0] + "\n");
            output("epsilon = " + epsilon + "\n");
            showMatrix(y[0], "y[0]", true);
            showMatrix(z[0], "z[0]", true);
            while (k < 100)
            {
                output("Ітерація " + k + "\n");
                //calc
                y.Add(multiply(in_A, z[k - 1]));
                lambda.Add(multiply(y[k], z[k - 1]) / multiply(z[k - 1], z[k - 1]));
                z.Add(normalize(y[k]));
                //out
                output("lambda[" + k + "] = " + lambda[k] + "\n");
                showMatrix(y[k], "y[" + k + "]", true);
                showMatrix(z[k], "z[" + k + "]", true);


                //Прийом Гарвіка
                if (checkBoxAll.Checked && k > 2 && (lambda[k] - lambda[k - 1]) > (lambda[k - 1] - lambda[k - 2]))
                    output("Критерій Гарвіка не виконується!\n");

                //stop
                if (Math.Abs(lambda[k] - lambda[k - 1]) < epsilon)
                {
                    output(" КРИТЕРІЙ ЗУПИНКИ ВИКОНАНО! k = " + k + "\n");
                    output("-----------------------------------------------------\n");
                    output("lambda = " + lambda[k] + "\n");
                    showMatrix(z[k], "x", true);
                    //return
                    eigenValue = lambda[k];
                    eigenVector = z[k];
                    return;
                }
                k++;
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            //return
            eigenValue = 0;
            eigenVector = createVector(n, 0);
        }

        //METHODS
        public double[] gaussian(double[,] in_A, double[] in_b)//метод Гауса
        {
            output("-----Метод Гаусса\n");
            output("Підготовка матриці...\n");
            double[,] A0 = new double[n, n + 1];
            double[,] A1 = new double[n, n + 1];
            double det = 1;
            A0 = getWide(in_A, in_b);
            if(checkBoxAll.Checked)
                showMatrix(A0, "Підготовлена матриця");

            output("Прямий хід методу Гауса...\n");
            output("Приведення до трикутного вигляду...\n");
            for (int k = 0; k < n; k++)
            {
                for (int j = k; j <= n; j++)
                {
                    A1[k, j] = A0[k, j] / A0[k, k];
                    for (int i = k + 1; i < n; i++)
                    {
                        A1[i, j] = A0[i, j] - A1[k, j] * A0[i, k];
                    }
                }
                det *= A0[k, k];
                if (checkBoxAll.Checked)
                    showMatrix(A1, "(" + k.ToString() + ") матриця A");
                matrixCopy(A0, A1);
            }

            double[] out_x = gaussianBack(A1);
            output("det(A) = " + det.ToString() + ";");
            showMatrix(out_x, "матриця X", true);
            return out_x;
        }
        public double[] gaussianBack(double[,] in_A)//зворотній хід методу Гауса
        {
            output("Зворотній хід методу Гауса...\n");
            output("Розрахунок коренів...\n");
            double[] out_x = new double[in_A.GetLength(0)];
            for (int i = in_A.GetLength(0) - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < in_A.GetLength(0); j++)
                {
                    sum += in_A[i, j] * out_x[j];
                }
                out_x[i] = (in_A[i, n] - sum) / in_A[i, i];
            }
            showMatrix(out_x, "out_x");
            return out_x;
        }
        public double[] gaussianBackInv(double[,] in_A)//зворотній хід методу Гауса який можна примінити для лівої трикутної матриці
        {
            output("Модифікація зворотнього ходу методу Гауса...\n");
            output("Розрахунок коренів...\n");
            double[] out_x = new double[in_A.GetLength(0)];
            for (int i = 0; i < in_A.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += in_A[i, j] * out_x[j];
                }
                out_x[i] = (in_A[i, n] - sum) / in_A[i, i];
            }
            showMatrix(out_x, "out_x");
            return out_x;
        }
        public double[,] inverce(double[,] in_A)//пошук оберненої матриці
        {
            output("Пошук оберненої матриці...\n");
            double[,] out_x = new double[n,n];
            for (int i = 0; i < in_A.GetLength(1); i++)
            {
                output("Пошук стовпчика "+i.ToString()+"...\n");
                double[] tmp_b = new double[n];
                for (int j = 0; j < n; j++)
                    tmp_b[j] = 0;
                tmp_b[i] = 1;
                double[] col = gaussian(A, tmp_b);
                setColumn(out_x, col, i);
            }
            showMatrix(out_x, "матриця обернена А");
            return out_x;
        }
        public double[] reflectionsQR(double[,] in_A, double[] in_b)//метод відбиття
        {
            output("Метод обертань...");
            double[,] C = getWide(in_A, in_b);
            double[,] R = new double[in_A.GetLength(0), in_A.GetLength(1)];//A
            matrixCopy(R, in_A);
            double[,] Qt = getI(n);
            for (int i = 0; i < n; i++)
            {
                double[,] H = getH(getColumn(C, i), i);
                R = multiply(H, R);
                //Qt - Q transponovana    Q = H1 * H2 * ... * Hn
                Qt = multiply(H, Qt);
                C = multiply(H, C);
                if (checkBoxAll.Checked)//виведення промідних результатів
                {
                    showMatrix(H, String.Format("H ({0})", i));
                    showMatrix(R, String.Format("R ({0})", i));
                    showMatrix(Qt, String.Format("Qt ({0})", i));
                    showMatrix(C, String.Format("C ({0})", i));
                }
            }

            //find INV and DET
            double[,] Rinv = getI(n);
            double det = 1;
            for (int i = 0; i < n; i++)
            {
                if (checkBoxAll.Checked)//виведення промідних результатів
                    output(String.Format("det({1}) = {0}\n", det, i));
                det *= R[i, i];//det A = r11 * r22 * ... * Rnn
                setColumn(Rinv, gaussianBack(getWide(R, getColumn(Rinv, i))), i);
                if (checkBoxAll.Checked)//виведення промідних результатів
                    showMatrix(Rinv, String.Format("Rinv({0})", i));
            }
            output(String.Format("\n\ndet(А) = {0}\n", det));
            double[,] Ainv = multiply(Rinv, Qt);
            showMatrix(Ainv, "inv(A)");


            //find ROOTS
            showMatrix(Qt, "Q");
            showMatrix(R, "R");
            double[] result = gaussianBack(C);
            showMatrix(result, "Result X", true);
            return result;
        }
        public double[] holecky(double[,] in_A, double[] in_b)//Метод Холецького (квадратних коенів)
        {
            int len = in_b.Length;
            double[,] A1 = new double[len, len];
            double[] b1 = new double[len];
            double[] y = new double[len];
            double[,] U = new double[len, len];
            double[] x = new double[len];
            double detA = 1;

            output("Копіювання матриць А та b, та ініціалізація матриці U...\n");
            for (int i = 0; i < len; i++)
            {
                b1[i] = in_b[i];
                for (int j = 0; j < len; j++)
                {
                    A1[i,j] = in_A[i,j];
                    U[i,j] = 0;
                }
            }
            showMatrix(A1, "Початкова матриця");

            output("Отримання правої трикутної матриці U...\n");
            for (int i = 0; i < len; i++)
            {
                double sum = 0;                     //first formula
                for (int k = 0; k < i; k++)
                {
                    sum += Math.Pow(U[k, i], 2);
                }
                U[i, i] = Math.Sqrt(A1[i, i] - sum);


                for (int j = i + 1; j < len; j++)   //second formula
                {
                    sum = 0;
                    for (int k = 0; k < i; k++)
                    {
                        sum += U[k, i] * U[k, j];
                    }
                    U[i, j] = (A1[i, j] - sum) / U[i, i];
                }
                if (checkBoxAll.Checked)//виведення промідних результатів
                    showMatrix(U, "U ("+i+")");
            }
            showMatrix(U, "Права трикутна матриця");

            if (checkBoxLog.Checked)
            {
                output("Обернена матриця...\n");
                bool real = checkBoxLog.Checked;
                checkBoxLog.Checked = false;
                double[,] inv = inverce(A);
                checkBoxLog.Checked = real;
                showMatrix(inv, "inv(A)");
            }

            output("Отримання вектора у...\n");
            y = gaussianBackInv(getWide(transponate(U), in_b));
            showMatrix(y, "Вектор у");

            output("Отримання вектора x...\n");
            x = gaussianBack(getWide(U, y));
            showMatrix(x, "Вектор x", true);

            output("Пошук детермінанти...\n");
            output("То є добуток діагональних елементів\n");
            for (int i = 0; i < len; i++)
            {
                detA *= Math.Pow(U[i, i], 2);
            }
            output("det(A) = " + detA + ";");
            return x;
        }
        public double[] sweep(double[,] in_A, double[] in_b)//Метод прогонки
        {
            output("Ініціалізація прогонки...\n");
            double[] result = new double[n];
            double[] delta = new double[n];
            double[] lambda = new double[n];
            if (checkBoxAll.Checked)//виведення промідних результатів
            {
                showMatrix(in_A, "Матриця A");
                showMatrix(in_b, "Векотр b");
            }

            output("Виконання прямої прогонки...\n");
            delta[0] = -in_A[0, 1] / in_A[0, 0];//так як цикл починається з 1, то 0 елемент порахуємо вручну
            lambda[0] = in_b[0] / in_A[0, 0];
            double det = in_A[0, 0];
            for (int i = 1; i < n - 1; i++)
            {
                double denominator = in_A[i, i] + in_A[i, i - 1] * delta[i - 1];//знаменник
                delta[i] = -in_A[i, i + 1] / denominator;
                lambda[i] = (in_b[i] - in_A[i, i - 1] * lambda[i - 1]) / denominator;

                if (checkBoxAll.Checked)//виведення промідних результатів
                {
                    output(String.Format("\nlambda({1}) = {0}\n", lambda[i], i));
                    output(String.Format("\ndelta({1}) = {0}\n", delta[i], i));
                    output(String.Format("\ndet({1}) = {0}\n", det, i));
                }
                det *= denominator;
            }
            det *= in_A[n - 1, n - 1] + in_A[n - 1, n - 2] * delta[n - 2];//кусочок, який не враховано в циклі
            output(String.Format("\ndet(A) = {0}\n\n", det));
            showMatrix(lambda, "lambda", true);
            showMatrix(delta, "delta", true);

            output("Виконання зворотньої прогонки...\n");
            //так як цикл до цього місля не доходив, по тут буде формула, яка включає обрахування лямбди і дельти
            result[n - 1] = (in_b[n - 1] - in_A[n - 1, n - 2] * lambda[n - 2]) / (in_A[n - 1, n - 1] + in_A[n - 1, n - 2] * delta[n - 2]);
            for (int i = n - 2; i >= 0; i--)
            {
                result[i] = delta[i] * result[i + 1] + lambda[i];
                if (checkBoxAll.Checked)//виведення промідних результатів
                    output(String.Format("x({1}) = {0}\n", result[i], i));
            }
            output("\n");
            showMatrix(result, "x", true);

            return result;
        }
        //semestr2
        public double[] powerMethod(double[,] in_A)//("Степеневий метод (алгоритм 2)");//5
        {
            double delta = 0.01; //критерий остановки
            double epsilon = 0.01; //критерий остановки

            //Візьмемо довільний вектор такий, що  y(0)  0 (1,1,...,1,1)
            List<double[]> y = new List<double[]>();
            List<double[]> lambda = new List<double[]>();
            y.Add(new double[n]);
            for(int i=0; i<n; i++)
                y[0][i]=1;
            lambda.Add(y[0]);
            showMatrix(y[0], "Y0", true);

            //Тоді, у відповідності до алгоритму №1, нам потрібно пронормувати вектор   y(0) : 
            List<double[]> z = new List<double[]>();
            z.Add(multiply(y[0], 1/norm(y[0])));
            showMatrix(z[0], "Z0", true);

            //Вважатимемо, що  p  3 та на кожній ітерації, кратній   p , проводитимемо нормування.
            int p = 3;
            int k = 1;
            double[,] B = multiply(in_A, in_A);
            showMatrix(B, "B");

            //Провівши ініціалізацію, можемо перейти до ітераційного процесу: 
            while (k<100)
            {
                if (checkBoxAll.Checked)
                    output("Ітерація "+k+"\n");
                //Знайдемо вектор  (k)y B (k-1)
                y.Add(multiply(B, z[k - 1]));
                if(checkBoxAll.Checked)
                    showMatrix(y[k], "y[" + k + "]", true);

                //Обчислимо наближення до старшого власного числа: 
                double[] tmp = new double[n];
                for (int i = 0; i < n; i++)
                    tmp[i] = y[k][i] / z[k - 1][i];
                lambda.Add(tmp);
                if (checkBoxAll.Checked)
                    showMatrix(lambda[k], "lambda[" + k + "]", true);

                //Перевіримо  виконання  рівності  mkod p0:1mod3 0.  Отже, нормування виконувати не потрібно та  (1)z (1)y
                if (k % p == 0)
                {
                    z.Add(multiply(y[k], 1 / norm(y[k])));
                    if (checkBoxAll.Checked)
                        output("Нормування.\n");
                }
                else
                    z.Add(y[k]);
                if (checkBoxAll.Checked)
                    showMatrix(z[k], "z[" + k + "]", true);


                //Прийом Гарвіка
                if (checkBoxAll.Checked && k > 2 && norm(substract(lambda[k], lambda[k - 1])) > norm(substract(lambda[k - 1], lambda[k - 2])))
                    output("Критерій Гарвіка не виконується!\n");

                //Можна використовувати один з двох критеріїв зупинки
                if (norm(substract(lambda[k], lambda[k - 1])) < epsilon)
                {
                    output(" КРИТЕРІЙ ЗУПИНКИ ВИКОНАНО! k = "+k+"\n");
                    //y
                    double[] fy = multiply(in_A, z[k]);
                    showMatrix(fy, "fy", true);
                    //lambda
                    double[] flambda = new double[n];                        
                    for (int i = 0; i < n; i++)
                        flambda[i] = fy[i] / z[k][i];
                    showMatrix(flambda, "flambda", true);
                    //lambda1
                    double sum = 0;
                    int count = 0;
                    for (int i = 0; i < n; i++)//S
                        if (z[k - 1][i] > delta)
                        {
                            sum += flambda[i];
                            count++;
                        }
                    double lambda1 = sum / count;
                    output("-----------------------------------------------------\n");
                    output("lambda1=" + lambda1 + "\n");
                    //x
                    double[] x = (multiply(fy, 1 / norm(fy)));
                    showMatrix(x, "x", true);
                    //return
                    return x;
                }


                k++;
                //Щоб не зависало
                Application.DoEvents();
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            return createVector(n, 1);
        }
        public double[] powerEitkinMethod(double[,] in_A)//("Степеневий метод + delta2 процес Ейткена");//6
        {
            double delta = 0.01; //критерий остановки
            double epsilon = 0.01; //критерий остановки

            //Візьмемо довільний вектор такий, що  y(0)  0 (1,1,...,1,1)
            List<double[]> y = new List<double[]>();
            List<double[]> lambda = new List<double[]>();
            y.Add(new double[n]);
            for (int i = 0; i < n; i++)
                y[0][i] = 1;
            lambda.Add(y[0]);
            showMatrix(y[0], "Y0", true);

            //Тоді, у відповідності до алгоритму №1, нам потрібно пронормувати вектор   y(0) : 
            List<double[]> z = new List<double[]>();
            z.Add(multiply(y[0], 1 / norm(y[0])));
            showMatrix(z[0], "Z0", true);

            //Вважатимемо, що  p  3 та на кожній ітерації, кратній   p , проводитимемо нормування.
            int p = 3;
            int k = 1;
            double[,] B = multiply(in_A, in_A);
            showMatrix(B, "B");

            //Провівши ініціалізацію, можемо перейти до ітераційного процесу: 
            while (k < 100)
            {
                if (checkBoxAll.Checked)
                    output("Ітерація " + k + "\n");
                //Знайдемо вектор  (k)y B (k-1)
                y.Add(multiply(B, z[k - 1]));
                if (checkBoxAll.Checked)
                    showMatrix(y[k], "y[" + k + "]", true);

                //Обчислимо наближення до старшого власного числа: 
                double[] tmp = new double[n];
                for (int i = 0; i < n; i++)
                    tmp[i] = y[k][i] / z[k - 1][i];
                lambda.Add(tmp);
                if (checkBoxAll.Checked)
                    showMatrix(lambda[k], "lambda[" + k + "]", true);

                //Перевіримо  виконання  рівності  mkod p0:1mod3 0.  Отже, нормування виконувати не потрібно та  (1)z (1)y
                if (k % p == 0)
                {
                    z.Add(multiply(y[k], 1 / norm(y[k])));
                    if (checkBoxAll.Checked)
                        output("Нормування.\n");
                }
                else
                    z.Add(y[k]);
                if (checkBoxAll.Checked)
                    showMatrix(z[k], "z[" + k + "]", true);

                //покоординатне уточнення
                if (k % p == 0)
                {
                    double sum = 0;
                    int count = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (z[k][i] > delta)
                        {
                            count++;
                            double lambdatilda = (lambda[k - 2][i] - (
                                    Math.Pow(lambda[k - 1][i] - lambda[k - 2][i], 2) /
                                    (lambda[k][i] - (2 * lambda[k - 1][i]) + lambda[k - 2][i])));
                            sum += lambdatilda;

                        }
                    }
                    output("Результат уточнення: lambda="+(sum/count)+"\n");
                }


                //Прийом Гарвіка
                if (checkBoxAll.Checked && k > 2 && norm(substract(lambda[k], lambda[k - 1])) > norm(substract(lambda[k - 1], lambda[k - 2])))
                    output("Критерій Гарвіка не виконується!\n");

                //Можна використовувати один з двох критеріїв зупинки
                if (norm(substract(lambda[k], lambda[k - 1])) < epsilon)
                {
                    output(" КРИТЕРІЙ ЗУПИНКИ ВИКОНАНО! k = " + k + "\n");
                    //покоординатне уточнення
                    double sum1 = 0;
                    int count1 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (z[k][i] > delta)
                        {
                            count1++;
                            double lambdatilda = (lambda[k - 2][i] - (
                                    Math.Pow(lambda[k - 1][i] - lambda[k - 2][i], 2) /
                                    (lambda[k][i] - (2 * lambda[k - 1][i]) + lambda[k - 2][i])));
                            sum1 += lambdatilda;
                        }
                    }
                    output("Результат уточнення: lambda=" + (sum1 / count1) + "\n");
                    //y
                    double[] fy = multiply(in_A, z[k]);
                    showMatrix(fy, "fy", true);
                    //lambda
                    double[] flambda = new double[n];
                    for (int i = 0; i < n; i++)
                        flambda[i] = fy[i] / z[k][i];
                    showMatrix(flambda, "flambda", true);
                    //lambda1
                    double sum = 0;
                    int count = 0;
                    for (int i = 0; i < n; i++)//S
                        if (z[k - 1][i] > delta)
                        {
                            sum += flambda[i];
                            count++;
                        }
                    double lambda1 = sum / count;
                    output("-----------------------------------------------------\n");
                    output("lambda1=" + lambda1 + "\n");
                    //x
                    double[] x = (multiply(fy, 1 / norm(fy)));
                    showMatrix(x, "x", true);
                    //return
                    return x;
                }


                k++;
                //Щоб не зависало
                Application.DoEvents();
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            return createVector(n, 1) ;
        }
        public double[] scalarMultiplMethod(double[,] in_A)//("Метод скалярних добутків (алгоритм 2)");//8
        {
            //init
            int size = in_A.GetLength(0);
            List<double[]> y = new List<double[]>();
            List<double[]> z = new List<double[]>();
            List<double> lambda = new List<double>();
            double epsilon = 0.001;
            y.Add(createVector(size, 1));
            lambda.Add(0);
            z.Add(normalize(y[0]));
            int k = 1;
            //out
            output("Ініціалізація...\n");
            output("lambda[0] = " + lambda[0] + "\n");
            output("epsilon = " + epsilon + "\n");
            showMatrix(y[0], "y[0]", true);
            showMatrix(z[0], "z[0]", true);
            while (k < 100)
            {
                output("Ітерація "+k+"\n");
                //calc
                y.Add(multiply(in_A, z[k - 1]));
                lambda.Add(multiply(y[k], z[k - 1]) / multiply(z[k - 1], z[k - 1]));
                z.Add(normalize(y[k]));
                //out
                output("lambda["+k+"] = " + lambda[k] + "\n");
                showMatrix(y[k], "y[" + k + "]", true);
                showMatrix(z[k], "z[" + k + "]", true);


                //Прийом Гарвіка
                if (checkBoxAll.Checked && k > 2 && (lambda[k] - lambda[k - 1]) > (lambda[k - 1] - lambda[k - 2]))
                    output("Критерій Гарвіка не виконується!\n");

                //stop
                if (Math.Abs(lambda[k] - lambda[k - 1]) < epsilon)
                {
                    output(" КРИТЕРІЙ ЗУПИНКИ ВИКОНАНО! k = " + k + "\n");
                    output("-----------------------------------------------------\n");
                    output("lambda = " + lambda[k] + "\n");
                    showMatrix(z[k], "x", true);
                    return z[k];
                }
                k++;
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            return createVector(n, 1);
        }
        public double[] methodLU(double[,] in_A)//("LU - метод (Одинична діагональ у матрці U )");//10
        {
            List<double[,]> A = new List<double[,]>();
            A.Add(in_A);
            double epsilon = 0.01;
            int k = 1;
            while (k < 200)
            {
                output("Ітерація "+k+"\n");
                //init
                double[,] L;
                double[,] U;
                //calc
                getLU(A[k-1], out L, out U);
                A.Add(multiply(U, L));
                //show
                showMatrix(L, "L" + k);
                showMatrix(U, "U" + k);
                showMatrix(A[k], "A" + k);
                output("Норма матриці А["+k+"]:" + norm(A[k])+"\n");
                //check
                // різниця норм діагональних елементів менше епсілон.
                if (Math.Abs(norm(getDiagonal(A[k])) - norm(getDiagonal(A[k-1]))) < epsilon)
                {
                    output("Умова виходу виконана\n");
                    output("-----------------------------------------\n");
                    double[] x = getDiagonal(A[k]);
                    showMatrix(x, "lambda", true);
                    return x;
                }
                k++;
            }
            return createVector(5,1);
        }
        public double[] methodQR(double[,] in_A)//("QR -метод (алгоритм 0)");//11
        {
            List<double[,]> A = new List<double[,]>();
            A.Add(in_A);
            output("Норма матриці А[" + 0 + "]:" + norm(A[0]) + "\n");
            double epsilon = 0.01;
            int k = 1;
            while (k < 200)
            {
                output("Ітерація " + k + "\n");
                //init
                double[,] Q;
                double[,] R;
                //calc
                getQR(A[k - 1], out Q, out R);
                A.Add(multiply(R, Q));
                //show
                showMatrix(Q, "Q" + k);
                showMatrix(R, "R" + k);
                showMatrix(A[k], "A" + k);
                output("Норма матриці А[" + k + "]:" + norm(A[k]) + "\n");
                //check
                if (Math.Abs(norm(getDiagonal(A[k])) - norm(getDiagonal(A[k-1]))) < epsilon)
                {
                    output("Умова виходу виконана\n");
                    output("-----------------------------------------\n");
                    double[] x = getDiagonal(A[k]);
                    double[,] vectors = new double[n, n];
                    for (int i = 0; i < x.Length; i++)
                    {
                        //Да я тєбя на ноль памножу!
                        output("Пошук "+i+" власного вектора...\n");
                        //showMatrix(inverce(add(in_A, multiply(getI(n), -x[i]))), "eigen");
                        vectors = setColumn(vectors, findEigenVectorByEigenNumber(in_A, 1500), i);
                    }
                    output("-----------------------------------------\n");
                    showMatrix(x, "lambda", true);
                    showMatrix(vectors, "vectors");
                    return x;
                }
                k++;
            }
            return createVector(5, 1);
        }
        public double[] jacobiMethod(double[,] in_A)//("Метод Якобі (алгоритм 0)");//9
        {
            double epsilon = 0.01;
            int k = 1;
            List<double[,]> B = new List<double[,]>();
            B.Add(in_A);
            while (k<100)
            {
                //create next matrix
                B.Add(createMatrix(n, n, 0));//A);//createMatrix(n,n,0));//new double[n,n]);
                //find max element
                int maxI = 1;
                int maxJ = 0;
                double maxElement = B[k - 1][maxI, maxJ];
                for (int i = 0; i < B[k-1].GetLength(0); i++)
                    for (int j = 0; j < B[k-1].GetLength(0); j++)
                        if (i != j && Math.Abs(B[k-1][i, j]) > maxElement)
                        {
                            maxI = i;
                            maxJ = j;
                            maxElement = Math.Abs(B[k - 1][maxI, maxJ]);
                        }
                //3
                double p = 2 * B[k - 1][maxI, maxJ];
                double q = B[k - 1][maxI, maxI] - B[k - 1][maxJ, maxJ];
                double d = Math.Sqrt(p*p+q*q);
                //4
                double r = Math.Abs(q) / (2 * d);
                double c = Math.Sqrt(0.5 + r);
                double s;
                if(q/p < 10)//якщо q менш ніж в 10 разів більший за p;
                    s = Math.Sign(p * q) * Math.Sqrt(0.5 - r);
                else//ячкщо q в 10 разів більше за p
                    s = Math.Sign(p * q) * Math.Abs(p)/(2*c*d);
                //5
                B[k][maxI, maxI] = (c * c * B[k - 1][maxI, maxI]) + (s * s * B[k - 1][maxJ, maxJ]) + (2 * c * s * B[k - 1][maxI, maxJ]);
                B[k][maxJ, maxJ] = (s * s * B[k - 1][maxI, maxI]) + (c * c * B[k - 1][maxJ, maxJ]) - (2 * c * s * B[k - 1][maxI, maxJ]);
                //6
                B[k][maxI, maxJ] = B[k][maxJ, maxI] = (c*c-s*s)*B[k-1][maxI, maxJ] - c*s*(q);
                //7
                for (int l = 0; l < n; l++)
                {
                    B[k][maxI, l] = B[k][l, maxI] = c * B[k - 1][l, maxI] + s * B[k - 1][l, maxJ];
                    B[k][maxJ, l] = B[k][l, maxJ] = (-s) * B[k - 1][l, maxI] + c * B[k - 1][l, maxJ];
                }
                //out
                if (checkBoxAll.Checked)
                {
                    output("\n\nІтерація " + k + "");
                    showMatrix(B[k], "b[" + k + "]");
                    output("p = " + p + " \n");
                    output("q = " + q + " \n");
                    output("d = " + d + " \n");
                    output("r = " + r + " \n");
                    output("c = " + c + " \n");
                    output("s = " + s + " \n");
                }
                // різниця норм діагональних елементів менше епсілон.
                if (Math.Abs(norm(getDiagonal(B[k])) - norm(getDiagonal(B[k - 1]))) < epsilon)
                {
                    output("Умова виходу виконана\n");
                    output("-----------------------------------------\n");
                    double[] x = getDiagonal(B[k]);
                    showMatrix(x, "lambda", true);
                    return x;
                }
                //8
                k++;
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            return createVector(n, 1); 
        }
        public double[] inverseIterationMethod(double[,] in_A)//("Метод зворотних ітерацій (алгоритм 3)");//7
        {
            List<double[]> y = new List<double[]>();
            List<double[]> z = new List<double[]>();
            List<double> s = new List<double>();
            List<double> p = new List<double>();
            List<double> t = new List<double>();
            List<double> lambda = new List<double>();
            int k = 1;
            y.Add(createVector(n, 1));
            s.Add(multiply(y[0], y[0]));
            p.Add(norm(y[0]));
            z.Add(normalize(y[0]));
            t.Add(0);
            lambda.Add(0);
            output("Ініціалізація: \n");
            showMatrix(y[0], "y[0]", true);
            showMatrix(z[0], "z[0]", true);
            output("p[0] = " + p[0] + "\n");
            output("s[0] = " + z[0] + "\n");
            //ітераційний процес
            while (k < 100)
            {
                output("Ітерація "+k+"\n");
                //розвяжемо СЛАР методом Гауса:
                y.Add(gaussian(in_A, z[k-1]));
                //обчислимо скаляри
                s.Add(multiply(y[k], y[k]));
                t.Add(multiply(y[k], z[k - 1]));
                p.Add(norm(y[k]));
                lambda.Add(s[k]/t[k]);
                z.Add(multiply(y[k], 1/p[k]));
                //out
                showMatrix(y[k], "y[" + k + "]", true);
                showMatrix(z[k], "z[" + k + "]", true);
                output("p[" + k + "] = " + p[k] + "\n");
                output("s[" + k + "] = " + s[k] + "\n");
                output("t[" + k + "] = " + t[k] + "\n");
                output("lambda[" + k + "] = " + lambda[k] + "\n");
                //критерій зупинки
                if (norm(substract(z[k], z[k - 1])) < 0.00001)
                {
                    output("Умова виходу виконана\n");
                    output("------------------------------------\n");
                    showMatrix(z[k], "x", true);
                    output("lambda = " + 1/lambda[k] + "\n");
                    return x;
                }
                k++;
            }
            output(" Перевищено ліміт ітерацій. k = " + k + "\n");
            return createVector(n, 1); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}