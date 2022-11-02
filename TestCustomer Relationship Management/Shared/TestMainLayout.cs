using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Shared;

namespace TestCustomer_Relationship_Management
{
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbNavbarModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbNavDrawerModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}