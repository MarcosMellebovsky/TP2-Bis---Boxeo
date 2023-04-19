int opciones; 
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();
Console.Clear();
do
{
System.Console.WriteLine("A que opcion desea entrar: ");
System.Console.WriteLine("Opcion 1: Cargar Datos Boxeador 1:");
System.Console.WriteLine("Opcion 2: Cargar Datos Boxeador 2: ");
System.Console.WriteLine("Opcion 3: Pelear!");
System.Console.WriteLine("Opcion 4: Salir");
opciones = int.Parse(Console.ReadLine());
switch (opciones)
{
    case 1:
    boxeador1 = CargarBoxeador();
    break;
    case 2:
    boxeador2 = CargarBoxeador();
    break;
    case 3:
    Pelear();
    break;
    
} 
} while (opciones != 4);
Boxeador CargarBoxeador()
{
    string nombre = Funciones.IngresarTexto("Ingrese su nombre: ");
    string pais = Funciones.IngresarTexto("Ingrese su Pais: ");
    double peso = ingresarPeso("Ingrese su Peso: ");
    int potenciaGolpes = ingresarNumero("Ingrese la potencia de sus golpes: ");
    int velocidadPiernas = ingresarNumero("Ingrese la Velocidad de las piernas: ");
    Boxeador boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas);
    System.Console.WriteLine("Se ha creado el boxeador: " + nombre);
    Console.ReadLine();
    return boxeador;
}
int ingresarNumero(string msj)
{
    int numDevolver;
    System.Console.WriteLine(msj);
    numDevolver = int.Parse(Console.ReadLine());
    while (numDevolver < 0 || numDevolver > 100)
    {
        System.Console.WriteLine("Ingresaste mal los datos, volve a hacerlo");
        System.Console.WriteLine(msj);
        numDevolver = int.Parse(Console.ReadLine());
    }
    return numDevolver;
}
double ingresarPeso(String msj)
{
    double peso;
    Console.WriteLine(msj);
    peso = double.Parse(Console.ReadLine());
    return peso;
}

void Pelear()
{
    if (boxeador1.Nombre == "" || boxeador2.Nombre == "")
    {
        System.Console.WriteLine("Boxeador no existente, volve a ingresarlo! ");
    }
    else
    {
        buscarGanador();
    }
}
void buscarGanador()
{
    if (boxeador1.ObtenerSkill() > boxeador2.ObtenerSkill())
    {
        if (boxeador1.ObtenerSkill() - boxeador2.ObtenerSkill() >= 30)
        {
            Console.WriteLine("Gana " + boxeador1.Nombre + " por KO");
        }
          else if(boxeador1.ObtenerSkill() - boxeador2.ObtenerSkill() >= 10 && boxeador1.ObtenerSkill() - boxeador2.ObtenerSkill() < 30)
        {
            Console.WriteLine("Gana " + boxeador1.Nombre + " por puntos en fallo unanime");
        }
        else
        {
            Console.WriteLine("Gana " + boxeador1.Nombre + " por puntos en fallo dividido");
        }
    }
    else
    {
        if (boxeador2.ObtenerSkill() > boxeador1.ObtenerSkill())
    {
        if (boxeador2.ObtenerSkill() - boxeador1.ObtenerSkill() >= 30)
        {
            Console.WriteLine("Gana " + boxeador2.Nombre + " por KO");
        }
          else if(boxeador2.ObtenerSkill() - boxeador1.ObtenerSkill() >= 10 && boxeador2.ObtenerSkill() - boxeador1.ObtenerSkill() < 30)
        {
            Console.WriteLine("Gana " + boxeador2.Nombre + " por puntos en fallo unanime");
        }
        else
        {
            Console.WriteLine("Gana " + boxeador2.Nombre + " por puntos en fallo dividido");
        }
    }
    }
}