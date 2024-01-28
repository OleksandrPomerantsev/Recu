using System;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowLlistes();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    OpcionsLlista1();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    OpcionsLlista2();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    OpcionsLlista3();
                    Console.ReadKey();
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    MsgNextScreen("Error. Press any key to retun to the menu...");
                    break;
            }
        }
        while (!(tecla.Key == ConsoleKey.D0 || tecla.Key == ConsoleKey.NumPad0));
    }

    public static void ShowLlistes()
    {
        Console.Clear();
        Console.WriteLine("Escull una de les llistes:\n");
        Console.WriteLine("1 - Llista 1");
        Console.WriteLine("2 - Llista 2");
        Console.WriteLine("3 - Llista 3");
        Console.WriteLine("0 - Sortir");
    }

    public static void OpcionsLlista1()
    {
        int num = 0;
        int num2 = 0;

        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowLlista1();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Sumatori(num));
                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix un enter per elevar");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Potencia(num, num2));
                    Console.ReadKey();
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introdueix un segon enter");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Modul(num, num2));
                    Console.ReadKey();
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Fibonacci(num));
                    Console.ReadKey();
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(ComptarXifres(num));
                    Console.ReadKey();
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    break;
            }
        }
        while (!(tecla.Key == ConsoleKey.D0 || tecla.Key == ConsoleKey.NumPad0));
    }

    public static void ShowLlista1()
    {
        Console.Clear();
        Console.WriteLine("1 - Suma de digits");
        
        Console.WriteLine("3 - Potencia d’un número elevat a un altre");
        
        Console.WriteLine("5 - Modul");
        
        Console.WriteLine("7 - Fibonacci");
        
        Console.WriteLine("9 - Comptar xifres");

        Console.WriteLine("0 - Torna enrere");
    }

    #region Lista 1
    // 1. Sumatori d’un número natural
    public static int Sumatori(int n)
    {
        if (n <= 0) return 0;
        else return n + Sumatori(n - 1);
    }

    // 2. Potència d’un número elevat a un altre
    public static int Potencia(int a, int b)
    {
        if (b == 0) return 1;
        else return a * Potencia(a, b - 1);
    }

    // 3. Mòdul entre dos números
    public static int Modul(int a, int b)
    {
        if (b == 0) return a;
        else return Modul(b, a % b);
    }

    // 4. Enèsim número de la sèrie de Fibonacci
    public static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        else return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // 9. Comptar les xifres d'un nombre de forma recursiva
    public static int ComptarXifres(int n)
    {
        if (n == 0) return 0;
        else return 1 + ComptarXifres(n / 10);
    }
    #endregion

    public static void OpcionsLlista2()
    {
        int num = 0;
        int num2 = 0;
        Random r = new Random();
        int[] vector;


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowLlista2();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Fibonacci2(num));
                    Console.ReadKey();
                    break;


                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Fibonacci2(num));
                    Console.ReadKey();
                    break;


                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine("Introdueix un enter");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Fibonacci2(num));
                    Console.ReadKey();
                    break;


                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.WriteLine("Quina longitud de vectors vols:");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int[] vectorA = CreaUnVector(length);
                    int[] vectorB = CreaUnVector(length);
                    Console.WriteLine($"Producte escalar: {VecProduct(vectorA, vectorB)}");
                    Console.ReadKey();
                    break;

                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.WriteLine("Quina longitud de vector vols:");
                    int longitud = Convert.ToInt32(Console.ReadLine());
                    vector = CreaUnVector(longitud);
                    Console.WriteLine(Compare(vector) ? "Hi ha un element igual a la suma dels anteriors" : "No hi ha coincidències");
                    Console.ReadKey();
                    break;


                case ConsoleKey.B:
                    Console.WriteLine("Quina longitud de vector vols:");
                    longitud = Convert.ToInt32(Console.ReadLine());
                    vector = CreaUnVector(longitud);
                    Console.WriteLine(IsSorted(vector) ? "Està ordenat" : "No està ordenat");
                    Console.ReadKey();
                    break;


                case ConsoleKey.D:
                    Console.WriteLine("Quina longitud de vector vols:");
                    int longitudSeparar = Convert.ToInt32(Console.ReadLine());
                    long[] vectorSeparar = CreaUnVectorLong(longitudSeparar);
                    Console.WriteLine("Quina suma vols comprovar?");
                    long sumaTotal = Convert.ToInt64(Console.ReadLine());

                    if (Separar(vectorSeparar, sumaTotal))
                    {
                        Console.WriteLine("Es pot separar amb la mateixa suma en ambdós costats.");
                    }
                    else
                    {
                        Console.WriteLine("No es pot separar amb la mateixa suma en ambdós costats.");
                    }
                    Console.ReadKey();
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    break;
            }
        }
        while (!(tecla.Key == ConsoleKey.D0 || tecla.Key == ConsoleKey.NumPad0));
    }

    public static void ShowLlista2()
    {
        Console.Clear();
        Console.WriteLine("1 - Enèssim número Fibonacci");
        
        Console.WriteLine("3 - És triangular?");
        
        Console.WriteLine("5 - Capgira números");
        
        Console.WriteLine("7 - Producte escalar de dos vectors");
        
        Console.WriteLine("9 - Suma dels valors precedents?");

        Console.WriteLine("B - El vector està ordenat?");

        Console.WriteLine("D - Esquerra i dreta sumen el mateix?");

        Console.WriteLine("0 - Torna enrere");
    }

    #region Lista 2

    // 1. Fibonacci
    public static int Fibonacci2(int n)
    {
        if (n == 0) return 0;
        else if (n == 1) return 1;
        else return Fibonacci2(n - 1) + Fibonacci2(n - 2);
    }

    // 3. Verificar si un nombre és triangular

    public static bool EsTriangular(int n)
    {
        if (n == 0 || n == 1)
        {
            return true;
        }
        else if (n < 0)
        {
            return false;
        }
        else
        {
            int suma = 0;
            int i = 1;
            while (suma < n)
            {
                suma += i;
                i += 1;
            }
            if (suma == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // 5. Invertir un número enter
    public static int ReverseInteger(int num)
    {
        int revNum = 0;
        while (num != 0)
        {
            revNum = revNum * 10 + num % 10;
            num = num / 10;
        }
        return revNum;

    }

    // 7. Mostrar el producto de 2 vectores

    // Una fumada con los returns Artur.
    public static int VecProduct(int[] a, int[] b, int n = 0)
    {
        if (a == null || b == null)
        {
            return -1;
        }

        if (a.Length != b.Length)
        {
            return -2;
        }

        if (n == a.Length)
        {
            return 0;
        }

        return a[n] * b[n] + VecProduct(a, b, n + 1);
    }

    // 9. Determinar si algún elemento de un vector coincide con la suma de los elementos que tiene
    public static bool Compare(int[] vector, int index = 0, int sum = 0)
    {
        if (index == vector.Length)
        {
            return false;
        }
        else
        {
            sum += vector[index];
            if (sum == vector[index] || Compare(vector, index + 1, sum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // 11. Esta ordenado o no
    public static bool IsSorted(int[] vector, int index = 0, int nextIndex = 1)
    {
        if (index == vector.Length - 1)
        {
            return true;
        }
        else
        {
            if (vector[index] == vector[nextIndex])
            {
                return IsSorted(vector, index + 1, nextIndex + 1);
            }
            else if (vector[index] < vector[nextIndex])
            {
                return IsSorted(vector, index + 1, nextIndex + 1);
            }
            else // vector[index] > vector[nextIndex]
            {
                return false;
            }
        }
    }


    // 13. Buscar en los dos lados la suma igual

    public static bool Separar(long[] vector, long total)
    {
        return Separar(vector, 0, vector.Length - 1, 0, total);
    }

    private static bool Separar(long[] vector, int principi, int final, long suma, long total)
    {
        bool res;
        if (suma == total)
        {
            res = true;
        }
        else if (principi == final)
        {
            res = false;
        }
        else
        {
            if (suma + vector[principi] <= total)
            {
                res = Separar(vector, principi + 1, final, suma + vector[principi], total);
            }
            else if (suma + vector[final] <= total)
            {
                res = Separar(vector, principi, final - 1, suma + vector[final], total);
            }
            else
            {
                res = false;
            }
        }
        return res;
    }

    #endregion
    public static void OpcionsLlista3()
    {
        int num = 0;
        int num2 = 0;

        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowLlista3();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                

                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Quants casos vols?");
                    int casos = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < casos; i++)
                    {
                        int numero = Convert.ToInt32(Console.ReadLine());
                        string resultat = Base6(numero);
                        Console.WriteLine("Resultat: " + resultat);
                    }

                    Console.ReadKey();
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    break;
            }
        }
        while (!(tecla.Key == ConsoleKey.D0 || tecla.Key == ConsoleKey.NumPad0));
    }

    public static void ShowLlista3()
    {
        Console.Clear();
        Console.WriteLine("1 - Tres dits a cada ma");
        Console.WriteLine("0 - Torna enrere");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    public static string Base6(long n)
    {
        string res;

        if (n == 0)
        {
            res = "0";
        }
        else
        {
            res = Base6(n / 6);
            res += n % 6;
        }

        return res;
    }

    public static int[] CreaUnVector(int Longitud)
    {
        int[] vector = new int[Longitud];
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Introdueix Un Número A La Posició {i + 1} -> ");
            int numvector = Convert.ToInt32(Console.ReadLine());
            vector[i] = numvector;
        }

        Console.Write("[");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
            if (i < vector.Length - 1) { Console.Write(","); }
        }
        Console.Write("]\n");

        return vector;
    }

    public static long[] CreaUnVectorLong(long Longitud)
    {
        long[] vector = new long[Longitud];
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Introdueix Un Número A La Posició {i + 1} -> ");
            int numvector = Convert.ToInt32(Console.ReadLine());
            vector[i] = numvector;
        }

        Console.Write("[");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
            if (i < vector.Length - 1) { Console.Write(","); }
        }
        Console.Write("]\n");

        return vector;
    }
}