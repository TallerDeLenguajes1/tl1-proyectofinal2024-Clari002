namespace EspacioPersonaje;

public class Personaje
{
    private string tipo;
    private string nombre;
    private string apodo;
    private DateTime fechaDeNacimiento;
    private int edad;

    //caract
    private int velocidad;
    private int destreza;
    private int fuerza;
    private int nivel;
    private int armadura;
    private int salud;


    public Personaje(string tipo, string nombre, string apodo, DateTime fechaDeNacimiento, int edad, int velocidad, int destreza, int fuerza, int nivel, int armadura, int salud)
    {
        this.tipo=tipo;
        this.nombre=nombre;
        this.apodo=apodo;
        this.fechaDeNacimiento=fechaDeNacimiento;
        this.edad=edad;
        this.velocidad=velocidad;
        this.destreza=destreza;
        this.fuerza=fuerza;
        this.nivel=nivel;
        this.armadura=armadura;
        this.salud=salud;
    }

    public string Tipo { get => tipo; set => tipo = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apodo { get => apodo; set => apodo = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armadura { get => armadura; set => armadura = value; }
    public int Salud { get => salud; set => salud = value; }
}

