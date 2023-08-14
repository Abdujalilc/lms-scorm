//
// itemType.cs.cs
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

namespace imscp_v1p1
{
    public class itemType : Altova.Node
    {
        #region Forward constructors
        public itemType() : base() { SetCollectionParents(); }
        public itemType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public itemType(XmlNode node) : base(node) { SetCollectionParents(); }
        public itemType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Attribute, "", "identifier");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "identifier", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Attribute, "", "identifierref");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "identifierref", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Attribute, "", "isvisible");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "isvisible", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Attribute, "", "parameters");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "parameters", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "item");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "item", i);
                InternalAdjustPrefix(DOMNode, false);
                new itemType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", i);
                InternalAdjustPrefix(DOMNode, false);
                new metadataType(DOMNode).AdjustPrefix();
            }
        }


        #region identifier accessor methods
        public int GetidentifierMinCount()
        {
            return 1;
        }

        public int identifierMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetidentifierMaxCount()
        {
            return 1;
        }

        public int identifierMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetidentifierCount()
        {
            return DomChildCount(NodeType.Attribute, "", "identifier");
        }

        public int identifierCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "identifier");
            }
        }

        public bool Hasidentifier()
        {
            return HasDomChild(NodeType.Attribute, "", "identifier");
        }

        public SchemaString GetidentifierAt(int index)
        {
            return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "identifier", index)));
        }

        public SchemaString Getidentifier()
        {
            return GetidentifierAt(0);
        }

        public SchemaString identifier
        {
            get
            {
                return GetidentifierAt(0);
            }
        }

        public void RemoveidentifierAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "identifier", index);
        }

        public void Removeidentifier()
        {
            while (Hasidentifier())
                RemoveidentifierAt(0);
        }

        public void Addidentifier(SchemaString newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "identifier", newValue.ToString());
        }

        public void InsertidentifierAt(SchemaString newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "identifier", index, newValue.ToString());
        }

        public void ReplaceidentifierAt(SchemaString newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "identifier", index, newValue.ToString());
        }
        #endregion // identifier accessor methods

        #region identifier collection
        public identifierCollection Myidentifiers = new identifierCollection();

        public class identifierCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public identifierEnumerator GetEnumerator()
            {
                return new identifierEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class identifierEnumerator : IEnumerator
        {
            int nIndex;
            itemType parent;
            public identifierEnumerator(itemType par)
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
                return (nIndex < parent.identifierCount);
            }
            public SchemaString Current
            {
                get
                {
                    return (parent.GetidentifierAt(nIndex));
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

        #endregion // identifier collection

        #region identifierref accessor methods
        public int GetidentifierrefMinCount()
        {
            return 0;
        }

        public int identifierrefMinCount
        {
            get
            {
                return 0;
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

        public SchemaString GetidentifierrefAt(int index)
        {
            return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "identifierref", index)));
        }

        public SchemaString Getidentifierref()
        {
            return GetidentifierrefAt(0);
        }

        public SchemaString identifierref
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

        public void Addidentifierref(SchemaString newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "identifierref", newValue.ToString());
        }

        public void InsertidentifierrefAt(SchemaString newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "identifierref", index, newValue.ToString());
        }

        public void ReplaceidentifierrefAt(SchemaString newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "identifierref", index, newValue.ToString());
        }
        #endregion // identifierref accessor methods

        #region identifierref collection
        public identifierrefCollection Myidentifierrefs = new identifierrefCollection();

        public class identifierrefCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
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
            itemType parent;
            public identifierrefEnumerator(itemType par)
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
            public SchemaString Current
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

        #region isvisible accessor methods
        public int GetisvisibleMinCount()
        {
            return 0;
        }

        public int isvisibleMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetisvisibleMaxCount()
        {
            return 1;
        }

        public int isvisibleMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetisvisibleCount()
        {
            return DomChildCount(NodeType.Attribute, "", "isvisible");
        }

        public int isvisibleCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "isvisible");
            }
        }

        public bool Hasisvisible()
        {
            return HasDomChild(NodeType.Attribute, "", "isvisible");
        }

        public SchemaBoolean GetisvisibleAt(int index)
        {
            return new SchemaBoolean(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "isvisible", index)));
        }

        public SchemaBoolean Getisvisible()
        {
            return GetisvisibleAt(0);
        }

        public SchemaBoolean isvisible
        {
            get
            {
                return GetisvisibleAt(0);
            }
        }

        public void RemoveisvisibleAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "isvisible", index);
        }

        public void Removeisvisible()
        {
            while (Hasisvisible())
                RemoveisvisibleAt(0);
        }

        public void Addisvisible(SchemaBoolean newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "isvisible", newValue.ToString());
        }

        public void InsertisvisibleAt(SchemaBoolean newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "isvisible", index, newValue.ToString());
        }

        public void ReplaceisvisibleAt(SchemaBoolean newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "isvisible", index, newValue.ToString());
        }
        #endregion // isvisible accessor methods

        #region isvisible collection
        public isvisibleCollection Myisvisibles = new isvisibleCollection();

        public class isvisibleCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public isvisibleEnumerator GetEnumerator()
            {
                return new isvisibleEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class isvisibleEnumerator : IEnumerator
        {
            int nIndex;
            itemType parent;
            public isvisibleEnumerator(itemType par)
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
                return (nIndex < parent.isvisibleCount);
            }
            public SchemaBoolean Current
            {
                get
                {
                    return (parent.GetisvisibleAt(nIndex));
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

        #endregion // isvisible collection

        #region parameters accessor methods
        public int GetparametersMinCount()
        {
            return 0;
        }

        public int parametersMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetparametersMaxCount()
        {
            return 1;
        }

        public int parametersMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetparametersCount()
        {
            return DomChildCount(NodeType.Attribute, "", "parameters");
        }

        public int parametersCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "parameters");
            }
        }

        public bool Hasparameters()
        {
            return HasDomChild(NodeType.Attribute, "", "parameters");
        }

        public SchemaString GetparametersAt(int index)
        {
            return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "parameters", index)));
        }

        public SchemaString Getparameters()
        {
            return GetparametersAt(0);
        }

        public SchemaString parameters
        {
            get
            {
                return GetparametersAt(0);
            }
        }

        public void RemoveparametersAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "parameters", index);
        }

        public void Removeparameters()
        {
            while (Hasparameters())
                RemoveparametersAt(0);
        }

        public void Addparameters(SchemaString newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "parameters", newValue.ToString());
        }

        public void InsertparametersAt(SchemaString newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "parameters", index, newValue.ToString());
        }

        public void ReplaceparametersAt(SchemaString newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "parameters", index, newValue.ToString());
        }
        #endregion // parameters accessor methods

        #region parameters collection
        public parametersCollection Myparameterss = new parametersCollection();

        public class parametersCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public parametersEnumerator GetEnumerator()
            {
                return new parametersEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class parametersEnumerator : IEnumerator
        {
            int nIndex;
            itemType parent;
            public parametersEnumerator(itemType par)
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
                return (nIndex < parent.parametersCount);
            }
            public SchemaString Current
            {
                get
                {
                    return (parent.GetparametersAt(nIndex));
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

        #endregion // parameters collection

        #region title accessor methods
        public int GettitleMinCount()
        {
            return 0;
        }

        public int titleMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GettitleMaxCount()
        {
            return 1;
        }

        public int titleMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GettitleCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title");
        }

        public int titleCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title");
            }
        }

        public bool Hastitle()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title");
        }

        public titleType GettitleAt(int index)
        {
            return new titleType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", index)));
        }

        public titleType Gettitle()
        {
            return GettitleAt(0);
        }

        public titleType title
        {
            get
            {
                return GettitleAt(0);
            }
        }

        public void RemovetitleAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", index);
        }

        public void Removetitle()
        {
            while (Hastitle())
                RemovetitleAt(0);
        }

        public void Addtitle(titleType newValue)
        {
            AppendDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", newValue.ToString());
        }

        public void InserttitleAt(titleType newValue, int index)
        {
            InsertDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", index, newValue.ToString());
        }

        public void ReplacetitleAt(titleType newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "title", index, newValue.ToString());
        }
        #endregion // title accessor methods

        #region title collection
        public titleCollection Mytitles = new titleCollection();

        public class titleCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public titleEnumerator GetEnumerator()
            {
                return new titleEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class titleEnumerator : IEnumerator
        {
            int nIndex;
            itemType parent;
            public titleEnumerator(itemType par)
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
                return (nIndex < parent.titleCount);
            }
            public titleType Current
            {
                get
                {
                    return (parent.GettitleAt(nIndex));
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

        #endregion // title collection


        #region metadata accessor methods
        public int GetmetadataMinCount()
        {
            return 0;
        }

        public int metadataMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetmetadataMaxCount()
        {
            return 1;
        }

        public int metadataMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetmetadataCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata");
        }

        public int metadataCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata");
            }
        }

        public bool Hasmetadata()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata");
        }

        public metadataType GetmetadataAt(int index)
        {
            return new metadataType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", index));
        }

        public metadataType Getmetadata()
        {
            return GetmetadataAt(0);
        }

        public metadataType metadata
        {
            get
            {
                return GetmetadataAt(0);
            }
        }

        public void RemovemetadataAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", index);
        }

        public void Removemetadata()
        {
            while (Hasmetadata())
                RemovemetadataAt(0);
        }

        public void Addmetadata(metadataType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", newValue);
        }

        public void InsertmetadataAt(metadataType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", index, newValue);
        }

        public void ReplacemetadataAt(metadataType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imscp_v1p1", "metadata", index, newValue);
        }
        #endregion // metadata accessor methods

        #region metadata collection
        public metadataCollection Mymetadatas = new metadataCollection();

        public class metadataCollection : IEnumerable
        {
            itemType parent;
            public itemType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public metadataEnumerator GetEnumerator()
            {
                return new metadataEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class metadataEnumerator : IEnumerator
        {
            int nIndex;
            itemType parent;
            public metadataEnumerator(itemType par)
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
                return (nIndex < parent.metadataCount);
            }
            public metadataType Current
            {
                get
                {
                    return (parent.GetmetadataAt(nIndex));
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

        #endregion // metadata collection

        protected virtual void SetCollectionParents()
        {
            Myidentifiers.Parent = this;
            Myidentifierrefs.Parent = this;
            Myisvisibles.Parent = this;
            Myparameterss.Parent = this;
            Mytitles.Parent = this;

            Mymetadatas.Parent = this;
        }
    }
}
