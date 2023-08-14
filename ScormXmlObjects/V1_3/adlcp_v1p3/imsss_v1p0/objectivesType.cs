//
// objectivesType.cs.cs
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

namespace imsss_v1p0
{
    public class objectivesType : Altova.Node
    {
        #region Forward constructors
        public objectivesType() : base() { SetCollectionParents(); }
        public objectivesType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public objectivesType(XmlNode node) : base(node) { SetCollectionParents(); }
        public objectivesType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective", i);
                InternalAdjustPrefix(DOMNode, true);
                new primaryObjectiveType(DOMNode).AdjustPrefix();
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective", i);
                InternalAdjustPrefix(DOMNode, true);
                new objectiveType(DOMNode).AdjustPrefix();
            }
        }


        #region primaryObjective accessor methods
        public int GetprimaryObjectiveMinCount()
        {
            return 1;
        }

        public int primaryObjectiveMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetprimaryObjectiveMaxCount()
        {
            return 1;
        }

        public int primaryObjectiveMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetprimaryObjectiveCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective");
        }

        public int primaryObjectiveCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective");
            }
        }

        public bool HasprimaryObjective()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective");
        }

        public primaryObjectiveType GetprimaryObjectiveAt(int index)
        {
            return new primaryObjectiveType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective", index));
        }

        public primaryObjectiveType GetprimaryObjective()
        {
            return GetprimaryObjectiveAt(0);
        }

        public primaryObjectiveType primaryObjective
        {
            get
            {
                return GetprimaryObjectiveAt(0);
            }
        }

        public void RemoveprimaryObjectiveAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "primaryObjective", index);
        }

        public void RemoveprimaryObjective()
        {
            while (HasprimaryObjective())
                RemoveprimaryObjectiveAt(0);
        }

        public void AddprimaryObjective(primaryObjectiveType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsss", "primaryObjective", newValue);
        }

        public void InsertprimaryObjectiveAt(primaryObjectiveType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "primaryObjective", index, newValue);
        }

        public void ReplaceprimaryObjectiveAt(primaryObjectiveType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "primaryObjective", index, newValue);
        }
        #endregion // primaryObjective accessor methods

        #region primaryObjective collection
        public primaryObjectiveCollection MyprimaryObjectives = new primaryObjectiveCollection();

        public class primaryObjectiveCollection : IEnumerable
        {
            objectivesType parent;
            public objectivesType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public primaryObjectiveEnumerator GetEnumerator()
            {
                return new primaryObjectiveEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class primaryObjectiveEnumerator : IEnumerator
        {
            int nIndex;
            objectivesType parent;
            public primaryObjectiveEnumerator(objectivesType par)
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
                return (nIndex < parent.primaryObjectiveCount);
            }
            public primaryObjectiveType Current
            {
                get
                {
                    return (parent.GetprimaryObjectiveAt(nIndex));
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

        #endregion // primaryObjective collection

        #region objective accessor methods
        public int GetobjectiveMinCount()
        {
            return 0;
        }

        public int objectiveMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetobjectiveMaxCount()
        {
            return Int32.MaxValue;
        }

        public int objectiveMaxCount
        {
            get
            {
                return Int32.MaxValue;
            }
        }

        public int GetobjectiveCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective");
        }

        public int objectiveCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective");
            }
        }

        public bool Hasobjective()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective");
        }

        public objectiveType GetobjectiveAt(int index)
        {
            return new objectiveType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective", index));
        }

        public objectiveType Getobjective()
        {
            return GetobjectiveAt(0);
        }

        public objectiveType objective
        {
            get
            {
                return GetobjectiveAt(0);
            }
        }

        public void RemoveobjectiveAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "objective", index);
        }

        public void Removeobjective()
        {
            while (Hasobjective())
                RemoveobjectiveAt(0);
        }

        public void Addobjective(objectiveType newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsss", "objective", newValue);
        }

        public void InsertobjectiveAt(objectiveType newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "objective", index, newValue);
        }

        public void ReplaceobjectiveAt(objectiveType newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "objective", index, newValue);
        }
        #endregion // objective accessor methods

        #region objective collection
        public objectiveCollection Myobjectives = new objectiveCollection();

        public class objectiveCollection : IEnumerable
        {
            objectivesType parent;
            public objectivesType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public objectiveEnumerator GetEnumerator()
            {
                return new objectiveEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class objectiveEnumerator : IEnumerator
        {
            int nIndex;
            objectivesType parent;
            public objectiveEnumerator(objectivesType par)
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
                return (nIndex < parent.objectiveCount);
            }
            public objectiveType Current
            {
                get
                {
                    return (parent.GetobjectiveAt(nIndex));
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

        #endregion // objective collection

        private void SetCollectionParents()
        {
            MyprimaryObjectives.Parent = this;
            Myobjectives.Parent = this;
        }
    }
}
