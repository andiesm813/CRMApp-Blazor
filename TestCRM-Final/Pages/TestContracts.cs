using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_Final.Pages;

namespace TestCRM_Final
{
	public class TestContracts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Contracts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}