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
	[Register ("ParentTxHistoryCell")]
	partial class ParentTxHistoryCell
	{
		[Outlet]
		UIKit.UILabel txAmountLbl { get; set; }

		[Outlet]
		UIKit.UILabel txDateLbl { get; set; }

		[Outlet]
		UIKit.UILabel txRecipientLbl { get; set; }

		[Outlet]
		UIKit.UILabel txTypeLbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txDateLbl != null) {
				txDateLbl.Dispose ();
				txDateLbl = null;
			}

			if (txTypeLbl != null) {
				txTypeLbl.Dispose ();
				txTypeLbl = null;
			}

			if (txAmountLbl != null) {
				txAmountLbl.Dispose ();
				txAmountLbl = null;
			}

			if (txRecipientLbl != null) {
				txRecipientLbl.Dispose ();
				txRecipientLbl = null;
			}
		}
	}
}
