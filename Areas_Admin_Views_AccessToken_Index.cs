using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using HAS.Server.TagHelpers;
using Mega.Has.Modules.UAS.Areas.Admin.ViewModels;
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
	// Token: 0x02000031 RID: 49
	[RazorSourceChecksum("SHA256", "7afa080131e4066af381311638e5724ff707e887b6ad95e641cde14881a9db63", "/Areas/Admin/Views/AccessToken/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/AccessToken/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_AccessToken_Index : BaseRazorPage<IEnumerable<AccessTokenViewModel>>
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000988B File Offset: 0x00007A8B
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

		// Token: 0x060001BA RID: 442 RVA: 0x000098C0 File Offset: 0x00007AC0
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_AccessToken_Index.<ExecuteAsync>d__9 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_AccessToken_Index.<ExecuteAsync>d__9>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00009903 File Offset: 0x00007B03
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000990B File Offset: 0x00007B0B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00009914 File Offset: 0x00007B14
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000991C File Offset: 0x00007B1C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00009925 File Offset: 0x00007B25
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000992D File Offset: 0x00007B2D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00009936 File Offset: 0x00007B36
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000993E File Offset: 0x00007B3E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00009947 File Offset: 0x00007B47
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000994F File Offset: 0x00007B4F
		[RazorInject]
		public IHtmlHelper<IEnumerable<AccessTokenViewModel>> Html { get; private set; }

		// Token: 0x060001C7 RID: 455 RVA: 0x00009988 File Offset: 0x00007B88
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_4()
		{
			Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_4>d <<ExecuteAsync>b__9_4>d;
			<<ExecuteAsync>b__9_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_4>d.<>4__this = this;
			<<ExecuteAsync>b__9_4>d.<>1__state = -1;
			<<ExecuteAsync>b__9_4>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_4>d>(ref <<ExecuteAsync>b__9_4>d);
			return <<ExecuteAsync>b__9_4>d.<>t__builder.Task;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000099CC File Offset: 0x00007BCC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_8()
		{
			Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_8>d <<ExecuteAsync>b__9_8>d;
			<<ExecuteAsync>b__9_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_8>d.<>4__this = this;
			<<ExecuteAsync>b__9_8>d.<>1__state = -1;
			<<ExecuteAsync>b__9_8>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_8>d>(ref <<ExecuteAsync>b__9_8>d);
			return <<ExecuteAsync>b__9_8>d.<>t__builder.Task;
		}

		// Token: 0x04000155 RID: 341
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000156 RID: 342
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000157 RID: 343
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000158 RID: 344
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000159 RID: 345
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400015A RID: 346
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x0400015B RID: 347
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x020000F5 RID: 245
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_4>d : IAsyncStateMachine
		{
			// Token: 0x0600090E RID: 2318 RVA: 0x000276F4 File Offset: 0x000258F4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Index areas_Admin_Views_AccessToken_Index = this.<>4__this;
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
						areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n    ");
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Index.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "7afa080131e4066af381311638e5724ff707e887b6ad95e641cde14881a9db6314341", new Func<Task>(areas_Admin_Views_AccessToken_Index.<ExecuteAsync>b__9_8));
						areas_Admin_Views_AccessToken_Index.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_AccessToken_Index.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Index.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_AccessToken_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_AccessToken_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = areas_Admin_Views_AccessToken_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_4>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Index.<<ExecuteAsync>b__9_4>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					areas_Admin_Views_AccessToken_Index.Write(areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n");
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

			// Token: 0x0600090F RID: 2319 RVA: 0x000278E8 File Offset: 0x00025AE8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000664 RID: 1636
			public int <>1__state;

			// Token: 0x04000665 RID: 1637
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000666 RID: 1638
			public Areas_Admin_Views_AccessToken_Index <>4__this;

			// Token: 0x04000667 RID: 1639
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000F6 RID: 246
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_8>d : IAsyncStateMachine
		{
			// Token: 0x06000910 RID: 2320 RVA: 0x000278F8 File Offset: 0x00025AF8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Index areas_Admin_Views_AccessToken_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    ");
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

			// Token: 0x06000911 RID: 2321 RVA: 0x0002795C File Offset: 0x00025B5C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000668 RID: 1640
			public int <>1__state;

			// Token: 0x04000669 RID: 1641
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400066A RID: 1642
			public Areas_Admin_Views_AccessToken_Index <>4__this;
		}

		// Token: 0x020000F7 RID: 247
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000914 RID: 2324 RVA: 0x00027980 File Offset: 0x00025B80
			internal Task <ExecuteAsync>b__9_0()
			{
				Areas_Admin_Views_AccessToken_Index.<>c.<<ExecuteAsync>b__9_0>d <<ExecuteAsync>b__9_0>d;
				<<ExecuteAsync>b__9_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__9_0>d.<>1__state = -1;
				<<ExecuteAsync>b__9_0>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Index.<>c.<<ExecuteAsync>b__9_0>d>(ref <<ExecuteAsync>b__9_0>d);
				return <<ExecuteAsync>b__9_0>d.<>t__builder.Task;
			}

			// Token: 0x0400066B RID: 1643
			public static readonly Areas_Admin_Views_AccessToken_Index.<>c <>9 = new Areas_Admin_Views_AccessToken_Index.<>c();

			// Token: 0x0400066C RID: 1644
			public static Func<Task> <>9__9_0;

			// Token: 0x02000294 RID: 660
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__9_0>d : IAsyncStateMachine
			{
				// Token: 0x06000E36 RID: 3638 RVA: 0x000714DC File Offset: 0x0006F6DC
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

				// Token: 0x06000E37 RID: 3639 RVA: 0x0007152C File Offset: 0x0006F72C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DC9 RID: 3529
				public int <>1__state;

				// Token: 0x04000DCA RID: 3530
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x020000F8 RID: 248
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0400066D RID: 1645
			public AccessTokenViewModel item;
		}

		// Token: 0x020000F9 RID: 249
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x06000916 RID: 2326 RVA: 0x000279C4 File Offset: 0x00025BC4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Index areas_Admin_Views_AccessToken_Index = this.<>4__this;
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
							num = (this.<>1__state = -1);
							goto IL_018C;
						}
						areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>User accounts</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/accesstoken/create' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        ");
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "7afa080131e4066af381311638e5724ff707e887b6ad95e641cde14881a9db634348", new Func<Task>(Areas_Admin_Views_AccessToken_Index.<>c.<>9.<ExecuteAsync>b__9_0));
						areas_Admin_Views_AccessToken_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_AccessToken_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_AccessToken_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_AccessToken_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Index.__tagHelperAttribute_0);
						awaiter2 = areas_Admin_Views_AccessToken_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Index.<ExecuteAsync>d__9>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
					}
					awaiter2.GetResult();
					if (areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0193;
					}
					awaiter = areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Index.<ExecuteAsync>d__9>(ref awaiter, ref this);
						return;
					}
					IL_018C:
					awaiter.GetResult();
					IL_0193:
					areas_Admin_Views_AccessToken_Index.Write(areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Index.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n");
					if (areas_Admin_Views_AccessToken_Index.Model != null)
					{
						areas_Admin_Views_AccessToken_Index.WriteLiteral("            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase = areas_Admin_Views_AccessToken_Index;
						IHtmlHelper<IEnumerable<AccessTokenViewModel>> html = areas_Admin_Views_AccessToken_Index.Html;
						ParameterExpression parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "model");
						razorPageBase.Write(html.DisplayNameFor(Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase2 = areas_Admin_Views_AccessToken_Index;
						IHtmlHelper<IEnumerable<AccessTokenViewModel>> html2 = areas_Admin_Views_AccessToken_Index.Html;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "model");
						razorPageBase2.Write(html2.DisplayNameFor(Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase3 = areas_Admin_Views_AccessToken_Index;
						IHtmlHelper<IEnumerable<AccessTokenViewModel>> html3 = areas_Admin_Views_AccessToken_Index.Html;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "model");
						razorPageBase3.Write(html3.DisplayNameFor(Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
						IEnumerator<AccessTokenViewModel> enumerator = areas_Admin_Views_AccessToken_Index.Model.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0 CS$<>8__locals1 = new Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0();
								CS$<>8__locals1.item = enumerator.Current;
								areas_Admin_Views_AccessToken_Index.WriteLiteral("                        <tr");
								areas_Admin_Views_AccessToken_Index.BeginWriteAttribute("class", " class=\"", 1331, "\"", 1376, 1);
								areas_Admin_Views_AccessToken_Index.WriteAttributeValue("", 1339, CS$<>8__locals1.item.IsExpired ? "bg-warning" : "", 1339, 37, false);
								areas_Admin_Views_AccessToken_Index.EndWriteAttribute();
								areas_Admin_Views_AccessToken_Index.WriteLiteral(">\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase4 = areas_Admin_Views_AccessToken_Index;
								IHtmlHelper<IEnumerable<AccessTokenViewModel>> html4 = areas_Admin_Views_AccessToken_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<AccessTokenViewModel>), "modelItem");
								razorPageBase4.Write(html4.DisplayFor(Expression.Lambda<Func<IEnumerable<AccessTokenViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0.item)), methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase5 = areas_Admin_Views_AccessToken_Index;
								IHtmlHelper<IEnumerable<AccessTokenViewModel>> html5 = areas_Admin_Views_AccessToken_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<AccessTokenViewModel>), "modelItem");
								razorPageBase5.Write(html5.DisplayFor(Expression.Lambda<Func<IEnumerable<AccessTokenViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0.item)), methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase6 = areas_Admin_Views_AccessToken_Index;
								IHtmlHelper<IEnumerable<AccessTokenViewModel>> html6 = areas_Admin_Views_AccessToken_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<AccessTokenViewModel>), "modelItem");
								razorPageBase6.Write(html6.DisplayFor(Expression.Lambda<Func<IEnumerable<AccessTokenViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_AccessToken_Index.<>c__DisplayClass9_0.item)), methodof(InputAccessTokenViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_AccessToken_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Edit\">\r\n                                    <a");
								areas_Admin_Views_AccessToken_Index.BeginWriteAttribute("href", " href=\"", 2002, "\"", 2045, 2);
								areas_Admin_Views_AccessToken_Index.WriteAttributeValue("", 2009, "/uas/admin/accesstoken/Edit/", 2009, 28, true);
								areas_Admin_Views_AccessToken_Index.WriteAttributeValue("", 2037, CS$<>8__locals1.item.Id, 2037, 8, false);
								areas_Admin_Views_AccessToken_Index.EndWriteAttribute();
								areas_Admin_Views_AccessToken_Index.WriteLiteral(">\r\n                                        <span class=\"fa fa-edit mx-2\"></span>\r\n                                    </a>\r\n                                </p>\r\n                            </td>\r\n                            <td>\r\n");
								if (CS$<>8__locals1.item.TokenName != "admin")
								{
									areas_Admin_Views_AccessToken_Index.WriteLiteral("                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Revoke\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Revoke\"\r\n                                                data-href=\"/uas/admin/accesstoken/delete/");
									areas_Admin_Views_AccessToken_Index.Write(CS$<>8__locals1.item.Id);
									areas_Admin_Views_AccessToken_Index.WriteLiteral("\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n");
								}
								areas_Admin_Views_AccessToken_Index.WriteLiteral("                            </td>\r\n                        </tr>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						areas_Admin_Views_AccessToken_Index.WriteLiteral("                </tbody>\r\n            </table>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                            <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                                <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            Are you sure ?\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-bs-dis");
						areas_Admin_Views_AccessToken_Index.WriteLiteral("miss=\"modal\">Cancel</button>\r\n                            <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
					}
					else
					{
						areas_Admin_Views_AccessToken_Index.WriteLiteral("            <div class=\"text-center text-info\">There is no user accounts </div>\r\n");
					}
					areas_Admin_Views_AccessToken_Index.WriteLiteral("    </div>\r\n</div>\r\n");
					areas_Admin_Views_AccessToken_Index.DefineSection("scripts", new RenderAsyncDelegate(areas_Admin_Views_AccessToken_Index.<ExecuteAsync>b__9_4));
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

			// Token: 0x06000917 RID: 2327 RVA: 0x00028034 File Offset: 0x00026234
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400066E RID: 1646
			public int <>1__state;

			// Token: 0x0400066F RID: 1647
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000670 RID: 1648
			public Areas_Admin_Views_AccessToken_Index <>4__this;

			// Token: 0x04000671 RID: 1649
			private TaskAwaiter <>u__1;
		}
	}
}
