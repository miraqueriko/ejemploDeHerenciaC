using System;

class persona //clase base
{
    protected string nombre;
    protected int edad;
    protected string cedula;
    protected string direccion;
    protected double sueldoBase;
  
    public void setNombre()
    {
        Console.Write("\n\nIngrese su nombre: ");
        nombre = Console.ReadLine();
    }

    public void getNombre()
    {
        Console.WriteLine("\n\nSu nombre es: {0}", nombre);       
    }

    public void setEdad()
    {
        Console.Write("\nIngrese su Edad: ");
        edad = int.Parse(Console.ReadLine());
    }

    public void getEdad()
    {
        Console.WriteLine("\nSu edad es: {0}", edad);       
    }

    public void setCedula()
    {
        Console.Write("\nIngrese su Cedula: ");
        cedula = Console.ReadLine();
    }

    public void getCedula()
    {
        Console.WriteLine("\nSu Cedula es: {0}", cedula);       
    }

    public void setDireccion()
    {
        Console.Write("\nIngrese su Direccion: ");
        direccion = Console.ReadLine();
    }

    public void getDireccion()
    {
        Console.WriteLine("\nSu Direccion es: {0}", direccion);       
    }

    public virtual void Licencia() //metodo virtual para poder sobreescribir en una clase heredera
    {
        Console.WriteLine("\nLicencia por paternidad otorgada: 2 Dias");
    }

    public void setSueldoBase()
    {
        Console.Write("\nIngrese el sueldo base del puesto: ");
        sueldoBase = double.Parse(Console.ReadLine());
    }
    public void getSueldoBase()
    {
        Console.WriteLine("\nSu sueldo base es: {0}", sueldoBase);
    }

}

class hombre : persona //clase derivada
{
    private int esperanzaDeVida; //atributo propio de la clase
    private int superavit; //atributo propio de la clase

    public void mensaje() //metodo propio de la clase
    {
        Console.Write("\n****Este objeto es para una persona masculina****");
    }

    public void EsperanzaDeVida() //metodo propio de la clase
    {
        esperanzaDeVida = 74 - edad;

        if (esperanzaDeVida > 0)
        {
            Console.Write("\nSu esperanza de vida es de: {0} años", esperanzaDeVida);
        }

        else
        {
            superavit = esperanzaDeVida * (-1);
            Console.Write("\nUsted a superado la esperanza de vida por: {0} años", superavit);
        }
    }
    

}

class mujer : persona //clase derivada
{
    private double sueldo; //atributo propio de la clase

    public override void Licencia() //metodo sobreescrito de la clase base
    {
        Console.WriteLine("\nLicencia por Maternidad otorgada: 13 Semanas");
    }

    public void Sueldo() //metodo propio de la clase
    {
        sueldo = sueldoBase - (sueldoBase * 0.2);
        Console.WriteLine("\nEl sueldo promedio en base a su sueldo base es {0}", sueldo);
    }

    public void mensaje() //metodo propio de la clase
    {
        Console.Write("\n****Este objeto es para una persona femenina****");
    }
}

class prueba //tester class
{
    static int Main()
    {
        Console.Clear();
        hombre hombre1= new hombre(); //constructor clase hombre
        mujer mujer1= new mujer(); //contructor clase mujer
        hombre1.mensaje(); //metodo de la clase hombre
        hombre1.setNombre(); //metodo heredado de la clase persona 
        hombre1.setEdad(); //metodo heredado de la clase persona
        hombre1.setCedula(); //metodo heredado de la clase persona
        hombre1.setDireccion(); //metodo heredado de la clase persona
        mujer1.mensaje(); //metodo de la clase mujer
        mujer1.setNombre(); //metodo heredado de la clase persona 
        mujer1.setEdad(); //metodo heredado de la clase persona
        mujer1.setCedula(); //metodo heredado de la clase persona
        mujer1.setDireccion(); //metodo heredado de la clase persona
        mujer1.setSueldoBase(); //metodo heredado de la clase persona
        Console.Write("\n\n*******DESPLIEGUE DE INFORMACION*******");
        hombre1.getNombre(); //metodo heredado de la clase persona 
        hombre1.getEdad(); //metodo heredado de la clase persona
        hombre1.getCedula(); //metodo heredado de la clase persona
        hombre1.getDireccion(); //metodo heredado de la clase persona
        hombre1.Licencia(); //metodo heredado de la clase persona
        hombre1.EsperanzaDeVida(); ////metodo de la clase hombre
        Console.Write("\n\n***************************************");
        mujer1.getNombre(); //metodo heredado de la clase persona 
        mujer1.getEdad(); //metodo heredado de la clase persona
        mujer1.getCedula(); //metodo heredado de la clase persona
        mujer1.getDireccion(); //metodo heredado de la clase persona
        mujer1.Licencia(); //metodo sobreescrito
        mujer1.getSueldoBase(); //metodo heredado de la clase persona
        mujer1.Sueldo(); //metodo de la clase mujer
        return 0;
    }
}