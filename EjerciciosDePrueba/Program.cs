
using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

public class ProgramEjercicios
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //Console.WriteLine(CalcularDiasDeVida(1,1,1));
        //Console.WriteLine(CalcularDiasLadosDeUnTriangulosss(1, 1, 1));
        //ImprimirMinimoDe4();
        //CalcularDiasLadosDeUnTriangulo(); 
        //fechasValidasInvalidas();
        //Console.WriteLine(ControlFechaValida(29, 2, 2023));
        //CalcularHorasFaltantes();
        //CalcularValorPago();
        //PruebaDeObjetosSplit();
        //PruebaObjetoPersona();
        //pruebapavaelectrica();
        //pruebacalculadora();
        //pruebaventilador();
        //pruebastereo();
        //pruebaClasesAbstractaYHerencia();
        //pruebacalculadoraPasajePorReferencia();
        PruebaDeClasesGenéricas();
    }

    private static void PruebaDeClasesGenéricas()
    {
        Empresa<empleado> empresa = new Empresa<empleado>("Neumaticos Debona");

        gerente empleado1 = new gerente("Marcelo", "Fabre");
        gerente empleado2 = new gerente("Tomas", "Avalos");
        empresa.agregarEmpleado(empleado1);
        empresa.agregarEmpleado(empleado2);
        Console.WriteLine(empresa.ListarPersonas());
        empresa.quitarEmpleado(empleado2);
        Console.WriteLine(empresa.ListarPersonas());

    }

    private static void pruebacalculadoraPasajePorReferencia()
    {
        int a = 123;
        int b = 10;
        int total = 0;
        Calculadora2 calculadora2 = new Calculadora2();
        calculadora2.Sumar(a,b,ref total);
        Console.WriteLine("la suma total es:" + total);
     }

    private static void pruebaClasesAbstractaYHerencia()
    {
        gerente  juan= new gerente("Marcelo", "Fabre");
        Console.WriteLine(juan.ImprimirDatos());
    }

    private static void pruebastereo()
    {
        Stereo mistereo = new Stereo("color", "marca");
        

            mistereo.presionarBotonEncendido();

            mistereo.cambiarModo(Modostereo.Radio);
            mistereo.SetNombreRadio("Radio FM 102.5");
            mistereo.Display();
           

            mistereo.cambiarModo(Modostereo.Bluetooth);
            mistereo.SetNombreCancionBluetooth("Callejeros - Imposible");
            mistereo.Display();

            mistereo.cambiarModo(Modostereo.Cd);
            mistereo.SetPistaCD("6 (Soda stereo - de musica ligera)");
            mistereo.Display();

            mistereo.cambiarModo(Modostereo.EntradaAuxiliarAudio);
            mistereo.setEntradaAuxiliarAudio("YSY A - a por todo");
            mistereo.Display();
            mistereo.presionarBotonEncendido();
        
    }

    private static void pruebapavaelectrica()
    {
        PavaElectrica mipava = new PavaElectrica("cromado", "PEABODY", 100);
        mipava.SeleccionarTipoBebida("mate");
        mipava.CalentarAgua();
        mipava.PresionarBotonEncendido();
        mipava.SeleccionarTipoBebida("mate");
        mipava.CalentarAgua();


    }
    private static void pruebacalculadora()
    {
        calculadora micalculadora = new calculadora("cromado", "PEABODY", "científica");
        micalculadora.PresionarBotonEncendido();
        micalculadora.Sumar(1, 2, 3, 4);
        micalculadora.multiplicar(4, 4, 5, 6);
        micalculadora.dividir(3, 4, 5, 6);
        micalculadora.Restar(3, 4, 5, 6);
        micalculadora.CambiarModo("Básica");

    }
    private static void pruebaventilador()
    {
        ventilador miventilador = new ventilador("Negro", "PEABODY", "Industrial de pie", "Fijo");
        miventilador.cambiarModo("automatico");
        miventilador.presionarbotonencendido();
        miventilador.cambiarModo("automatico");
        miventilador.subirVelocidad();
        miventilador.subirVelocidad();
        miventilador.subirVelocidad();
        miventilador.subirVelocidad();
        miventilador.bajarVelocidad();
        miventilador.bajarVelocidad();


    }





    /// <summary>
    /// algoritmo que imprime el mínimo entre cuatro valores que se piden al usuario.
    /// </summary>
    private static void ImprimirMinimoDe4()
    {
        //declaramos las variables
        int num1, num2, num3, num4;

        //pedimos el ingreso de los 4 números
        Console.Write("Ingrese el primer número:");
        num1= int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el segundo número:");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número:");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número:");
        num4 = int.Parse(Console.ReadLine());

        //comparamos los numeros el "O" son "||"

        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine("el numero menor es el primero:" + num1);
        if (num2 < num1 && num2 < num3 && num2 < num4)
            Console.WriteLine("el numero menor es el segundo:" + num2);
        if (num3 < num1 && num3 < num2 && num3 < num4)
            Console.WriteLine("el numero menor es el tercero:" + num3);
        if (num4 < num1 && num4 < num2 && num4 < num3)
            Console.WriteLine("el numero menor es el :" + num4);
    }
     

