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
	[Register ("LoginScreenVC")]
	partial class LoginScreenVC
	{
		[Outlet]
		UIKit.UIImageView alatAuthLogo { get; set; }

		[Outlet]
		UIKit.UIView authenticatingView { get; set; }

		[Outlet]
		UIKit.UIImageView authSpinImg { get; set; }

		[Outlet]
		UIKit.UITextField emailField { get; set; }

		[Outlet]
		UIKit.UILabel errorMsgLabel { get; set; }

		[Outlet]
		UIKit.UIButton loginBtn { get; set; }

		[Outlet]
		UIKit.UITextField passwordField { get; set; }

		[Outlet]
		UIKit.UIImageView showPasswordImg { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (alatAuthLogo != null) {
				alatAuthLogo.Dispose ();
				alatAuthLogo = null;
			}

			if (authenticatingView != null) {
				authenticatingView.Dispose ();
				authenticatingView = null;
			}

			if (authSpinImg != null) {
				authSpinImg.Dispose ();
				authSpinImg = null;
			}

			if (emailField != null) {
				emailField.Dispose ();
				emailField = null;
			}

			if (errorMsgLabel != null) {
				errorMsgLabel.Dispose ();
				errorMsgLabel = null;
			}

			if (loginBtn != null) {
				loginBtn.Dispose ();
				loginBtn = null;
			}

			if (passwordField != null) {
				passwordField.Dispose ();
				passwordField = null;
			}

			if (showPasswordImg != null) {
				showPasswordImg.Dispose ();
				showPasswordImg = null;
			}
		}
	}
}
