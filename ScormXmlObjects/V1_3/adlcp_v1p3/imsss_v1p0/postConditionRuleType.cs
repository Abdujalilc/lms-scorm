//
// postConditionRuleType.cs.cs
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

namespace imsss_v1p0
{
    public class postConditionRuleType : sequencingRuleType
    {
        #region Forward constructors
        public postConditionRuleType() : base() { SetCollectionParents(); }
        public postConditionRuleType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public postConditionRuleType(XmlNode node) : base(node) { SetCollectionParents(); }
        public postConditionRuleType(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction", i);
                InternalAdjustPrefix(DOMNode, true);
                new ruleActionType3(DOMNode).AdjustPrefix();
            }
        }


        #region ruleAction accessor methods
        public int GetruleActionMinCount()
        {
            return 1;
        }

        public int ruleActionMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetruleActionMaxCount()
        {
            return 1;
        }

        public int ruleActionMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetruleActionCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction");
        }

        public int ruleActionCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction");
            }
        }

        public bool HasruleAction()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction");
        }

        public ruleActionType3 GetruleActionAt(int index)
        {
            return new ruleActionType3(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction", index));
        }

        public ruleActionType3 GetruleAction()
        {
            return GetruleActionAt(0);
        }

        public ruleActionType3 ruleAction
        {
            get
            {
                return GetruleActionAt(0);
            }
        }

        public void RemoveruleActionAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleAction", index);
        }

        public void RemoveruleAction()
        {
            while (HasruleAction())
                RemoveruleActionAt(0);
        }

        public void AddruleAction(ruleActionType3 newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsss", "ruleAction", newValue);
        }

        public void InsertruleActionAt(ruleActionType3 newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "ruleAction", index, newValue);
        }

        public void ReplaceruleActionAt(ruleActionType3 newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "ruleAction", index, newValue);
        }
        #endregion // ruleAction accessor methods

        #region ruleAction collection
        public ruleActionCollection MyruleActions = new ruleActionCollection();

        public class ruleActionCollection : IEnumerable
        {
            postConditionRuleType parent;
            public postConditionRuleType Parent
            {
                set
                {
                    parent = value;
                }
            }
            public ruleActionEnumerator GetEnumerator()
            {
                return new ruleActionEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class ruleActionEnumerator : IEnumerator
        {
            int nIndex;
            postConditionRuleType parent;
            public ruleActionEnumerator(postConditionRuleType par)
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
                return (nIndex < parent.ruleActionCount);
            }
            public ruleActionType3 Current
            {
                get
                {
                    return (parent.GetruleActionAt(nIndex));
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

        #endregion // ruleAction collection

        private void SetCollectionParents()
        {
            MyruleActions.Parent = this;
        }
    }
}
