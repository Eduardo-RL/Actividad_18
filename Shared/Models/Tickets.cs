using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public int? ClientesId { get; set; }
        public virtual Clientes? Clientes { get; set; }
        public virtual ICollection<Productos>?   Productos { get; set; }
    }
}
