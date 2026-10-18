
using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine("     SISTEMA DE BIBLIOTECA");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("0. Salir");
            Console.WriteLine("==================================");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    MenuLibros();
                    break;

                case 2:
                    MenuUsuarios();
                    break;

                case 3:
                    MenuPrestamos();
                    break;

                case 4:
                    MenuReportes();
                    break;

                case 5:
                    MenuDatos();
                    break;

                case 0:
                    Salir();
                    break;

                default:
                    Mensaje("Opción no válida. Intenta de nuevo.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    // =====================================
    // MENU DE LIBROS
    // =====================================

    static void MenuLibros()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("========== MENU DE LIBROS ==========");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle de libro");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    RegistrarLibro();
                    break;

                case 2:
                    MenuListarLibros();
                    break;

                case 3:
                    VerDetalleLibro();
                    break;

                case 4:
                    MenuActualizarLibro();
                    break;

                case 5:
                    EliminarLibro();
                    break;

                case 0:
                    break;

                default:
                    Mensaje("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    static void MenuListarLibros()
    {
        Console.WriteLine("\n1. Listar todos los libros");
        Console.WriteLine("2. Listar libros disponibles");
        Console.WriteLine("3. Listar libros prestados");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                ListarTodosLosLibros();
                break;
            case "2":
                ListarLibrosDisponibles();
                break;
            case "3":
                ListarLibrosPrestados();
                break;
            default:
                Mensaje("Opción no válida.");
                break;
        }
    }

    static void MenuActualizarLibro()
    {
        Console.WriteLine("\n1. Editar título");
        Console.WriteLine("2. Editar autor");
        Console.WriteLine("3. Editar año y categoría");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                EditarTituloLibro();
                break;
            case "2":
                EditarAutorLibro();
                break;
            case "3":
                EditarAnioCategoriaLibro();
                break;
            default:
                Mensaje("Opción no válida.");
                break;
        }
    }

    static void RegistrarLibro()
    {
        Mensaje("Función para registrar un libro.");
    }

    static void ListarTodosLosLibros()
    {
        Mensaje("Función para listar todos los libros.");
    }

    static void ListarLibrosDisponibles()
    {
        Mensaje("Función para listar los libros disponibles.");
    }

    static void ListarLibrosPrestados()
    {
        Mensaje("Función para listar los libros prestados.");
    }

    static void VerDetalleLibro()
    {
        Mensaje("Función para consultar el detalle de un libro por ID o ISBN.");
    }

    static void EditarTituloLibro()
    {
        Mensaje("Función para actualizar el título de un libro.");
    }

    static void EditarAutorLibro()
    {
        Mensaje("Función para actualizar el autor de un libro.");
    }

    static void EditarAnioCategoriaLibro()
    {
        Mensaje("Función para actualizar el año y la categoría de un libro.");
    }

    static void EliminarLibro()
    {
        Mensaje("Función para eliminar un libro, validando que no esté prestado.");
    }

    // =====================================
    // MENU DE USUARIOS
    // =====================================

    static void MenuUsuarios()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("========== MENU DE USUARIOS ==========");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle de usuario");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    RegistrarUsuario();
                    break;

                case 2:
                    ListarUsuarios();
                    break;

                case 3:
                    VerDetalleUsuario();
                    break;

                case 4:
                    MenuActualizarUsuario();
                    break;

                case 5:
                    EliminarUsuario();
                    break;

                case 0:
                    break;

                default:
                    Mensaje("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    static void MenuActualizarUsuario()
    {
        Console.WriteLine("\n1. Editar nombre");
        Console.WriteLine("2. Editar contacto");
        Console.WriteLine("3. Activar / desactivar usuario");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                EditarNombreUsuario();
                break;
            case "2":
                EditarContactoUsuario();
                break;
            case "3":
                CambiarEstadoUsuario();
                break;
            default:
                Mensaje("Opción no válida.");
                break;
        }
    }

    static void RegistrarUsuario()
    {
        Mensaje("Función para registrar un usuario.");
    }

    static void ListarUsuarios()
    {
        Mensaje("Función para listar los usuarios registrados.");
    }

    static void VerDetalleUsuario()
    {
        Mensaje("Función para consultar un usuario por ID o documento.");
    }

    static void EditarNombreUsuario()
    {
        Mensaje("Función para actualizar el nombre del usuario.");
    }

    static void EditarContactoUsuario()
    {
        Mensaje("Función para actualizar el teléfono o correo del usuario.");
    }

    static void CambiarEstadoUsuario()
    {
        Mensaje("Función para activar o desactivar un usuario.");
    }

    static void EliminarUsuario()
    {
        Mensaje("Función para eliminar un usuario, validando que no tenga préstamos activos.");
    }

    // =====================================
    // MENU DE PRESTAMOS
    // =====================================

    static void MenuPrestamos()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("========== MENU DE PRESTAMOS ==========");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle de préstamo");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    CrearPrestamo();
                    break;

                case 2:
                    MenuListarPrestamos();
                    break;

                case 3:
                    VerDetallePrestamo();
                    break;

                case 4:
                    RegistrarDevolucion();
                    break;

                case 5:
                    EliminarPrestamo();
                    break;

                case 0:
                    break;

                default:
                    Mensaje("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    static void MenuListarPrestamos()
    {
        Console.WriteLine("\n1. Listar todos los préstamos");
        Console.WriteLine("2. Listar préstamos activos");
        Console.WriteLine("3. Listar préstamos devueltos");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                ListarTodosLosPrestamos();
                break;
            case "2":
                ListarPrestamosActivos();
                break;
            case "3":
                ListarPrestamosCerrados();
                break;
            default:
                Mensaje("Opción no válida.");
                break;
        }
    }

    static void CrearPrestamo()
    {
        Mensaje("Función para crear un préstamo y validar el usuario y el libro.");
    }

    static void ListarTodosLosPrestamos()
    {
        Mensaje("Función para listar todos los préstamos.");
    }

    static void ListarPrestamosActivos()
    {
        Mensaje("Función para listar los préstamos activos.");
    }

    static void ListarPrestamosCerrados()
    {
        Mensaje("Función para listar los préstamos devueltos.");
    }

    static void VerDetallePrestamo()
    {
        Mensaje("Función para consultar el detalle de un préstamo por ID.");
    }

    static void RegistrarDevolucion()
    {
        Mensaje("Función para registrar la devolución de un libro.");
    }

    static void EliminarPrestamo()
    {
        Mensaje("Función para eliminar un préstamo y gestionar el estado del libro.");
    }

    // =====================================
    // BUSQUEDAS Y REPORTES
    // =====================================

    static void MenuReportes()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("======= BUSQUEDAS Y REPORTES =======");
            Console.WriteLine("1. Buscar libro por título");
            Console.WriteLine("2. Buscar libro por autor");
            Console.WriteLine("3. Buscar libro por ID o ISBN");
            Console.WriteLine("4. Buscar libro por categoría");
            Console.WriteLine("5. Buscar usuario por nombre");
            Console.WriteLine("6. Buscar usuario por ID o documento");
            Console.WriteLine("7. Préstamos por usuario");
            Console.WriteLine("8. Préstamos por libro");
            Console.WriteLine("9. Préstamos vencidos");
            Console.WriteLine("10. Resumen general de libros");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    BuscarLibroPorTitulo();
                    break;
                case 2:
                    BuscarLibroPorAutor();
                    break;
                case 3:
                    BuscarLibroPorIdIsbn();
                    break;
                case 4:
                    BuscarLibroPorCategoria();
                    break;
                case 5:
                    BuscarUsuarioPorNombre();
                    break;
                case 6:
                    BuscarUsuarioPorId();
                    break;
                case 7:
                    ReportePrestamosPorUsuario();
                    break;
                case 8:
                    ReportePrestamosPorLibro();
                    break;
                case 9:
                    ReportePrestamosVencidos();
                    break;
                case 10:
                    ReporteResumenGeneral();
                    break;
                case 0:
                    break;
                default:
                    Mensaje("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    static void BuscarLibroPorTitulo()
    {
        Mensaje("Función para buscar un libro por título.");
    }

    static void BuscarLibroPorAutor()
    {
        Mensaje("Función para buscar libros por autor.");
    }

    static void BuscarLibroPorIdIsbn()
    {
        Mensaje("Función para buscar un libro por ID o ISBN.");
    }

    static void BuscarLibroPorCategoria()
    {
        Mensaje("Función para buscar libros por categoría.");
    }

    static void BuscarUsuarioPorNombre()
    {
        Mensaje("Función para buscar usuarios por nombre.");
    }

    static void BuscarUsuarioPorId()
    {
        Mensaje("Función para buscar usuarios por ID o documento.");
    }

    static void ReportePrestamosPorUsuario()
    {
        Mensaje("Función para generar el reporte de préstamos por usuario.");
    }

    static void ReportePrestamosPorLibro()
    {
        Mensaje("Función para generar el reporte de préstamos por libro.");
    }

    static void ReportePrestamosVencidos()
    {
        Mensaje("Función para consultar los préstamos vencidos.");
    }

    static void ReporteResumenGeneral()
    {
        Mensaje("Función para mostrar el total de libros, disponibles y prestados.");
    }

    // =====================================
    // GUARDAR Y CARGAR DATOS
    // =====================================

    static void MenuDatos()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("======= GUARDAR / CARGAR DATOS =======");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("0. Volver al menú principal");
            Console.Write("Selecciona una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    GuardarDatos();
                    break;
                case 2:
                    CargarDatos();
                    break;
                case 3:
                    ReiniciarDatos();
                    break;
                case 0:
                    break;
                default:
                    Mensaje("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Pausar();
            }

        } while (opcion != 0);
    }

    static void GuardarDatos()
    {
        Mensaje("Función para guardar los libros, usuarios y préstamos.");
    }

    static void CargarDatos()
    {
        Mensaje("Función para cargar los datos guardados.");
    }

    static void ReiniciarDatos()
    {
        Console.Write("¿Estás seguro de reiniciar todos los datos? (S/N): ");
        string confirmacion = Console.ReadLine() ?? "";

        if (confirmacion.Equals("S", StringComparison.OrdinalIgnoreCase))
        {
            Mensaje("Función para reiniciar los datos.");
        }
        else
        {
            Mensaje("Operación cancelada.");
        }
    }

    // =====================================
    // FUNCIONES GENERALES
    // =====================================

    static void Salir()
    {
        Console.Write("¿Guardar antes de salir? (S/N): ");
        string respuesta = Console.ReadLine() ?? "";

        if (respuesta.Equals("S", StringComparison.OrdinalIgnoreCase))
        {
            GuardarDatos();
        }

        Mensaje("Gracias por utilizar el sistema de biblioteca.");
    }

    static void Mensaje(string texto)
    {
        Console.WriteLine("\n" + texto);
    }

    static void Pausar()
    {
        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
    }
}