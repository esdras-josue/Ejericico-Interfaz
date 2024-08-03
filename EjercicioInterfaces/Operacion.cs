using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EjercicioInterfaces
{
    public class Operacion : IOperacion
    {
        public double area;
        public double volumen;
        public double perimetro;
        public int altura;
        public int peso;
        public double tiempo;
        public double distancia;
        public double AreaCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }

        public double VolumenCubo(double lado)
        {
            double area = lado * lado * lado;
            return area;
        }

        public double PerimetroCuadrado(double lado)
        {
            double perimetro = 4 * lado;
            return perimetro;
        }
        public int IMC(int peso, int altura)
        {
            int Imc = peso / altura;
            return Imc;
        }

        public double CalcularVelocidad(double distancia, double tiempo)
        {
            double velocidad = distancia / tiempo;
            return velocidad;
        }


        public void Imprimir(double area, double volumen, double cuadrado,int peso,int altura)
        {
            Console.WriteLine($"Area de cuadrado: {AreaCuadrado(area)} cm.");
            Console.WriteLine($"Volumen de cubo: {VolumenCubo(volumen)} cm.");
            Console.WriteLine($"Perimetro de cubo: {PerimetroCuadrado(perimetro)} cm.");
            Console.WriteLine($"IMC: {IMC(altura, peso)} lbs");
            Console.WriteLine($"Velocidad promedio: {CalcularVelocidad(distancia,tiempo)} KM/H.");
            
        }
    }
}
