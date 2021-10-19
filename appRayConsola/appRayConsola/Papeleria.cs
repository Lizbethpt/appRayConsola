using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRayConsola
{
    class Papeleria
    {
        private string colordeLustrina;
        private string pluma;
        private string cuaderno;

        public string Cuaderno
        {
            get { return cuaderno; }
            set { cuaderno = value; }
        }

        public string Pluma
        {
            get { return pluma; }
            set { pluma = value; }
        }

        public string ColordeLustrina
        {
            get { return colordeLustrina; }
            set { colordeLustrina = value; }
        }


        public Papeleria()
        {
            colordeLustrina = "";
            pluma = "";
            cuaderno = "";
        }
        public Papeleria(string colordeLustrina, string pluma, string cuaderno)
        {
            this.colordeLustrina = colordeLustrina;
            this.pluma = pluma;
            this.cuaderno = cuaderno;
        }
        public override string ToString()
        {
            return colordeLustrina + " " + pluma + " " + cuaderno;
        }

    }
}
