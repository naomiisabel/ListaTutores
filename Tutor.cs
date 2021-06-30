using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTutores.modelo
{
    class Tutor
    {
        private string ID_TUTOR;
        private string NOMBRES ;
        private string APELLIDOS;
        private string TITULO_ACADEMICO;
        private string DIRECCION;
        private string FECHA_NACIMIENTO;

        public Tutor()
        {
            this.ID_TUTOR = "";
            this.NOMBRES = "";
            this.APELLIDOS = "";
            this.TITULO_ACADEMICO = "";
            this.DIRECCION = "";
            this.FECHA_NACIMIENTO = "";
        }

        public string ID_TUTOR1 { get => ID_TUTOR; set => ID_TUTOR = value; }
        public string NOMBRES1 { get => NOMBRES; set => NOMBRES = value; }
        public string APELLIDOS1 { get => APELLIDOS; set => APELLIDOS = value; }
        public string TITULO_ACADEMICO1 { get => TITULO_ACADEMICO; set => TITULO_ACADEMICO = value; }
        public string DIRECCION1 { get => DIRECCION; set => DIRECCION = value; }
        public string FECHA_NACIMIENTO1 { get => FECHA_NACIMIENTO; set => FECHA_NACIMIENTO = value; }
    }
}
