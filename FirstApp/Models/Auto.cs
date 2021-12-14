using FirstApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Models
{
    public class Auto : IVoertuig, ITrekker
    {
        private int _maxSnelheid;
        private string _merk;
        private int _snelheid;
        private ITrekbaar _aanhangwagen;
        private int _maxTrekGewicht;

        public int MaximumSnelheid { get { return _maxSnelheid; } }

        public string Merk { get { return _merk; } }

        public int Snelheid
        {
            get { return _snelheid; }
            set
            {
                if (_snelheid < MaximumSnelheid && _snelheid > 0)
                {
                    _snelheid = value;

                }
            }
        }

        public ITrekbaar Aanhangwagen
        {
            get { return _aanhangwagen; }

        }

        public int MaximaalTrekGewicht { get { return _maxTrekGewicht; } }

        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            if (Snelheid == 0)
            {
               Aanhangwagen trekbaar = new Aanhangwagen();
                trekbaar = (Aanhangwagen)aanhangwagen;
                
            }
            else
            {
                try
                {
                    Aanhangwagen trekbaar = new Aanhangwagen();
                    trekbaar = (Aanhangwagen)aanhangwagen;
                    if (aanhangwagen.Gewicht > MaximaalTrekGewicht)
                    {
                        Snelheid = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(" het gewicht van de aanhangwagen groter is dan de maximale trekkracht van de auto "+e);
                }
            }
        }

        public void Versnel(int versnelling)
        {
            if (Snelheid < MaximumSnelheid)
            {
                Snelheid++;
            }
        }

        public void Vertraag(int vertraging)
        {
            if (Snelheid>0 && Snelheid<MaximumSnelheid)
            {
                Snelheid--;
            }
        }
    }
}
