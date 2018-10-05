using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Utils
{
	public static class AnimationUtil
	{
		public static double CalcCurrentValue(double from, double to, double animationRatio)
		{
			var gap = to - from;
			return from + gap * animationRatio;
		}

		public static Color CalcCurrentValue(Color from, Color to, double animationRatio)
		{
			var rVal = (to.R - from.R) * animationRatio;
			var gVal = (to.G - from.G) * animationRatio;
			var bVal = (to.B - from.B) * animationRatio;
			return Color.FromRgb(from.R + rVal, from.G + gVal, from.B + bVal);
		}

		public static Thickness CalcCurrentValue(Thickness from, Thickness to, double animationRatio)
		{
			return new Thickness(from.Left + (to.Left - from.Left),
								 from.Top + (to.Top - from.Top),
								 from.Right + (to.Right - from.Right),
								 from.Bottom + (to.Bottom - from.Bottom));
		}
	}
}
