using System;
using System.Collections.Generic;
using System.Text;

namespace xLinkedList
{
	public class XNode
	{
		private readonly object data;

		public object Data => data;

		public XNode Next { get; set; }

		public XNode(object data)
		{
			this.data = data;
		}
	}
}
