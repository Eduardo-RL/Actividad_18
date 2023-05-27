using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int existencias {get; set; }
        
        public int? TicketsId { get; set; }
        public virtual Tickets? Tickets { get; set; }
        
    }
}
