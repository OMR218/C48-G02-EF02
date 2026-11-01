using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G02_EF02.Module_Class
{
    public class OrganizerEvent
    {
        public int OrganizerId { get; set; }
        public Organizer organizer { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
