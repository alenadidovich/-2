using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class produkte : interfacee
    {
        string _kategorie, _name;
        int _preis, _poleznost;
        public string Kategorie;
        public string Name;
        public int Preis;
        public int Nutzbarkeit;

        public produkte()
        {
            _kategorie = Kategorie;
            _name = Name;
            _preis = Preis;
            _poleznost = Nutzbarkeit;
        }
        public string kategorie { get => _kategorie; set => _kategorie = value; }
        public string name { get => _name; set => _name = value; }
        public int preis { get => _preis; set => _preis = value; }
        public int nutzbarkeit { get => _poleznost; set => _poleznost = value; }
    }
}
