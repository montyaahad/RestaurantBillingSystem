using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows.UserControls.BaseUserControls;
using Windows.Support;

namespace Windows.UserControls
{
    public partial class UcMenuItems : BaseGrid
    {
        public UcMenuItems()
        {
            InitializeComponent();
        }

        private List<Service.DTO.MenuItem> _list;

        protected override void NewItem()
        {
            FormLoader.LoadChildForm("AddEditMenuItem", "Add/Edit Menu Item");

        }
        protected override void EditItem()
        {
            int id = _list[RowIndex].MenuItemId;
            FormLoader.LoadChildForm("AddEditMenuItem", "Add/Edit Menu Item", new object[] { id });
        }

        protected override void DeleteItem()
        {
            int id = _list[RowIndex].MenuItemId;
            new Service.BLL.BllMenuItem().Delete(id);

        }
        protected override void LoadData()
        {
            ListForGrid = _list = new Service.BLL.BllMenuItem().GetAll();

        }
    }
}
