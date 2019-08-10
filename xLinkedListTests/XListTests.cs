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
			XNode first = new XNode("1st");
			first.Next = null;

			XList list = new XList(first);

			Assert.IsNotNull(list);
		}
	}
}
