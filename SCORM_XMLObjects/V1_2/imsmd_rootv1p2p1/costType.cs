//
// costType.cs.cs
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
using Altova.Types;

namespace imsmd_rootv1p2p1
{
	public class costType : Altova.Node
	{
		#region Forward constructors
		public costType() : base() { SetCollectionParents(); }
		public costType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public costType(XmlNode node) : base(node) { SetCollectionParents(); }
		public costType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", i);
				InternalAdjustPrefix(DOMNode, true);
				new sourceType(DOMNode).AdjustPrefix();
			}

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", i);
				InternalAdjustPrefix(DOMNode, true);
				new valueType(DOMNode).AdjustPrefix();
			}
		}


		#region source accessor methods
		public int GetsourceMinCount()
		{
			return 1;
		}

		public int sourceMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetsourceMaxCount()
		{
			return 1;
		}

		public int sourceMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetsourceCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source");
		}

		public int sourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source");
			}
		}

		public bool Hassource()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source");
		}

		public sourceType GetsourceAt(int index)
		{
			return new sourceType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", index));
		}

		public sourceType Getsource()
		{
			return GetsourceAt(0);
		}

		public sourceType source
		{
			get
			{
				return GetsourceAt(0);
			}
		}

		public void RemovesourceAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", index);
		}

		public void Removesource()
		{
			while (Hassource())
				RemovesourceAt(0);
		}

		public void Addsource(sourceType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", newValue);
		}

		public void InsertsourceAt(sourceType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", index, newValue);
		}

		public void ReplacesourceAt(sourceType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "source", index, newValue);
		}
		#endregion // source accessor methods

		#region source collection
        public sourceCollection	Mysources = new sourceCollection( );

        public class sourceCollection: IEnumerable
        {
            costType parent;
            public costType Parent
			{
				set
				{
					parent = value;
				}
			}
			public sourceEnumerator GetEnumerator() 
			{
				return new sourceEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class sourceEnumerator: IEnumerator 
        {
			int nIndex;
			costType parent;
			public sourceEnumerator(costType par) 
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
				return(nIndex < parent.sourceCount );
			}
			public sourceType  Current 
			{
				get 
				{
					return(parent.GetsourceAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // source collection

		#region value accessor methods
		public int GetvalueMinCount()
		{
			return 1;
		}

		public int valueMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetvalueMaxCount()
		{
			return 1;
		}

		public int valueMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetvalueCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value");
		}

		public int valueCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value");
			}
		}

		public bool Hasvalue()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value");
		}

		public valueType GetvalueAt(int index)
		{
			return new valueType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", index));
		}

		public valueType Getvalue()
		{
			return GetvalueAt(0);
		}

		public valueType value
		{
			get
			{
				return GetvalueAt(0);
			}
		}

		public void RemovevalueAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", index);
		}

		public void Removevalue()
		{
			while (Hasvalue())
				RemovevalueAt(0);
		}

		public void Addvalue(valueType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", newValue);
		}

		public void InsertvalueAt(valueType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", index, newValue);
		}

		public void ReplacevalueAt(valueType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "value", index, newValue);
		}
		#endregion // value accessor methods

		#region value collection
        public valueCollection	Myvalues = new valueCollection( );

        public class valueCollection: IEnumerable
        {
            costType parent;
            public costType Parent
			{
				set
				{
					parent = value;
				}
			}
			public valueEnumerator GetEnumerator() 
			{
				return new valueEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class valueEnumerator: IEnumerator 
        {
			int nIndex;
			costType parent;
			public valueEnumerator(costType par) 
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
				return(nIndex < parent.valueCount );
			}
			public valueType  Current 
			{
				get 
				{
					return(parent.GetvalueAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // value collection

        private void SetCollectionParents()
        {
            Mysources.Parent = this; 
            Myvalues.Parent = this; 
	}
}
}
