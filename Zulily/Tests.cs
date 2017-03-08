using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Zulily
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("LAST CHANCE");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Last Chance'");

			app.ScrollDown();
			Thread.Sleep(4000);
			app.Screenshot("Let's scroll down to see more information");

			app.Tap("UPCOMING");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Upcoming'");

			app.Tap("NEW TODAY");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'New Today'");

			Thread.Sleep(4000);
			app.Tap("women");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Women'");

			Thread.Sleep(4000);
			app.Tap(x => x.Marked("product_horizontal_image"));
			Thread.Sleep(4000);
			app.Screenshot("Tapped on the item we want");

			app.ScrollDown();
			Thread.Sleep(4000);
			app.Screenshot("Let's scroll down to see more information");

			Thread.Sleep(4000);
			app.Tap("size");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Size");

			Thread.Sleep(4000);
			app.Tap("S");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on my size");

			Thread.Sleep(4000);
			app.Tap("product_add_to_basket");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Sign In'");

			Thread.Sleep(4000);
			app.Tap("login_switch");
			Thread.Sleep(4000);
			app.Screenshot("Continue with Login process");

			app.Tap("login_email");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on E-Mail Text Field");

			app.EnterText("MicrosoftLovesZulily@zzz.com");
			Thread.Sleep(4000);
			app.Screenshot("Wrote in our E-mail");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			Thread.Sleep(4000);
			app.Tap("login_password");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on Password Field");

			app.EnterText("Christmas");
			Thread.Sleep(4000);
			app.Screenshot("Wrote in our Password, 'Christmas'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			Thread.Sleep(4000);
			app.Tap("signup_submit_section");
			Thread.Sleep(4000);
			app.Screenshot("Tapped on 'Signup' Button");

			Thread.Sleep(4000);
			app.Tap("product_add_to_basket");
			Thread.Sleep(30000);
			app.Screenshot("Added product to our shopping cart");











		}





	}
}
