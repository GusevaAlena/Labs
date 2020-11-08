using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    interface IComment
    {
        string Comment();
        string message { get; set; }
    }
}
