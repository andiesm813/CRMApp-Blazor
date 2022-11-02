using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Customer_Relationship_Management.Pages;

namespace TestCustomer_Relationship_Management
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