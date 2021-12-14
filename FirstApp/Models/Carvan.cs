using FirstApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Carvan : Aanhangwagen, IBewoonbaar
    {
        private double _bewoonbaar;
        public int AantalSlaapkamers { get => 1; }

        public double BewoonbaarOppervlakte 
        {
            get => _bewoonbaar; 
            set
            {
                if (_bewoonbaar >0)
                {
                    _bewoonbaar = value;
                }
            }
        }
    }
}
