class Michael : Npc
{
    public Michael() : base("Michael", "Mansion", false, "")
    {
        respuestasArray = new string[]
        {
            "Me encontraba en una reunion con unos empresarios en la sala de reuniones de la mansion.",
            "Mi padre nos dejo ciertas propiedades para cada uno de nosotros...",
            "Mi padre era un hombre muy inteligente, supo construir su fortuna desde joven y creo su fama como dueno de una empresa de joyas enorme y reconocida mundialmente.",
            "Un collar y un brazalete? Se de unas joyas hereditarias que mi padre confecciono para cada uno de nosotros, pero no tengo ni la mas minima idea de un robo de dichas pertenencias.",
            "Si mis hermanos son sospechosos? No lo dudaria, pero la verdad no encuentro razon alguna para que alguno de nosotros fuera causante de su muerte.",
            "Personalmente, alguno de los empleados o tal vez Anna. No se, la verdad es muy confuso.",
            "Confio plenamente en usted, detective, y espero que encuentre al responsable de la muerte de mi querido padre.",
            "Que tenga una buena noche, Detective " + Program.nombre + "."
        };
    }
}
