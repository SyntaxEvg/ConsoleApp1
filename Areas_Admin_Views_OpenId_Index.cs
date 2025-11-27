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
	// Token: 0x02000039 RID: 57
	[RazorSourceChecksum("SHA256", "14927698e9a7d76888476febea0889a775a56d1559f7069c16e60e00d061f4be", "/Areas/Admin/Views/OpenId/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/OpenId/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_OpenId_Index : BaseRazorPage<IEnumerable<OpenIdConfigViewModel>>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000AF87 File Offset: 0x00009187
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

		// Token: 0x06000249 RID: 585 RVA: 0x0000AFBC File Offset: 0x000091BC
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_OpenId_Index.<ExecuteAsync>d__9 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_OpenId_Index.<ExecuteAsync>d__9>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000AFFF File Offset: 0x000091FF
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0000B007 File Offset: 0x00009207
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000B010 File Offset: 0x00009210
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000B018 File Offset: 0x00009218
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000B021 File Offset: 0x00009221
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0000B029 File Offset: 0x00009229
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000B032 File Offset: 0x00009232
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000B03A File Offset: 0x0000923A
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000B043 File Offset: 0x00009243
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000B04B File Offset: 0x0000924B
		[RazorInject]
		public IHtmlHelper<IEnumerable<OpenIdConfigViewModel>> Html { get; private set; }

		// Token: 0x06000256 RID: 598 RVA: 0x0000B084 File Offset: 0x00009284
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_1()
		{
			Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_1>d <<ExecuteAsync>b__9_1>d;
			<<ExecuteAsync>b__9_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_1>d.<>4__this = this;
			<<ExecuteAsync>b__9_1>d.<>1__state = -1;
			<<ExecuteAsync>b__9_1>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_1>d>(ref <<ExecuteAsync>b__9_1>d);
			return <<ExecuteAsync>b__9_1>d.<>t__builder.Task;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B0C8 File Offset: 0x000092C8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_4()
		{
			Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_4>d <<ExecuteAsync>b__9_4>d;
			<<ExecuteAsync>b__9_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_4>d.<>4__this = this;
			<<ExecuteAsync>b__9_4>d.<>1__state = -1;
			<<ExecuteAsync>b__9_4>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_4>d>(ref <<ExecuteAsync>b__9_4>d);
			return <<ExecuteAsync>b__9_4>d.<>t__builder.Task;
		}

		// Token: 0x0400020F RID: 527
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000210 RID: 528
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000211 RID: 529
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000212 RID: 530
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000213 RID: 531
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000214 RID: 532
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000215 RID: 533
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_1>d : IAsyncStateMachine
		{
			// Token: 0x060009CE RID: 2510 RVA: 0x00039FC4 File Offset: 0x000381C4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Index areas_Admin_Views_OpenId_Index = this.<>4__this;
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
						areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n    ");
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Index.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "14927698e9a7d76888476febea0889a775a56d1559f7069c16e60e00d061f4be11457", new Func<Task>(areas_Admin_Views_OpenId_Index.<ExecuteAsync>b__9_4));
						areas_Admin_Views_OpenId_Index.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_OpenId_Index.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Index.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_OpenId_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_OpenId_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = areas_Admin_Views_OpenId_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_1>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Index.<<ExecuteAsync>b__9_1>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					areas_Admin_Views_OpenId_Index.Write(areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n");
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

			// Token: 0x060009CF RID: 2511 RVA: 0x0003A1B8 File Offset: 0x000383B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000759 RID: 1881
			public int <>1__state;

			// Token: 0x0400075A RID: 1882
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400075B RID: 1883
			public Areas_Admin_Views_OpenId_Index <>4__this;

			// Token: 0x0400075C RID: 1884
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200012A RID: 298
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_4>d : IAsyncStateMachine
		{
			// Token: 0x060009D0 RID: 2512 RVA: 0x0003A1C8 File Offset: 0x000383C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Index areas_Admin_Views_OpenId_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    ");
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

			// Token: 0x060009D1 RID: 2513 RVA: 0x0003A22C File Offset: 0x0003842C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400075D RID: 1885
			public int <>1__state;

			// Token: 0x0400075E RID: 1886
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400075F RID: 1887
			public Areas_Admin_Views_OpenId_Index <>4__this;
		}

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060009D4 RID: 2516 RVA: 0x0003A250 File Offset: 0x00038450
			internal Task <ExecuteAsync>b__9_0()
			{
				Areas_Admin_Views_OpenId_Index.<>c.<<ExecuteAsync>b__9_0>d <<ExecuteAsync>b__9_0>d;
				<<ExecuteAsync>b__9_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__9_0>d.<>1__state = -1;
				<<ExecuteAsync>b__9_0>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Index.<>c.<<ExecuteAsync>b__9_0>d>(ref <<ExecuteAsync>b__9_0>d);
				return <<ExecuteAsync>b__9_0>d.<>t__builder.Task;
			}

			// Token: 0x04000760 RID: 1888
			public static readonly Areas_Admin_Views_OpenId_Index.<>c <>9 = new Areas_Admin_Views_OpenId_Index.<>c();

			// Token: 0x04000761 RID: 1889
			public static Func<Task> <>9__9_0;

			// Token: 0x020002EF RID: 751
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__9_0>d : IAsyncStateMachine
			{
				// Token: 0x06000EEC RID: 3820 RVA: 0x000736FC File Offset: 0x000718FC
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

				// Token: 0x06000EED RID: 3821 RVA: 0x0007374C File Offset: 0x0007194C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E7F RID: 3711
				public int <>1__state;

				// Token: 0x04000E80 RID: 3712
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200012C RID: 300
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x04000762 RID: 1890
			public OpenIdConfigViewModel item;
		}

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x060009D6 RID: 2518 RVA: 0x0003A294 File Offset: 0x00038494
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Index areas_Admin_Views_OpenId_Index = this.<>4__this;
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
						areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>Open id configurations</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/openid/edit' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        ");
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "14927698e9a7d76888476febea0889a775a56d1559f7069c16e60e00d061f4be4321", new Func<Task>(Areas_Admin_Views_OpenId_Index.<>c.<>9.<ExecuteAsync>b__9_0));
						areas_Admin_Views_OpenId_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_OpenId_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_OpenId_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_OpenId_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Index.__tagHelperAttribute_0);
						awaiter2 = areas_Admin_Views_OpenId_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Index.<ExecuteAsync>d__9>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0193;
					}
					awaiter = areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Index.<ExecuteAsync>d__9>(ref awaiter, ref this);
						return;
					}
					IL_018C:
					awaiter.GetResult();
					IL_0193:
					areas_Admin_Views_OpenId_Index.Write(areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Index.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n");
					if (areas_Admin_Views_OpenId_Index.Model != null)
					{
						areas_Admin_Views_OpenId_Index.WriteLiteral("            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n\t\t\t\t\t\t<th></th>\r\n                        <th>\r\n                            Display name\r\n                        </th>\r\n                        <th>\r\n                            Enabled\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
						IEnumerator<OpenIdConfigViewModel> enumerator = areas_Admin_Views_OpenId_Index.Model.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0 CS$<>8__locals1 = new Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0();
								CS$<>8__locals1.item = enumerator.Current;
								areas_Admin_Views_OpenId_Index.WriteLiteral("                        <tr>\r\n\t\t\t\t\t\t\t<td><a");
								areas_Admin_Views_OpenId_Index.BeginWriteAttribute("href", " href='", 1115, "'", 1161, 1);
								RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Index;
								string text = "";
								int num2 = 1122;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
								defaultInterpolatedStringHandler.AppendLiteral("/uas/admin/openid/edit/");
								defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.item.Id);
								razorPageBase.WriteAttributeValue(text, num2, defaultInterpolatedStringHandler.ToStringAndClear(), 1122, 39, false);
								areas_Admin_Views_OpenId_Index.EndWriteAttribute();
								areas_Admin_Views_OpenId_Index.WriteLiteral(" title=\"Edit\"><i class=\"fa fa-edit\"></i></a></td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase2 = areas_Admin_Views_OpenId_Index;
								IHtmlHelper<IEnumerable<OpenIdConfigViewModel>> html = areas_Admin_Views_OpenId_Index.Html;
								ParameterExpression parameterExpression = Expression.Parameter(typeof(IEnumerable<OpenIdConfigViewModel>), "modelItem");
								razorPageBase2.Write(html.DisplayFor(Expression.Lambda<Func<IEnumerable<OpenIdConfigViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0.item)), methodof(OpenIdConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase3 = areas_Admin_Views_OpenId_Index;
								IHtmlHelper<IEnumerable<OpenIdConfigViewModel>> html2 = areas_Admin_Views_OpenId_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<OpenIdConfigViewModel>), "modelItem");
								razorPageBase3.Write(html2.DisplayFor(Expression.Lambda<Func<IEnumerable<OpenIdConfigViewModel>, bool>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_OpenId_Index.<>c__DisplayClass9_0.item)), methodof(OpenIdConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_OpenId_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Revoke\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Revoke\"\r\n                                                data-href=\"/uas/admin/openid/delete/");
								areas_Admin_Views_OpenId_Index.Write(CS$<>8__locals1.item.Id);
								areas_Admin_Views_OpenId_Index.WriteLiteral("\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n                            </td>\r\n                        </tr>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						areas_Admin_Views_OpenId_Index.WriteLiteral("                </tbody>\r\n            </table>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                            <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                                <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            Are you sure ?\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-bs-dis");
						areas_Admin_Views_OpenId_Index.WriteLiteral("miss=\"modal\">Cancel</button>\r\n                            <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
					}
					else
					{
						areas_Admin_Views_OpenId_Index.WriteLiteral("            <div class=\"text-center text-info\">There is no api keys </div>\r\n");
					}
					areas_Admin_Views_OpenId_Index.WriteLiteral("    </div>\r\n</div>\r\n");
					areas_Admin_Views_OpenId_Index.DefineSection("scripts", new RenderAsyncDelegate(areas_Admin_Views_OpenId_Index.<ExecuteAsync>b__9_1));
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

			// Token: 0x060009D7 RID: 2519 RVA: 0x0003A6F8 File Offset: 0x000388F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000763 RID: 1891
			public int <>1__state;

			// Token: 0x04000764 RID: 1892
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000765 RID: 1893
			public Areas_Admin_Views_OpenId_Index <>4__this;

			// Token: 0x04000766 RID: 1894
			private TaskAwaiter <>u__1;
		}
	}
}
