//
// prerequisiteStringType.cs.cs
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

namespace adlcp_rootv1p2
{

    public class prerequisiteStringType : SchemaString
    {
        public prerequisiteStringType(string newValue) : base(newValue)
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
            return 8000; // spec says 200 but that isn't big enough
        }
    }
}
