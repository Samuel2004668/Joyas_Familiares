public class Program
{
    public static string nombre = "";
    public static int pistasRecolectadas = 0;
    public static string escenarioActual = "Mansion";
    public static bool puedeViajar = false;
    public static bool sobornoAceptado = false;
    public static Npc[] todosLosNpcs = new Npc[0];
    public static Escenario[] todosLosEscenarios = new Escenario[0];

    public static void Main()
    {
        CrearNpcs();
        CrearEscenarios();
        Intro();
        LoopJuego();
        Finales();
    }

    public static void CrearNpcs()
    {
        todosLosNpcs = new Npc[8];
        todosLosNpcs[0] = new Michael();
        todosLosNpcs[1] = new Jakov();
        todosLosNpcs[2] = new Lucy();
        todosLosNpcs[3] = new Joseph();
        todosLosNpcs[4] = new Asistente();
        todosLosNpcs[5] = new Ana();
        todosLosNpcs[6] = new Policia();
        todosLosNpcs[7] = new Policia2();
    }

    public static void CrearEscenarios()
    {
        todosLosEscenarios = new Escenario[3];
        todosLosEscenarios[0] = new Mansion();
        todosLosEscenarios[1] = new Joyeria();
        todosLosEscenarios[2] = new Comisaria();
    }

    public static void Intro()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        JOYAS FAMILIARES");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("Medellin, Colombia. Ano 2000.");
        Console.WriteLine("Un magnate joyero ha sido envenenado en su mansion.");
        Console.WriteLine("Sus cinco hijos eran los unicos en la casa esa noche.");
        Console.WriteLine("Ademas, robaron un anillo y un colgante.");
        Console.WriteLine();
        Console.WriteLine("Te han contratado como detective privado.");
        Console.WriteLine();
        Console.Write("Antes de comenzar, detective, digame su nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Bienvenido, Detective " + nombre + ".");
        Console.WriteLine("Debes recolectar 5 pistas para resolver el caso.");
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para comenzar...");
        Console.ReadLine();
    }

    public static void LoopJuego()
    {
        while (pistasRecolectadas < 5)
        {
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("Escenario actual: " + escenarioActual);
            Console.WriteLine("Pistas recolectadas: " + pistasRecolectadas + "/5");
            Console.WriteLine("========================================");
            MostrarEscenarioActual();

            Console.WriteLine();
            Console.WriteLine("1) Hablar con alguien");
            Console.WriteLine("2) Viajar a otro escenario");
            Console.WriteLine("3) Ver pistas recolectadas");
            Console.WriteLine("0) Esperar");

            string opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                SeleccionarNpc();
            }
            else if (opcion == "2")
            {
                if (puedeViajar == true)
                {
                    Viajar();
                }
                else
                {
                    Console.WriteLine(">>> Primero habla con al menos 2 personas en la mansion.");
                }
            }
            else if (opcion == "3")
            {
                MostrarPistas();
            }
            else if (opcion == "0")
            {
                Console.WriteLine("Observas la escena con calma...");
            }
            else
            {
                Console.WriteLine("Esa no es una opcion valida.");
            }
        }
    }

    public static void MostrarEscenarioActual()
    {
        for (int i = 0; i < todosLosEscenarios.Length; i++)
        {
            if (todosLosEscenarios[i].nombre == escenarioActual)
            {
                todosLosEscenarios[i].Mostrar();
            }
        }
    }

    public static void SeleccionarNpc()
    {
        Npc[] disponibles = new Npc[8];
        int cantidad = 0;

        for (int i = 0; i < todosLosNpcs.Length; i++)
        {
            if (todosLosNpcs[i].ubicacion == escenarioActual)
            {
                disponibles[cantidad] = todosLosNpcs[i];
                cantidad = cantidad + 1;
            }
        }

        if (cantidad == 0)
        {
            Console.WriteLine("No hay nadie con quien hablar aqui.");
            return;
        }

        Console.WriteLine("=== Personas en " + escenarioActual + " ===");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine((i + 1) + ") " + disponibles[i].nombre);
        }
        Console.WriteLine("0) Volver");

        string opcion = Console.ReadLine();
        Console.WriteLine();

        if (opcion == "0")
        {
            return;
        }

        int numero = 0;
        bool valido = false;

        if (opcion == "1") { numero = 1; valido = true; }
        if (opcion == "2") { numero = 2; valido = true; }
        if (opcion == "3") { numero = 3; valido = true; }
        if (opcion == "4") { numero = 4; valido = true; }
        if (opcion == "5") { numero = 5; valido = true; }
        if (opcion == "6") { numero = 6; valido = true; }
        if (opcion == "7") { numero = 7; valido = true; }
        if (opcion == "8") { numero = 8; valido = true; }

        if (valido == true && numero <= cantidad)
        {
            disponibles[numero - 1].Dialogo();
            VerificarProgreso();
        }
        else
        {
            Console.WriteLine("Esa no es una opcion valida.");
        }
    }

    public static void VerificarProgreso()
    {
        if (puedeViajar == true)
        {
            return;
        }

        int contador = 0;
        for (int i = 0; i < todosLosNpcs.Length; i++)
        {
            if (todosLosNpcs[i].ubicacion == "Mansion" && todosLosNpcs[i].yaHable == true)
            {
                contador = contador + 1;
            }
        }

        if (contador >= 2)
        {
            puedeViajar = true;
            Console.WriteLine();
            Console.WriteLine(">>> Ya puedes viajar a otros escenarios.");
        }
    }

    public static void Viajar()
    {
        Console.WriteLine("=== A donde quieres ir? ===");
        Console.WriteLine("1) Mansion");
        Console.WriteLine("2) Joyeria");
        Console.WriteLine("3) Comisaria");
        Console.WriteLine("0) Cancelar");

        string opcion = Console.ReadLine();
        Console.WriteLine();

        if (opcion == "1")
        {
            escenarioActual = "Mansion";
        }
        else if (opcion == "2")
        {
            escenarioActual = "Joyeria";
        }
        else if (opcion == "3")
        {
            escenarioActual = "Comisaria";
        }
        else if (opcion == "0")
        {
            return;
        }
        else
        {
            Console.WriteLine("Esa no es una opcion valida.");
        }
    }

    public static void MostrarPistas()
    {
        Console.WriteLine("=== Pistas recolectadas ===");
        int contador = 0;

        for (int i = 0; i < todosLosNpcs.Length; i++)
        {
            if (todosLosNpcs[i].pistaEntregada == true)
            {
                contador = contador + 1;
                Console.WriteLine(contador + ") " + todosLosNpcs[i].pista);
            }
        }

        if (contador == 0)
        {
            Console.WriteLine("Todavia no has recolectado ninguna pista.");
        }
    }

    public static void Finales()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("Has recolectado las 5 pistas necesarias.");
        Console.WriteLine("Es hora de tomar una decision.");
        Console.WriteLine("========================================");
        Console.WriteLine();
        Console.WriteLine("1) Seguir investigando por tu cuenta");
        Console.WriteLine("2) Perseguir a los hermanos culpables");

        string opcion = Console.ReadLine();
        Console.WriteLine();

        if (opcion == "1")
        {
            FinalMuerte();
        }
        else if (opcion == "2")
        {
            Console.WriteLine("Encuentras a Michael y Jakov en la mansion.");
            Console.WriteLine("Ellos te ofrecen 3 millones de dolares para que los dejes libres.");
            Console.WriteLine();
            Console.WriteLine("1) Arrestarlos y seguir la ley");
            Console.WriteLine("2) Aceptar el soborno");

            string sub = Console.ReadLine();
            Console.WriteLine();

            if (sub == "1")
            {
                FinalArresto();
            }
            else if (sub == "2")
            {
                FinalSoborno();
            }
            else
            {
                Console.WriteLine("Dudas demasiado. Los hermanos escapan.");
            }
        }
        else
        {
            Console.WriteLine("No tomas una decision a tiempo. El caso queda sin resolver.");
        }
    }

    public static void FinalArresto()
    {
        Console.WriteLine();
        Console.WriteLine(">>> FINAL A: ARRESTO DE LOS CULPABLES");
        Console.WriteLine("Reunes las pruebas y arrestas a Michael y Jakov");
        Console.WriteLine("por el robo y el asesinato de su padre.");
        Console.WriteLine("La justicia se cumple. El caso se cierra.");
        Console.ReadLine();
    }

    public static void FinalSoborno()
    {
        sobornoAceptado = true;
        Console.WriteLine();
        Console.WriteLine(">>> FINAL B: DETECTIVE CORRUPTO");
        Console.WriteLine("Aceptas los 3 millones de dolares.");
        Console.WriteLine("Michael y Jakov quedan libres.");
        Console.WriteLine("Destruyes todas las pruebas. Te vuelves corrupto.");
        Console.WriteLine("El caso se cierra falsamente.");
        Console.ReadLine();
    }

    public static void FinalMuerte()
    {
        Console.WriteLine();
        Console.WriteLine(">>> FINAL C: MUERTE EN LA TRAMPA");
        Console.WriteLine("Sigues investigando por tu cuenta.");
        Console.WriteLine("Michael y Jakov te tienden una trampa.");
        Console.WriteLine("El detective muere antes de poder arrestarlos.");
        Console.ReadLine();
    }
}