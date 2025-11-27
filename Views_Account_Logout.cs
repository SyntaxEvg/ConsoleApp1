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

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000047 RID: 71
	[RazorSourceChecksum("SHA256", "f925a10d1317eafe805a2db5dc4a918f89321a7445c42551b703aa5017889be1", "/Views/Account/Logout.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/Logout.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_Logout : BaseRazorPage<LogoutViewModel>
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000C963 File Offset: 0x0000AB63
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

		// Token: 0x06000324 RID: 804 RVA: 0x0000C998 File Offset: 0x0000AB98
		public override Task ExecuteAsync()
		{
			Views_Account_Logout.<ExecuteAsync>d__13 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_Logout.<ExecuteAsync>d__13>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000C9DB File Offset: 0x0000ABDB
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000C9E3 File Offset: 0x0000ABE3
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000C9FD File Offset: 0x0000ABFD
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000CA05 File Offset: 0x0000AC05
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000CA0E File Offset: 0x0000AC0E
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000CA16 File Offset: 0x0000AC16
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000CA1F File Offset: 0x0000AC1F
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0000CA27 File Offset: 0x0000AC27
		[RazorInject]
		public IHtmlHelper<LogoutViewModel> Html { get; private set; }

		// Token: 0x06000331 RID: 817 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__13_1()
		{
			Views_Account_Logout.<<ExecuteAsync>b__13_1>d <<ExecuteAsync>b__13_1>d;
			<<ExecuteAsync>b__13_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__13_1>d.<>4__this = this;
			<<ExecuteAsync>b__13_1>d.<>1__state = -1;
			<<ExecuteAsync>b__13_1>d.<>t__builder.Start<Views_Account_Logout.<<ExecuteAsync>b__13_1>d>(ref <<ExecuteAsync>b__13_1>d);
			return <<ExecuteAsync>b__13_1>d.<>t__builder.Task;
		}

		// Token: 0x040002F4 RID: 756
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002F5 RID: 757
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002F6 RID: 758
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002F7 RID: 759
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("asp-action", "Logout", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002F8 RID: 760
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040002F9 RID: 761
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040002FA RID: 762
		private string __tagHelperStringValueBuffer;

		// Token: 0x040002FB RID: 763
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040002FC RID: 764
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x040002FD RID: 765
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x040002FE RID: 766
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x02000162 RID: 354
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__13_1>d : IAsyncStateMachine
		{
			// Token: 0x06000A80 RID: 2688 RVA: 0x000489A8 File Offset: 0x00046BA8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Logout views_Account_Logout = this.<>4__this;
				try
				{
					views_Account_Logout.WriteLiteral("\r\n                <input type=\"hidden\" name=\"logoutId\"");
					views_Account_Logout.BeginWriteAttribute("value", " value=\"", 453, "\"", 476, 1);
					views_Account_Logout.WriteAttributeValue("", 461, views_Account_Logout.Model.LogoutId, 461, 15, false);
					views_Account_Logout.EndWriteAttribute();
					views_Account_Logout.WriteLiteral(" />\r\n            <button class=\"btn btn-hopex btn-success\" type=\"submit\" id=\"btnSubmit\">");
					views_Account_Logout.Write(views_Account_Logout.T["Yes"]);
					views_Account_Logout.WriteLiteral("</button>\r\n            ");
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

			// Token: 0x06000A81 RID: 2689 RVA: 0x00048A80 File Offset: 0x00046C80
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000843 RID: 2115
			public int <>1__state;

			// Token: 0x04000844 RID: 2116
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000845 RID: 2117
			public Views_Account_Logout <>4__this;
		}

		// Token: 0x02000163 RID: 355
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A84 RID: 2692 RVA: 0x00048AA4 File Offset: 0x00046CA4
			internal Task <ExecuteAsync>b__13_0()
			{
				Views_Account_Logout.<>c.<<ExecuteAsync>b__13_0>d <<ExecuteAsync>b__13_0>d;
				<<ExecuteAsync>b__13_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__13_0>d.<>1__state = -1;
				<<ExecuteAsync>b__13_0>d.<>t__builder.Start<Views_Account_Logout.<>c.<<ExecuteAsync>b__13_0>d>(ref <<ExecuteAsync>b__13_0>d);
				return <<ExecuteAsync>b__13_0>d.<>t__builder.Task;
			}

			// Token: 0x04000846 RID: 2118
			public static readonly Views_Account_Logout.<>c <>9 = new Views_Account_Logout.<>c();

			// Token: 0x04000847 RID: 2119
			public static Func<Task> <>9__13_0;

			// Token: 0x02000336 RID: 822
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__13_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F7A RID: 3962 RVA: 0x00075F88 File Offset: 0x00074188
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

				// Token: 0x06000F7B RID: 3963 RVA: 0x00075FD8 File Offset: 0x000741D8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F0F RID: 3855
				public int <>1__state;

				// Token: 0x04000F10 RID: 3856
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000164 RID: 356
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__13 : IAsyncStateMachine
		{
			// Token: 0x06000A85 RID: 2693 RVA: 0x00048AE0 File Offset: 0x00046CE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Logout views_Account_Logout = this.<>4__this;
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
						goto IL_01CF;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0312;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0384;
					default:
						views_Account_Logout.WriteLiteral("\r\n    <div class=\"login\">\r\n        <div class=\"account-login border shadow rounded\">\r\n            <div class=\"text-center py-3 \">\r\n            ");
						views_Account_Logout.__tagHelperExecutionContext = views_Account_Logout.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "f925a10d1317eafe805a2db5dc4a918f89321a7445c42551b703aa5017889be15488", new Func<Task>(Views_Account_Logout.<>c.<>9.<ExecuteAsync>b__13_0));
						views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_Logout.CreateTagHelper<ImageTagHelper>();
						views_Account_Logout.__tagHelperExecutionContext.Add(views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_Logout.__tagHelperAttribute_0.Value;
						views_Account_Logout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Logout.__tagHelperAttribute_0);
						views_Account_Logout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Logout.__tagHelperAttribute_1);
						views_Account_Logout.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Logout.__tagHelperAttribute_2);
						views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_Logout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Account_Logout.__tagHelperRunner.RunAsync(views_Account_Logout.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Logout.<ExecuteAsync>d__13>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Account_Logout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01D6;
					}
					awaiter2 = views_Account_Logout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Logout.<ExecuteAsync>d__13>(ref awaiter2, ref this);
						return;
					}
					IL_01CF:
					awaiter2.GetResult();
					IL_01D6:
					views_Account_Logout.Write(views_Account_Logout.__tagHelperExecutionContext.Output);
					views_Account_Logout.__tagHelperExecutionContext = views_Account_Logout.__tagHelperScopeManager.End();
					views_Account_Logout.WriteLiteral("\r\n            </div>\r\n            <h5 class=\"mx-2\">");
					views_Account_Logout.Write(views_Account_Logout.T["Would you like to logout ?"]);
					views_Account_Logout.WriteLiteral("</h5>\r\n\r\n            ");
					views_Account_Logout.__tagHelperExecutionContext = views_Account_Logout.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "f925a10d1317eafe805a2db5dc4a918f89321a7445c42551b703aa5017889be17605", new Func<Task>(views_Account_Logout.<ExecuteAsync>b__13_1));
					views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = views_Account_Logout.CreateTagHelper<FormTagHelper>();
					views_Account_Logout.__tagHelperExecutionContext.Add(views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = views_Account_Logout.CreateTagHelper<RenderAtEndOfFormTagHelper>();
					views_Account_Logout.__tagHelperExecutionContext.Add(views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					views_Account_Logout.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)Views_Account_Logout.__tagHelperAttribute_3.Value;
					views_Account_Logout.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Logout.__tagHelperAttribute_3);
					awaiter3 = views_Account_Logout.__tagHelperRunner.RunAsync(views_Account_Logout.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Logout.<ExecuteAsync>d__13>(ref awaiter3, ref this);
						return;
					}
					IL_0312:
					awaiter3.GetResult();
					if (views_Account_Logout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_038B;
					}
					awaiter4 = views_Account_Logout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Logout.<ExecuteAsync>d__13>(ref awaiter4, ref this);
						return;
					}
					IL_0384:
					awaiter4.GetResult();
					IL_038B:
					views_Account_Logout.Write(views_Account_Logout.__tagHelperExecutionContext.Output);
					views_Account_Logout.__tagHelperExecutionContext = views_Account_Logout.__tagHelperScopeManager.End();
					views_Account_Logout.WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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

			// Token: 0x06000A86 RID: 2694 RVA: 0x00048EF0 File Offset: 0x000470F0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000848 RID: 2120
			public int <>1__state;

			// Token: 0x04000849 RID: 2121
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400084A RID: 2122
			public Views_Account_Logout <>4__this;

			// Token: 0x0400084B RID: 2123
			private TaskAwaiter <>u__1;
		}
	}
}
