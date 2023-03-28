namespace Puntomonoplaza;

public class Circuito
{
    public string Nombre { get; set; }
    public int Vueltas { get; set; }
    public List<Monoplaza> monoplazas { get; set; }
    public Circuito(string nombre, int vueltas)
    {
        this.Nombre = nombre;
        this.Vueltas = vueltas;
        monoplazas = new List<Monoplaza>();
    }
    public void AgregarMonoplaza(Monoplaza monoplaza)
    {
        monoplazas.Add(monoplaza);
    }
    public void SacarMonoplaza(Monoplaza monoplaza)
    {
        monoplazas.Remove(monoplaza);
    }
    public double RealizarPrueba()
    {   
        if (monoplazas == null || monoplazas.Count == 0)
        {
            Console.WriteLine("No se puede iniciar la prueba sin un monoplaza");

        }

        Random azar = new Random();
        double time;
        double mejortiempo = double.MaxValue;

        foreach (var monoplaza in monoplazas)
        {
            monoplaza.Encender();
            monoplaza.Mover();
        }
        bool codigoMostrado = false;

        if (!codigoMostrado)
        {
            for (int i = 0; i < Vueltas; i++)
            {
                time = azar.Next(100000, 500000);
                Console.WriteLine($"En la vuelta {i + 1}: el tiempo es de {time} segundos");

                if (time < mejortiempo)
                    mejortiempo = time;
            }

            foreach (var monoplaza in monoplazas)
            {
                monoplaza.Detener();
                monoplaza.Apagar();
            }

            Console.WriteLine($"El mejor tiempo del monoplaza ha sido: {mejortiempo} segundos");
            codigoMostrado = true;
        }

        return mejortiempo;
    }


    
}
