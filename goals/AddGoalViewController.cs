using System;

using UIKit;

namespace goals
{
    public partial class AddGoalViewController : UIViewController
    {
        public AddGoalViewController() : base("AddGoalViewController", null)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //pickerView.add
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

