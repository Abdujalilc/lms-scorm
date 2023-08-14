//
// relationType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System.Collections;
using System.Xml;

namespace imsmd_rootv1p2p1
{
    public class relationType : Altova.Node
    {
        #region Forward constructors
        public relationType() : base() { SetCollectionParents(); }
        public relationType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public relationType(XmlNode node) : base(node) { SetCollectionParents(); }
        public relationType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", i);
                InternalAdjustPrefix(DOMNode, true);
                new kindType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", i);
                InternalAdjustPrefix(DOMNode, true);
                new resourceType(DOMNode).AdjustPrefix();
            }
        }


        #region kind accessor methods
        public int GetkindMinCount()
        {
            return 0;
        }

        public int kindMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetkindMaxCount()
        {
            return 1;
        }

        public int kindMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetkindCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind");
        }

        public int kindCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind");
            }
        }

        public bool Haskind()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind");
        }

        public kindType GetkindAt(int index)
        {
            return new kindType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", index));
        }

        public kindType Getkind()
        {
            return GetkindAt(0);
        }

        public kindType kind
        {
            get
            {
                return GetkindAt(0);
            }
        }

        public void RemovekindAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", index);
        }

        public void Removekind()
        {
            while (Haskind())
                RemovekindAt(0);
        }

        public void Addkind(kindType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", newValue);
        }

        public void InsertkindAt(kindType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", index, newValue);
        }

        public void ReplacekindAt(kindType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "kind", index, newValue);
        }
        #endregion // kind accessor methods

        #region kind collection
        public kindCollection Mykinds = new kindCollection();

        public class kindCollection : IEnumerable
        {
            relationType parent;
            public relationType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public kindEnumerator GetEnumerator()
            {
                return new kindEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class kindEnumerator : IEnumerator
        {
            int nIndex;
            relationType parent;
            public kindEnumerator(relationType par)
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
                return (nIndex < parent.kindCount);
            }
            public kindType Current
            {
                get
                {
                    return (parent.GetkindAt(nIndex));
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

        #endregion // kind collection

        #region resource accessor methods
        public int GetresourceMinCount()
        {
            return 0;
        }

        public int resourceMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetresourceMaxCount()
        {
            return 1;
        }

        public int resourceMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetresourceCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource");
        }

        public int resourceCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource");
            }
        }

        public bool Hasresource()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource");
        }

        public resourceType GetresourceAt(int index)
        {
            return new resourceType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", index));
        }

        public resourceType Getresource()
        {
            return GetresourceAt(0);
        }

        public resourceType resource
        {
            get
            {
                return GetresourceAt(0);
            }
        }

        public void RemoveresourceAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", index);
        }

        public void Removeresource()
        {
            while (Hasresource())
                RemoveresourceAt(0);
        }

        public void Addresource(resourceType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", newValue);
        }

        public void InsertresourceAt(resourceType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", index, newValue);
        }

        public void ReplaceresourceAt(resourceType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "resource", index, newValue);
        }
        #endregion // resource accessor methods

        #region resource collection
        public resourceCollection Myresources = new resourceCollection();

        public class resourceCollection : IEnumerable
        {
            relationType parent;
            public relationType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public resourceEnumerator GetEnumerator()
            {
                return new resourceEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class resourceEnumerator : IEnumerator
        {
            int nIndex;
            relationType parent;
            public resourceEnumerator(relationType par)
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
                return (nIndex < parent.resourceCount);
            }
            public resourceType Current
            {
                get
                {
                    return (parent.GetresourceAt(nIndex));
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

        #endregion // resource collection

        private void SetCollectionParents()
        {
            Mykinds.Parent = this;
            Myresources.Parent = this;
        }
    }
}
