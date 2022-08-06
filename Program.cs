using SpotifyConsole.Helper;
using SpotifyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Menu;



namespace SpotifyConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instancia de un obj Men para ejecutar la funcion Empezar()
            Men objMen = new Men();
            objMen.Empezar();
        }

    }
}
