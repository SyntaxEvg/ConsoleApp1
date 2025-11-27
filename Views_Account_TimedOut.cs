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
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CSharp.RuntimeBinder;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000049 RID: 73
	[RazorSourceChecksum("SHA256", "9cea83f49b42bd9ea27ccbabe01c07b8b2a5e96baa855c5cd35532341c8a841c", "/Views/Account/TimedOut.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/TimedOut.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_TimedOut : BaseRazorPage<LoggedOutViewModel>
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000CFE7 File Offset: 0x0000B1E7
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

		// Token: 0x06000347 RID: 839 RVA: 0x0000D01C File Offset: 0x0000B21C
		public override Task ExecuteAsync()
		{
			Views_Account_TimedOut.<ExecuteAsync>d__10 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_TimedOut.<ExecuteAsync>d__10>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000D05F File Offset: 0x0000B25F
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000D067 File Offset: 0x0000B267
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000D070 File Offset: 0x0000B270
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000D078 File Offset: 0x0000B278
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000D081 File Offset: 0x0000B281
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000D089 File Offset: 0x0000B289
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000D092 File Offset: 0x0000B292
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000D09A File Offset: 0x0000B29A
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000D0A3 File Offset: 0x0000B2A3
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000D0AB File Offset: 0x0000B2AB
		[RazorInject]
		public IHtmlHelper<LoggedOutViewModel> Html { get; private set; }

		// Token: 0x0400032F RID: 815
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000330 RID: 816
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000331 RID: 817
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000332 RID: 818
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000333 RID: 819
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000334 RID: 820
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000335 RID: 821
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000336 RID: 822
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x0200016D RID: 365
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AA5 RID: 2725 RVA: 0x0004BC38 File Offset: 0x00049E38
			internal Task <ExecuteAsync>b__10_0()
			{
				Views_Account_TimedOut.<>c.<<ExecuteAsync>b__10_0>d <<ExecuteAsync>b__10_0>d;
				<<ExecuteAsync>b__10_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__10_0>d.<>1__state = -1;
				<<ExecuteAsync>b__10_0>d.<>t__builder.Start<Views_Account_TimedOut.<>c.<<ExecuteAsync>b__10_0>d>(ref <<ExecuteAsync>b__10_0>d);
				return <<ExecuteAsync>b__10_0>d.<>t__builder.Task;
			}

			// Token: 0x04000871 RID: 2161
			public static readonly Views_Account_TimedOut.<>c <>9 = new Views_Account_TimedOut.<>c();

			// Token: 0x04000872 RID: 2162
			public static Func<Task> <>9__10_0;

			// Token: 0x02000343 RID: 835
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__10_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F94 RID: 3988 RVA: 0x00076468 File Offset: 0x00074668
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

				// Token: 0x06000F95 RID: 3989 RVA: 0x000764B8 File Offset: 0x000746B8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F29 RID: 3881
				public int <>1__state;

				// Token: 0x04000F2A RID: 3882
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200016F RID: 367
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06000AA6 RID: 2726 RVA: 0x0004BC74 File Offset: 0x00049E74
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_TimedOut views_Account_TimedOut = this.<>4__this;
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
						views_Account_TimedOut.WriteLiteral("\r\n");
						views_Account_TimedOut.ViewData["signed-out"] = true;
						views_Account_TimedOut.WriteLiteral("\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded pt-3\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_TimedOut.__tagHelperExecutionContext = views_Account_TimedOut.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "9cea83f49b42bd9ea27ccbabe01c07b8b2a5e96baa855c5cd35532341c8a841c5227", new Func<Task>(Views_Account_TimedOut.<>c.<>9.<ExecuteAsync>b__10_0));
						views_Account_TimedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_TimedOut.CreateTagHelper<ImageTagHelper>();
						views_Account_TimedOut.__tagHelperExecutionContext.Add(views_Account_TimedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_TimedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_TimedOut.__tagHelperAttribute_0.Value;
						views_Account_TimedOut.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_TimedOut.__tagHelperAttribute_0);
						views_Account_TimedOut.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_TimedOut.__tagHelperAttribute_1);
						views_Account_TimedOut.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_TimedOut.__tagHelperAttribute_2);
						views_Account_TimedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_TimedOut.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_TimedOut.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_TimedOut.__tagHelperRunner.RunAsync(views_Account_TimedOut.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_TimedOut.<ExecuteAsync>d__10>(ref awaiter2, ref this);
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
					if (views_Account_TimedOut.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01EE;
					}
					awaiter = views_Account_TimedOut.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_TimedOut.<ExecuteAsync>d__10>(ref awaiter, ref this);
						return;
					}
					IL_01E7:
					awaiter.GetResult();
					IL_01EE:
					views_Account_TimedOut.Write(views_Account_TimedOut.__tagHelperExecutionContext.Output);
					views_Account_TimedOut.__tagHelperExecutionContext = views_Account_TimedOut.__tagHelperScopeManager.End();
					views_Account_TimedOut.WriteLiteral("\r\n        </div>\r\n        <div class=\"m-2 alert alert-danger text-center\">");
					views_Account_TimedOut.Write(views_Account_TimedOut.T["Authentication failed, please try again."]);
					views_Account_TimedOut.WriteLiteral("</div>\r\n\r\n        <a class=\"btn btn-hopex btn-success mx-50 my-20\"");
					views_Account_TimedOut.BeginWriteAttribute("href", " href=\"", 560, "\"", 585, 1);
					if (Views_Account_TimedOut.<>o__10.<>p__1 == null)
					{
						Views_Account_TimedOut.<>o__10.<>p__1 = CallSite<Action<CallSite, Views_Account_TimedOut, string, int, object, int, int, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "WriteAttributeValue", null, typeof(Views_Account_TimedOut), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Action<CallSite, Views_Account_TimedOut, string, int, object, int, int, bool> target = Views_Account_TimedOut.<>o__10.<>p__1.Target;
					CallSite <>p__ = Views_Account_TimedOut.<>o__10.<>p__1;
					Views_Account_TimedOut views_Account_TimedOut2 = views_Account_TimedOut;
					string text = "";
					int num2 = 567;
					if (Views_Account_TimedOut.<>o__10.<>p__0 == null)
					{
						Views_Account_TimedOut.<>o__10.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "ReturnUrl", typeof(Views_Account_TimedOut), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
					}
					target(<>p__, views_Account_TimedOut2, text, num2, Views_Account_TimedOut.<>o__10.<>p__0.Target(Views_Account_TimedOut.<>o__10.<>p__0, views_Account_TimedOut.ViewBag), 567, 18, false);
					views_Account_TimedOut.EndWriteAttribute();
					views_Account_TimedOut.WriteLiteral(">");
					views_Account_TimedOut.Write(views_Account_TimedOut.T["Back to login page"]);
					views_Account_TimedOut.WriteLiteral("</a>\r\n\r\n    </div>\r\n</div>");
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

			// Token: 0x06000AA7 RID: 2727 RVA: 0x0004C048 File Offset: 0x0004A248
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000875 RID: 2165
			public int <>1__state;

			// Token: 0x04000876 RID: 2166
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000877 RID: 2167
			public Views_Account_TimedOut <>4__this;

			// Token: 0x04000878 RID: 2168
			private TaskAwaiter <>u__1;
		}
	}
}
