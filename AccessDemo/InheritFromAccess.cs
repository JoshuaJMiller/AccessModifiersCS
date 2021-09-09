using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAccessDemo;

namespace AccessDemo
{
    class InheritFromAccess : Access
    {
        public void Internal()
        {
            InternalModifier();
            ProtectedModifier();
            PrivateProtectedModifier();
        }
    }
}
