using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    class Ex : Exception
    {
        public Ex()
        {
            
        }
        public Ex(string message) : base(message)
        {
            MessageBox.Show(message);
        }

        public Ex(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Ex(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void DisplayError()
        {

        }
    }
}
