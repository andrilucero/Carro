Carro miCarrito = new Carro("Ford", 2019, "azul", 120);
Carro CarritodeAndri = new Carro("Lamborguini", 2022, "Rojo", 150);



if (miCarrito.Modelo > CarritodeAndri.Modelo)
{
    Console.WriteLine("El carro de mi cuate es mas reciente");
}
else
{
    Console.WriteLine("El carro de Andri es mas reciente");
}


Console.WriteLine($"Andri's car is {CarritodeAndri.Marca}");

Console.WriteLine(CarritodeAndri.GetVelocidadActual());
Console.WriteLine(miCarrito.DameInformacion());
CarritodeAndri.EncenderMotor();

for (int i = 0; i < 15; i++)
{
    CarritodeAndri.acelerar();
}

CarritodeAndri.acelerar(2);
CarritodeAndri.acelerar(4);
CarritodeAndri.acelerar(1);