using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows.UserControls.BaseUserControls;
using Service.DTO;
using Windows.Support;

namespace Windows.UserControls
{
    public partial class UcMenuCategory : BaseGrid
    {
        public UcMenuCategory()
        {
            InitializeComponent();
        }

        private List<MenuCategory> _list;

        protected override void NewItem()
        {
            FormLoader.LoadChildForm("AddEditMenuCategory", "Add/Edit Menu Category");

        }
        protected override void EditItem()
        {
            int id = _list[RowIndex].MenuCategoryId;
            FormLoader.LoadChildForm("AddEditMenuCategory", "Add/Edit Menu Category", new object[] { id });
        }

        protected override void DeleteItem()
        {
            int id = _list[RowIndex].MenuCategoryId;
            new Service.BLL.BllMenuCategory().Delete(id);

        }
        protected override void LoadData()
        {
            ListForGrid = _list = new Service.BLL.BllMenuCategory().GetAll();

        }
    }
}
