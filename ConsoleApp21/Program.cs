using System;

namespace ConsoleApp21
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}
	public class Gen<T>
	{
		private Array[] _B;
		private int _addP = 0;
		private int _getP = 0;

		public Gen()
		{
			_B = new Array[100];
		}

		public void Add(Array item)
		{
			_B[_addP] = item;
			_addP++;
		}
		public T Get()
		{
			T item = _B[_getP];
			_getP++;
			return item;
		}


	}
}
