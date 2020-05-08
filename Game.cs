//ximena
using Buscaminas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    public class Game<T> where T : ICell, new()
    {
        protected int tiempo;
        protected int numMines;

        public int width;
        public int height;

        protected int minesLeft;
        public int flagsCount;

        private bool gameOver;
        private int cellsLeft;
        private bool isPlaying;

        public static Game<Celda> currentGame;

        private void GetNeighbors();
        protected void ChangeMineNeighbors();
        public void GenerateRandomMines(int initPosX, int initPosy);

        protected CellNode[,] celdas;

        public int FlagsCount
        {
            get
            {
                return this.FlagsCount;
            }
        }
        public void AddFlag()
        {
            this.flagsCount--;
        }

        public void RemoveFlag()
        {
            this.flagsCount++;
        }

        public void AddMineCount()
        {
            if (--this.mines == 0)
            {
                this.isPlaying = false;
            }
        }

        public int CellsLeft;
        public bool GameOver;
        private int mines;
        public int Tiempo
        {
            get
            {
                return this.tiempo;
            }

            set 
            {
                this.tiempo++;
            }
        }

        private void FormatTime()
        {
            if (this.tiempo == 60)
            {
                this.tiempo = 0;
                this.minutos++;
            }
            return this.minutos.ToString("00") + ":" + this.tiempo.ToString("00")
        }

        public bool GameOver
        {
            get { return this.GameOver; }
            set
            {
                this.GameOver = true;
                this.isPlaying = false;
            }
        }

        public bool IsPlaying
        {
            get => this.isPlaying;
        }
        
        public int HeightGetter
        {
            get
            {
                return this.height;
            }
        }

        public int WidthGetter
        {
            get
            {
                return this.width;
            }
        }

        public Game(int w, int h, int minas)
        {
            this.width = w;
            this.height = h;
            this.numMines = minas;

            this.celdas = new CellNode[w, h];
            for (uint i = 0; i < this.width; i++)
            {
                for (uint j = 0; j < this.height; j++)
                {
                    this.celdas[i, j] = new CellNode(new T());
                }
            }

            this.GenerateMines();
        }

        public class posicion
        {
            public int x;
            public int y;
        }
        public void GenerateMines()
        {
            Random random = new Random();
            List<CellNode> list = new List<CellNode>();
            for (uint i = 0; i < this.width; i++)
            {
                for (uint j = 0; j < this.height; j++)
                {
                    list.Add(this.celdas[i, j]);
                }
            }
            //list[0].cell.SetValue(8);
            //list[0].SetValue(8);
            int pos;
            for (uint i = 0; i < this.numMines; i++)
            {
                pos = random.Next(0, list.Count);
                list[pos].cell = new Mine();
                list.RemoveAt(pos);
            }
        }
        public void GetStats()
        {
        }

    }
}