using Menu_de_restaurante.CapaNegocios;
using Menu_de_restaurante.LogicaNegocios;
using System;

namespace Menu_de_restaurante
{
    class Program
    {

        static void Main(string[] args)
        {
            MenuLN logicaMenu = new MenuLN();
            MenuCN menu1 = logicaMenu.createMenu1();
            MenuCN menu2 = logicaMenu.createMenu2();
            startApp(menu1,menu2 );
        }

        static void startApp(MenuCN menu1, MenuCN menu2) { //Gracias al patron de diseño "Abstract Factory" hemos conseguido una interfaz de conjuntos de objetos//
            MenuLN logicaMenu = new MenuLN();
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Este es el menu digital del restaurante 3B");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("Seleccione un Menú de la lista");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("/////////////     Menus      //////////////");
            Console.WriteLine("/////////////    1) Menu 1      //////////////");
            Console.WriteLine("/////////////    2) Menu 2     //////////////");
            Console.WriteLine("/////////////    3) Salir     //////////////");
            String respuesta = Console.ReadLine();
            if (respuesta == "1")
            {
                logicaMenu.imprimirMenu1(menu1);
            }
            else
            {
                if (respuesta == "2")
                {
                    logicaMenu.imprimirMenu2(menu2);
                }
                else {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Presione una tecla para volver");
            Console.ReadKey();
            Console.Clear();
            startApp(menu1,menu2);
        }
    }
}
