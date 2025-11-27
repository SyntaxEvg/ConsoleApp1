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
using Microsoft.CSharp.RuntimeBinder;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000042 RID: 66
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "b6fdb7853326de6612d31bd2916214daa89041a66ca7f7ddc63cecfcd6086b3c", "/Views/Account/AccessDenied.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/AccessDenied.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_AccessDenied : BaseRazorPage<object>
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000BFCC File Offset: 0x0000A1CC
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

		// Token: 0x060002D7 RID: 727 RVA: 0x0000C000 File Offset: 0x0000A200
		public override Task ExecuteAsync()
		{
			Views_Account_AccessDenied.<ExecuteAsync>d__10 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_AccessDenied.<ExecuteAsync>d__10>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000C043 File Offset: 0x0000A243
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000C04B File Offset: 0x0000A24B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000C054 File Offset: 0x0000A254
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0000C05C File Offset: 0x0000A25C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000C065 File Offset: 0x0000A265
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000C06D File Offset: 0x0000A26D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000C076 File Offset: 0x0000A276
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000C07E File Offset: 0x0000A27E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000C087 File Offset: 0x0000A287
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000C08F File Offset: 0x0000A28F
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x04000296 RID: 662
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000297 RID: 663
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000298 RID: 664
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000299 RID: 665
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x0400029A RID: 666
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x0400029B RID: 667
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400029C RID: 668
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400029D RID: 669
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x0200014F RID: 335
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A50 RID: 2640 RVA: 0x000455F0 File Offset: 0x000437F0
			internal Task <ExecuteAsync>b__10_0()
			{
				Views_Account_AccessDenied.<>c.<<ExecuteAsync>b__10_0>d <<ExecuteAsync>b__10_0>d;
				<<ExecuteAsync>b__10_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__10_0>d.<>1__state = -1;
				<<ExecuteAsync>b__10_0>d.<>t__builder.Start<Views_Account_AccessDenied.<>c.<<ExecuteAsync>b__10_0>d>(ref <<ExecuteAsync>b__10_0>d);
				return <<ExecuteAsync>b__10_0>d.<>t__builder.Task;
			}

			// Token: 0x040007FF RID: 2047
			public static readonly Views_Account_AccessDenied.<>c <>9 = new Views_Account_AccessDenied.<>c();

			// Token: 0x04000800 RID: 2048
			public static Func<Task> <>9__10_0;

			// Token: 0x02000327 RID: 807
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__10_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F5C RID: 3932 RVA: 0x00074BFC File Offset: 0x00072DFC
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

				// Token: 0x06000F5D RID: 3933 RVA: 0x00074C4C File Offset: 0x00072E4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EEF RID: 3823
				public int <>1__state;

				// Token: 0x04000EF0 RID: 3824
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000151 RID: 337
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06000A51 RID: 2641 RVA: 0x0004562C File Offset: 0x0004382C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_AccessDenied views_Account_AccessDenied = this.<>4__this;
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
							goto IL_01C6;
						}
						views_Account_AccessDenied.WriteLiteral("\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded pt-3\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_AccessDenied.__tagHelperExecutionContext = views_Account_AccessDenied.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "b6fdb7853326de6612d31bd2916214daa89041a66ca7f7ddc63cecfcd6086b3c4926", new Func<Task>(Views_Account_AccessDenied.<>c.<>9.<ExecuteAsync>b__10_0));
						views_Account_AccessDenied.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_AccessDenied.CreateTagHelper<ImageTagHelper>();
						views_Account_AccessDenied.__tagHelperExecutionContext.Add(views_Account_AccessDenied.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_AccessDenied.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_AccessDenied.__tagHelperAttribute_0.Value;
						views_Account_AccessDenied.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_AccessDenied.__tagHelperAttribute_0);
						views_Account_AccessDenied.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_AccessDenied.__tagHelperAttribute_1);
						views_Account_AccessDenied.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_AccessDenied.__tagHelperAttribute_2);
						views_Account_AccessDenied.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_AccessDenied.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_AccessDenied.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_AccessDenied.__tagHelperRunner.RunAsync(views_Account_AccessDenied.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_AccessDenied.<ExecuteAsync>d__10>(ref awaiter2, ref this);
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
					if (views_Account_AccessDenied.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01CD;
					}
					awaiter = views_Account_AccessDenied.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_AccessDenied.<ExecuteAsync>d__10>(ref awaiter, ref this);
						return;
					}
					IL_01C6:
					awaiter.GetResult();
					IL_01CD:
					views_Account_AccessDenied.Write(views_Account_AccessDenied.__tagHelperExecutionContext.Output);
					views_Account_AccessDenied.__tagHelperExecutionContext = views_Account_AccessDenied.__tagHelperScopeManager.End();
					views_Account_AccessDenied.WriteLiteral("\r\n        </div>\r\n        <h5 class=\"m-2 alert alert-danger text-center\">");
					views_Account_AccessDenied.Write(views_Account_AccessDenied.T["Access is denied"]);
					views_Account_AccessDenied.WriteLiteral("</h5>\r\n\r\n        <a class=\"mt-4 btn btn-block btn-primary\"");
					views_Account_AccessDenied.BeginWriteAttribute("href", " href=\"", 391, "\"", 416, 1);
					if (Views_Account_AccessDenied.<>o__10.<>p__1 == null)
					{
						Views_Account_AccessDenied.<>o__10.<>p__1 = CallSite<Action<CallSite, Views_Account_AccessDenied, string, int, object, int, int, bool>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "WriteAttributeValue", null, typeof(Views_Account_AccessDenied), new CSharpArgumentInfo[]
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
					Action<CallSite, Views_Account_AccessDenied, string, int, object, int, int, bool> target = Views_Account_AccessDenied.<>o__10.<>p__1.Target;
					CallSite <>p__ = Views_Account_AccessDenied.<>o__10.<>p__1;
					Views_Account_AccessDenied views_Account_AccessDenied2 = views_Account_AccessDenied;
					string text = "";
					int num2 = 398;
					if (Views_Account_AccessDenied.<>o__10.<>p__0 == null)
					{
						Views_Account_AccessDenied.<>o__10.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "ReturnUrl", typeof(Views_Account_AccessDenied), new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
					}
					target(<>p__, views_Account_AccessDenied2, text, num2, Views_Account_AccessDenied.<>o__10.<>p__0.Target(Views_Account_AccessDenied.<>o__10.<>p__0, views_Account_AccessDenied.ViewBag), 398, 18, false);
					views_Account_AccessDenied.EndWriteAttribute();
					views_Account_AccessDenied.WriteLiteral(">");
					views_Account_AccessDenied.Write(views_Account_AccessDenied.T["LOGIN"]);
					views_Account_AccessDenied.WriteLiteral("</a>\r\n\r\n    </div>\r\n</div>");
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

			// Token: 0x06000A52 RID: 2642 RVA: 0x000459E0 File Offset: 0x00043BE0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000803 RID: 2051
			public int <>1__state;

			// Token: 0x04000804 RID: 2052
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000805 RID: 2053
			public Views_Account_AccessDenied <>4__this;

			// Token: 0x04000806 RID: 2054
			private TaskAwaiter <>u__1;
		}
	}
}
