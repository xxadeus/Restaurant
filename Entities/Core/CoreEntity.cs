using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Core
{
    public class CoreEntity
    {
        public CoreEntity() 
        {
            Id = Id++;
        }
        public int Id { get; set; } 
    }
}
