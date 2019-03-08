using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace goals
{
    public partial class GoalCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GoalCell");
        public static readonly UINib Nib;

        UILabel titleLabel;
        UILabel descriptionLabel;
        UILabel subGoalLabel;


        public GoalCell()
        {
            titleLabel = new UILabel
            {
                Frame = new CGRect(10, 10, 200, 20),
                Font = UIFont.FromName("Helvetica", 18f)
            };

            descriptionLabel = new UILabel
            {
                Frame = new CGRect(20, 40, 200, 40),
                Font = UIFont.FromName("Helvetica", 14f)
            };

            subGoalLabel = new UILabel
            {
                Frame = new CGRect(Frame.Right - 40, 25, 100, 20),
                Font = UIFont.FromName("Helvetica", 14f)
            };


            AddSubviews(new UIView { titleLabel, descriptionLabel, subGoalLabel });
        }

        static GoalCell()
        {
            Nib = UINib.FromName("GoalCell", NSBundle.MainBundle);
        }

        protected GoalCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void UpdateCell(Goal _goal)
        {
            titleLabel.Text = _goal.GetTitle();
            descriptionLabel.Text = _goal.GetDesc();
            subGoalLabel.Text = "Subgoals: " + _goal.GetSubGoals().Count;
        }
    }
}
