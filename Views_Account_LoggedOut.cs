using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using Mega.Has.Modules.UAS.ViewModels;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000045 RID: 69
	[RazorSourceChecksum("SHA256", "b45dae28e1e1424999910ea5c60066feec960575993268b4d4ec8e3cdc068f6d", "/Views/Account/LoggedOut.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/LoggedOut.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_LoggedOut : BaseRazorPage<LoggedOutViewModel>
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000C486 File Offset: 0x0000A686
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

		// Token: 0x06000303 RID: 771 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public override Task ExecuteAsync()
		{
			Views_Account_LoggedOut.<ExecuteAsync>d__10 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_LoggedOut.<ExecuteAsync>d__10>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000C4FF File Offset: 0x0000A6FF
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000C507 File Offset: 0x0000A707
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000C510 File Offset: 0x0000A710
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000C518 File Offset: 0x0000A718
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000C521 File Offset: 0x0000A721
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000C529 File Offset: 0x0000A729
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000C532 File Offset: 0x0000A732
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000C53A File Offset: 0x0000A73A
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000C543 File Offset: 0x0000A743
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0000C54B File Offset: 0x0000A74B
		[RazorInject]
		public IHtmlHelper<LoggedOutViewModel> Html { get; private set; }

		// Token: 0x06000310 RID: 784 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__10_1()
		{
			Views_Account_LoggedOut.<<ExecuteAsync>b__10_1>d <<ExecuteAsync>b__10_1>d;
			<<ExecuteAsync>b__10_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__10_1>d.<>4__this = this;
			<<ExecuteAsync>b__10_1>d.<>1__state = -1;
			<<ExecuteAsync>b__10_1>d.<>t__builder.Start<Views_Account_LoggedOut.<<ExecuteAsync>b__10_1>d>(ref <<ExecuteAsync>b__10_1>d);
			return <<ExecuteAsync>b__10_1>d.<>t__builder.Task;
		}

		// Token: 0x040002C7 RID: 711
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002C8 RID: 712
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002C9 RID: 713
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002CA RID: 714
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040002CB RID: 715
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040002CC RID: 716
		private string __tagHelperStringValueBuffer;

		// Token: 0x040002CD RID: 717
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040002CE RID: 718
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x02000159 RID: 345
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__10_1>d : IAsyncStateMachine
		{
			// Token: 0x06000A67 RID: 2663 RVA: 0x0004680C File Offset: 0x00044A0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_LoggedOut views_Account_LoggedOut = this.<>4__this;
				try
				{
					views_Account_LoggedOut.WriteLiteral("\r\n\r\n");
					if (views_Account_LoggedOut.Model.AutomaticRedirectAfterSignOut)
					{
						views_Account_LoggedOut.WriteLiteral("        <script src=\"/uas/js/signout-redirect.js\"></script>\r\n");
					}
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

			// Token: 0x06000A68 RID: 2664 RVA: 0x00046888 File Offset: 0x00044A88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000820 RID: 2080
			public int <>1__state;

			// Token: 0x04000821 RID: 2081
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000822 RID: 2082
			public Views_Account_LoggedOut <>4__this;
		}

		// Token: 0x0200015A RID: 346
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A6B RID: 2667 RVA: 0x000468AC File Offset: 0x00044AAC
			internal Task <ExecuteAsync>b__10_0()
			{
				Views_Account_LoggedOut.<>c.<<ExecuteAsync>b__10_0>d <<ExecuteAsync>b__10_0>d;
				<<ExecuteAsync>b__10_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__10_0>d.<>1__state = -1;
				<<ExecuteAsync>b__10_0>d.<>t__builder.Start<Views_Account_LoggedOut.<>c.<<ExecuteAsync>b__10_0>d>(ref <<ExecuteAsync>b__10_0>d);
				return <<ExecuteAsync>b__10_0>d.<>t__builder.Task;
			}

			// Token: 0x04000823 RID: 2083
			public static readonly Views_Account_LoggedOut.<>c <>9 = new Views_Account_LoggedOut.<>c();

			// Token: 0x04000824 RID: 2084
			public static Func<Task> <>9__10_0;

			// Token: 0x0200032F RID: 815
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__10_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F6C RID: 3948 RVA: 0x00075CE8 File Offset: 0x00073EE8
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

				// Token: 0x06000F6D RID: 3949 RVA: 0x00075D38 File Offset: 0x00073F38
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F01 RID: 3841
				public int <>1__state;

				// Token: 0x04000F02 RID: 3842
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200015B RID: 347
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06000A6C RID: 2668 RVA: 0x000468E8 File Offset: 0x00044AE8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_LoggedOut views_Account_LoggedOut = this.<>4__this;
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
							goto IL_01E7;
						}
						views_Account_LoggedOut.WriteLiteral("\r\n");
						views_Account_LoggedOut.ViewData["signed-out"] = true;
						views_Account_LoggedOut.WriteLiteral("\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded pt-3\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_LoggedOut.__tagHelperExecutionContext = views_Account_LoggedOut.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "b45dae28e1e1424999910ea5c60066feec960575993268b4d4ec8e3cdc068f6d5234", new Func<Task>(Views_Account_LoggedOut.<>c.<>9.<ExecuteAsync>b__10_0));
						views_Account_LoggedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_LoggedOut.CreateTagHelper<ImageTagHelper>();
						views_Account_LoggedOut.__tagHelperExecutionContext.Add(views_Account_LoggedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_LoggedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_LoggedOut.__tagHelperAttribute_0.Value;
						views_Account_LoggedOut.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_LoggedOut.__tagHelperAttribute_0);
						views_Account_LoggedOut.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_LoggedOut.__tagHelperAttribute_1);
						views_Account_LoggedOut.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_LoggedOut.__tagHelperAttribute_2);
						views_Account_LoggedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_LoggedOut.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_LoggedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_LoggedOut.__tagHelperRunner.RunAsync(views_Account_LoggedOut.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_LoggedOut.<ExecuteAsync>d__10>(ref awaiter2, ref this);
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
					if (views_Account_LoggedOut.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01EE;
					}
					awaiter = views_Account_LoggedOut.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_LoggedOut.<ExecuteAsync>d__10>(ref awaiter, ref this);
						return;
					}
					IL_01E7:
					awaiter.GetResult();
					IL_01EE:
					views_Account_LoggedOut.Write(views_Account_LoggedOut.__tagHelperExecutionContext.Output);
					views_Account_LoggedOut.__tagHelperExecutionContext = views_Account_LoggedOut.__tagHelperScopeManager.End();
					views_Account_LoggedOut.WriteLiteral("\r\n        </div>\r\n        <h5 class=\"m-2\">");
					views_Account_LoggedOut.Write(views_Account_LoggedOut.T["Logout"]);
					views_Account_LoggedOut.WriteLiteral("</h5>\r\n        <div class=\"m-2 alert alert-success text-center\">");
					views_Account_LoggedOut.Write(views_Account_LoggedOut.T["You are now logged out"]);
					views_Account_LoggedOut.WriteLiteral("</div>\r\n        <div class=\"text-center\">\r\n");
					if (views_Account_LoggedOut.Model.PostLogoutRedirectUri != null)
					{
						views_Account_LoggedOut.WriteLiteral("                <div>\r\n                    Click <a class=\"PostLogoutRedirectUri\"");
						views_Account_LoggedOut.BeginWriteAttribute("href", " href=\"", 714, "\"", 749, 1);
						views_Account_LoggedOut.WriteAttributeValue("", 721, views_Account_LoggedOut.Model.PostLogoutRedirectUri, 721, 28, false);
						views_Account_LoggedOut.EndWriteAttribute();
						views_Account_LoggedOut.WriteLiteral(">here</a> to return to the\r\n                    <span>");
						views_Account_LoggedOut.Write(views_Account_LoggedOut.Model.ClientName);
						views_Account_LoggedOut.WriteLiteral("</span> application.\r\n                </div>\r\n");
					}
					views_Account_LoggedOut.WriteLiteral("\r\n");
					if (views_Account_LoggedOut.Model.SignOutIframeUrl != null)
					{
						views_Account_LoggedOut.WriteLiteral("                <iframe width=\"0\" height=\"0\"");
						views_Account_LoggedOut.BeginWriteAttribute("src", " src=\"", 993, "\"", 1022, 1);
						views_Account_LoggedOut.WriteAttributeValue("", 999, views_Account_LoggedOut.Model.SignOutIframeUrl, 999, 23, false);
						views_Account_LoggedOut.EndWriteAttribute();
						views_Account_LoggedOut.WriteLiteral("></iframe>\r\n");
					}
					views_Account_LoggedOut.WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
					views_Account_LoggedOut.DefineSection("scripts", new RenderAsyncDelegate(views_Account_LoggedOut.<ExecuteAsync>b__10_1));
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

			// Token: 0x06000A6D RID: 2669 RVA: 0x00046CC0 File Offset: 0x00044EC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000825 RID: 2085
			public int <>1__state;

			// Token: 0x04000826 RID: 2086
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000827 RID: 2087
			public Views_Account_LoggedOut <>4__this;

			// Token: 0x04000828 RID: 2088
			private TaskAwaiter <>u__1;
		}
	}
}
