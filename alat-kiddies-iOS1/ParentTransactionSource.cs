using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace alat_kiddies_iOS1
{
    public class ParentTxHistorySource: UITableViewSource
    {
        public ParentTxHistorySource()
        {
        }    
        List<ParentTransaction> TableItems;

        public ParentTxHistorySource(List<ParentTransaction> tableItems)
        {
            this.TableItems = tableItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("transactionCell") as TransactionTableCell;
            cell.PopulateCell(TableItems[indexPath.Row]);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 80f;
        }       
        
    }    
}
