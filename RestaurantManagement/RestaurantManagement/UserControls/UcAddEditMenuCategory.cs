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

namespace Windows.UserControls
{
    public partial class UcAddEditMenuCategory : BaseSaveClose
    {
        public UcAddEditMenuCategory()
        {
            InitializeComponent();
        }

        public UcAddEditMenuCategory(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private readonly int _id = 0;
        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            if (_id > 0)
            {
                var MenuCategory = new Service.BLL.BllMenuCategory().GetById(_id);

                FormLoader.SetControlValue(ControlList, MenuCategory);
            }
        }
        public override void BindingProperty()
        {
            var MenuCategory = new MenuCategory();

            AddToControlList(() => MenuCategory.MenuCategoryName, TbName);
        }

        protected override void Save()
        {
            base.Save();
            var obj = FormLoader.GetControlValue<MenuCategory>(ControlList);
            obj.MenuCategoryId = _id;
            new Service.BLL.BllMenuCategory().InsertOrUpdate(obj);

        }
    }
}
