using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace goals
{
    public class HighLevelTableViewSource : UITableViewSource
    {
        List<Goal> goals;

        public HighLevelTableViewSource(List<Goal> _goals)
        {
            goals = _goals;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            tableview.RowHeight = 100;
            return goals.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (GoalCell) tableView.DequeueReusableCell("EventCell");
            var myEvent = goals[indexPath.Row];

            if (cell == null)
                cell = new GoalCell();

            cell.UpdateCell(myEvent);

            return cell;
        }
    }
}
