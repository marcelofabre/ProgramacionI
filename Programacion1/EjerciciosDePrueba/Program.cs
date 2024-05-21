

internal class Program
{
    private static void Main(string[] args)
    {
        //PedirNombreYSaludar();
        //CalcularDiasDeVida();
        //ImprimirMinimoDe4();
        //ImprimirTipoDeTriangulo();
        DeterminarFechaValida();
        //CalcularHorasDeTrabajoFaltantes();
    }

    /// <summary>
    /// Algoritmo que muestre la cantidad de horas que faltan para el fin de la jornada laboral, tomando en cuenta que los jueves se trabajan dos horas más y que la jornada tiene 5 horas.Se le pide al usuario que ingrese las horas trabajadas hasta el momento.
    /// </summary>
    private static void CalcularHorasDeTrabajoFaltantes()
    {
        int horasTrabajadas, horasFaltantes;
        string dia;

        Console.Write("Ingrese las horas trabajadas hasta el momento: ");
        horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el dia de la semana: ");
        dia = Console.ReadLine();

        horasFaltantes = 5 - horasTrabajadas;

        dia = dia.ToLower();
        if (dia == "jueves")
        {
            horasFaltantes = horasFaltantes + 2;
            Console.WriteLine($"Faltan {horasFaltantes} horas para terminar la jornada");
        }
        else
        {
            Console.WriteLine($"Faltan {horasFaltantes} horas para terminar la jornada");   
        }
    }

    /// <summary>
    /// Leer tres valores que correspondena un dia, un mes y un año y determinar si se trata de una fecha valida o no
    /// </summary>
    private static void DeterminarFechaValida()
    {
        // Declaramos las variables
        int dia, mes, año;

        // Pedimos los datos al usuario
        Console.Write("Ingrese un dia: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un mes: ");
        mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un año: ");
        año = int.Parse(Console.ReadLine());

        if (año <= 0) Console.WriteLine("El año que ingresaste no es valido");

        // Calculamos si el año es bisiesto o no
        if (año % 4 == 0)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
                {
                    // Que hacer si el año es bisiesto
                    AñoBisiesto(mes, dia);
                }
                else
                {
                    // Que hacer si el año no es bisiesto
                    AñoNoBisiesto(mes, dia);
                }
            }
            else
            {
                // Que hacer si el año es bisiesto
                AñoBisiesto(mes, dia);
            }
        }
        else
        {
            // Que hacer si el año no es bisiesto
            AñoNoBisiesto(mes, dia);
        }

        // Metodo para los años bisiestos
        static void AñoBisiesto(int mes, int dia)
        {
            bool fechaValida = true;

            if (mes <= 12 && mes >= 1)
            {
                if(mes == 2)
                {
                    if (dia > 29) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
                else
                {
                    if (dia > 30 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("La fecha no es valida");
                fechaValida = false;
            }

            if (fechaValida) Console.WriteLine("La fecha que ingresaste es valida");
        }

        // Metodo para los añps no biciestos
        static void AñoNoBisiesto(int mes, int dia)
        {
            bool fechaValida = true;

            if (mes <= 12 && mes >= 1)
            {
                if(mes == 2)
                {
                    if (dia > 28) 
                    {
                        Console.WriteLine("La fecha no es valida"); 
                        fechaValida = false;
                    }
                }

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0) 
                    {
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
                else
                {
                    if (dia > 30 || dia <= 0)
                    { 
                        Console.WriteLine("La fecha no es valida");
                        fechaValida = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("La fecha no es valida");
                fechaValida = false;
            }

            if(fechaValida) Console.WriteLine("La fecha que ingresaste es valida");
        }
    }

    // Creamos un metodo que pida el nombre y apellido del usuario y posteriormente lo salude con "Bienvenido {Apellido}, {Nombre}"
    private static void PedirNombreYSaludar()
    {
        // Declaramos las variables
        string nombre, apellido;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        apellido = Console.ReadLine();


        //Console.WriteLine("Bienvenido "+apellido+", "+nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
    }

    // Creamos un metodo que nos pida los años, meses y dias de vida, y muestre al final la cantidad total de dias de vida
    private static void CalcularDiasDeVida()
    {
        // Declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida: ");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida: ");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus dias de vida: ");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;
        Console.WriteLine($"Los dias de vida totales son: {diasDeVida}");
    }

    /// <summary>
    /// Realizar un algoritmo que imprima el mínimo entre cuatro valores que se piden al usuario.
    /// </summary>
    private static void ImprimirMinimoDe4()
    {
        // Declaramos las variables
        int num1, num2, num3, num4;

        // Pedimos que se ingresen los valores
        Console.Write("Ingrese el primer valor: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer valor: ");
        num3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto valor: ");
        num4 = int.Parse(Console.ReadLine());

        // Resolvemos
        if (num1 < num2 && num1 < num3 && num1 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num1}");

        if (num2 < num1 && num2 < num3 && num2 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num2}");

        if (num3 < num1 && num3 < num2 && num3 < num4) Console.WriteLine($"El valor minimo de los cuatro es {num3}");

        if (num4 < num1 && num4 < num2 && num4 < num2) Console.WriteLine($"El valor minimo de los cuatro es {num4}");
    }

    /// <summary>
    /// Realizar un programa que pida los valores de los tres lados de un triangulo e imprima si el mismo es equilatero, isosceles o escaleno
    /// </summary>
    private static void ImprimirTipoDeTriangulo()
    {
        int lado1, lado2, lado3;

        Console.Write("Ingrese el valor del primer lado: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del segundo lado: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del tercer lado: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es equilatero");
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
        {
            Console.WriteLine("El triangulo es isosceles");
        }
        else
        {
            Console.WriteLine("El triangulo es escaleno");
        }
    }
}