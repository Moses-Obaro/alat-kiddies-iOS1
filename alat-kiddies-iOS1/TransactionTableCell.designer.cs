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
	[Register ("TransactionTableCell")]
	partial class TransactionTableCell
	{
		[Outlet]
		UIKit.UILabel transactionAmountLbl { get; set; }

		[Outlet]
		UIKit.UILabel transactionDateLbl { get; set; }

		[Outlet]
		UIKit.UILabel transactionRecipientLbl { get; set; }

		[Outlet]
		UIKit.UILabel transactionTypeLbl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (transactionAmountLbl != null) {
				transactionAmountLbl.Dispose ();
				transactionAmountLbl = null;
			}

			if (transactionDateLbl != null) {
				transactionDateLbl.Dispose ();
				transactionDateLbl = null;
			}

			if (transactionRecipientLbl != null) {
				transactionRecipientLbl.Dispose ();
				transactionRecipientLbl = null;
			}

			if (transactionTypeLbl != null) {
				transactionTypeLbl.Dispose ();
				transactionTypeLbl = null;
			}
		}
	}
}
