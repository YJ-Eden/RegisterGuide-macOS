using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class Window : NSWindow
    {
        public Window(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public Window(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
