using Windows.Support;
using System;
namespace Windows.UserControls.BaseUserControls
{
    public partial class BaseAddEditWithImage : BaseSaveClose
    {
        public BaseAddEditWithImage()
        {
            InitializeComponent();

        }

        private void BtAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                FormLoader.LoadImage(PbImage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            try
            {
                PbImage.Image = null;
                PbImage.ImageLocation = String.Empty;
            }

            catch
            {
                throw;
            }
        }



    }
}
