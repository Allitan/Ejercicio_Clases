

namespace Ejercicio_Clases
{
    public class SuperHeroe : SuperPoder
    {
        public string? Nombre {  get; set; }
        public string? IdentidadSecreta { get; set; }
        public string? Ciudad {  get; set; }
        public bool PuedeVolar {  get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Si" : "No")}");
            Console.WriteLine($"Super Poder: {SuperPode} ");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Nivel: {Nivel} ");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
