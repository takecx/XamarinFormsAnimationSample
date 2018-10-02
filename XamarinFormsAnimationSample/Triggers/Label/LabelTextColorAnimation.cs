using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Interfaces;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelTextColorAnimation : TriggerAction<VisualElement>, ITriggerAction<Color>
	{
		// Animation Parameter
		public Color From { set; get; }
		public Color To { set; get; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		/// <summary>
		/// Calculates the gap Color between From and To.
		/// </summary>
		/// <returns>The gap.</returns>
		/// <param name="from">From.</param>
		/// <param name="to">To.</param>
		public Color CalculateGap(Color from, Color to)
		{
			return Color.FromRgb(to.R - from.R, to.G - from.G, to.B - from.B);
		}

		/// <summary>
		/// Invoke change Label TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			var gap = CalculateGap(From, To);

			sender.Animate("LabelTextColorAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var rVal = gap.R * animationRatio;
				var gVal = gap.G * animationRatio;
				var bVal = gap.B * animationRatio;
				(sender as Label).TextColor = Color.FromRgb(From.R + rVal, From.G + gVal, From.B + bVal);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
