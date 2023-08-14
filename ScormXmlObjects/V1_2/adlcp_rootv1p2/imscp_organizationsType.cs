//
// imscp_organizationsType.cs.cs
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
using System;
using System.Collections;
using System.Xml;

namespace adlcp_rootv1p2.imscp
{
    public class organizationsType : Altova.Node
    {
        #region Forward constructors
        public organizationsType() : base() { SetCollectionParents(); }
        public organizationsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public organizationsType(XmlNode node) : base(node) { SetCollectionParents(); }
        public organizationsType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Attribute, "", "default");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "default", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", i);
                InternalAdjustPrefix(DOMNode, false);
                new organizationType(DOMNode).AdjustPrefix();
            }
        }


        #region default2 accessor methods
        public int Getdefault2MinCount()
        {
            return 0;
        }

        public int default2MinCount
        {
            get
            {
                return 0;
            }
        }

        public int Getdefault2MaxCount()
        {
            return 1;
        }

        public int default2MaxCount
        {
            get
            {
                return 1;
            }
        }

        public int Getdefault2Count()
        {
            return DomChildCount(NodeType.Attribute, "", "default");
        }

        public int default2Count
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "default");
            }
        }

        public bool Hasdefault2()
        {
            return HasDomChild(NodeType.Attribute, "", "default");
        }

        public SchemaString Getdefault2At(int index)
        {
            return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "default", index)));
        }

        public SchemaString Getdefault2()
        {
            return Getdefault2At(0);
        }

        public SchemaString default2
        {
            get
            {
                return Getdefault2At(0);
            }
        }

        public void Removedefault2At(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "default", index);
        }

        public void Removedefault2()
        {
            while (Hasdefault2())
                Removedefault2At(0);
        }

        public void Adddefault2(SchemaString newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "default", newValue.ToString());
        }

        public void Insertdefault2At(SchemaString newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "default", index, newValue.ToString());
        }

        public void Replacedefault2At(SchemaString newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "default", index, newValue.ToString());
        }
        #endregion // default2 accessor methods

        #region default2 collection
        public default2Collection Mydefault2s = new default2Collection();

        public class default2Collection : IEnumerable
        {
            organizationsType parent;
            public organizationsType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public default2Enumerator GetEnumerator()
            {
                return new default2Enumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class default2Enumerator : IEnumerator
        {
            int nIndex;
            organizationsType parent;
            public default2Enumerator(organizationsType par)
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
                return (nIndex < parent.default2Count);
            }
            public SchemaString Current
            {
                get
                {
                    return (parent.Getdefault2At(nIndex));
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

        #endregion // default2 collection

        #region organization accessor methods
        public int GetorganizationMinCount()
        {
            return 0;
        }

        public int organizationMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetorganizationMaxCount()
        {
            return Int32.MaxValue;
        }

        public int organizationMaxCount
        {
            get
            {
                return Int32.MaxValue;
            }
        }

        public int GetorganizationCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization");
        }

        public int organizationCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization");
            }
        }

        public bool Hasorganization()
        {
            return HasDomChild(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization");
        }

        public organizationType GetorganizationAt(int index)
        {
            return new organizationType(GetDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", index));
        }

        public organizationType Getorganization()
        {
            return GetorganizationAt(0);
        }

        public organizationType organization
        {
            get
            {
                return GetorganizationAt(0);
            }
        }

        public void RemoveorganizationAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", index);
        }

        public void Removeorganization()
        {
            while (Hasorganization())
                RemoveorganizationAt(0);
        }

        public void Addorganization(organizationType newValue)
        {
            AppendDomElement("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", newValue);
        }

        public void InsertorganizationAt(organizationType newValue, int index)
        {
            InsertDomElementAt("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", index, newValue);
        }

        public void ReplaceorganizationAt(organizationType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsproject.org/xsd/imscp_rootv1p1p2", "organization", index, newValue);
        }
        #endregion // organization accessor methods

        #region organization collection
        public organizationCollection Myorganizations = new organizationCollection();

        public class organizationCollection : IEnumerable
        {
            organizationsType parent;
            public organizationsType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public organizationEnumerator GetEnumerator()
            {
                return new organizationEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class organizationEnumerator : IEnumerator
        {
            int nIndex;
            organizationsType parent;
            public organizationEnumerator(organizationsType par)
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
                return (nIndex < parent.organizationCount);
            }
            public organizationType Current
            {
                get
                {
                    return (parent.GetorganizationAt(nIndex));
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

        #endregion // organization collection

        private void SetCollectionParents()
        {
            Mydefault2s.Parent = this;
            Myorganizations.Parent = this;
        }
    }
}
