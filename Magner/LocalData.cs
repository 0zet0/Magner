using System.Drawing;
using Tesseract;

namespace Magner
{
    public class LocalData
    {
        public static Rectangle GetBox(Bitmap bmp)
        {
            bmp.Save("img.jpg");
            ClearImage clearImage = new ClearImage();
            clearImage.Clear("img.jpg", "img.jpg", 31, 4, bmp.Width, bmp.Height);
            bmp = (Bitmap)clearImage.Cleared;
            Pix pix = PixConverter.ToPix(bmp);
            var engine = new TesseractEngine("tessdata", "tgk1");
            var page = engine.Process(pix);
            var segm = page.GetSegmentedRegions(PageIteratorLevel.Block);
            if (segm.Count != 0)
                return segm[0];
            else
                return new Rectangle();
        }
    }
}
