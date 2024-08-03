using EjercicioInterfaces;

Operacion operaciones = new Operacion();
Console.WriteLine("Operaciones matematicas");
Console.WriteLine();
Console.WriteLine("************************");
Console.WriteLine();

Console.WriteLine("Area de Cuadrado:");
Console.WriteLine("************************");
Console.WriteLine("Ingrese un numero para calcular el area de un cuadrado");
operaciones.area = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Perimetro de un Cuadrado:");
Console.WriteLine("************************");
Console.WriteLine("Ingrese un numero para calcular el perimetro de un cuadrado");
operaciones.perimetro = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Volumen de un cubo");
Console.WriteLine("************************");
Console.WriteLine("Ingrese un numero para calcular el volumen de un cubo");
operaciones.volumen = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Calculara IMC");
Console.WriteLine("************************");
Console.WriteLine("Ingrese su peso corporal");
operaciones.peso = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su altura");
operaciones.altura = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Calcular velocidad promedio");
Console.WriteLine("************************");
Console.WriteLine("Ingrese la distancia que recorrera:");
operaciones.distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tiempo que tardara en llegar a su destino");
operaciones.tiempo = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Resultados");
Console.WriteLine("************************");
Console.WriteLine();
operaciones.Imprimir(operaciones.area, operaciones.perimetro, operaciones.volumen,
    operaciones.peso,operaciones.altura);

Console.ReadKey();