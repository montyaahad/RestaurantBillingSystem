using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Windows.Support;

namespace Windows.UserControls.BaseUserControls
{
    public partial class BaseGrid : UserControl
    {
        public BaseGrid()
        {
            InitializeComponent();
            Bd = new BindingSource();
        }
         
        public BindingSource Bd;
        public dynamic ListForGrid { get; set; } 
        public int RowIndex { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
            BindGrid();

        }
        protected virtual void BtCloseClick(object sender, EventArgs e)
        {
        }

        private void BtNewClick(object sender, EventArgs e)
        {                
            NewItem();
            ResetGrid(); 
        }
        private void BtEditClick(object sender, EventArgs e)
        {

            if (CheckGrid())
            {
                EditItem();
                ResetGrid();
            }
        }
        private void BtDeleteClick(object sender, EventArgs e)
        {
            if (CheckGrid())
            {
                DialogResult dr = KryptonMessageBox.Show(Messages.DeleteConfirmation, Text, MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    DeleteItem();
                ResetGrid();
            }
        }

        protected virtual void NewItem()
        {
            
        }
        protected virtual void EditItem()
        {
            
        }
        protected virtual  void DeleteItem()
        {
            
        }

        public void BindGrid()
        {
            Bd.DataSource = ListForGrid;
            Dgv.AutoGenerateColumns = false;
            Dgv.DataSource = Bd;
            Bd.ResetBindings(false);
        }

        private void ResetGrid()
        {
            LoadData();
            Bd.DataSource = ListForGrid;
            Bd.ResetBindings(false);
        }
        protected virtual void LoadData()
        {
            
        }

        private  bool CheckGrid()
        {
            if (Dgv.Rows.Count <= 0)
            {
                KryptonMessageBox.Show(Messages.GridEmptyInfo, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
                
            if (Dgv.CurrentRow.Index <= -1)
            {
                KryptonMessageBox.Show(Messages.GridSelectInfo, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
                
            }
            return true;
        }

        private void DgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
            CellItemClicked();
        }
        protected virtual void CellItemClicked()
        {
            
        }

        protected virtual void CellItemDoubleClicked()
        {
 
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
            EditItem();
            ResetGrid();
        }

    }
}
