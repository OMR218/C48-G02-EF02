using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G02_EF02.Module_Class
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProfile OrganizerProfile { get; set; }
        public OrganizerEvent OrganizerEvent { get; set; }
    }
}
