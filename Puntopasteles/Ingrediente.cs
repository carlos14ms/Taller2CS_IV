namespace Puntopasteles{
public class Ingrediente:Iingredientes {
    public Ingrediente(string Nombre, int Cantidad, float Precio){
        this.Nombre = Nombre;
        this.Cantidad = Cantidad;
        this.Precio = Precio;
    }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public float Precio { get; set; }
    
}
}