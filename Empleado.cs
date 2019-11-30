using System;

namespace DemoConstructor
{
    public class Empleado
    {
        //contructor
        public Empleado()
        {
            nombre="Juan";
            apellidoPaterno="Pérez";
            apellidoMaterno="López";
        }
        public Empleado(string _nombre, string _apellidoPaterno, string _apellidoMaterno)
        {
             nombre=_nombre;
            apellidoPaterno=_apellidoPaterno;
            apellidoMaterno=_apellidoMaterno;
            nombreCompleto=_nombre+" "+_apellidoPaterno+" "+_apellidoMaterno;
        }
        //destructor
        ~Empleado(){

        }
        //Atributos
        #region Atributos
           public string nombre;
           public string apellidoPaterno;
            public string apellidoMaterno;
            public string nombreCompleto;
            public DateTime fechaNacimiento;
            public int año;
        #endregion

        //Metodos
#region Metodos
    public void AñoNacimiento()
    {
        año =fechaNacimiento.Year;
    }
    public string ObtenerCumpleaños()
    {
        return fechaNacimiento.Day.ToString() +" "+ 
        fechaNacimiento.Month.ToString();

    }
    public string NombreMes(int mes)
    {
        string nombreMes="";
        switch (mes)
        {
            case 1:
            nombreMes="Enero";
            break;
            case 2:
            nombreMes="febrero";
            break;

        }
        return nombreMes;
    }
#endregion
        //Eventos
     //   
#region Eventos
    
#endregion
    }
}