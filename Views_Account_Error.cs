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
	// Token: 0x02000044 RID: 68
	[RazorSourceChecksum("SHA256", "e5d36ed7c102ab535c6d118909c21294d613f1fdb1ebf16e30656bf892405f1d", "/Views/Account/Error.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/Error.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_Error : BaseRazorPage<ErrorViewModel>
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000C34F File Offset: 0x0000A54F
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

		// Token: 0x060002F5 RID: 757 RVA: 0x0000C384 File Offset: 0x0000A584
		public override Task ExecuteAsync()
		{
			Views_Account_Error.<ExecuteAsync>d__10 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_Error.<ExecuteAsync>d__10>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0000C3C7 File Offset: 0x0000A5C7
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000C3CF File Offset: 0x0000A5CF
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0000C3E0 File Offset: 0x0000A5E0
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000C3E9 File Offset: 0x0000A5E9
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000C3F1 File Offset: 0x0000A5F1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000C3FA File Offset: 0x0000A5FA
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000C402 File Offset: 0x0000A602
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000C40B File Offset: 0x0000A60B
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000C413 File Offset: 0x0000A613
		[RazorInject]
		public IHtmlHelper<ErrorViewModel> Html { get; private set; }

		// Token: 0x040002BA RID: 698
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002BB RID: 699
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002BC RID: 700
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002BD RID: 701
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040002BE RID: 702
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040002BF RID: 703
		private string __tagHelperStringValueBuffer;

		// Token: 0x040002C0 RID: 704
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040002C1 RID: 705
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x02000157 RID: 343
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A64 RID: 2660 RVA: 0x000464B8 File Offset: 0x000446B8
			internal Task <ExecuteAsync>b__10_0()
			{
				Views_Account_Error.<>c.<<ExecuteAsync>b__10_0>d <<ExecuteAsync>b__10_0>d;
				<<ExecuteAsync>b__10_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__10_0>d.<>1__state = -1;
				<<ExecuteAsync>b__10_0>d.<>t__builder.Start<Views_Account_Error.<>c.<<ExecuteAsync>b__10_0>d>(ref <<ExecuteAsync>b__10_0>d);
				return <<ExecuteAsync>b__10_0>d.<>t__builder.Task;
			}

			// Token: 0x0400081A RID: 2074
			public static readonly Views_Account_Error.<>c <>9 = new Views_Account_Error.<>c();

			// Token: 0x0400081B RID: 2075
			public static Func<Task> <>9__10_0;

			// Token: 0x0200032E RID: 814
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__10_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F6A RID: 3946 RVA: 0x00075C88 File Offset: 0x00073E88
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

				// Token: 0x06000F6B RID: 3947 RVA: 0x00075CD8 File Offset: 0x00073ED8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EFF RID: 3839
				public int <>1__state;

				// Token: 0x04000F00 RID: 3840
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000158 RID: 344
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__10 : IAsyncStateMachine
		{
			// Token: 0x06000A65 RID: 2661 RVA: 0x000464F4 File Offset: 0x000446F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Error views_Account_Error = this.<>4__this;
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
						views_Account_Error.WriteLiteral("\r\n\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded pt-3\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_Error.__tagHelperExecutionContext = views_Account_Error.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "e5d36ed7c102ab535c6d118909c21294d613f1fdb1ebf16e30656bf892405f1d4895", new Func<Task>(Views_Account_Error.<>c.<>9.<ExecuteAsync>b__10_0));
						views_Account_Error.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_Error.CreateTagHelper<ImageTagHelper>();
						views_Account_Error.__tagHelperExecutionContext.Add(views_Account_Error.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_Error.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_Error.__tagHelperAttribute_0.Value;
						views_Account_Error.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Error.__tagHelperAttribute_0);
						views_Account_Error.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Error.__tagHelperAttribute_1);
						views_Account_Error.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Error.__tagHelperAttribute_2);
						views_Account_Error.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_Error.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Error.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_Error.__tagHelperRunner.RunAsync(views_Account_Error.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Error.<ExecuteAsync>d__10>(ref awaiter2, ref this);
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
					if (views_Account_Error.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01CD;
					}
					awaiter = views_Account_Error.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Error.<ExecuteAsync>d__10>(ref awaiter, ref this);
						return;
					}
					IL_01C6:
					awaiter.GetResult();
					IL_01CD:
					views_Account_Error.Write(views_Account_Error.__tagHelperExecutionContext.Output);
					views_Account_Error.__tagHelperExecutionContext = views_Account_Error.__tagHelperScopeManager.End();
					views_Account_Error.WriteLiteral("\r\n        </div>\r\n        <div class=\"lead\">\r\n            <h2>");
					views_Account_Error.Write(views_Account_Error.T["Login Error"]);
					views_Account_Error.WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"alert alert-danger\">\r\n            ");
					views_Account_Error.Write(views_Account_Error.T["Sorry, there was an error"]);
					views_Account_Error.WriteLiteral("\r\n\r\n");
					if (views_Account_Error.Model.Error != null)
					{
						views_Account_Error.WriteLiteral("                <strong>\r\n                    <em>\r\n                        ");
						views_Account_Error.Write(views_Account_Error.Model.Error);
						views_Account_Error.WriteLiteral("\r\n                    </em>\r\n                </strong>\r\n");
						if (views_Account_Error.Model.ErrorDescription != null)
						{
							views_Account_Error.WriteLiteral("                    <div>");
							views_Account_Error.Write(views_Account_Error.Model.ErrorDescription);
							views_Account_Error.WriteLiteral(" </div>\r\n");
						}
					}
					views_Account_Error.WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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

			// Token: 0x06000A66 RID: 2662 RVA: 0x000467FC File Offset: 0x000449FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400081C RID: 2076
			public int <>1__state;

			// Token: 0x0400081D RID: 2077
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400081E RID: 2078
			public Views_Account_Error <>4__this;

			// Token: 0x0400081F RID: 2079
			private TaskAwaiter <>u__1;
		}
	}
}
