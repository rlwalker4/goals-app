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
	[Register ("AddGoalViewController")]
	partial class AddGoalViewController
	{
		[Outlet]
		UIKit.UIPickerView pickerView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (pickerView != null) {
				pickerView.Dispose ();
				pickerView = null;
			}
		}
	}
}
