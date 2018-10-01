using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ChangeLabelTextColorTriggerAction : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public Color From { set; get; }
		public Color To { set; get; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		// FromとToの差を保持する
		private double _RGap;
		private double _GGap;
		private double _BGap;

		public ChangeLabelTextColorTriggerAction()
		{
			if (From == null || To == null) throw new InvalidDataException("There's no From or(and) To Color.");
		}

		protected override void Invoke(VisualElement sender)
		{
			CalculateGap();

			sender.Animate("ChangeLabelTextColor", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				var rVal = _RGap * animationRatio;
				var gVal = _GGap * animationRatio;
				var bVal = _BGap * animationRatio;
				(sender as Label).TextColor = Color.FromRgb(From.R + rVal, From.G + gVal, From.B + bVal);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}

		/// <summary>
		/// Calculates the gap between From and To.
		/// </summary>
		private void CalculateGap()
		{
			_RGap = To.R - From.R;
			_GGap = To.G - From.G;
			_BGap = To.B - From.B;
		}

	}
}
