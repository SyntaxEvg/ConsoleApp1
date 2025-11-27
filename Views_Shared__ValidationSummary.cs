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
	// Token: 0x0200004D RID: 77
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "7f2d24d8a37e30fcc7830d3d7bd882ca385849e6d9ab40df93d4e3d5a7e05122", "/Views/Shared/_ValidationSummary.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/_ValidationSummary.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared__ValidationSummary : BaseRazorPage<object>
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000D92B File Offset: 0x0000BB2B
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

		// Token: 0x06000389 RID: 905 RVA: 0x0000D960 File Offset: 0x0000BB60
		public override Task ExecuteAsync()
		{
			Views_Shared__ValidationSummary.<ExecuteAsync>d__8 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000D9A3 File Offset: 0x0000BBA3
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0000D9AB File Offset: 0x0000BBAB
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000D9C5 File Offset: 0x0000BBC5
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000D9CD File Offset: 0x0000BBCD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000D9D6 File Offset: 0x0000BBD6
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000D9DE File Offset: 0x0000BBDE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000D9E7 File Offset: 0x0000BBE7
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0000D9EF File Offset: 0x0000BBEF
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x04000385 RID: 901
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000386 RID: 902
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000387 RID: 903
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000388 RID: 904
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000389 RID: 905
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400038A RID: 906
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000ADB RID: 2779 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
			internal Task <ExecuteAsync>b__8_0()
			{
				Views_Shared__ValidationSummary.<>c.<<ExecuteAsync>b__8_0>d <<ExecuteAsync>b__8_0>d;
				<<ExecuteAsync>b__8_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__8_0>d.<>1__state = -1;
				<<ExecuteAsync>b__8_0>d.<>t__builder.Start<Views_Shared__ValidationSummary.<>c.<<ExecuteAsync>b__8_0>d>(ref <<ExecuteAsync>b__8_0>d);
				return <<ExecuteAsync>b__8_0>d.<>t__builder.Task;
			}

			// Token: 0x040008BF RID: 2239
			public static readonly Views_Shared__ValidationSummary.<>c <>9 = new Views_Shared__ValidationSummary.<>c();

			// Token: 0x040008C0 RID: 2240
			public static Func<Task> <>9__8_0;

			// Token: 0x02000355 RID: 853
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__8_0>d : IAsyncStateMachine
			{
				// Token: 0x06000FB8 RID: 4024 RVA: 0x00076B28 File Offset: 0x00074D28
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

				// Token: 0x06000FB9 RID: 4025 RVA: 0x00076B78 File Offset: 0x00074D78
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F4D RID: 3917
				public int <>1__state;

				// Token: 0x04000F4E RID: 3918
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000182 RID: 386
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__8 : IAsyncStateMachine
		{
			// Token: 0x06000ADC RID: 2780 RVA: 0x0005000C File Offset: 0x0004E20C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__ValidationSummary views_Shared__ValidationSummary = this.<>4__this;
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
						if (views_Shared__ValidationSummary.ViewContext.ModelState.IsValid)
						{
							goto IL_01D2;
						}
						views_Shared__ValidationSummary.WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <strong>Error</strong>\r\n        ");
						views_Shared__ValidationSummary.__tagHelperExecutionContext = views_Shared__ValidationSummary.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "7f2d24d8a37e30fcc7830d3d7bd882ca385849e6d9ab40df93d4e3d5a7e051224480", new Func<Task>(Views_Shared__ValidationSummary.<>c.<>9.<ExecuteAsync>b__8_0));
						views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = views_Shared__ValidationSummary.CreateTagHelper<ValidationSummaryTagHelper>();
						views_Shared__ValidationSummary.__tagHelperExecutionContext.Add(views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						views_Shared__ValidationSummary.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", views_Shared__ValidationSummary.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						views_Shared__ValidationSummary.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__ValidationSummary.__tagHelperAttribute_0);
						awaiter2 = views_Shared__ValidationSummary.__tagHelperRunner.RunAsync(views_Shared__ValidationSummary.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref awaiter2, ref this);
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
					if (views_Shared__ValidationSummary.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01A5;
					}
					awaiter = views_Shared__ValidationSummary.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__ValidationSummary.<ExecuteAsync>d__8>(ref awaiter, ref this);
						return;
					}
					IL_019E:
					awaiter.GetResult();
					IL_01A5:
					views_Shared__ValidationSummary.Write(views_Shared__ValidationSummary.__tagHelperExecutionContext.Output);
					views_Shared__ValidationSummary.__tagHelperExecutionContext = views_Shared__ValidationSummary.__tagHelperScopeManager.End();
					views_Shared__ValidationSummary.WriteLiteral("\r\n    </div>\r\n");
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

			// Token: 0x06000ADD RID: 2781 RVA: 0x00050238 File Offset: 0x0004E438
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008C1 RID: 2241
			public int <>1__state;

			// Token: 0x040008C2 RID: 2242
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008C3 RID: 2243
			public Views_Shared__ValidationSummary <>4__this;

			// Token: 0x040008C4 RID: 2244
			private TaskAwaiter <>u__1;
		}
	}
}
