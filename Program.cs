Console.WriteLine("=== AHORCADO ===");

// Pedir categoría
var uiTemporal = new Ahorcado.ConsolaUI(null!); // solo para reutilizar el método
// — o simplemente inline:
var categorias = Ahorcado.PalabrasEnMemoria.ObtenerCategorias();
Console.WriteLine("Elige una categoría:");
var lista = categorias.ToList();
for (int i = 0; i < lista.Count; i++)
    Console.WriteLine($"  {i + 1}. {lista[i]}");

string categoriaElegida;
while (true)
{
    Console.Write("Opción: ");
    if (int.TryParse(Console.ReadLine(), out int op) && op >= 1 && op <= lista.Count)
    { categoriaElegida = lista[op - 1]; break; }
    Console.WriteLine("Opción inválida.");
}

var repositorio = new Ahorcado.PalabrasEnMemoria(categoriaElegida);
var motor = new Ahorcado.MotorAhorcado(repositorio);
var ui = new Ahorcado.ConsolaUI(motor);

while (!motor.Ganado() && !motor.Perdido())
{
    ui.MostrarTablero();
    char letra = ui.PedirLetra();
    if (motor.LetraYaUsada(letra)) { ui.MostrarMensaje("Ya usaste esa letra."); continue; }
    motor.RegistrarLetra(letra);
}

ui.MostrarTablero();
if (motor.Ganado())
    ui.MostrarMensaje($"\n¡Ganaste! La palabra era: {motor.PalabraSecreta}");
else
    ui.MostrarMensaje($"\nPerdiste. La palabra era: {motor.PalabraSecreta}");

if (ui.PreguntarOtraVez())
{
    var nuevoRepositorio = new Ahorcado.PalabrasEnMemoria(categoriaElegida);
    var nuevoMotor = new Ahorcado.MotorAhorcado(nuevoRepositorio);
    var nuevaUI = new Ahorcado.ConsolaUI(nuevoMotor);
}