// FolderChooserDialog.cs created with MonoDevelop
// User: dantes at 11:23 AM 5/28/2008
//

using System;
using System.IO;
using System.Collections.Generic;

namespace HollyLibrary
{
	
	
	public partial class FolderChooserDialog : Gtk.Window
	{
		HComboFolder father;
		char separator         = System.IO.Path.DirectorySeparatorChar;
		Gdk.Pixbuf folder_icon, drive_icon;
		
		public FolderChooserDialog( HComboFolder father ) : 
				base(Gtk.WindowType.Popup)
		{
			folder_icon = new Gdk.Pixbuf( this.GetType().Assembly, "folder.png");
			drive_icon  = new Gdk.Pixbuf( this.GetType().Assembly, "drive.png");
			
			this.father = father;
			this.Build();
			//incarca baza
			DriveInfo[] difs = DriveInfo.GetDrives();
			foreach( DriveInfo di in difs )
			{
				// adauga doar discurile fixe
				if( di.DriveType == DriveType.Fixed )
					FolderTree.Nodes.Add( new HTreeNode( di.Name, drive_icon ) );
			}
			//add dummy childs
			foreach( HTreeNode node in FolderTree.Nodes )
			{
				node.Nodes.Add( new HTreeNode("dummy") );
			}
		}
		
		protected override bool OnExposeEvent (Gdk.EventExpose args)
		{
			base.OnExposeEvent (args);
			
			int winWidth, winHeight;
			this.GetSize ( out winWidth, out winHeight );
			this.GdkWindow.DrawRectangle ( this.Style.ForegroundGC ( Gtk.StateType.Insensitive ), false, 0, 0, winWidth - 1, winHeight - 1 );
			
			return false;
		}
		
		public void ShowMe( Gdk.Rectangle area, String path )
		{
			Move  ( area.X    , area.Y      );
			Resize( area.Width, area.Height );
			ShowAll();
			GrabUtil.GrabWindow( this );
			FolderTree.GrabFocus();
			SetPath( path );
		}
		
		private void SetPath( String path )
		{
			HTreeNode current_node = FolderTree.SelectedNode;
			String current_path    = "";
			if( current_node != null )	
				current_path  = getPathFromNode( current_node );
			//daca pathul este valid si diferit de ce e deja selectat,
			//construieste calea catre el 
			if( Directory.Exists( path ) && !path.Equals( current_path ) )
			{
				FolderTree.CollapseAll();
				//get drive first
				//TODO: check if in windows it's working
				String drive         = path.Substring( 0, path.IndexOf( separator ) + 1 );
				//then the rest of the path
				path                 = path.Substring( path.IndexOf   ( separator ) + 1 );
				String[] path_parts  = path.Split( separator );
				List<String> parts   = new List<String>();
				
				parts.Add     ( drive );
				parts.AddRange( path_parts );
				
				NodeCollection nodes = FolderTree.Nodes;
				for( int i = 0; i < parts.Count; i++ )
				{
					String node_text = parts[i];
					//search the node with that text
					HTreeNode node   = null;
					foreach( HTreeNode n in nodes )
					{
						if( !n.Text.Equals( node_text ) )
							continue;
						node = n;
						break;
					}
					
					//clear nodes childs
					node.Nodes.Clear();
					//build node childs
					buildNode( node );
					//expand node
					FolderTree.expandNode( node );
					nodes = node.Nodes;
				}
			}
		}
		
		public void Close()
		{
			Hide();
			GrabUtil.RemoveGrab( this );
		}

		protected virtual void OnBtnNewFolderButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
		{
			args.RetVal = true;
		}

		protected virtual void OnFolderTreeButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
		{
			args.RetVal = true;
		}

		protected virtual void OnButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
		{
			Close();
		}

		protected virtual void OnFolderTreeBeforeNodeExpand (object sender, HollyLibrary.NodeEventArgs args)
		{
			HTreeNode node       = args.Node;
			String path          = getPathFromNode(node);
			buildNode            ( node );
			//select the expanded node
			FolderTree.selectNode( node );
			ChangeFatherPath     ( path );
		}
		
		private void buildNode( HTreeNode node )
		{
			String path          = getPathFromNode(node);
			DirectoryInfo di     = new DirectoryInfo( path );
			DirectoryInfo[] dirs = di.GetDirectories();
			node.Nodes.Clear();
			foreach( DirectoryInfo d in dirs )
			{
				node.Nodes.Add( new HTreeNode( d.Name, folder_icon ) );
			}
			//add dummy childs
			foreach( HTreeNode n in node.Nodes )
			{
				n.Nodes.Add( new HTreeNode("dummy") );
			}
			
		}
		

		private string getPathFromNode( HTreeNode node )
		{
			String ret       = node.Text;
			HTreeNode parent = node.ParentNode;
			while( parent   != null )
			{
				ret    = parent.Text + separator + ret;
				parent = parent.ParentNode;
			}
			ret              = ret.Replace( separator + "" + separator,separator + "");
			return ret;
		}

		protected virtual void OnFolderTreeCursorChanged (object sender, System.EventArgs e)
		{
			HTreeNode node = FolderTree.SelectedNode;
			if( node != null )
				ChangeFatherPath( getPathFromNode( node ) );
		}
		
		public void ChangeFatherPath( String path )
		{
			father.SelectedPath = path;
		}

		protected virtual void OnFolderTreeRowActivated (object o, Gtk.RowActivatedArgs args)
		{
			Close();
		}
		
	}
	
}
