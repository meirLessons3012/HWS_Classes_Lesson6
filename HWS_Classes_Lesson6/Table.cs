using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Classes_Lesson6
{
    public class Table
    {
        #region Fields
        public int numOfLegs;
        public string color;
        public string woodType;
        #endregion

        #region Ctors
        public Table()
        {
            numOfLegs = 4;
        }

        public Table(int numOfLegs, string color, string woodType) : this()
        {
            this.numOfLegs = numOfLegs;
            this.color = color;
            this.woodType = woodType;
        } 
        
        #endregion
       
        #region Methods
        public override string ToString()
        {
            return $"num Of Legs {numOfLegs}. color: {color}. wood Type: {woodType}.";
        }
        #endregion
    }
}
