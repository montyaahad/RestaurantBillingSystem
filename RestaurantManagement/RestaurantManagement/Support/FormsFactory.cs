using System;
using System.Collections.Generic;
using Windows.UserControls;

namespace Windows.Support
{
    public static class FormsFactory
    {
        public enum FormsCollection
        {
            
        }

        public static Dictionary<string, Type> Forms;

        public static void ListForms()
        {
            Forms = new Dictionary<string, Type>
                {
                    //Child forms
                    

                    {"MenuCategory",typeof(UcMenuCategory)},
                    {"MenuItems",typeof(UcMenuItems)},
                    {"AllBills",typeof(UcBillInfo)},
                    {"About",typeof(UcAbout)},
                    {"DayClose",typeof(UcDayClose)},

                    //ADD EDIT Form


                    {"AddEditMenuCategory",typeof(UcAddEditMenuCategory)},
                    {"AddEditMenuItem",typeof(UcAddEditMenuItem)},
                    {"NewBill",typeof(UcAddEditBillInfo)},
                    
                    //Reports
                    {"SalesDetailsReport",typeof(UcReportSalesDetails)},
                    {"ItemWiseSalesReport",typeof(UcReportItemWiseSales)}

                };

            

            


            
        }

    }
}
