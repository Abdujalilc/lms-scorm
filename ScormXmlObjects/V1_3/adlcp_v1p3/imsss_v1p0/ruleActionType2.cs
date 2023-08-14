//
// ruleActionType2.cs.cs
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
    public class ruleActionType2 : Altova.Node
    {
        #region Forward constructors
        public ruleActionType2() : base() { SetCollectionParents(); }
        public ruleActionType2(XmlDocument doc) : base(doc) { SetCollectionParents(); }
        public ruleActionType2(XmlNode node) : base(node) { SetCollectionParents(); }
        public ruleActionType2(Altova.Node node) : base(node) { SetCollectionParents(); }
        #endregion // Forward constructors

        public override void AdjustPrefix()
        {
            int nCount;

            nCount = DomChildCount(NodeType.Attribute, "", "action");
            for (int i = 0; i < nCount; i++)
            {
                XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "action", i);
                InternalAdjustPrefix(DOMNode, false);
            }
        }


        #region action accessor methods
        public int GetactionMinCount()
        {
            return 1;
        }

        public int actionMinCount
        {
            get
            {
                return 1;
            }
        }

        public int GetactionMaxCount()
        {
            return 1;
        }

        public int actionMaxCount
        {
            get
            {
                return 1;
            }
        }

        public int GetactionCount()
        {
            return DomChildCount(NodeType.Attribute, "", "action");
        }

        public int actionCount
        {
            get
            {
                return DomChildCount(NodeType.Attribute, "", "action");
            }
        }

        public bool Hasaction()
        {
            return HasDomChild(NodeType.Attribute, "", "action");
        }

        public exitConditionRuleActionType GetactionAt(int index)
        {
            return new exitConditionRuleActionType(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "action", index)));
        }

        public exitConditionRuleActionType Getaction()
        {
            return GetactionAt(0);
        }

        public exitConditionRuleActionType action
        {
            get
            {
                return GetactionAt(0);
            }
        }

        public void RemoveactionAt(int index)
        {
            RemoveDomChildAt(NodeType.Attribute, "", "action", index);
        }

        public void Removeaction()
        {
            while (Hasaction())
                RemoveactionAt(0);
        }

        public void Addaction(exitConditionRuleActionType newValue)
        {
            AppendDomChild(NodeType.Attribute, "", "action", newValue.ToString());
        }

        public void InsertactionAt(exitConditionRuleActionType newValue, int index)
        {
            InsertDomChildAt(NodeType.Attribute, "", "action", index, newValue.ToString());
        }

        public void ReplaceactionAt(exitConditionRuleActionType newValue, int index)
        {
            ReplaceDomChildAt(NodeType.Attribute, "", "action", index, newValue.ToString());
        }
        #endregion // action accessor methods

        #region action collection
        public actionCollection Myactions = new actionCollection();

        public class actionCollection : IEnumerable
        {
            ruleActionType2 parent;
            public ruleActionType2 Parent
            {
                set
                {
                    parent = value;
                }
            }
            public actionEnumerator GetEnumerator()
            {
                return new actionEnumerator(parent);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public class actionEnumerator : IEnumerator
        {
            int nIndex;
            ruleActionType2 parent;
            public actionEnumerator(ruleActionType2 par)
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
                return (nIndex < parent.actionCount);
            }
            public exitConditionRuleActionType Current
            {
                get
                {
                    return (parent.GetactionAt(nIndex));
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

        #endregion // action collection

        private void SetCollectionParents()
        {
            Myactions.Parent = this;
        }
    }
}
