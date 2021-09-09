using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAccessDemo
{
     public class Access
    {
        // PROPERTY: gives a private member variable public getter and setter
        private string ssn;

        public string SSN
        {
            get
            {
                //000-00-0000
                return "***-**-" + ssn.Substring(7);
            }
            set { ssn = value; }
        }
        public void PublicModifier()
        {

        }

        private void PrivateModifier()
        {

        }

        private void Call()
        {
            PrivateModifier();
            InternalModifier();
        }

        internal void InternalModifier()
        {

        }

        protected void ProtectedModifier()
        {

        }

        protected internal void ProtectedInternalModifier()
        {

        }

        private protected void PrivateProtectedModifier()
        {

        }
    }
}
