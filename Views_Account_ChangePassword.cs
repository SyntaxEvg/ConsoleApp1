using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using HAS.Server.TagHelpers;
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
	// Token: 0x02000043 RID: 67
	[RazorSourceChecksum("SHA256", "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda19", "/Views/Account/ChangePassword.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/ChangePassword.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_ChangePassword : BaseRazorPage<ChangePasswordViewModel>
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000C102 File Offset: 0x0000A302
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

		// Token: 0x060002E5 RID: 741 RVA: 0x0000C138 File Offset: 0x0000A338
		public override Task ExecuteAsync()
		{
			Views_Account_ChangePassword.<ExecuteAsync>d__20 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_ChangePassword.<ExecuteAsync>d__20>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000C17B File Offset: 0x0000A37B
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000C183 File Offset: 0x0000A383
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000C18C File Offset: 0x0000A38C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000C194 File Offset: 0x0000A394
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000C19D File Offset: 0x0000A39D
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000C1A5 File Offset: 0x0000A3A5
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000C1AE File Offset: 0x0000A3AE
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000C1BF File Offset: 0x0000A3BF
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		[RazorInject]
		public IHtmlHelper<ChangePasswordViewModel> Html { get; private set; }

		// Token: 0x060002F2 RID: 754 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__20_1()
		{
			Views_Account_ChangePassword.<<ExecuteAsync>b__20_1>d <<ExecuteAsync>b__20_1>d;
			<<ExecuteAsync>b__20_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__20_1>d.<>4__this = this;
			<<ExecuteAsync>b__20_1>d.<>1__state = -1;
			<<ExecuteAsync>b__20_1>d.<>t__builder.Start<Views_Account_ChangePassword.<<ExecuteAsync>b__20_1>d>(ref <<ExecuteAsync>b__20_1>d);
			return <<ExecuteAsync>b__20_1>d.<>t__builder.Task;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000C30C File Offset: 0x0000A50C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__20_11()
		{
			Views_Account_ChangePassword.<<ExecuteAsync>b__20_11>d <<ExecuteAsync>b__20_11>d;
			<<ExecuteAsync>b__20_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__20_11>d.<>4__this = this;
			<<ExecuteAsync>b__20_11>d.<>1__state = -1;
			<<ExecuteAsync>b__20_11>d.<>t__builder.Start<Views_Account_ChangePassword.<<ExecuteAsync>b__20_11>d>(ref <<ExecuteAsync>b__20_11>d);
			return <<ExecuteAsync>b__20_11>d.<>t__builder.Task;
		}

		// Token: 0x040002A3 RID: 675
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A4 RID: 676
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A5 RID: 677
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A6 RID: 678
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A7 RID: 679
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A8 RID: 680
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("form-control bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002A9 RID: 681
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002AA RID: 682
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("asp-route", "ChangePassword", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002AB RID: 683
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("class", new HtmlString("form-signin"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002AC RID: 684
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040002AD RID: 685
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040002AE RID: 686
		private string __tagHelperStringValueBuffer;

		// Token: 0x040002AF RID: 687
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040002B0 RID: 688
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x040002B1 RID: 689
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x040002B2 RID: 690
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x040002B3 RID: 691
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x040002B4 RID: 692
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x02000152 RID: 338
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__20_11>d : IAsyncStateMachine
		{
			// Token: 0x06000A53 RID: 2643 RVA: 0x000459F0 File Offset: 0x00043BF0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_ChangePassword views_Account_ChangePassword = this.<>4__this;
				try
				{
					views_Account_ChangePassword.WriteLiteral("\r\n        $(function () {\r\n\r\n            $('[data-bs-toggle=\"popover\"]').popover()\r\n\r\n            $(\"#show_hide_password_current a\").on('click', function (event) {\r\n                event.preventDefault();\r\n                if ($('#show_hide_password_current input').attr(\"type\") === \"text\") {\r\n                    $('#show_hide_password_current input').attr('type', 'password');\r\n                    $('#show_hide_password_icon_current').attr('data-icon', 'eye-slash');\r\n                } else if ($('#show_hide_password_current input').attr(\"type\") === \"password\") {\r\n                    $('#show_hide_password_current input').attr('type', 'text');\r\n                    $('#show_hide_password_icon_current').attr('data-icon', 'eye');\r\n                }\r\n            });\r\n\r\n            $(\"#show_hide_password a\").on('click', function (event) {\r\n                event.preventDefault();\r\n                if ($('#show_hide_password input').attr(\"type\") === \"text\") {\r\n                    $('#show_hide_password input').attr('typ");
					views_Account_ChangePassword.WriteLiteral("e', 'password');\r\n                    $('#show_hide_password_icon').attr('data-icon', 'eye-slash');\r\n                } else if ($('#show_hide_password input').attr(\"type\") === \"password\") {\r\n                    $('#show_hide_password input').attr('type', 'text');\r\n                    $('#show_hide_password_icon').attr('data-icon', 'eye');\r\n                }\r\n            });\r\n\r\n            $(\"#show_hide_password2 a\").on('click', function (event) {\r\n                event.preventDefault();\r\n                if ($('#show_hide_password2 input').attr(\"type\") === \"text\") {\r\n                    $('#show_hide_password2 input').attr('type', 'password');\r\n                    $('#show_hide_password_icon2').attr('data-icon', 'eye-slash');\r\n                } else if ($('#show_hide_password2 input').attr(\"type\") === \"password\") {\r\n                    $('#show_hide_password2 input').attr('type', 'text');\r\n                    $('#show_hide_password_icon2').attr('data-icon', 'eye');\r\n                }\r\n            });\r\n\r\n      ");
					views_Account_ChangePassword.WriteLiteral("      $(\"#Password1\").on('keyup', testNewPassword);\r\n            $(\"#Password1\").on('change', testNewPassword);\r\n        });\r\n\r\n        function testNewPassword() {\r\n            $.get(\"/uas/Account/TestPassword?password=\" + $(\"#Password1\").val()).done((result) => {\r\n                var elem = $(\"#newPasswordSecurity\");\r\n                elem.css(\"width\", getProgressWidth(result));\r\n                elem.removeClass('bg-success bg-danger bg-warning');\r\n                elem.addClass(getProgressColor(result));\r\n                elem.attr('aria-valuenow', result.score);\r\n            });\r\n        }\r\n\r\n        function getProgressWidth(result) {\r\n            let width = 0;\r\n\r\n            if (result.score <= 0)\r\n                width = 0;\r\n            else if (result.pass !== true)\r\n                width = result.score > 60 ? 60 : result.score;\r\n            else\r\n                width = result.score > 100 ? 100 : result.score;\r\n\r\n            return width + \"%\";\r\n        }\r\n\r\n        function getProgressColor(result) {\r");
					views_Account_ChangePassword.WriteLiteral("\n            if (result.score <= 0)\r\n                return \"bg-danger\"\r\n            return result.score > 60 && result.pass === true ? \"bg-success\" : \"bg-warning\";\r\n        }\r\n    ");
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

			// Token: 0x06000A54 RID: 2644 RVA: 0x00045A74 File Offset: 0x00043C74
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000807 RID: 2055
			public int <>1__state;

			// Token: 0x04000808 RID: 2056
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000809 RID: 2057
			public Views_Account_ChangePassword <>4__this;
		}

		// Token: 0x02000153 RID: 339
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__20_1>d : IAsyncStateMachine
		{
			// Token: 0x06000A55 RID: 2645 RVA: 0x00045A84 File Offset: 0x00043C84
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_ChangePassword views_Account_ChangePassword = this.<>4__this;
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
							goto IL_0166;
						}
						views_Account_ChangePassword.WriteLiteral("\r\n    ");
						views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1929862", new Func<Task>(views_Account_ChangePassword.<ExecuteAsync>b__20_11));
						views_Account_ChangePassword.__HAS_Server_TagHelpers_NonceTagHelper = views_Account_ChangePassword.CreateTagHelper<NonceTagHelper>();
						views_Account_ChangePassword.__tagHelperExecutionContext.Add(views_Account_ChangePassword.__HAS_Server_TagHelpers_NonceTagHelper);
						views_Account_ChangePassword.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						views_Account_ChangePassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", views_Account_ChangePassword.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_ChangePassword.__tagHelperRunner.RunAsync(views_Account_ChangePassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<<ExecuteAsync>b__20_1>d>(ref awaiter2, ref this);
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
					if (views_Account_ChangePassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = views_Account_ChangePassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<<ExecuteAsync>b__20_1>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					views_Account_ChangePassword.Write(views_Account_ChangePassword.__tagHelperExecutionContext.Output);
					views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.End();
					views_Account_ChangePassword.WriteLiteral("\r\n");
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

			// Token: 0x06000A56 RID: 2646 RVA: 0x00045C78 File Offset: 0x00043E78
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400080A RID: 2058
			public int <>1__state;

			// Token: 0x0400080B RID: 2059
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400080C RID: 2060
			public Views_Account_ChangePassword <>4__this;

			// Token: 0x0400080D RID: 2061
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000154 RID: 340
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A59 RID: 2649 RVA: 0x00045C9C File Offset: 0x00043E9C
			internal Task <ExecuteAsync>b__20_0()
			{
				Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_0>d <<ExecuteAsync>b__20_0>d;
				<<ExecuteAsync>b__20_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_0>d.<>1__state = -1;
				<<ExecuteAsync>b__20_0>d.<>t__builder.Start<Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_0>d>(ref <<ExecuteAsync>b__20_0>d);
				return <<ExecuteAsync>b__20_0>d.<>t__builder.Task;
			}

			// Token: 0x06000A5A RID: 2650 RVA: 0x00045CD8 File Offset: 0x00043ED8
			internal Task <ExecuteAsync>b__20_3()
			{
				Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_3>d <<ExecuteAsync>b__20_3>d;
				<<ExecuteAsync>b__20_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_3>d.<>1__state = -1;
				<<ExecuteAsync>b__20_3>d.<>t__builder.Start<Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_3>d>(ref <<ExecuteAsync>b__20_3>d);
				return <<ExecuteAsync>b__20_3>d.<>t__builder.Task;
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00045D14 File Offset: 0x00043F14
			internal Task <ExecuteAsync>b__20_5()
			{
				Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_5>d <<ExecuteAsync>b__20_5>d;
				<<ExecuteAsync>b__20_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_5>d.<>1__state = -1;
				<<ExecuteAsync>b__20_5>d.<>t__builder.Start<Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_5>d>(ref <<ExecuteAsync>b__20_5>d);
				return <<ExecuteAsync>b__20_5>d.<>t__builder.Task;
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00045D50 File Offset: 0x00043F50
			internal Task <ExecuteAsync>b__20_7()
			{
				Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_7>d <<ExecuteAsync>b__20_7>d;
				<<ExecuteAsync>b__20_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_7>d.<>1__state = -1;
				<<ExecuteAsync>b__20_7>d.<>t__builder.Start<Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_7>d>(ref <<ExecuteAsync>b__20_7>d);
				return <<ExecuteAsync>b__20_7>d.<>t__builder.Task;
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00045D8C File Offset: 0x00043F8C
			internal Task <ExecuteAsync>b__20_9()
			{
				Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_9>d <<ExecuteAsync>b__20_9>d;
				<<ExecuteAsync>b__20_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__20_9>d.<>1__state = -1;
				<<ExecuteAsync>b__20_9>d.<>t__builder.Start<Views_Account_ChangePassword.<>c.<<ExecuteAsync>b__20_9>d>(ref <<ExecuteAsync>b__20_9>d);
				return <<ExecuteAsync>b__20_9>d.<>t__builder.Task;
			}

			// Token: 0x0400080E RID: 2062
			public static readonly Views_Account_ChangePassword.<>c <>9 = new Views_Account_ChangePassword.<>c();

			// Token: 0x0400080F RID: 2063
			public static Func<Task> <>9__20_0;

			// Token: 0x04000810 RID: 2064
			public static Func<Task> <>9__20_3;

			// Token: 0x04000811 RID: 2065
			public static Func<Task> <>9__20_5;

			// Token: 0x04000812 RID: 2066
			public static Func<Task> <>9__20_7;

			// Token: 0x04000813 RID: 2067
			public static Func<Task> <>9__20_9;

			// Token: 0x02000328 RID: 808
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F5E RID: 3934 RVA: 0x00074C5C File Offset: 0x00072E5C
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

				// Token: 0x06000F5F RID: 3935 RVA: 0x00074CAC File Offset: 0x00072EAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EF1 RID: 3825
				public int <>1__state;

				// Token: 0x04000EF2 RID: 3826
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000329 RID: 809
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_3>d : IAsyncStateMachine
			{
				// Token: 0x06000F60 RID: 3936 RVA: 0x00074CBC File Offset: 0x00072EBC
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

				// Token: 0x06000F61 RID: 3937 RVA: 0x00074D0C File Offset: 0x00072F0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EF3 RID: 3827
				public int <>1__state;

				// Token: 0x04000EF4 RID: 3828
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200032A RID: 810
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_5>d : IAsyncStateMachine
			{
				// Token: 0x06000F62 RID: 3938 RVA: 0x00074D1C File Offset: 0x00072F1C
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

				// Token: 0x06000F63 RID: 3939 RVA: 0x00074D6C File Offset: 0x00072F6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EF5 RID: 3829
				public int <>1__state;

				// Token: 0x04000EF6 RID: 3830
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200032B RID: 811
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_7>d : IAsyncStateMachine
			{
				// Token: 0x06000F64 RID: 3940 RVA: 0x00074D7C File Offset: 0x00072F7C
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

				// Token: 0x06000F65 RID: 3941 RVA: 0x00074DCC File Offset: 0x00072FCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EF7 RID: 3831
				public int <>1__state;

				// Token: 0x04000EF8 RID: 3832
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200032C RID: 812
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__20_9>d : IAsyncStateMachine
			{
				// Token: 0x06000F66 RID: 3942 RVA: 0x00074DDC File Offset: 0x00072FDC
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

				// Token: 0x06000F67 RID: 3943 RVA: 0x00074E2C File Offset: 0x0007302C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EF9 RID: 3833
				public int <>1__state;

				// Token: 0x04000EFA RID: 3834
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000155 RID: 341
		[CompilerGenerated]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06000A5F RID: 2655 RVA: 0x00045DD0 File Offset: 0x00043FD0
			internal Task <ExecuteAsync>b__2()
			{
				Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d <<ExecuteAsync>b__2>d;
				<<ExecuteAsync>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__2>d.<>4__this = this;
				<<ExecuteAsync>b__2>d.<>1__state = -1;
				<<ExecuteAsync>b__2>d.<>t__builder.Start<Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref <<ExecuteAsync>b__2>d);
				return <<ExecuteAsync>b__2>d.<>t__builder.Task;
			}

			// Token: 0x04000814 RID: 2068
			public string content;

			// Token: 0x04000815 RID: 2069
			public Views_Account_ChangePassword <>4__this;

			// Token: 0x0200032D RID: 813
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__2>d : IAsyncStateMachine
			{
				// Token: 0x06000F68 RID: 3944 RVA: 0x00074E3C File Offset: 0x0007303C
				void IAsyncStateMachine.MoveNext()
				{
					int num = this.<>1__state;
					Views_Account_ChangePassword.<>c__DisplayClass20_0 CS$<>8__locals1 = this.<>4__this;
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
						ParameterExpression parameterExpression;
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
							goto IL_0260;
						case 2:
							awaiter3 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_055E;
						case 3:
							awaiter4 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_05DD;
						case 4:
							awaiter5 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_091B;
						case 5:
							awaiter6 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_099A;
						case 6:
							awaiter7 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_0C86;
						case 7:
							awaiter8 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							this.<>1__state = -1;
							goto IL_0D05;
						default:
						{
							CS$<>8__locals1.<>4__this.WriteLiteral("\r\n                ");
							CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1913696", new Func<Task>(Views_Account_ChangePassword.<>c.<>9.<ExecuteAsync>b__20_3));
							CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CS$<>8__locals1.<>4__this.CreateTagHelper<InputTagHelper>();
							CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Add(CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
							InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
							IModelExpressionProvider modelExpressionProvider = CS$<>8__locals1.<>4__this.ModelExpressionProvider;
							ViewDataDictionary<ChangePasswordViewModel> viewData = CS$<>8__locals1.<>4__this.ViewData;
							parameterExpression = Expression.Parameter(typeof(ChangePasswordViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<ChangePasswordViewModel, string>(viewData, Expression.Lambda<Func<ChangePasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(ChangePasswordViewModel.get_ReturnUrl())), new ParameterExpression[] { parameterExpression }));
							CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_ChangePassword.__tagHelperAttribute_3.Value;
							CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_3);
							awaiter = CS$<>8__locals1.<>4__this.__tagHelperRunner.RunAsync(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter, ref this);
								return;
							}
							break;
						}
						}
						awaiter.GetResult();
						if (CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0267;
						}
						awaiter2 = CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 1;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter2, ref this);
							return;
						}
						IL_0260:
						awaiter2.GetResult();
						IL_0267:
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.End();
						CS$<>8__locals1.<>4__this.WriteLiteral("\r\n\r\n                <div class=\"form-group my-4 mx-5 text-start\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><label class=\"mx-2 my-1\">");
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.T["Current password"]);
						CS$<>8__locals1.<>4__this.WriteLiteral("</label></div>\r\n                    <div class=\"input-group\" id=\"show_hide_password\">\r\n                        ");
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1915994", new Func<Task>(Views_Account_ChangePassword.<>c.<>9.<ExecuteAsync>b__20_5));
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CS$<>8__locals1.<>4__this.CreateTagHelper<InputTagHelper>();
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Add(CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider2 = CS$<>8__locals1.<>4__this.ModelExpressionProvider;
						ViewDataDictionary<ChangePasswordViewModel> viewData2 = CS$<>8__locals1.<>4__this.ViewData;
						parameterExpression = Expression.Parameter(typeof(ChangePasswordViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<ChangePasswordViewModel, string>(viewData2, Expression.Lambda<Func<ChangePasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(ChangePasswordViewModel.get_CurrentPassword())), new ParameterExpression[] { parameterExpression }));
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_ChangePassword.__tagHelperAttribute_4.Value;
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_4);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_5);
						CS$<>8__locals1.<>4__this.BeginWriteTagHelperAttribute();
						CS$<>8__locals1.<>4__this.__tagHelperStringValueBuffer = CS$<>8__locals1.<>4__this.EndWriteTagHelperAttribute();
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute("autofocus", CS$<>8__locals1.<>4__this.Html.Raw(CS$<>8__locals1.<>4__this.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_6);
						CS$<>8__locals1.<>4__this.BeginAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.AddHtmlAttributeValue("", 2508, CS$<>8__locals1.<>4__this.T["Current password"], 2508, 22, false);
						CS$<>8__locals1.<>4__this.EndAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext);
						awaiter3 = CS$<>8__locals1.<>4__this.__tagHelperRunner.RunAsync(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							this.<>1__state = 2;
							this.<>u__1 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter3, ref this);
							return;
						}
						IL_055E:
						awaiter3.GetResult();
						if (CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_05E4;
						}
						awaiter4 = CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							this.<>1__state = 3;
							this.<>u__1 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter4, ref this);
							return;
						}
						IL_05DD:
						awaiter4.GetResult();
						IL_05E4:
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.End();
						CS$<>8__locals1.<>4__this.WriteLiteral("\r\n                        <a class=\"input-group-text eye\"");
						CS$<>8__locals1.<>4__this.BeginWriteAttribute("href", " href=\"", 2591, "\"", 2598, 0);
						CS$<>8__locals1.<>4__this.EndWriteAttribute();
						CS$<>8__locals1.<>4__this.WriteLiteral(" >\r\n                            <i id=\"show_hide_password_icon_current\" class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group my-4 mx-5 text-start\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><label class=\"mx-2 my-1\" >");
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.T["New password"]);
						CS$<>8__locals1.<>4__this.WriteLiteral("</label></div>\r\n                    <div class=\"input-group\" id=\"show_hide_password\">\r\n                        ");
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1919732", new Func<Task>(Views_Account_ChangePassword.<>c.<>9.<ExecuteAsync>b__20_7));
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CS$<>8__locals1.<>4__this.CreateTagHelper<InputTagHelper>();
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Add(CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider3 = CS$<>8__locals1.<>4__this.ModelExpressionProvider;
						ViewDataDictionary<ChangePasswordViewModel> viewData3 = CS$<>8__locals1.<>4__this.ViewData;
						parameterExpression = Expression.Parameter(typeof(ChangePasswordViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<ChangePasswordViewModel, string>(viewData3, Expression.Lambda<Func<ChangePasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(ChangePasswordViewModel.get_Password1())), new ParameterExpression[] { parameterExpression }));
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_ChangePassword.__tagHelperAttribute_4.Value;
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_4);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_5);
						CS$<>8__locals1.<>4__this.BeginWriteTagHelperAttribute();
						CS$<>8__locals1.<>4__this.__tagHelperStringValueBuffer = CS$<>8__locals1.<>4__this.EndWriteTagHelperAttribute();
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute("autofocus", CS$<>8__locals1.<>4__this.Html.Raw(CS$<>8__locals1.<>4__this.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_6);
						CS$<>8__locals1.<>4__this.BeginAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.AddHtmlAttributeValue("", 3200, CS$<>8__locals1.<>4__this.T["New password"], 3200, 18, false);
						CS$<>8__locals1.<>4__this.EndAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext);
						awaiter5 = CS$<>8__locals1.<>4__this.__tagHelperRunner.RunAsync(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							this.<>1__state = 4;
							this.<>u__1 = awaiter5;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter5, ref this);
							return;
						}
						IL_091B:
						awaiter5.GetResult();
						if (CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_09A1;
						}
						awaiter6 = CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter6.IsCompleted)
						{
							this.<>1__state = 5;
							this.<>u__1 = awaiter6;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter6, ref this);
							return;
						}
						IL_099A:
						awaiter6.GetResult();
						IL_09A1:
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.End();
						CS$<>8__locals1.<>4__this.WriteLiteral("\r\n                        <a class=\"input-group-text eye\"");
						CS$<>8__locals1.<>4__this.BeginWriteAttribute("href", " href=\"", 3279, "\"", 3286, 0);
						CS$<>8__locals1.<>4__this.EndWriteAttribute();
						CS$<>8__locals1.<>4__this.WriteLiteral(" >\r\n                            <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"progress my-2 shodow-sm\">\r\n                        <div class=\"progress-bar\" id=\"newPasswordSecurity\" role=\"progressbar\" style=\"width: 0%\" aria-valuenow=\"0\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group my-4 mx-5 text-start\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><label class=\"mx-2 my-1\">");
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.T["Re enter new password"]);
						CS$<>8__locals1.<>4__this.WriteLiteral("</label></div>\r\n                    <div class=\"input-group\" id=\"show_hide_password2\">\r\n                        ");
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1923740", new Func<Task>(Views_Account_ChangePassword.<>c.<>9.<ExecuteAsync>b__20_9));
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CS$<>8__locals1.<>4__this.CreateTagHelper<InputTagHelper>();
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Add(CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider4 = CS$<>8__locals1.<>4__this.ModelExpressionProvider;
						ViewDataDictionary<ChangePasswordViewModel> viewData4 = CS$<>8__locals1.<>4__this.ViewData;
						parameterExpression = Expression.Parameter(typeof(ChangePasswordViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider4.CreateModelExpression<ChangePasswordViewModel, string>(viewData4, Expression.Lambda<Func<ChangePasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(ChangePasswordViewModel.get_Password2())), new ParameterExpression[] { parameterExpression }));
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_ChangePassword.__tagHelperAttribute_4.Value;
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_4);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_5);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_6);
						CS$<>8__locals1.<>4__this.BeginAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
						CS$<>8__locals1.<>4__this.AddHtmlAttributeValue("", 4142, CS$<>8__locals1.<>4__this.T["Re enter new password"], 4142, 27, false);
						CS$<>8__locals1.<>4__this.EndAddHtmlAttributeValues(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext);
						awaiter7 = CS$<>8__locals1.<>4__this.__tagHelperRunner.RunAsync(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter7.IsCompleted)
						{
							this.<>1__state = 6;
							this.<>u__1 = awaiter7;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter7, ref this);
							return;
						}
						IL_0C86:
						awaiter7.GetResult();
						if (CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0D0C;
						}
						awaiter8 = CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter8.IsCompleted)
						{
							this.<>1__state = 7;
							this.<>u__1 = awaiter8;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<>c__DisplayClass20_0.<<ExecuteAsync>b__2>d>(ref awaiter8, ref this);
							return;
						}
						IL_0D05:
						awaiter8.GetResult();
						IL_0D0C:
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.__tagHelperExecutionContext.Output);
						CS$<>8__locals1.<>4__this.__tagHelperExecutionContext = CS$<>8__locals1.<>4__this.__tagHelperScopeManager.End();
						CS$<>8__locals1.<>4__this.WriteLiteral("\r\n                        <a class=\"input-group-text eye\"");
						CS$<>8__locals1.<>4__this.BeginWriteAttribute("href", " href=\"", 4230, "\"", 4237, 0);
						CS$<>8__locals1.<>4__this.EndWriteAttribute();
						CS$<>8__locals1.<>4__this.WriteLiteral(" >\r\n                            <i id=\"show_hide_password_icon2\" class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n                <a href=\"#\" data-bs-toggle=\"popover\" data-bs-html=\"true\" data-bs-trigger=\"hover\" title=\"Password policy\" data-bs-content=\"");
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.content);
						CS$<>8__locals1.<>4__this.WriteLiteral("\">Password policy</a>\r\n                <button class=\"btn btn-hopex btn-success\" type=\"submit\" id=\"btnSubmit\">");
						CS$<>8__locals1.<>4__this.Write(CS$<>8__locals1.<>4__this.T["Change password"]);
						CS$<>8__locals1.<>4__this.WriteLiteral("</button>\r\n            ");
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

				// Token: 0x06000F69 RID: 3945 RVA: 0x00075C78 File Offset: 0x00073E78
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EFB RID: 3835
				public int <>1__state;

				// Token: 0x04000EFC RID: 3836
				public AsyncTaskMethodBuilder <>t__builder;

				// Token: 0x04000EFD RID: 3837
				public Views_Account_ChangePassword.<>c__DisplayClass20_0 <>4__this;

				// Token: 0x04000EFE RID: 3838
				private TaskAwaiter <>u__1;
			}
		}

		// Token: 0x02000156 RID: 342
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__20 : IAsyncStateMachine
		{
			// Token: 0x06000A60 RID: 2656 RVA: 0x00045E14 File Offset: 0x00044014
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_ChangePassword views_Account_ChangePassword = this.<>4__this;
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
						goto IL_0518;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_058D;
					default:
						views_Account_ChangePassword.WriteLiteral("<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda197421", new Func<Task>(Views_Account_ChangePassword.<>c.<>9.<ExecuteAsync>b__20_0));
						views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_ChangePassword.CreateTagHelper<ImageTagHelper>();
						views_Account_ChangePassword.__tagHelperExecutionContext.Add(views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_ChangePassword.__tagHelperAttribute_0.Value;
						views_Account_ChangePassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_0);
						views_Account_ChangePassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_1);
						views_Account_ChangePassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_2);
						views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_ChangePassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Account_ChangePassword.__tagHelperRunner.RunAsync(views_Account_ChangePassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<ExecuteAsync>d__20>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Account_ChangePassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01D6;
					}
					awaiter2 = views_Account_ChangePassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<ExecuteAsync>d__20>(ref awaiter2, ref this);
						return;
					}
					IL_01CF:
					awaiter2.GetResult();
					IL_01D6:
					views_Account_ChangePassword.Write(views_Account_ChangePassword.__tagHelperExecutionContext.Output);
					views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.End();
					views_Account_ChangePassword.WriteLiteral("\r\n        </div>\r\n\r\n");
					if (views_Account_ChangePassword.Model.Success)
					{
						views_Account_ChangePassword.WriteLiteral("            <div class=\"alert alert-success mx-2\">\r\n                <div class=\"alert-success\">\r\n                    ");
						views_Account_ChangePassword.Write(views_Account_ChangePassword.T["Password has been changed successfully"]);
						views_Account_ChangePassword.WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <div class=\"text-center mb-4 mt-1\">\r\n                <a");
						views_Account_ChangePassword.BeginWriteAttribute("href", " href=\"", 615, "\"", 638, 1);
						views_Account_ChangePassword.WriteAttributeValue("", 622, views_Account_ChangePassword.Model.ReturnUrl, 622, 16, false);
						views_Account_ChangePassword.EndWriteAttribute();
						views_Account_ChangePassword.WriteLiteral(" class=\"btn btn-hopex btn-success\">\r\n                    ");
						views_Account_ChangePassword.Write(views_Account_ChangePassword.T["Sign in with new password"]);
						views_Account_ChangePassword.WriteLiteral("\r\n                </a>\r\n            </div>\r\n");
						goto IL_05C1;
					}
					Views_Account_ChangePassword.<>c__DisplayClass20_0 CS$<>8__locals1 = new Views_Account_ChangePassword.<>c__DisplayClass20_0();
					CS$<>8__locals1.<>4__this = views_Account_ChangePassword;
					CS$<>8__locals1.content = string.Concat(new string[]
					{
						"The password must:<br/>\r\n        <ul>\r\n        <li>include at least ",
						views_Account_ChangePassword.Model.Settings.RequiredLength.ToString(),
						" characters",
						views_Account_ChangePassword.Model.Settings.RequireUppercase ? ", one uppercase" : "",
						views_Account_ChangePassword.Model.Settings.RequireLowercase ? ", one lowercase" : "",
						views_Account_ChangePassword.Model.Settings.RequireDigit ? ", one digit" : "",
						views_Account_ChangePassword.Model.Settings.RequireNonAlphanumeric ? ", one special character" : "",
						"</li>\r\n        <li>not use any sequence of characters (e.g; 12345, qwert) nor contextual words (e.g.: hopex, mega)</li>\r\n        <li>be complex enough to meet your enterprise security requirements</li>\r\n        </ul>\r\n        "
					});
					views_Account_ChangePassword.WriteLiteral("            <p class=\"text-center\">");
					views_Account_ChangePassword.Write(views_Account_ChangePassword.T["Use the form below to change password for"]);
					views_Account_ChangePassword.WriteLiteral(" ");
					views_Account_ChangePassword.Write(views_Account_ChangePassword.Model.UserName);
					views_Account_ChangePassword.WriteLiteral(".</p>\r\n");
					if (views_Account_ChangePassword.Model.ErrorMessage != null)
					{
						views_Account_ChangePassword.WriteLiteral("                <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                    <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                    <div class=\"col\">\r\n                        ");
						views_Account_ChangePassword.Write(views_Account_ChangePassword.Model.ErrorMessage);
						views_Account_ChangePassword.WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
					}
					views_Account_ChangePassword.WriteLiteral("            ");
					views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "7f33fc37c8eab86555d977856f6ede71d3d5725d7fce879482c2bbfac1adda1913397", new Func<Task>(CS$<>8__locals1.<ExecuteAsync>b__2));
					views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = views_Account_ChangePassword.CreateTagHelper<FormTagHelper>();
					views_Account_ChangePassword.__tagHelperExecutionContext.Add(views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = views_Account_ChangePassword.CreateTagHelper<RenderAtEndOfFormTagHelper>();
					views_Account_ChangePassword.__tagHelperExecutionContext.Add(views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					views_Account_ChangePassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)Views_Account_ChangePassword.__tagHelperAttribute_7.Value;
					views_Account_ChangePassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_ChangePassword.__tagHelperAttribute_7);
					views_Account_ChangePassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_ChangePassword.__tagHelperAttribute_8);
					awaiter3 = views_Account_ChangePassword.__tagHelperRunner.RunAsync(views_Account_ChangePassword.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<ExecuteAsync>d__20>(ref awaiter3, ref this);
						return;
					}
					IL_0518:
					awaiter3.GetResult();
					if (views_Account_ChangePassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0594;
					}
					awaiter4 = views_Account_ChangePassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_ChangePassword.<ExecuteAsync>d__20>(ref awaiter4, ref this);
						return;
					}
					IL_058D:
					awaiter4.GetResult();
					IL_0594:
					views_Account_ChangePassword.Write(views_Account_ChangePassword.__tagHelperExecutionContext.Output);
					views_Account_ChangePassword.__tagHelperExecutionContext = views_Account_ChangePassword.__tagHelperScopeManager.End();
					views_Account_ChangePassword.WriteLiteral("\r\n");
					IL_05C1:
					views_Account_ChangePassword.WriteLiteral("        <div class=\"mt-5 footer w-100 show-v6 text-dark\" style=\"display:none;\">\r\n            <label class=\"mb-3\">\r\n                ");
					RazorPageBase razorPageBase = views_Account_ChangePassword;
					ChangePasswordViewModel model = views_Account_ChangePassword.Model;
					razorPageBase.Write((model != null) ? model.MegaInfo : null);
					views_Account_ChangePassword.WriteLiteral(" <br>\r\n                <a class=\"text-white privacy-link\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#privacyModal\">");
					views_Account_ChangePassword.Write(views_Account_ChangePassword.T["Privacy and Cookie Policy"]);
					views_Account_ChangePassword.WriteLiteral("</a>\r\n            </label>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
					views_Account_ChangePassword.DefineSection("Scripts", new RenderAsyncDelegate(views_Account_ChangePassword.<ExecuteAsync>b__20_1));
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

			// Token: 0x06000A61 RID: 2657 RVA: 0x00046494 File Offset: 0x00044694
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000816 RID: 2070
			public int <>1__state;

			// Token: 0x04000817 RID: 2071
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000818 RID: 2072
			public Views_Account_ChangePassword <>4__this;

			// Token: 0x04000819 RID: 2073
			private TaskAwaiter <>u__1;
		}
	}
}
