using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeDoubleAnimation : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public double From { get; set; }
		public double To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		private double gap;

		public LabelFontSizeDoubleAnimation() { }

		/// <summary>
		/// Invoke change font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			gap = CalculateGap(From, To);

			var animation = new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var currentSize = gap * animationRatio;
				(sender as Label).FontSize = From + currentSize;
			});
			sender.Animate("LabelFontSize", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}

		/// <summary>
		/// Calculates the font-size gap.
		/// </summary>
		/// <returns>The gap.</returns>
		/// <param name="from">From.</param>
		/// <param name="to">To.</param>
		private double CalculateGap(double from, double to)
		{
			return to - from;
		}
	}
}
