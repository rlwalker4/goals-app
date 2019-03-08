using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace goals
{
    public partial class HighLevelViewController : UIViewController
    {
        List<Goal> goals;
        bool urgencySort;
        string sortString;
        //Database db;

        public HighLevelViewController() : base("HighLevelViewController", null)
        {
            goals = new List<Goal>();
            goals.Add(new Goal());
            goals.Add(new Goal());
            goals.Add(new Goal());
            goals.Add(new Goal());
            goals[0].title = "High Importance";
            goals[0].importance = 100;
            goals[0].urgency = 0;
            goals[1].title = "Low Importance";
            goals[1].importance = -10;
            goals[1].urgency = 0;
            goals[2].title = "High Urgency";
            goals[2].importance = 0;
            goals[2].urgency = 100;
            goals[3].title = "Low urgency";
            goals[3].importance = 0;
            goals[3].urgency = -10;
            goals = goals.OrderByDescending(o => o.GetUrgency()).ToList();
            urgencySort = true;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            tableView.Source = new HighLevelTableViewSource(goals);

            reorgButton.Clicked += (object sender, EventArgs e) => ReOrganize();
            addButton.Clicked += (object sender, EventArgs e) =>
            {
                //NavigationController.PushViewController
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void ReOrganize()
        {
            sortString = "Your goals are currently sorted by ";
            if (urgencySort)
                sortString += "urgency.";
            else
                sortString += "importance.";
            sortString += " How would you like to sort your goals?";
            var okCancelAlertController = UIAlertController.Create("Sort Goals", sortString, UIAlertControllerStyle.ActionSheet);
            okCancelAlertController.AddAction(UIAlertAction.Create("Urgency", UIAlertActionStyle.Default, alert => 
            {
                goals = goals.OrderByDescending(o => o.GetUrgency()).ToList();
                urgencySort = true;
                tableView.Source = new HighLevelTableViewSource(goals);
                tableView.ReloadData();
            }));
            okCancelAlertController.AddAction(UIAlertAction.Create("Imporance", UIAlertActionStyle.Default, alert => 
            {
                goals = goals.OrderByDescending(o => o.GetImportance()).ToList();
                urgencySort = false;
                tableView.Source = new HighLevelTableViewSource(goals);
                tableView.ReloadData();
            }));
            okCancelAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));

            PresentViewController(okCancelAlertController, true, null);
        }

        public void RefreshView()
        {
            tableView.ReloadData();
        }
    }
}

