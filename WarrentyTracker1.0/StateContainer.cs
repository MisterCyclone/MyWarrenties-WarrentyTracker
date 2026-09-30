using Firebase.Auth;


namespace WarrentyTracker1._0
{
	public class StateContainer
	{
		private UserCredential _currentUser = null;
		public UserCredential CurrentUser 
		{ 
			get { return _currentUser; }
			set { _currentUser = value; NotifyStateChange(); } 
		}
		

		public event Action? OnChange;
		private void NotifyStateChange() => OnChange?.Invoke();
	}
}
