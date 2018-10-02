// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Interfaces;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class BackgroundColorAnimation : TriggerAction<VisualElement>, ITriggerAction<Color>
	{
		// Animation Parameter
		public Color From { get; set; }
		public Color To { get; set; }
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
		/// Invoke change BackgroundColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			var gap = CalculateGap(From, To);

			sender.Animate("BackgroundColorAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var rVal = gap.R * animationRatio;
				var gVal = gap.G * animationRatio;
				var bVal = gap.B * animationRatio;
				sender.BackgroundColor = Color.FromRgb(From.R + rVal, From.G + gVal, From.B + bVal);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
