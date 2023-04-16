using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Items
{
    public class Table : CoreEntity
    {
        public int Capacity { get; set; }
        public bool Activity { get; set; }
        public List<Product> Products{ get; set; }
        public double AccountInfo { get; set; }
        public enum Situation {empty, full, reserved}
        public Situation Situations { get; set; }    
    }
}
