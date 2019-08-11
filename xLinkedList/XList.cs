using System;

namespace xLinkedList
{
	/// <summary>
	/// Represents a linked list
	/// </summary>
	public class XList
	{
		private readonly XNode head;

		/// <summary>
		/// Head node of the linked list
		/// </summary>
		public XNode Head => head;

		/// <summary>
		/// Creates a new linked list
		/// </summary>
		/// <param name="head"></param>
		public XList(XNode head)
		{
			this.head = head ?? throw new ArgumentNullException(nameof(head));
		}

		/// <summary>
		/// Finds a node by data
		/// </summary>
		/// <param name="data">The data parameter</param>
		/// <returns>The found node null otherwise</returns>
		public XNode Find(string data)
		{
			XNode retVal = null;

			if (data == null)
			{
				throw new ArgumentNullException(nameof(data));
			}

			XNode current = head;

			while (current != null)
			{
				if (current.Data == data)
				{
					retVal = current;
					break;
				}

				current = current.Next;
			}

			return retVal;
		}

		/// <summary>
		/// Adds a new node with the specified data
		/// </summary>
		/// <param name="data">The data parameter</param>
		public void Add(string data)
		{
			XNode headCurrentNode = head.Next;
			XNode newNode = new XNode(data);

			newNode.Next = headCurrentNode;
			head.Next = newNode;
		}

		/// <summary>
		/// Removes the node with the specified data 
		/// </summary>
		/// <param name="data">The data parameter</param>
		public void Remove(string data)
		{
			if (data == null)
			{
				throw new ArgumentNullException(nameof(data));
			}

			XNode previous = null;
			XNode current = head;

			while (current != null && current.Data != data)
			{
				previous = current;
				current = current.Next;
			}

			if (current != null && previous != null)
			{
				previous.Next = current.Next;
			}
		}

		
	}
}
