// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace alat_kiddies_iOS1.Kiddies
{
	[Register ("WardDashBoardScreen")]
	partial class WardDashBoardScreen
	{
		[Outlet]
		UIKit.UILabel AccBalLbl { get; set; }

		[Outlet]
		UIKit.UILabel AccNumLbl { get; set; }

		[Outlet]
		UIKit.UIImageView AccountStatementImg { get; set; }

		[Outlet]
		UIKit.UILabel AccStatusLbl { get; set; }

		[Outlet]
		UIKit.UILabel AccTypeLbl { get; set; }

		[Outlet]
		UIKit.UIImageView BuyAirtimeImg { get; set; }

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

			if (TxHistoryScreenImg != null) {
				TxHistoryScreenImg.Dispose ();
				TxHistoryScreenImg = null;
			}

			if (BuyAirtimeImg != null) {
				BuyAirtimeImg.Dispose ();
				BuyAirtimeImg = null;
			}

			if (AccountStatementImg != null) {
				AccountStatementImg.Dispose ();
				AccountStatementImg = null;
			}

			if (HiLbl != null) {
				HiLbl.Dispose ();
				HiLbl = null;
			}

			if (ProfilePicImg != null) {
				ProfilePicImg.Dispose ();
				ProfilePicImg = null;
			}
		}
	}
}
