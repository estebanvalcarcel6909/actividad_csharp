
int width = 7;
int height = 5;

// Calcular el area y el perimetro iniciales
int area = width * height;
int perimeter = 2 * width + 2 * height;

// Incrementar el ancho en 3
width += 3;

// Decrementar el alto en 2
height -= 2;

// Recalcular el area y el perimetro
area = width * height;
perimeter = 2 * width + 2 * height;

// Mostrar los valores finales
Console.WriteLine("Ancho final: " + width);
Console.WriteLine("Alto final: " + height);
Console.WriteLine("Area final: " + area);
Console.WriteLine("Perimetro final: " + perimeter);