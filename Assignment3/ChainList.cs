using Assignment3;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ChainList<T> : ILinkedListADT<T>
{
	public Node<T> First { get; private set; }
	
	public Node<T> Last { get; private set; }

	public int Count { get; private set; }		
	
	public ChainList()
	{
		this.First = null;	
		this.Last= null;	
	}
}
