using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Pages;

namespace TestCustomer_Relationship_Management
{
	public class TestAccountSample
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule));
			var componentUnderTest = ctx.RenderComponent<AccountSample>();
			Assert.NotNull(componentUnderTest);
		}
	}
}