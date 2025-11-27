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
	// Token: 0x0200003F RID: 63
	[RazorSourceChecksum("SHA256", "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd", "/Areas/Admin/Views/Windows/Index.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Windows/Index.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Windows_Index : BaseRazorPage<WindowsConfigViewModel>
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000BAF7 File Offset: 0x00009CF7
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

		// Token: 0x060002AB RID: 683 RVA: 0x0000BB2C File Offset: 0x00009D2C
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Windows_Index.<ExecuteAsync>d__26 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<ExecuteAsync>d__26>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000BB6F File Offset: 0x00009D6F
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000BB77 File Offset: 0x00009D77
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000BB80 File Offset: 0x00009D80
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000BB88 File Offset: 0x00009D88
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000BB91 File Offset: 0x00009D91
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000BB99 File Offset: 0x00009D99
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000BBA2 File Offset: 0x00009DA2
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000BBAA File Offset: 0x00009DAA
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000BBB3 File Offset: 0x00009DB3
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000BBBB File Offset: 0x00009DBB
		[RazorInject]
		public IHtmlHelper<WindowsConfigViewModel> Html { get; private set; }

		// Token: 0x060002B8 RID: 696 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_0()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d <<ExecuteAsync>b__26_0>d;
			<<ExecuteAsync>b__26_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_0>d.<>4__this = this;
			<<ExecuteAsync>b__26_0>d.<>1__state = -1;
			<<ExecuteAsync>b__26_0>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref <<ExecuteAsync>b__26_0>d);
			return <<ExecuteAsync>b__26_0>d.<>t__builder.Task;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BD40 File Offset: 0x00009F40
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_4()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_4>d <<ExecuteAsync>b__26_4>d;
			<<ExecuteAsync>b__26_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_4>d.<>4__this = this;
			<<ExecuteAsync>b__26_4>d.<>1__state = -1;
			<<ExecuteAsync>b__26_4>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_4>d>(ref <<ExecuteAsync>b__26_4>d);
			return <<ExecuteAsync>b__26_4>d.<>t__builder.Task;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000BD84 File Offset: 0x00009F84
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_10()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_10>d <<ExecuteAsync>b__26_10>d;
			<<ExecuteAsync>b__26_10>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_10>d.<>4__this = this;
			<<ExecuteAsync>b__26_10>d.<>1__state = -1;
			<<ExecuteAsync>b__26_10>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_10>d>(ref <<ExecuteAsync>b__26_10>d);
			return <<ExecuteAsync>b__26_10>d.<>t__builder.Task;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_16()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_16>d <<ExecuteAsync>b__26_16>d;
			<<ExecuteAsync>b__26_16>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_16>d.<>4__this = this;
			<<ExecuteAsync>b__26_16>d.<>1__state = -1;
			<<ExecuteAsync>b__26_16>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_16>d>(ref <<ExecuteAsync>b__26_16>d);
			return <<ExecuteAsync>b__26_16>d.<>t__builder.Task;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000BE0C File Offset: 0x0000A00C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_22()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_22>d <<ExecuteAsync>b__26_22>d;
			<<ExecuteAsync>b__26_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_22>d.<>4__this = this;
			<<ExecuteAsync>b__26_22>d.<>1__state = -1;
			<<ExecuteAsync>b__26_22>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_22>d>(ref <<ExecuteAsync>b__26_22>d);
			return <<ExecuteAsync>b__26_22>d.<>t__builder.Task;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000BE50 File Offset: 0x0000A050
		[CompilerGenerated]
		private Task <ExecuteAsync>b__26_36()
		{
			Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_36>d <<ExecuteAsync>b__26_36>d;
			<<ExecuteAsync>b__26_36>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__26_36>d.<>4__this = this;
			<<ExecuteAsync>b__26_36>d.<>1__state = -1;
			<<ExecuteAsync>b__26_36>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_36>d>(ref <<ExecuteAsync>b__26_36>d);
			return <<ExecuteAsync>b__26_36>d.<>t__builder.Task;
		}

		// Token: 0x0400026F RID: 623
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000270 RID: 624
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000271 RID: 625
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", "Enabled", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000272 RID: 626
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("control-label"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000273 RID: 627
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000274 RID: 628
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("name", "DisplayName", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000275 RID: 629
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("name", "WindowsRole", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000276 RID: 630
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("name", "WindowsSourceIdentifier", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000277 RID: 631
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("type", new HtmlString("hidden"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000278 RID: 632
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("asp-route", "Admin/Windows", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000279 RID: 633
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("class", new HtmlString("btn btn-primary"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400027A RID: 634
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400027B RID: 635
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x0400027C RID: 636
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x0400027D RID: 637
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400027E RID: 638
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400027F RID: 639
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000280 RID: 640
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000281 RID: 641
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000282 RID: 642
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x04000283 RID: 643
		private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

		// Token: 0x04000284 RID: 644
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x04000285 RID: 645
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x04000286 RID: 646
		private AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;

		// Token: 0x02000145 RID: 325
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_0>d : IAsyncStateMachine
		{
			// Token: 0x06000A2C RID: 2604 RVA: 0x000426CC File Offset: 0x000408CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
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
					TaskAwaiter awaiter37;
					TaskAwaiter awaiter38;
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
						goto IL_02A1;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0457;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04CC;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_062B;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_06A0;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_083C;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_08B1;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A23;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A99;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0BF9;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C6F;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0E0C;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0E82;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0FF5;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_106B;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_11CB;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1241;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_13B4;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_142A;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_159D;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1613;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1773;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_17E9;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19A8;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1A1E;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1BA1;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1C17;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1D8A;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1E00;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F8D;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2003;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2176;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_21EC;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2379;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_23EF;
					case 36:
						awaiter37 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2505;
					case 37:
						awaiter38 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2578;
					default:
						areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                    <!-- Modal -->\r\n                    <div class=\"modal fade\" id=\"WindowsModal\" tabindex=\"-1\" role=\"dialog\" aria-hidden=\"true\">\r\n                        <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                            <div class=\"modal-content\">\r\n                                <div class=\"modal-body text-center h5\">\r\n                                    ");
						areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.T["To <strong>save</strong> and <strong>apply</strong> the changes, the instance and all related nodes will be totally restarted."]);
						areas_Admin_Views_Windows_Index.WriteLiteral("<br>\r\n                                    \u200b ");
						areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.T["All users will be disconnected."]);
						areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                                </div>\r\n                                <div class=\"modal-footer justify-content-center\">\r\n                                    <button type=\"submit\" class=\"btn btn-danger w-100\">");
						areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.T["I understand the consequences, restart\u200b"]);
						areas_Admin_Views_Windows_Index.WriteLiteral("</button>\r\n                                    <button type=\"button\" class=\"btn btn-success w-100 mb-3\" data-bs-dismiss=\"modal\">");
						areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.T["Cancel changes, don’t restart\u200b"]);
						areas_Admin_Views_Windows_Index.WriteLiteral("</button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    ");
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd11165", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_1));
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02A8;
					}
					awaiter2 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_02A1:
					awaiter2.GetResult();
					IL_02A8:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <div class=\"checkbox\">\r\n                            <label>\r\n                                ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd13058", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_2));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData = areas_Admin_Views_Windows_Index.ViewData;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<WindowsConfigViewModel, bool>(viewData, Expression.Lambda<Func<WindowsConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_2.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_2);
					awaiter3 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0457:
					awaiter3.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04D3;
					}
					awaiter4 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_04CC:
					awaiter4.GetResult();
					IL_04D3:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral(" Active\r\n                            </label>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd15201", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_4));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData2 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider2.CreateModelExpression<WindowsConfigViewModel, string>(viewData2, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter5 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_062B:
					awaiter5.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06A7;
					}
					awaiter6 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_06A0:
					awaiter6.GetResult();
					IL_06A7:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd16908", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_6));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData3 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<WindowsConfigViewModel, string>(viewData3, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_4);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_5.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_5);
					awaiter7 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_083C:
					awaiter7.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08B8;
					}
					awaiter8 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_08B1:
					awaiter8.GetResult();
					IL_08B8:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd18765", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_8));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData4 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider4.CreateModelExpression<WindowsConfigViewModel, string>(viewData4, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_0);
					awaiter9 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A23:
					awaiter9.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0AA0;
					}
					awaiter10 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0A99:
					awaiter10.GetResult();
					IL_0AA0:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        <small>This field is used to set the text button in the login page</small>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd20673", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_10));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData5 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2.For = modelExpressionProvider5.CreateModelExpression<WindowsConfigViewModel, string>(viewData5, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsRole())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter11 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0BF9:
					awaiter11.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0C76;
					}
					awaiter12 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0C6F:
					awaiter12.GetResult();
					IL_0C76:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd22405", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_12));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData6 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider6.CreateModelExpression<WindowsConfigViewModel, string>(viewData6, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsRole())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_4);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_6.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_6);
					awaiter13 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						this.<>1__state = 12;
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0E0C:
					awaiter13.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0E89;
					}
					awaiter14 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						this.<>1__state = 13;
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0E82:
					awaiter14.GetResult();
					IL_0E89:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd24262", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_14));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData7 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider7.CreateModelExpression<WindowsConfigViewModel, string>(viewData7, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsRole())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_0);
					awaiter15 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						this.<>1__state = 14;
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_0FF5:
					awaiter15.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1072;
					}
					awaiter16 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						this.<>1__state = 15;
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_106B:
					awaiter16.GetResult();
					IL_1072:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        <small>This feature is used to filter the windows roles if your organization has a lot of groups.</small>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd26205", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_16));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData8 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3.For = modelExpressionProvider8.CreateModelExpression<WindowsConfigViewModel, string>(viewData8, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter17 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						this.<>1__state = 16;
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_11CB:
					awaiter17.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1248;
					}
					awaiter18 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						this.<>1__state = 17;
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_1241:
					awaiter18.GetResult();
					IL_1248:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd28123", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_18));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData9 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider9.CreateModelExpression<WindowsConfigViewModel, string>(viewData9, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_4);
					awaiter19 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						this.<>1__state = 18;
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_13B4:
					awaiter19.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1431;
					}
					awaiter20 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						this.<>1__state = 19;
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_142A:
					awaiter20.GetResult();
					IL_1431:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd29775", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_20));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData10 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider10.CreateModelExpression<WindowsConfigViewModel, string>(viewData10, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_0);
					awaiter21 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						this.<>1__state = 20;
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_159D:
					awaiter21.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_161A;
					}
					awaiter22 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						this.<>1__state = 21;
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1613:
					awaiter22.GetResult();
					IL_161A:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd31587", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_22));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData11 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4.For = modelExpressionProvider11.CreateModelExpression<WindowsConfigViewModel, string>(viewData11, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsSourceIdentifier())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter23 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						this.<>1__state = 22;
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_1773:
					awaiter23.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_17F0;
					}
					awaiter24 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						this.<>1__state = 23;
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_17E9:
					awaiter24.GetResult();
					IL_17F0:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd33377", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_24));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData12 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider12.CreateModelExpression<WindowsConfigViewModel, string>(viewData12, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsSourceIdentifier())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_7.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_7);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = areas_Admin_Views_Windows_Index.Model.WindowsSourceIdentifiers;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter25 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						this.<>1__state = 24;
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_19A8:
					awaiter25.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1A25;
					}
					awaiter26 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						this.<>1__state = 25;
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1A1E:
					awaiter26.GetResult();
					IL_1A25:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd35682", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_26));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData13 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider13.CreateModelExpression<WindowsConfigViewModel, string>(viewData13, Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_WindowsSourceIdentifier())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_8);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_0);
					awaiter27 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						this.<>1__state = 26;
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1BA1:
					awaiter27.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1C1E;
					}
					awaiter28 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						this.<>1__state = 27;
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1C17:
					awaiter28.GetResult();
					IL_1C1E:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                            <small>Enables to choose the property used to identify connection.</small>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label class=\"control-label\">Authentication schemes</label>\r\n                        <div class=\"form-group\">\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd37861", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_28));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData14 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5.For = modelExpressionProvider14.CreateModelExpression<WindowsConfigViewModel, bool>(viewData14, Expression.Lambda<Func<WindowsConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_Negociate())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter29 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						this.<>1__state = 28;
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1D8A:
					awaiter29.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1E07;
					}
					awaiter30 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						this.<>1__state = 29;
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1E00:
					awaiter30.GetResult();
					IL_1E07:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd39519", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_30));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData15 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider15.CreateModelExpression<WindowsConfigViewModel, bool>(viewData15, Expression.Lambda<Func<WindowsConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_Negociate())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter31 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						this.<>1__state = 30;
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_1F8D:
					awaiter31.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_200A;
					}
					awaiter32 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						this.<>1__state = 31;
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_2003:
					awaiter32.GetResult();
					IL_200A:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd41388", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_32));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData16 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6.For = modelExpressionProvider16.CreateModelExpression<WindowsConfigViewModel, bool>(viewData16, Expression.Lambda<Func<WindowsConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_Basic())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_3);
					awaiter33 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						this.<>1__state = 32;
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_2176:
					awaiter33.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_21F3;
					}
					awaiter34 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						this.<>1__state = 33;
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_21EC:
					awaiter34.GetResult();
					IL_21F3:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                            ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd43042", new Func<Task>(Areas_Admin_Views_Windows_Index.<>c.<>9.<ExecuteAsync>b__26_34));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_1);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_Windows_Index.ModelExpressionProvider;
					ViewDataDictionary<WindowsConfigViewModel> viewData17 = areas_Admin_Views_Windows_Index.ViewData;
					parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider17.CreateModelExpression<WindowsConfigViewModel, bool>(viewData17, Expression.Lambda<Func<WindowsConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_Basic())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter35 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						this.<>1__state = 34;
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_2379:
					awaiter35.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_23F6;
					}
					awaiter36 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						this.<>1__state = 35;
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_23EF:
					awaiter36.GetResult();
					IL_23F6:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group pull-right\">\r\n                        ");
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("a", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd44940", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_36));
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<AnchorTagHelper>();
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
					areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_9.Value;
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_9);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_10);
					awaiter37 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter37.IsCompleted)
					{
						this.<>1__state = 36;
						this.<>u__1 = awaiter37;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter37, ref this);
						return;
					}
					IL_2505:
					awaiter37.GetResult();
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_257F;
					}
					awaiter38 = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter38.IsCompleted)
					{
						this.<>1__state = 37;
						this.<>u__1 = awaiter38;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<<ExecuteAsync>b__26_0>d>(ref awaiter38, ref this);
						return;
					}
					IL_2578:
					awaiter38.GetResult();
					IL_257F:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-success\" data-bs-toggle=\"modal\" data-bs-target=\"#WindowsModal\">Save</button>\r\n                    </div>\r\n                ");
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

			// Token: 0x06000A2D RID: 2605 RVA: 0x00044CD0 File Offset: 0x00042ED0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007D4 RID: 2004
			public int <>1__state;

			// Token: 0x040007D5 RID: 2005
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007D6 RID: 2006
			public Areas_Admin_Views_Windows_Index <>4__this;

			// Token: 0x040007D7 RID: 2007
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000146 RID: 326
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_10>d : IAsyncStateMachine
		{
			// Token: 0x06000A2E RID: 2606 RVA: 0x00044CE0 File Offset: 0x00042EE0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Windows_Index.WriteLiteral("Windows Roles ( separated by \";\" ) ");
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

			// Token: 0x06000A2F RID: 2607 RVA: 0x00044D44 File Offset: 0x00042F44
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007D8 RID: 2008
			public int <>1__state;

			// Token: 0x040007D9 RID: 2009
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007DA RID: 2010
			public Areas_Admin_Views_Windows_Index <>4__this;
		}

		// Token: 0x02000147 RID: 327
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_16>d : IAsyncStateMachine
		{
			// Token: 0x06000A30 RID: 2608 RVA: 0x00044D54 File Offset: 0x00042F54
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_Windows_Index;
					IHtmlHelper<WindowsConfigViewModel> html = areas_Admin_Views_Windows_Index.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(WindowsConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<WindowsConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(WindowsConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x06000A31 RID: 2609 RVA: 0x00044DF8 File Offset: 0x00042FF8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007DB RID: 2011
			public int <>1__state;

			// Token: 0x040007DC RID: 2012
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007DD RID: 2013
			public Areas_Admin_Views_Windows_Index <>4__this;
		}

		// Token: 0x02000148 RID: 328
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_22>d : IAsyncStateMachine
		{
			// Token: 0x06000A32 RID: 2610 RVA: 0x00044E08 File Offset: 0x00043008
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Windows_Index.WriteLiteral("Windows Source Identifier");
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

			// Token: 0x06000A33 RID: 2611 RVA: 0x00044E6C File Offset: 0x0004306C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007DE RID: 2014
			public int <>1__state;

			// Token: 0x040007DF RID: 2015
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007E0 RID: 2016
			public Areas_Admin_Views_Windows_Index <>4__this;
		}

		// Token: 0x02000149 RID: 329
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_36>d : IAsyncStateMachine
		{
			// Token: 0x06000A34 RID: 2612 RVA: 0x00044E7C File Offset: 0x0004307C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Windows_Index.WriteLiteral("Cancel");
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

			// Token: 0x06000A35 RID: 2613 RVA: 0x00044EE0 File Offset: 0x000430E0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007E1 RID: 2017
			public int <>1__state;

			// Token: 0x040007E2 RID: 2018
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007E3 RID: 2019
			public Areas_Admin_Views_Windows_Index <>4__this;
		}

		// Token: 0x0200014A RID: 330
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__26_4>d : IAsyncStateMachine
		{
			// Token: 0x06000A36 RID: 2614 RVA: 0x00044EF0 File Offset: 0x000430F0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
				try
				{
					areas_Admin_Views_Windows_Index.WriteLiteral("Display name");
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

			// Token: 0x06000A37 RID: 2615 RVA: 0x00044F54 File Offset: 0x00043154
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007E4 RID: 2020
			public int <>1__state;

			// Token: 0x040007E5 RID: 2021
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007E6 RID: 2022
			public Areas_Admin_Views_Windows_Index <>4__this;
		}

		// Token: 0x0200014B RID: 331
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A3A RID: 2618 RVA: 0x00044F78 File Offset: 0x00043178
			internal Task <ExecuteAsync>b__26_1()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_1>d <<ExecuteAsync>b__26_1>d;
				<<ExecuteAsync>b__26_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_1>d.<>1__state = -1;
				<<ExecuteAsync>b__26_1>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_1>d>(ref <<ExecuteAsync>b__26_1>d);
				return <<ExecuteAsync>b__26_1>d.<>t__builder.Task;
			}

			// Token: 0x06000A3B RID: 2619 RVA: 0x00044FB4 File Offset: 0x000431B4
			internal Task <ExecuteAsync>b__26_2()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_2>d <<ExecuteAsync>b__26_2>d;
				<<ExecuteAsync>b__26_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_2>d.<>1__state = -1;
				<<ExecuteAsync>b__26_2>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_2>d>(ref <<ExecuteAsync>b__26_2>d);
				return <<ExecuteAsync>b__26_2>d.<>t__builder.Task;
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x00044FF0 File Offset: 0x000431F0
			internal Task <ExecuteAsync>b__26_6()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_6>d <<ExecuteAsync>b__26_6>d;
				<<ExecuteAsync>b__26_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_6>d.<>1__state = -1;
				<<ExecuteAsync>b__26_6>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_6>d>(ref <<ExecuteAsync>b__26_6>d);
				return <<ExecuteAsync>b__26_6>d.<>t__builder.Task;
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x0004502C File Offset: 0x0004322C
			internal Task <ExecuteAsync>b__26_8()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_8>d <<ExecuteAsync>b__26_8>d;
				<<ExecuteAsync>b__26_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_8>d.<>1__state = -1;
				<<ExecuteAsync>b__26_8>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_8>d>(ref <<ExecuteAsync>b__26_8>d);
				return <<ExecuteAsync>b__26_8>d.<>t__builder.Task;
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x00045068 File Offset: 0x00043268
			internal Task <ExecuteAsync>b__26_12()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_12>d <<ExecuteAsync>b__26_12>d;
				<<ExecuteAsync>b__26_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_12>d.<>1__state = -1;
				<<ExecuteAsync>b__26_12>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_12>d>(ref <<ExecuteAsync>b__26_12>d);
				return <<ExecuteAsync>b__26_12>d.<>t__builder.Task;
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x000450A4 File Offset: 0x000432A4
			internal Task <ExecuteAsync>b__26_14()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_14>d <<ExecuteAsync>b__26_14>d;
				<<ExecuteAsync>b__26_14>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_14>d.<>1__state = -1;
				<<ExecuteAsync>b__26_14>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_14>d>(ref <<ExecuteAsync>b__26_14>d);
				return <<ExecuteAsync>b__26_14>d.<>t__builder.Task;
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x000450E0 File Offset: 0x000432E0
			internal Task <ExecuteAsync>b__26_18()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_18>d <<ExecuteAsync>b__26_18>d;
				<<ExecuteAsync>b__26_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_18>d.<>1__state = -1;
				<<ExecuteAsync>b__26_18>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_18>d>(ref <<ExecuteAsync>b__26_18>d);
				return <<ExecuteAsync>b__26_18>d.<>t__builder.Task;
			}

			// Token: 0x06000A41 RID: 2625 RVA: 0x0004511C File Offset: 0x0004331C
			internal Task <ExecuteAsync>b__26_20()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_20>d <<ExecuteAsync>b__26_20>d;
				<<ExecuteAsync>b__26_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_20>d.<>1__state = -1;
				<<ExecuteAsync>b__26_20>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_20>d>(ref <<ExecuteAsync>b__26_20>d);
				return <<ExecuteAsync>b__26_20>d.<>t__builder.Task;
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00045158 File Offset: 0x00043358
			internal Task <ExecuteAsync>b__26_24()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_24>d <<ExecuteAsync>b__26_24>d;
				<<ExecuteAsync>b__26_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_24>d.<>1__state = -1;
				<<ExecuteAsync>b__26_24>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_24>d>(ref <<ExecuteAsync>b__26_24>d);
				return <<ExecuteAsync>b__26_24>d.<>t__builder.Task;
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x00045194 File Offset: 0x00043394
			internal Task <ExecuteAsync>b__26_26()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_26>d <<ExecuteAsync>b__26_26>d;
				<<ExecuteAsync>b__26_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_26>d.<>1__state = -1;
				<<ExecuteAsync>b__26_26>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_26>d>(ref <<ExecuteAsync>b__26_26>d);
				return <<ExecuteAsync>b__26_26>d.<>t__builder.Task;
			}

			// Token: 0x06000A44 RID: 2628 RVA: 0x000451D0 File Offset: 0x000433D0
			internal Task <ExecuteAsync>b__26_28()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_28>d <<ExecuteAsync>b__26_28>d;
				<<ExecuteAsync>b__26_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_28>d.<>1__state = -1;
				<<ExecuteAsync>b__26_28>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_28>d>(ref <<ExecuteAsync>b__26_28>d);
				return <<ExecuteAsync>b__26_28>d.<>t__builder.Task;
			}

			// Token: 0x06000A45 RID: 2629 RVA: 0x0004520C File Offset: 0x0004340C
			internal Task <ExecuteAsync>b__26_30()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_30>d <<ExecuteAsync>b__26_30>d;
				<<ExecuteAsync>b__26_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_30>d.<>1__state = -1;
				<<ExecuteAsync>b__26_30>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_30>d>(ref <<ExecuteAsync>b__26_30>d);
				return <<ExecuteAsync>b__26_30>d.<>t__builder.Task;
			}

			// Token: 0x06000A46 RID: 2630 RVA: 0x00045248 File Offset: 0x00043448
			internal Task <ExecuteAsync>b__26_32()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_32>d <<ExecuteAsync>b__26_32>d;
				<<ExecuteAsync>b__26_32>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_32>d.<>1__state = -1;
				<<ExecuteAsync>b__26_32>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_32>d>(ref <<ExecuteAsync>b__26_32>d);
				return <<ExecuteAsync>b__26_32>d.<>t__builder.Task;
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x00045284 File Offset: 0x00043484
			internal Task <ExecuteAsync>b__26_34()
			{
				Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_34>d <<ExecuteAsync>b__26_34>d;
				<<ExecuteAsync>b__26_34>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__26_34>d.<>1__state = -1;
				<<ExecuteAsync>b__26_34>d.<>t__builder.Start<Areas_Admin_Views_Windows_Index.<>c.<<ExecuteAsync>b__26_34>d>(ref <<ExecuteAsync>b__26_34>d);
				return <<ExecuteAsync>b__26_34>d.<>t__builder.Task;
			}

			// Token: 0x040007E7 RID: 2023
			public static readonly Areas_Admin_Views_Windows_Index.<>c <>9 = new Areas_Admin_Views_Windows_Index.<>c();

			// Token: 0x040007E8 RID: 2024
			public static Func<Task> <>9__26_1;

			// Token: 0x040007E9 RID: 2025
			public static Func<Task> <>9__26_2;

			// Token: 0x040007EA RID: 2026
			public static Func<Task> <>9__26_6;

			// Token: 0x040007EB RID: 2027
			public static Func<Task> <>9__26_8;

			// Token: 0x040007EC RID: 2028
			public static Func<Task> <>9__26_12;

			// Token: 0x040007ED RID: 2029
			public static Func<Task> <>9__26_14;

			// Token: 0x040007EE RID: 2030
			public static Func<Task> <>9__26_18;

			// Token: 0x040007EF RID: 2031
			public static Func<Task> <>9__26_20;

			// Token: 0x040007F0 RID: 2032
			public static Func<Task> <>9__26_24;

			// Token: 0x040007F1 RID: 2033
			public static Func<Task> <>9__26_26;

			// Token: 0x040007F2 RID: 2034
			public static Func<Task> <>9__26_28;

			// Token: 0x040007F3 RID: 2035
			public static Func<Task> <>9__26_30;

			// Token: 0x040007F4 RID: 2036
			public static Func<Task> <>9__26_32;

			// Token: 0x040007F5 RID: 2037
			public static Func<Task> <>9__26_34;

			// Token: 0x02000319 RID: 793
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_12>d : IAsyncStateMachine
			{
				// Token: 0x06000F40 RID: 3904 RVA: 0x000746BC File Offset: 0x000728BC
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

				// Token: 0x06000F41 RID: 3905 RVA: 0x0007470C File Offset: 0x0007290C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ED3 RID: 3795
				public int <>1__state;

				// Token: 0x04000ED4 RID: 3796
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031A RID: 794
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_14>d : IAsyncStateMachine
			{
				// Token: 0x06000F42 RID: 3906 RVA: 0x0007471C File Offset: 0x0007291C
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

				// Token: 0x06000F43 RID: 3907 RVA: 0x0007476C File Offset: 0x0007296C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ED5 RID: 3797
				public int <>1__state;

				// Token: 0x04000ED6 RID: 3798
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031B RID: 795
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_18>d : IAsyncStateMachine
			{
				// Token: 0x06000F44 RID: 3908 RVA: 0x0007477C File Offset: 0x0007297C
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

				// Token: 0x06000F45 RID: 3909 RVA: 0x000747CC File Offset: 0x000729CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ED7 RID: 3799
				public int <>1__state;

				// Token: 0x04000ED8 RID: 3800
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031C RID: 796
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_1>d : IAsyncStateMachine
			{
				// Token: 0x06000F46 RID: 3910 RVA: 0x000747DC File Offset: 0x000729DC
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

				// Token: 0x06000F47 RID: 3911 RVA: 0x0007482C File Offset: 0x00072A2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000ED9 RID: 3801
				public int <>1__state;

				// Token: 0x04000EDA RID: 3802
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031D RID: 797
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_20>d : IAsyncStateMachine
			{
				// Token: 0x06000F48 RID: 3912 RVA: 0x0007483C File Offset: 0x00072A3C
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

				// Token: 0x06000F49 RID: 3913 RVA: 0x0007488C File Offset: 0x00072A8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EDB RID: 3803
				public int <>1__state;

				// Token: 0x04000EDC RID: 3804
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031E RID: 798
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_24>d : IAsyncStateMachine
			{
				// Token: 0x06000F4A RID: 3914 RVA: 0x0007489C File Offset: 0x00072A9C
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

				// Token: 0x06000F4B RID: 3915 RVA: 0x000748EC File Offset: 0x00072AEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EDD RID: 3805
				public int <>1__state;

				// Token: 0x04000EDE RID: 3806
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200031F RID: 799
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_26>d : IAsyncStateMachine
			{
				// Token: 0x06000F4C RID: 3916 RVA: 0x000748FC File Offset: 0x00072AFC
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

				// Token: 0x06000F4D RID: 3917 RVA: 0x0007494C File Offset: 0x00072B4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EDF RID: 3807
				public int <>1__state;

				// Token: 0x04000EE0 RID: 3808
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000320 RID: 800
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_28>d : IAsyncStateMachine
			{
				// Token: 0x06000F4E RID: 3918 RVA: 0x0007495C File Offset: 0x00072B5C
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

				// Token: 0x06000F4F RID: 3919 RVA: 0x000749AC File Offset: 0x00072BAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EE1 RID: 3809
				public int <>1__state;

				// Token: 0x04000EE2 RID: 3810
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000321 RID: 801
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_2>d : IAsyncStateMachine
			{
				// Token: 0x06000F50 RID: 3920 RVA: 0x000749BC File Offset: 0x00072BBC
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

				// Token: 0x06000F51 RID: 3921 RVA: 0x00074A0C File Offset: 0x00072C0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EE3 RID: 3811
				public int <>1__state;

				// Token: 0x04000EE4 RID: 3812
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000322 RID: 802
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_30>d : IAsyncStateMachine
			{
				// Token: 0x06000F52 RID: 3922 RVA: 0x00074A1C File Offset: 0x00072C1C
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

				// Token: 0x06000F53 RID: 3923 RVA: 0x00074A6C File Offset: 0x00072C6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EE5 RID: 3813
				public int <>1__state;

				// Token: 0x04000EE6 RID: 3814
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000323 RID: 803
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_32>d : IAsyncStateMachine
			{
				// Token: 0x06000F54 RID: 3924 RVA: 0x00074A7C File Offset: 0x00072C7C
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

				// Token: 0x06000F55 RID: 3925 RVA: 0x00074ACC File Offset: 0x00072CCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EE7 RID: 3815
				public int <>1__state;

				// Token: 0x04000EE8 RID: 3816
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000324 RID: 804
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_34>d : IAsyncStateMachine
			{
				// Token: 0x06000F56 RID: 3926 RVA: 0x00074ADC File Offset: 0x00072CDC
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

				// Token: 0x06000F57 RID: 3927 RVA: 0x00074B2C File Offset: 0x00072D2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EE9 RID: 3817
				public int <>1__state;

				// Token: 0x04000EEA RID: 3818
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000325 RID: 805
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_6>d : IAsyncStateMachine
			{
				// Token: 0x06000F58 RID: 3928 RVA: 0x00074B3C File Offset: 0x00072D3C
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

				// Token: 0x06000F59 RID: 3929 RVA: 0x00074B8C File Offset: 0x00072D8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EEB RID: 3819
				public int <>1__state;

				// Token: 0x04000EEC RID: 3820
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000326 RID: 806
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__26_8>d : IAsyncStateMachine
			{
				// Token: 0x06000F5A RID: 3930 RVA: 0x00074B9C File Offset: 0x00072D9C
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

				// Token: 0x06000F5B RID: 3931 RVA: 0x00074BEC File Offset: 0x00072DEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EED RID: 3821
				public int <>1__state;

				// Token: 0x04000EEE RID: 3822
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200014C RID: 332
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__26 : IAsyncStateMachine
		{
			// Token: 0x06000A48 RID: 2632 RVA: 0x000452C0 File Offset: 0x000434C0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Windows_Index areas_Admin_Views_Windows_Index = this.<>4__this;
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
						areas_Admin_Views_Windows_Index.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>Windows Configuration</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "54c9aa8e01d92a9f785d79cb3539d61d1c8843b2b31d7058c360885aedc0f4fd8650", new Func<Task>(areas_Admin_Views_Windows_Index.<ExecuteAsync>b__26_0));
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_Windows_Index.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Add(areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_9.Value;
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_9);
						areas_Admin_Views_Windows_Index.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_Windows_Index.__tagHelperAttribute_11.Value;
						areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Windows_Index.__tagHelperAttribute_11);
						awaiter2 = areas_Admin_Views_Windows_Index.__tagHelperRunner.RunAsync(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<ExecuteAsync>d__26>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01B1;
					}
					awaiter = areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Windows_Index.<ExecuteAsync>d__26>(ref awaiter, ref this);
						return;
					}
					IL_01AA:
					awaiter.GetResult();
					IL_01B1:
					areas_Admin_Views_Windows_Index.Write(areas_Admin_Views_Windows_Index.__tagHelperExecutionContext.Output);
					areas_Admin_Views_Windows_Index.__tagHelperExecutionContext = areas_Admin_Views_Windows_Index.__tagHelperScopeManager.End();
					areas_Admin_Views_Windows_Index.WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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

			// Token: 0x06000A49 RID: 2633 RVA: 0x000454F8 File Offset: 0x000436F8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007F6 RID: 2038
			public int <>1__state;

			// Token: 0x040007F7 RID: 2039
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007F8 RID: 2040
			public Areas_Admin_Views_Windows_Index <>4__this;

			// Token: 0x040007F9 RID: 2041
			private TaskAwaiter <>u__1;
		}
	}
}
