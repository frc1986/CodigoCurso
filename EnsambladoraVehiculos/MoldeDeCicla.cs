using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos
{
    class MoldeDeCicla
    {


        //public enum ColorCicla
        //{
        //    Rojo = 2, Gris, Negro = 5, Amarillo, Azul
        //}

        //public enum MarcaCicla
        //{
        //    GW = 1, Shimano, Orbea, Scott
        //}

        /// <summary>
        /// este es un molde para crear carros
        /// </summary>

        public MoldeDeCicla(int _numPuertas, int _numllantas, string _color, string _marca)
        {
            NumLlantas = _numllantas;
            color = _color;
            Marca = _marca;
        }



        #region Propiedades
        /// <summary>
        /// esta propiedad me guarda el numero de puertas que va tener la bibleta
        /// </summary>

        /// <summary>
        /// esta propiedad me guarda el numero de llantas que va tener la bicilceta
        /// </summary>
        public int NumLlantas { get; set; }

        /// <summary>
        /// esta propiedad me va a guardar el color ddel carro
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// esta propiedad me guarda la velociadad actual del carro
        /// </summary>
        public int Velocidad { get; set; }

        /// <summary>
        /// esta propiedad me guarda la marca del carro
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

    }
}
        

         

    #endregion



        

