using System.Collections.Generic;
using System.Drawing;

namespace PaintClone
{
    public static class Utils
    {

        public static void SwapRectanglePoints(ref int firstX, ref int firstY, ref int lastX, ref int lastY)
        {
            if (firstX <= lastX && firstY <= lastY)
            {
            }
            else if (firstX >= lastX && firstY <= lastY)
            {
                var t = firstX;
                firstX = lastX;
                lastX = t;
            }
            else if (firstX >= lastX && firstY >= lastY)
            {
                var t1 = firstX;
                var t2 = firstY;
                firstX = lastX;
                firstY = lastY;
                lastX = t1;
                lastY = t2;
            }
            else if (firstX <= lastX && firstY >= lastY)
            {
                var t = firstY;
                firstY = lastY;
                lastY = t;
            }
        }

        public static Point ApplyOffset(Point point, Point offset)
        {
            point.Offset(offset);
            return point;
        }

        public static Point[] ApplyOffsetToPoints(List<Point> points, Point offset)
        {
            var offsetedPoints = new Point[points.Count];
            for (int i = 0; i < points.Count; i++)
            {
                offsetedPoints[i] = ApplyOffset(points[i], offset);
            }
            return offsetedPoints;
        }
    }
}