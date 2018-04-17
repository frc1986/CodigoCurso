using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnsambladoraVehiculos.Molde;

namespace EnsambladoraVehiculos
{
    class Program
    {


        static void Main(string[] args)
        {
            //MoldeDeCarro elPrimerCarro = new MoldeDeCarro();
            //elPrimerCarro.Color = "rojo";
            //elPrimerCarro.Marca = "chevrolet";
            //elPrimerCarro.NumLlantas = 4;
            //elPrimerCarro.NumPuertas = 2;

            //MoldeDeCarro elSegundoCarro = new MoldeDeCarro();
            //elSegundoCarro.Color = "verde";
            //elSegundoCarro.Marca = "mazda";
            //elSegundoCarro.NumLlantas = 4;
            //elSegundoCarro.NumPuertas = 4;

            MoldeDeCarro elTercerCarro = new MoldeDeCarro(4, 4, Ayudas.Colores.Amarrillo.ToString(), Ayudas.Marcas.Mazda.ToString());

            MoldeDeCarro elCuartoCarro = new MoldeDeCarro(2, 4, Ayudas.Marcas.Mazda.ToString());

            elCuartoCarro.color = "que cambia con la luz";

            MoldeDeCarro elQuintoCarro = new MoldeDeCarro(4, 4, Ayudas.Colores.Azul.ToString(), Ayudas.Marcas.Ferrrari.ToString());
        }

        //string marca = Ayudas.Marcas.Mazda.ToString();
        //string marca2 = Convert.ToString(Ayudas.Marcas.Mazda);
        //string marca3 = (string) Ayudas.Marcas.Mazda;

            


    }



}

