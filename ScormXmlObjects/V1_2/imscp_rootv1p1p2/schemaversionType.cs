//
// schemaversionType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace imscp_rootv1p1p2
{

    public class schemaversionType : SchemaString
    {
        public schemaversionType(string newValue) : base(newValue)
        {
            Validate();
        }

        public void Validate()
        {
            if (Value.Length > GetMaxLength())
                throw new System.Exception("Too long");
        }
        public int GetMaxLength()
        {
            return 20;
        }
    }
}
