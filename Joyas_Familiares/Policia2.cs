class Policia2 : Npc
{
    public Policia2() : base("Policia2", "Comisaria", true, "Cuentas Bancarias de los hijos responsables del crimen")
    {
        respuestasArray = new string[]
        {
            "Estoy vigilando a la testigo. Anna no se mueve de aqui.",
            "La hija menor es la principal heredera, segun el testamento.",
            "El caso es muy reciente. Apenas tenemos reportes.",
            "Las joyas no aparecen. Ni en la mansion ni en la joyeria.",
            "Los hijos estan dispersos, pero todos han declarado ya.",
            "Sospechamos de los desheredados, pero no podemos arrestar sin pruebas.",
            "Vea las grabaciones, detective. Y revise las cuentas bancarias. Algo no cuadra con dos de los hijos.",
            "Cuidese, Detective " + Program.nombre + "."
        };
    }
}
