using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShifaClinic.Common
{
    public static class GridView
    {
        public static void NavigateGridView(this DataGridView gridView, Keys key, int steps = 1)
        {
            int offset = 0;
            int newRowIndex = 0;
            int currentRowIndex = gridView.CurrentCell.RowIndex;

            gridView.Rows[currentRowIndex].Selected = false;
            switch (key)
            {
                case Keys.PageUp:
                    offset = steps > 1 ? steps : 5;

                    if (0 > currentRowIndex - offset)
                        newRowIndex = 0;
                    else
                        newRowIndex = currentRowIndex - offset;

                    gridView.Rows[newRowIndex].Cells[0].Selected = true;
                    break;
                case Keys.PageDown:
                    offset = steps > 1 ? steps : 5;

                    if (gridView.Rows.Count < currentRowIndex + offset)
                        newRowIndex = gridView.Rows.Count - 1;
                    else
                        newRowIndex = currentRowIndex + offset;

                    gridView.Rows[newRowIndex].Cells[0].Selected = true;
                    break;
                case Keys.Up:
                    if (0 > currentRowIndex - steps)
                        newRowIndex = 0;
                    else
                        newRowIndex = currentRowIndex - steps;

                    gridView.Rows[newRowIndex].Cells[0].Selected = true;
                    break;
                case Keys.Down:
                    if (gridView.Rows.Count < currentRowIndex + steps)
                        newRowIndex = gridView.Rows.Count - 1;
                    else
                        newRowIndex = currentRowIndex + steps;

                    gridView.Rows[newRowIndex].Cells[0].Selected = true;
                    break;
            }
        }

        public static void FindInColumns(this DataGridView gridView, string[] cells, string criteria)
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                foreach (string column in cells)
                {
                    var c = row.Cells[column];
                    if (c.Value.ToString().Contains(criteria) && !string.IsNullOrWhiteSpace(criteria))
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        c.Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
