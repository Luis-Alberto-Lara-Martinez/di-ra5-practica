using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace di_ra5_practica.Controladores
{
    internal class ProductosControlador
    {
        public static List<Productos> listaProductos = new List<Productos>();

        public List<Productos> cargarProductos()
        {
            try
            {
                if (File.Exists("ventas.json"))
                {
               
                    string jsonString = File.ReadAllText("Datos de demo/compras.json");
                   
                   

                     listaProductos = JsonSerializer.Deserialize<List<Productos>>(jsonString);
                }
            }
            catch (Exception e)
            {
                // Capturar y mostrar cualquier error ocurrido
                Console.WriteLine("Error al cargar ventas desde JSON: " + e.Message);
            }


            return new List<Productos>();
        }
    }
}
