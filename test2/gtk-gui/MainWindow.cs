// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private HollyLibrary.HSimpleComboBox hsimplecombobox1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.hsimplecombobox1 = new HollyLibrary.HSimpleComboBox();
        this.hsimplecombobox1.Events = ((Gdk.EventMask)(256));
        this.hsimplecombobox1.Name = "hsimplecombobox1";
        this.hsimplecombobox1.IsEditable = false;
        this.hsimplecombobox1.DropDownHeight = 0;
        this.Add(this.hsimplecombobox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 400;
        this.DefaultHeight = 60;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}