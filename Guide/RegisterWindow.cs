using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class RegisterWindow : NSWindow
    {
        public RegisterWindow(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public RegisterWindow(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
