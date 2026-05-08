using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion_csharp.Models
{
    public class OperasBas
    {

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public void Suma()
        {
            this.Res = this.Num1 + this.Num2;
        } 

    }
}