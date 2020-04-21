//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Mine : ICell
    {

        public int x;
        public int y;

        public Celda.Status status;

        public Mine()
        {
            this.status = Celda.Status.SHOWN;
        }
        public Celda.Status GetStatus()
        {

            return this.status;
        }

        public int GetValue()
        {
            return 0; //throw new NotImplementedException();    
        }

        public bool IsHidden()
        {
            return false;
        }

        public void LeftClick()
        {
        }

        public void RightClick()
        {
          
        }
    }
}
