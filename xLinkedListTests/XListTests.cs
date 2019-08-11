using Microsoft.VisualStudio.TestTools.UnitTesting;
using xLinkedList;

namespace xLinkedListTests
{
	[TestClass]
	public class XListTests
	{
		[TestMethod]
		public void CreateXList_WithHeadParameterAsNull_Works()
		{
			XList list = new XList(null);

			Assert.IsNotNull(list);
		}

		[TestMethod]
		public void CreateXList_WithHeadParameterAsXNode_Works()
		{
			XNode first = new XNode("first");
			first.Next = null;

			XList list = new XList(first);

			Assert.IsNotNull(list);
		}

		[TestMethod]
		public void AddNodeToXList_WithValidDataParameter_Works()
		{
			XNode first = new XNode("first");
			first.Next = null;

			XList list = new XList(first);
			list.Add("second");

			XNode head = list.Head;
			XNode second = list.Head.Next;

			Assert.IsNotNull(second);
		}

		[TestMethod]
		public void FindNodeInXList_WithValidDataParameter_Works()
		{
			XNode first = new XNode("first");
			first.Next = null;

			XList list = new XList(first);

			list.Add("second");
			list.Add("third");
			list.Add("fourth");

			XNode found = list.Find("second");

			Assert.IsNotNull(found);
		}

		[TestMethod]
		public void RemoveNodeInXList_WithValidDataParameter_Works()
		{
			XNode first = new XNode("first");
			first.Next = null;

			XList list = new XList(first);

			list.Add("second");
			list.Add("third");
			list.Add("fourth");

			list.Remove("third");
			XNode found = list.Find("third");

			Assert.IsNull(found);
		}


	}
}
