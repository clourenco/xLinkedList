using System;
using System.Collections.Generic;
using System.Text;

namespace xLinkedList
{
	/// <summary>
	/// Represents a linked list node
	/// </summary>
	public class XNode
	{
		private readonly string data;

		/// <summary>
		/// Content of the node
		/// </summary>
		public string Data => data;

		/// <summary>
		/// Next node pointer
		/// </summary>
		public XNode Next { get; set; }

		/// <summary>
		/// Creates a new node
		/// </summary>
		/// <param name="data">The data parameter</param>
		public XNode(string data)
		{
			this.data = data;
		}
	}
}
