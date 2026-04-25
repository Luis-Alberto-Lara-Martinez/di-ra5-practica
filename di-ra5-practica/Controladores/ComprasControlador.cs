using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace di_ra5_practica.Controladores
{
    internal class ComprasControlador
    {
        public static List<Compras> listaCompras = new List<Compras>();
        public static List<Compras> cargarCompras()
        {
            try
            {
                string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                string filePath = Path.Combine(projectDir, "Datos de demo", "compras.json");
                filePath = Path.GetFullPath(filePath);

                if (!File.Exists(filePath))
                {
                    throw new Exception($"No existe el archivo compras.json en: {filePath}");
                }

                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Compras>>(jsonString);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
