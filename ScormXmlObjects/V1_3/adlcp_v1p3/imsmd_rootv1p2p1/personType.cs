//
// personType.cs.cs
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
using System.Collections;
using System.Xml;

namespace imsmd_rootv1p2p1
{
    public class personType : Altova.Node
    {
        #region Forward constructors
        public personType() : base() { SetCollectionParents(); }
        public personType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public personType(XmlNode node) : base(node) { SetCollectionParents(); }
        public personType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", i);
                InternalAdjustPrefix(DOMNode, true);
            }
        }


        #region vcard accessor methods
        public int GetvcardMinCount()
        {
            return 1;
        }

        public int vcardMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetvcardMaxCount()
        {
            return 1;
        }

        public int vcardMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetvcardCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard");
        }

        public int vcardCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard");
            }
        }

        public bool Hasvcard()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard");
        }

        public SchemaString GetvcardAt(int index)
        {
            return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", index)));
        }

        public SchemaString Getvcard()
        {
            return GetvcardAt(0);
        }

        public SchemaString vcard
        {
            get
            {
                return GetvcardAt(0);
            }
        }

        public void RemovevcardAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", index);
        }

        public void Removevcard()
        {
            while (Hasvcard())
                RemovevcardAt(0);
        }

        public void Addvcard(SchemaString newValue)
        {
            AppendDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", newValue.ToString());
        }

        public void InsertvcardAt(SchemaString newValue, int index)
        {
            InsertDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", index, newValue.ToString());
        }

        public void ReplacevcardAt(SchemaString newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "vcard", index, newValue.ToString());
        }
        #endregion // vcard accessor methods

        #region vcard collection
        public vcardCollection Myvcards = new vcardCollection();

        public class vcardCollection : IEnumerable
        {
            personType parent;
            public personType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public vcardEnumerator GetEnumerator()
            {
                return new vcardEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class vcardEnumerator : IEnumerator
        {
            int nIndex;
            personType parent;
            public vcardEnumerator(personType par)
            {
                parent = par;
                nIndex = -1;
            }
            public void Reset()
            {
                nIndex = -1;
            }
            public bool MoveNext()
            {
                nIndex++;
                return (nIndex < parent.vcardCount);
            }
            public SchemaString Current
            {
                get
                {
                    return (parent.GetvcardAt(nIndex));
                }
            }
            object IEnumerator.Current
            {
                get
                {
                    return (Current);
                }
            }
        }

        #endregion // vcard collection

        private void SetCollectionParents()
        {
            Myvcards.Parent = this;
        }
    }
}
