// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HollyLibrary {
    
    
    public partial class HImageCheckBox {
        
        private Gtk.EventBox eventbox1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image ImgCheck;
        
        private Gtk.Label LblText;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.HImageCheckBox
            Stetic.BinContainer.Attach(this);
            this.Name = "HollyLibrary.HImageCheckBox";
            // Container child HollyLibrary.HImageCheckBox.Gtk.Container+ContainerChild
            this.eventbox1 = new Gtk.EventBox();
            this.eventbox1.Name = "eventbox1";
            // Container child eventbox1.Gtk.Container+ContainerChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.ImgCheck = new Gtk.Image();
            this.ImgCheck.Name = "ImgCheck";
            this.hbox1.Add(this.ImgCheck);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.ImgCheck]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.LblText = new Gtk.Label();
            this.LblText.Name = "LblText";
            this.LblText.Xalign = 0F;
            this.LblText.LabelProp = Mono.Unix.Catalog.GetString("text");
            this.hbox1.Add(this.LblText);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.LblText]));
            w2.Position = 1;
            this.eventbox1.Add(this.hbox1);
            this.Add(this.eventbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
