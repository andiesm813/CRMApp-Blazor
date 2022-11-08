using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_Final.Pages;

namespace TestCRM_Final
{
	public class TestTasks
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Tasks>();
			Assert.NotNull(componentUnderTest);
		}
	}
}