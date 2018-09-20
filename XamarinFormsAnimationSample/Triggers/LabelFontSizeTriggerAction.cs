using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeTriggerAction : TriggerAction<VisualElement>
	{
		public int FontSize { get; set; }

		public LabelFontSizeTriggerAction()
		{
		}

		protected override void Invoke(VisualElement sender)
		{
			var animation = new Animation((d) =>
			{
				var label = sender as Label;
				label.FontSize = FontSize;
			});
			sender.Animate("", animation, length: 1000, easing: Easing.Linear);
		}
	}
}
