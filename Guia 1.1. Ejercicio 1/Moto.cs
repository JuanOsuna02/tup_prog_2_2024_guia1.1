using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1._1.Ejercicio_1
{
    internal class moto
    {
        public string marca {  get; private set; }
        public int modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public moto(string Marca,int Modelo, double ValorF) { 

            this.marca = Marca;
            this.modelo = Modelo;
            ValorFabricacion = ValorF;
        }

        public double CalcuDepLineal(int Año,int Vida)
        {
            
            
            double Valor=ValorFabricacion-(ValorFabricacion*Año/Vida);
            return Valor;


        }
        public double CalcuDepAnual(int Año, double Tasa)
        {
            double aux, aux2;
            aux = 1 - Tasa;
            aux2 = Math.Pow(aux,Año);

            double Valor = ValorFabricacion * aux2;
            return Valor;


        }
    }
}
