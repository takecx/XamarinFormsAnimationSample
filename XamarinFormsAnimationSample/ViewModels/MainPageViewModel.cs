using System;
using System.Threading;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace XamarinFormsAnimationSample
{
	public class MainPageViewModel : BindableBase
	{
		#region BindableProperty
		private bool _IsAnimationStart;
		public bool m_IsAnimationStart
		{
			get { return _IsAnimationStart; }
			set { this.SetProperty(ref this._IsAnimationStart, value); }
		}
		#endregion

		#region Commands
		public DelegateCommand StartAnimationCommand { get; }
		#endregion

		public MainPageViewModel()
		{
			// Create Commands
			StartAnimationCommand = new DelegateCommand(StartAnimation);
		}

		private void StartAnimation()
		{
			m_IsAnimationStart = true;

			// １秒待ってfalseにする
			Task.Run(() =>
			{
				Thread.Sleep(1000);
			}).ContinueWith((r) =>
			{
				m_IsAnimationStart = false;
			});
		}
	}
}
