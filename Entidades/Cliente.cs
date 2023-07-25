namespace Entidades
{
    public class Cliente
    {
        static int ultimoId = 1000;
        static bool flag;


        int id;
        string nombreYapellido;
        string direccion;
        string localidad;
        double telefono;

        public int Id { get => id; set => id = value; }
        public string NombreYapellido { get => nombreYapellido; set => nombreYapellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public static bool Flag { get => flag; set => flag = value; }

        public Cliente(string nombreYapellido, string direccion, string localidad, double telefono)
        {
            if (!Flag)
            {
                CargarUltimoId();
            }
            Flag = true;
            id = GetNextId();

            this.nombreYapellido = nombreYapellido;
            this.direccion = direccion;
            this.localidad = localidad;
            this.telefono = telefono;
        }

        private void CargarUltimoId()
        {
            try
            {
                int idMayor = Sistema.Clientes[Sistema.Clientes.Count - 1].id;
                ultimoId = idMayor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static int GetNextId()
        {
            return Interlocked.Increment(ref ultimoId);
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if (c1 is not null && c2 is not null)
            {
                return (c1.telefono == c2.telefono);
            }
            return false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.telefono == c2.telefono);
        }
    }
}