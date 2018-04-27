using System;

using UIKit;

namespace helloName.iOS
{
    public partial class ViewController : UIViewController
    {
        //int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //            sayHelloWorldButton.TouchUpInside += (sender, ea) => { new UIAlertView("Result:", "Hello World!", null, "OK", null).Show(); };


            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            //Button.TouchUpInside += delegate
            //{
            //    var title = string.Format("{0} clicks!", count++);
            //    Button.SetTitle(title, UIControlState.Normal);
            //};

            Button.TouchUpInside += (sender, ea) => { new UIAlertView("Result: ", "Hello, " + myTextField.Text + "!", null, "OK", null).Show(); };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
