// HBaseComboBox.cs created with MonoDevelop
// User: dantes at 11:03 AM 5/15/2008
//

using System;
using Gtk;

namespace HollyLibrary
{
	
	
	internal partial class HBaseComboBox : Gtk.Bin
	{
		
		public HBaseComboBox()
		{
			this.AppPaintable   = true;
			this.Build();
		}
		
		[GLib.ConnectBefore]
		protected override bool OnExposeEvent (Gdk.EventExpose evnt)
		{
			Gdk.Rectangle rect = new Gdk.Rectangle( Allocation.X, Allocation.Y, Allocation.Width , Allocation.Height );
			
			
			
			//in loc de Gtk.ShadowType.None era Entry.ShadowType
			
			Gtk.Style.PaintFlatBox( Entry.Style, this.GdkWindow, Entry.State, Gtk.ShadowType.In, this.Allocation, Entry, "entry_bg", rect.X, rect.Y, rect.Width, rect.Height );
			Gtk.Style.PaintShadow ( Entry.Style, this.GdkWindow, Entry.State, Gtk.ShadowType.In, this.Allocation, Entry, "entry"   , rect.X, rect.Y, rect.Width, rect.Height );
			
			return base.OnExposeEvent (evnt);
		}

		protected virtual void OnEntryFocusInEvent (object o, Gtk.FocusInEventArgs args)
		{
			QueueDraw();
		}

		protected virtual void OnEntryFocusOutEvent (object o, Gtk.FocusOutEventArgs args)
		{
			QueueDraw();
		}
		
		public Entry Entry 
		{
			get 
			{
				return entry;
			}
		}

		public Button PopupButton 
		{
			get 
			{
				return popupButton;
			}
		}
	}
}
