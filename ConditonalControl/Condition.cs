using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditonalControl
{
    public abstract class Condition
    {
        public virtual bool isMet()
        {
            return false;
        }
    }
}
