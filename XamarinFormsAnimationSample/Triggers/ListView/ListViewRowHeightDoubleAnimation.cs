using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ListViewRowHeightDoubleAnimation : AnimationBase<int>
	{
		/// <summary>
		/// Invoke ListView RowHeight animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ListView).RowHeight);

			var animation = new Animation((d) =>
			{
				(sender as ListView).RowHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("ListViewRowHeightDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
