static class Escape
{
       static string[] incognitasSalas = new string[4];
       static int estadoJuego = 1;

    private static void InicializarJuego() {
        incognitasSalas[0] = "";
        incognitasSalas[1] = "";
        incognitasSalas[2] = "";
        incognitasSalas[3] = "";
    }
    public static int GetEstadoJuego() {
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string incognita){

        bool exito;
        if (incognitasSalas == null)
        {
            InicializarJuego();
        }
        if (sala == GetEstadoJuego())
        {
            if(incognitasSalas[sala-1] == incognita)
            {
                exito = true;
                estadoJuego++;
            }
            else {
                exito = false;
            }
        }
        else {
            exito = false;
        }
        return exito;
    }
}