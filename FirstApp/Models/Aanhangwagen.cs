using FirstApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Aanhangwagen : ITrekbaar
    {
        private int _aantalBanden;
        private int _gewicht;
        public int AantalBanden
        {
            get { return _aantalBanden; }
            set
            {
                if (_aantalBanden >= 2)
                    _aantalBanden = value;
            }
        }

        public int Gewicht
        {
            get => _gewicht;
            set
            {
                if (_gewicht > 0)
                     _gewicht= value;
            } 
        }

    }
}
