using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Operations.Data
{
    public class Device
    {
        [Key]
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType Type { get; set; }
    }
}
