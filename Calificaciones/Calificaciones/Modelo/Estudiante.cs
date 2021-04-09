using System;
using System.Collections.Generic;

namespace Calificaciones.Modelo
{
    public partial class Estudiante
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Prome { get; set; }
        public string Aprob { get; set; }
    }
}
