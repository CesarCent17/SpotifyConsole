using SpotifyConsole.Models;
using SpotifyConsole.Helper;


namespace Menu
{
    class Men
    {
        //Metodo que retorna una opcion con tipo de dato int
        public static int OpcionElegida()
        {

            //Lista de opciones
            List<string> opciones;
            opciones = new List<string>();
            opciones.Add("1.- Revisar lista de artistas por busqueda");
            opciones.Add("2.- Revisar popularidad por busqueda de artista");
            opciones.Add("3.- Revisar seguidores por busqueda de artista");
            opciones.Add("4.- Salir");

            //Mostrar la lista de opciones
            System.Console.WriteLine("\n                     MENU\n");
            foreach (var opcion in opciones)
            {
                System.Console.WriteLine(opcion);
            }



            //Solicito que ingrese la opcion dentro del rango
            int op = -1;
            while (op < 1 || op > opciones.Count())
            {
                System.Console.WriteLine("\n#####################################");
                System.Console.WriteLine("Ingrese una opcion dentro del rango: ");
                op = int.Parse(Console.ReadLine());
            }
            return op;

        }

        
        public void Empezar()
        {
            //Inicia la tarea asincronica
            Task.Run(async () => await SearchHelper.GetTokenAsync());
            int opcion = Men.OpcionElegida();

            switch (opcion)
            {

                case 1:

                    //Uso del do-while para que como minimo se ejecute una vez
                    bool salir = false;
                    do
                    { 
                        //Si fue elegido 1.- Revisar lista de artistas por busqueda
                        System.Console.WriteLine($"\nSu eleccion es la #{opcion}");
                        Console.WriteLine("\nEscriba el artista:");
                        string texto = Console.ReadLine();
                        System.Console.WriteLine($"\nUsted esta buscando a {texto}\n");

                        //leerApi nos retorna una lista de tipo SpotifyArtist
                        List<SpotifyArtist> list = leerApi(texto);

                        //Sirve en caso de que el resultado de la busqueda sea menor a 10
                        //Si la longitud de la lista es menor a 9
                        if (list.Count < 9)
                        {
                            //Recorrer la lista
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine("*********");
                            }
                        }

                        //Si no, si es mayor entonces solo deseo que me de los 10 primeros elementos
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine("*********");
                            }
                        }

                        //Submenu elegir opcion
                        List<string> opciones;
                        opciones = new List<string>();
                        opciones.Add("\n1.- Volver a realizar una busqueda");
                        opciones.Add("2.- Regresar al menu principal");

                        //Recorrer lista de opciones del submenu
                        foreach (var opc in opciones)
                        {
                            System.Console.WriteLine(opc);
                        }

                        int op = -1;
                        while (op < 1 || op > opciones.Count())
                        {
                            System.Console.WriteLine("Ingrese una opcion dentro del rango: ");
                            op = int.Parse(Console.ReadLine());
                        }

                        //Si elige la opcion 1 continua el bucle

                        //Si elige la opcion 2 el valor booleano salir cambia a true por ende salimos del do-while
                        if (op == 2)
                        {
                            salir = true;
                        }


                    } while (salir == false);

                    //Si sali del do-while retorno al menu principal con recursividad
                    if (salir == true)
                    {
                        Men objMen = new Men();
                        objMen.Empezar();
                    }


                    break;

                case 2:
                    salir = false;
                    do
                    {
                        System.Console.WriteLine($"\nSu eleccion es la #{opcion}");
                        Console.WriteLine("\nEscriba el artista:");
                        string texto = Console.ReadLine();
                        System.Console.WriteLine($"\nUsted esta buscando a {texto}\n");
                        List<SpotifyArtist> list = leerApi(texto);

                        //Recorrer la lista
                        if (list.Count < 10)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine($"Popularidad: {list[i].Popularity}");
                                Console.WriteLine("*********");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine($"Popularidad: {list[i].Popularity}");
                                Console.WriteLine("*********");
                            }
                        }

                        //Submenu elegir opcion
                        List<string> opciones;
                        opciones = new List<string>();
                        opciones.Add("\n1.- Volver a realizar una busqueda");
                        opciones.Add("2.- Regresar al menu principal");

                        //Recorrer lista de opciones
                        foreach (var opc in opciones)
                        {
                            System.Console.WriteLine(opc);
                        }

                        int op = -1;
                        while (op < 1 || op > opciones.Count())
                        {
                            System.Console.WriteLine("Ingrese una opcion dentro del rango: ");
                            op = int.Parse(Console.ReadLine());
                        }
                        if (op == 2)
                        {
                            salir = true;
                        }


                    } while (salir == false);
                    if (salir == true)
                    {
                        Men objMen = new Men();
                        objMen.Empezar();
                    }


                    break;

                case 3:
                    salir = false;
                    do
                    {
                        System.Console.WriteLine($"\nSu eleccion es la #{opcion}");
                        Console.WriteLine("\nEscriba el artista:");
                        string texto = Console.ReadLine();
                        System.Console.WriteLine($"\nUsted esta buscando a {texto}\n");
                        List<SpotifyArtist> list = leerApi(texto);

                        //Recorrer la lista
                        if (list.Count < 10)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine(list[i].Followers);
                                Console.WriteLine("*********");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("Artista " + (i + 1) + ":");
                                Console.WriteLine(list[i].Name);
                                Console.WriteLine(list[i].Followers);
                                Console.WriteLine("*********");
                            }
                        }

                        //Submenu elegir opcion
                        List<string> opciones;
                        opciones = new List<string>();
                        opciones.Add("\n1.- Volver a realizar una busqueda");
                        opciones.Add("2.- Regresar al menu principal");

                        //Recorrer lista de opciones
                        foreach (var opc in opciones)
                        {
                            System.Console.WriteLine(opc);
                        }

                        int op = -1;
                        while (op < 1 || op > opciones.Count())
                        {
                            System.Console.WriteLine("Ingrese una opcion dentro del rango: ");
                            op = int.Parse(Console.ReadLine());
                        }
                        if (op == 2)
                        {
                            salir = true;
                        }


                    } while (salir == false);
                    if (salir == true)
                    {
                        Men objMen = new Men();
                        objMen.Empezar();
                    }


                    break;
                case 4:
                    break;

            }

        }

        //Metodo que me retorna una lista de tipo SpotifyArtist
        private static List<SpotifyArtist> leerApi(string texto)
        {
            
            var result = SearchHelper.SearchArtistOrSong(texto);

            if (result == null)
            {
                return null;
            }

            var listArtist = new List<SpotifyArtist>();

            //Por cada item de los resultados se va a agregar a la lista un objeto de tipo SpotifyArtist
            foreach (var item in result.artists.items)
            {
                listArtist.Add(new SpotifyArtist
                {
                    ID = item.id,
                    Image = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    Name = item.name,
                    Popularity = $"{item.popularity}%",
                    Followers = $"{item.followers.total.ToString("N")} seguidores"
                });
            }

            //retorna mi lista de objetos 
            return listArtist;



        }


    }

}