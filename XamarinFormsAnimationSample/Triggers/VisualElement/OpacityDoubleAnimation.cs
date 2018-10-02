using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Interfaces;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class OpacityDoubleAnimation : TriggerAction<VisualElement>, ITriggerAction<double>
	{
		// Animation Parameter
		public double From { get; set; }
		public double To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		/// <summary>
		/// Calculates the gap.
		/// </summary>
		/// <returns>The gap.</returns>
		/// <param name="from">From.</param>
		/// <param name="to">To.</param>
		public double CalculateGap(double from, double to)
		{
			return to - from;
		}

		protected override void Invoke(VisualElement sender)
		{
			var gap = CalculateGap(From, To);
			sender.Animate("OpacityDoubleAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var currentValue = gap * animationRatio;
				sender.Opacity = From + currentValue;
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
