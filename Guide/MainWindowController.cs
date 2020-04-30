using System;

using Foundation;
using AppKit;

namespace Guide
{
    public partial class MainWindowController : NSWindowController
    {
        RegisterWindowController register;
        RegisterWindow2Controller register2;

        string name;
        string password;
        string mail;
        string closemethod;

        public MainWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public MainWindowController(NSCoder coder) : base(coder)
        {
        }

        public MainWindowController() : base("MainWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        //窗口加载时的初始化操作
        public override void WindowDidLoad()
        {
            base.WindowDidLoad();

            tipMain.StringValue = "您还没有进行过注册操作!";
            nameMain.StringValue = "";
            passwordMain.StringValue = "";
            mailMain.StringValue = "";
        }

        public new MainWindow Window
        {
            get { return (MainWindow)base.Window; }
        }

        //点击注册按钮，生成注册1页面
        partial void ClickedButtonRegister(Foundation.NSObject sender)
        {
            Console.WriteLine("hello");
            createRegister();
        }

        //生成注册1页面，绑定页面中各个按钮的操作
        public void createRegister()
        {
            nameMain.StringValue = "";
            passwordMain.StringValue = "";
            mailMain.StringValue = "";

            register = new RegisterWindowController();
            register.Window.MakeKeyAndOrderFront(this);
            register.RegisterCanceled += (s, e) => {
                //TODO
                Console.WriteLine("register1 canceled");
                closemethod = "cancel";
                setRegister1(register);
                tipMain.StringValue = "您刚刚点击了"+closemethod+"按钮。";
                register.Close();
            };
            register.RegisterFinished += (s, e) =>
            {
                //TODO
                Console.WriteLine("register1 finished");
                closemethod = "finish";
                setRegister1(register);
                tipMain.StringValue = "您刚刚点击了" + closemethod + "按钮。";
                register.Close();
            };
            register.RegisterNext += (s, e) =>
            {
                Console.WriteLine("register1 next");
                setRegister1(register);
                createRegister2();
                register.Close();
            };
        }

        //生成注册2页面，绑定页面中各个按钮的操作
        public void createRegister2()
        {
            register2 = new RegisterWindow2Controller();
            register2.Window.MakeKeyAndOrderFront(this);
            register2.RegisterCanceled += (s, e) =>
            {
                //TODO
                Console.WriteLine("register2 canceled");
                closemethod = "cancel";
                setRegister2(register2);
                tipMain.StringValue = "您刚刚点击了" + closemethod + "按钮。";
                register2.Close();
            };
            register2.RegisterFinished += (s, e) =>
            {
                //TODO
                Console.WriteLine("register2 finished");
                closemethod = "finish";
                setRegister2(register2);
                tipMain.StringValue = "您刚刚点击了" + closemethod + "按钮。";
                register2.Close();
            };
            register2.RegisterPrevious += (s, e) =>
            {
                Console.WriteLine("register2 previous");
                setRegister2(register2);
                createRegister();
                register2.Close();
            };
        }

        //注册页面1填写内容抓取
        public void setRegister1(RegisterWindowController register)
        {
            name = register.getName();
            password = register.getPassword();
            nameMain.StringValue = "您输入的用户名为：" + name;
            passwordMain.StringValue = "您输入的密码为：" + password;
        }

        //注册页面2填写内容抓取
        public void setRegister2(RegisterWindow2Controller register)
        {
            mail = register.getMail();
            mailMain.StringValue = "您输入的邮箱为：" + mail;
        }
    }
}
