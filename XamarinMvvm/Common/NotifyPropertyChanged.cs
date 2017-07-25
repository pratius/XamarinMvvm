using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinMvvm.Common
{
    public class NotifyPropertyChanged:INotifyPropertyChanged
    {
		/// <summary>
		/// Properties changed event handler 
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
		/// <summary>
		/// Calling this method on propertyChanged from source to target or target ot source
		/// </summary>
		/// <param name="propertiesName">Propertiesname.</param>
		public void OnPropertyChanged([CallerMemberName] string propertiesName = "")
		{
			var handler = PropertyChanged;
			if (handler == null)
				return;
			handler(this, new PropertyChangedEventArgs(propertiesName));
		}
    }
}
