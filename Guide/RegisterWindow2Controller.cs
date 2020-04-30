using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class RegisterWindow2Controller : NSWindowController
    {

        public RegisterWindow2Controller(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public RegisterWindow2Controller(NSCoder coder) : base(coder)
        {
        }

        public RegisterWindow2Controller() : base("RegisterWindow2")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public new RegisterWindow2 Window
        {
            get { return (RegisterWindow2)base.Window; }
        }

        partial void ClickedRegisterCancel(NSObject sender)
        {
            RaiseRegisterCanceled();
            //CloseRegister();
        }

        public EventHandler RegisterCanceled;

        internal void RaiseRegisterCanceled()
        {
            if (this.RegisterCanceled != null)
                this.RegisterCanceled(this, EventArgs.Empty);
        }

        partial void ClickedRegisterFinish(NSObject sender)
        {
            RaiseRegisterFinished();
        }

        public EventHandler RegisterFinished;

        internal void RaiseRegisterFinished()
        {
            if (this.RegisterFinished != null)
                this.RegisterFinished(this, EventArgs.Empty);
        }

        partial void ClickedRegister2Previous(NSObject sender)
        {
            RaiseRegisterPrevious();
        }

        public EventHandler RegisterPrevious;

        internal void RaiseRegisterPrevious()
        {
            if (this.RegisterPrevious != null)
                this.RegisterPrevious(this, EventArgs.Empty);
        }

        public string getMail()
        {
            return mail.StringValue;
        }
    }
}
