using System;
using System.Collections;
using System.Collections.Generic;

namespace Innogiant;

public class ObjectPool<T> : IEnumerable<T> where T : new()
{
	public class Node
	{
		public int Index;

		public T Object;
	}

	private sealed class ObjectEnumerator : IEnumerator<T>
	{
		private readonly ObjectPool<T> _pool;
		private int _index;
		private T _current;

		public ObjectEnumerator(ObjectPool<T> pool)
		{
			_pool = pool;
			_index = -1;
		}

		public T Current => _current;

		object IEnumerator.Current => _current;

		public bool MoveNext()
		{
			while (++_index < _pool._capacity)
			{
				if (_pool._activeNodes[_pool._nodes[_index].Index])
				{
					_current = _pool._nodes[_index].Object;
					return true;
				}
			}

			return false;
		}

		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void Dispose()
		{
		}
	}

	private sealed class NodeEnumerator : IEnumerable<Node>, IEnumerator<Node>
	{
		private readonly ObjectPool<T> _pool;
		private int _index;
		private Node _current;

		public NodeEnumerator(ObjectPool<T> pool)
		{
			_pool = pool;
			_index = -1;
		}

		public Node Current => _current;

		object IEnumerator.Current => _current;

		public IEnumerator<Node> GetEnumerator()
		{
			return new NodeEnumerator(_pool);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool MoveNext()
		{
			while (++_index < _pool._capacity)
			{
				if (_pool._activeNodes[_pool._nodes[_index].Index])
				{
					_current = _pool._nodes[_index];
					return true;
				}
			}

			return false;
		}

		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void Dispose()
		{
		}
	}

	public Node[] _nodes;

	public bool[] _activeNodes;

	private Queue<int> m_a;

	public int _capacity;

	public int Count => m_a.Count;

	public IEnumerable<Node> ActiveNodes => new NodeEnumerator(this);

	public ObjectPool(int aCapacity)
	{
		_capacity = aCapacity;
		_nodes = new Node[_capacity];
		_activeNodes = new bool[_capacity];
		m_a = new Queue<int>(_capacity);
		for (int i = 0; i < _capacity; i++)
		{
			_nodes[i] = new Node();
			_nodes[i].Index = i;
			_nodes[i].Object = new T();
			_activeNodes[i] = false;
			m_a.Enqueue(i);
		}
	}

	public void Clear()
	{
		m_a.Clear();
		for (int i = 0; i < _capacity; i++)
		{
			_activeNodes[i] = false;
			m_a.Enqueue(i);
		}
	}

	public Node Alloc()
	{
		int num = m_a.Dequeue();
		_activeNodes[num] = true;
		return _nodes[num];
	}

	public void Free(Node aNode)
	{
		_activeNodes[aNode.Index] = false;
		m_a.Enqueue(aNode.Index);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return new ObjectEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
