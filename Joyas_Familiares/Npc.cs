public class Npc
{
    public string nombre = "";
    public string ubicacion = "";
    public bool tienePista = false;
    public bool pistaEntregada = false;
    public bool yaHable = false;
    public string pista = "";
    public int preguntasHechas = 0;
    public string[] respuestasArray = new string[0];
    public string[] opcionesArray = new string[0];

    public Npc(string nom, string ubi, bool pistaBool, string pistaTexto)
    {
        nombre = nom;
        ubicacion = ubi;
        tienePista = pistaBool;
        pistaEntregada = false;
        yaHable = false;
        pista = pistaTexto;
        preguntasHechas = 0;

        opcionesArray = new string[8];
        opcionesArray[0] = "1) Preguntar por su coartada";
        opcionesArray[1] = "2) Preguntar por la herencia";
        opcionesArray[2] = "3) Preguntar por su padre";
        opcionesArray[3] = "4) Preguntar por las joyas";
        opcionesArray[4] = "5) Preguntar por sus hermanos";
        opcionesArray[5] = "6) Preguntar quien cree que fue";
        opcionesArray[6] = "7) Hablar de la investigacion";
        opcionesArray[7] = "8) Despedirse";
    }

    public bool EntregarPista()
    {
        if (tienePista == true && pistaEntregada == false && preguntasHechas >= 3)
        {
            Console.WriteLine();
            Console.WriteLine(">>> PISTA OBTENIDA: " + pista);
            pistaEntregada = true;
            return true;
        }
        return false;
    }

    public void Dialogo()
    {
        yaHable = true;

        Console.WriteLine();
        Console.WriteLine(nombre + " te mira.");
        string opcion = "0";

        while (opcion != "8")
        {
            Console.WriteLine();
            for (int i = 0; i < opcionesArray.Length; i++)
            {
                Console.WriteLine(opcionesArray[i]);
            }

            opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[0]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "2")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[1]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "3")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[2]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "4")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[3]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "5")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[4]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "6")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[5]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "7")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[6]);
                preguntasHechas = preguntasHechas + 1;
            }
            else if (opcion == "8")
            {
                Console.WriteLine(nombre + ": " + respuestasArray[7]);
                bool dioPista = EntregarPista();
                if (dioPista == true)
                {
                    Program.pistasRecolectadas = Program.pistasRecolectadas + 1;
                }
            }
            else
            {
                Console.WriteLine("Esa no es una opcion valida.");
            }
        }
    }
}
