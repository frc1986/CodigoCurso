using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos
{
    class MoldeDeAvion
    {
    }
}
//public enum ColorAvion
//{
//    Rojo = 2, Gris, Negro = 5, Amarillo, Azul
//}

//public enum MarcaAvion
//{
//    Airbus A340 = 1, Boeing, McDonnell, 
//}

/// <summary>
/// este es un molde para crear aviones
/// </summary>
public class MoldeDeAvion
{
    public MoldeDeAvion(int _numPuertas, int _numllantas, string _color, string _marca)
    {
        NumPuertas = _numPuertas;
        NumLlantas = _numllantas;
        color = _color;
        Marca = _marca;
    }

    public MoldeDeAvion(int _numPuertas, int _numllantas, string _marca)
    {
        NumPuertas = _numPuertas;
        NumLlantas = _numllantas;
        Marca = _marca;
    }


    #region Propiedades
    /// <summary>
    /// esta propiedad me guarda el numero de puertas que va tener el avion
    /// </summary>
    public int NumPuertas { get; set; }

    /// <summary>
    /// esta propiedad me guarda el numero de llantas que va tener el avion
    /// </summary>
    public int NumLlantas { get; set; }

    /// <summary>
    /// esta propiedad me va a guardar el color ddel avion
    /// </summary>
    public string color { get; set; }

    /// <summary>
    /// esta propiedad me guarda la velociadad actual del avion
    /// </summary>
    public int Velocidad { get; set; }

    /// <summary>
    /// esta propiedad me guarda la marca del avion
    /// </summary>
    public string Marca { get; set; }

    #endregion

    #region Metodos
    /// <summary>
    /// este metodo me controla la velocidad cuando acelera
    /// </summary>
    /// <param name="_presionPedalAcelerar"></param>
    public void Acelerar(int _presionPedalAcelerar)
    {
        if (_presionPedalAcelerar > 0)
            Velocidad = _presionPedalAcelerar * 2;

        Velocidad = 0;
    }

    /// <summary>
    ///  este metodo me controla la velocidad cuando frena
    /// </summary>
    /// <param name="_presionPedalFreno"></param>
    public void Frenar(int _presionPedalFreno)
    {
        if (_presionPedalFreno > 0)
            Velocidad = _presionPedalFreno / 2;
    }

    public void Reversa(int _presionPedalAcelerar)
    {
        if (_presionPedalAcelerar > 0)
            Velocidad = _presionPedalAcelerar * 2;

        Velocidad = 0;
    }


    #endregion


}
        
