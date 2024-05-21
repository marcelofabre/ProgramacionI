
using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //CalcularDiasLadosDeUnTriangulo(); 
        //CalcularFechaValida();
        //CalcularHorasFaltantes();
        //CalcularValorPago();
        //PruebaDeObjetosSplit();
        //PruebaObjetoPersona();
        //pruebapavaelectrica();
        //pruebacalculadora();
        //pruebaventilador();
        //pruebastereo();
        pruebaClasesAbstractaYHerencia();
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
    private static void CalcularDiasDeVida()
    {
        //declaramos las variables
        int años,meses,dias,diasDeVida;

        Console.Write("Ingrese sus años de vida:");
        años=int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida:");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus días de vida:");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los días de vida totales son:{diasDeVida}");
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
    private static void CalcularFechaValida()
    {
        int dia, mes, año;

        Console.WriteLine("ingrese el numero de día");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese el numero de mes");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese el numero de año");
        año = int.Parse(Console.ReadLine());


        //el DateTime.IsLeapYear(año) basicamente controla si el año es bisiesto o no
        bool esBisiesto = DateTime.IsLeapYear(año);

        //"DateTime.DaysInMonth(año, mes)" verifica que el dia este en el rango valido dependiendo del dia y el mes que se encuentre

        if (mes >= 1 && mes <= 12 && dia >= 1 && dia <= DateTime.DaysInMonth(año, mes))

        {
            Console.WriteLine($"{dia}/{mes}/{año} es una fecha válida.");
        }
        else
        {
            Console.WriteLine($"{dia}/{mes}/{año} no es una fecha válida.");
        }
    }
    private static void CalcularHorasFaltantes()
    {
        int HorasTrabajadas;
        string dias; 
        Console.Write("Ingrese la cantidad de horas trabajadas:");
        HorasTrabajadas= int.Parse(Console.ReadLine());

        Console.Write("Ingrese el dia en el que está:");
        dias = Console.ReadLine();

       
       

        if (dias == "jueves" || dias=="JUEVES" || dias=="Jueves")
            Console.Write("las horas faltantes son:" + (5 - HorasTrabajadas + 2));
        else
            Console.Write("las horas faltantes son:" +(5 - HorasTrabajadas));


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





