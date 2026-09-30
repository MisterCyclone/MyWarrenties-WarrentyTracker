using Firebase.Auth;
using Firebase.Auth.Providers;


namespace WarrentyTracker1._0.Shared
{
	static class FirebaseCredentials
	{
		public static FirebaseAuthConfig GetConfig()
		{
			var config = new FirebaseAuthConfig
			{
				ApiKey = "AIzaSyBaArtxPSe1KpoNf9hgi7W1Or06Hv97EBM",
				AuthDomain = "mywarranties-7e52e.firebaseapp.com",

				Providers = new FirebaseAuthProvider[]
				{
					new EmailProvider()
				}

			};
			return config;
		}
	}
}
