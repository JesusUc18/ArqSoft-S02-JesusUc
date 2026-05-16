namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly string _categoria;

        private readonly Dictionary<string, List<string>> _palabrasPorCategoria = new()
        {
            ["Arquitectura"] = new() { "arquitectura", "componente", "descomposicion", "dependencia", "acoplamiento" },
            ["POO"] = new() { "polimorfismo", "encapsulamiento", "herencia", "abstraccion", "clase" },
            [".NET"] = new() { "ensamblado", "namespace", "interfaz", "delegado", "middleware" }
        };

        public PalabrasEnMemoria(string categoria)
        {
            _categoria = categoria;
        }

        public string ObtenerPalabraAleatoria()
        {
            var lista = _palabrasPorCategoria[_categoria];
            var random = new Random();
            return lista[random.Next(lista.Count)];
        }
    }
}