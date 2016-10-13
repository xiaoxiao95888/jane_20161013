using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _20161013.Models
{
    public interface IDtStamped
    {
        DateTime? UpdateTime { get; set; }
        DateTime CreatedTime { get; set; }
        bool IsDeleted { get; set; }
    }
}