using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Operations.Data
{
    public enum DeviceType
    {
        [Key]
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}
