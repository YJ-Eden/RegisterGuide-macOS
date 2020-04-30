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
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSTextField mailMain { get; set; }

		[Outlet]
		AppKit.NSTextField nameMain { get; set; }

		[Outlet]
		AppKit.NSTextField passwordMain { get; set; }

		[Outlet]
		AppKit.NSTextField tipMain { get; set; }

		[Action ("ClickedButtonRegister:")]
		partial void ClickedButtonRegister (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tipMain != null) {
				tipMain.Dispose ();
				tipMain = null;
			}

			if (nameMain != null) {
				nameMain.Dispose ();
				nameMain = null;
			}

			if (passwordMain != null) {
				passwordMain.Dispose ();
				passwordMain = null;
			}

			if (mailMain != null) {
				mailMain.Dispose ();
				mailMain = null;
			}
		}
	}
}
