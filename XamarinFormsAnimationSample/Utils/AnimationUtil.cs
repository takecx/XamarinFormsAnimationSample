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
			var gap = new Thickness(to.Left - from.Left, to.Top - from.Top, to.Right - from.Right, to.Bottom - from.Bottom);
			return new Thickness(from.Left + gap.Left, from.Top + gap.Top, from.Right + gap.Right, from.Bottom + gap.Bottom);
		}
	}
}
