// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Guide
{
	[Register ("RegisterWindowController")]
	partial class RegisterWindowController
	{
		[Outlet]
		AppKit.NSTextField name { get; set; }

		[Outlet]
		AppKit.NSSecureTextField password { get; set; }

		[Action ("ClickedRegister1Cancel:")]
		partial void ClickedRegister1Cancel (Foundation.NSObject sender);

		[Action ("ClickedRegister1Finish:")]
		partial void ClickedRegister1Finish (Foundation.NSObject sender);

		[Action ("ClickedRegister1Next:")]
		partial void ClickedRegister1Next (Foundation.NSObject sender);

		[Action ("ClickedRegisterCancel:")]
		partial void ClickedRegisterCancel (Foundation.NSObject sender);

		[Action ("ClickedRegisterFinish:")]
		partial void ClickedRegisterFinish (Foundation.NSObject sender);

		[Action ("ClickedRegisterNext:")]
		partial void ClickedRegisterNext (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (name != null) {
				name.Dispose ();
				name = null;
			}

			if (password != null) {
				password.Dispose ();
				password = null;
			}
		}
	}
}
