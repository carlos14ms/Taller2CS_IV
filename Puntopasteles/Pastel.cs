
namespace Puntopasteles{
    public class Pastel {
    public string nombre;
    public string tamaño;
    public List<Ingrediente> ListaIngredientes = new List<Ingrediente>();
    
    public Pastel(string Nombre,string tamaño) {
        this.nombre = Nombre;
        this.tamaño = tamaño;
    }
    
    public void agregarIngrediente(Ingrediente ingrediente) {
        this.ListaIngredientes.Add(ingrediente);
    }

    public void EliminarIngrediente(Ingrediente ingrediente){
        this.ListaIngredientes.Remove(ingrediente);
    }  
    
    public int cantidadDeIngredientes() {
        return this.ListaIngredientes.Count;
    }
    
    public string listarIngredientes() {
        string lista = "";
        foreach (Ingrediente ingrediente in ListaIngredientes) {
            lista += ingrediente.Cantidad +"  " + ingrediente.Nombre + "\n";
        }
        return lista;
    }
    
    public float Costepastel() {
        float costo = 0;
        foreach (Ingrediente ingrediente in ListaIngredientes) {
            costo += ingrediente.Cantidad * ingrediente.Precio;
        }
        return costo; 
    } 
    
    
    
}
}