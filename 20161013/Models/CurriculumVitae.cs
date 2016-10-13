using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20161013.Models
{
    public class CurriculumVitae: IDtStamped
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime CreatedTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}