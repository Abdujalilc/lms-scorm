//
// dependencyType.cs.cs
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

namespace imscp_rootv1p1p2
{
    public class dependencyType : Altova.Node
    {
        #region Forward constructors
        public dependencyType() : base() { SetCollectionParents(); }
        public dependencyType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public dependencyType(XmlNode node) : base(node) { SetCollectionParents(); }
        public dependencyType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Attribute, "", "identifierref");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "identifierref", i);
                InternalAdjustPrefix(DOMNode, false);
            }
        }


        #region identifierref accessor methods
        public int GetidentifierrefMinCount()
        {
            return 1;
        }

        public int identifierrefMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetidentifierrefMaxCount()
        {
            return 1;
        }

        public int identifierrefMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetidentifierrefCount()
        {
            return DomChildCount(NodeType.Attribute, "", "identifierref");
        }

        public int identifierrefCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "identifierref");
            }
        }

        public bool Hasidentifierref()
        {
            return HasDomChild(NodeType.Attribute, "", "identifierref");
        }

        public identifierrefType GetidentifierrefAt(int index)
        {
            return new identifierrefType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "identifierref", index)));
        }

        public identifierrefType Getidentifierref()
        {
            return GetidentifierrefAt(0);
        }

        public identifierrefType identifierref
        {
            get
            {
                return GetidentifierrefAt(0);
            }
        }

        public void RemoveidentifierrefAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "identifierref", index);
        }

        public void Removeidentifierref()
        {
            while (Hasidentifierref())
                RemoveidentifierrefAt(0);
        }

        public void Addidentifierref(identifierrefType newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "identifierref", newValue.ToString());
        }

        public void InsertidentifierrefAt(identifierrefType newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "identifierref", index, newValue.ToString());
        }

        public void ReplaceidentifierrefAt(identifierrefType newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "identifierref", index, newValue.ToString());
        }
        #endregion // identifierref accessor methods

        #region identifierref collection
        public identifierrefCollection Myidentifierrefs = new identifierrefCollection();

        public class identifierrefCollection : IEnumerable
        {
            dependencyType parent;
            public dependencyType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public identifierrefEnumerator GetEnumerator()
            {
                return new identifierrefEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class identifierrefEnumerator : IEnumerator
        {
            int nIndex;
            dependencyType parent;
            public identifierrefEnumerator(dependencyType par)
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
                return (nIndex < parent.identifierrefCount);
            }
            public identifierrefType Current
            {
                get
                {
                    return (parent.GetidentifierrefAt(nIndex));
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

        #endregion // identifierref collection

        private void SetCollectionParents()
        {
            Myidentifierrefs.Parent = this;
        }
    }
}
