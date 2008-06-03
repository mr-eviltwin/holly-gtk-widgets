// ObjectCollection.cs created with MonoDevelop
// User: dantes at 11:39 AM 5/17/2008
//

using System;
using System.Collections;
using System.Collections.Generic;
using HollyLibrary;

namespace HollyLibrary
{

	public class ObjectCollection : CollectionBase
	{
		
		public event ListAddEventHandler OnItemAdded;
		public event ListRemoveEventHandler OnItemRemoved;
		public event ListUpdateEventHandler OnItemUpdated;
		

		public void AddRange( object[] objects )
		{
			foreach( object obj in objects )
			{
				this.Add( obj );
			}
		}
		
		public void Add (object item)
		{
			
			List.Add(item);
			if( OnItemAdded != null ) 
				OnItemAdded( this, new ListAddEventArgs( item ) );
		}
		
		public object this[int index]
		{
			get
			{
				return this.List[index];
			}
			set
			{
				if( index >=0 && index < this.List.Count )
				{
					this.List[index] = value;
					if( OnItemUpdated != null) 
						OnItemUpdated( this, new ListUpdateEventArgs( index, value ) );
				}
			}
		}
		
		internal void Sort()
		{
			this.InnerList.Sort();
		}
		
		internal void Sort( IComparer comparer )
		{
			this.InnerList.Sort(comparer);
		}
		
		public new void RemoveAt( int index )
		{
			if( index >=0 && index < this.List.Count )
				Remove( this.List[index] );
		}
		
		public void Remove( object item )
		{
			int index = this.List.IndexOf(item);
			this.List.Remove(item);
			if( OnItemRemoved != null ) 
				OnItemRemoved( this, new ListRemoveEventArgs( index ) );
		}
		
		public bool Contains (object item)
		{
			return this.List.Contains(item);
		}
		
		public int IndexOf( object item )
		{
			return this.List.IndexOf(item);
		}
		
		public new void Clear()
		{
			for( int i = this.List.Count - 1; i >=0; i-- )
			{
				RemoveAt(i);
			}
		}

	}
}
