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
	// Token: 0x0200003B RID: 59
	[RazorSourceChecksum("SHA256", "74bff481fd1675c47db0d9be712b7aa1fe147335d1acd8d594bb41ad8cd611ab", "/Areas/Admin/Views/SAML2/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/SAML2/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_SAML2_Index : BaseRazorPage<IEnumerable<Saml2ConfigViewModel>>
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000B4D7 File Offset: 0x000096D7
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

		// Token: 0x0600026E RID: 622 RVA: 0x0000B50C File Offset: 0x0000970C
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_SAML2_Index.<ExecuteAsync>d__9 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_SAML2_Index.<ExecuteAsync>d__9>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000B54F File Offset: 0x0000974F
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000B557 File Offset: 0x00009757
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000B560 File Offset: 0x00009760
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000B568 File Offset: 0x00009768
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000B571 File Offset: 0x00009771
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000B579 File Offset: 0x00009779
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000B582 File Offset: 0x00009782
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000B58A File Offset: 0x0000978A
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000B593 File Offset: 0x00009793
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000B59B File Offset: 0x0000979B
		[RazorInject]
		public IHtmlHelper<IEnumerable<Saml2ConfigViewModel>> Html { get; private set; }

		// Token: 0x0600027B RID: 635 RVA: 0x0000B5D4 File Offset: 0x000097D4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_1()
		{
			Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_1>d <<ExecuteAsync>b__9_1>d;
			<<ExecuteAsync>b__9_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_1>d.<>4__this = this;
			<<ExecuteAsync>b__9_1>d.<>1__state = -1;
			<<ExecuteAsync>b__9_1>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_1>d>(ref <<ExecuteAsync>b__9_1>d);
			return <<ExecuteAsync>b__9_1>d.<>t__builder.Task;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000B618 File Offset: 0x00009818
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_4()
		{
			Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_4>d <<ExecuteAsync>b__9_4>d;
			<<ExecuteAsync>b__9_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_4>d.<>4__this = this;
			<<ExecuteAsync>b__9_4>d.<>1__state = -1;
			<<ExecuteAsync>b__9_4>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_4>d>(ref <<ExecuteAsync>b__9_4>d);
			return <<ExecuteAsync>b__9_4>d.<>t__builder.Task;
		}

		// Token: 0x04000236 RID: 566
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000237 RID: 567
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000238 RID: 568
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000239 RID: 569
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400023A RID: 570
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400023B RID: 571
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x0400023C RID: 572
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x02000137 RID: 311
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_1>d : IAsyncStateMachine
		{
			// Token: 0x06000A09 RID: 2569 RVA: 0x00040274 File Offset: 0x0003E474
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Index areas_Admin_Views_SAML2_Index = this.<>4__this;
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
						areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n    ");
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Index.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "74bff481fd1675c47db0d9be712b7aa1fe147335d1acd8d594bb41ad8cd611ab11435", new Func<Task>(areas_Admin_Views_SAML2_Index.<ExecuteAsync>b__9_4));
						areas_Admin_Views_SAML2_Index.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_SAML2_Index.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Index.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_SAML2_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_SAML2_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = areas_Admin_Views_SAML2_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_1>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Index.<<ExecuteAsync>b__9_1>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					areas_Admin_Views_SAML2_Index.Write(areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n");
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

			// Token: 0x06000A0A RID: 2570 RVA: 0x00040468 File Offset: 0x0003E668
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007A1 RID: 1953
			public int <>1__state;

			// Token: 0x040007A2 RID: 1954
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007A3 RID: 1955
			public Areas_Admin_Views_SAML2_Index <>4__this;

			// Token: 0x040007A4 RID: 1956
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000138 RID: 312
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_4>d : IAsyncStateMachine
		{
			// Token: 0x06000A0B RID: 2571 RVA: 0x00040478 File Offset: 0x0003E678
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Index areas_Admin_Views_SAML2_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    ");
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

			// Token: 0x06000A0C RID: 2572 RVA: 0x000404DC File Offset: 0x0003E6DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007A5 RID: 1957
			public int <>1__state;

			// Token: 0x040007A6 RID: 1958
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007A7 RID: 1959
			public Areas_Admin_Views_SAML2_Index <>4__this;
		}

		// Token: 0x02000139 RID: 313
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A0F RID: 2575 RVA: 0x00040500 File Offset: 0x0003E700
			internal Task <ExecuteAsync>b__9_0()
			{
				Areas_Admin_Views_SAML2_Index.<>c.<<ExecuteAsync>b__9_0>d <<ExecuteAsync>b__9_0>d;
				<<ExecuteAsync>b__9_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__9_0>d.<>1__state = -1;
				<<ExecuteAsync>b__9_0>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Index.<>c.<<ExecuteAsync>b__9_0>d>(ref <<ExecuteAsync>b__9_0>d);
				return <<ExecuteAsync>b__9_0>d.<>t__builder.Task;
			}

			// Token: 0x040007A8 RID: 1960
			public static readonly Areas_Admin_Views_SAML2_Index.<>c <>9 = new Areas_Admin_Views_SAML2_Index.<>c();

			// Token: 0x040007A9 RID: 1961
			public static Func<Task> <>9__9_0;

			// Token: 0x0200030F RID: 783
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__9_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F2C RID: 3884 RVA: 0x000742FC File Offset: 0x000724FC
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

				// Token: 0x06000F2D RID: 3885 RVA: 0x0007434C File Offset: 0x0007254C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EBF RID: 3775
				public int <>1__state;

				// Token: 0x04000EC0 RID: 3776
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200013A RID: 314
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x040007AA RID: 1962
			public Saml2ConfigViewModel item;
		}

		// Token: 0x0200013B RID: 315
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x06000A11 RID: 2577 RVA: 0x00040544 File Offset: 0x0003E744
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Index areas_Admin_Views_SAML2_Index = this.<>4__this;
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
						areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>Saml2 configurations</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/saml2/edit' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        ");
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "74bff481fd1675c47db0d9be712b7aa1fe147335d1acd8d594bb41ad8cd611ab4311", new Func<Task>(Areas_Admin_Views_SAML2_Index.<>c.<>9.<ExecuteAsync>b__9_0));
						areas_Admin_Views_SAML2_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_SAML2_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_SAML2_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_SAML2_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Index.__tagHelperAttribute_0);
						awaiter2 = areas_Admin_Views_SAML2_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Index.<ExecuteAsync>d__9>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0193;
					}
					awaiter = areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Index.<ExecuteAsync>d__9>(ref awaiter, ref this);
						return;
					}
					IL_018C:
					awaiter.GetResult();
					IL_0193:
					areas_Admin_Views_SAML2_Index.Write(areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Index.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n");
					if (areas_Admin_Views_SAML2_Index.Model != null)
					{
						areas_Admin_Views_SAML2_Index.WriteLiteral("            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n\t\t\t\t\t\t<th></th>\r\n                        <th>\r\n                            Display name\r\n                        </th>\r\n                        <th>\r\n                            Enabled\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
						IEnumerator<Saml2ConfigViewModel> enumerator = areas_Admin_Views_SAML2_Index.Model.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0 CS$<>8__locals1 = new Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0();
								CS$<>8__locals1.item = enumerator.Current;
								areas_Admin_Views_SAML2_Index.WriteLiteral("                        <tr>\r\n\t\t\t\t\t\t\t<td><a");
								areas_Admin_Views_SAML2_Index.BeginWriteAttribute("href", " href='", 1111, "'", 1156, 1);
								RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Index;
								string text = "";
								int num2 = 1118;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
								defaultInterpolatedStringHandler.AppendLiteral("/uas/admin/saml2/edit/");
								defaultInterpolatedStringHandler.AppendFormatted<int>(CS$<>8__locals1.item.Id);
								razorPageBase.WriteAttributeValue(text, num2, defaultInterpolatedStringHandler.ToStringAndClear(), 1118, 38, false);
								areas_Admin_Views_SAML2_Index.EndWriteAttribute();
								areas_Admin_Views_SAML2_Index.WriteLiteral(" title=\"Edit\"><i class=\"fa fa-edit\"></i></a></td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase2 = areas_Admin_Views_SAML2_Index;
								IHtmlHelper<IEnumerable<Saml2ConfigViewModel>> html = areas_Admin_Views_SAML2_Index.Html;
								ParameterExpression parameterExpression = Expression.Parameter(typeof(IEnumerable<Saml2ConfigViewModel>), "modelItem");
								razorPageBase2.Write(html.DisplayFor(Expression.Lambda<Func<IEnumerable<Saml2ConfigViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0.item)), methodof(Saml2ConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase3 = areas_Admin_Views_SAML2_Index;
								IHtmlHelper<IEnumerable<Saml2ConfigViewModel>> html2 = areas_Admin_Views_SAML2_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<Saml2ConfigViewModel>), "modelItem");
								razorPageBase3.Write(html2.DisplayFor(Expression.Lambda<Func<IEnumerable<Saml2ConfigViewModel>, bool>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_SAML2_Index.<>c__DisplayClass9_0.item)), methodof(Saml2ConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_SAML2_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Revoke\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Revoke\"\r\n                                                data-href=\"/uas/admin/saml2/delete/");
								areas_Admin_Views_SAML2_Index.Write(CS$<>8__locals1.item.Id);
								areas_Admin_Views_SAML2_Index.WriteLiteral("\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n                            </td>\r\n                        </tr>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						areas_Admin_Views_SAML2_Index.WriteLiteral("                </tbody>\r\n            </table>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                            <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                                <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            Are you sure ?\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-bs-dis");
						areas_Admin_Views_SAML2_Index.WriteLiteral("miss=\"modal\">Cancel</button>\r\n                            <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
					}
					else
					{
						areas_Admin_Views_SAML2_Index.WriteLiteral("            <div class=\"text-center text-info\">There is no api keys </div>\r\n");
					}
					areas_Admin_Views_SAML2_Index.WriteLiteral("    </div>\r\n</div>\r\n");
					areas_Admin_Views_SAML2_Index.DefineSection("scripts", new RenderAsyncDelegate(areas_Admin_Views_SAML2_Index.<ExecuteAsync>b__9_1));
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

			// Token: 0x06000A12 RID: 2578 RVA: 0x000409A8 File Offset: 0x0003EBA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007AB RID: 1963
			public int <>1__state;

			// Token: 0x040007AC RID: 1964
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007AD RID: 1965
			public Areas_Admin_Views_SAML2_Index <>4__this;

			// Token: 0x040007AE RID: 1966
			private TaskAwaiter <>u__1;
		}
	}
}
