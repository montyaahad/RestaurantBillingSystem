using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq.Expressions;

namespace Windows.Support
{
    internal class Extension
    {
        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void GetCorrectType(Type t, ref object value)
        {
            if (t == typeof(int))
            {
                value = Convert.ToInt32(value);
            }
            if (t == typeof(short))
            {
                value = Convert.ToInt16(value);
            }
            if (t == typeof(long))
            {
                value = Convert.ToInt64(value);
            }

            if (t == typeof(decimal))
            {
                value = Convert.ToDecimal(value);
            }
            if (t == typeof(DateTime))
            {
                try
                {
                    value = Convert.ToDateTime(value);
                }
                catch
                {
                    value = DateTime.Now;
                }
            }
            if (t == typeof(bool))
            {
                if (!(value is bool))
                    value = false;
                value = Convert.ToBoolean(value);
            }
            if (t == typeof(byte[]))
            {
                if (value is Image)
                    value = ImageToByteArray((Image)value);
                else
                    value = new byte[0];
            }
            if (t == typeof(Double))
            {
                value = Convert.ToDouble(value);
            }

        }

        public static string CheckName<T>(Expression<Func<T>> expr)
        {
            var body = ((MemberExpression)expr.Body);
            return body.Member.Name;
        }

    }
}
