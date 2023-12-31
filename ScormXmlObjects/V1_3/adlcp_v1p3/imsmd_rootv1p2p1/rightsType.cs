//
// rightsType.cs.cs
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
    public class rightsType : Altova.Node
    {
        #region Forward constructors
        public rightsType() : base() { SetCollectionParents(); }
        public rightsType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public rightsType(XmlNode node) : base(node) { SetCollectionParents(); }
        public rightsType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", i);
                InternalAdjustPrefix(DOMNode, true);
                new costType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", i);
                InternalAdjustPrefix(DOMNode, true);
                new copyrightandotherrestrictionsType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", i);
                InternalAdjustPrefix(DOMNode, true);
                new descriptionType(DOMNode).AdjustPrefix();
            }
        }


        #region cost accessor methods
        public int GetcostMinCount()
        {
            return 0;
        }

        public int costMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetcostMaxCount()
        {
            return 1;
        }

        public int costMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetcostCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost");
        }

        public int costCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost");
            }
        }

        public bool Hascost()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost");
        }

        public costType GetcostAt(int index)
        {
            return new costType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", index));
        }

        public costType Getcost()
        {
            return GetcostAt(0);
        }

        public costType cost
        {
            get
            {
                return GetcostAt(0);
            }
        }

        public void RemovecostAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", index);
        }

        public void Removecost()
        {
            while (Hascost())
                RemovecostAt(0);
        }

        public void Addcost(costType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", newValue);
        }

        public void InsertcostAt(costType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", index, newValue);
        }

        public void ReplacecostAt(costType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "cost", index, newValue);
        }
        #endregion // cost accessor methods

        #region cost collection
        public costCollection Mycosts = new costCollection();

        public class costCollection : IEnumerable
        {
            rightsType parent;
            public rightsType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public costEnumerator GetEnumerator()
            {
                return new costEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class costEnumerator : IEnumerator
        {
            int nIndex;
            rightsType parent;
            public costEnumerator(rightsType par)
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
                return (nIndex < parent.costCount);
            }
            public costType Current
            {
                get
                {
                    return (parent.GetcostAt(nIndex));
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

        #endregion // cost collection

        #region copyrightandotherrestrictions accessor methods
        public int GetcopyrightandotherrestrictionsMinCount()
        {
            return 0;
        }

        public int copyrightandotherrestrictionsMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetcopyrightandotherrestrictionsMaxCount()
        {
            return 1;
        }

        public int copyrightandotherrestrictionsMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetcopyrightandotherrestrictionsCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions");
        }

        public int copyrightandotherrestrictionsCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions");
            }
        }

        public bool Hascopyrightandotherrestrictions()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions");
        }

        public copyrightandotherrestrictionsType GetcopyrightandotherrestrictionsAt(int index)
        {
            return new copyrightandotherrestrictionsType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", index));
        }

        public copyrightandotherrestrictionsType Getcopyrightandotherrestrictions()
        {
            return GetcopyrightandotherrestrictionsAt(0);
        }

        public copyrightandotherrestrictionsType copyrightandotherrestrictions
        {
            get
            {
                return GetcopyrightandotherrestrictionsAt(0);
            }
        }

        public void RemovecopyrightandotherrestrictionsAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", index);
        }

        public void Removecopyrightandotherrestrictions()
        {
            while (Hascopyrightandotherrestrictions())
                RemovecopyrightandotherrestrictionsAt(0);
        }

        public void Addcopyrightandotherrestrictions(copyrightandotherrestrictionsType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", newValue);
        }

        public void InsertcopyrightandotherrestrictionsAt(copyrightandotherrestrictionsType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", index, newValue);
        }

        public void ReplacecopyrightandotherrestrictionsAt(copyrightandotherrestrictionsType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "copyrightandotherrestrictions", index, newValue);
        }
        #endregion // copyrightandotherrestrictions accessor methods

        #region copyrightandotherrestrictions collection
        public copyrightandotherrestrictionsCollection Mycopyrightandotherrestrictionss = new copyrightandotherrestrictionsCollection();

        public class copyrightandotherrestrictionsCollection : IEnumerable
        {
            rightsType parent;
            public rightsType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public copyrightandotherrestrictionsEnumerator GetEnumerator()
            {
                return new copyrightandotherrestrictionsEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class copyrightandotherrestrictionsEnumerator : IEnumerator
        {
            int nIndex;
            rightsType parent;
            public copyrightandotherrestrictionsEnumerator(rightsType par)
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
                return (nIndex < parent.copyrightandotherrestrictionsCount);
            }
            public copyrightandotherrestrictionsType Current
            {
                get
                {
                    return (parent.GetcopyrightandotherrestrictionsAt(nIndex));
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

        #endregion // copyrightandotherrestrictions collection

        #region description accessor methods
        public int GetdescriptionMinCount()
        {
            return 0;
        }

        public int descriptionMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetdescriptionMaxCount()
        {
            return 1;
        }

        public int descriptionMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetdescriptionCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description");
        }

        public int descriptionCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description");
            }
        }

        public bool Hasdescription()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description");
        }

        public descriptionType GetdescriptionAt(int index)
        {
            return new descriptionType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", index));
        }

        public descriptionType Getdescription()
        {
            return GetdescriptionAt(0);
        }

        public descriptionType description
        {
            get
            {
                return GetdescriptionAt(0);
            }
        }

        public void RemovedescriptionAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", index);
        }

        public void Removedescription()
        {
            while (Hasdescription())
                RemovedescriptionAt(0);
        }

        public void Adddescription(descriptionType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", newValue);
        }

        public void InsertdescriptionAt(descriptionType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", index, newValue);
        }

        public void ReplacedescriptionAt(descriptionType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", index, newValue);
        }
        #endregion // description accessor methods

        #region description collection
        public descriptionCollection Mydescriptions = new descriptionCollection();

        public class descriptionCollection : IEnumerable
        {
            rightsType parent;
            public rightsType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public descriptionEnumerator GetEnumerator()
            {
                return new descriptionEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class descriptionEnumerator : IEnumerator
        {
            int nIndex;
            rightsType parent;
            public descriptionEnumerator(rightsType par)
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
                return (nIndex < parent.descriptionCount);
            }
            public descriptionType Current
            {
                get
                {
                    return (parent.GetdescriptionAt(nIndex));
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

        #endregion // description collection

        private void SetCollectionParents()
        {
            Mycosts.Parent = this;
            Mycopyrightandotherrestrictionss.Parent = this;
            Mydescriptions.Parent = this;
        }
    }
}