//Creamos un método que pida el nombre y apellido del usuario
//y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]
private static void PedirNombreYSaludar()
    {
        //Declaramos las variables
        string nombre,apellido;

        Console.Write("Ingrese su nombre:");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido:");
        apellido = Console.ReadLine();

        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    /*Creamos un método que nos pida los años, meses y días de vida
    y muestre al final la cantidad total de días de vida
     */
    public static int CalcularDiasDeVida(int años, int meses, int dias )
    {
        int diasDeVida;
        diasDeVida = (años * 365) + (meses * 30) + dias;
        return diasDeVida;
    }
    private static void CalcularDiasLadosDeUnTriangulo()
    {
        //declarqamos las variables
        int lado1, lado2, lado3;
       Console.Write("Ingrese el primer lado:");
       lado1= int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el segundo lado:");
       lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer lado:");
       lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("el triángulo es Equilátero.");
        }

        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("el triángulo es Isósceles.");
        }

        else
        {
            Console.WriteLine("el triangulo es Escaleno.");
        }


      
    }

    public static string CalcularDiasLadosDeUnTriangulosss(int lado1, int lado2, int lado3)
    {
        //declarqamos las variables
        
       

        if (lado1 == lado2 && lado2 == lado3)
        {
            return "Equilatero";
        }

        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            return "Isósceles";
        }

        else
        {
            return "Escaleno";
        }



    }


    private static void fechasValidasInvalidas()

    {
        //definir variables  
        int dia, mes, año;

        // Pedir Informacion al usuario
        Console.WriteLine("Ingrese el día");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año");
        año = int.Parse(Console.ReadLine());


        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            Console.WriteLine("Fecha Valida");

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            Console.WriteLine("Fecha Valida ");

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            Console.WriteLine("Fecha Valida ");

        else
            Console.WriteLine("Fecha Invalida");

    }


    public static bool ControlFechaValida(int dia, int mes, int año)

    {
       


        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            return true;


        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            return true;


        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            return true;

        else
            return false;

    }
    private static void CalcularValorPago()
    {
        //declaramos las variables
        double valorCuota;
        int nroDia;

        //leemos las variables 
        Console.Write("ingrese el valor de la cuota: ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("ingrese el número de día de pago: ");
        nroDia = int.Parse(Console.ReadLine());
        
        switch (nroDia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;


            case >=6 and <= 10:
                    valorCuota = valorCuota + (valorCuota * 0.01);
                break;

            case >= 11  and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;

            case >= 21 and <= 31:
                valorCuota = valorCuota + (valorCuota * 0.15);
                break;


        }

        Console.WriteLine($"el valor de la cuota para el dia de pago es: {valorCuota}");





    }
    private static void PruebaDeObjetosSplit()
    {
        //instanciamos el objeto split: se pone la clase, se pone un nombre de objeto y despues se hace new y se pone split, abrimos parentesis y ahi le ponemos la informacion que le queremos pasar
        Split miSplit = new Split("Blanco", 3000, "Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo(ModoEnum.Maximo);
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es: " + miSplit.modo);

    }
    private static void PruebaObjetoPersona()

    {
        Persona Messi= new Persona("Lionel Messi", "Rosario", 1987);
        Persona Lewandowski = new Persona("Robert lewandowski(peresín)", "Castelldefels", 1988);

        Lewandowski.decir("Mi doctor me aconsejó que deje el fútbol");
        Messi.decir("¿Por qué?,¿estas enfermo?");
        Lewandowski.decir("No, porque me ha visto jugar");
    }





   

}





