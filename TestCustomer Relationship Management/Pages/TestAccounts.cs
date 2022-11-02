using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Pages;
using Customer_Relationship_Management.Northwind;

namespace TestCustomer_Relationship_Management
{
	public class TestAccounts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownModule),
				typeof(IgniteUI.Blazor.Controls.IgbDropdownItemModule),
				typeof(IgniteUI.Blazor.Controls.IgbDataGridModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Accounts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}