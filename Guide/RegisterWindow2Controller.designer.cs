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
	[Register ("RegisterWindow2Controller")]
	partial class RegisterWindow2Controller
	{
		[Outlet]
		AppKit.NSTextField mail { get; set; }

		[Action ("ClickedRegister2Cancel:")]
		partial void ClickedRegister2Cancel (Foundation.NSObject sender);

		[Action ("ClickedRegister2Finish:")]
		partial void ClickedRegister2Finish (Foundation.NSObject sender);

		[Action ("ClickedRegister2Previous:")]
		partial void ClickedRegister2Previous (Foundation.NSObject sender);

		[Action ("ClickedRegisterCancel:")]
		partial void ClickedRegisterCancel (Foundation.NSObject sender);

		[Action ("ClickedRegisterFinish:")]
		partial void ClickedRegisterFinish (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (mail != null) {
				mail.Dispose ();
				mail = null;
			}
		}
	}
}
