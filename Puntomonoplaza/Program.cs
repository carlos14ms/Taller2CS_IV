namespace Puntomonoplaza
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Monoplaza> vehiculo = new List<Monoplaza> { new McLaren(), new Ferrari(), new RedBull() };
            Circuito pista1 = new Circuito("IndyCar", 2);
            Dictionary<string, double> resultado = new Dictionary<string, double>();

            foreach (Monoplaza monoplaza in vehiculo)
            {
                Console.WriteLine("El el circuito: "+pista1.Nombre);
                pista1.AgregarMonoplaza(monoplaza);
                double mejortiempo = pista1.RealizarPrueba();
                resultado.Add(monoplaza.Escuderia, mejortiempo);
                pista1.SacarMonoplaza(monoplaza);
            }
        }
    }
}

