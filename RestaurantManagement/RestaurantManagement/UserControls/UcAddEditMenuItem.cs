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
using Service.DTO;
using Service.BLL;

namespace Windows.UserControls
{
    public partial class UcAddEditMenuItem : BaseSaveClose
    {
        List<MenuCategory> listMenuCategory;

        public UcAddEditMenuItem()
        {
            InitializeComponent();
        }


        public UcAddEditMenuItem(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private readonly int _id = 0;
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            LoadMenucategory();

            if (_id > 0)
            {
                var MenuItem = new Service.BLL.BllMenuItem().GetById(_id);

                FormLoader.SetControlValue(ControlList, MenuItem);

                CmbCategory.SelectedValue = MenuItem.MenuCategoryId;
            }

            
        }
        public override void BindingProperty()
        {
            var MenuItem = new Service.DTO.MenuItem();

            AddToControlList(() => MenuItem.MenuItemName, TbName);

            AddToControlList(() => MenuItem.MenuItemCode, TbCode);
            AddToControlList(() => MenuItem.MenuCategoryId, CmbCategory);
            AddToControlList(() => MenuItem.Description, TbDescription);
            AddToControlList(() => MenuItem.Price, TbPrice);

            AddToControlList(() => MenuItem.FoodOrBeverage, cmbFoorOrBeverage);

            
        }

        protected override void Save()
        {
            base.Save();
            var obj = FormLoader.GetControlValue<Service.DTO.MenuItem>(ControlList);
            obj.MenuItemId = _id;
            new Service.BLL.BllMenuItem().InsertOrUpdate(obj);

        }

        private void LoadMenucategory()
        {
            listMenuCategory = new BllMenuCategory().GetAll();


            FormLoader.LoadDataSource<MenuCategory>(CmbCategory, listMenuCategory, "MenuCategoryName", "MenuCategoryId");   
        }
    }
}
