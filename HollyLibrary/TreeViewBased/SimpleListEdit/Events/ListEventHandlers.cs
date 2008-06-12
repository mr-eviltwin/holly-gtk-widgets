// ListEventHandlers.cs created with MonoDevelop
// User: dantes at 11:35 AM 5/17/2008
//

using System;

namespace HollyLibrary
{
	
	public class ListItemRightClickEventArgs
	{
		int itemIndex;
		
		public int ItemIndex 
		{
			get 
			{
				return itemIndex;
			}
		}
		
		public ListItemRightClickEventArgs( int itemIndex )
		{
			this.itemIndex = itemIndex;
		}
		
	}
	
	public class ListItemCheckEventArgs : EventArgs
	{
		int itemIndex;
		bool newValue;
		
		public ListItemCheckEventArgs( int itemIndex, bool newValue )
		{
			this.itemIndex = itemIndex;
			this.newValue  = newValue;
		}
		
		public bool NewValue
		{
			get
			{
				return newValue;
			}
		}
		
		public int ItemIndex
		{
			get 
			{
				return itemIndex;
			}
		}
		
	}
	
	public class ListUpdateEventArgs : EventArgs
	{
		private object new_value;
		private int index;
		
		public object NewValue 
		{
			get 
			{
				return new_value;
			}
		}

		public int Index 
		{
			get
			{
				return index;
			}
		}

		public ListUpdateEventArgs( int index, object new_value )
		{
			this.new_value = new_value;
			this.index     = index;
		}
	}
	
	public class ListInsertEventArgs : EventArgs
	{
		private object val;
		private int index;
		
		public object Value 
		{
			get 
			{
				return val;
			}
		}

		public int Index 
		{
			get 
			{
				return index;
			}
		}
		
		public ListInsertEventArgs( int index, object val )
		{
			this.index = index;
			this.val   =  val;
		}
	}
	
	public class ListAddEventArgs : EventArgs
	{
		private object val;
		
		public object Value 
		{
			get 
			{
				return val;
			}
		}
		
		public ListAddEventArgs( object val )
		{
			this.val =  val;
		}
	}
	
	public class ListRemoveEventArgs : EventArgs
	{
		private int index;
		
		public int Index 
		{
			get 
			{
				return index;
			}
		}
		
		public ListRemoveEventArgs( int index )
		{
			this.index = index;
		}
	}
	
	public delegate void ListRemoveEventHandler ( object sender, ListRemoveEventArgs args  );
	public delegate void ListAddEventHandler    ( object sender, ListAddEventArgs args     );
	public delegate void ListInsertEventHandler ( object sender, ListInsertEventArgs args  );
	public delegate void ListUpdateEventHandler ( object sender, ListUpdateEventArgs args  );
	//
	public delegate void MeasureItemEventHandler( object sender, MeasureItemEventArgs args );
	public delegate void DrawItemEventHandler   ( object sender, DrawItemEventArgs args    );
	//
	public delegate void ListItemCheck      ( object sender, ListItemCheckEventArgs args );
	public delegate void ListItemRightClick ( object sender, ListItemRightClickEventArgs args );
	
		
}
