
using System;

class persona //clase base
{
    protected string nombre;
    protected int edad;
    protected string cedula;
    protected int horasTrabajadas;
    protected double pagoSemana;  
    public void setter()
    {
        Console.Write("\nIngrese su nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese su Edad: ");
        edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese su Cedula: ");
        cedula = Console.ReadLine();
        Console.Write("Ingrese la cantidad de horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());
    }
    public void getter()
    {
        Console.WriteLine("\nSu nombre es: {0}", nombre);    
        Console.WriteLine("Su edad es: {0}", edad);  
        Console.WriteLine("Su Cedula es: {0}", cedula); 
        Console.WriteLine("Su cantidad de horas trabajadas es: {0}", horasTrabajadas);
    }
    public virtual void pagoPorSemana()
    {
        
        if (horasTrabajadas <= 44)
        {
            pagoSemana = horasTrabajadas * 50.11;
        }
        else
        {
            pagoSemana = 44 * 50.11 + (horasTrabajadas-44) * 50.11 * 1.5;
        }

        Console.WriteLine("Su pago semanal corresponde a: {0}", pagoSemana);
    }
}

class hombre : persona //clase derivada
{
    protected double bonoPorPaternidad;
    public void LicenciaPorPaternidad()
    {
        Console.WriteLine("Se le han otorgado 3 dias calendario por el nacimiento de su hijo");
    }
    public void incentivoPadre()
    {
        bonoPorPaternidad = pagoSemana/2;
        Console.WriteLine("Su bono por paternidad es: {0}", bonoPorPaternidad);
    }
}

class mujer : persona //clase derivada
{
    public void LicenciaPorMaternidad()
        {
            Console.WriteLine("Se le han otorgado 45 dias calendario por el nacimiento de su hijo");
        }
    public void cuidoInfantil()
    {
        Console.WriteLine("A travez de RRHH se le entregara un formulario para la inscripcion de los niños menores de 3 años a la estancia infantil");
    }
    public override void pagoPorSemana() //METODO SOBREESCRITO*** 
    {
        
        if (horasTrabajadas <= 44)
        {
            pagoSemana = horasTrabajadas * 48.3; //CAMBIE EL VALOR POR EL QUE SE MULTIPLICAN LAS HORAS TRABAJADAS***
        }
        else
        {
            pagoSemana = 44 * 48.3 + (horasTrabajadas-44) * 48.3 * 1.5;
        }

        Console.WriteLine("Su pago semanal corresponde a: {0}", pagoSemana);
    }
    
}

class prueba //tester class
{
    static void Main()
    {
        Console.Clear();
        mujer mujer1 = new mujer();
        hombre hombre1 = new hombre();
        Console.WriteLine("****Esta entrada pertenece a una mujer****");
        mujer1.setter();
        Console.WriteLine("\n****Esta entrada pertenece a un hombre****");
        hombre1.setter();
        Console.WriteLine("*\n***RESUMEN EMPLEADA MUJER****");
        mujer1.getter();
        mujer1.pagoPorSemana();
        mujer1.cuidoInfantil();
        mujer1.LicenciaPorMaternidad();
        Console.WriteLine("\n****RESUMEN EMPLEADO HOMBRE****");
        hombre1.getter();
        hombre1.pagoPorSemana();
        hombre1.incentivoPadre();
        hombre1.LicenciaPorPaternidad();
    }
}
