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
	// Token: 0x02000033 RID: 51
	[RazorSourceChecksum("SHA256", "877ac5d78041a80a124f80ca3c56846503b955fe4f2c862d2c9a246fd573ed0e", "/Areas/Admin/Views/ApiKey/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/ApiKey/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_ApiKey_Index : BaseRazorPage<IEnumerable<ApiKeyViewModel>>
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00009FB3 File Offset: 0x000081B3
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

		// Token: 0x060001DF RID: 479 RVA: 0x00009FE8 File Offset: 0x000081E8
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_ApiKey_Index.<ExecuteAsync>d__9 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_ApiKey_Index.<ExecuteAsync>d__9>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000A02B File Offset: 0x0000822B
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000A033 File Offset: 0x00008233
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000A03C File Offset: 0x0000823C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000A044 File Offset: 0x00008244
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A04D File Offset: 0x0000824D
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000A055 File Offset: 0x00008255
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000A05E File Offset: 0x0000825E
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000A066 File Offset: 0x00008266
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000A06F File Offset: 0x0000826F
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000A077 File Offset: 0x00008277
		[RazorInject]
		public IHtmlHelper<IEnumerable<ApiKeyViewModel>> Html { get; private set; }

		// Token: 0x060001EC RID: 492 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_4()
		{
			Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_4>d <<ExecuteAsync>b__9_4>d;
			<<ExecuteAsync>b__9_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_4>d.<>4__this = this;
			<<ExecuteAsync>b__9_4>d.<>1__state = -1;
			<<ExecuteAsync>b__9_4>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_4>d>(ref <<ExecuteAsync>b__9_4>d);
			return <<ExecuteAsync>b__9_4>d.<>t__builder.Task;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[CompilerGenerated]
		private Task <ExecuteAsync>b__9_8()
		{
			Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_8>d <<ExecuteAsync>b__9_8>d;
			<<ExecuteAsync>b__9_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__9_8>d.<>4__this = this;
			<<ExecuteAsync>b__9_8>d.<>1__state = -1;
			<<ExecuteAsync>b__9_8>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_8>d>(ref <<ExecuteAsync>b__9_8>d);
			return <<ExecuteAsync>b__9_8>d.<>t__builder.Task;
		}

		// Token: 0x04000192 RID: 402
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000193 RID: 403
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000194 RID: 404
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000195 RID: 405
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000196 RID: 406
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000197 RID: 407
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000198 RID: 408
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x02000104 RID: 260
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_4>d : IAsyncStateMachine
		{
			// Token: 0x06000946 RID: 2374 RVA: 0x0002CF0C File Offset: 0x0002B10C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Index areas_Admin_Views_ApiKey_Index = this.<>4__this;
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
						areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n    ");
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Index.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "877ac5d78041a80a124f80ca3c56846503b955fe4f2c862d2c9a246fd573ed0e13285", new Func<Task>(areas_Admin_Views_ApiKey_Index.<ExecuteAsync>b__9_8));
						areas_Admin_Views_ApiKey_Index.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_ApiKey_Index.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Index.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_ApiKey_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_ApiKey_Index.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = areas_Admin_Views_ApiKey_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_4>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016D;
					}
					awaiter = areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Index.<<ExecuteAsync>b__9_4>d>(ref awaiter, ref this);
						return;
					}
					IL_0166:
					awaiter.GetResult();
					IL_016D:
					areas_Admin_Views_ApiKey_Index.Write(areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n");
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

			// Token: 0x06000947 RID: 2375 RVA: 0x0002D100 File Offset: 0x0002B300
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006AF RID: 1711
			public int <>1__state;

			// Token: 0x040006B0 RID: 1712
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006B1 RID: 1713
			public Areas_Admin_Views_ApiKey_Index <>4__this;

			// Token: 0x040006B2 RID: 1714
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000105 RID: 261
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__9_8>d : IAsyncStateMachine
		{
			// Token: 0x06000948 RID: 2376 RVA: 0x0002D110 File Offset: 0x0002B310
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Index areas_Admin_Views_ApiKey_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    ");
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

			// Token: 0x06000949 RID: 2377 RVA: 0x0002D174 File Offset: 0x0002B374
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006B3 RID: 1715
			public int <>1__state;

			// Token: 0x040006B4 RID: 1716
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006B5 RID: 1717
			public Areas_Admin_Views_ApiKey_Index <>4__this;
		}

		// Token: 0x02000106 RID: 262
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600094C RID: 2380 RVA: 0x0002D198 File Offset: 0x0002B398
			internal Task <ExecuteAsync>b__9_0()
			{
				Areas_Admin_Views_ApiKey_Index.<>c.<<ExecuteAsync>b__9_0>d <<ExecuteAsync>b__9_0>d;
				<<ExecuteAsync>b__9_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__9_0>d.<>1__state = -1;
				<<ExecuteAsync>b__9_0>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Index.<>c.<<ExecuteAsync>b__9_0>d>(ref <<ExecuteAsync>b__9_0>d);
				return <<ExecuteAsync>b__9_0>d.<>t__builder.Task;
			}

			// Token: 0x040006B6 RID: 1718
			public static readonly Areas_Admin_Views_ApiKey_Index.<>c <>9 = new Areas_Admin_Views_ApiKey_Index.<>c();

			// Token: 0x040006B7 RID: 1719
			public static Func<Task> <>9__9_0;

			// Token: 0x020002AF RID: 687
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__9_0>d : IAsyncStateMachine
			{
				// Token: 0x06000E6C RID: 3692 RVA: 0x00071EFC File Offset: 0x000700FC
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

				// Token: 0x06000E6D RID: 3693 RVA: 0x00071F4C File Offset: 0x0007014C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DFF RID: 3583
				public int <>1__state;

				// Token: 0x04000E00 RID: 3584
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000107 RID: 263
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x040006B8 RID: 1720
			public ApiKeyViewModel item;
		}

		// Token: 0x02000108 RID: 264
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__9 : IAsyncStateMachine
		{
			// Token: 0x0600094E RID: 2382 RVA: 0x0002D1DC File Offset: 0x0002B3DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Index areas_Admin_Views_ApiKey_Index = this.<>4__this;
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
						areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>API keys</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/apikey/create' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        ");
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "877ac5d78041a80a124f80ca3c56846503b955fe4f2c862d2c9a246fd573ed0e4303", new Func<Task>(Areas_Admin_Views_ApiKey_Index.<>c.<>9.<ExecuteAsync>b__9_0));
						areas_Admin_Views_ApiKey_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_ApiKey_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_ApiKey_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_ApiKey_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Index.__tagHelperAttribute_0);
						awaiter2 = areas_Admin_Views_ApiKey_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Index.<ExecuteAsync>d__9>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0193;
					}
					awaiter = areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Index.<ExecuteAsync>d__9>(ref awaiter, ref this);
						return;
					}
					IL_018C:
					awaiter.GetResult();
					IL_0193:
					areas_Admin_Views_ApiKey_Index.Write(areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Index.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n");
					if (areas_Admin_Views_ApiKey_Index.Model != null)
					{
						areas_Admin_Views_ApiKey_Index.WriteLiteral("            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase = areas_Admin_Views_ApiKey_Index;
						IHtmlHelper<IEnumerable<ApiKeyViewModel>> html = areas_Admin_Views_ApiKey_Index.Html;
						ParameterExpression parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "model");
						razorPageBase.Write(html.DisplayNameFor(Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase2 = areas_Admin_Views_ApiKey_Index;
						IHtmlHelper<IEnumerable<ApiKeyViewModel>> html2 = areas_Admin_Views_ApiKey_Index.Html;
						parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "model");
						razorPageBase2.Write(html2.DisplayNameFor(Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
						RazorPageBase razorPageBase3 = areas_Admin_Views_ApiKey_Index;
						IHtmlHelper<IEnumerable<ApiKeyViewModel>> html3 = areas_Admin_Views_ApiKey_Index.Html;
						parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "model");
						razorPageBase3.Write(html3.DisplayNameFor(Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
						IEnumerator<ApiKeyViewModel> enumerator = areas_Admin_Views_ApiKey_Index.Model.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0 CS$<>8__locals1 = new Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0();
								CS$<>8__locals1.item = enumerator.Current;
								areas_Admin_Views_ApiKey_Index.WriteLiteral("                        <tr");
								areas_Admin_Views_ApiKey_Index.BeginWriteAttribute("class", " class=\"", 1281, "\"", 1326, 1);
								areas_Admin_Views_ApiKey_Index.WriteAttributeValue("", 1289, CS$<>8__locals1.item.IsExpired ? "bg-warning" : "", 1289, 37, false);
								areas_Admin_Views_ApiKey_Index.EndWriteAttribute();
								areas_Admin_Views_ApiKey_Index.WriteLiteral(">\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase4 = areas_Admin_Views_ApiKey_Index;
								IHtmlHelper<IEnumerable<ApiKeyViewModel>> html4 = areas_Admin_Views_ApiKey_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ApiKeyViewModel>), "modelItem");
								razorPageBase4.Write(html4.DisplayFor(Expression.Lambda<Func<IEnumerable<ApiKeyViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0.item)), methodof(InputApiKeyViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase5 = areas_Admin_Views_ApiKey_Index;
								IHtmlHelper<IEnumerable<ApiKeyViewModel>> html5 = areas_Admin_Views_ApiKey_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ApiKeyViewModel>), "modelItem");
								razorPageBase5.Write(html5.DisplayFor(Expression.Lambda<Func<IEnumerable<ApiKeyViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0.item)), methodof(InputApiKeyViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
								RazorPageBase razorPageBase6 = areas_Admin_Views_ApiKey_Index;
								IHtmlHelper<IEnumerable<ApiKeyViewModel>> html6 = areas_Admin_Views_ApiKey_Index.Html;
								parameterExpression = Expression.Parameter(typeof(IEnumerable<ApiKeyViewModel>), "modelItem");
								razorPageBase6.Write(html6.DisplayFor(Expression.Lambda<Func<IEnumerable<ApiKeyViewModel>, string>>(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0)), fieldof(Areas_Admin_Views_ApiKey_Index.<>c__DisplayClass9_0.item)), methodof(InputApiKeyViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression })));
								areas_Admin_Views_ApiKey_Index.WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
								if (CS$<>8__locals1.item.TokenName != "admin")
								{
									areas_Admin_Views_ApiKey_Index.WriteLiteral("                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Revoke\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Revoke\"\r\n                                                data-href=\"/uas/admin/apikey/delete/");
									areas_Admin_Views_ApiKey_Index.Write(CS$<>8__locals1.item.Id);
									areas_Admin_Views_ApiKey_Index.WriteLiteral("\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n");
								}
								areas_Admin_Views_ApiKey_Index.WriteLiteral("                            </td>\r\n                        </tr>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						areas_Admin_Views_ApiKey_Index.WriteLiteral("                </tbody>\r\n            </table>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                            <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                                <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            Are you sure ?\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-bs-dis");
						areas_Admin_Views_ApiKey_Index.WriteLiteral("miss=\"modal\">Cancel</button>\r\n                            <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
					}
					else
					{
						areas_Admin_Views_ApiKey_Index.WriteLiteral("            <div class=\"text-center text-info\">There is no api keys </div>\r\n");
					}
					areas_Admin_Views_ApiKey_Index.WriteLiteral("    </div>\r\n</div>\r\n");
					areas_Admin_Views_ApiKey_Index.DefineSection("scripts", new RenderAsyncDelegate(areas_Admin_Views_ApiKey_Index.<ExecuteAsync>b__9_4));
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

			// Token: 0x0600094F RID: 2383 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006B9 RID: 1721
			public int <>1__state;

			// Token: 0x040006BA RID: 1722
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006BB RID: 1723
			public Areas_Admin_Views_ApiKey_Index <>4__this;

			// Token: 0x040006BC RID: 1724
			private TaskAwaiter <>u__1;
		}
	}
}
