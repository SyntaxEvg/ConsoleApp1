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
	// Token: 0x02000034 RID: 52
	[RazorSourceChecksum("SHA256", "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f86", "/Areas/Admin/Views/Client/Create.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Client/Create.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Client_Create : BaseRazorPage<ClientInputViewModel>
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000A137 File Offset: 0x00008337
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

		// Token: 0x060001EF RID: 495 RVA: 0x0000A16C File Offset: 0x0000836C
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Client_Create.<ExecuteAsync>d__23 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Client_Create.<ExecuteAsync>d__23>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000A1AF File Offset: 0x000083AF
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000A1B7 File Offset: 0x000083B7
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000A1C0 File Offset: 0x000083C0
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000A1C8 File Offset: 0x000083C8
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000A1D1 File Offset: 0x000083D1
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000A1D9 File Offset: 0x000083D9
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000A1E2 File Offset: 0x000083E2
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000A1EA File Offset: 0x000083EA
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000A1F3 File Offset: 0x000083F3
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000A1FB File Offset: 0x000083FB
		[RazorInject]
		public IHtmlHelper<ClientInputViewModel> Html { get; private set; }

		// Token: 0x060001FC RID: 508 RVA: 0x0000A32C File Offset: 0x0000852C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__23_0()
		{
			Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d <<ExecuteAsync>b__23_0>d;
			<<ExecuteAsync>b__23_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__23_0>d.<>4__this = this;
			<<ExecuteAsync>b__23_0>d.<>1__state = -1;
			<<ExecuteAsync>b__23_0>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref <<ExecuteAsync>b__23_0>d);
			return <<ExecuteAsync>b__23_0>d.<>t__builder.Task;
		}

		// Token: 0x0400019E RID: 414
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400019F RID: 415
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A0 RID: 416
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", "Id", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A1 RID: 417
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A2 RID: 418
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("class", new HtmlString("form-control  col-md-7 col-xs-12"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A3 RID: 419
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A4 RID: 420
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A5 RID: 421
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A6 RID: 422
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("rows", new HtmlString("5"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A7 RID: 423
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("class", new HtmlString("form-horizontal form-label-left"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A8 RID: 424
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001A9 RID: 425
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040001AA RID: 426
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040001AB RID: 427
		private string __tagHelperStringValueBuffer;

		// Token: 0x040001AC RID: 428
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040001AD RID: 429
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x040001AE RID: 430
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x040001AF RID: 431
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x040001B0 RID: 432
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x040001B1 RID: 433
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x040001B2 RID: 434
		private TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;

		// Token: 0x02000109 RID: 265
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__23_0>d : IAsyncStateMachine
		{
			// Token: 0x06000950 RID: 2384 RVA: 0x0002D7E4 File Offset: 0x0002B9E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Create areas_Admin_Views_Client_Create = this.<>4__this;
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
					TaskAwaiter awaiter9;
					TaskAwaiter awaiter10;
					TaskAwaiter awaiter11;
					TaskAwaiter awaiter12;
					TaskAwaiter awaiter13;
					TaskAwaiter awaiter14;
					TaskAwaiter awaiter15;
					TaskAwaiter awaiter16;
					TaskAwaiter awaiter17;
					TaskAwaiter awaiter18;
					TaskAwaiter awaiter19;
					TaskAwaiter awaiter20;
					TaskAwaiter awaiter21;
					TaskAwaiter awaiter22;
					TaskAwaiter awaiter23;
					TaskAwaiter awaiter24;
					TaskAwaiter awaiter25;
					TaskAwaiter awaiter26;
					TaskAwaiter awaiter27;
					TaskAwaiter awaiter28;
					TaskAwaiter awaiter29;
					TaskAwaiter awaiter30;
					TaskAwaiter awaiter31;
					TaskAwaiter awaiter32;
					TaskAwaiter awaiter33;
					TaskAwaiter awaiter34;
					TaskAwaiter awaiter35;
					TaskAwaiter awaiter36;
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
						goto IL_0215;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03CB;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0440;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0629;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_069E;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_082A;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_089F;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A11;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A87;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0BFA;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C70;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0DE3;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0E59;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0FCC;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1042;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_11FA;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1270;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_13E3;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1459;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_15DC;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1652;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_17C5;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_183B;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19AE;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1A24;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1B97;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1C0D;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1D80;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1DF6;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F69;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1FDF;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2152;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_21C8;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_233B;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_23AE;
					default:
						areas_Admin_Views_Client_Create.WriteLiteral("\r\n                    ");
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f868552", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_1));
						areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_021C;
					}
					awaiter2 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_0215:
					awaiter2.GetResult();
					IL_021C:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                    ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8610287", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_2));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Create.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_1);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData = areas_Admin_Views_Client_Create.ViewData;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<ClientInputViewModel, int>(viewData, Expression.Lambda<Func<ClientInputViewModel, int>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Id())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Create.__tagHelperAttribute_2.Value;
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_2);
					awaiter3 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_03CB:
					awaiter3.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0447;
					}
					awaiter4 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_0440:
					awaiter4.GetResult();
					IL_0447:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"ClientTypes\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Types<span class=\"required\"> *</span></label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					RazorPageBase razorPageBase = areas_Admin_Views_Client_Create;
					IHtmlHelper<ClientInputViewModel> html = areas_Admin_Views_Client_Create.Html;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "m");
					razorPageBase.Write(html.DropDownListFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientTypeId())), new ParameterExpression[] { parameterExpression }), areas_Admin_Views_Client_Create.Model.ClientTypes, "- Please select your client type -", new
					{
						@class = "form-select  col-md-7 col-xs-12",
						id = "ClientTypes"
					}));
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8613171", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_5));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData2 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider2.CreateModelExpression<ClientInputViewModel, string>(viewData2, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientTypeId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter5 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_0629:
					awaiter5.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06A5;
					}
					awaiter6 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_069E:
					awaiter6.GetResult();
					IL_06A5:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"Enabled\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Enabled</label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8615194", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_7));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData3 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<ClientInputViewModel, bool>(viewData3, Expression.Lambda<Func<ClientInputViewModel, bool>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Create.__tagHelperAttribute_3.Value;
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_3);
					awaiter7 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_082A:
					awaiter7.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08A6;
					}
					awaiter8 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_089F:
					awaiter8.GetResult();
					IL_08A6:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"ClientId\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Client Id<span class=\"required\"> *</span></label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8617302", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_9));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData4 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider4.CreateModelExpression<ClientInputViewModel, string>(viewData4, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter9 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A11:
					awaiter9.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0A8E;
					}
					awaiter10 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0A87:
					awaiter10.GetResult();
					IL_0A8E:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8618953", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_11));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData5 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider5.CreateModelExpression<ClientInputViewModel, string>(viewData5, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter11 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0BFA:
					awaiter11.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0C77;
					}
					awaiter12 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0C70:
					awaiter12.GetResult();
					IL_0C77:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"ClientName\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Title<span class=\"required\"> *</span></label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8621007", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_13));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData6 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider6.CreateModelExpression<ClientInputViewModel, string>(viewData6, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter13 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						this.<>1__state = 12;
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0DE3:
					awaiter13.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0E60;
					}
					awaiter14 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						this.<>1__state = 13;
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0E59:
					awaiter14.GetResult();
					IL_0E60:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8622660", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_15));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData7 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider7.CreateModelExpression<ClientInputViewModel, string>(viewData7, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter15 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						this.<>1__state = 14;
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_0FCC:
					awaiter15.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1049;
					}
					awaiter16 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						this.<>1__state = 15;
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_1042:
					awaiter16.GetResult();
					IL_1049:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
					areas_Admin_Views_Client_Create.WriteLiteral("                    <div class=\"form-group\">\r\n                        <label for=\"ClientSecret\" class=\"control-label  col-md-3 col-sm-3 col-xs-12\">Client secret<span class=\"required\"> *</span></label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            <div class=\"input-group col-md-7 col-xs-12 p-0\" id=\"show_hide_password\">\r\n                                ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8624878", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_17));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData8 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider8.CreateModelExpression<ClientInputViewModel, string>(viewData8, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_5);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_6);
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Create.__tagHelperAttribute_7.Value;
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_7);
					awaiter17 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						this.<>1__state = 16;
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_11FA:
					awaiter17.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1277;
					}
					awaiter18 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						this.<>1__state = 17;
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_1270:
					awaiter18.GetResult();
					IL_1277:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                                <button class=\"input-group-text eye rounded-right\" type=\"button\">\r\n                                    <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\" tabindex=\"-1\"></i>\r\n                                </button>\r\n                                ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8627124", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_19));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData9 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider9.CreateModelExpression<ClientInputViewModel, string>(viewData9, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter19 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						this.<>1__state = 18;
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_13E3:
					awaiter19.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1460;
					}
					awaiter20 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						this.<>1__state = 19;
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_1459:
					awaiter20.GetResult();
					IL_1460:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"Description\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Description<span class=\"required\"> *</span></label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("textarea", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8629225", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_21));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<TextAreaTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_8);
					TextAreaTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData10 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = modelExpressionProvider10.CreateModelExpression<ClientInputViewModel, string>(viewData10, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter21 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						this.<>1__state = 20;
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_15DC:
					awaiter21.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1659;
					}
					awaiter22 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						this.<>1__state = 21;
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1652:
					awaiter22.GetResult();
					IL_1659:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8630990", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_23));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData11 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider11.CreateModelExpression<ClientInputViewModel, string>(viewData11, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter23 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						this.<>1__state = 22;
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_17C5:
					awaiter23.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1842;
					}
					awaiter24 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						this.<>1__state = 23;
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_183B:
					awaiter24.GetResult();
					IL_1842:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"ClientUri\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Client Uri</label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8633017", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_25));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData12 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider12.CreateModelExpression<ClientInputViewModel, string>(viewData12, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter25 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						this.<>1__state = 24;
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_19AE:
					awaiter25.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1A2B;
					}
					awaiter26 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						this.<>1__state = 25;
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1A24:
					awaiter26.GetResult();
					IL_1A2B:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8634669", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_27));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData13 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6.For = modelExpressionProvider13.CreateModelExpression<ClientInputViewModel, string>(viewData13, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter27 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						this.<>1__state = 26;
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1B97:
					awaiter27.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1C14;
					}
					awaiter28 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						this.<>1__state = 27;
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1C0D:
					awaiter28.GetResult();
					IL_1C14:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"Scopes\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Scopes</label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8636687", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_29));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData14 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider14.CreateModelExpression<ClientInputViewModel, string>(viewData14, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Scopes())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter29 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						this.<>1__state = 28;
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1D80:
					awaiter29.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1DFD;
					}
					awaiter30 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						this.<>1__state = 29;
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1DF6:
					awaiter30.GetResult();
					IL_1DFD:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8638336", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_31));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData15 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7.For = modelExpressionProvider15.CreateModelExpression<ClientInputViewModel, string>(viewData15, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Scopes())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter31 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						this.<>1__state = 30;
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_1F69:
					awaiter31.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1FE6;
					}
					awaiter32 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						this.<>1__state = 31;
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_1FDF:
					awaiter32.GetResult();
					IL_1FE6:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"Cors\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Allowed Cors origins</label>\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8640363", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_33));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData16 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider16.CreateModelExpression<ClientInputViewModel, string>(viewData16, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Cors())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_4);
					awaiter33 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						this.<>1__state = 32;
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_2152:
					awaiter33.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_21CF;
					}
					awaiter34 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						this.<>1__state = 33;
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_21C8:
					awaiter34.GetResult();
					IL_21CF:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f8642010", new Func<Task>(Areas_Admin_Views_Client_Create.<>c.<>9.<ExecuteAsync>b__23_35));
					areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8 = areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_Client_Create.ModelExpressionProvider;
					ViewDataDictionary<ClientInputViewModel> viewData17 = areas_Admin_Views_Client_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8.For = modelExpressionProvider17.CreateModelExpression<ClientInputViewModel, string>(viewData17, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Cors())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_0);
					awaiter35 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						this.<>1__state = 34;
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_233B:
					awaiter35.GetResult();
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_23B5;
					}
					awaiter36 = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						this.<>1__state = 35;
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<<ExecuteAsync>b__23_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_23AE:
					awaiter36.GetResult();
					IL_23B5:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"ln_solid\"></div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-md-6 col-sm-6 col-xs-12 col-md-offset-3\">\r\n                            <button class=\"btn btn-primary pull-right\" type=\"submit\" id=\"login\">\r\n                                Submit\r\n                            </button>\r\n                        </div>\r\n                    </div>\r\n                ");
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

			// Token: 0x06000951 RID: 2385 RVA: 0x0002FC20 File Offset: 0x0002DE20
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006BD RID: 1725
			public int <>1__state;

			// Token: 0x040006BE RID: 1726
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006BF RID: 1727
			public Areas_Admin_Views_Client_Create <>4__this;

			// Token: 0x040006C0 RID: 1728
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200010A RID: 266
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000954 RID: 2388 RVA: 0x0002FC44 File Offset: 0x0002DE44
			internal Task <ExecuteAsync>b__23_1()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_1>d <<ExecuteAsync>b__23_1>d;
				<<ExecuteAsync>b__23_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_1>d.<>1__state = -1;
				<<ExecuteAsync>b__23_1>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_1>d>(ref <<ExecuteAsync>b__23_1>d);
				return <<ExecuteAsync>b__23_1>d.<>t__builder.Task;
			}

			// Token: 0x06000955 RID: 2389 RVA: 0x0002FC80 File Offset: 0x0002DE80
			internal Task <ExecuteAsync>b__23_2()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_2>d <<ExecuteAsync>b__23_2>d;
				<<ExecuteAsync>b__23_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_2>d.<>1__state = -1;
				<<ExecuteAsync>b__23_2>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_2>d>(ref <<ExecuteAsync>b__23_2>d);
				return <<ExecuteAsync>b__23_2>d.<>t__builder.Task;
			}

			// Token: 0x06000956 RID: 2390 RVA: 0x0002FCBC File Offset: 0x0002DEBC
			internal Task <ExecuteAsync>b__23_5()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_5>d <<ExecuteAsync>b__23_5>d;
				<<ExecuteAsync>b__23_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_5>d.<>1__state = -1;
				<<ExecuteAsync>b__23_5>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_5>d>(ref <<ExecuteAsync>b__23_5>d);
				return <<ExecuteAsync>b__23_5>d.<>t__builder.Task;
			}

			// Token: 0x06000957 RID: 2391 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
			internal Task <ExecuteAsync>b__23_7()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_7>d <<ExecuteAsync>b__23_7>d;
				<<ExecuteAsync>b__23_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_7>d.<>1__state = -1;
				<<ExecuteAsync>b__23_7>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_7>d>(ref <<ExecuteAsync>b__23_7>d);
				return <<ExecuteAsync>b__23_7>d.<>t__builder.Task;
			}

			// Token: 0x06000958 RID: 2392 RVA: 0x0002FD34 File Offset: 0x0002DF34
			internal Task <ExecuteAsync>b__23_9()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_9>d <<ExecuteAsync>b__23_9>d;
				<<ExecuteAsync>b__23_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_9>d.<>1__state = -1;
				<<ExecuteAsync>b__23_9>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_9>d>(ref <<ExecuteAsync>b__23_9>d);
				return <<ExecuteAsync>b__23_9>d.<>t__builder.Task;
			}

			// Token: 0x06000959 RID: 2393 RVA: 0x0002FD70 File Offset: 0x0002DF70
			internal Task <ExecuteAsync>b__23_11()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_11>d <<ExecuteAsync>b__23_11>d;
				<<ExecuteAsync>b__23_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_11>d.<>1__state = -1;
				<<ExecuteAsync>b__23_11>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_11>d>(ref <<ExecuteAsync>b__23_11>d);
				return <<ExecuteAsync>b__23_11>d.<>t__builder.Task;
			}

			// Token: 0x0600095A RID: 2394 RVA: 0x0002FDAC File Offset: 0x0002DFAC
			internal Task <ExecuteAsync>b__23_13()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_13>d <<ExecuteAsync>b__23_13>d;
				<<ExecuteAsync>b__23_13>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_13>d.<>1__state = -1;
				<<ExecuteAsync>b__23_13>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_13>d>(ref <<ExecuteAsync>b__23_13>d);
				return <<ExecuteAsync>b__23_13>d.<>t__builder.Task;
			}

			// Token: 0x0600095B RID: 2395 RVA: 0x0002FDE8 File Offset: 0x0002DFE8
			internal Task <ExecuteAsync>b__23_15()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_15>d <<ExecuteAsync>b__23_15>d;
				<<ExecuteAsync>b__23_15>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_15>d.<>1__state = -1;
				<<ExecuteAsync>b__23_15>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_15>d>(ref <<ExecuteAsync>b__23_15>d);
				return <<ExecuteAsync>b__23_15>d.<>t__builder.Task;
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x0002FE24 File Offset: 0x0002E024
			internal Task <ExecuteAsync>b__23_17()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_17>d <<ExecuteAsync>b__23_17>d;
				<<ExecuteAsync>b__23_17>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_17>d.<>1__state = -1;
				<<ExecuteAsync>b__23_17>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_17>d>(ref <<ExecuteAsync>b__23_17>d);
				return <<ExecuteAsync>b__23_17>d.<>t__builder.Task;
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x0002FE60 File Offset: 0x0002E060
			internal Task <ExecuteAsync>b__23_19()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_19>d <<ExecuteAsync>b__23_19>d;
				<<ExecuteAsync>b__23_19>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_19>d.<>1__state = -1;
				<<ExecuteAsync>b__23_19>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_19>d>(ref <<ExecuteAsync>b__23_19>d);
				return <<ExecuteAsync>b__23_19>d.<>t__builder.Task;
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x0002FE9C File Offset: 0x0002E09C
			internal Task <ExecuteAsync>b__23_21()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_21>d <<ExecuteAsync>b__23_21>d;
				<<ExecuteAsync>b__23_21>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_21>d.<>1__state = -1;
				<<ExecuteAsync>b__23_21>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_21>d>(ref <<ExecuteAsync>b__23_21>d);
				return <<ExecuteAsync>b__23_21>d.<>t__builder.Task;
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x0002FED8 File Offset: 0x0002E0D8
			internal Task <ExecuteAsync>b__23_23()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_23>d <<ExecuteAsync>b__23_23>d;
				<<ExecuteAsync>b__23_23>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_23>d.<>1__state = -1;
				<<ExecuteAsync>b__23_23>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_23>d>(ref <<ExecuteAsync>b__23_23>d);
				return <<ExecuteAsync>b__23_23>d.<>t__builder.Task;
			}

			// Token: 0x06000960 RID: 2400 RVA: 0x0002FF14 File Offset: 0x0002E114
			internal Task <ExecuteAsync>b__23_25()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_25>d <<ExecuteAsync>b__23_25>d;
				<<ExecuteAsync>b__23_25>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_25>d.<>1__state = -1;
				<<ExecuteAsync>b__23_25>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_25>d>(ref <<ExecuteAsync>b__23_25>d);
				return <<ExecuteAsync>b__23_25>d.<>t__builder.Task;
			}

			// Token: 0x06000961 RID: 2401 RVA: 0x0002FF50 File Offset: 0x0002E150
			internal Task <ExecuteAsync>b__23_27()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_27>d <<ExecuteAsync>b__23_27>d;
				<<ExecuteAsync>b__23_27>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_27>d.<>1__state = -1;
				<<ExecuteAsync>b__23_27>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_27>d>(ref <<ExecuteAsync>b__23_27>d);
				return <<ExecuteAsync>b__23_27>d.<>t__builder.Task;
			}

			// Token: 0x06000962 RID: 2402 RVA: 0x0002FF8C File Offset: 0x0002E18C
			internal Task <ExecuteAsync>b__23_29()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_29>d <<ExecuteAsync>b__23_29>d;
				<<ExecuteAsync>b__23_29>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_29>d.<>1__state = -1;
				<<ExecuteAsync>b__23_29>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_29>d>(ref <<ExecuteAsync>b__23_29>d);
				return <<ExecuteAsync>b__23_29>d.<>t__builder.Task;
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x0002FFC8 File Offset: 0x0002E1C8
			internal Task <ExecuteAsync>b__23_31()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_31>d <<ExecuteAsync>b__23_31>d;
				<<ExecuteAsync>b__23_31>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_31>d.<>1__state = -1;
				<<ExecuteAsync>b__23_31>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_31>d>(ref <<ExecuteAsync>b__23_31>d);
				return <<ExecuteAsync>b__23_31>d.<>t__builder.Task;
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x00030004 File Offset: 0x0002E204
			internal Task <ExecuteAsync>b__23_33()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_33>d <<ExecuteAsync>b__23_33>d;
				<<ExecuteAsync>b__23_33>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_33>d.<>1__state = -1;
				<<ExecuteAsync>b__23_33>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_33>d>(ref <<ExecuteAsync>b__23_33>d);
				return <<ExecuteAsync>b__23_33>d.<>t__builder.Task;
			}

			// Token: 0x06000965 RID: 2405 RVA: 0x00030040 File Offset: 0x0002E240
			internal Task <ExecuteAsync>b__23_35()
			{
				Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_35>d <<ExecuteAsync>b__23_35>d;
				<<ExecuteAsync>b__23_35>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_35>d.<>1__state = -1;
				<<ExecuteAsync>b__23_35>d.<>t__builder.Start<Areas_Admin_Views_Client_Create.<>c.<<ExecuteAsync>b__23_35>d>(ref <<ExecuteAsync>b__23_35>d);
				return <<ExecuteAsync>b__23_35>d.<>t__builder.Task;
			}

			// Token: 0x040006C1 RID: 1729
			public static readonly Areas_Admin_Views_Client_Create.<>c <>9 = new Areas_Admin_Views_Client_Create.<>c();

			// Token: 0x040006C2 RID: 1730
			public static Func<Task> <>9__23_1;

			// Token: 0x040006C3 RID: 1731
			public static Func<Task> <>9__23_2;

			// Token: 0x040006C4 RID: 1732
			public static Func<Task> <>9__23_5;

			// Token: 0x040006C5 RID: 1733
			public static Func<Task> <>9__23_7;

			// Token: 0x040006C6 RID: 1734
			public static Func<Task> <>9__23_9;

			// Token: 0x040006C7 RID: 1735
			public static Func<Task> <>9__23_11;

			// Token: 0x040006C8 RID: 1736
			public static Func<Task> <>9__23_13;

			// Token: 0x040006C9 RID: 1737
			public static Func<Task> <>9__23_15;

			// Token: 0x040006CA RID: 1738
			public static Func<Task> <>9__23_17;

			// Token: 0x040006CB RID: 1739
			public static Func<Task> <>9__23_19;

			// Token: 0x040006CC RID: 1740
			public static Func<Task> <>9__23_21;

			// Token: 0x040006CD RID: 1741
			public static Func<Task> <>9__23_23;

			// Token: 0x040006CE RID: 1742
			public static Func<Task> <>9__23_25;

			// Token: 0x040006CF RID: 1743
			public static Func<Task> <>9__23_27;

			// Token: 0x040006D0 RID: 1744
			public static Func<Task> <>9__23_29;

			// Token: 0x040006D1 RID: 1745
			public static Func<Task> <>9__23_31;

			// Token: 0x040006D2 RID: 1746
			public static Func<Task> <>9__23_33;

			// Token: 0x040006D3 RID: 1747
			public static Func<Task> <>9__23_35;

			// Token: 0x020002B0 RID: 688
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_11>d : IAsyncStateMachine
			{
				// Token: 0x06000E6E RID: 3694 RVA: 0x00071F5C File Offset: 0x0007015C
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

				// Token: 0x06000E6F RID: 3695 RVA: 0x00071FAC File Offset: 0x000701AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E01 RID: 3585
				public int <>1__state;

				// Token: 0x04000E02 RID: 3586
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B1 RID: 689
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_13>d : IAsyncStateMachine
			{
				// Token: 0x06000E70 RID: 3696 RVA: 0x00071FBC File Offset: 0x000701BC
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

				// Token: 0x06000E71 RID: 3697 RVA: 0x0007200C File Offset: 0x0007020C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E03 RID: 3587
				public int <>1__state;

				// Token: 0x04000E04 RID: 3588
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B2 RID: 690
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_15>d : IAsyncStateMachine
			{
				// Token: 0x06000E72 RID: 3698 RVA: 0x0007201C File Offset: 0x0007021C
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

				// Token: 0x06000E73 RID: 3699 RVA: 0x0007206C File Offset: 0x0007026C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E05 RID: 3589
				public int <>1__state;

				// Token: 0x04000E06 RID: 3590
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B3 RID: 691
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_17>d : IAsyncStateMachine
			{
				// Token: 0x06000E74 RID: 3700 RVA: 0x0007207C File Offset: 0x0007027C
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

				// Token: 0x06000E75 RID: 3701 RVA: 0x000720CC File Offset: 0x000702CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E07 RID: 3591
				public int <>1__state;

				// Token: 0x04000E08 RID: 3592
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B4 RID: 692
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_19>d : IAsyncStateMachine
			{
				// Token: 0x06000E76 RID: 3702 RVA: 0x000720DC File Offset: 0x000702DC
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

				// Token: 0x06000E77 RID: 3703 RVA: 0x0007212C File Offset: 0x0007032C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E09 RID: 3593
				public int <>1__state;

				// Token: 0x04000E0A RID: 3594
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B5 RID: 693
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_1>d : IAsyncStateMachine
			{
				// Token: 0x06000E78 RID: 3704 RVA: 0x0007213C File Offset: 0x0007033C
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

				// Token: 0x06000E79 RID: 3705 RVA: 0x0007218C File Offset: 0x0007038C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E0B RID: 3595
				public int <>1__state;

				// Token: 0x04000E0C RID: 3596
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B6 RID: 694
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_21>d : IAsyncStateMachine
			{
				// Token: 0x06000E7A RID: 3706 RVA: 0x0007219C File Offset: 0x0007039C
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

				// Token: 0x06000E7B RID: 3707 RVA: 0x000721EC File Offset: 0x000703EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E0D RID: 3597
				public int <>1__state;

				// Token: 0x04000E0E RID: 3598
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B7 RID: 695
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_23>d : IAsyncStateMachine
			{
				// Token: 0x06000E7C RID: 3708 RVA: 0x000721FC File Offset: 0x000703FC
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

				// Token: 0x06000E7D RID: 3709 RVA: 0x0007224C File Offset: 0x0007044C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E0F RID: 3599
				public int <>1__state;

				// Token: 0x04000E10 RID: 3600
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B8 RID: 696
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_25>d : IAsyncStateMachine
			{
				// Token: 0x06000E7E RID: 3710 RVA: 0x0007225C File Offset: 0x0007045C
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

				// Token: 0x06000E7F RID: 3711 RVA: 0x000722AC File Offset: 0x000704AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E11 RID: 3601
				public int <>1__state;

				// Token: 0x04000E12 RID: 3602
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002B9 RID: 697
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_27>d : IAsyncStateMachine
			{
				// Token: 0x06000E80 RID: 3712 RVA: 0x000722BC File Offset: 0x000704BC
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

				// Token: 0x06000E81 RID: 3713 RVA: 0x0007230C File Offset: 0x0007050C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E13 RID: 3603
				public int <>1__state;

				// Token: 0x04000E14 RID: 3604
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BA RID: 698
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_29>d : IAsyncStateMachine
			{
				// Token: 0x06000E82 RID: 3714 RVA: 0x0007231C File Offset: 0x0007051C
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

				// Token: 0x06000E83 RID: 3715 RVA: 0x0007236C File Offset: 0x0007056C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E15 RID: 3605
				public int <>1__state;

				// Token: 0x04000E16 RID: 3606
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BB RID: 699
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_2>d : IAsyncStateMachine
			{
				// Token: 0x06000E84 RID: 3716 RVA: 0x0007237C File Offset: 0x0007057C
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

				// Token: 0x06000E85 RID: 3717 RVA: 0x000723CC File Offset: 0x000705CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E17 RID: 3607
				public int <>1__state;

				// Token: 0x04000E18 RID: 3608
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BC RID: 700
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_31>d : IAsyncStateMachine
			{
				// Token: 0x06000E86 RID: 3718 RVA: 0x000723DC File Offset: 0x000705DC
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

				// Token: 0x06000E87 RID: 3719 RVA: 0x0007242C File Offset: 0x0007062C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E19 RID: 3609
				public int <>1__state;

				// Token: 0x04000E1A RID: 3610
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BD RID: 701
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_33>d : IAsyncStateMachine
			{
				// Token: 0x06000E88 RID: 3720 RVA: 0x0007243C File Offset: 0x0007063C
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

				// Token: 0x06000E89 RID: 3721 RVA: 0x0007248C File Offset: 0x0007068C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E1B RID: 3611
				public int <>1__state;

				// Token: 0x04000E1C RID: 3612
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BE RID: 702
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_35>d : IAsyncStateMachine
			{
				// Token: 0x06000E8A RID: 3722 RVA: 0x0007249C File Offset: 0x0007069C
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

				// Token: 0x06000E8B RID: 3723 RVA: 0x000724EC File Offset: 0x000706EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E1D RID: 3613
				public int <>1__state;

				// Token: 0x04000E1E RID: 3614
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002BF RID: 703
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_5>d : IAsyncStateMachine
			{
				// Token: 0x06000E8C RID: 3724 RVA: 0x000724FC File Offset: 0x000706FC
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

				// Token: 0x06000E8D RID: 3725 RVA: 0x0007254C File Offset: 0x0007074C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E1F RID: 3615
				public int <>1__state;

				// Token: 0x04000E20 RID: 3616
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C0 RID: 704
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_7>d : IAsyncStateMachine
			{
				// Token: 0x06000E8E RID: 3726 RVA: 0x0007255C File Offset: 0x0007075C
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

				// Token: 0x06000E8F RID: 3727 RVA: 0x000725AC File Offset: 0x000707AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E21 RID: 3617
				public int <>1__state;

				// Token: 0x04000E22 RID: 3618
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C1 RID: 705
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_9>d : IAsyncStateMachine
			{
				// Token: 0x06000E90 RID: 3728 RVA: 0x000725BC File Offset: 0x000707BC
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

				// Token: 0x06000E91 RID: 3729 RVA: 0x0007260C File Offset: 0x0007080C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E23 RID: 3619
				public int <>1__state;

				// Token: 0x04000E24 RID: 3620
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200010B RID: 267
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__23 : IAsyncStateMachine
		{
			// Token: 0x06000966 RID: 2406 RVA: 0x0003007C File Offset: 0x0002E27C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Create areas_Admin_Views_Client_Create = this.<>4__this;
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
							goto IL_01C4;
						}
						areas_Admin_Views_Client_Create.WriteLiteral("<div class=\"clearfix\"></div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"x_panel\">\r\n            <div class=\"x_title\">\r\n                <h2>UAS Client <small>Create a new client</small></h2>\r\n                <ul class=\"nav navbar-right panel_toolbox\">\r\n                </ul>\r\n                <div class=\"clearfix\"></div>\r\n            </div>\r\n            <div class=\"x_content\">\r\n                ");
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "6ae7716398d91855f089e05ac30a9dcb1d832c25398c5cf005807165b99d4f868250", new Func<Task>(areas_Admin_Views_Client_Create.<ExecuteAsync>b__23_0));
						areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_Client_Create.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_Client_Create.BeginWriteTagHelperAttribute();
						areas_Admin_Views_Client_Create.__tagHelperStringValueBuffer = areas_Admin_Views_Client_Create.EndWriteTagHelperAttribute();
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute("data-parsley-validate", areas_Admin_Views_Client_Create.Html.Raw(areas_Admin_Views_Client_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_9);
						areas_Admin_Views_Client_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_Client_Create.__tagHelperAttribute_10.Value;
						areas_Admin_Views_Client_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Create.__tagHelperAttribute_10);
						awaiter2 = areas_Admin_Views_Client_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<ExecuteAsync>d__23>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01CB;
					}
					awaiter = areas_Admin_Views_Client_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Create.<ExecuteAsync>d__23>(ref awaiter, ref this);
						return;
					}
					IL_01C4:
					awaiter.GetResult();
					IL_01CB:
					areas_Admin_Views_Client_Create.Write(areas_Admin_Views_Client_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Client_Create.__tagHelperExecutionContext = areas_Admin_Views_Client_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_Client_Create.WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

			// Token: 0x06000967 RID: 2407 RVA: 0x000302CC File Offset: 0x0002E4CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006D4 RID: 1748
			public int <>1__state;

			// Token: 0x040006D5 RID: 1749
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006D6 RID: 1750
			public Areas_Admin_Views_Client_Create <>4__this;

			// Token: 0x040006D7 RID: 1751
			private TaskAwaiter <>u__1;
		}
	}
}
