using Menu_de_restaurante.CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_de_restaurante.LogicaNegocios
{
    public class MenuLN
    {
        public Func<MenuCN> createMenu1 = () => {  // Expresion lambda: esta expresion crea el menu numero 1
                                                   // en el cual estan los diferentes alimentos en lista//

            MenuCN menu1 = new MenuCN(); //Aplicamos el patron de diseño "Abstract Factory", ya que estamos creando una interfaz que se muestre por pantalla el "Menu 1" //
            String[] nombresSopas = { "Sopa de Camaron", "Sopa de Pollo", "Sopa de Carne", "Sopa de Queso" }; // aqui estamos creando familias de objetos relacionados sin especificar el nombre de la clase//
            Double[] preciosSobas = { 2.50, 1.50, 2, 1 };

            for (int i = 0; i < nombresSopas.Length; i++)
            {
                AnadirListaSopas(menu1, nombresSopas[i], preciosSobas[i]);
            }


            String[] nombresArroces = { "Arroz Colorado", "Chaulafan", "Arroz Blanco", "Arroz Sopudo" };
            Double[] preciosArroces = { 3, 4, 1.50, 1.25 };
            for (int i = 0; i < nombresArroces.Length; i++)
            {
                AnadirListaArroces(menu1, nombresArroces[i], preciosArroces[i]);
            }


            String[] nombresCarnes = { "Carne de Res", "Carne de Cerdo", "Carnde de Chivo" };
            String[] coccionCarnes = { "Asado Termino Medio", "Asado", "Asado" };
            Double[] preciosCarnes = { 3, 5, 3.50 };
            for (int i = 0; i < nombresCarnes.Length; i++)
            {
                AnadirListaCarnes(menu1, nombresCarnes[i], preciosCarnes[i], coccionCarnes[i]);
            }
            return menu1;
        };

        public Func<MenuCN> createMenu2 = () =>  // Expresion lambda: Esta expresion crea el menu numero 2
                                                 // en el cual se encuentra otras listas de alimentos//
        {
            MenuCN menu2 = new MenuCN(); //Aplicamos el patron de diseño "Abstract Factory", para mostrar en la interfaz "Menu 2 " 
            String[] nombresSopas2 = { "Sopa de Espinacas", "Sopa de Brocoli", "Sopa de Zanahoria" }; // aqui estamos creando familias de objetos relacionados sin especificar el nombre de la clase//
            Double[] preciosSobas2 = { 3.50, 2.50, 3 };
            for (int i = 0; i < nombresSopas2.Length; i++)
            {
                AnadirListaSopas(menu2, nombresSopas2[i], preciosSobas2[i]);
            }


            String[] nombresArroces2 = { "Arroz Blanco", "Arroz Integral" };
            Double[] preciosArroces2 = { 3, 5 };
            for (int i = 0; i < nombresArroces2.Length; i++)
            {
                AnadirListaArroces(menu2, nombresArroces2[i], preciosArroces2[i]);
            }


            String[] nombreMariscos = { "Pescado", "Camaron", "Pulpo", "Calamar" };
            Double[] precioMariscos = { 3, 5, 3.50, 3.50 };
            for (int i = 0; i < nombreMariscos.Length; i++)
            {
                AnadirListaMariscos(menu2, nombreMariscos[i], precioMariscos[i]);
            }
            return menu2;
        };

        public Func<MenuCN, Boolean> imprimirMenu1 = (menu) => // Expresion lambda: Esta expresion muuestra
        {                                                      // la lista del menu 1//
            Console.Clear();
            Console.WriteLine("///// Este es el menu 1 /////////");
            ImprimirListaSopas(menu);
            Console.WriteLine("");
            ImprimirListaArroces(menu);
            Console.WriteLine("");
            ImprimirListaCarnes(menu);
            Console.WriteLine("");
            return true;
        };

        public Func<MenuCN, Boolean> imprimirMenu2 = (menu) =>   // Expresion lambda: Esta expresion muestra
        {                                                        // la lista de sopas del menu 2//
            Console.Clear();
            Console.WriteLine("///// Este es el menu 2 /////////");
            ImprimirListaSopas(menu);
            Console.WriteLine("");
            ImprimirListaArroces(menu);
            Console.WriteLine("");
            ImprimirListaMariscos(menu);
            Console.WriteLine("");
            return true;
        };



        //public static Func<MenuCN, string, double, Boolean> addSopasMenu = (menu, nombre, precio) => {
        //    SopasCN sopa = new SopasCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
        //    sopa.Name = nombre;
        //    sopa.Precio = precio;
        //    menu.Sopas.Add(sopa);
        //    return true;
        //};

        public static void AnadirListaSopas(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            SopasCN sopa = new SopasCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            sopa.Name = nombre;
            sopa.Precio = precio;
            menu.Sopas.Add(sopa);
        }

        public static void AnadirListaArroces(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            ArrozCN arroz = new ArrozCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            arroz.Name = nombre;
            arroz.Precio = precio;
            menu.Arroces.Add(arroz);
        }


        public static void AnadirListaCarnes(MenuCN menu, String nombre, Double precio, String coccion) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            CarnesCN carne = new CarnesCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            carne.Name = nombre;
            carne.Precio = precio;
            carne.Coccion = coccion;
            menu.Carnes.Add(carne);
        }


        public static void AnadirListaMariscos(MenuCN menu, String nombre, Double precio) // Aqui usamos el patron de diseño "Builder Patterns", ya que estamos representando y añadiendo objetos utilizando el mismo codigo//
        {
            MariscosCN marisco = new MariscosCN(); //Estamos agregando propiedades al objeto independiente, para luego hacerlo un objeto complejo, patron de diseño "Builder Patterns".
            marisco.Name = nombre;
            marisco.Precio = precio;
            menu.Mariscos.Add(marisco);
        }

        public static void ImprimirListaCarnes(MenuCN menu) {
            Console.WriteLine("//////       Carnes      //////////");
            for (int i = 0; i < menu.Carnes.Count; i++)
            {
                CarnesCN carne = menu.Carnes[i];
                Console.WriteLine((i + 1) + ") " + carne.Name + "     $" + carne.Precio);
            }
        }

        public static void ImprimirListaArroces(MenuCN menu)
        {
            Console.WriteLine("//////       Arroces      //////////");
            for (int i = 0; i < menu.Arroces.Count; i++)
            {
                ArrozCN arroz = menu.Arroces[i];
                Console.WriteLine((i + 1) + ") " + arroz.Name + "     $" + arroz.Precio);
            }
        }
        public static void ImprimirListaSopas(MenuCN menu)
        {
            Console.WriteLine("//////       Sopas      //////////");
            for (int i = 0; i < menu.Sopas.Count; i++)
            {
                SopasCN sopa = menu.Sopas[i];
                Console.WriteLine((i + 1) + ") " + sopa.Name + "     $" + sopa.Precio);
            }
        }
        public static void ImprimirListaMariscos(MenuCN menu)
        {
            Console.WriteLine("//////       Mariscos      //////////");
            for (int i = 0; i < menu.Mariscos.Count; i++)
            {
                MariscosCN marisco = menu.Mariscos[i];
                Console.WriteLine((i + 1) + ") " + marisco.Name + "     $" + marisco.Precio);
            }
        }
    }
}
