using System;
using System.Collections.Generic;
using System.Text;

namespace ImageWriter.Formats
{
    public class ImageFormats
    {
        public static readonly byte[]  bmp = Encoding.ASCII.GetBytes("BM");     // BMP
        public static readonly byte[] gif = Encoding.ASCII.GetBytes("GIF");    // GIF
        public static readonly byte[] png = new byte[] { 137, 80, 78, 71 };              // PNG
        public static readonly byte[] tiff = new byte[] { 73, 73, 42 };                  // TIFF
        public static readonly byte[] tiff2 = new byte[] { 77, 77, 42 };                 // TIFF
        public static readonly byte[] jpeg = new byte[] { 255, 216, 255, 224 };          // jpeg
        public static readonly byte[] jpeg2 = new byte[] { 255, 216, 255, 225 };         // jpeg canon
    }
}
