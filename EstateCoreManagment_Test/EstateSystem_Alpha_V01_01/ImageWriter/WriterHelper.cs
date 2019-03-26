using ImageWriter.Common;
using ImageWriter.Formats;
using System;
using System.Linq;
using System.Text;

namespace ImageWriter
{
    public class WriterHelper
    {
        public static ImageFormat GetImageFormat(byte[] bytes)
        {

            if (ImageFormats.bmp.SequenceEqual(bytes.Take(ImageFormats.bmp.Length)))
                return ImageFormat.bmp;

            if (ImageFormats.gif.SequenceEqual(bytes.Take(ImageFormats.gif.Length)))
                return ImageFormat.gif;

            if (ImageFormats.png.SequenceEqual(bytes.Take(ImageFormats.png.Length)))
                return ImageFormat.png;

            if (ImageFormats.tiff.SequenceEqual(bytes.Take(ImageFormats.tiff.Length)))
                return ImageFormat.tiff;

            if (ImageFormats.tiff2.SequenceEqual(bytes.Take(ImageFormats.tiff2.Length)))
                return ImageFormat.tiff;

            if (ImageFormats.jpeg.SequenceEqual(bytes.Take(ImageFormats.jpeg.Length)))
                return ImageFormat.jpeg;

            if (ImageFormats.jpeg2.SequenceEqual(bytes.Take(ImageFormats.jpeg2.Length)))
                return ImageFormat.jpeg;

            return ImageFormat.unknown;
        }
    }
}
