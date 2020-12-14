using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.Lab02.Ex6
{
    interface IPubs
    {
       void Subs ();
       bool IfSubs { get; set; }
    }
}
