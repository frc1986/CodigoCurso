using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos
{
//    public enum ColorMotos

//    {
//        Azul, Gris, Verde, Amarrillo
//    }
        
//   /// public enum MarcaMotos

//    {
//        Suzuki, Yamaha, Honda
//    }

    class MoldeDeMotos

    {
        public MoldeDeMotos(int num_llantas, string _color, string _marca)
        {
            NumLlantas = num_llantas;
            Color = _color;
            Marca = _marca;
              
        }

          /// esta propiedad me guarda el numero de llantas que va tener el carro
        /// </summary>
        public int NumLlantas { get; set; }

        /// <summary>
        /// esta propiedad me va a guardar el color ddel carro
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// esta propiedad me guarda la velociadad actual del carro
        /// </summary>

        public string Marca { get; set; }
    }

}

