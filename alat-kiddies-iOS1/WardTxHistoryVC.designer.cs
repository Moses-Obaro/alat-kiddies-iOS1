// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace alat_kiddies_iOS1
{
	[Register ("WardTxHistoryVC")]
	partial class WardTxHistoryVC
	{
		[Outlet]
		UIKit.UITableView wardTxHistoryTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (wardTxHistoryTableView != null) {
				wardTxHistoryTableView.Dispose ();
				wardTxHistoryTableView = null;
			}
		}
	}
}
