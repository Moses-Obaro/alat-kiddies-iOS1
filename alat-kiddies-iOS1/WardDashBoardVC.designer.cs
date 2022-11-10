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
	[Register ("WardDashBoardVC")]
	partial class WardDashBoardVC
	{
		[Outlet]
		UIKit.UILabel AccBalLbl { get; set; }

		[Outlet]
		UIKit.UILabel AccNumLbl { get; set; }

		[Outlet]
		UIKit.UIImageView AccountStatementScreenImg { get; set; }

		[Outlet]
		UIKit.UILabel AccStatusLbl { get; set; }

		[Outlet]
		UIKit.UILabel AccTypeLbl { get; set; }

		[Outlet]
		UIKit.UIImageView AirtimePurchaseImg { get; set; }

		[Outlet]
		UIKit.UILabel HiLbl { get; set; }

		[Outlet]
		UIKit.UIImageView ProfilePicImg { get; set; }

		[Outlet]
		UIKit.UIImageView ShowHideImg { get; set; }

		[Outlet]
		UIKit.UIImageView TxHistoryScreenImg { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AirtimePurchaseImg != null) {
				AirtimePurchaseImg.Dispose ();
				AirtimePurchaseImg = null;
			}

			if (AccountStatementScreenImg != null) {
				AccountStatementScreenImg.Dispose ();
				AccountStatementScreenImg = null;
			}

			if (TxHistoryScreenImg != null) {
				TxHistoryScreenImg.Dispose ();
				TxHistoryScreenImg = null;
			}

			if (ProfilePicImg != null) {
				ProfilePicImg.Dispose ();
				ProfilePicImg = null;
			}

			if (HiLbl != null) {
				HiLbl.Dispose ();
				HiLbl = null;
			}

			if (AccBalLbl != null) {
				AccBalLbl.Dispose ();
				AccBalLbl = null;
			}

			if (AccNumLbl != null) {
				AccNumLbl.Dispose ();
				AccNumLbl = null;
			}

			if (AccStatusLbl != null) {
				AccStatusLbl.Dispose ();
				AccStatusLbl = null;
			}

			if (AccTypeLbl != null) {
				AccTypeLbl.Dispose ();
				AccTypeLbl = null;
			}

			if (ShowHideImg != null) {
				ShowHideImg.Dispose ();
				ShowHideImg = null;
			}
		}
	}
}
