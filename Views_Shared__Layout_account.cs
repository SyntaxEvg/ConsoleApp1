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

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200004C RID: 76
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e", "/Views/Shared/_Layout_account.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Shared/_Layout_account.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Shared__Layout_account : BaseRazorPage<object>
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0000D6A3 File Offset: 0x0000B8A3
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

		// Token: 0x06000378 RID: 888 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public override Task ExecuteAsync()
		{
			Views_Shared__Layout_account.<ExecuteAsync>d__20 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Shared__Layout_account.<ExecuteAsync>d__20>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000D71B File Offset: 0x0000B91B
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000D723 File Offset: 0x0000B923
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000D72C File Offset: 0x0000B92C
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000D734 File Offset: 0x0000B934
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000D73D File Offset: 0x0000B93D
		// (set) Token: 0x0600037E RID: 894 RVA: 0x0000D745 File Offset: 0x0000B945
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000D74E File Offset: 0x0000B94E
		// (set) Token: 0x06000380 RID: 896 RVA: 0x0000D756 File Offset: 0x0000B956
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000D75F File Offset: 0x0000B95F
		// (set) Token: 0x06000382 RID: 898 RVA: 0x0000D767 File Offset: 0x0000B967
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000D860 File Offset: 0x0000BA60
		[CompilerGenerated]
		private Task <ExecuteAsync>b__20_0()
		{
			Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d <<ExecuteAsync>b__20_0>d;
			<<ExecuteAsync>b__20_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__20_0>d.<>4__this = this;
			<<ExecuteAsync>b__20_0>d.<>1__state = -1;
			<<ExecuteAsync>b__20_0>d.<>t__builder.Start<Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref <<ExecuteAsync>b__20_0>d);
			return <<ExecuteAsync>b__20_0>d.<>t__builder.Task;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		[CompilerGenerated]
		private Task <ExecuteAsync>b__20_5()
		{
			Views_Shared__Layout_account.<<ExecuteAsync>b__20_5>d <<ExecuteAsync>b__20_5>d;
			<<ExecuteAsync>b__20_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__20_5>d.<>4__this = this;
			<<ExecuteAsync>b__20_5>d.<>1__state = -1;
			<<ExecuteAsync>b__20_5>d.<>t__builder.Start<Views_Shared__Layout_account.<<ExecuteAsync>b__20_5>d>(ref <<ExecuteAsync>b__20_5>d);
			return <<ExecuteAsync>b__20_5>d.<>t__builder.Task;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__20_1()
		{
			Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d <<ExecuteAsync>b__20_1>d;
			<<ExecuteAsync>b__20_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__20_1>d.<>4__this = this;
			<<ExecuteAsync>b__20_1>d.<>1__state = -1;
			<<ExecuteAsync>b__20_1>d.<>t__builder.Start<Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref <<ExecuteAsync>b__20_1>d);
			return <<ExecuteAsync>b__20_1>d.<>t__builder.Task;
		}

		// Token: 0x0400036E RID: 878
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", new HtmlString("stylesheet"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400036F RID: 879
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", new HtmlString("text/css"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000370 RID: 880
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("href", "/uas/lib/bootstrap/dist/css/bootstrap.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000371 RID: 881
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("href", "/uas/lib/font-awesome/css/all.min.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000372 RID: 882
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("href", "/_customs/has.uas/css/site.css", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000373 RID: 883
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("src", "/uas/lib/jquery/jquery.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000374 RID: 884
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("src", "/uas/lib/font-awesome/js/all.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000375 RID: 885
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("src", "/uas/lib/bootstrap/dist/js/bootstrap.min.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000376 RID: 886
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("class", new HtmlString("bg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000377 RID: 887
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000378 RID: 888
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000379 RID: 889
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400037A RID: 890
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400037B RID: 891
		private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

		// Token: 0x0400037C RID: 892
		private LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;

		// Token: 0x0400037D RID: 893
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x0400037E RID: 894
		private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;

		// Token: 0x0400037F RID: 895
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x0200017C RID: 380
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__20_0>d : IAsyncStateMachine
		{
			// Token: 0x06000AC9 RID: 2761 RVA: 0x0004ECBC File Offset: 0x0004CEBC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout_account views_Shared__Layout_account = this.<>4__this;
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
						goto IL_01E4;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_034E;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03C3;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_052D;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_05A2;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_06AA;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_071C;
					default:
						views_Shared__Layout_account.WriteLiteral("\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\" />\r\n    <title>MEGA HOPEX</title>\r\n    <link rel=\"apple-touch-icon\" href=\"/_customs/has.uas/images/apple-touch-icon.png\" />\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"32x32\" href=\"/_customs/has.uas/images/favicon-32x32.png\" />\r\n    <link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"/_customs/has.uas/images/favicon-16x16.png\" />\r\n    <link rel=\"shortcut icon\" type=\"images/x-icon\" href=\"/_customs/has.uas/images/favicon.ico\" />\r\n    <meta name=\"msapplication-config\" content=\"/_customs/has.uas/images/browserconfig.xml\" />\r\n\r\n    <link rel=\"mask-icon\" href=\"/uas/shared/images/safari-pinned-tab.svg\" color=\"#5bbad5\" />\r\n    <meta name=\"msapplication-TileColor\" content=\"#da532c\">\r\n    <meta name=\"theme-color\" content=\"#ffffff\">\r\n    ");
						views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e8468", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_2));
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout_account.CreateTagHelper<LinkTagHelper>();
						views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
						views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_0);
						views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_1);
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout_account.__tagHelperAttribute_2.Value;
						views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_2);
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
						views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01EB;
					}
					awaiter2 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_01E4:
					awaiter2.GetResult();
					IL_01EB:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n    ");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("link", TagMode.StartTagOnly, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e10329", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_3));
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout_account.CreateTagHelper<LinkTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_0);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_1);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout_account.__tagHelperAttribute_3.Value;
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_3);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_034E:
					awaiter3.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_03CA;
					}
					awaiter4 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_03C3:
					awaiter4.GetResult();
					IL_03CA:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n    ");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("link", TagMode.SelfClosing, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e12192", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_4));
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = views_Shared__Layout_account.CreateTagHelper<LinkTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_0);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_1);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)Views_Shared__Layout_account.__tagHelperAttribute_4.Value;
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_4);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_052D:
					awaiter5.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_05A9;
					}
					awaiter6 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_05A2:
					awaiter6.GetResult();
					IL_05A9:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n\r\n    ");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("style", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e14058", new Func<Task>(views_Shared__Layout_account.<ExecuteAsync>b__20_5));
					views_Shared__Layout_account.__HAS_Server_TagHelpers_NonceTagHelper = views_Shared__Layout_account.CreateTagHelper<NonceTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__HAS_Server_TagHelpers_NonceTagHelper);
					views_Shared__Layout_account.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", views_Shared__Layout_account.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter7 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_06AA:
					awaiter7.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0723;
					}
					awaiter8 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_071C:
					awaiter8.GetResult();
					IL_0723:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n");
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

			// Token: 0x06000ACA RID: 2762 RVA: 0x0004F464 File Offset: 0x0004D664
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008A9 RID: 2217
			public int <>1__state;

			// Token: 0x040008AA RID: 2218
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008AB RID: 2219
			public Views_Shared__Layout_account <>4__this;

			// Token: 0x040008AC RID: 2220
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200017D RID: 381
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__20_1>d : IAsyncStateMachine
		{
			// Token: 0x06000ACB RID: 2763 RVA: 0x0004F474 File Offset: 0x0004D674
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout_account views_Shared__Layout_account = this.<>4__this;
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
						goto IL_01D3;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_031D;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0392;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04DC;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0551;
					default:
						views_Shared__Layout_account.WriteLiteral("\r\n    ");
						views_Shared__Layout_account.Write(views_Shared__Layout_account.RenderBody());
						views_Shared__Layout_account.WriteLiteral("\r\n    ");
						views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e18534", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_6));
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout_account.CreateTagHelper<ScriptTagHelper>();
						views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout_account.__tagHelperAttribute_5.Value;
						views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_5);
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
						views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01DA;
					}
					awaiter2 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter2, ref this);
						return;
					}
					IL_01D3:
					awaiter2.GetResult();
					IL_01DA:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n    ");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e20241", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_7));
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout_account.CreateTagHelper<ScriptTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout_account.__tagHelperAttribute_6.Value;
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_6);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter3, ref this);
						return;
					}
					IL_031D:
					awaiter3.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0399;
					}
					awaiter4 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter4, ref this);
						return;
					}
					IL_0392:
					awaiter4.GetResult();
					IL_0399:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n    ");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e21948", new Func<Task>(Views_Shared__Layout_account.<>c.<>9.<ExecuteAsync>b__20_8));
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Shared__Layout_account.CreateTagHelper<ScriptTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Shared__Layout_account.__tagHelperAttribute_7.Value;
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Shared__Layout_account.__tagHelperAttribute_7);
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter5, ref this);
						return;
					}
					IL_04DC:
					awaiter5.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0558;
					}
					awaiter6 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<<ExecuteAsync>b__20_1>d>(ref awaiter6, ref this);
						return;
					}
					IL_0551:
					awaiter6.GetResult();
					IL_0558:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n    ");
					views_Shared__Layout_account.Write(views_Shared__Layout_account.RenderSection("scripts", false));
					views_Shared__Layout_account.WriteLiteral("\r\n");
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

			// Token: 0x06000ACC RID: 2764 RVA: 0x0004FA70 File Offset: 0x0004DC70
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008AD RID: 2221
			public int <>1__state;

			// Token: 0x040008AE RID: 2222
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008AF RID: 2223
			public Views_Shared__Layout_account <>4__this;

			// Token: 0x040008B0 RID: 2224
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__20_5>d : IAsyncStateMachine
		{
			// Token: 0x06000ACD RID: 2765 RVA: 0x0004FA80 File Offset: 0x0004DC80
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout_account views_Shared__Layout_account = this.<>4__this;
				try
				{
					views_Shared__Layout_account.WriteLiteral("\r\n        body, html {\r\n            height: 100%;\r\n            margin: 0 0 0 0;\r\n        }\r\n\r\n        .bg {\r\n            background-image: url('/_customs/has.uas/images/loginbackground.jpg');\r\n            /* Full height */\r\n            height: 100%;\r\n            /* Center and scale the image nicely */\r\n            background-position: center;\r\n            background-repeat: no-repeat;\r\n            background-size: cover;\r\n        }\r\n\r\n        .footer {\r\n            padding-top: 40px;\r\n            position: fixed;\r\n            width: 100%;\r\n            bottom: 40px;\r\n        }\r\n\r\n            .footer label {\r\n                background: #8F9DA9;\r\n                width: 400px;\r\n            }\r\n\r\n        a.eye, a:hover {\r\n            color: #333\r\n        }\r\n\r\n        .bg-hopex {\r\n            background-color: #31B672;\r\n        }\r\n\r\n        .btn-hopex, .btn-hopex:disabled {\r\n            background-color: #31B672;\r\n            border-color: #31B672;\r\n            color: white;\r\n            font-weight: 600;\r\n        ");
					views_Shared__Layout_account.WriteLiteral("    width: 300px;\r\n            margin: 20px 50px;\r\n            font-size: 18px\r\n        }\r\n\r\n        .btn-cancel {\r\n            background-color: rgb(161, 164, 167);\r\n            color: white;\r\n            font-weight: 600;\r\n            width: 300px;\r\n            margin: 0px 50px;\r\n            font-size: 18px\r\n        }\r\n\r\n        .titleimg {\r\n            width: 130px;\r\n            margin: -15px;\r\n            padding: 0px;\r\n        }\r\n\r\n        .login {\r\n            justify-content: center;\r\n            padding-top: 120px;\r\n            display: flex;\r\n        }\r\n\r\n        .account-login {\r\n            background-color: #ffffff;\r\n            width: 400px;\r\n            min-height: 400px;\r\n        }\r\n    ");
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

			// Token: 0x06000ACE RID: 2766 RVA: 0x0004FAF0 File Offset: 0x0004DCF0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008B1 RID: 2225
			public int <>1__state;

			// Token: 0x040008B2 RID: 2226
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008B3 RID: 2227
			public Views_Shared__Layout_account <>4__this;
		}

		// Token: 0x0200017F RID: 383
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AD1 RID: 2769 RVA: 0x0004FB14 File Offset: 0x0004DD14
			internal Task <ExecuteAsync>b__20_2()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_2>d <<ExecuteAsync>b__20_2>d;
				<<ExecuteAsync>b__20_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_2>d.<>1__state = -1;
				<<ExecuteAsync>b__20_2>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_2>d>(ref <<ExecuteAsync>b__20_2>d);
				return <<ExecuteAsync>b__20_2>d.<>t__builder.Task;
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x0004FB50 File Offset: 0x0004DD50
			internal Task <ExecuteAsync>b__20_3()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_3>d <<ExecuteAsync>b__20_3>d;
				<<ExecuteAsync>b__20_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_3>d.<>1__state = -1;
				<<ExecuteAsync>b__20_3>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_3>d>(ref <<ExecuteAsync>b__20_3>d);
				return <<ExecuteAsync>b__20_3>d.<>t__builder.Task;
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x0004FB8C File Offset: 0x0004DD8C
			internal Task <ExecuteAsync>b__20_4()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_4>d <<ExecuteAsync>b__20_4>d;
				<<ExecuteAsync>b__20_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_4>d.<>1__state = -1;
				<<ExecuteAsync>b__20_4>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_4>d>(ref <<ExecuteAsync>b__20_4>d);
				return <<ExecuteAsync>b__20_4>d.<>t__builder.Task;
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x0004FBC8 File Offset: 0x0004DDC8
			internal Task <ExecuteAsync>b__20_6()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_6>d <<ExecuteAsync>b__20_6>d;
				<<ExecuteAsync>b__20_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_6>d.<>1__state = -1;
				<<ExecuteAsync>b__20_6>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_6>d>(ref <<ExecuteAsync>b__20_6>d);
				return <<ExecuteAsync>b__20_6>d.<>t__builder.Task;
			}

			// Token: 0x06000AD5 RID: 2773 RVA: 0x0004FC04 File Offset: 0x0004DE04
			internal Task <ExecuteAsync>b__20_7()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_7>d <<ExecuteAsync>b__20_7>d;
				<<ExecuteAsync>b__20_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_7>d.<>1__state = -1;
				<<ExecuteAsync>b__20_7>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_7>d>(ref <<ExecuteAsync>b__20_7>d);
				return <<ExecuteAsync>b__20_7>d.<>t__builder.Task;
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x0004FC40 File Offset: 0x0004DE40
			internal Task <ExecuteAsync>b__20_8()
			{
				Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_8>d <<ExecuteAsync>b__20_8>d;
				<<ExecuteAsync>b__20_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_8>d.<>1__state = -1;
				<<ExecuteAsync>b__20_8>d.<>t__builder.Start<Views_Shared__Layout_account.<>c.<<ExecuteAsync>b__20_8>d>(ref <<ExecuteAsync>b__20_8>d);
				return <<ExecuteAsync>b__20_8>d.<>t__builder.Task;
			}

			// Token: 0x040008B4 RID: 2228
			public static readonly Views_Shared__Layout_account.<>c <>9 = new Views_Shared__Layout_account.<>c();

			// Token: 0x040008B5 RID: 2229
			public static Func<Task> <>9__20_2;

			// Token: 0x040008B6 RID: 2230
			public static Func<Task> <>9__20_3;

			// Token: 0x040008B7 RID: 2231
			public static Func<Task> <>9__20_4;

			// Token: 0x040008B8 RID: 2232
			public static Func<Task> <>9__20_6;

			// Token: 0x040008B9 RID: 2233
			public static Func<Task> <>9__20_7;

			// Token: 0x040008BA RID: 2234
			public static Func<Task> <>9__20_8;

			// Token: 0x0200034F RID: 847
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_2>d : IAsyncStateMachine
			{
				// Token: 0x06000FAC RID: 4012 RVA: 0x000768E8 File Offset: 0x00074AE8
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

				// Token: 0x06000FAD RID: 4013 RVA: 0x00076938 File Offset: 0x00074B38
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F41 RID: 3905
				public int <>1__state;

				// Token: 0x04000F42 RID: 3906
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000350 RID: 848
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_3>d : IAsyncStateMachine
			{
				// Token: 0x06000FAE RID: 4014 RVA: 0x00076948 File Offset: 0x00074B48
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

				// Token: 0x06000FAF RID: 4015 RVA: 0x00076998 File Offset: 0x00074B98
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F43 RID: 3907
				public int <>1__state;

				// Token: 0x04000F44 RID: 3908
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000351 RID: 849
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_4>d : IAsyncStateMachine
			{
				// Token: 0x06000FB0 RID: 4016 RVA: 0x000769A8 File Offset: 0x00074BA8
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

				// Token: 0x06000FB1 RID: 4017 RVA: 0x000769F8 File Offset: 0x00074BF8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F45 RID: 3909
				public int <>1__state;

				// Token: 0x04000F46 RID: 3910
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000352 RID: 850
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_6>d : IAsyncStateMachine
			{
				// Token: 0x06000FB2 RID: 4018 RVA: 0x00076A08 File Offset: 0x00074C08
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

				// Token: 0x06000FB3 RID: 4019 RVA: 0x00076A58 File Offset: 0x00074C58
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F47 RID: 3911
				public int <>1__state;

				// Token: 0x04000F48 RID: 3912
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000353 RID: 851
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_7>d : IAsyncStateMachine
			{
				// Token: 0x06000FB4 RID: 4020 RVA: 0x00076A68 File Offset: 0x00074C68
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

				// Token: 0x06000FB5 RID: 4021 RVA: 0x00076AB8 File Offset: 0x00074CB8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F49 RID: 3913
				public int <>1__state;

				// Token: 0x04000F4A RID: 3914
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000354 RID: 852
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_8>d : IAsyncStateMachine
			{
				// Token: 0x06000FB6 RID: 4022 RVA: 0x00076AC8 File Offset: 0x00074CC8
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

				// Token: 0x06000FB7 RID: 4023 RVA: 0x00076B18 File Offset: 0x00074D18
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F4B RID: 3915
				public int <>1__state;

				// Token: 0x04000F4C RID: 3916
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__20 : IAsyncStateMachine
		{
			// Token: 0x06000AD7 RID: 2775 RVA: 0x0004FC7C File Offset: 0x0004DE7C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Shared__Layout_account views_Shared__Layout_account = this.<>4__this;
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
						goto IL_0230;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_02A2;
					default:
						views_Shared__Layout_account.WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
						views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("head", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e7341", new Func<Task>(views_Shared__Layout_account.<ExecuteAsync>b__20_0));
						views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = views_Shared__Layout_account.CreateTagHelper<HeadTagHelper>();
						views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
						awaiter = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<ExecuteAsync>d__20>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_014C;
					}
					awaiter2 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<ExecuteAsync>d__20>(ref awaiter2, ref this);
						return;
					}
					IL_0145:
					awaiter2.GetResult();
					IL_014C:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n");
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.Begin("body", TagMode.StartTagAndEndTag, "e4eff8a6ee4da08edef183fec8b222ac9f85036bbb5c5e79d7b62027429a841e17986", new Func<Task>(views_Shared__Layout_account.<ExecuteAsync>b__20_1));
					views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = views_Shared__Layout_account.CreateTagHelper<BodyTagHelper>();
					views_Shared__Layout_account.__tagHelperExecutionContext.Add(views_Shared__Layout_account.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
					views_Shared__Layout_account.__tagHelperExecutionContext.AddHtmlAttribute(Views_Shared__Layout_account.__tagHelperAttribute_8);
					awaiter3 = views_Shared__Layout_account.__tagHelperRunner.RunAsync(views_Shared__Layout_account.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<ExecuteAsync>d__20>(ref awaiter3, ref this);
						return;
					}
					IL_0230:
					awaiter3.GetResult();
					if (views_Shared__Layout_account.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02A9;
					}
					awaiter4 = views_Shared__Layout_account.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Shared__Layout_account.<ExecuteAsync>d__20>(ref awaiter4, ref this);
						return;
					}
					IL_02A2:
					awaiter4.GetResult();
					IL_02A9:
					views_Shared__Layout_account.Write(views_Shared__Layout_account.__tagHelperExecutionContext.Output);
					views_Shared__Layout_account.__tagHelperExecutionContext = views_Shared__Layout_account.__tagHelperScopeManager.End();
					views_Shared__Layout_account.WriteLiteral("\r\n</html>\r\n");
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

			// Token: 0x06000AD8 RID: 2776 RVA: 0x0004FFAC File Offset: 0x0004E1AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008BB RID: 2235
			public int <>1__state;

			// Token: 0x040008BC RID: 2236
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008BD RID: 2237
			public Views_Shared__Layout_account <>4__this;

			// Token: 0x040008BE RID: 2238
			private TaskAwaiter <>u__1;
		}
	}
}
