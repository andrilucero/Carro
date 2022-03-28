internal class Carro
{
    public string Marca { get; }
    public int Modelo { get; }

    public String Color { get; set; }
    public string Frenar { get; }

    private int Encendido = 0;
    private int velocidad_actual = 0;
    public int MAXVELOCIDAD { get;}






    public Carro(string _marca, int _modelo, string _color, int velocidmax)
    {
        Marca = _marca;
        Modelo = _modelo;
        Color = _color;
        Encendido = 0;
        MAXVELOCIDAD = velocidmax;
        this.velocidad_actual = 0;
    }



    public string acelerar()
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += 5;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Hey que ondas, vas a maxima velocidad, no te creas Vin Diesel!";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }



    public string acelerar(int AcelerarAkph)
    {
        if (Encendido == 0)
        {
            return $"El carro esta apagado, asi no se puede";
        }


        string mensaje = "";
        if (velocidad_actual <= MAXVELOCIDAD)
        {
            velocidad_actual += AcelerarAkph;
            mensaje = $"vas a {velocidad_actual} KPH";
        }
        else
        {
            velocidad_actual = MAXVELOCIDAD;
            mensaje = "Relajese mijo se va accidentar!";
        }

        Console.WriteLine(mensaje);
        return mensaje;

    }

    public void freno(int frenar)

    {
        if (velocidad_actual == 0)

            Console.WriteLine("Que ondas frenaste el carro?");


    }

    public string GetVelocidadActual()
    {
        return $"Vamos a {velocidad_actual}KPH";
    }


    public void EncenderMotor()
    {
        if (Encendido == 0)
        {
            Encendido = 1;
            Console.WriteLine("Brururururururu carro encendido!!");
            velocidad_actual = 0;

        }
        else
        {
            Console.WriteLine("y que ondas? el carro ya estaba encendido");
        }
    }






    public string DameInformacion()
    {
        return ($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
    }

}