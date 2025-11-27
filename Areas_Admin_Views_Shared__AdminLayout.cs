using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.Commons.Time;
using HAS.Server.SiteModule.Razor;
using HAS.Server.TagHelpers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
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
	// Token: 0x0200003D RID: 61
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c4", "/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Shared__AdminLayout : BaseRazorPage<object>
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000B70D File Offset: 0x0000990D
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

		// Token: 0x0600028C RID: 652 RVA: 0x0000B740 File Offset: 0x00009940
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000B783 File Offset: 0x00009983
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000B78B File Offset: 0x0000998B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000B794 File Offset: 0x00009994
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000B79C File Offset: 0x0000999C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000B7A5 File Offset: 0x000099A5
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000B7AD File Offset: 0x000099AD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000B7B6 File Offset: 0x000099B6
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000B7BE File Offset: 0x000099BE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000B7C7 File Offset: 0x000099C7
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000B7CF File Offset: 0x000099CF
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000B930 File Offset: 0x00009B30
		[CompilerGenerated]
		private Task <ExecuteAsync>b__25_0()
		{
			Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d <<ExecuteAsync>b__25_0>d;
			<<ExecuteAsync>b__25_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__25_0>d.<>4__this = this;
			<<ExecuteAsync>b__25_0>d.<>1__state = -1;
			<<ExecuteAsync>b__25_0>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref <<ExecuteAsync>b__25_0>d);
			return <<ExecuteAsync>b__25_0>d.<>t__builder.Task;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000B974 File Offset: 0x00009B74
		[CompilerGenerated]
		private Task <ExecuteAsync>b__25_1()
		{
			Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d <<ExecuteAsync>b__25_1>d;
			<<ExecuteAsync>b__25_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__25_1>d.<>4__this = this;
			<<ExecuteAsync>b__25_1>d.<>1__state = -1;
			<<ExecuteAsync>b__25_1>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref <<ExecuteAsync>b__25_1>d);
			return <<ExecuteAsync>b__25_1>d.<>t__builder.Task;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__25_10()
		{
			Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_10>d <<ExecuteAsync>b__25_10>d;
			<<ExecuteAsync>b__25_10>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__25_10>d.<>4__this = this;
			<<ExecuteAsync>b__25_10>d.<>1__state = -1;
			<<ExecuteAsync>b__25_10>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_10>d>(ref <<ExecuteAsync>b__25_10>d);
			return <<ExecuteAsync>b__25_10>d.<>t__builder.Task;
		}

		// Token: 0x04000248 RID: 584
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", new HtmlString("stylesheet"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000249 RID: 585
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", new HtmlString("text/css"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024A RID: 586
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("href", "/uas/lib/bootstrap/dist/css/bootstrap.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024B RID: 587
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("href", "/uas/lib/font-awesome/css/all.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024C RID: 588
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("href", "/_customs/has.uas/css/site.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024D RID: 589
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("style", new HtmlString("margin-bottom: -15px;"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024E RID: 590
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("alt", new HtmlString("Hopex"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400024F RID: 591
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("width", new HtmlString("120"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000250 RID: 592
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("alt", new HtmlString("Logout"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000251 RID: 593
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("width", new HtmlString("32"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000252 RID: 594
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("src", "/uas/lib/jquery/jquery.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000253 RID: 595
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("src", "/uas/lib/font-awesome/js/all.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000254 RID: 596
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("src", "/uas/lib/bootstrap/dist/js/bootstrap.bundle.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000255 RID: 597
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000256 RID: 598
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000257 RID: 599
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000258 RID: 600
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000259 RID: 601
		private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

		// Token: 0x0400025A RID: 602
		private LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;

		// Token: 0x0400025B RID: 603
		private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;

		// Token: 0x0400025C RID: 604
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x0400025D RID: 605
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x0400025E RID: 606
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x0200013D RID: 317
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__25_0>d : IAsyncStateMachine
		{
			// Token: 0x06000A15 RID: 2581 RVA: 0x00040B20 File Offset: 0x0003ED20
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared__AdminLayout areas_Admin_Views_Shared__AdminLayout = this.<>4__this;
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
						areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <title>UAS Administration</title>\r\n    ");
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c49627", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_2));
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<LinkTagHelper>();
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_0);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_1);
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_2.Value;
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_2);
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01E3;
					}
					awaiter2 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_01DC:
					awaiter2.GetResult();
					IL_01E3:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("link", TagMode.StartTagOnly, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c411497", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_3));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<LinkTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_0);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_1);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_3.Value;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_3);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0346:
					awaiter3.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_03C2;
					}
					awaiter4 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_03BB:
					awaiter4.GetResult();
					IL_03C2:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c413369", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_4));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<LinkTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_0);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_1);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_4.Value;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_4);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_0525:
					awaiter5.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_05A1;
					}
					awaiter6 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_059A:
					awaiter6.GetResult();
					IL_05A1:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.RenderSection("styleSheets", false));
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n");
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

			// Token: 0x06000A16 RID: 2582 RVA: 0x00041164 File Offset: 0x0003F364
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007B2 RID: 1970
			public int <>1__state;

			// Token: 0x040007B3 RID: 1971
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007B4 RID: 1972
			public Areas_Admin_Views_Shared__AdminLayout <>4__this;

			// Token: 0x040007B5 RID: 1973
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200013E RID: 318
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__25_10>d : IAsyncStateMachine
		{
			// Token: 0x06000A17 RID: 2583 RVA: 0x00041174 File Offset: 0x0003F374
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared__AdminLayout areas_Admin_Views_Shared__AdminLayout = this.<>4__this;
				try
				{
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n        $(document).ready(function () {\r\n            $(\"#show_hide_password button\").on('click', function (event) {\r\n                event.preventDefault();\r\n                if ($('#show_hide_password input').attr(\"type\") == \"text\") {\r\n                    $('#show_hide_password input').attr('type', 'password');\r\n                    $('#show_hide_password_icon').attr('data-icon', 'eye-slash');\r\n                } else if ($('#show_hide_password input').attr(\"type\") == \"password\") {\r\n                    $('#show_hide_password input').attr('type', 'text');\r\n                    $('#show_hide_password_icon').attr('data-icon', 'eye');\r\n                }\r\n            });\r\n        });\r\n    ");
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

			// Token: 0x06000A18 RID: 2584 RVA: 0x000411D8 File Offset: 0x0003F3D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007B6 RID: 1974
			public int <>1__state;

			// Token: 0x040007B7 RID: 1975
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007B8 RID: 1976
			public Areas_Admin_Views_Shared__AdminLayout <>4__this;
		}

		// Token: 0x0200013F RID: 319
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__25_1>d : IAsyncStateMachine
		{
			// Token: 0x06000A19 RID: 2585 RVA: 0x000411E8 File Offset: 0x0003F3E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared__AdminLayout areas_Admin_Views_Shared__AdminLayout = this.<>4__this;
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
					TaskAwaiter awaiter11;
					TaskAwaiter awaiter12;
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
						goto IL_022A;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0465;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04DA;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0706;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_077B;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_08C5;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_093A;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A84;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0AFA;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C03;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C79;
					default:
						areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    <div class=\"d-flex flex-column\" id=\"v-wrapper\">\r\n        <!-- top horizontal navbar -->\r\n        <nav class=\"navbar navbar-expand-sm bg-dark navbar-dark pt-1 pb-1\">\r\n            <ul class=\"navbar-nav ms-5 me-5\">\r\n                <li class=\"nav-item\">\r\n                    <a class=\"#navbar-brand\" href=\"#\">\r\n                        ");
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("img", TagMode.StartTagOnly, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c416879", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_5));
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<ImageTagHelper>();
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_5);
						areas_Admin_Views_Shared__AdminLayout.BeginWriteTagHelperAttribute();
						areas_Admin_Views_Shared__AdminLayout.WriteLiteral(areas_Admin_Views_Shared__AdminLayout.Url.Content("/_customs/has.uas/images/logo-H-white.png"));
						areas_Admin_Views_Shared__AdminLayout.__tagHelperStringValueBuffer = areas_Admin_Views_Shared__AdminLayout.EndWriteTagHelperAttribute();
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = areas_Admin_Views_Shared__AdminLayout.__tagHelperStringValueBuffer;
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("src", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_6);
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_7);
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0231;
					}
					awaiter2 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter2, ref this);
						return;
					}
					IL_022A:
					awaiter2.GetResult();
					IL_0231:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n            <h4 class=\"navbar-text text-white ms-5 me-auto mb-0\">UAS Administration</h4>\r\n            <span class=\"navbar-text text-white me-1 mb-0\" style=\"font-size: 0.7em\">Last connection : ");
					RazorPageBase razorPageBase = areas_Admin_Views_Shared__AdminLayout;
					if (Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__1 == null)
					{
						Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__1 = CallSite<Func<CallSite, object, DateTime?>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(DateTime?), typeof(Areas_Admin_Views_Shared__AdminLayout)));
					}
					Func<CallSite, object, DateTime?> target = Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__1.Target;
					CallSite <>p__ = Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__1;
					if (Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__0 == null)
					{
						Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "LastConnectionDate", typeof(Areas_Admin_Views_Shared__AdminLayout), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
					}
					razorPageBase.Write(TimeElapsedHelper.Transform(target(<>p__, Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__0.Target(Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__0, areas_Admin_Views_Shared__AdminLayout.ViewBag)), DateTime.UtcNow));
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("</span>\r\n            <ul class=\"navbar-nav\">\r\n                <li class=\"nav-item\">\r\n                    <a href=\"/console\"\r\n                       class=\"nav-link text-white hover-green\" data-bs-toggle=\"tooltip\" title=\"Return to console\">\r\n                        ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("img", TagMode.StartTagOnly, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c420242", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_6));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<ImageTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
					areas_Admin_Views_Shared__AdminLayout.BeginWriteTagHelperAttribute();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral(areas_Admin_Views_Shared__AdminLayout.Url.Content("/_customs/has.uas/images/logout.png"));
					areas_Admin_Views_Shared__AdminLayout.__tagHelperStringValueBuffer = areas_Admin_Views_Shared__AdminLayout.EndWriteTagHelperAttribute();
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = areas_Admin_Views_Shared__AdminLayout.__tagHelperStringValueBuffer;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("src", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_8);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_9);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter3, ref this);
						return;
					}
					IL_0465:
					awaiter3.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04E1;
					}
					awaiter4 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter4, ref this);
						return;
					}
					IL_04DA:
					awaiter4.GetResult();
					IL_04E1:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n        <!-- end of top horizontal navbar -->\r\n        <div class=\"d-flex flex-fill\" id=\"wrapper\">\r\n            <!-- sidebar -->\r\n            <div class=\"bg-light border-end\" id=\"sidebar-wrapper\">\r\n                <div class=\"h-100 list-group list-group-flush\">\r\n                    <ul class=\"h-100 navbar-nav flex-column mt-4\">\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/uas/admin/accesstoken\" class=\"nav-link p-3 mb-2\">\r\n                                <i class=\"fas fa-server text-dark fa-lg me-3\"></i>User accounts\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a href=\"/uas/admin/apikey\" class=\"nav-link p-3 mb-2\">\r\n                                <i class=\"fas fa-server text-dark fa-lg me-3\"></i>Api keys\r\n                            </a>\r\n                        </li>\r\n                     ");
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("   <li class=\"nav-item\">\r\n                            <a href=\"/uas/admin/client\" class=\"nav-link p-3 mb-2\">\r\n                                <i class=\"fas fa-server text-dark fa-lg me-3\"></i>Authorized clients\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"nav-item collapsible-panel mb-auto\">\r\n                            <a href=\"#\" class=\"nav-link p-3 mb-2 sidebar-link toggle\"\r\n                               data-bs-toggle=\"collapse\"\r\n                               data-bs-target=\"#menu1\" aria-expanded=\"false\">\r\n                                <i class=\"fas fa-wrench text-dark fa-lg me-3\"></i>Identity providers\r\n                                <span class=\"ms-auto\"></span>\r\n                            </a>\r\n                            <ul class=\"navbar-nav collapse\" id=\"menu1\">\r\n                                <li class=\"ms-3 mb-2 ps-2 sidebar-link\">\r\n                                    <a class=\"text-dark\" href=\"/uas/admin/hopex\">HOPEX</a>\r\n            ");
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("                    </li>\r\n                                <li class=\"ms-3 mb-2 ps-2 sidebar-link\">\r\n                                    <a class=\"text-dark\" href=\"/uas/admin/windows\">Windows</a>\r\n                                </li>\r\n                                <li class=\"ms-3 mb-2 ps-2 sidebar-link\">\r\n                                    <a class=\"text-dark\" href=\"/uas/admin/saml2\">SAML2</a>\r\n                                </li>\r\n                                <li class=\"ms-3 mb-2 ps-2 sidebar-link\">\r\n                                    <a class=\"text-dark\" href=\"/uas/admin/openid\">OpenID</a>\r\n                                </li>\r\n                            </ul>\r\n                        </li>\r\n                        <li class=\"nav-item mb-3 text-info d-flex justify-content-center\">\r\n                            <h5>v");
					if (Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__3 == null)
					{
						Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__3 = CallSite<Action<CallSite, Areas_Admin_Views_Shared__AdminLayout, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(Areas_Admin_Views_Shared__AdminLayout), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Areas_Admin_Views_Shared__AdminLayout, object> target2 = Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__3.Target;
					CallSite <>p__2 = Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__3;
					Areas_Admin_Views_Shared__AdminLayout areas_Admin_Views_Shared__AdminLayout2 = areas_Admin_Views_Shared__AdminLayout;
					if (Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__2 == null)
					{
						Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Version", typeof(Areas_Admin_Views_Shared__AdminLayout), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
					}
					target2(<>p__2, areas_Admin_Views_Shared__AdminLayout2, Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__2.Target(Areas_Admin_Views_Shared__AdminLayout.<>o__25.<>p__2, areas_Admin_Views_Shared__AdminLayout.ViewBag));
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("</h5>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <!-- end of sidebar -->\r\n            <!-- page content -->\r\n            <div id=\"page-content-wrapper\">\r\n                <div class=\"container-fluid overflow-auto h-100\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col pt-5\">\r\n                            ");
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.RenderBody());
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- end of page content -->\r\n        </div>\r\n    </div>\r\n    <!-- scripts -->\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c426836", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_7));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_10.Value;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_10);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter5, ref this);
						return;
					}
					IL_0706:
					awaiter5.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0782;
					}
					awaiter6 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter6, ref this);
						return;
					}
					IL_077B:
					awaiter6.GetResult();
					IL_0782:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c428555", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_8));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_11.Value;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_11);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter7 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter7, ref this);
						return;
					}
					IL_08C5:
					awaiter7.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0941;
					}
					awaiter8 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter8, ref this);
						return;
					}
					IL_093A:
					awaiter8.GetResult();
					IL_0941:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c430274", new Func<Task>(Areas_Admin_Views_Shared__AdminLayout.<>c.<>9.<ExecuteAsync>b__25_9));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_12.Value;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Shared__AdminLayout.__tagHelperAttribute_12);
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter9 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A84:
					awaiter9.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0B01;
					}
					awaiter10 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter10, ref this);
						return;
					}
					IL_0AFA:
					awaiter10.GetResult();
					IL_0B01:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c431993", new Func<Task>(areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>b__25_10));
					areas_Admin_Views_Shared__AdminLayout.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<NonceTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__HAS_Server_TagHelpers_NonceTagHelper);
					areas_Admin_Views_Shared__AdminLayout.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_Shared__AdminLayout.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter11 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter11, ref this);
						return;
					}
					IL_0C03:
					awaiter11.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0C80;
					}
					awaiter12 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<<ExecuteAsync>b__25_1>d>(ref awaiter12, ref this);
						return;
					}
					IL_0C79:
					awaiter12.GetResult();
					IL_0C80:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n    ");
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.RenderSection("Scripts", false));
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n");
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

			// Token: 0x06000A1A RID: 2586 RVA: 0x00041F0C File Offset: 0x0004010C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007B9 RID: 1977
			public int <>1__state;

			// Token: 0x040007BA RID: 1978
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007BB RID: 1979
			public Areas_Admin_Views_Shared__AdminLayout <>4__this;

			// Token: 0x040007BC RID: 1980
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000140 RID: 320
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A1D RID: 2589 RVA: 0x00041F30 File Offset: 0x00040130
			internal Task <ExecuteAsync>b__25_2()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_2>d <<ExecuteAsync>b__25_2>d;
				<<ExecuteAsync>b__25_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_2>d.<>1__state = -1;
				<<ExecuteAsync>b__25_2>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_2>d>(ref <<ExecuteAsync>b__25_2>d);
				return <<ExecuteAsync>b__25_2>d.<>t__builder.Task;
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x00041F6C File Offset: 0x0004016C
			internal Task <ExecuteAsync>b__25_3()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_3>d <<ExecuteAsync>b__25_3>d;
				<<ExecuteAsync>b__25_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_3>d.<>1__state = -1;
				<<ExecuteAsync>b__25_3>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_3>d>(ref <<ExecuteAsync>b__25_3>d);
				return <<ExecuteAsync>b__25_3>d.<>t__builder.Task;
			}

			// Token: 0x06000A1F RID: 2591 RVA: 0x00041FA8 File Offset: 0x000401A8
			internal Task <ExecuteAsync>b__25_4()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_4>d <<ExecuteAsync>b__25_4>d;
				<<ExecuteAsync>b__25_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_4>d.<>1__state = -1;
				<<ExecuteAsync>b__25_4>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_4>d>(ref <<ExecuteAsync>b__25_4>d);
				return <<ExecuteAsync>b__25_4>d.<>t__builder.Task;
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x00041FE4 File Offset: 0x000401E4
			internal Task <ExecuteAsync>b__25_5()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_5>d <<ExecuteAsync>b__25_5>d;
				<<ExecuteAsync>b__25_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_5>d.<>1__state = -1;
				<<ExecuteAsync>b__25_5>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_5>d>(ref <<ExecuteAsync>b__25_5>d);
				return <<ExecuteAsync>b__25_5>d.<>t__builder.Task;
			}

			// Token: 0x06000A21 RID: 2593 RVA: 0x00042020 File Offset: 0x00040220
			internal Task <ExecuteAsync>b__25_6()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_6>d <<ExecuteAsync>b__25_6>d;
				<<ExecuteAsync>b__25_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_6>d.<>1__state = -1;
				<<ExecuteAsync>b__25_6>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_6>d>(ref <<ExecuteAsync>b__25_6>d);
				return <<ExecuteAsync>b__25_6>d.<>t__builder.Task;
			}

			// Token: 0x06000A22 RID: 2594 RVA: 0x0004205C File Offset: 0x0004025C
			internal Task <ExecuteAsync>b__25_7()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_7>d <<ExecuteAsync>b__25_7>d;
				<<ExecuteAsync>b__25_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_7>d.<>1__state = -1;
				<<ExecuteAsync>b__25_7>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_7>d>(ref <<ExecuteAsync>b__25_7>d);
				return <<ExecuteAsync>b__25_7>d.<>t__builder.Task;
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x00042098 File Offset: 0x00040298
			internal Task <ExecuteAsync>b__25_8()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_8>d <<ExecuteAsync>b__25_8>d;
				<<ExecuteAsync>b__25_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_8>d.<>1__state = -1;
				<<ExecuteAsync>b__25_8>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_8>d>(ref <<ExecuteAsync>b__25_8>d);
				return <<ExecuteAsync>b__25_8>d.<>t__builder.Task;
			}

			// Token: 0x06000A24 RID: 2596 RVA: 0x000420D4 File Offset: 0x000402D4
			internal Task <ExecuteAsync>b__25_9()
			{
				Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_9>d <<ExecuteAsync>b__25_9>d;
				<<ExecuteAsync>b__25_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__25_9>d.<>1__state = -1;
				<<ExecuteAsync>b__25_9>d.<>t__builder.Start<Areas_Admin_Views_Shared__AdminLayout.<>c.<<ExecuteAsync>b__25_9>d>(ref <<ExecuteAsync>b__25_9>d);
				return <<ExecuteAsync>b__25_9>d.<>t__builder.Task;
			}

			// Token: 0x040007BD RID: 1981
			public static readonly Areas_Admin_Views_Shared__AdminLayout.<>c <>9 = new Areas_Admin_Views_Shared__AdminLayout.<>c();

			// Token: 0x040007BE RID: 1982
			public static Func<Task> <>9__25_2;

			// Token: 0x040007BF RID: 1983
			public static Func<Task> <>9__25_3;

			// Token: 0x040007C0 RID: 1984
			public static Func<Task> <>9__25_4;

			// Token: 0x040007C1 RID: 1985
			public static Func<Task> <>9__25_5;

			// Token: 0x040007C2 RID: 1986
			public static Func<Task> <>9__25_6;

			// Token: 0x040007C3 RID: 1987
			public static Func<Task> <>9__25_7;

			// Token: 0x040007C4 RID: 1988
			public static Func<Task> <>9__25_8;

			// Token: 0x040007C5 RID: 1989
			public static Func<Task> <>9__25_9;

			// Token: 0x02000310 RID: 784
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_2>d : IAsyncStateMachine
			{
				// Token: 0x06000F2E RID: 3886 RVA: 0x0007435C File Offset: 0x0007255C
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

				// Token: 0x06000F2F RID: 3887 RVA: 0x000743AC File Offset: 0x000725AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EC1 RID: 3777
				public int <>1__state;

				// Token: 0x04000EC2 RID: 3778
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000311 RID: 785
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_3>d : IAsyncStateMachine
			{
				// Token: 0x06000F30 RID: 3888 RVA: 0x000743BC File Offset: 0x000725BC
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

				// Token: 0x06000F31 RID: 3889 RVA: 0x0007440C File Offset: 0x0007260C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EC3 RID: 3779
				public int <>1__state;

				// Token: 0x04000EC4 RID: 3780
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000312 RID: 786
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_4>d : IAsyncStateMachine
			{
				// Token: 0x06000F32 RID: 3890 RVA: 0x0007441C File Offset: 0x0007261C
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

				// Token: 0x06000F33 RID: 3891 RVA: 0x0007446C File Offset: 0x0007266C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EC5 RID: 3781
				public int <>1__state;

				// Token: 0x04000EC6 RID: 3782
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000313 RID: 787
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_5>d : IAsyncStateMachine
			{
				// Token: 0x06000F34 RID: 3892 RVA: 0x0007447C File Offset: 0x0007267C
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

				// Token: 0x06000F35 RID: 3893 RVA: 0x000744CC File Offset: 0x000726CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EC7 RID: 3783
				public int <>1__state;

				// Token: 0x04000EC8 RID: 3784
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000314 RID: 788
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_6>d : IAsyncStateMachine
			{
				// Token: 0x06000F36 RID: 3894 RVA: 0x000744DC File Offset: 0x000726DC
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

				// Token: 0x06000F37 RID: 3895 RVA: 0x0007452C File Offset: 0x0007272C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EC9 RID: 3785
				public int <>1__state;

				// Token: 0x04000ECA RID: 3786
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000315 RID: 789
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_7>d : IAsyncStateMachine
			{
				// Token: 0x06000F38 RID: 3896 RVA: 0x0007453C File Offset: 0x0007273C
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

				// Token: 0x06000F39 RID: 3897 RVA: 0x0007458C File Offset: 0x0007278C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ECB RID: 3787
				public int <>1__state;

				// Token: 0x04000ECC RID: 3788
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000316 RID: 790
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_8>d : IAsyncStateMachine
			{
				// Token: 0x06000F3A RID: 3898 RVA: 0x0007459C File Offset: 0x0007279C
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

				// Token: 0x06000F3B RID: 3899 RVA: 0x000745EC File Offset: 0x000727EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ECD RID: 3789
				public int <>1__state;

				// Token: 0x04000ECE RID: 3790
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000317 RID: 791
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__25_9>d : IAsyncStateMachine
			{
				// Token: 0x06000F3C RID: 3900 RVA: 0x000745FC File Offset: 0x000727FC
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

				// Token: 0x06000F3D RID: 3901 RVA: 0x0007464C File Offset: 0x0007284C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ECF RID: 3791
				public int <>1__state;

				// Token: 0x04000ED0 RID: 3792
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000142 RID: 322
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__25 : IAsyncStateMachine
		{
			// Token: 0x06000A25 RID: 2597 RVA: 0x00042110 File Offset: 0x00040310
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared__AdminLayout areas_Admin_Views_Shared__AdminLayout = this.<>4__this;
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
						areas_Admin_Views_Shared__AdminLayout.WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("head", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c49170", new Func<Task>(areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>b__25_0));
						areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<HeadTagHelper>();
						areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
						awaiter = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_014C;
					}
					awaiter2 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25>(ref awaiter2, ref this);
						return;
					}
					IL_0145:
					awaiter2.GetResult();
					IL_014C:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n");
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.Begin("body", TagMode.StartTagAndEndTag, "4a707c0e8411c6baecdd24a4cb3d4777adffdc2207fe7ba39385b40863cb66c416247", new Func<Task>(areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>b__25_1));
					areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = areas_Admin_Views_Shared__AdminLayout.CreateTagHelper<BodyTagHelper>();
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Add(areas_Admin_Views_Shared__AdminLayout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
					awaiter3 = areas_Admin_Views_Shared__AdminLayout.__tagHelperRunner.RunAsync(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25>(ref awaiter3, ref this);
						return;
					}
					IL_0220:
					awaiter3.GetResult();
					if (areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0299;
					}
					awaiter4 = areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Shared__AdminLayout.<ExecuteAsync>d__25>(ref awaiter4, ref this);
						return;
					}
					IL_0292:
					awaiter4.GetResult();
					IL_0299:
					areas_Admin_Views_Shared__AdminLayout.Write(areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Shared__AdminLayout.__tagHelperExecutionContext = areas_Admin_Views_Shared__AdminLayout.__tagHelperScopeManager.End();
					areas_Admin_Views_Shared__AdminLayout.WriteLiteral("\r\n</html>");
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

			// Token: 0x06000A26 RID: 2598 RVA: 0x00042430 File Offset: 0x00040630
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007CA RID: 1994
			public int <>1__state;

			// Token: 0x040007CB RID: 1995
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007CC RID: 1996
			public Areas_Admin_Views_Shared__AdminLayout <>4__this;

			// Token: 0x040007CD RID: 1997
			private TaskAwaiter <>u__1;
		}
	}
}
