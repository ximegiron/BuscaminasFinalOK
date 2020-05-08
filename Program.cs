//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - B U S C A M I N A S - - -");
            int columnas=0;
            int renglones=0;
            int minas=0;
            
            //string a = "10";
            //Console.WriteLine(a.PadLeft(3))
            //Celda.Status celda = Celda.Status.HIDDEN;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("- - - B U S C A M I N A S - - -");
                Console.WriteLine("Escribe el número de la opcion deseada");
                Console.WriteLine("Dificultad: ");
                Console.WriteLine("1. FÁCIL \n 2. MEDIO \n 3. DIFÍCIL \n 4. PERSONALIZADO \n 5.SALIR");
                int dificultad = 0;
                switch (dificultad)
                {
                    case 1:
                    columnas = 7;
                    renglones = 7;
                    minas = 10;
                        break;
                    case 2:
                    columnas = 7;
                    renglones = 7;
                    minas = 10;
                    break;
                    case 3:
                    columnas = 10;
                    renglones = 10;
                    minas = 15;
                    break;
                    case 4:
                    Console.WriteLine("Escriba el número de columnas: ");
                    columnas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el número de renglones: ");
                    renglones = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el número de minas: ");
                    minas = int.Parse(Console.ReadLine());
                    break;
                    case 5:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Ingresa un número del 1 al 5");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            ConsoleGame<Celda> game = new ConsoleGame<Celda>(columnas, renglones, minas);

            while (true)
            {
                Console.Clear();
                game.ShowGrid();
                Console.WriteLine("RENGLÓN: ");
                int renglon = int.Parse(Console.ReadLine());
                Console.ReadLine();
                Console.WriteLine("COLUMNA: ");
                int columna = int.Parse(Console.ReadLine());
                Console.ReadLine();
                Console.ReadKey();




                Console.Write("Fila:");
                int posI = int.Parse(Console.ReadLine());
                Console.Write("Columna:");
                int posJ = int.Parse(Console.ReadLine());

                ConsoleGame<Celda> lista = new ConsoleGame<Celda>();
                int ini_reng = posI - 1;
                if (ini_reng < 0)
                    ini_reng = 0;
                int posI_final = posI + 1;
                if (posI_final >= mat.GetLength(0))
                    posI_final = posI;

                int ini_col = posJ - 1;
                if (ini_col < 0)
                    ini_col = 0;
                int fin_col = pos_col + 1;
                if (fin_col >= mat.GetLength(1))
                    fin_col = pos_col;




                for (int i = ini_reng; i <= posI_final; i++)
                {
                    for (int j = ini_col; j <= fin_col; j++)
                    {
                        if (i == pos_ren && j == pos_col) continue;
                        lista.Add(mat[i, j]);
                    }
                }
                foreach (Celda e in lista)
                {
                    Console.Write(e.valor + ",");
                }

                Console.ReadKey();


            }
            void Click();
            }
        }
    }
