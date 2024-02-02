using System;

namespace Estructura_de_Clase
{
    public abstract class MiembroDeLaComunidad
    {
        private string nombre;

        public MiembroDeLaComunidad(string nombre)
        {
            this.nombre = nombre;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
        }
    }

    public class Empleado : MiembroDeLaComunidad
    {
        public Empleado(string nombre) : base(nombre) { }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Empleado");
        }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public Estudiante(string nombre) : base(nombre) { }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Estudiante");
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public ExAlumno(string nombre) : base(nombre) { }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: ExAlumno");
        }
    }

    public class Docente : Empleado
    {
        public Docente(string nombre) : base(nombre) { }
    }

    // Otras clases derivadas similares a Docente

    public class Program
    {
        public static void Main(string[] args)
        {
            MiembroDeLaComunidad miembro = new Docente("John Doe");
            miembro.MostrarInformacion();
        }
    }
}
