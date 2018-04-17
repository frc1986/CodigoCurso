using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmsambladoraVehiculos2.Molde
{
    public class MoldeCarro : MoldeVehiculoHijo
    {
        public class MoldeDeCarro
        {
            #region Contructores
            public MoldeDeCarro(int _numPuertas, int _numllantas, string _color, string _marca)
                   : base(_numPuertas, _numllantas, _numllantas, _color, _marca)
            {
            }

            public MoldeDeCarro(int _numPuertas, int _numllantas, string _marca)
                : base(_numPuertas, _numPuertas, _marca)
            {
            } 
          
            #region Propiedades
            /// <summary>
            /// esta propiedad me guarda el numero de puertas que va tener el carrio
            /// </summary>
            public int NumPuertas { get; set; }

            /// <summary>
            /// esta propiedad me guarda el numero de llantas que va tener el carro
            /// </summary>
           
           
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

 
            public void Reversa(int _presionPedalAcelerar)
            {
                if (_presionPedalAcelerar > 0)
                    Velocidad = _presionPedalAcelerar * 2;

                Velocidad = 0;
            }


            #endregion


        }

    }

}
