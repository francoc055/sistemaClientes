using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {

        static List<Cliente> clientes;

        public static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        static Sistema()
        {
            clientes = new List<Cliente>();
            //HardcodearClientes();
        }

        //static List<Cliente> HardcodearClientes()
        //{
        //    Clientes.Add(new Cliente("pepe perez", "calle falsa 123", "temperley", 1123457609));
        //    Clientes.Add(new Cliente("franco armani", "calle falsa 564", "lomas", 1145457600));
        //    Clientes.Add(new Cliente("paulo diaz", "calle falsa 456", "lanus", 1123450987));
        //    Clientes.Add(new Cliente("milton casco", "calle falsa 111", "escalada", 1123456510));

        //    return clientes;
        //}

        public static void SerializarJson<T>(List<T> lista, string ruta)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(ruta))
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;
                string objJson = System.Text.Json.JsonSerializer.Serialize(lista, opciones);
                sw.WriteLine(objJson);
            }
        }

        public static List<T> DeserializarJson<T>(string ruta)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        string json_str = sr.ReadToEnd();
                        List<T> registro = JsonConvert.DeserializeObject<List<T>>(json_str);
                        return registro;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
