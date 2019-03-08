// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace goals
{
	[Register ("HighLevelViewController")]
	partial class HighLevelViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem addButton { get; set; }

		[Outlet]
		UIKit.UIBarButtonItem reorgButton { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (addButton != null) {
				addButton.Dispose ();
				addButton = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (reorgButton != null) {
				reorgButton.Dispose ();
				reorgButton = null;
			}
		}
	}
}
