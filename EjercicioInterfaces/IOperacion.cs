using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public interface IOperacion
    {
        double AreaCuadrado(double lado);
        double VolumenCubo(double lado);
        double PerimetroCuadrado(double lado);
        int IMC(int peso, int altura);
        double CalcularVelocidad(double tiempo, double distancia);
      
    }
}
