using System;
using System.IO;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ChangeLabelTextColorTriggerAction : TriggerAction<VisualElement>
	{
		public int StartsFrom { set; get; }
		public Color From { set; get; }
		public Color To { set; get; }

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
				var percent = StartsFrom == 0 ? d : 1 - d;
				var rVal = _RGap * percent;
				var gVal = _GGap * percent;
				var bVal = _BGap * percent;
				var label = sender as Label;
				label.TextColor = Color.FromRgb(From.R + rVal, From.G + gVal, From.B + bVal);
			}),
			length: 1000, // milliseconds
			easing: Easing.Linear);
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
