using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Vendedor : Persona
    {
        //Atributos
        private string TipoDeContrato;
        private Double Sueldo;

        //Propiedades
        public string TipoDeContrato1 { get => TipoDeContrato; set => TipoDeContrato = value; }
        public Double Sueldo1 { get => Sueldo; set => Sueldo = value; }

        //Operaciones
        public void CalcularSueldo(Double SueldoBase)
        {
            if(this.Tipo == "C")
            {
                this.Sueldo1 = SueldoBase + 350;
            }
            else if(this.Tipo == "N")
            {
                this.Sueldo1 = SueldoBase + 750;
            }
            else
            {
                this.Sueldo1 = 0;
            }
        }
    }
}
