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
    
    
    public partial class FolderChooserDialog {
        
        private Gtk.VBox vbox1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HTreeView FolderTree;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Entry TxtNewFolder;
        
        private Gtk.Button BtnNewFolder;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.FolderChooserDialog
            this.Name = "HollyLibrary.FolderChooserDialog";
            this.Title = Mono.Unix.Catalog.GetString("FolderChooserDialog");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(2));
            this.Decorated = false;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.FocusOnMap = false;
            // Container child HollyLibrary.FolderChooserDialog.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            this.vbox1.BorderWidth = ((uint)(4));
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            this.GtkScrolledWindow.BorderWidth = ((uint)(2));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.FolderTree = null;
            this.GtkScrolledWindow.Add(this.FolderTree);
            this.vbox1.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
            w2.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.vbox1.Add(this.hseparator1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Add new folder:");
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w4.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.TxtNewFolder = new Gtk.Entry();
            this.TxtNewFolder.CanFocus = true;
            this.TxtNewFolder.Name = "TxtNewFolder";
            this.TxtNewFolder.IsEditable = true;
            this.TxtNewFolder.InvisibleChar = '●';
            this.hbox1.Add(this.TxtNewFolder);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.TxtNewFolder]));
            w5.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.BtnNewFolder = new Gtk.Button();
            this.BtnNewFolder.CanFocus = true;
            this.BtnNewFolder.Name = "BtnNewFolder";
            this.BtnNewFolder.UseStock = true;
            this.BtnNewFolder.UseUnderline = true;
            this.BtnNewFolder.Label = "gtk-add";
            this.hbox1.Add(this.BtnNewFolder);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.BtnNewFolder]));
            w6.Position = 2;
            w6.Expand = false;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 355;
            this.DefaultHeight = 271;
            this.Hide();
            this.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnButtonPressEvent);
            this.TxtNewFolder.KeyReleaseEvent += new Gtk.KeyReleaseEventHandler(this.OnTxtNewFolderKeyReleaseEvent);
            this.BtnNewFolder.Clicked += new System.EventHandler(this.OnBtnNewFolderClicked);
            this.BtnNewFolder.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnBtnNewFolderButtonPressEvent);
        }
    }
}
