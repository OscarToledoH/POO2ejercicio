using EjercicioGato;

internal class Program
{
    private static void Main(string[] args)
    {
        Egipcio egipcio01= new Egipcio();
        egipcio01.Nombre = "Pelusa";
        egipcio01.Color = "Blanco";
        egipcio01.Tamaño="S";
        egipcio01.Peso= 80.5M;

        egipcio01.Comer();
        egipcio01.Jugar();
        egipcio01.Correr();

        Sianes sianes01 = new Sianes();
        sianes01.Nombre ="Lucho";
        sianes01.Color="Negro";
        sianes01.Tamaño="G";
        sianes01.Peso=90.2M;

        sianes01.Comer();
        sianes01.Jugar();
        sianes01.Correr();
        




    }
}


/*Crear la clase chihuahua 
con 4 propiedades que son tamaño , peso , color , nombre
y que tenga el constructor default*/