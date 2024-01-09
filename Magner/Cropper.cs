using OpenCvSharp;
using System;
using System.IO;
using System.Linq;
using SD = System.Drawing;

namespace Magner
{
    public class Cropper
    {
        public int Threshold1 { get; set; }
        public int Threshold2 { get; set; }
        private SD.Image FinalImage = null;
        public Cropper()
        {
            Threshold1 = 150;
            Threshold2 = 0;
        }

        public SD.Image GetFinalImage() => FinalImage;
        public void CropImage(string inputImagePath, string outputImagePath)
        {
            if (Threshold1 == 0 && Threshold2 == 0)
            {
                using (var orgImage = new Mat(inputImagePath))
                {
                    orgImage.SaveImage(outputImagePath);
                    using (var finalImage = new FileStream(outputImagePath, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                    {
                        FinalImage = SD.Image.FromStream(finalImage);
                        finalImage.Close();
                    }
                }
                return;
            }
            using (var orgImage = new Mat(inputImagePath))
            {
                Mat img = new Mat();
                Mat kernal = Mat.Ones(5, 5, MatType.CV_8UC1);
                Cv2.Resize(orgImage, orgImage, new Size(900, 788));
                Cv2.CvtColor(orgImage, img, ColorConversionCodes.BGR2GRAY);
                Cv2.GaussianBlur(img, img, new Size(5, 5), 1);
                Cv2.Canny(img, img, Threshold1, Threshold2, apertureSize: 3);
                Cv2.Dilate(img, img, kernal, iterations: 2);
                Cv2.Erode(img, img, kernal, iterations: 1);
                Point[][] contours;
                Point[] bigc = new Point[4];
                HierarchyIndex[] hierarchyIndexes;
                Cv2.FindContours(
                    img,
                    out contours,
                    out hierarchyIndexes,
                    mode: RetrievalModes.External,
                    method: ContourApproximationModes.ApproxSimple);
                var matrix = new Mat();
                var output = new Mat();
                double area, peri, maxArea = 0;
                Point[][] contour = new Point[1][];
                foreach (var item in contours)
                {
                    area = Cv2.ContourArea(item);
                    if (area > 5000)
                    {
                        peri = Cv2.ArcLength(item, true);
                        var approx = Cv2.ApproxPolyDP(item, peri * 0.01, true);
                        if (area > maxArea)
                        {
                            maxArea = area;
                            contour[0] = item;
                        }
                    }
                }
                Point[] points = new Point[4];
                int minX = img.Width;
                int maxX = 0;
                int minY = img.Height;
                int maxY = 0;
                if (contour[0] == null)
                    return;
                foreach (var c in contour[0])
                {
                    if (minX + minY >= c.X + c.Y)
                    {
                        minX = c.X;
                        minY = c.Y;
                    }
                    if (maxX + maxY <= c.X + c.Y)
                    {
                        maxX = c.X;
                        maxY = c.Y;
                    }
                }
                points[0] = new Point(minX, minY);
                points[3] = new Point(maxX, maxY);
                points[1] = new Point(minX, maxY);
                points[2] = new Point(maxX, minY);
                foreach (var c in contour[0])
                {
                    if ((img.Width - points[1].X + points[1].Y) >= (img.Width - c.X + c.Y))
                        points[1] = new Point(c.X, c.Y);
                    if ((img.Height - points[2].Y + points[2].X) >= (img.Height - c.Y + c.X))
                        points[2] = new Point(c.X, c.Y);
                }
                Point2f[] srcs = Reorder(points);
                Point2f[] dsts = new Point2f[4];
                dsts[0] = new Point2f(0, 0);
                dsts[1] = new Point2f(orgImage.Width, 0);
                dsts[2] = new Point2f(0, orgImage.Height);
                dsts[3] = new Point2f(orgImage.Width, orgImage.Height);
                matrix = Cv2.GetPerspectiveTransform(srcs, dsts);
                Cv2.WarpPerspective(orgImage, orgImage, matrix, new Size(900, 788));
                orgImage.SaveImage(outputImagePath);
                using (var finalImage = new FileStream(outputImagePath, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                {
                    FinalImage = System.Drawing.Image.FromStream(finalImage);
                    finalImage.Close();
                }
            }
        }
        public SD.Image GetDrawContours(string inputImagePath)
        {
            using (var orgImage = new Mat(inputImagePath))
            {
                Cv2.Resize(orgImage, orgImage, new Size(900, 788));
                HierarchyIndex[] hierarchyIndexes;
                Mat img = new Mat();
                Mat kernal = Mat.Ones(5, 5, MatType.CV_8UC1);
                Cv2.CvtColor(orgImage, img, ColorConversionCodes.BGR2GRAY);
                Cv2.GaussianBlur(img, img, new Size(5, 5), 1);
                Cv2.Canny(img, img, Threshold1, Threshold2, apertureSize: 3);
                Cv2.Dilate(img, img, kernal, iterations: 2);
                Cv2.Erode(img, img, kernal, iterations: 1);
                Point[][] contours;
                Point[] bigc = new Point[4];
                Cv2.FindContours(
                    img,
                    out contours,
                    out hierarchyIndexes,
                    mode: RetrievalModes.External,
                    method: ContourApproximationModes.ApproxSimple);
                double area, peri, maxArea = 0;
                Point[][] contour = new Point[1][];
                foreach (var item in contours)
                {
                    area = Cv2.ContourArea(item);
                    if (area > 5000)
                    {
                        peri = Cv2.ArcLength(item, true);
                        var approx = Cv2.ApproxPolyDP(item, peri * 0.01, true);
                        if (area > maxArea)
                        {
                            maxArea = area;
                            contour[0] = item;
                        }
                    }
                }
                if (!(Threshold1 == 0 && Threshold2 == 0))
                    if (contour[0] != null)
                        Cv2.DrawContours(orgImage, contour, -1, Scalar.GreenYellow, 10);
                inputImagePath = "DrawContours.jpg";
                orgImage.SaveImage(inputImagePath);
                SD.Image im;
                using (var finalImage = new FileStream(@inputImagePath, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
                {
                    im = SD.Image.FromStream(finalImage);
                    finalImage.Close();
                    finalImage.Dispose();
                }
                if (File.Exists(inputImagePath))
                    File.Delete(inputImagePath);
                orgImage.Dispose();
                img.Dispose();
                kernal.Dispose();
                return im;
            }
        }
        private Point2f[] Reorder(Point[] points)
        {
            double[] sum = new double[4];
            double[] diff = new double[4];
            int i = 0;
            foreach (var point in points)
            {
                sum[i] = point.X + point.Y;
                diff[i++] = point.Y - point.X;
            }
            Point2f[] srcs = new Point2f[4];
            srcs[0] = points[Array.IndexOf(sum, sum.Min())];
            srcs[1] = points[Array.IndexOf(diff, diff.Min())];
            srcs[2] = points[Array.IndexOf(diff, diff.Max())];
            srcs[3] = points[Array.IndexOf(sum, sum.Max())];
            int f = 4, s = 8;
            srcs[0].X -= f; srcs[1].Y -= f; srcs[2].Y += f; srcs[3].X += f;
            srcs[0].Y -= s; srcs[1].X += s; srcs[2].X -= s; srcs[3].Y += s;
            return srcs;
        }
    }
}
