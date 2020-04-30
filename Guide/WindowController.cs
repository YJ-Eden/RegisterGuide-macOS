using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class WindowController : NSWindowController
    {
        public WindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public WindowController(NSCoder coder) : base(coder)
        {
        }

        public WindowController() : base("Window")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public new Window Window
        {
            get { return (Window)base.Window; }
        }
    }
}
