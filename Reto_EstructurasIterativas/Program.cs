
int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

// ==========================================
// SECCION 1: FOR Y FOREACH
// ==========================================

Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}

Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

for (int i = calificaciones.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
}

int sumaTotal = 0;

foreach (int nota in calificaciones)
{
    sumaTotal += nota;
}

double promedio = (double)sumaTotal / calificaciones.Length;

Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");
Console.WriteLine($"Suma total: {sumaTotal}");
Console.WriteLine($"Promedio: {promedio:F1}");

Console.WriteLine("\n=== POSICIONES PARES ===");

for (int i = 0; i < calificaciones.Length; i += 2)
{
    Console.WriteLine($"Posición par: {calificaciones[i]}");
}

// ==========================================
// SECCION 2: WHILE Y DO-WHILE
// ==========================================

Console.WriteLine("\n=== CONTROL DE ACCESO ===");

int intentos = 0;
string clave = "sena2025";
bool accesoConcedido = false;

while (intentos < 3 && !accesoConcedido)
{
    Console.Write("Ingresa la clave: ");
    string claveIngresada = Console.ReadLine() ?? "";

    intentos++;

    if (claveIngresada == clave)
    {
        accesoConcedido = true;
        Console.WriteLine("Acceso concedido.");
    }
    else if (intentos < 3)
    {
        Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
    }
}

if (!accesoConcedido)
{
    Console.WriteLine("Acceso bloqueado.");
}

Console.WriteLine("\n=== MENÚ PRINCIPAL ===");

int opcion;

do
{
    Console.WriteLine("\n1. Ver promedio del grupo");
    Console.WriteLine("2. Ver calificación más alta");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");

    string entrada = Console.ReadLine() ?? "";

    if (!int.TryParse(entrada, out opcion))
    {
        opcion = 0;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Promedio del grupo: {promedio:F1}");
            break;

        case 2:
            int notaMaxima = calificaciones[0];

            foreach (int nota in calificaciones)
            {
                if (nota > notaMaxima)
                {
                    notaMaxima = nota;
                }
            }

            Console.WriteLine($"Calificación más alta: {notaMaxima}");
            break;

        case 3:
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
    }

} while (opcion != 3);

// ==========================================
// SECCION 3: BREAK Y CONTINUE
// ==========================================

Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 60)
    {
        Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
        break;
    }
}

Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

int totalAprobados = 0;

foreach (int nota in calificaciones)
{
    if (nota < 60)
    {
        continue;
    }

    Console.WriteLine($"Aprobado: {nota}");
    totalAprobados++;
}

Console.WriteLine($"Total aprobados: {totalAprobados}");

Console.WriteLine("\n=== FILTRO COMBINADO ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    int nota = calificaciones[i];

    if (nota >= 95)
    {
        Console.WriteLine($"Búsqueda detenida al encontrar: {nota}");
        break;
    }

    if (nota < 70)
    {
        continue;
    }

    Console.WriteLine($"Calificación procesada: {nota}");
}