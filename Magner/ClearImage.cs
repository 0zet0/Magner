using OpenCvSharp;
using System.Drawing;
using System.IO;

namespace Magner
{
    class ClearImage
    {
        public Image Cleared { get; set; }
        public Image OrignImage { get; set; }


        public void Clear(string inputPath, string outputPath, int blockSize, int c, int width, int height)
        {
            Mat orignImg = Cv2.ImRead(inputPath);
            Mat img = Cv2.ImRead(inputPath);
            Cv2.Resize(img, img, new OpenCvSharp.Size(width, height));
            Cv2.Resize(orignImg, orignImg, new OpenCvSharp.Size(width, height));
            Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
            if (blockSize != 0 && c != 0)
            {
                Cv2.AdaptiveThreshold(img, img, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, blockSize, c);
                Cv2.Dilate(img, img, Mat.Ones(2, 2, MatType.CV_8UC1), iterations: 1);
                Cv2.MorphologyEx(img, img, MorphTypes.Open, Mat.Ones(2, 2, MatType.CV_8UC1));
                Cv2.GaussianBlur(img, img, new OpenCvSharp.Size(3, 3), 1);
            }
            img.SaveImage(outputPath);
            using (var file = new FileStream(outputPath, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            {
                Cleared = Image.FromStream(file);
                file.Close();
            }
            orignImg.SaveImage(outputPath);
            using (var file = new FileStream(outputPath, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            {
                OrignImage = Image.FromStream(file);
                file.Close();
            }
            if (File.Exists(outputPath)) File.Delete(outputPath);
        }
        public static void SaveImage(string inputPath, string outputPath)
        {
            Mat img = Cv2.ImRead(inputPath);
            img.SaveImage(outputPath);
        }
    }
}
