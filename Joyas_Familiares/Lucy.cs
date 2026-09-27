class Lucy : Npc
{
    public Lucy() : base("Lucy", "Joyeria", false, "")
    {
        respuestasArray = new string[]
        {
            "Bueno, yo me encontraba descansando por el trabajo extensivo de hoy, ya que mi empresa esta en la otra punta de la ciudad. En casos especiales, cuando trabajo hasta tarde, me quedo en un apartamento cerca de la empresa.",
            "Herencia igualada para cada uno? A que se refiere? Quien le haya dicho esto es una mentira. Ya hay un heredero, y personalmente no podria estar mas feliz por ella. Despues de todo, yo se la sugeri a mi padre.",
            "Papa era... alguien que si bien podia llegar a ser algo complicado en algunos casos con nosotros, era muy carinoso y siempre se preocupaba por nosotros. De pronto Ana piense que el era algo estricto, pero era porque desde siempre la tenia en consideracion como sucesora.",
            "Se perdieron unas joyas? No lo sabia. De hecho vine corriendo en cuanto supe que fallecio, pero porque pense que fue aqui en la joyeria, no en casa... Eso es demasiado raro.",
            "Mis hermanos son muy distintos entre si. Joseph es el mas maduro por ser el mayor, aunque eso no evita que sea competitivo. Michael y Jakov han sido los unicos que fracasaron con sus empresas. Finalmente Ana esta estudiando en la universidad, parte del plan de papa.",
            "Odiaria sospechar de alguno de mis hermanos, mas porque papa siempre nos trato como iguales. Tal vez trato a Ana con mas carino, pero por razones mas personales.",
            "Confio en sus habilidades, detective, asi que por favor encuentre al asesino de mi padre.",
            "Cuidese mucho, Detective " + Program.nombre + ", y buena suerte."
        };
    }
}
