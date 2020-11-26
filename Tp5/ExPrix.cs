using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    class ExPrix : Exception
    {
        public string msg = "le prix doit etre un nombre !!";
        public ExPrix()
        {
            MessageBox.Show(msg);

        }
        public ExPrix(string message) : base(message)
        {
        }

        public ExPrix(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExPrix(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void DisplayError()
        {

        }
    }
}
