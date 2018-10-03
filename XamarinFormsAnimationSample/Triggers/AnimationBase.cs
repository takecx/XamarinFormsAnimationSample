using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class AnimationBase<T> : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public T From { get; set; }
		public T To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		protected override void Invoke(VisualElement sender)
		{
			Console.WriteLine("Please Implement Invoke()");
		}
	}
}
