//
// ruleConditionsType4.cs.cs
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
    public class ruleConditionsType4 : Altova.Node
    {
        #region Forward constructors
        public ruleConditionsType4() : base() { SetCollectionParents(); }
        public ruleConditionsType4(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public ruleConditionsType4(XmlNode node) : base(node) { SetCollectionParents(); }
        public ruleConditionsType4(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Attribute, "", "conditionCombination");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "conditionCombination", i);
                InternalAdjustPrefix(DOMNode, false);
            }

            nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition", i);
                InternalAdjustPrefix(DOMNode, true);
                new ruleConditionType4(DOMNode).AdjustPrefix();
            }
        }


        #region conditionCombination accessor methods
        public int GetconditionCombinationMinCount()
        {
            return 0;
        }

        public int conditionCombinationMinCount
        {
            get
            {
                return 0;
            }
        }

        public int GetconditionCombinationMaxCount()
        {
            return 1;
        }

        public int conditionCombinationMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetconditionCombinationCount()
        {
            return DomChildCount(NodeType.Attribute, "", "conditionCombination");
        }

        public int conditionCombinationCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "conditionCombination");
            }
        }

        public bool HasconditionCombination()
        {
            return HasDomChild(NodeType.Attribute, "", "conditionCombination");
        }

        public conditionCombinationType GetconditionCombinationAt(int index)
        {
            return new conditionCombinationType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "conditionCombination", index)));
        }

        public conditionCombinationType GetconditionCombination()
        {
            return GetconditionCombinationAt(0);
        }

        public conditionCombinationType conditionCombination
        {
            get
            {
                return GetconditionCombinationAt(0);
            }
        }

        public void RemoveconditionCombinationAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "conditionCombination", index);
        }

        public void RemoveconditionCombination()
        {
            while (HasconditionCombination())
                RemoveconditionCombinationAt(0);
        }

        public void AddconditionCombination(conditionCombinationType newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "conditionCombination", newValue.ToString());
        }

        public void InsertconditionCombinationAt(conditionCombinationType newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "conditionCombination", index, newValue.ToString());
        }

        public void ReplaceconditionCombinationAt(conditionCombinationType newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "conditionCombination", index, newValue.ToString());
        }
        #endregion // conditionCombination accessor methods

        #region conditionCombination collection
        public conditionCombinationCollection MyconditionCombinations = new conditionCombinationCollection();

        public class conditionCombinationCollection : IEnumerable
        {
            ruleConditionsType4 parent;
            public ruleConditionsType4 Parent
            {
                set
                {
                    parent = value;
                }
            }
            public conditionCombinationEnumerator GetEnumerator()
            {
                return new conditionCombinationEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class conditionCombinationEnumerator : IEnumerator
        {
            int nIndex;
            ruleConditionsType4 parent;
            public conditionCombinationEnumerator(ruleConditionsType4 par)
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
                return (nIndex < parent.conditionCombinationCount);
            }
            public conditionCombinationType Current
            {
                get
                {
                    return (parent.GetconditionCombinationAt(nIndex));
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

        #endregion // conditionCombination collection

        #region ruleCondition accessor methods
        public int GetruleConditionMinCount()
        {
            return 1;
        }

        public int ruleConditionMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetruleConditionMaxCount()
        {
            return Int32.MaxValue;
        }

        public int ruleConditionMaxCount
        {
            get
            {
                return Int32.MaxValue;
            }
        }

        public int GetruleConditionCount()
        {
            return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition");
        }

        public int ruleConditionCount
        {
            get
            {
                return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition");
            }
        }

        public bool HasruleCondition()
        {
            return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition");
        }

        public ruleConditionType4 GetruleConditionAt(int index)
        {
            return new ruleConditionType4(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition", index));
        }

        public ruleConditionType4 GetruleCondition()
        {
            return GetruleConditionAt(0);
        }

        public ruleConditionType4 ruleCondition
        {
            get
            {
                return GetruleConditionAt(0);
            }
        }

        public void RemoveruleConditionAt(int index)
        {
            RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsss", "ruleCondition", index);
        }

        public void RemoveruleCondition()
        {
            while (HasruleCondition())
                RemoveruleConditionAt(0);
        }

        public void AddruleCondition(ruleConditionType4 newValue)
        {
            AppendDomElement("http://www.imsglobal.org/xsd/imsss", "ruleCondition", newValue);
        }

        public void InsertruleConditionAt(ruleConditionType4 newValue, int index)
        {
            InsertDomElementAt("http://www.imsglobal.org/xsd/imsss", "ruleCondition", index, newValue);
        }

        public void ReplaceruleConditionAt(ruleConditionType4 newValue, int index)
        {
            ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsss", "ruleCondition", index, newValue);
        }
        #endregion // ruleCondition accessor methods

        #region ruleCondition collection
        public ruleConditionCollection MyruleConditions = new ruleConditionCollection();

        public class ruleConditionCollection : IEnumerable
        {
            ruleConditionsType4 parent;
            public ruleConditionsType4 Parent
            {
                set
                {
                    parent = value;
                }
            }
            public ruleConditionEnumerator GetEnumerator()
            {
                return new ruleConditionEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class ruleConditionEnumerator : IEnumerator
        {
            int nIndex;
            ruleConditionsType4 parent;
            public ruleConditionEnumerator(ruleConditionsType4 par)
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
                return (nIndex < parent.ruleConditionCount);
            }
            public ruleConditionType4 Current
            {
                get
                {
                    return (parent.GetruleConditionAt(nIndex));
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

        #endregion // ruleCondition collection

        private void SetCollectionParents()
        {
            MyconditionCombinations.Parent = this;
            MyruleConditions.Parent = this;
        }
    }
}
