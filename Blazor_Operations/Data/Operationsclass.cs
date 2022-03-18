using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Operations.Data
{
    public class Operationsclass
    {
        [Key]
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public Device Device { get; set; }

    }
}
