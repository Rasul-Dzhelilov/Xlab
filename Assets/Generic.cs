using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour
{
	void Start()
	{
		MyList<MyClass> list = new MyList<MyClass>();

		list.Push(new MyClass());
	}

	public class MyClass
	{
		public int i;
		public int j;
	}
	public struct MyStruct
	{
		public int i;
		public int j;
	}

	public class MyList<T>
	{
		private T[] array = new T[4];

		public int Count { get; }

		public void Push(T item)
		{

		}
		public void Insert(T item, int index)
		{

		}

		public void IndexOf(T item)
		{

		}
	}

	public void Foo<T>()
	{
		Debug.Log("Foo();");
	}
}