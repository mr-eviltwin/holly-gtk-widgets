using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using HollyLibrary;
using Gtk;


namespace test
{
	
	public class TreeView : Window
	{
		//the tree widget
		HTreeView tree       = new HTreeView();
		//buttons
		Button BtnAddNode    = new Button("Add node");
		Button BtnRemoveNode = new Button("Remove node");
		Button BtnEditNode   = new Button("Edit node");
		//checkboxes
		CheckButton ChkNodeIconVisible = new CheckButton("Node icon is visible");
		CheckButton ChkCheckBoxTree    = new CheckButton("Tree is checkbox tree");
		CheckButton ChkEditableTree    = new CheckButton("Tree is editable");
		CheckButton ChkOwnerDrawn      = new CheckButton("Tree is OwnerDrawn");
		CheckButton ChkDragAndDrop     = new CheckButton("Drag and drop enabled");
		
		public TreeView() : base( WindowType.Toplevel )
		{
			this.Title          = "HTreeView demo";
			this.WindowPosition = Gtk.WindowPosition.CenterAlways;
			this.Resize( 320, 240 );
			//
			initGui();
			//
			tree.DrawItem              +=  OnItemDrawn;
			//button events
			BtnAddNode.Clicked         += OnBtnAddClicked;
			BtnEditNode.Clicked        += OnBtnEditClicked;
			BtnRemoveNode.Clicked      += OnBtnRemoveClicked;
			//checkbox events
			ChkCheckBoxTree.Toggled    += OnCheckBoxChecked;
			ChkEditableTree.Toggled    += OnEditableChecked;
			ChkNodeIconVisible.Toggled += OnNodeIconChecked;
			ChkOwnerDrawn.Toggled      += OnChkOwnerDrawnChecked;
			ChkDragAndDrop.Toggled     += OnChkDragAndDropChecked;
			//make the tree to show icons by default
			ChkNodeIconVisible.Active   = true;	
		}
		
		private void OnItemDrawn( object sender, DrawItemEventArgs args )
		{
			//take the text
			String text      = tree.getNodeFromIter( args.Iter ).Text;
			//take font from style
			Font font        = new Font( "Courier New" , 14F );
			// take color from style
			Color c          = Color.DarkCyan;
			Brush b          = new SolidBrush( c );
			//set quality to HighSpeed
			args.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
			args.Graphics.DrawString( text, font, b, args.CellArea.X, args.CellArea.Y );
			args.Graphics.Dispose();
		}
		
		private void OnBtnAddClicked( object sender, EventArgs args )
		{
			//make a icon from a stock image
			Gdk.Pixbuf icon = GraphUtil.pixbufFromStock("gtk-yes", IconSize.Button );
			//create the new node
			HTreeNode node  = new HTreeNode( "new node!", icon );
			//check if there is a node selected
			HTreeNode selected_node = tree.SelectedNode;
			//if no node is selected, add the new node directly to the base
			if( selected_node == null )
				tree.Nodes.Add( node );
			else
				selected_node.Nodes.Add( node );
		}
		
		private void OnBtnEditClicked( object sender, EventArgs args )
		{
			//change the text/icon to the selected node
			HTreeNode node = tree.SelectedNode;
			if( node != null )
			{
				node.Text = "new and shiny modified value!";
				node.Icon = GraphUtil.pixbufFromStock("gtk-add", IconSize.Button );
			}
		}
		
		private void OnBtnRemoveClicked( object sender, EventArgs args )
		{
			//remove the selected node
			HTreeNode node = tree.SelectedNode;
			if( node != null )
			{
				if( node.ParentNode == null )
					tree.Nodes.Remove( node );
				else
					node.ParentNode.Nodes.Remove( node );
			}
		}
		
		
		private void OnChkDragAndDropChecked( object sender, EventArgs args )
		{
			tree.IsDragAndDropEnable = ChkDragAndDrop.Active;
		}
		
		private void OnCheckBoxChecked( object sender, EventArgs args )
		{
			tree.IsCheckBoxTree = ChkCheckBoxTree.Active;
		}
		
		private void OnEditableChecked( object sender, EventArgs args )
		{
			tree.Editable = ChkEditableTree.Active;
		}
		
		private void OnNodeIconChecked( object sender, EventArgs args )
		{
			tree.NodeIconVisible = ChkNodeIconVisible.Active;
		}
		
		private void OnChkOwnerDrawnChecked( object sender, EventArgs args )
		{
			tree.OwnerDraw = ChkOwnerDrawn.Active;
		}
		
		private void initGui()
		{
			//create the layout
			VBox layout = new VBox();
			//add the treeview
			ScrolledWindow swTree = new ScrolledWindow();
			swTree.AddWithViewport( tree );
			layout.PackStart( swTree );
			//add the add/edit/remove buttons
			HBox hbox = new HBox();
			hbox.PackStart  ( BtnAddNode    );
			hbox.PackStart  ( BtnEditNode   );
			hbox.PackStart  ( BtnRemoveNode );
			layout.PackStart( hbox, false, true, 0 );
			//add the checkboxes
			hbox      = new HBox();
			hbox.PackStart  ( ChkNodeIconVisible );
			hbox.PackStart  ( ChkCheckBoxTree    );
			hbox.PackStart  ( ChkEditableTree    );
			hbox.PackStart  ( ChkOwnerDrawn      );
			hbox.PackStart  ( ChkDragAndDrop     );
			layout.PackStart( hbox, false, true, 0 );
			//add layout
			this.Add( layout );
		}
		
	}
}
