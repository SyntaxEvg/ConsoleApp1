using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using HAS.Server.TagHelpers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CSharp.RuntimeBinder;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200004B RID: 75
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe6", "/Views/Shared/_Layout.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/_Layout.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared__Layout : BaseRazorPage<object>
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000D3DF File Offset: 0x0000B5DF
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

		// Token: 0x06000366 RID: 870 RVA: 0x0000D414 File Offset: 0x0000B614
		public override Task ExecuteAsync()
		{
			Views_Shared__Layout.<ExecuteAsync>d__21 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared__Layout.<ExecuteAsync>d__21>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000D457 File Offset: 0x0000B657
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0000D45F File Offset: 0x0000B65F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000D468 File Offset: 0x0000B668
		// (set) Token: 0x0600036A RID: 874 RVA: 0x0000D470 File Offset: 0x0000B670
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000D479 File Offset: 0x0000B679
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000D481 File Offset: 0x0000B681
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000D48A File Offset: 0x0000B68A
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000D492 File Offset: 0x0000B692
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000D49B File Offset: 0x0000B69B
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000D4A3 File Offset: 0x0000B6A3
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000D594 File Offset: 0x0000B794
		[CompilerGenerated]
		private Task <ExecuteAsync>b__21_0()
		{
			Views_Shared__Layout.<<ExecuteAsync>b__21_0>d <<ExecuteAsync>b__21_0>d;
			<<ExecuteAsync>b__21_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__21_0>d.<>4__this = this;
			<<ExecuteAsync>b__21_0>d.<>1__state = -1;
			<<ExecuteAsync>b__21_0>d.<>t__builder.Start<Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref <<ExecuteAsync>b__21_0>d);
			return <<ExecuteAsync>b__21_0>d.<>t__builder.Task;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__21_1()
		{
			Views_Shared__Layout.<<ExecuteAsync>b__21_1>d <<ExecuteAsync>b__21_1>d;
			<<ExecuteAsync>b__21_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__21_1>d.<>4__this = this;
			<<ExecuteAsync>b__21_1>d.<>1__state = -1;
			<<ExecuteAsync>b__21_1>d.<>t__builder.Start<Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref <<ExecuteAsync>b__21_1>d);
			return <<ExecuteAsync>b__21_1>d.<>t__builder.Task;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000D61C File Offset: 0x0000B81C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__21_5()
		{
			Views_Shared__Layout.<<ExecuteAsync>b__21_5>d <<ExecuteAsync>b__21_5>d;
			<<ExecuteAsync>b__21_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__21_5>d.<>4__this = this;
			<<ExecuteAsync>b__21_5>d.<>1__state = -1;
			<<ExecuteAsync>b__21_5>d.<>t__builder.Start<Views_Shared__Layout.<<ExecuteAsync>b__21_5>d>(ref <<ExecuteAsync>b__21_5>d);
			return <<ExecuteAsync>b__21_5>d.<>t__builder.Task;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000D660 File Offset: 0x0000B860
		[CompilerGenerated]
		private Task <ExecuteAsync>b__21_9()
		{
			Views_Shared__Layout.<<ExecuteAsync>b__21_9>d <<ExecuteAsync>b__21_9>d;
			<<ExecuteAsync>b__21_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__21_9>d.<>4__this = this;
			<<ExecuteAsync>b__21_9>d.<>1__state = -1;
			<<ExecuteAsync>b__21_9>d.<>t__builder.Start<Views_Shared__Layout.<<ExecuteAsync>b__21_9>d>(ref <<ExecuteAsync>b__21_9>d);
			return <<ExecuteAsync>b__21_9>d.<>t__builder.Task;
		}

		// Token: 0x04000356 RID: 854
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", new HtmlString("stylesheet"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000357 RID: 855
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", new HtmlString("text/css"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000358 RID: 856
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("href", "/uas/lib/bootstrap/dist/css/bootstrap.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000359 RID: 857
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("href", "/uas/lib/font-awesome/css/all.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035A RID: 858
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("href", "/_customs/has.uas/css/login.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035B RID: 859
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("include", "Development", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035C RID: 860
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("src", "/uas/lib/jquery/jquery.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035D RID: 861
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("src", "/uas/lib/font-awesome/js/all.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035E RID: 862
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("src", "/uas/lib/bootstrap/dist/js/bootstrap.bundle.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400035F RID: 863
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000360 RID: 864
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000361 RID: 865
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000362 RID: 866
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000363 RID: 867
		private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

		// Token: 0x04000364 RID: 868
		private LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;

		// Token: 0x04000365 RID: 869
		private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;

		// Token: 0x04000366 RID: 870
		private EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;

		// Token: 0x04000367 RID: 871
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x04000368 RID: 872
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x02000175 RID: 373
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__21_0>d : IAsyncStateMachine
		{
			// Token: 0x06000AB7 RID: 2743 RVA: 0x0004D6A0 File Offset: 0x0004B8A0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout views_Shared__Layout = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
					TaskAwaiter awaiter5;
					TaskAwaiter awaiter6;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_01DC;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0346;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03BB;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0525;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_059A;
					default:
						views_Shared__Layout.WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>MEGA HOPEX</title>\r\n    <link rel=\"apple-touch-icon\" href=\"/_customs/has.uas/images/apple-touch-icon.png\" />\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"32x32\" href=\"/_customs/has.uas/images/favicon-32x32.png\" />\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"/_customs/has.uas/images/favicon-16x16.png\" />\r\n    <link rel=\"shortcut icon\" type=\"images/x-icon\" href=\"/_customs/has.uas/images/favicon.ico\" />\r\n\r\n    <link rel=\"mask-icon\" href=\"/uas/shared/images/safari-pinned-tab.svg\" color=\"#5bbad5\" />\r\n    <meta name=\"msapplication-config\" content=\"/_customs/has.uas/images/browserconfig.xml\" />\r\n\r\n    <meta name=\"msapplication-TileColor\" content=\"#da532c\">\r\n    <meta name=\"theme-color\" content=\"#ffffff\">\r\n\r\n    ");
						views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe68604", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_2));
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout.CreateTagHelper<LinkTagHelper>();
						views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
						views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_0);
						views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_1);
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout.__tagHelperAttribute_2.Value;
						views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_2);
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
						views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01E3;
					}
					awaiter2 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_01DC:
					awaiter2.GetResult();
					IL_01E3:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe610457", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_3));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout.CreateTagHelper<LinkTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_0);
					views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_1);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout.__tagHelperAttribute_3.Value;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_3);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0346:
					awaiter3.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_03C2;
					}
					awaiter4 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_03BB:
					awaiter4.GetResult();
					IL_03C2:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe612311", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_4));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout.CreateTagHelper<LinkTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_0);
					views_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout.__tagHelperAttribute_1);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout.__tagHelperAttribute_4.Value;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_4);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_0525:
					awaiter5.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_05A1;
					}
					awaiter6 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_059A:
					awaiter6.GetResult();
					IL_05A1:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n\r\n    ");
					views_Shared__Layout.Write(views_Shared__Layout.RenderSection("StyleSheets", false));
					views_Shared__Layout.WriteLiteral("\r\n\r\n");
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

			// Token: 0x06000AB8 RID: 2744 RVA: 0x0004DCE4 File Offset: 0x0004BEE4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400088E RID: 2190
			public int <>1__state;

			// Token: 0x0400088F RID: 2191
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000890 RID: 2192
			public Views_Shared__Layout <>4__this;

			// Token: 0x04000891 RID: 2193
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000176 RID: 374
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__21_1>d : IAsyncStateMachine
		{
			// Token: 0x06000AB9 RID: 2745 RVA: 0x0004DCF4 File Offset: 0x0004BEF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout views_Shared__Layout = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
					TaskAwaiter awaiter5;
					TaskAwaiter awaiter6;
					TaskAwaiter awaiter7;
					TaskAwaiter awaiter8;
					TaskAwaiter awaiter9;
					TaskAwaiter awaiter10;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0187;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_040B;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0480;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_05CA;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_063F;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0789;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_07FE;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0906;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_097C;
					default:
						views_Shared__Layout.WriteLiteral("\r\n    ");
						views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("environment", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe615450", new Func<Task>(views_Shared__Layout.<ExecuteAsync>b__21_5));
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = views_Shared__Layout.CreateTagHelper<EnvironmentTagHelper>();
						views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)Views_Shared__Layout.__tagHelperAttribute_5.Value;
						views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_5);
						awaiter = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_018E;
					}
					awaiter2 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter2, ref this);
						return;
					}
					IL_0187:
					awaiter2.GetResult();
					IL_018E:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    <div class=\"container fluid h-100\">\r\n        <div class=\"row h-100 align-items-center justify-content-center text-center\">\r\n            <div class=\"login\">\r\n                ");
					views_Shared__Layout.Write(views_Shared__Layout.RenderBody());
					views_Shared__Layout.WriteLiteral("\r\n                <div class=\"mt-5 mb-3 footer w-100\">\r\n                    <label class=\"mega-info\">\r\n                        ");
					if (Views_Shared__Layout.<>o__21.<>p__1 == null)
					{
						Views_Shared__Layout.<>o__21.<>p__1 = CallSite<Action<CallSite, Views_Shared__Layout, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(Views_Shared__Layout), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Views_Shared__Layout, object> target = Views_Shared__Layout.<>o__21.<>p__1.Target;
					CallSite <>p__ = Views_Shared__Layout.<>o__21.<>p__1;
					Views_Shared__Layout views_Shared__Layout2 = views_Shared__Layout;
					object model = views_Shared__Layout.Model;
					object obj;
					if (model == null)
					{
						obj = null;
					}
					else
					{
						if (Views_Shared__Layout.<>o__21.<>p__0 == null)
						{
							Views_Shared__Layout.<>o__21.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "MegaInfo", typeof(Views_Shared__Layout), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						obj = Views_Shared__Layout.<>o__21.<>p__0.Target(Views_Shared__Layout.<>o__21.<>p__0, model);
					}
					target(<>p__, views_Shared__Layout2, obj);
					views_Shared__Layout.WriteLiteral(" <br>\r\n                        <a class=\"text-white\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#privacyModal\">");
					views_Shared__Layout.Write(views_Shared__Layout.T["Privacy and Cookie Policy"]);
					views_Shared__Layout.WriteLiteral("</a>\r\n                    </label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"modal fade\" id=\"privacyModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"privacyModal\" aria-hidden=\"true\">\r\n            <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable modal-lg\" role=\"document\">\r\n                <div class=\"modal-content\">\r\n                    <div class=\"modal-header\">\r\n                        <h3 class=\"modal-title\">");
					views_Shared__Layout.Write(views_Shared__Layout.T["Privacy Policy"]);
					views_Shared__Layout.WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"modal-body\">\r\n                        <div class=\"container-fluid\" id=\"privacyPolicyContent\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-hopex\" data-bs-dismiss=\"modal\">");
					views_Shared__Layout.Write(views_Shared__Layout.T["Close"]);
					views_Shared__Layout.WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe619566", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_6));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout.CreateTagHelper<ScriptTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout.__tagHelperAttribute_6.Value;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_6);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter3, ref this);
						return;
					}
					IL_040B:
					awaiter3.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0487;
					}
					awaiter4 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter4, ref this);
						return;
					}
					IL_0480:
					awaiter4.GetResult();
					IL_0487:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe621265", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_7));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout.CreateTagHelper<ScriptTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout.__tagHelperAttribute_7.Value;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_7);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter5, ref this);
						return;
					}
					IL_05CA:
					awaiter5.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0646;
					}
					awaiter6 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter6, ref this);
						return;
					}
					IL_063F:
					awaiter6.GetResult();
					IL_0646:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe622964", new Func<Task>(Views_Shared__Layout.<>c.<>9.<ExecuteAsync>b__21_8));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout.CreateTagHelper<ScriptTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout.__tagHelperAttribute_8.Value;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout.__tagHelperAttribute_8);
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter7 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter7, ref this);
						return;
					}
					IL_0789:
					awaiter7.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0805;
					}
					awaiter8 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter8, ref this);
						return;
					}
					IL_07FE:
					awaiter8.GetResult();
					IL_0805:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe624663", new Func<Task>(views_Shared__Layout.<ExecuteAsync>b__21_9));
					views_Shared__Layout.__HAS_Server_TagHelpers_NonceTagHelper = views_Shared__Layout.CreateTagHelper<NonceTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__HAS_Server_TagHelpers_NonceTagHelper);
					views_Shared__Layout.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
					views_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", views_Shared__Layout.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter9 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter9, ref this);
						return;
					}
					IL_0906:
					awaiter9.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0983;
					}
					awaiter10 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<<ExecuteAsync>b__21_1>d>(ref awaiter10, ref this);
						return;
					}
					IL_097C:
					awaiter10.GetResult();
					IL_0983:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n    ");
					views_Shared__Layout.Write(views_Shared__Layout.RenderSection("Scripts", false));
					views_Shared__Layout.WriteLiteral("\r\n");
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

			// Token: 0x06000ABA RID: 2746 RVA: 0x0004E718 File Offset: 0x0004C918
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000892 RID: 2194
			public int <>1__state;

			// Token: 0x04000893 RID: 2195
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000894 RID: 2196
			public Views_Shared__Layout <>4__this;

			// Token: 0x04000895 RID: 2197
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000177 RID: 375
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__21_5>d : IAsyncStateMachine
		{
			// Token: 0x06000ABB RID: 2747 RVA: 0x0004E728 File Offset: 0x0004C928
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout views_Shared__Layout = this.<>4__this;
				try
				{
					views_Shared__Layout.WriteLiteral("\r\n        <h1 class=\"text-white\" style=\"text-shadow: 0 0 2px black;\">\r\n            Development\r\n        </h1>\r\n    ");
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

			// Token: 0x06000ABC RID: 2748 RVA: 0x0004E78C File Offset: 0x0004C98C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000896 RID: 2198
			public int <>1__state;

			// Token: 0x04000897 RID: 2199
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000898 RID: 2200
			public Views_Shared__Layout <>4__this;
		}

		// Token: 0x02000178 RID: 376
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__21_9>d : IAsyncStateMachine
		{
			// Token: 0x06000ABD RID: 2749 RVA: 0x0004E79C File Offset: 0x0004C99C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout views_Shared__Layout = this.<>4__this;
				try
				{
					views_Shared__Layout.WriteLiteral("\r\n        $(function () {\r\n            $(\"#privacyPolicyContent\").load(\"/_customs/has.uas/privacy-policy.html\");\r\n        });\r\n    ");
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

			// Token: 0x06000ABE RID: 2750 RVA: 0x0004E800 File Offset: 0x0004CA00
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000899 RID: 2201
			public int <>1__state;

			// Token: 0x0400089A RID: 2202
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400089B RID: 2203
			public Views_Shared__Layout <>4__this;
		}

		// Token: 0x02000179 RID: 377
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AC1 RID: 2753 RVA: 0x0004E824 File Offset: 0x0004CA24
			internal Task <ExecuteAsync>b__21_2()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_2>d <<ExecuteAsync>b__21_2>d;
				<<ExecuteAsync>b__21_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_2>d.<>1__state = -1;
				<<ExecuteAsync>b__21_2>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_2>d>(ref <<ExecuteAsync>b__21_2>d);
				return <<ExecuteAsync>b__21_2>d.<>t__builder.Task;
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x0004E860 File Offset: 0x0004CA60
			internal Task <ExecuteAsync>b__21_3()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_3>d <<ExecuteAsync>b__21_3>d;
				<<ExecuteAsync>b__21_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_3>d.<>1__state = -1;
				<<ExecuteAsync>b__21_3>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_3>d>(ref <<ExecuteAsync>b__21_3>d);
				return <<ExecuteAsync>b__21_3>d.<>t__builder.Task;
			}

			// Token: 0x06000AC3 RID: 2755 RVA: 0x0004E89C File Offset: 0x0004CA9C
			internal Task <ExecuteAsync>b__21_4()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_4>d <<ExecuteAsync>b__21_4>d;
				<<ExecuteAsync>b__21_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_4>d.<>1__state = -1;
				<<ExecuteAsync>b__21_4>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_4>d>(ref <<ExecuteAsync>b__21_4>d);
				return <<ExecuteAsync>b__21_4>d.<>t__builder.Task;
			}

			// Token: 0x06000AC4 RID: 2756 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
			internal Task <ExecuteAsync>b__21_6()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_6>d <<ExecuteAsync>b__21_6>d;
				<<ExecuteAsync>b__21_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_6>d.<>1__state = -1;
				<<ExecuteAsync>b__21_6>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_6>d>(ref <<ExecuteAsync>b__21_6>d);
				return <<ExecuteAsync>b__21_6>d.<>t__builder.Task;
			}

			// Token: 0x06000AC5 RID: 2757 RVA: 0x0004E914 File Offset: 0x0004CB14
			internal Task <ExecuteAsync>b__21_7()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_7>d <<ExecuteAsync>b__21_7>d;
				<<ExecuteAsync>b__21_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_7>d.<>1__state = -1;
				<<ExecuteAsync>b__21_7>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_7>d>(ref <<ExecuteAsync>b__21_7>d);
				return <<ExecuteAsync>b__21_7>d.<>t__builder.Task;
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x0004E950 File Offset: 0x0004CB50
			internal Task <ExecuteAsync>b__21_8()
			{
				Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_8>d <<ExecuteAsync>b__21_8>d;
				<<ExecuteAsync>b__21_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__21_8>d.<>1__state = -1;
				<<ExecuteAsync>b__21_8>d.<>t__builder.Start<Views_Shared__Layout.<>c.<<ExecuteAsync>b__21_8>d>(ref <<ExecuteAsync>b__21_8>d);
				return <<ExecuteAsync>b__21_8>d.<>t__builder.Task;
			}

			// Token: 0x0400089C RID: 2204
			public static readonly Views_Shared__Layout.<>c <>9 = new Views_Shared__Layout.<>c();

			// Token: 0x0400089D RID: 2205
			public static Func<Task> <>9__21_2;

			// Token: 0x0400089E RID: 2206
			public static Func<Task> <>9__21_3;

			// Token: 0x0400089F RID: 2207
			public static Func<Task> <>9__21_4;

			// Token: 0x040008A0 RID: 2208
			public static Func<Task> <>9__21_6;

			// Token: 0x040008A1 RID: 2209
			public static Func<Task> <>9__21_7;

			// Token: 0x040008A2 RID: 2210
			public static Func<Task> <>9__21_8;

			// Token: 0x02000349 RID: 841
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_2>d : IAsyncStateMachine
			{
				// Token: 0x06000FA0 RID: 4000 RVA: 0x000766A8 File Offset: 0x000748A8
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

				// Token: 0x06000FA1 RID: 4001 RVA: 0x000766F8 File Offset: 0x000748F8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F35 RID: 3893
				public int <>1__state;

				// Token: 0x04000F36 RID: 3894
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200034A RID: 842
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_3>d : IAsyncStateMachine
			{
				// Token: 0x06000FA2 RID: 4002 RVA: 0x00076708 File Offset: 0x00074908
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

				// Token: 0x06000FA3 RID: 4003 RVA: 0x00076758 File Offset: 0x00074958
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F37 RID: 3895
				public int <>1__state;

				// Token: 0x04000F38 RID: 3896
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200034B RID: 843
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_4>d : IAsyncStateMachine
			{
				// Token: 0x06000FA4 RID: 4004 RVA: 0x00076768 File Offset: 0x00074968
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

				// Token: 0x06000FA5 RID: 4005 RVA: 0x000767B8 File Offset: 0x000749B8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F39 RID: 3897
				public int <>1__state;

				// Token: 0x04000F3A RID: 3898
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200034C RID: 844
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_6>d : IAsyncStateMachine
			{
				// Token: 0x06000FA6 RID: 4006 RVA: 0x000767C8 File Offset: 0x000749C8
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

				// Token: 0x06000FA7 RID: 4007 RVA: 0x00076818 File Offset: 0x00074A18
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F3B RID: 3899
				public int <>1__state;

				// Token: 0x04000F3C RID: 3900
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200034D RID: 845
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_7>d : IAsyncStateMachine
			{
				// Token: 0x06000FA8 RID: 4008 RVA: 0x00076828 File Offset: 0x00074A28
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

				// Token: 0x06000FA9 RID: 4009 RVA: 0x00076878 File Offset: 0x00074A78
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F3D RID: 3901
				public int <>1__state;

				// Token: 0x04000F3E RID: 3902
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200034E RID: 846
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__21_8>d : IAsyncStateMachine
			{
				// Token: 0x06000FAA RID: 4010 RVA: 0x00076888 File Offset: 0x00074A88
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

				// Token: 0x06000FAB RID: 4011 RVA: 0x000768D8 File Offset: 0x00074AD8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F3F RID: 3903
				public int <>1__state;

				// Token: 0x04000F40 RID: 3904
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__21 : IAsyncStateMachine
		{
			// Token: 0x06000AC7 RID: 2759 RVA: 0x0004E98C File Offset: 0x0004CB8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout views_Shared__Layout = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0145;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0220;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0292;
					default:
						views_Shared__Layout.WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
						views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("head", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe67365", new Func<Task>(views_Shared__Layout.<ExecuteAsync>b__21_0));
						views_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = views_Shared__Layout.CreateTagHelper<HeadTagHelper>();
						views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
						awaiter = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<ExecuteAsync>d__21>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_014C;
					}
					awaiter2 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<ExecuteAsync>d__21>(ref awaiter2, ref this);
						return;
					}
					IL_0145:
					awaiter2.GetResult();
					IL_014C:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n");
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.Begin("body", TagMode.StartTagAndEndTag, "1dce776561a55fda81b9b63b132b1641fda94261e65fbcd7d69d90d862d0dbe615163", new Func<Task>(views_Shared__Layout.<ExecuteAsync>b__21_1));
					views_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = views_Shared__Layout.CreateTagHelper<BodyTagHelper>();
					views_Shared__Layout.__tagHelperExecutionContext.Add(views_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
					awaiter3 = views_Shared__Layout.__tagHelperRunner.RunAsync(views_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<ExecuteAsync>d__21>(ref awaiter3, ref this);
						return;
					}
					IL_0220:
					awaiter3.GetResult();
					if (views_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0299;
					}
					awaiter4 = views_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout.<ExecuteAsync>d__21>(ref awaiter4, ref this);
						return;
					}
					IL_0292:
					awaiter4.GetResult();
					IL_0299:
					views_Shared__Layout.Write(views_Shared__Layout.__tagHelperExecutionContext.Output);
					views_Shared__Layout.__tagHelperExecutionContext = views_Shared__Layout.__tagHelperScopeManager.End();
					views_Shared__Layout.WriteLiteral("\r\n</html>\r\n");
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

			// Token: 0x06000AC8 RID: 2760 RVA: 0x0004ECAC File Offset: 0x0004CEAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008A5 RID: 2213
			public int <>1__state;

			// Token: 0x040008A6 RID: 2214
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008A7 RID: 2215
			public Views_Shared__Layout <>4__this;

			// Token: 0x040008A8 RID: 2216
			private TaskAwaiter <>u__1;
		}
	}
}
