//
// classificationType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;

namespace imsmd_rootv1p2p1
{
    public class classificationType : Altova.Node
    {
        #region Forward constructors
        public classificationType() : base() { SetCollectionParents(); }
        public classificationType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public classificationType(XmlNode node) : base(node) { SetCollectionParents(); }
        public classificationType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", i);
                InternalAdjustPrefix(DOMNode, true);
                new purposeType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", i);
                InternalAdjustPrefix(DOMNode, true);
                new taxonpathType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "description", i);
                InternalAdjustPrefix(DOMNode, true);
                new descriptionType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", i);
                InternalAdjustPrefix(DOMNode, true);
                new keywordType(DOMNode).AdjustPrefix();
            }
        }


        #region purpose accessor methods
        public int GetpurposeMinCount()
        {
            return 0;
        }

        public int purposeMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetpurposeMaxCount()
        {
            return 1;
        }

        public int purposeMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetpurposeCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose");
        }

        public int purposeCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose");
            }
        }

        public bool Haspurpose()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose");
        }

        public purposeType GetpurposeAt(int index)
        {
            return new purposeType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", index));
        }

        public purposeType Getpurpose()
        {
            return GetpurposeAt(0);
        }

        public purposeType purpose
        {
            get
            {
                return GetpurposeAt(0);
            }
        }

        public void RemovepurposeAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", index);
        }

        public void Removepurpose()
        {
            while (Haspurpose())
                RemovepurposeAt(0);
        }

        public void Addpurpose(purposeType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", newValue);
        }

        public void InsertpurposeAt(purposeType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", index, newValue);
        }

        public void ReplacepurposeAt(purposeType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "purpose", index, newValue);
        }
        #endregion // purpose accessor methods

        #region purpose collection
        public purposeCollection Mypurposes = new purposeCollection();

        public class purposeCollection : IEnumerable
        {
            classificationType parent;
            public classificationType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public purposeEnumerator GetEnumerator()
            {
                return new purposeEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class purposeEnumerator : IEnumerator
        {
            int nIndex;
            classificationType parent;
            public purposeEnumerator(classificationType par)
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
                return (nIndex < parent.purposeCount);
            }
            public purposeType Current
            {
                get
                {
                    return (parent.GetpurposeAt(nIndex));
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

        #endregion // purpose collection

        #region taxonpath accessor methods
        public int GettaxonpathMinCount()
        {
            return 0;
        }

        public int taxonpathMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GettaxonpathMaxCount()
        {
            return Int32.MaxValue;
        }

        public int taxonpathMaxCount
        {
            get
            {
                return Int32.MaxValue;
            }
        }

        public int GettaxonpathCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath");
        }

        public int taxonpathCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath");
            }
        }

        public bool Hastaxonpath()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath");
        }

        public taxonpathType GettaxonpathAt(int index)
        {
            return new taxonpathType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", index));
        }

        public taxonpathType Gettaxonpath()
        {
            return GettaxonpathAt(0);
        }

        public taxonpathType taxonpath
        {
            get
            {
                return GettaxonpathAt(0);
            }
        }

        public void RemovetaxonpathAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", index);
        }

        public void Removetaxonpath()
        {
            while (Hastaxonpath())
                RemovetaxonpathAt(0);
        }

        public void Addtaxonpath(taxonpathType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", newValue);
        }

        public void InserttaxonpathAt(taxonpathType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", index, newValue);
        }

        public void ReplacetaxonpathAt(taxonpathType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "taxonpath", index, newValue);
        }
        #endregion // taxonpath accessor methods

        #region taxonpath collection
        public taxonpathCollection Mytaxonpaths = new taxonpathCollection();

        public class taxonpathCollection : IEnumerable
        {
            classificationType parent;
            public classificationType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public taxonpathEnumerator GetEnumerator()
            {
                return new taxonpathEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class taxonpathEnumerator : IEnumerator
        {
            int nIndex;
            classificationType parent;
            public taxonpathEnumerator(classificationType par)
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
                return (nIndex < parent.taxonpathCount);
            }
            public taxonpathType Current
            {
                get
                {
                    return (parent.GettaxonpathAt(nIndex));
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

        #endregion // taxonpath collection

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
            classificationType parent;
            public classificationType Parent
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
            classificationType parent;
            public descriptionEnumerator(classificationType par)
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

        #region keyword accessor methods
        public int GetkeywordMinCount()
        {
            return 0;
        }

        public int keywordMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetkeywordMaxCount()
        {
            return Int32.MaxValue;
        }

        public int keywordMaxCount
        {
            get
            {
                return Int32.MaxValue;
            }
        }

        public int GetkeywordCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword");
        }

        public int keywordCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword");
            }
        }

        public bool Haskeyword()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword");
        }

        public keywordType GetkeywordAt(int index)
        {
            return new keywordType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", index));
        }

        public keywordType Getkeyword()
        {
            return GetkeywordAt(0);
        }

        public keywordType keyword
        {
            get
            {
                return GetkeywordAt(0);
            }
        }

        public void RemovekeywordAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", index);
        }

        public void Removekeyword()
        {
            while (Haskeyword())
                RemovekeywordAt(0);
        }

        public void Addkeyword(keywordType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", newValue);
        }

        public void InsertkeywordAt(keywordType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", index, newValue);
        }

        public void ReplacekeywordAt(keywordType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "keyword", index, newValue);
        }
        #endregion // keyword accessor methods

        #region keyword collection
        public keywordCollection Mykeywords = new keywordCollection();

        public class keywordCollection : IEnumerable
        {
            classificationType parent;
            public classificationType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public keywordEnumerator GetEnumerator()
            {
                return new keywordEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class keywordEnumerator : IEnumerator
        {
            int nIndex;
            classificationType parent;
            public keywordEnumerator(classificationType par)
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
                return (nIndex < parent.keywordCount);
            }
            public keywordType Current
            {
                get
                {
                    return (parent.GetkeywordAt(nIndex));
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

        #endregion // keyword collection

        private void SetCollectionParents()
        {
            Mypurposes.Parent = this;
            Mytaxonpaths.Parent = this;
            Mydescriptions.Parent = this;
            Mykeywords.Parent = this;
        }
    }
}
