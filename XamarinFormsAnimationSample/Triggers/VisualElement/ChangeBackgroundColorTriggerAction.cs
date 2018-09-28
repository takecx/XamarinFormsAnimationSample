// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ChangeBackgroundColorTriggerAction : TriggerAction<VisualElement>
	{
		public int StartsFrom { set; get; }

		public ChangeBackgroundColorTriggerAction()
		{
		}

		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("ChangeBackgroundColor", new Animation((d) =>
			{
				var val = StartsFrom == 0 ? d : 1 - d;  // modify [StartsFrom == 1] -> [StartsFrom == 0]
				sender.BackgroundColor = Color.FromRgb(1, val, 1);
				Console.WriteLine(d);
			}),
			length: 1000, // milliseconds
			easing: Easing.Linear);
		}
	}
}
