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
    
    
    public partial class TreePopupDialog {
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private HollyLibrary.HTreeView Tree;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget HollyLibrary.TreePopupDialog
            this.Name = "HollyLibrary.TreePopupDialog";
            this.Title = "TreePopupDialog";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Decorated = false;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Container child HollyLibrary.TreePopupDialog.Gtk.Container+ContainerChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.Tree = new HollyLibrary.HTreeView();
            this.Tree.CanFocus = true;
            this.Tree.Name = "Tree";
            this.Tree.HeadersClickable = true;
            this.Tree.OwnerDraw = false;
            this.Tree.ItemHeight = 0;
            this.Tree.NodeIconVisible = false;
            this.Tree.IsCheckBoxTree = false;
            this.Tree.IsDragAndDropEnable = false;
            this.Tree.Editable = false;
            this.GtkScrolledWindow.Add(this.Tree);
            this.Add(this.GtkScrolledWindow);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 322;
            this.DefaultHeight = 325;
            this.Hide();
            this.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnButtonPressEvent);
            this.Tree.ButtonPressEvent += new Gtk.ButtonPressEventHandler(this.OnTreeButtonPressEvent);
            this.Tree.RowActivated += new Gtk.RowActivatedHandler(this.OnTreeRowActivated);
            this.Tree.CursorChanged += new System.EventHandler(this.OnTreeCursorChanged);
        }
    }
}
