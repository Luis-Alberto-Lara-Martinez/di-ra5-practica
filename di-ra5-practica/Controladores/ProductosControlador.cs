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

        public static List<Productos> cargarProductos()
        {
            try
            {
                string projectDir = Path.Combine(
                    Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                    "..", "..");

                string filePath = Path.Combine(projectDir, "Datos de demo", "productos.json");
                filePath = Path.GetFullPath(filePath);

                if (!File.Exists(filePath))
                    throw new Exception($"No existe el archivo productos.json en: {filePath}");

                string jsonString = File.ReadAllText(filePath);

                var opciones = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                listaProductos = JsonSerializer.Deserialize<List<Productos>>(jsonString, opciones)
                                ?? new List<Productos>();

                return listaProductos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
