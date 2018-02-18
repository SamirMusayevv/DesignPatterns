using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    static class Size
    {
        static public string Calculate(double size)
        {
            string result = $"{size} Bytes";

            if (size >= 1000)
            {
                result = $"{(size /= 1000).ToString("0.##")} KB";
                if (size >= 1000)
                {
                    result = $"{(size /= 1000).ToString("0.##")} MB";
                    if (size >= 1000)
                        result = $"{(size /= 1000).ToString("0.##")} GB";
                }
            }

            return result;
        }
    }
}
