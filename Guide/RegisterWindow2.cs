using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class RegisterWindow2 : NSWindow
    {
        public RegisterWindow2(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public RegisterWindow2(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
