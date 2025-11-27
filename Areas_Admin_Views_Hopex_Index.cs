using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using Mega.Has.Modules.UAS.Areas.Admin.ViewModels;
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
	// Token: 0x02000037 RID: 55
	[RazorSourceChecksum("SHA256", "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea47", "/Areas/Admin/Views/Hopex/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Hopex/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Hopex_Index : BaseRazorPage<HopexConfigViewModel>
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000A7AB File Offset: 0x000089AB
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

		// Token: 0x0600021C RID: 540 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Hopex_Index.<ExecuteAsync>d__16 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<ExecuteAsync>d__16>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000A823 File Offset: 0x00008A23
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000A82B File Offset: 0x00008A2B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000A834 File Offset: 0x00008A34
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000A83C File Offset: 0x00008A3C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000A845 File Offset: 0x00008A45
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000A84D File Offset: 0x00008A4D
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000A856 File Offset: 0x00008A56
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000A85E File Offset: 0x00008A5E
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000A867 File Offset: 0x00008A67
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000A86F File Offset: 0x00008A6F
		[RazorInject]
		public IHtmlHelper<HopexConfigViewModel> Html { get; private set; }

		// Token: 0x06000229 RID: 553 RVA: 0x0000A90C File Offset: 0x00008B0C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__16_0()
		{
			Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d <<ExecuteAsync>b__16_0>d;
			<<ExecuteAsync>b__16_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__16_0>d.<>4__this = this;
			<<ExecuteAsync>b__16_0>d.<>1__state = -1;
			<<ExecuteAsync>b__16_0>d.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref <<ExecuteAsync>b__16_0>d);
			return <<ExecuteAsync>b__16_0>d.<>t__builder.Task;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000A950 File Offset: 0x00008B50
		[CompilerGenerated]
		private Task <ExecuteAsync>b__16_6()
		{
			Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_6>d <<ExecuteAsync>b__16_6>d;
			<<ExecuteAsync>b__16_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__16_6>d.<>4__this = this;
			<<ExecuteAsync>b__16_6>d.<>1__state = -1;
			<<ExecuteAsync>b__16_6>d.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_6>d>(ref <<ExecuteAsync>b__16_6>d);
			return <<ExecuteAsync>b__16_6>d.<>t__builder.Task;
		}

		// Token: 0x040001E1 RID: 481
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001E2 RID: 482
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001E3 RID: 483
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("asp-route", "Admin/Hopex", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001E4 RID: 484
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("btn btn-primary"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001E5 RID: 485
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001E6 RID: 486
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040001E7 RID: 487
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040001E8 RID: 488
		private string __tagHelperStringValueBuffer;

		// Token: 0x040001E9 RID: 489
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040001EA RID: 490
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x040001EB RID: 491
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x040001EC RID: 492
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x040001ED RID: 493
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x040001EE RID: 494
		private AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;

		// Token: 0x02000114 RID: 276
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__16_0>d : IAsyncStateMachine
		{
			// Token: 0x06000987 RID: 2439 RVA: 0x0003355C File Offset: 0x0003175C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Hopex_Index areas_Admin_Views_Hopex_Index = this.<>4__this;
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
						goto IL_0229;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03B5;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_042A;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_05B6;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_062B;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0740;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_07B2;
					default:
						areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n                    <div class=\"modal fade\" id=\"HopexModal\" tabindex=\"-1\" role=\"dialog\" aria-hidden=\"true\">\r\n                        <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                            <div class=\"modal-content\">\r\n                                <div class=\"modal-body text-center h5\">\r\n                                    ");
						areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.T["To <strong>save</strong> and <strong>apply</strong> the changes, the instance and all related nodes will be totally restarted."]);
						areas_Admin_Views_Hopex_Index.WriteLiteral("<br>\r\n                                    \u200b ");
						areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.T["All users will be disconnected."]);
						areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n                                </div>\r\n                                <div class=\"modal-footer justify-content-center\">\r\n                                    <button type=\"submit\" class=\"btn btn-danger w-100\">");
						areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.T["I understand the consequences, restart\u200b"]);
						areas_Admin_Views_Hopex_Index.WriteLiteral("</button>\r\n                                    <button type=\"button\" class=\"btn btn-success w-100 mb-3\" data-bs-dismiss=\"modal\">");
						areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.T["Cancel changes, don’t restart\u200b"]);
						areas_Admin_Views_Hopex_Index.WriteLiteral("</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    ");
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea478425", new Func<Task>(Areas_Admin_Views_Hopex_Index.<>c.<>9.<ExecuteAsync>b__16_1));
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_Hopex_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0230;
					}
					awaiter2 = areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_0229:
					awaiter2.GetResult();
					IL_0230:
					areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <div class=\"checkbox\">\r\n                            <label>\r\n                                ");
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea4710311", new Func<Task>(Areas_Admin_Views_Hopex_Index.<>c.<>9.<ExecuteAsync>b__16_2));
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_Hopex_Index.ModelExpressionProvider;
					ViewDataDictionary<HopexConfigViewModel> viewData = areas_Admin_Views_Hopex_Index.ViewData;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(HopexConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<HopexConfigViewModel, bool>(viewData, Expression.Lambda<Func<HopexConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(HopexConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_1);
					awaiter3 = areas_Admin_Views_Hopex_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_03B5:
					awaiter3.GetResult();
					if (areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0431;
					}
					awaiter4 = areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_042A:
					awaiter4.GetResult();
					IL_0431:
					areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Hopex_Index.WriteLiteral(" Active\r\n                            </label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"checkbox\">\r\n                            <label>\r\n                                ");
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea4712331", new Func<Task>(Areas_Admin_Views_Hopex_Index.<>c.<>9.<ExecuteAsync>b__16_4));
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_Hopex_Index.ModelExpressionProvider;
					ViewDataDictionary<HopexConfigViewModel> viewData2 = areas_Admin_Views_Hopex_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(HopexConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<HopexConfigViewModel, bool>(viewData2, Expression.Lambda<Func<HopexConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(HopexConfigViewModel.get_Hidden())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_1);
					awaiter5 = areas_Admin_Views_Hopex_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_05B6:
					awaiter5.GetResult();
					if (areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0632;
					}
					awaiter6 = areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_062B:
					awaiter6.GetResult();
					IL_0632:
					areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Hopex_Index.WriteLiteral(" Hidden\r\n                            </label>\r\n                        </div>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"form-group pull-right\">\r\n                        ");
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.Begin("a", TagMode.StartTagAndEndTag, "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea4714305", new Func<Task>(areas_Admin_Views_Hopex_Index.<ExecuteAsync>b__16_6));
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<AnchorTagHelper>();
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
					areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_2.Value;
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_2);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_3);
					awaiter7 = areas_Admin_Views_Hopex_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_0740:
					awaiter7.GetResult();
					if (areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_07B9;
					}
					awaiter8 = areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<<ExecuteAsync>b__16_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_07B2:
					awaiter8.GetResult();
					IL_07B9:
					areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-success\" data-bs-toggle=\"modal\" data-bs-target=\"#HopexModal\">Save</button>\r\n                    </div>\r\n                ");
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

			// Token: 0x06000988 RID: 2440 RVA: 0x00033D9C File Offset: 0x00031F9C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006FD RID: 1789
			public int <>1__state;

			// Token: 0x040006FE RID: 1790
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006FF RID: 1791
			public Areas_Admin_Views_Hopex_Index <>4__this;

			// Token: 0x04000700 RID: 1792
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__16_6>d : IAsyncStateMachine
		{
			// Token: 0x06000989 RID: 2441 RVA: 0x00033DAC File Offset: 0x00031FAC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Hopex_Index areas_Admin_Views_Hopex_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Hopex_Index.WriteLiteral("Cancel");
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

			// Token: 0x0600098A RID: 2442 RVA: 0x00033E10 File Offset: 0x00032010
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000701 RID: 1793
			public int <>1__state;

			// Token: 0x04000702 RID: 1794
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000703 RID: 1795
			public Areas_Admin_Views_Hopex_Index <>4__this;
		}

		// Token: 0x02000116 RID: 278
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600098D RID: 2445 RVA: 0x00033E34 File Offset: 0x00032034
			internal Task <ExecuteAsync>b__16_1()
			{
				Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_1>d <<ExecuteAsync>b__16_1>d;
				<<ExecuteAsync>b__16_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__16_1>d.<>1__state = -1;
				<<ExecuteAsync>b__16_1>d.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_1>d>(ref <<ExecuteAsync>b__16_1>d);
				return <<ExecuteAsync>b__16_1>d.<>t__builder.Task;
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x00033E70 File Offset: 0x00032070
			internal Task <ExecuteAsync>b__16_2()
			{
				Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_2>d <<ExecuteAsync>b__16_2>d;
				<<ExecuteAsync>b__16_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__16_2>d.<>1__state = -1;
				<<ExecuteAsync>b__16_2>d.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_2>d>(ref <<ExecuteAsync>b__16_2>d);
				return <<ExecuteAsync>b__16_2>d.<>t__builder.Task;
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x00033EAC File Offset: 0x000320AC
			internal Task <ExecuteAsync>b__16_4()
			{
				Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_4>d <<ExecuteAsync>b__16_4>d;
				<<ExecuteAsync>b__16_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__16_4>d.<>1__state = -1;
				<<ExecuteAsync>b__16_4>d.<>t__builder.Start<Areas_Admin_Views_Hopex_Index.<>c.<<ExecuteAsync>b__16_4>d>(ref <<ExecuteAsync>b__16_4>d);
				return <<ExecuteAsync>b__16_4>d.<>t__builder.Task;
			}

			// Token: 0x04000704 RID: 1796
			public static readonly Areas_Admin_Views_Hopex_Index.<>c <>9 = new Areas_Admin_Views_Hopex_Index.<>c();

			// Token: 0x04000705 RID: 1797
			public static Func<Task> <>9__16_1;

			// Token: 0x04000706 RID: 1798
			public static Func<Task> <>9__16_2;

			// Token: 0x04000707 RID: 1799
			public static Func<Task> <>9__16_4;

			// Token: 0x020002D2 RID: 722
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__16_1>d : IAsyncStateMachine
			{
				// Token: 0x06000EB2 RID: 3762 RVA: 0x00072C1C File Offset: 0x00070E1C
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

				// Token: 0x06000EB3 RID: 3763 RVA: 0x00072C6C File Offset: 0x00070E6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E45 RID: 3653
				public int <>1__state;

				// Token: 0x04000E46 RID: 3654
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D3 RID: 723
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__16_2>d : IAsyncStateMachine
			{
				// Token: 0x06000EB4 RID: 3764 RVA: 0x00072C7C File Offset: 0x00070E7C
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

				// Token: 0x06000EB5 RID: 3765 RVA: 0x00072CCC File Offset: 0x00070ECC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E47 RID: 3655
				public int <>1__state;

				// Token: 0x04000E48 RID: 3656
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D4 RID: 724
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__16_4>d : IAsyncStateMachine
			{
				// Token: 0x06000EB6 RID: 3766 RVA: 0x00072CDC File Offset: 0x00070EDC
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

				// Token: 0x06000EB7 RID: 3767 RVA: 0x00072D2C File Offset: 0x00070F2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E49 RID: 3657
				public int <>1__state;

				// Token: 0x04000E4A RID: 3658
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000117 RID: 279
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__16 : IAsyncStateMachine
		{
			// Token: 0x06000990 RID: 2448 RVA: 0x00033EE8 File Offset: 0x000320E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Hopex_Index areas_Admin_Views_Hopex_Index = this.<>4__this;
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
							goto IL_01AA;
						}
						areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>Hopex Configuration</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "3acf720c3d0a424c710ff3664a1140e88b78a6a88a2f23bb915ad107f070ea475956", new Func<Task>(areas_Admin_Views_Hopex_Index.<ExecuteAsync>b__16_0));
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_Hopex_Index.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_2.Value;
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_2);
						areas_Admin_Views_Hopex_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_4.Value;
						areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Hopex_Index.__tagHelperAttribute_4);
						awaiter2 = areas_Admin_Views_Hopex_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<ExecuteAsync>d__16>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01B1;
					}
					awaiter = areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Hopex_Index.<ExecuteAsync>d__16>(ref awaiter, ref this);
						return;
					}
					IL_01AA:
					awaiter.GetResult();
					IL_01B1:
					areas_Admin_Views_Hopex_Index.Write(areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Hopex_Index.__tagHelperExecutionContext = areas_Admin_Views_Hopex_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Hopex_Index.WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

			// Token: 0x06000991 RID: 2449 RVA: 0x00034120 File Offset: 0x00032320
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000708 RID: 1800
			public int <>1__state;

			// Token: 0x04000709 RID: 1801
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400070A RID: 1802
			public Areas_Admin_Views_Hopex_Index <>4__this;

			// Token: 0x0400070B RID: 1803
			private TaskAwaiter <>u__1;
		}
	}
}
