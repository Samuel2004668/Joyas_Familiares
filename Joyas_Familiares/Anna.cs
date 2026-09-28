class Anna : Npc
{
    public Anna() : base("Ana", "Comisaria", true, "Grabaciones")
    {
        respuestasArray = new string[]
        {
            "Estaba estudiando en la universidad cuando me llego la noticia... Es algo que nunca en mi vida hubiera esperado. Pero de cierto modo espero que este feliz donde este.",
            "Si... papa me iba a dejar su fortuna... Como mis hermanos y hermana ya tenian exito en sus negocios, el decidio que como ultimo deseo de voluntad me dejaria a cargo del negocio familiar.",
            "Mi papa era... dificil. Exigente... Aunque en su mayoria era asi conmigo, porque esperaba dejarme sus cosas. Aun asi era buen padre, no falto nunca y siempre nos apoyo.",
            "El anillo y el colgante eran de mi mama... Cuando ella fallecio, papa los decidio dejar en exposicion en la tienda principal como un tributo en su honor, para que su memoria siguiera con vida.",
            "Joseph es algo serio, pero es de esperarse, ya que fue el primero en tener exito. Lucy siempre ha sido muy cercana a mi. Michael y Jakov... tanto Michael como Jakov fracasaron poco despues de comenzar sus empresas. Por eso papa decidio dejarme a mi de sucesora...",
            "Yo... no quiero acusar a nadie sin pruebas... Pero Jakov y Michael son de los que mas desconfio. Cuando nos dio a conocer su eleccion sobre la herencia, Michael y Jakov no estuvieron tan felices. Temo que sus celos y codicia los lleven demasiado lejos...",
            "En cualquier caso, pedi que el asistente de papa me consiguiera grabaciones de la joyeria. Y mientras buscaba, encontro esta en la que aparecen Michael y Jakov con papa... No he visto nada, ya que queria darsela a usted, detective. Tenga.",
            "Gracias por escucharme, detective " + Program.nombre + "..."
        };
    }
}