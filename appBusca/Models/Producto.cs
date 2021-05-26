  
using System.Collections.Generic;

namespace appBusca.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Celular { get; set; }
        public string lugar { get; set; }
        public string Comprador { get; set; }
        public Categoria Categoria { get; set; }
        // EF Shadow property
        public int CategoriaId { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}