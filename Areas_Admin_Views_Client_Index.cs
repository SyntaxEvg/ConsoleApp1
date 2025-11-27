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
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x02000036 RID: 54
	[RazorSourceChecksum("SHA256", "9a6d32536404f181e0aac02d4d48f8c55a4c076928484aba7f125113a0c8fa1e", "/Areas/Admin/Views/Client/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Client/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Client_Index : BaseRazorPage<IEnumerable<ClientViewModel>>
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000A643 File Offset: 0x00008843
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

		// Token: 0x0600020D RID: 525 RVA: 0x0000A678 File Offset: 0x00008878
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Client_Index.<ExecuteAsync>d__7 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Client_Index.<ExecuteAsync>d__7>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000A6BB File Offset: 0x000088BB
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0000A6C3 File Offset: 0x000088C3
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000A6CC File Offset: 0x000088CC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000A6D4 File Offset: 0x000088D4
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000A6DD File Offset: 0x000088DD
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000A6E5 File Offset: 0x000088E5
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000A6EE File Offset: 0x000088EE
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000A6F6 File Offset: 0x000088F6
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000A6FF File Offset: 0x000088FF
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000A707 File Offset: 0x00008907
		[RazorInject]
		public IHtmlHelper<IEnumerable<ClientViewModel>> Html { get; private set; }

		// Token: 0x06000219 RID: 537 RVA: 0x0000A724 File Offset: 0x00008924
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__7_4()
		{
			Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_4>d <<ExecuteAsync>b__7_4>d;
			<<ExecuteAsync>b__7_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__7_4>d.<>4__this = this;
			<<ExecuteAsync>b__7_4>d.<>1__state = -1;
			<<ExecuteAsync>b__7_4>d.<>t__builder.Start<Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_4>d>(ref <<ExecuteAsync>b__7_4>d);
			return <<ExecuteAsync>b__7_4>d.<>t__builder.Task;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000A768 File Offset: 0x00008968
		[CompilerGenerated]
		private Task <ExecuteAsync>b__7_9()
		{
			Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_9>d <<ExecuteAsync>b__7_9>d;
			<<ExecuteAsync>b__7_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__7_9>d.<>4__this = this;
			<<ExecuteAsync>b__7_9>d.<>1__state = -1;
			<<ExecuteAsync>b__7_9>d.<>t__builder.Start<Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_9>d>(ref <<ExecuteAsync>b__7_9>d);
			return <<ExecuteAsync>b__7_9>d.<>t__builder.Task;
		}

		// Token: 0x040001D7 RID: 471
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040001D8 RID: 472
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040001D9 RID: 473
		private string __tagHelperStringValueBuffer;

		// Token: 0x040001DA RID: 474
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040001DB RID: 475
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x0200010F RID: 271
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__7_4>d : IAsyncStateMachine
		{
			// Token: 0x0600097E RID: 2430 RVA: 0x00032D98 File Offset: 0x00030F98
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Index areas_Admin_Views_Client_Index = this.<>4__this;
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
						areas_Admin_Views_Client_Index.WriteLiteral("\r\n    ");
						areas_Admin_Views_Client_Index.__tagHelperExecutionContext = areas_Admin_Views_Client_Index.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "9a6d32536404f181e0aac02d4d48f8c55a4c076928484aba7f125113a0c8fa1e12678", new Func<Task>(areas_Admin_Views_Client_Index.<ExecuteAsync>b__7_9));
						areas_Admin_Views_Client_Index.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_Client_Index.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_Client_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Index.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_Client_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_Client_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_Client_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = areas_Admin_Views_Client_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_4>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_Client_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = areas_Admin_Views_Client_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Index.<<ExecuteAsync>b__7_4>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					areas_Admin_Views_Client_Index.Write(areas_Admin_Views_Client_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Index.__tagHelperExecutionContext = areas_Admin_Views_Client_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Index.WriteLiteral("\r\n");
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

			// Token: 0x0600097F RID: 2431 RVA: 0x00032F8C File Offset: 0x0003118C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006F1 RID: 1777
			public int <>1__state;

			// Token: 0x040006F2 RID: 1778
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006F3 RID: 1779
			public Areas_Admin_Views_Client_Index <>4__this;

			// Token: 0x040006F4 RID: 1780
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000110 RID: 272
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__7_9>d : IAsyncStateMachine
		{
			// Token: 0x06000980 RID: 2432 RVA: 0x00032F9C File Offset: 0x0003119C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Index areas_Admin_Views_Client_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Client_Index.WriteLiteral("\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    ");
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

			// Token: 0x06000981 RID: 2433 RVA: 0x00033000 File Offset: 0x00031200
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006F5 RID: 1781
			public int <>1__state;

			// Token: 0x040006F6 RID: 1782
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006F7 RID: 1783
			public Areas_Admin_Views_Client_Index <>4__this;
		}

		// Token: 0x02000111 RID: 273
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x040006F8 RID: 1784
			public static readonly Areas_Admin_Views_Client_Index.<>c <>9 = new Areas_Admin_Views_Client_Index.<>c();
		}

		// Token: 0x02000112 RID: 274
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x040006F9 RID: 1785
			public ClientViewModel item;
		}

		// Token: 0x02000113 RID: 275
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x06000985 RID: 2437 RVA: 0x0003302C File Offset: 0x0003122C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Index areas_Admin_Views_Client_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Client_Index.WriteLiteral("\r\n\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>Clients</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/client/create' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n");
					if (areas_Admin_Views_Client_Index.Model != null)
					{
						areas_Admin_Views_Client_Index.WriteLiteral("            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase = areas_Admin_Views_Client_Index;
						IHtmlHelper<IEnumerable<ClientViewModel>> html = areas_Admin_Views_Client_Index.Html;
						ParameterExpression parameterExpression = Expression.Parameter(typeof(ClientViewModel), "model");
						razorPageBase.Write(html.DisplayNameFor(Expression.Lambda<Func<ClientViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase2 = areas_Admin_Views_Client_Index;
						IHtmlHelper<IEnumerable<ClientViewModel>> html2 = areas_Admin_Views_Client_Index.Html;
						parameterExpression = Expression.Parameter(typeof(ClientViewModel), "model");
						razorPageBase2.Write(html2.DisplayNameFor(Expression.Lambda<Func<ClientViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase3 = areas_Admin_Views_Client_Index;
						IHtmlHelper<IEnumerable<ClientViewModel>> html3 = areas_Admin_Views_Client_Index.Html;
						parameterExpression = Expression.Parameter(typeof(ClientViewModel), "model");
						razorPageBase3.Write(html3.DisplayNameFor(Expression.Lambda<Func<ClientViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase4 = areas_Admin_Views_Client_Index;
						IHtmlHelper<IEnumerable<ClientViewModel>> html4 = areas_Admin_Views_Client_Index.Html;
						parameterExpression = Expression.Parameter(typeof(ClientViewModel), "model");
						razorPageBase4.Write(html4.DisplayNameFor(Expression.Lambda<Func<ClientViewModel, bool>>(Expression.Property(parameterExpression, methodof(ClientViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Index.WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
						IEnumerator<ClientViewModel> enumerator = areas_Admin_Views_Client_Index.Model.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0 CS$<>8__locals1 = new Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0();
								CS$<>8__locals1.item = enumerator.Current;
								areas_Admin_Views_Client_Index.WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase5 = areas_Admin_Views_Client_Index;
								IHtmlHelper<IEnumerable<ClientViewModel>> html5 = areas_Admin_Views_Client_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ClientViewModel>), "modelItem");
								razorPageBase5.Write(html5.DisplayFor(Expression.Lambda<Func<IEnumerable<ClientViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0)), fieldof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0.item)), methodof(ClientViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_Client_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase6 = areas_Admin_Views_Client_Index;
								IHtmlHelper<IEnumerable<ClientViewModel>> html6 = areas_Admin_Views_Client_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ClientViewModel>), "modelItem");
								razorPageBase6.Write(html6.DisplayFor(Expression.Lambda<Func<IEnumerable<ClientViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0)), fieldof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0.item)), methodof(ClientViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_Client_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase7 = areas_Admin_Views_Client_Index;
								IHtmlHelper<IEnumerable<ClientViewModel>> html7 = areas_Admin_Views_Client_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ClientViewModel>), "modelItem");
								razorPageBase7.Write(html7.DisplayFor(Expression.Lambda<Func<IEnumerable<ClientViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0)), fieldof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0.item)), methodof(ClientViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_Client_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase8 = areas_Admin_Views_Client_Index;
								IHtmlHelper<IEnumerable<ClientViewModel>> html8 = areas_Admin_Views_Client_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ClientViewModel>), "modelItem");
								razorPageBase8.Write(html8.DisplayFor(Expression.Lambda<Func<IEnumerable<ClientViewModel>, bool>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0)), fieldof(Areas_Admin_Views_Client_Index.<>c__DisplayClass7_0.item)), methodof(ClientViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_Client_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
								if (!CS$<>8__locals1.item.NonEditable)
								{
									areas_Admin_Views_Client_Index.WriteLiteral("                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Edit\">\r\n                                        <a");
									areas_Admin_Views_Client_Index.BeginWriteAttribute("href", " href=\"", 2243, "\"", 2296, 2);
									areas_Admin_Views_Client_Index.WriteAttributeValue("", 2250, "/uas/admin/client/Edit?clientId=", 2250, 32, true);
									areas_Admin_Views_Client_Index.WriteAttributeValue("", 2282, CS$<>8__locals1.item.ClientId, 2282, 14, false);
									areas_Admin_Views_Client_Index.EndWriteAttribute();
									areas_Admin_Views_Client_Index.WriteLiteral(">\r\n                                            <span class=\"fa fa-edit mx-2\"></span>\r\n                                        </a>\r\n                                    </p>\r\n");
								}
								areas_Admin_Views_Client_Index.WriteLiteral("                            </td>\r\n                            <td>\r\n");
								if (!CS$<>8__locals1.item.NonEditable)
								{
									areas_Admin_Views_Client_Index.WriteLiteral("                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Delete\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Delete\"\r\n                                                data-href=\"/uas/admin/client/delete/");
									areas_Admin_Views_Client_Index.Write(CS$<>8__locals1.item.ClientId);
									areas_Admin_Views_Client_Index.WriteLiteral("\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n");
								}
								areas_Admin_Views_Client_Index.WriteLiteral("                            </td>\r\n                        </tr>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						areas_Admin_Views_Client_Index.WriteLiteral("                </tbody>\r\n            </table>\r\n");
					}
					else
					{
						areas_Admin_Views_Client_Index.WriteLiteral("            <div class=\"text-center text-info\">There is no client </div>\r\n");
					}
					areas_Admin_Views_Client_Index.WriteLiteral("    </div>\r\n</div>\r\n<!-- Modal -->\r\n<div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                Are you sure ?\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\" data-bs-dismiss=\"modal\">Cancel</button>\r\n                <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
					areas_Admin_Views_Client_Index.DefineSection("scripts", new RenderAsyncDelegate(areas_Admin_Views_Client_Index.<ExecuteAsync>b__7_4));
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

			// Token: 0x06000986 RID: 2438 RVA: 0x0003354C File Offset: 0x0003174C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006FA RID: 1786
			public int <>1__state;

			// Token: 0x040006FB RID: 1787
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006FC RID: 1788
			public Areas_Admin_Views_Client_Index <>4__this;
		}
	}
}
