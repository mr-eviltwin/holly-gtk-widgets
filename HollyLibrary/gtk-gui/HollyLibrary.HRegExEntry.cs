
// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class HRegExEntry
	{
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry TextBox;
		private global::Gtk.EventBox EbErrorImage;
		private global::Gtk.Image ErrorImage;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.HRegExEntry
			global::Stetic.BinContainer.Attach (this);
			this.Name = "HollyLibrary.HRegExEntry";
			// Container child HollyLibrary.HRegExEntry.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(5));
			// Container child hbox1.Gtk.Box+BoxChild
			this.TextBox = new global::Gtk.Entry ();
			this.TextBox.CanFocus = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.IsEditable = true;
			this.TextBox.HasFrame = false;
			this.TextBox.InvisibleChar = '●';
			this.hbox1.Add (this.TextBox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.TextBox]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.EbErrorImage = new global::Gtk.EventBox ();
			this.EbErrorImage.Name = "EbErrorImage";
			this.EbErrorImage.VisibleWindow = false;
			// Container child EbErrorImage.Gtk.Container+ContainerChild
			this.ErrorImage = new global::Gtk.Image ();
			this.ErrorImage.Name = "ErrorImage";
			this.EbErrorImage.Add (this.ErrorImage);
			this.hbox1.Add (this.EbErrorImage);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.EbErrorImage]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.TextBox.Changed += new global::System.EventHandler (this.OnTextBoxChanged);
		}
	}
}
