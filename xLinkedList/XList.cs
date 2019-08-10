using System;

namespace xLinkedList
{
	public class XList
	{
		private readonly XNode head;

		public XNode Head => head;

		public XList(XNode head)
		{
			this.head = head;
		}
	}
}
