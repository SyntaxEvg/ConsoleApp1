using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200003E RID: 62
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "7f2d24d8a37e30fcc7830d3d7bd882ca385849e6d9ab40df93d4e3d5a7e05122", "/Areas/Admin/Views/Shared/_ValidationSummary.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Shared/_ValidationSummary.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Shared__ValidationSummary : BaseRazorPage<object>
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000B9FB File Offset: 0x00009BFB
		private TagHelperScopeManager __tagHelperScopeManager
		{
			get
			{
				if (this.__backed__tagHelperScopeManager == null)
				{
					this.__backed__tagHelperScopeManager = new TagHelperScopeManager(new Action<HtmlEncoder>(base.StartTagHelperWritingScope), new Func<TagHelperContent>(base.EndTagHelperWritingScope));
				}
				return this.__backed__tagHelperScopeManager;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000BA30 File Offset: 0x00009C30
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Shared__ValidationSummary.<ExecuteAsync>d__8 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000BA73 File Offset: 0x00009C73
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000BA7B File Offset: 0x00009C7B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000BA84 File Offset: 0x00009C84
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000BA8C File Offset: 0x00009C8C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000BA95 File Offset: 0x00009C95
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000BA9D File Offset: 0x00009C9D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000BAA6 File Offset: 0x00009CA6
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000BAAE File Offset: 0x00009CAE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000BAB7 File Offset: 0x00009CB7
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000BABF File Offset: 0x00009CBF
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x04000264 RID: 612
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000265 RID: 613
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000266 RID: 614
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000267 RID: 615
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000268 RID: 616
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000269 RID: 617
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A29 RID: 2601 RVA: 0x00042454 File Offset: 0x00040654
			internal Task <ExecuteAsync>b__8_0()
			{
				Areas_Admin_Views_Shared__ValidationSummary.<>c.<<ExecuteAsync>b__8_0>d <<ExecuteAsync>b__8_0>d;
				<<ExecuteAsync>b__8_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__8_0>d.<>1__state = -1;
				<<ExecuteAsync>b__8_0>d.<>t__builder.Start<Areas_Admin_Views_Shared__ValidationSummary.<>c.<<ExecuteAsync>b__8_0>d>(ref <<ExecuteAsync>b__8_0>d);
				return <<ExecuteAsync>b__8_0>d.<>t__builder.Task;
			}

			// Token: 0x040007CE RID: 1998
			public static readonly Areas_Admin_Views_Shared__ValidationSummary.<>c <>9 = new Areas_Admin_Views_Shared__ValidationSummary.<>c();

			// Token: 0x040007CF RID: 1999
			public static Func<Task> <>9__8_0;

			// Token: 0x02000318 RID: 792
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__8_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F3E RID: 3902 RVA: 0x0007465C File Offset: 0x0007285C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					try
					{
					}
					catch (Exception ex)
					{
						this.<>1__state = -2;
						this.<>t__builder.SetException(ex);
						return;
					}
					this.<>1__state = -2;
					this.<>t__builder.SetResult();
				}

				// Token: 0x06000F3F RID: 3903 RVA: 0x000746AC File Offset: 0x000728AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ED1 RID: 3793
				public int <>1__state;

				// Token: 0x04000ED2 RID: 3794
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000144 RID: 324
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x06000A2A RID: 2602 RVA: 0x00042490 File Offset: 0x00040690
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared__ValidationSummary areas_Admin_Views_Shared__ValidationSummary = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_019E;
						}
						if (areas_Admin_Views_Shared__ValidationSummary.ViewContext.ModelState.IsValid)
						{
							goto IL_01D2;
						}
						areas_Admin_Views_Shared__ValidationSummary.WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Error</strong>\r\n        ");
						areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext = areas_Admin_Views_Shared__ValidationSummary.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "7f2d24d8a37e30fcc7830d3d7bd882ca385849e6d9ab40df93d4e3d5a7e051224171", new Func<Task>(Areas_Admin_Views_Shared__ValidationSummary.<>c.<>9.<ExecuteAsync>b__8_0));
						areas_Admin_Views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_Shared__ValidationSummary.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__ValidationSummary.__tagHelperAttribute_0);
						awaiter2 = areas_Admin_Views_Shared__ValidationSummary.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
					}
					awaiter2.GetResult();
					if (areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01A5;
					}
					awaiter = areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref awaiter, ref this);
						return;
					}
					IL_019E:
					awaiter.GetResult();
					IL_01A5:
					areas_Admin_Views_Shared__ValidationSummary.Write(areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__ValidationSummary.__tagHelperExecutionContext = areas_Admin_Views_Shared__ValidationSummary.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__ValidationSummary.WriteLiteral("\r\n    </div>\r\n");
					IL_01D2:;
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A2B RID: 2603 RVA: 0x000426BC File Offset: 0x000408BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007D0 RID: 2000
			public int <>1__state;

			// Token: 0x040007D1 RID: 2001
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007D2 RID: 2002
			public Areas_Admin_Views_Shared__ValidationSummary <>4__this;

			// Token: 0x040007D3 RID: 2003
			private TaskAwaiter <>u__1;
		}
	}
}
