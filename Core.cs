using System;

namespace DemoConstructor
{
    public class Core
    {
        public void Despedir()
        {
             Console.WriteLine("Bye World!");
        }
        public static void Saludar(){
            Console.WriteLine("Hola mundo!");
        }
        public Core()
        {
             Empleado empleado=new Empleado();
            Console.WriteLine(empleado.nombre);
            Console.WriteLine("escribe tu nombre:");
            string nombre=Console.ReadLine();
            Console.WriteLine("escribe tu Apellido paterno:");
            string paterno=Console.ReadLine();
            Console.WriteLine("escribe tu Apellido materno:");
            string materno=Console.ReadLine();
            Empleado empleado2=new Empleado(nombre,paterno,materno);
            Console.Write(empleado2.nombre);
            Console.WriteLine(empleado2.nombreCompleto);
            empleado2.fechaNacimiento =Convert.ToDateTime("30/11/1992");
             Console.WriteLine(empleado2.ObtenerCumpleaños());
             empleado2.AñoNacimiento();
             Console.WriteLine(empleado2.año);
        }
    }
}