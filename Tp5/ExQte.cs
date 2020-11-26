using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    class ExQte : Exception
    {
        public string msg = "la Quantite doit etre un entier !!";
        public ExQte()
        {
            MessageBox.Show(msg);
        }
        public ExQte(string message) : base(message)
        {
        }

        public ExQte(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExQte(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void DisplayError()
        {

        }
    }
}
