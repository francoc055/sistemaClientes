namespace Entidades
{
    public enum Loc
    {
        Lomas, //1000
        Temperley, //2000
        Banfield, //3000
        Vcentenario, //3000
        Turdera, //4000
        Lavallol,//4000
        Lanus, //5000
        Mchingolo, //5000
        Adrogue //6000
        
    }
    public class Cliente
    {
        static int ultimoId = 1000;
        static bool flag;


        int id;
        string nombreYapellido;
        string direccion;
        string localidad;
        double telefono;
        int localidadValor;

        public int Id { get => id; set => id = value; }
        public string NombreYapellido { get => nombreYapellido; set => nombreYapellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public static bool Flag { get => flag; set => flag = value; }
        public int LocalidadValor { get => localidadValor; set => localidadValor = value; }

        public Cliente(string nombreYapellido, string direccion, string localidad, double telefono, int localidadValor)
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
            this.localidadValor = localidadValor;
            //RevisarValorLocalidad(localidad);
        }

        public static int RevisarValorLocalidad(string loc)
        {
            int valor = 0;
            if (loc == Loc.Lomas.ToString())
            {
                valor = 1000;
            }
            else if (loc == Loc.Temperley.ToString())
            {
                valor = 2000;
            }
            else if (loc == Loc.Banfield.ToString() || loc == Loc.Vcentenario.ToString())
            {
                valor = 3000;
            }
            else if (loc == Loc.Turdera.ToString() || loc == Loc.Lavallol.ToString())
            {
                valor = 4000;
            }
            else if(loc == Loc.Mchingolo.ToString() || loc == Loc.Lanus.ToString())
            {
                valor = 5000;
            }
            else if(loc == Loc.Adrogue.ToString())
            {
                valor = 6000;
            }

            return valor;
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