using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Pages;
using Customer_Relationship_Management.ECommerce;
using Customer_Relationship_Management.Northwind;
using Customer_Relationship_Management.CRMApp;

namespace TestCustomer_Relationship_Management
{
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbDataGridModule),
				typeof(IgniteUI.Blazor.Controls.IgbListModule),
				typeof(IgniteUI.Blazor.Controls.IgbAvatarModule),
				typeof(IgniteUI.Blazor.Controls.IgbChipModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new ECommerceService(mockHttpClient));
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			ctx.Services.AddSingleton(new CRMAppService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}