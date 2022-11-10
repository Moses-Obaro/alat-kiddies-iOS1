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
	[Register ("GuardianTxHistoryVC")]
	partial class GuardianTxHistoryVC
	{
		[Outlet]
		UIKit.UIImageView alatLoadingImg { get; set; }

		[Outlet]
		UIKit.UIView loadingTxHistoryView { get; set; }

		[Outlet]
		UIKit.UITableView parentTxHistoryTable { get; set; }

		[Outlet]
		UIKit.UIImageView spinningIndicatorImg { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (alatLoadingImg != null) {
				alatLoadingImg.Dispose ();
				alatLoadingImg = null;
			}

			if (loadingTxHistoryView != null) {
				loadingTxHistoryView.Dispose ();
				loadingTxHistoryView = null;
			}

			if (spinningIndicatorImg != null) {
				spinningIndicatorImg.Dispose ();
				spinningIndicatorImg = null;
			}

			if (parentTxHistoryTable != null) {
				parentTxHistoryTable.Dispose ();
				parentTxHistoryTable = null;
			}
		}
	}
}
