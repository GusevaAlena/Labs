using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSystem
{
    class Inspector:User, IComment
    {
        private long numberOfApproves;
        
        public Inspector (string Organization, long ID, string FullName, string Position,long NumberOfApproves, bool Permition) : base(Organization, ID, FullName, Position, Permition)
        {
           numberOfApproves = NumberOfApproves;
        }
        public override string Show()
        {
            string insp = base.Show() + "\nКоличество одобренных сертификаций: " + numberOfApproves;
            return insp;
        }
        public string Approve()
        {           
            string inspMes1 = "\nСообщение от инспектора: Cогласовано!";
            return inspMes1;
        }
        public string DontApprove()
        {
            string inspMes2 = "\nСообщение от инспектора: Не согласовано!";
            return inspMes2;

        }
        public string message { get; set; }
        public string Comment()
        {
            message = "Предел текучести материала не должен превышать требования более чем на 10%";
            return message;
        }

    }
}
