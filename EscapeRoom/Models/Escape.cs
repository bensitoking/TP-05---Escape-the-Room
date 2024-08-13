static class Escape
{
    static string[] incognitasSalas = new string[4];
    static int estadoJuego = 1;

    public static void InicializarJuego() {
        incognitasSalas[0] = "Rosquillas";    
        incognitasSalas[1] = "Llamarada Moe"; 
        incognitasSalas[2] = "Don Barredora"; 
        incognitasSalas[3] = "Max Power";    
        estadoJuego = 1;
    }

    public static int GetEstadoJuego() {
        return estadoJuego;
    }

    public static bool ResolverSala(int sala, string incognita){

        bool exito;
        if (incognitasSalas[0] == null)
        {
            InicializarJuego();

        }
        if (sala == GetEstadoJuego())
        {
            if (incognitasSalas[sala - 1].Equals(incognita, StringComparison.OrdinalIgnoreCase))
            {
                exito = true;
                estadoJuego++;
            }
            else 
            {
                exito = false;
            }
        }
        else 
        {
            exito = false;
        }
        return exito;
    }
}