class Policia : Npc
{
    public Policia() : base("Policia", "Mansion", true, "Frasco de Veneno")
    {
        respuestasArray = new string[]
        {
            "Llegamos a la mansion a las 11:50 p.m. La empleada nos llamo.",
            "No sabemos quien hereda nada todavia. Eso lo vera el abogado.",
            "La victima fue envenenada. El medico forense ya hizo el reporte.",
            "Robaron un anillo y un colgante de la joyeria principal.",
            "Los cinco hijos estaban en la casa esa noche. Ninguno se ha ido.",
            "Sospechamos de alguien de la familia. Nadie mas tenia acceso.",
            "Revise el despacho, detective. Hay algo en el suelo que no hemos tocado.",
            "Buena suerte, Detective " + Program.nombre + "."
        };
    }
}
