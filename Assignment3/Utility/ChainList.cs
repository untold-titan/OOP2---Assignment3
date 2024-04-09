using Assignment3;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for Class1
/// </summary>

[DataContract]
[KnownType(typeof(List<User>))]
public class ChainList : ILinkedListADT
{
    [DataMember]
	public Node<User> First { get; private set; }
	
	public Node<User> Last { get; private set; }

	public int NodeCount { get; private set; }		
	
	public ChainList()
	{
		this.First = null;	
		this.Last = null;
	}

    public bool IsEmpty()
    {
        if (this.First == null)
        {
            return true;
        }
        return false;
    }

    public void Clear()
    {
        First = null;
        Last = null;
    }

    public void AddLast(User value)
    {
        if (this.Last == null)
        {
            var newNode = new Node<User>(value);
            this.First = newNode;
            this.Last = newNode;
        }
        else
        {
            var newNode = new Node<User>(value);
            Last.Next = newNode;
            Last = newNode;
        }
        NodeCount++;
    }

    public void AddFirst(User value)
    {
        if(First == null)
        {
            // No elements in list
            var newNode = new Node<User>(value);
            First = newNode;
            Last = newNode;
        }
        else
        {
            var newFirst = new Node<User>(value);
            newFirst.Next = First;
            First = newFirst;
        }
        NodeCount++;
    }

    public void Add(User value, int index)
    {
        if(index > NodeCount)
        {
            throw new IndexOutOfRangeException();
        }
        Node<User> currentNode = First;
        for(var i = 0; i != index - 1; i++)
        {
            currentNode = currentNode.Next;
        }
        var newNode = new Node<User>(value);
        newNode.Next = currentNode.Next;
        currentNode.Next = newNode;
    }

    public void Replace(User value, int index)
    {
        if (index > NodeCount)
        {
            throw new IndexOutOfRangeException();
        }
        Node<User> currentNode = First;
        for (var i = 0; i != index - 1; i++)
        {
            currentNode = currentNode.Next;
        }
        var newNode = new Node<User>(value);
        newNode.Next = currentNode.Next;
        currentNode.Next = newNode;
    }

    public void RemoveFirst()
    {
        First = First.Next;
        Last.Next = First;
    }

    public void RemoveLast()
    {
        Node<User> currentNode = First;
        for (var i = 0; i != NodeCount - 2; i++)
        {
            currentNode = currentNode.Next;
        }
        Last = currentNode;
        Last.Next = First;
    }

    public void Remove(int index)
    {
        if (index > NodeCount)
        {
            throw new IndexOutOfRangeException();
        }
        Node<User> currentNode = First;
        for (var i = 0; i != index - 1; i++)
        {
            currentNode = currentNode.Next;
        }
        currentNode.Next = currentNode.Next.Next;
    }

    public User GetValue(int index)
    {
        if (index > NodeCount)
        {
            throw new IndexOutOfRangeException();
        }
        Node<User> currentNode = First;
        for (var i = 0; i != index; i++)
        {
            currentNode = currentNode.Next;
        }
        return currentNode.Data;
    }

    public int IndexOf(User value)
    {
        Node<User> currentNode = First;
        if (currentNode.Data.Equals(value))
        {
            return 0;
        }
        for (var i = 0; i != NodeCount - 1; i++)
        {
            currentNode = currentNode.Next;
            if (currentNode.Data.Equals(value))
            {
                return i + 1;
            }
        }
        return -1;
    }

    public bool Contains(User value)
    {
        Node<User> currentNode = First;
        if (currentNode.Data.Equals(value))
        {
            return true;
        }
        for (var i = 0; i != NodeCount - 1; i++)
        {
            currentNode = currentNode.Next;
            if (currentNode.Data.Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    public User[] toArray()
    {
        var array = new List<User>();
        var currentNode = First;
        array.Add(currentNode.Data);
        int i = 1;
        for (; ; )
        {
            if (currentNode.Next == null)
            {
                return array.ToArray();
            }
            if (currentNode.Equals(First) && i > 1)
            {
                return array.ToArray();
            }
            currentNode = currentNode.Next;
            array.Add(currentNode.Data);
            i++;
        }

    }

    public int Count()
    {
        int i = 1;
        if(First == null )
        {
            return 0;
        }
        var currentNode = First;
        for (; ; )
        {
            if (currentNode.Next == null)
            {
                NodeCount = i;
                return i;
            }
            if(currentNode.Equals(First) && i > 1)
            {
                NodeCount = i;
                return i;
            }
            currentNode = currentNode.Next;
            i++;
        }
    }
}
