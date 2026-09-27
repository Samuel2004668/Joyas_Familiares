class Asistente : Npc
{
    public Asistente() : base("Asistente", "Joyeria", true, "Herencia")
    {
        respuestasArray = new string[]
        {
            "Coartada? Bueno, estaba llegando aqui cuando todavia no reportaban la muerte del senor Rothschild. Al momento del crimen, yo denuncie la desaparicion de las joyas de la difunta senora Rothschild desde la joyeria.",
            "La herencia y la sucesion de la empresa del senor Rothschild iba dirigida unicamente a la senorita Ana, puesta la renuncia a la herencia del senor Joseph y la sugerencia de la senorita Lucy.",
            "El senor Rothschild era un hombre inteligente, humilde y muy buen jefe. Si me pregunta como me parecio como padre, diria que fue un gran padre, comparado con muchos padres adinerados.",
            "Eran las joyas de la difunta senora Rothschild. El senor coloco su collar y brazalete en un altar de exposicion como manera de respeto y tributo.",
            "Los hijos e hijas del senor Rothschild son altamente capacitados para manejar sus respectivos negocios, sin olvidar que la senorita Ana, al graduarse, tomara el mando de la empresa.",
            "No estoy seguro. El senor no tenia practicamente ningun enemigo o rival hasta donde yo se. Y solo el y sus hijos tenian acceso a las joyas.",
            "Por favor, descubra quien fue y asegurese de traer de regreso las joyas. Nos aseguraremos de presentarlas como tributo a los fundadores de esta empresa.",
            "Le deseo suerte, Detective " + Program.nombre + "."
        };
    }
}
