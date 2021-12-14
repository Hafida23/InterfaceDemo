using FirstApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Motorhome : Auto, IBewoonbaar
    {
        private double _bewoonbaaroppervlakte;

        public Motorhome(double bewoonbaaroppervlakte )
        {
            if (_bewoonbaaroppervlakte > 0)
                _bewoonbaaroppervlakte = bewoonbaaroppervlakte;
        }
        public int AantalSlaapkamers { get; set; } = 1;
        public double BewoonbaarOppervlakte { get { return _bewoonbaaroppervlakte; }}
    }
}
