using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace SummonManager
{
    public class PreviousState
    {
        List<int> w = new List<int>();
        //List<string> n = new List<string>();
        public int indexOfSortedColumn = -1;
        public SortOrder soOfSortedColumn = SortOrder.None;
        public int idOfFirstRow = -1;
        //DataGridViewRow SelectedRow = null;
        public string idOfSelectedRow = "";
        public string Filter;
        DataGridView dgv;
        public PreviousState(DataGridView dgv_)
        {
            this.dgv = dgv_;
            if (dgv.SelectedRows.Count != 0) idOfSelectedRow = dgv.SelectedRows[0].Cells[0].Value.ToString();
            if (dgv.FirstDisplayedScrollingRowIndex != 0) idOfFirstRow = dgv.FirstDisplayedScrollingRowIndex;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                w.Add(c.Width);
                if (c.HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    soOfSortedColumn = c.HeaderCell.SortGlyphDirection;
                    indexOfSortedColumn = c.Index;
                }
            }
        }
        public void Restore()
        {
            int i = 0;
            if (indexOfSortedColumn != -1)
            {
                if (soOfSortedColumn == SortOrder.Ascending)
                {
                    dgv.Sort(dgv.Columns[indexOfSortedColumn], ListSortDirection.Ascending);
                }
                else
                {
                    dgv.Sort(dgv.Columns[indexOfSortedColumn], ListSortDirection.Descending);
                }

                dgv.Columns[indexOfSortedColumn].HeaderCell.SortGlyphDirection = soOfSortedColumn;
            }
            if (idOfFirstRow != -1)
            {
                if (idOfFirstRow < dgv.Rows.Count)
                    dgv.FirstDisplayedScrollingRowIndex = idOfFirstRow;
            }
            foreach (DataGridViewRow r in dgv.Rows)
            {
                
                if (r.Cells[0].Value.ToString() == this.idOfSelectedRow)
                {
                    r.Selected = true;
                    break;
                }
            }
            i = 0;
            foreach (DataGridViewColumn c in dgv.Columns)
            {

                c.Width = w[i++];
            }
        }
        
        
    }

}
