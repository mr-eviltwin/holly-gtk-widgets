
// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class HIpEntry
	{
		private global::Gtk.HBox hbox3;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Entry entry1;
		private global::Gtk.Label label3;
		private global::Gtk.Entry entry2;
		private global::Gtk.Label label4;
		private global::Gtk.Entry entry3;
		private global::Gtk.Label label5;
		private global::Gtk.Entry entry4;
		private global::Gtk.Label Spacer;
		private global::Gtk.EventBox EbIcon;
		private global::Gtk.Image ErrorImage;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.HIpEntry
			global::Stetic.BinContainer.Attach (this);
			this.Name = "HollyLibrary.HIpEntry";
			// Container child HollyLibrary.HIpEntry.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 1;
			this.hbox3.BorderWidth = ((uint)(6));
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.WidthChars = 3;
			this.entry1.MaxLength = 3;
			this.entry1.HasFrame = false;
			this.entry1.InvisibleChar = '●';
			this.entry1.Xalign = 0.5F;
			this.hbox4.Add (this.entry1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry1]));
			w1.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = ".";
			this.hbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label3]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.WidthChars = 3;
			this.entry2.MaxLength = 3;
			this.entry2.HasFrame = false;
			this.entry2.InvisibleChar = '●';
			this.entry2.Xalign = 0.5F;
			this.hbox4.Add (this.entry2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry2]));
			w3.Position = 2;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = ".";
			this.hbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label4]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.WidthChars = 3;
			this.entry3.MaxLength = 3;
			this.entry3.HasFrame = false;
			this.entry3.InvisibleChar = '●';
			this.entry3.Xalign = 0.5F;
			this.hbox4.Add (this.entry3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry3]));
			w5.Position = 4;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = ".";
			this.hbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label5]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			this.hbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.WidthChars = 3;
			this.entry4.MaxLength = 3;
			this.entry4.HasFrame = false;
			this.entry4.InvisibleChar = '●';
			this.entry4.Xalign = 0.5F;
			this.hbox3.Add (this.entry4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry4]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.Spacer = new global::Gtk.Label ();
			this.Spacer.Name = "Spacer";
			this.hbox3.Add (this.Spacer);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.Spacer]));
			w9.Position = 2;
			// Container child hbox3.Gtk.Box+BoxChild
			this.EbIcon = new global::Gtk.EventBox ();
			this.EbIcon.Name = "EbIcon";
			this.EbIcon.VisibleWindow = false;
			// Container child EbIcon.Gtk.Container+ContainerChild
			this.ErrorImage = new global::Gtk.Image ();
			this.ErrorImage.Name = "ErrorImage";
			this.EbIcon.Add (this.ErrorImage);
			this.hbox3.Add (this.EbIcon);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.EbIcon]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			this.Add (this.hbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
