namespace EmsambladoraVehiculos2.Molde
{
    public class MoldeAvion = MoldeVehiculoHijo
    {
    
     public int Altura { get; set; }

       
     public MoldeAvion(int _numPuertas, int _numllantas, string _color, string _marca)
          : base(_numPuertas, _numllantas, _numllantas, _color, _marca)
    {
    }

    public MoldeAvion(int _numPuertas, int _numllantas, string _marca)
        : base(_numPuertas, _numPuertas, _marca)
    {
    }

    #region Metodos

    /// <summary>
    ///  altura  cuando acelar 
    /// </summary>

    public void Altura(int _presionPedalAcelerar)
    {
        if (_presionPedalAcelerar > 0)
            Altura = _presionPedalAcelerar * 2;

           Altura = 0;
    }


    public void Reversa(int _presionPedalAcelerar)
    {
        if (_presionPedalAcelerar > 0)
            Velocidad = _presionPedalAcelerar * 2;

            Velocidad = 0;
    }


    #endregion


}

    



    

