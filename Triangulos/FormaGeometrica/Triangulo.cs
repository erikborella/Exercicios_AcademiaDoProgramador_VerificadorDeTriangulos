using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos.FormasGeometricas
{
    public enum TipoTriangulo
    {
        Equilatero,
        Isosceles,
        Escaleno,
        Invalido
    };

    class Triangulo
    {

        public double x;
        public double y;
        public double z;

        public Triangulo(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public TipoTriangulo Tipo
        {
            get
            {
                if (!EhTrianguloValido())
                    return TipoTriangulo.Invalido;

                if (EhTrianguloEquilatero())
                    return TipoTriangulo.Equilatero;

                else if (EhTrianguloIsoceles())
                    return TipoTriangulo.Isosceles;

                else if (EhTrianguloEscaleno())
                    return TipoTriangulo.Escaleno;

                else
                    return TipoTriangulo.Invalido;
            }
        }


        // Verifica se um dos lados é menor que a soma dos outros
        private bool EhTrianguloValido()
        {
            return (x < y + z &&
                y < x + z &&
                z < x + y);
        }

        // Todos os lados são iguais
        private bool EhTrianguloEquilatero()
        {
            return (x == y && x == z && y == z);
        }

        // Apenas dois lados iguais
        private bool EhTrianguloIsoceles()
        {
            return (x == y || y == z || x == z);
        }

        // Todos os lados diferentes
        private bool EhTrianguloEscaleno()
        {
            return (x != y && x != z && y != z);
        }
    }
}
