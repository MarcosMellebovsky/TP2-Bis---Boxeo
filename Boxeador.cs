class Boxeador
{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public double Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}
    
    public Boxeador(string nom, string pa, double pe, int PG, int VP)
    {
        Nombre = nom;
        Pais = pa;
        Peso = PG;
        PotenciaGolpes = PG;
        VelocidadPiernas = VP;
    }
    public Boxeador()
    {

    }
    public double ObtenerSkill()
    {
       
        Random num = new Random();
        double numero = num.Next(1, 10);
        double skill = 0;
        skill = numero + VelocidadPiernas/10 * 6 + PotenciaGolpes /10 * 6;
        return skill;
    }
}

