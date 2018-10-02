using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Utils
{
	public static class AnimationUtil
	{
		public static double CalculateCurrentValue(double from, double to, double animationRatio)
		{
			var gap = to - from;
			return from + gap * animationRatio;
		}

		public static Color CalculateCurrentValue(Color from, Color to, double animationRatio)
		{
			var gap = Color.FromRgb(to.R - from.R, to.G - from.G, to.B - from.B);
			var rVal = gap.R * animationRatio;
			var gVal = gap.G * animationRatio;
			var bVal = gap.B * animationRatio;

			return Color.FromRgb(from.R + rVal, from.G + gVal, from.B + bVal);
		}
	}
}
