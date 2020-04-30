using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class RegisterWindowController : NSWindowController
    {

        public RegisterWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public RegisterWindowController(NSCoder coder) : base(coder)
        {
        }

        public RegisterWindowController() : base("RegisterWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public new RegisterWindow Window
        {
            get { return (RegisterWindow)base.Window; }
        }

        //点击cancel后
        partial void ClickedRegisterCancel(NSObject sender)
        {
            RaiseRegisterCanceled();
            //CloseRegister();
        }

        public EventHandler RegisterCanceled;

        //使其他类使用EventHandler RegisterCanceled
        internal void RaiseRegisterCanceled()
        {
            if (this.RegisterCanceled != null)
                this.RegisterCanceled(this, EventArgs.Empty);
        }

        //点击finish后
        partial void ClickedRegisterFinish(NSObject sender)
        {
            RaiseRegisterFinished();
        }

        public EventHandler RegisterFinished;


        //使其他类使用EventHandler RegisterFinished
        internal void RaiseRegisterFinished()
        {
            if (this.RegisterFinished != null)
                this.RegisterFinished(this, EventArgs.Empty);
        }

        //点击“下一页”后
        partial void ClickedRegisterNext(NSObject sender)
        {
            RaiseRegisterNext();
        }

        public EventHandler RegisterNext;

        //使其他类使用EventHandler RegisterNext
        internal void RaiseRegisterNext()
        {
            if (this.RegisterNext != null)
                this.RegisterNext(this, EventArgs.Empty);
        }

        //返回填写的name
        public string getName()
        {
            return name.StringValue;
        }

        //返回填写的password
        public string getPassword()
        {
            return password.StringValue;
        }
    }
}
