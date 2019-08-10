using System;
using System.Collections.Generic;
using System.Text;

namespace xLinkedList
{
	public class XNode
	{
		private readonly object data;

		private readonly XNode next;

		public object Data => data;

		public XNode Next => next;

		public XNode(object data, XNode next)
		{
			this.data = data;
			this.next = next;
		}
	}
}
