//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class ConsoleGame<T> : Game<T> where T : ICell, new()
    {
        private char hiddenSymbol;
        private char mineCell;
        private char flagSymbol;

        public ConsoleGame(int w, int h, int minas) : base(w, h, minas)
        {
            this.hiddenSymbol = (char)9632;
            Console.ForegroundColor = ConsoleColor.Red;
            this.mineCell = '*';
            Console.ForegroundColor = ConsoleColor.Cyan;
            this.flagSymbol = '°';
            Console.ForegroundColor = ConsoleColor.White;
            ShowGrid();
        }

        public void ShowGrid()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth * 3));
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Minas restantes: " + this.flagsCount);
            Console.Write("".PadRight(4));
            for (int i = 0; i < this.width; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write((char)(65 + i) + " ");
            }
            Console.WriteLine();
            string printingValue;

            for (uint i = 0; i < this.height; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(((i + 1) + " ").PadLeft(4));
                Console.ForegroundColor = ConsoleColor.White;
                for (uint j = 0; j < this.width; j++)
                {
                    switch (this.celdas[j, i].cell.GetStatus())
                    {
                        case Celda.Status.SHOWN:
                            if (this.celdas[j, i].cell is Mine) //Comprobar tipo de dato
                            {
                                printingValue = this.mineCell.ToString();
                            }
                            else
                            {
                                printingValue = "" + this.celdas[j, i].cell.GetValue();
                            }
                            break;
                        case Celda.Status.FLAG:
                            printingValue = "" + this.flagSymbol;
                            break;
                        default:
                            printingValue = "" + this.hiddenSymbol;
                            break;
                    }
                    Console.Write(printingValue + " ");
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(0, this.height + 2);
        }

        public void ParseReadOut(string input)
        {
            bool rightclick = false;
            try
            {
                if (input[0] == 1)
                {
                    rightclick = true;
                    input = input.Substring(1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Coordenada(int width, int height)
        {
            int[] coordenadas = new int[this.width];
            for (int i = 0; i < this.width; i++)
            {
                coordenadas[i] = i;
            }
            bool flag = true;
            do
            {
                Console.WriteLine("COLUMNA: ");
                string columna = Console.ReadLine().ToUpper();
                int coord = (int)columna[0] - 65;

                if (coord < coordenadas.Length)
                {
                    this.width = coordenadas[coord];
                    Console.WriteLine("RENGLÓN: ");
                    int renglon = int.Parse(Console.ReadLine());
                    if (renglon > 0 && renglon <= this.height)
                    {
                        this.width = renglon;
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("¡Verifique el número de renglón!");
                    }
                }

                else
                {
                    Console.WriteLine("¡Verifique la letra de la columna!");
                }

            } while (flag == true);

            return (this.height) + (this.width);
        }
        
    }
}


