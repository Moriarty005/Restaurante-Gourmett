using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GourmetteRestaurante
{
    
    public class Plato
    {
        string nombre;
        List<string> lista_alergenos;
        string ruta_imagen;
        double precio;
        int cantidad;
        string tipo_plato;

        public Plato()
        {
            this.nombre = "";
            this.lista_alergenos = new List<string>();
            this.ruta_imagen = "";
            this.precio = 0.0;
            this.cantidad = 1;
            this.tipo_plato = "";

            this.setAlergenos();
        }

        public Plato(string nom, string img, double pre, int cantidad, string tp)
        {
            this.nombre = nom;
            this.precio = pre;
            this.ruta_imagen = img;
            this.lista_alergenos = new List<string>();
            this.cantidad = cantidad;
            this.tipo_plato = tp;

            this.setAlergenos();
        }

        public void setAlergenos()
        {
            string alergeno = "Huevo";
            this.lista_alergenos.Add(alergeno);
            string alergeno1 = "Gengibre";
            this.lista_alergenos.Add(alergeno1);
            string alergeno2 = "CEbollieno";
            this.lista_alergenos.Add(alergeno2);

        }

        public void setNombre(string nom)
        {
            this.nombre = nom;
        }

        public void setImagen(string img)
        {
            this.ruta_imagen = img;
        }

        public void setPrecio(double pre)
        {
            this.precio = pre;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setTipoPlato(string tp)
        {
            this.tipo_plato = tp;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getImagen()
        {
            return this.ruta_imagen;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public string getTipoPlato()
        {
            return this.tipo_plato;
        }

        public List<string> getAlergenos()
        {
            return this.lista_alergenos;
        }

        public void toStringPlato()
        {
            Console.WriteLine("Nombre: " + this.getNombre()
                + "\n" + "Ruta de imagen: " + this.getImagen()
                + "\n" + "Precio: " + this.getPrecio()
                + "\n" + "Cantidad: " + this.getCantidad()
                + "\n" + "Tipo de plato: " + this.getTipoPlato());
        }
    }
}
