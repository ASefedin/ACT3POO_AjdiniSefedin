using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3Elephant
{
    internal class Elephant
    {
        private string _nom;
        private uint _tailleOreille;

        public uint TailleOreilles
        {
            get { return _tailleOreille; }
            set { _tailleOreille = value; }
        }

        public string Nom
        {
            get { return _nom; }
        }
        public Elephant(string nom, uint tailleOreille)
        {
            _nom = nom;
            _tailleOreille = tailleOreille;
        }
        public string AfficheQuiJeSuis()
        {
            return "la taille des oreilles de " + Nom + " est de : " + TailleOreilles;
        }
        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }
        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }

    }
}
