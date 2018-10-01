// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class BackgroundColorAnimation : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public Color From { get; set; }
		public Color To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		// FromとToの差を保持する
		private double rGap;
		private double gGap;
		private double bGap;

		protected override void Invoke(VisualElement sender)
		{
			CalculateGap(From, To);

			sender.Animate("BackgroundColor", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var rVal = rGap * animationRatio;
				var gVal = gGap * animationRatio;
				var bVal = bGap * animationRatio;
				sender.BackgroundColor = Color.FromRgb(From.R + rVal, From.G + gVal, From.B + bVal);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}

		/// <summary>
		/// Calculates the gap between From and To.
		/// </summary>
		private void CalculateGap(Color from, Color to)
		{
			rGap = to.R - from.R;
			gGap = to.G - from.G;
			bGap = to.B - from.B;
		}

	}
}
