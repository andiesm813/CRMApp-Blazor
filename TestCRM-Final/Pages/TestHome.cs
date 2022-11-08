using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_Final.Pages;
using CRM_Final.ECommerce;
using CRM_Final.Northwind;
using CRM_Final.CRMApp;

namespace TestCRM_Final
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
				typeof(IgniteUI.Blazor.Controls.IgbGridModule),
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