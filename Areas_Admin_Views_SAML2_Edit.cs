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
	// Token: 0x0200003A RID: 58
	[RazorSourceChecksum("SHA256", "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd", "/Areas/Admin/Views/SAML2/Edit.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/SAML2/Edit.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_SAML2_Edit : BaseRazorPage<Saml2ConfigViewModel>
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000B10B File Offset: 0x0000930B
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

		// Token: 0x06000259 RID: 601 RVA: 0x0000B140 File Offset: 0x00009340
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_SAML2_Edit.<ExecuteAsync>d__24 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<ExecuteAsync>d__24>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000B183 File Offset: 0x00009383
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000B18B File Offset: 0x0000938B
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000B194 File Offset: 0x00009394
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000B19C File Offset: 0x0000939C
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B1A5 File Offset: 0x000093A5
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B1AD File Offset: 0x000093AD
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000B1B6 File Offset: 0x000093B6
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000B1BE File Offset: 0x000093BE
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000B1C7 File Offset: 0x000093C7
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000B1CF File Offset: 0x000093CF
		[RazorInject]
		public IHtmlHelper<Saml2ConfigViewModel> Html { get; private set; }

		// Token: 0x06000266 RID: 614 RVA: 0x0000B2FC File Offset: 0x000094FC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_0()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d <<ExecuteAsync>b__24_0>d;
			<<ExecuteAsync>b__24_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_0>d.<>4__this = this;
			<<ExecuteAsync>b__24_0>d.<>1__state = -1;
			<<ExecuteAsync>b__24_0>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref <<ExecuteAsync>b__24_0>d);
			return <<ExecuteAsync>b__24_0>d.<>t__builder.Task;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000B340 File Offset: 0x00009540
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_21()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_21>d <<ExecuteAsync>b__24_21>d;
			<<ExecuteAsync>b__24_21>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_21>d.<>4__this = this;
			<<ExecuteAsync>b__24_21>d.<>1__state = -1;
			<<ExecuteAsync>b__24_21>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_21>d>(ref <<ExecuteAsync>b__24_21>d);
			return <<ExecuteAsync>b__24_21>d.<>t__builder.Task;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000B384 File Offset: 0x00009584
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_27()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_27>d <<ExecuteAsync>b__24_27>d;
			<<ExecuteAsync>b__24_27>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_27>d.<>4__this = this;
			<<ExecuteAsync>b__24_27>d.<>1__state = -1;
			<<ExecuteAsync>b__24_27>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_27>d>(ref <<ExecuteAsync>b__24_27>d);
			return <<ExecuteAsync>b__24_27>d.<>t__builder.Task;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000B3C8 File Offset: 0x000095C8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_33()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_33>d <<ExecuteAsync>b__24_33>d;
			<<ExecuteAsync>b__24_33>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_33>d.<>4__this = this;
			<<ExecuteAsync>b__24_33>d.<>1__state = -1;
			<<ExecuteAsync>b__24_33>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_33>d>(ref <<ExecuteAsync>b__24_33>d);
			return <<ExecuteAsync>b__24_33>d.<>t__builder.Task;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000B40C File Offset: 0x0000960C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_39()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_39>d <<ExecuteAsync>b__24_39>d;
			<<ExecuteAsync>b__24_39>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_39>d.<>4__this = this;
			<<ExecuteAsync>b__24_39>d.<>1__state = -1;
			<<ExecuteAsync>b__24_39>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_39>d>(ref <<ExecuteAsync>b__24_39>d);
			return <<ExecuteAsync>b__24_39>d.<>t__builder.Task;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000B450 File Offset: 0x00009650
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_88()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_88>d <<ExecuteAsync>b__24_88>d;
			<<ExecuteAsync>b__24_88>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_88>d.<>4__this = this;
			<<ExecuteAsync>b__24_88>d.<>1__state = -1;
			<<ExecuteAsync>b__24_88>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_88>d>(ref <<ExecuteAsync>b__24_88>d);
			return <<ExecuteAsync>b__24_88>d.<>t__builder.Task;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B494 File Offset: 0x00009694
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_1()
		{
			Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_1>d <<ExecuteAsync>b__24_1>d;
			<<ExecuteAsync>b__24_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_1>d.<>4__this = this;
			<<ExecuteAsync>b__24_1>d.<>1__state = -1;
			<<ExecuteAsync>b__24_1>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_1>d>(ref <<ExecuteAsync>b__24_1>d);
			return <<ExecuteAsync>b__24_1>d.<>t__builder.Task;
		}

		// Token: 0x0400021B RID: 539
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400021C RID: 540
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400021D RID: 541
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400021E RID: 542
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("control-label"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400021F RID: 543
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("onchange", new HtmlString("ModulePathChanged(value);"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000220 RID: 544
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("type", "text", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000221 RID: 545
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("type", "mail", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000222 RID: 546
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("type", "email", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000223 RID: 547
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("asp-route", "Admin/Saml2", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000224 RID: 548
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("class", new HtmlString("btn btn-primary"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000225 RID: 549
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000226 RID: 550
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000227 RID: 551
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000228 RID: 552
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000229 RID: 553
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400022A RID: 554
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x0400022B RID: 555
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x0400022C RID: 556
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x0400022D RID: 557
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x0400022E RID: 558
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x0400022F RID: 559
		private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

		// Token: 0x04000230 RID: 560
		private AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_0>d : IAsyncStateMachine
		{
			// Token: 0x060009D8 RID: 2520 RVA: 0x0003A708 File Offset: 0x00038908
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
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
					TaskAwaiter awaiter39;
					TaskAwaiter awaiter40;
					TaskAwaiter awaiter41;
					TaskAwaiter awaiter42;
					TaskAwaiter awaiter43;
					TaskAwaiter awaiter44;
					TaskAwaiter awaiter45;
					TaskAwaiter awaiter46;
					TaskAwaiter awaiter47;
					TaskAwaiter awaiter48;
					TaskAwaiter awaiter49;
					TaskAwaiter awaiter50;
					TaskAwaiter awaiter51;
					TaskAwaiter awaiter52;
					TaskAwaiter awaiter53;
					TaskAwaiter awaiter54;
					TaskAwaiter awaiter55;
					TaskAwaiter awaiter56;
					TaskAwaiter awaiter57;
					TaskAwaiter awaiter58;
					TaskAwaiter awaiter59;
					TaskAwaiter awaiter60;
					TaskAwaiter awaiter61;
					TaskAwaiter awaiter62;
					TaskAwaiter awaiter63;
					TaskAwaiter awaiter64;
					TaskAwaiter awaiter65;
					TaskAwaiter awaiter66;
					TaskAwaiter awaiter67;
					TaskAwaiter awaiter68;
					TaskAwaiter awaiter69;
					TaskAwaiter awaiter70;
					TaskAwaiter awaiter71;
					TaskAwaiter awaiter72;
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
						goto IL_037D;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_056C;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_05E1;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_07AB;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0820;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0992;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0A07;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0BD1;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C47;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0DBA;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0E30;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0FFB;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1071;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_11E4;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_125A;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_13BA;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1430;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_15A3;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1619;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_178C;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1802;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1962;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19D8;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1B4B;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1BC1;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1D34;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1DAA;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F0A;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F80;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_20F3;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2169;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_22DC;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2352;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_24B2;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2528;
					case 36:
						awaiter37 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_26AB;
					case 37:
						awaiter38 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2721;
					case 38:
						awaiter39 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2894;
					case 39:
						awaiter40 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_290A;
					case 40:
						awaiter41 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2B0D;
					case 41:
						awaiter42 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2B83;
					case 42:
						awaiter43 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2CF6;
					case 43:
						awaiter44 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2D6C;
					case 44:
						awaiter45 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2F5C;
					case 45:
						awaiter46 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2FD2;
					case 46:
						awaiter47 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_31B7;
					case 47:
						awaiter48 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_322D;
					case 48:
						awaiter49 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_346F;
					case 49:
						awaiter50 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_34E5;
					case 50:
						awaiter51 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3732;
					case 51:
						awaiter52 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_37A8;
					case 52:
						awaiter53 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_39EA;
					case 53:
						awaiter54 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3A60;
					case 54:
						awaiter55 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3C55;
					case 55:
						awaiter56 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3CCB;
					case 56:
						awaiter57 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3E3E;
					case 57:
						awaiter58 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3EB4;
					case 58:
						awaiter59 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_40A9;
					case 59:
						awaiter60 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_411F;
					case 60:
						awaiter61 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4292;
					case 61:
						awaiter62 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4308;
					case 62:
						awaiter63 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_44FD;
					case 63:
						awaiter64 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4573;
					case 64:
						awaiter65 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_46E6;
					case 65:
						awaiter66 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_475C;
					case 66:
						awaiter67 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_495C;
					case 67:
						awaiter68 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_49D2;
					case 68:
						awaiter69 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4B45;
					case 69:
						awaiter70 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4BBB;
					case 70:
						awaiter71 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4CD1;
					case 71:
						awaiter72 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4D44;
					default:
						areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n\r\n<div class=\"x_title\">\r\n    <h2><b>SAML2 Configuration</b></h2>\r\n\r\n    <!-- Modals -->\r\n    <div class=\"modal fade\" id=\"SAML2Modal\" tabindex=\"-1\" role=\"dialog\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-body text-center h5\">\r\n                    ");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.T["To <strong>save</strong> and <strong>apply</strong> the changes, the instance and all related nodes will be totally restarted."]);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("<br>\r\n                    ");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.T["All users will be disconnected."]);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer justify-content-center\">\r\n                    <button type=\"submit\" class=\"btn btn-danger w-100\">");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.T["I understand the consequences, restart\u200b"]);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("</button>\r\n                    <button type=\"button\" class=\"btn btn-success w-100 mb-3\" data-bs-dismiss=\"modal\">");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.T["Cancel changes, don’t restart\u200b"]);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"modal fade\" id=\"exampleModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n        <div class=\"modal-dialog\" role=\"document\">\r\n            <div class=\"modal-content\">\r\n                <div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\" id=\"exampleModalLabel\">Information</h5>\r\n                    <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    <label>\r\n                        <strong>Identifier (Entity ID)</strong> : <span>");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.PublicOrigin);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("/uas</span>\r\n                    </label>\r\n                    <label>\r\n                        <strong>Reply URL (Assertion Consumer Service URL)</strong> :<span id=\"AssertionConsumerServiceUrlInModal\"> ");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.PublicOrigin);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("/UAS/");
						areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.ModulePath);
						areas_Admin_Views_SAML2_Edit.WriteLiteral("/Acs</span>\r\n                    </label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"border rounded p-2\">\r\n\r\n");
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd12110", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_2));
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0384;
					}
					awaiter2 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_037D:
					awaiter2.GetResult();
					IL_0384:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n<ul class=\"nav nav-tabs\" role=\"tablist\">\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link active\" href=\"#general\" data-bs-toggle=\"tab\" role=\"tab\" aria-controls=\"general\" aria-selected=\"true\">General</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"#certificate\" data-bs-toggle=\"tab\" role=\"tab\" aria-controls=\"certificate\" aria-selected=\"false\">Certificate and signature</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"#organization\" data-bs-toggle=\"tab\" role=\"tab\" aria-controls=\"organization\" aria-selected=\"false\">Organization</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link\" href=\"#contact\" data-bs-toggle=\"tab\" role=\"tab\" aria-controls=\"contact\" aria-selected=\"false\">Contact</a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <!-- Button trigger modal -->\r\n        <button type=\"button\" class=\"btn btn-sm btn-primary pull-right\" data-bs-toggle=\"modal\"\r\n                data-bs-target=\"#exampleModal\">\r\n            ?\r\n        </butto");
					areas_Admin_Views_SAML2_Edit.WriteLiteral("n>\r\n    </li>\r\n</ul>\r\n\r\n<div class=\"tab-content\">\r\n    <div class=\"tab-pane active\" id=\"general\" role=\"tabpanel\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html = areas_Admin_Views_SAML2_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<bool>(Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd15531", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_4));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<Saml2ConfigViewModel, bool>(viewData, Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1);
					awaiter3 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_056C:
					awaiter3.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_05E8;
					}
					awaiter4 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_05E1:
					awaiter4.GetResult();
					IL_05E8:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase2 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html2 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase2.Write(html2.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd17684", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_7));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData2 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<Saml2ConfigViewModel, string>(viewData2, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter5 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_07AB:
					awaiter5.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0827;
					}
					awaiter6 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_0820:
					awaiter6.GetResult();
					IL_0827:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    <small>The display name which can be shown in the button text on the login page</small>\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd19438", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_9));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData3 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider3.CreateModelExpression<Saml2ConfigViewModel, string>(viewData3, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter7 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_0992:
					awaiter7.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0A0E;
					}
					awaiter8 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_0A07:
					awaiter8.GetResult();
					IL_0A0E:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase3 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html3 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase3.Write(html3.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_EntityId())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd21539", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_12));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData4 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider4.CreateModelExpression<Saml2ConfigViewModel, string>(viewData4, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_EntityId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter9 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0BD1:
					awaiter9.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0C4E;
					}
					awaiter10 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0C47:
					awaiter10.GetResult();
					IL_0C4E:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd23179", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_14));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData5 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider5.CreateModelExpression<Saml2ConfigViewModel, string>(viewData5, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_EntityId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter11 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0DBA:
					awaiter11.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0E37;
					}
					awaiter12 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0E30:
					awaiter12.GetResult();
					IL_0E37:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    <small>The issuer url that the idp will be using when sending responses.</small>\r\n                    <div class=\"form-group\">\r\n                        ");
					RazorPageBase razorPageBase4 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html4 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase4.Write(html4.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_MetadataLocation())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd25375", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_17));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData6 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider6.CreateModelExpression<Saml2ConfigViewModel, string>(viewData6, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_MetadataLocation())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter13 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						this.<>1__state = 12;
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0FFB:
					awaiter13.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1078;
					}
					awaiter14 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						this.<>1__state = 13;
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_1071:
					awaiter14.GetResult();
					IL_1078:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd27027", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_19));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData7 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider7.CreateModelExpression<Saml2ConfigViewModel, string>(viewData7, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_MetadataLocation())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter15 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						this.<>1__state = 14;
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_11E4:
					awaiter15.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1261;
					}
					awaiter16 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						this.<>1__state = 15;
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_125A:
					awaiter16.GetResult();
					IL_1261:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        <small>The url where is located the xml federation medatafile</small>\r\n                    </div>\r\n                  \r\n\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd28958", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_21));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData8 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider8.CreateModelExpression<Saml2ConfigViewModel, string>(viewData8, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_3);
					awaiter17 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						this.<>1__state = 16;
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_13BA:
					awaiter17.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1437;
					}
					awaiter18 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						this.<>1__state = 17;
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_1430:
					awaiter18.GetResult();
					IL_1437:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd30876", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_23));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData9 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider9.CreateModelExpression<Saml2ConfigViewModel, string>(viewData9, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter19 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						this.<>1__state = 18;
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_15A3:
					awaiter19.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1620;
					}
					awaiter20 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						this.<>1__state = 19;
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_1619:
					awaiter20.GetResult();
					IL_1620:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd32528", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_25));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData10 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider10.CreateModelExpression<Saml2ConfigViewModel, string>(viewData10, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter21 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						this.<>1__state = 20;
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_178C:
					awaiter21.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1809;
					}
					awaiter22 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						this.<>1__state = 21;
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1802:
					awaiter22.GetResult();
					IL_1809:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    </div>\r\n                   \r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd34360", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_27));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData11 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2.For = modelExpressionProvider11.CreateModelExpression<Saml2ConfigViewModel, string>(viewData11, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_3);
					awaiter23 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						this.<>1__state = 22;
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_1962:
					awaiter23.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_19DF;
					}
					awaiter24 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						this.<>1__state = 23;
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_19D8:
					awaiter24.GetResult();
					IL_19DF:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd36275", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_29));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData12 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider12.CreateModelExpression<Saml2ConfigViewModel, string>(viewData12, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter25 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						this.<>1__state = 24;
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_1B4B:
					awaiter25.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1BC8;
					}
					awaiter26 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						this.<>1__state = 25;
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1BC1:
					awaiter26.GetResult();
					IL_1BC8:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd37925", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_31));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData13 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider13.CreateModelExpression<Saml2ConfigViewModel, string>(viewData13, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter27 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						this.<>1__state = 26;
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1D34:
					awaiter27.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1DB1;
					}
					awaiter28 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						this.<>1__state = 27;
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1DAA:
					awaiter28.GetResult();
					IL_1DB1:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    </div>\r\n\r\n                     <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd39736", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_33));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData14 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3.For = modelExpressionProvider14.CreateModelExpression<Saml2ConfigViewModel, string>(viewData14, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_3);
					awaiter29 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						this.<>1__state = 28;
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1F0A:
					awaiter29.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1F87;
					}
					awaiter30 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						this.<>1__state = 29;
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1F80:
					awaiter30.GetResult();
					IL_1F87:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd41647", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_35));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData15 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider15.CreateModelExpression<Saml2ConfigViewModel, string>(viewData15, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter31 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						this.<>1__state = 30;
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_20F3:
					awaiter31.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2170;
					}
					awaiter32 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						this.<>1__state = 31;
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_2169:
					awaiter32.GetResult();
					IL_2170:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd43295", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_37));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData16 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6.For = modelExpressionProvider16.CreateModelExpression<Saml2ConfigViewModel, string>(viewData16, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter33 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						this.<>1__state = 32;
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_22DC:
					awaiter33.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2359;
					}
					awaiter34 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						this.<>1__state = 33;
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_2352:
					awaiter34.GetResult();
					IL_2359:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd45103", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_39));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData17 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4.For = modelExpressionProvider17.CreateModelExpression<Saml2ConfigViewModel, string>(viewData17, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ModulePath())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_3);
					awaiter35 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						this.<>1__state = 34;
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_24B2:
					awaiter35.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_252F;
					}
					awaiter36 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						this.<>1__state = 35;
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_2528:
					awaiter36.GetResult();
					IL_252F:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd47012", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_41));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider18 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData18 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider18.CreateModelExpression<Saml2ConfigViewModel, string>(viewData18, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ModulePath())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_4);
					awaiter37 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter37.IsCompleted)
					{
						this.<>1__state = 36;
						this.<>u__1 = awaiter37;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter37, ref this);
						return;
					}
					IL_26AB:
					awaiter37.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2728;
					}
					awaiter38 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter38.IsCompleted)
					{
						this.<>1__state = 37;
						this.<>u__1 = awaiter38;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter38, ref this);
						return;
					}
					IL_2721:
					awaiter38.GetResult();
					IL_2728:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd48746", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_43));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider19 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData19 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7.For = modelExpressionProvider19.CreateModelExpression<Saml2ConfigViewModel, string>(viewData19, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ModulePath())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter39 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter39.IsCompleted)
					{
						this.<>1__state = 38;
						this.<>u__1 = awaiter39;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter39, ref this);
						return;
					}
					IL_2894:
					awaiter39.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2911;
					}
					awaiter40 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter40.IsCompleted)
					{
						this.<>1__state = 39;
						this.<>u__1 = awaiter40;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter40, ref this);
						return;
					}
					IL_290A:
					awaiter40.GetResult();
					IL_2911:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                        <small>Application root relative path for Saml2 endpoints. The default is \"AuthServices\".</small>\r\n                        <p><small id=\"AssertionConsumerServiceUrl\">Assertion Consumer EndPoint: ");
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.PublicOrigin);
					areas_Admin_Views_SAML2_Edit.WriteLiteral("/UAS/");
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.ModulePath);
					areas_Admin_Views_SAML2_Edit.WriteLiteral("/Acs</small></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"tab-pane\" id=\"certificate\" role=\"tabpanel\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase5 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html5 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase5.Write(html5.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateName())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd51854", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_46));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider20 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData20 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider20.CreateModelExpression<Saml2ConfigViewModel, string>(viewData20, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					awaiter41 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter41.IsCompleted)
					{
						this.<>1__state = 40;
						this.<>u__1 = awaiter41;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter41, ref this);
						return;
					}
					IL_2B0D:
					awaiter41.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2B8A;
					}
					awaiter42 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter42.IsCompleted)
					{
						this.<>1__state = 41;
						this.<>u__1 = awaiter42;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter42, ref this);
						return;
					}
					IL_2B83:
					awaiter42.GetResult();
					IL_2B8A:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd53502", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_48));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider21 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData21 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8.For = modelExpressionProvider21.CreateModelExpression<Saml2ConfigViewModel, string>(viewData21, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter43 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter43.IsCompleted)
					{
						this.<>1__state = 42;
						this.<>u__1 = awaiter43;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter43, ref this);
						return;
					}
					IL_2CF6:
					awaiter43.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2D73;
					}
					awaiter44 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter44.IsCompleted)
					{
						this.<>1__state = 43;
						this.<>u__1 = awaiter44;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter44, ref this);
						return;
					}
					IL_2D6C:
					awaiter44.GetResult();
					IL_2D73:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                \r\n");
					areas_Admin_Views_SAML2_Edit.WriteLiteral("                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase6 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html6 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase6.Write(html6.DisplayNameFor<bool>(Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_WantAssertionSigned())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd55676", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_51));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider22 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData22 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider22.CreateModelExpression<Saml2ConfigViewModel, bool>(viewData22, Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_WantAssertionSigned())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1);
					awaiter45 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter45.IsCompleted)
					{
						this.<>1__state = 44;
						this.<>u__1 = awaiter45;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter45, ref this);
						return;
					}
					IL_2F5C:
					awaiter45.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2FD9;
					}
					awaiter46 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter46.IsCompleted)
					{
						this.<>1__state = 45;
						this.<>u__1 = awaiter46;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter46, ref this);
						return;
					}
					IL_2FD2:
					awaiter46.GetResult();
					IL_2FD9:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase7 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html7 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase7.Write(html7.DisplayNameFor<bool>(Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_WantAuthnRequestsSigned())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd57856", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_54));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider23 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData23 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11.For = modelExpressionProvider23.CreateModelExpression<Saml2ConfigViewModel, bool>(viewData23, Expression.Lambda<Func<Saml2ConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_WantAuthnRequestsSigned())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_1);
					awaiter47 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter47.IsCompleted)
					{
						this.<>1__state = 46;
						this.<>u__1 = awaiter47;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter47, ref this);
						return;
					}
					IL_31B7:
					awaiter47.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3234;
					}
					awaiter48 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter48.IsCompleted)
					{
						this.<>1__state = 47;
						this.<>u__1 = awaiter48;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter48, ref this);
						return;
					}
					IL_322D:
					awaiter48.GetResult();
					IL_3234:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\"> \r\n                    ");
					RazorPageBase razorPageBase8 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html8 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase8.Write(html8.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_AuthenticateRequestSigningBehavior())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					RazorPageBase razorPageBase9 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html9 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "m");
					razorPageBase9.Write(html9.DropDownListFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_AuthenticateRequestSigningBehavior())), new ParameterExpression[] { parameterExpression }), areas_Admin_Views_SAML2_Edit.Model.SigningBehaviors, "- Please select your signing Behaviors -", new
					{
						@class = "form-select  col-md-7 col-xs-12",
						id = "SigningBehaviors"
					}));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd60639", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_58));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper9 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider24 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData24 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper9.For = modelExpressionProvider24.CreateModelExpression<Saml2ConfigViewModel, string>(viewData24, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_AuthenticateRequestSigningBehavior())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter49 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter49.IsCompleted)
					{
						this.<>1__state = 48;
						this.<>u__1 = awaiter49;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter49, ref this);
						return;
					}
					IL_346F:
					awaiter49.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_34EC;
					}
					awaiter50 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter50.IsCompleted)
					{
						this.<>1__state = 49;
						this.<>u__1 = awaiter50;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter50, ref this);
						return;
					}
					IL_34E5:
					awaiter50.GetResult();
					IL_34EC:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n\r\n");
					areas_Admin_Views_SAML2_Edit.WriteLiteral("            <div class=\"form-group\"> \r\n                    ");
					RazorPageBase razorPageBase10 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html10 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase10.Write(html10.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OutboundSigningAlgorithm())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					RazorPageBase razorPageBase11 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html11 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "m");
					razorPageBase11.Write(html11.DropDownListFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OutboundSigningAlgorithm())), new ParameterExpression[] { parameterExpression }), areas_Admin_Views_SAML2_Edit.Model.SigninAlgorithms, "- Please select your signing Algorithm -", new
					{
						@class = "form-select  col-md-7 col-xs-12",
						id = "SigninAlgorithms"
					}));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd63395", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_62));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper10 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider25 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData25 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper10.For = modelExpressionProvider25.CreateModelExpression<Saml2ConfigViewModel, string>(viewData25, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OutboundSigningAlgorithm())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter51 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter51.IsCompleted)
					{
						this.<>1__state = 50;
						this.<>u__1 = awaiter51;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter51, ref this);
						return;
					}
					IL_3732:
					awaiter51.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_37AF;
					}
					awaiter52 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter52.IsCompleted)
					{
						this.<>1__state = 51;
						this.<>u__1 = awaiter52;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter52, ref this);
						return;
					}
					IL_37A8:
					awaiter52.GetResult();
					IL_37AF:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase12 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html12 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase12.Write(html12.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateUse())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					RazorPageBase razorPageBase13 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html13 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "m");
					razorPageBase13.Write(html13.DropDownListFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateUse())), new ParameterExpression[] { parameterExpression }), areas_Admin_Views_SAML2_Edit.Model.CertificateUses, "- Please select your certificate use -", new
					{
						@class = "form-select  col-md-7 col-xs-12",
						id = "CertificateUse"
					}));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd66088", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_66));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper11 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider26 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData26 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper11.For = modelExpressionProvider26.CreateModelExpression<Saml2ConfigViewModel, string>(viewData26, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_CertificateUse())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter53 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter53.IsCompleted)
					{
						this.<>1__state = 52;
						this.<>u__1 = awaiter53;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter53, ref this);
						return;
					}
					IL_39EA:
					awaiter53.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3A67;
					}
					awaiter54 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter54.IsCompleted)
					{
						this.<>1__state = 53;
						this.<>u__1 = awaiter54;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter54, ref this);
						return;
					}
					IL_3A60:
					awaiter54.GetResult();
					IL_3A67:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"tab-pane\" id=\"organization\" role=\"tabpanel\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase14 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html14 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase14.Write(html14.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationName())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd68399", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_69));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider27 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData27 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12.For = modelExpressionProvider27.CreateModelExpression<Saml2ConfigViewModel, string>(viewData27, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_5.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_5);
					awaiter55 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter55.IsCompleted)
					{
						this.<>1__state = 54;
						this.<>u__1 = awaiter55;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter55, ref this);
						return;
					}
					IL_3C55:
					awaiter55.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3CD2;
					}
					awaiter56 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter56.IsCompleted)
					{
						this.<>1__state = 55;
						this.<>u__1 = awaiter56;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter56, ref this);
						return;
					}
					IL_3CCB:
					awaiter56.GetResult();
					IL_3CD2:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd70264", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_71));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper12 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider28 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData28 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper12.For = modelExpressionProvider28.CreateModelExpression<Saml2ConfigViewModel, string>(viewData28, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter57 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter57.IsCompleted)
					{
						this.<>1__state = 56;
						this.<>u__1 = awaiter57;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter57, ref this);
						return;
					}
					IL_3E3E:
					awaiter57.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3EBB;
					}
					awaiter58 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter58.IsCompleted)
					{
						this.<>1__state = 57;
						this.<>u__1 = awaiter58;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter58, ref this);
						return;
					}
					IL_3EB4:
					awaiter58.GetResult();
					IL_3EBB:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase15 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html15 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase15.Write(html15.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationEmail())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd72382", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_74));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider29 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData29 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13.For = modelExpressionProvider29.CreateModelExpression<Saml2ConfigViewModel, string>(viewData29, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationEmail())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_6.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_6);
					awaiter59 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter59.IsCompleted)
					{
						this.<>1__state = 58;
						this.<>u__1 = awaiter59;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter59, ref this);
						return;
					}
					IL_40A9:
					awaiter59.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4126;
					}
					awaiter60 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter60.IsCompleted)
					{
						this.<>1__state = 59;
						this.<>u__1 = awaiter60;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter60, ref this);
						return;
					}
					IL_411F:
					awaiter60.GetResult();
					IL_4126:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd74248", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_76));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper13 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider30 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData30 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper13.For = modelExpressionProvider30.CreateModelExpression<Saml2ConfigViewModel, string>(viewData30, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationEmail())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter61 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter61.IsCompleted)
					{
						this.<>1__state = 60;
						this.<>u__1 = awaiter61;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter61, ref this);
						return;
					}
					IL_4292:
					awaiter61.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_430F;
					}
					awaiter62 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter62.IsCompleted)
					{
						this.<>1__state = 61;
						this.<>u__1 = awaiter62;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter62, ref this);
						return;
					}
					IL_4308:
					awaiter62.GetResult();
					IL_430F:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase16 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html16 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase16.Write(html16.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationUrl())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd76365", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_79));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider31 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData31 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14.For = modelExpressionProvider31.CreateModelExpression<Saml2ConfigViewModel, string>(viewData31, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationUrl())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_5.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_5);
					awaiter63 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter63.IsCompleted)
					{
						this.<>1__state = 62;
						this.<>u__1 = awaiter63;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter63, ref this);
						return;
					}
					IL_44FD:
					awaiter63.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_457A;
					}
					awaiter64 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter64.IsCompleted)
					{
						this.<>1__state = 63;
						this.<>u__1 = awaiter64;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter64, ref this);
						return;
					}
					IL_4573:
					awaiter64.GetResult();
					IL_457A:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd78229", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_81));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper14 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider32 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData32 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper14.For = modelExpressionProvider32.CreateModelExpression<Saml2ConfigViewModel, string>(viewData32, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_OrganizationUrl())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter65 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter65.IsCompleted)
					{
						this.<>1__state = 64;
						this.<>u__1 = awaiter65;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter65, ref this);
						return;
					}
					IL_46E6:
					awaiter65.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4763;
					}
					awaiter66 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter66.IsCompleted)
					{
						this.<>1__state = 65;
						this.<>u__1 = awaiter66;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter66, ref this);
						return;
					}
					IL_475C:
					awaiter66.GetResult();
					IL_4763:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"tab-pane\" id=\"contact\" role=\"tabpanel\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-body\">\r\n");
					areas_Admin_Views_SAML2_Edit.WriteLiteral("                <div class=\"form-group\">\r\n                    ");
					RazorPageBase razorPageBase17 = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html17 = areas_Admin_Views_SAML2_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase17.Write(html17.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ContactEmail())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd80584", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_84));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider33 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData33 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15.For = modelExpressionProvider33.CreateModelExpression<Saml2ConfigViewModel, string>(viewData33, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ContactEmail())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_7.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_7);
					awaiter67 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter67.IsCompleted)
					{
						this.<>1__state = 66;
						this.<>u__1 = awaiter67;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter67, ref this);
						return;
					}
					IL_495C:
					awaiter67.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_49D9;
					}
					awaiter68 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter68.IsCompleted)
					{
						this.<>1__state = 67;
						this.<>u__1 = awaiter68;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter68, ref this);
						return;
					}
					IL_49D2:
					awaiter68.GetResult();
					IL_49D9:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd82445", new Func<Task>(Areas_Admin_Views_SAML2_Edit.<>c.<>9.<ExecuteAsync>b__24_86));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper15 = areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider34 = areas_Admin_Views_SAML2_Edit.ModelExpressionProvider;
					ViewDataDictionary<Saml2ConfigViewModel> viewData34 = areas_Admin_Views_SAML2_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper15.For = modelExpressionProvider34.CreateModelExpression<Saml2ConfigViewModel, string>(viewData34, Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ContactEmail())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_0);
					awaiter69 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter69.IsCompleted)
					{
						this.<>1__state = 68;
						this.<>u__1 = awaiter69;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter69, ref this);
						return;
					}
					IL_4B45:
					awaiter69.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4BC2;
					}
					awaiter70 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter70.IsCompleted)
					{
						this.<>1__state = 69;
						this.<>u__1 = awaiter70;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter70, ref this);
						return;
					}
					IL_4BBB:
					awaiter70.GetResult();
					IL_4BC2:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class=\"form-group pull-right\">\r\n    ");
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("a", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd84293", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_88));
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<AnchorTagHelper>();
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
					areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_8.Value;
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_8);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_9);
					awaiter71 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter71.IsCompleted)
					{
						this.<>1__state = 70;
						this.<>u__1 = awaiter71;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter71, ref this);
						return;
					}
					IL_4CD1:
					awaiter71.GetResult();
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4D4B;
					}
					awaiter72 = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter72.IsCompleted)
					{
						this.<>1__state = 71;
						this.<>u__1 = awaiter72;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter72, ref this);
						return;
					}
					IL_4D44:
					awaiter72.GetResult();
					IL_4D4B:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n    <button type=\"button\" class=\"btn btn-success\" data-bs-toggle=\"modal\" data-bs-target=\"#SAML2Modal\">Save</button>\r\n</div>\r\n</div>\r\n");
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

			// Token: 0x060009D9 RID: 2521 RVA: 0x0003F4D8 File Offset: 0x0003D6D8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000767 RID: 1895
			public int <>1__state;

			// Token: 0x04000768 RID: 1896
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000769 RID: 1897
			public Areas_Admin_Views_SAML2_Edit <>4__this;

			// Token: 0x0400076A RID: 1898
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_1>d : IAsyncStateMachine
		{
			// Token: 0x060009DA RID: 2522 RVA: 0x0003F4E8 File Offset: 0x0003D6E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n    <script>\r\n        function ModulePathChanged(value) {\r\n            var publicOrigin = \"");
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.Model.PublicOrigin);
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\";\r\n            var url = publicOrigin + \"/UAS/\" + value + \"/Acs\";\r\n            $(\"#AssertionConsumerServiceUrl\").text(\"Assertion Consumer EndPoint: \" + url);\r\n            $(\"#AssertionConsumerServiceUrlInModal\").text(url);\r\n        }\r\n    </script>\r\n");
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

			// Token: 0x060009DB RID: 2523 RVA: 0x0003F568 File Offset: 0x0003D768
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400076B RID: 1899
			public int <>1__state;

			// Token: 0x0400076C RID: 1900
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400076D RID: 1901
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000130 RID: 304
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_21>d : IAsyncStateMachine
		{
			// Token: 0x060009DC RID: 2524 RVA: 0x0003F578 File Offset: 0x0003D778
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html = areas_Admin_Views_SAML2_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009DD RID: 2525 RVA: 0x0003F61C File Offset: 0x0003D81C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400076E RID: 1902
			public int <>1__state;

			// Token: 0x0400076F RID: 1903
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000770 RID: 1904
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000131 RID: 305
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_27>d : IAsyncStateMachine
		{
			// Token: 0x060009DE RID: 2526 RVA: 0x0003F62C File Offset: 0x0003D82C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html = areas_Admin_Views_SAML2_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009DF RID: 2527 RVA: 0x0003F6D0 File Offset: 0x0003D8D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000771 RID: 1905
			public int <>1__state;

			// Token: 0x04000772 RID: 1906
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000773 RID: 1907
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000132 RID: 306
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_33>d : IAsyncStateMachine
		{
			// Token: 0x060009E0 RID: 2528 RVA: 0x0003F6E0 File Offset: 0x0003D8E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html = areas_Admin_Views_SAML2_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009E1 RID: 2529 RVA: 0x0003F784 File Offset: 0x0003D984
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000774 RID: 1908
			public int <>1__state;

			// Token: 0x04000775 RID: 1909
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000776 RID: 1910
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_39>d : IAsyncStateMachine
		{
			// Token: 0x060009E2 RID: 2530 RVA: 0x0003F794 File Offset: 0x0003D994
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_SAML2_Edit;
					IHtmlHelper<Saml2ConfigViewModel> html = areas_Admin_Views_SAML2_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Saml2ConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<Saml2ConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(Saml2ConfigViewModel.get_ModulePath())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009E3 RID: 2531 RVA: 0x0003F838 File Offset: 0x0003DA38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000777 RID: 1911
			public int <>1__state;

			// Token: 0x04000778 RID: 1912
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000779 RID: 1913
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_88>d : IAsyncStateMachine
		{
			// Token: 0x060009E4 RID: 2532 RVA: 0x0003F848 File Offset: 0x0003DA48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_SAML2_Edit.WriteLiteral("Cancel");
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

			// Token: 0x060009E5 RID: 2533 RVA: 0x0003F8AC File Offset: 0x0003DAAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400077A RID: 1914
			public int <>1__state;

			// Token: 0x0400077B RID: 1915
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400077C RID: 1916
			public Areas_Admin_Views_SAML2_Edit <>4__this;
		}

		// Token: 0x02000135 RID: 309
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060009E8 RID: 2536 RVA: 0x0003F8D0 File Offset: 0x0003DAD0
			internal Task <ExecuteAsync>b__24_2()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_2>d <<ExecuteAsync>b__24_2>d;
				<<ExecuteAsync>b__24_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_2>d.<>1__state = -1;
				<<ExecuteAsync>b__24_2>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_2>d>(ref <<ExecuteAsync>b__24_2>d);
				return <<ExecuteAsync>b__24_2>d.<>t__builder.Task;
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x0003F90C File Offset: 0x0003DB0C
			internal Task <ExecuteAsync>b__24_4()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_4>d <<ExecuteAsync>b__24_4>d;
				<<ExecuteAsync>b__24_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_4>d.<>1__state = -1;
				<<ExecuteAsync>b__24_4>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_4>d>(ref <<ExecuteAsync>b__24_4>d);
				return <<ExecuteAsync>b__24_4>d.<>t__builder.Task;
			}

			// Token: 0x060009EA RID: 2538 RVA: 0x0003F948 File Offset: 0x0003DB48
			internal Task <ExecuteAsync>b__24_7()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_7>d <<ExecuteAsync>b__24_7>d;
				<<ExecuteAsync>b__24_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_7>d.<>1__state = -1;
				<<ExecuteAsync>b__24_7>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_7>d>(ref <<ExecuteAsync>b__24_7>d);
				return <<ExecuteAsync>b__24_7>d.<>t__builder.Task;
			}

			// Token: 0x060009EB RID: 2539 RVA: 0x0003F984 File Offset: 0x0003DB84
			internal Task <ExecuteAsync>b__24_9()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_9>d <<ExecuteAsync>b__24_9>d;
				<<ExecuteAsync>b__24_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_9>d.<>1__state = -1;
				<<ExecuteAsync>b__24_9>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_9>d>(ref <<ExecuteAsync>b__24_9>d);
				return <<ExecuteAsync>b__24_9>d.<>t__builder.Task;
			}

			// Token: 0x060009EC RID: 2540 RVA: 0x0003F9C0 File Offset: 0x0003DBC0
			internal Task <ExecuteAsync>b__24_12()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_12>d <<ExecuteAsync>b__24_12>d;
				<<ExecuteAsync>b__24_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_12>d.<>1__state = -1;
				<<ExecuteAsync>b__24_12>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_12>d>(ref <<ExecuteAsync>b__24_12>d);
				return <<ExecuteAsync>b__24_12>d.<>t__builder.Task;
			}

			// Token: 0x060009ED RID: 2541 RVA: 0x0003F9FC File Offset: 0x0003DBFC
			internal Task <ExecuteAsync>b__24_14()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_14>d <<ExecuteAsync>b__24_14>d;
				<<ExecuteAsync>b__24_14>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_14>d.<>1__state = -1;
				<<ExecuteAsync>b__24_14>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_14>d>(ref <<ExecuteAsync>b__24_14>d);
				return <<ExecuteAsync>b__24_14>d.<>t__builder.Task;
			}

			// Token: 0x060009EE RID: 2542 RVA: 0x0003FA38 File Offset: 0x0003DC38
			internal Task <ExecuteAsync>b__24_17()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_17>d <<ExecuteAsync>b__24_17>d;
				<<ExecuteAsync>b__24_17>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_17>d.<>1__state = -1;
				<<ExecuteAsync>b__24_17>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_17>d>(ref <<ExecuteAsync>b__24_17>d);
				return <<ExecuteAsync>b__24_17>d.<>t__builder.Task;
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x0003FA74 File Offset: 0x0003DC74
			internal Task <ExecuteAsync>b__24_19()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_19>d <<ExecuteAsync>b__24_19>d;
				<<ExecuteAsync>b__24_19>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_19>d.<>1__state = -1;
				<<ExecuteAsync>b__24_19>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_19>d>(ref <<ExecuteAsync>b__24_19>d);
				return <<ExecuteAsync>b__24_19>d.<>t__builder.Task;
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x0003FAB0 File Offset: 0x0003DCB0
			internal Task <ExecuteAsync>b__24_23()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_23>d <<ExecuteAsync>b__24_23>d;
				<<ExecuteAsync>b__24_23>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_23>d.<>1__state = -1;
				<<ExecuteAsync>b__24_23>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_23>d>(ref <<ExecuteAsync>b__24_23>d);
				return <<ExecuteAsync>b__24_23>d.<>t__builder.Task;
			}

			// Token: 0x060009F1 RID: 2545 RVA: 0x0003FAEC File Offset: 0x0003DCEC
			internal Task <ExecuteAsync>b__24_25()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_25>d <<ExecuteAsync>b__24_25>d;
				<<ExecuteAsync>b__24_25>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_25>d.<>1__state = -1;
				<<ExecuteAsync>b__24_25>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_25>d>(ref <<ExecuteAsync>b__24_25>d);
				return <<ExecuteAsync>b__24_25>d.<>t__builder.Task;
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x0003FB28 File Offset: 0x0003DD28
			internal Task <ExecuteAsync>b__24_29()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_29>d <<ExecuteAsync>b__24_29>d;
				<<ExecuteAsync>b__24_29>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_29>d.<>1__state = -1;
				<<ExecuteAsync>b__24_29>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_29>d>(ref <<ExecuteAsync>b__24_29>d);
				return <<ExecuteAsync>b__24_29>d.<>t__builder.Task;
			}

			// Token: 0x060009F3 RID: 2547 RVA: 0x0003FB64 File Offset: 0x0003DD64
			internal Task <ExecuteAsync>b__24_31()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_31>d <<ExecuteAsync>b__24_31>d;
				<<ExecuteAsync>b__24_31>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_31>d.<>1__state = -1;
				<<ExecuteAsync>b__24_31>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_31>d>(ref <<ExecuteAsync>b__24_31>d);
				return <<ExecuteAsync>b__24_31>d.<>t__builder.Task;
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x0003FBA0 File Offset: 0x0003DDA0
			internal Task <ExecuteAsync>b__24_35()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_35>d <<ExecuteAsync>b__24_35>d;
				<<ExecuteAsync>b__24_35>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_35>d.<>1__state = -1;
				<<ExecuteAsync>b__24_35>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_35>d>(ref <<ExecuteAsync>b__24_35>d);
				return <<ExecuteAsync>b__24_35>d.<>t__builder.Task;
			}

			// Token: 0x060009F5 RID: 2549 RVA: 0x0003FBDC File Offset: 0x0003DDDC
			internal Task <ExecuteAsync>b__24_37()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_37>d <<ExecuteAsync>b__24_37>d;
				<<ExecuteAsync>b__24_37>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_37>d.<>1__state = -1;
				<<ExecuteAsync>b__24_37>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_37>d>(ref <<ExecuteAsync>b__24_37>d);
				return <<ExecuteAsync>b__24_37>d.<>t__builder.Task;
			}

			// Token: 0x060009F6 RID: 2550 RVA: 0x0003FC18 File Offset: 0x0003DE18
			internal Task <ExecuteAsync>b__24_41()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_41>d <<ExecuteAsync>b__24_41>d;
				<<ExecuteAsync>b__24_41>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_41>d.<>1__state = -1;
				<<ExecuteAsync>b__24_41>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_41>d>(ref <<ExecuteAsync>b__24_41>d);
				return <<ExecuteAsync>b__24_41>d.<>t__builder.Task;
			}

			// Token: 0x060009F7 RID: 2551 RVA: 0x0003FC54 File Offset: 0x0003DE54
			internal Task <ExecuteAsync>b__24_43()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_43>d <<ExecuteAsync>b__24_43>d;
				<<ExecuteAsync>b__24_43>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_43>d.<>1__state = -1;
				<<ExecuteAsync>b__24_43>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_43>d>(ref <<ExecuteAsync>b__24_43>d);
				return <<ExecuteAsync>b__24_43>d.<>t__builder.Task;
			}

			// Token: 0x060009F8 RID: 2552 RVA: 0x0003FC90 File Offset: 0x0003DE90
			internal Task <ExecuteAsync>b__24_46()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_46>d <<ExecuteAsync>b__24_46>d;
				<<ExecuteAsync>b__24_46>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_46>d.<>1__state = -1;
				<<ExecuteAsync>b__24_46>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_46>d>(ref <<ExecuteAsync>b__24_46>d);
				return <<ExecuteAsync>b__24_46>d.<>t__builder.Task;
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x0003FCCC File Offset: 0x0003DECC
			internal Task <ExecuteAsync>b__24_48()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_48>d <<ExecuteAsync>b__24_48>d;
				<<ExecuteAsync>b__24_48>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_48>d.<>1__state = -1;
				<<ExecuteAsync>b__24_48>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_48>d>(ref <<ExecuteAsync>b__24_48>d);
				return <<ExecuteAsync>b__24_48>d.<>t__builder.Task;
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x0003FD08 File Offset: 0x0003DF08
			internal Task <ExecuteAsync>b__24_51()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_51>d <<ExecuteAsync>b__24_51>d;
				<<ExecuteAsync>b__24_51>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_51>d.<>1__state = -1;
				<<ExecuteAsync>b__24_51>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_51>d>(ref <<ExecuteAsync>b__24_51>d);
				return <<ExecuteAsync>b__24_51>d.<>t__builder.Task;
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x0003FD44 File Offset: 0x0003DF44
			internal Task <ExecuteAsync>b__24_54()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_54>d <<ExecuteAsync>b__24_54>d;
				<<ExecuteAsync>b__24_54>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_54>d.<>1__state = -1;
				<<ExecuteAsync>b__24_54>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_54>d>(ref <<ExecuteAsync>b__24_54>d);
				return <<ExecuteAsync>b__24_54>d.<>t__builder.Task;
			}

			// Token: 0x060009FC RID: 2556 RVA: 0x0003FD80 File Offset: 0x0003DF80
			internal Task <ExecuteAsync>b__24_58()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_58>d <<ExecuteAsync>b__24_58>d;
				<<ExecuteAsync>b__24_58>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_58>d.<>1__state = -1;
				<<ExecuteAsync>b__24_58>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_58>d>(ref <<ExecuteAsync>b__24_58>d);
				return <<ExecuteAsync>b__24_58>d.<>t__builder.Task;
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x0003FDBC File Offset: 0x0003DFBC
			internal Task <ExecuteAsync>b__24_62()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_62>d <<ExecuteAsync>b__24_62>d;
				<<ExecuteAsync>b__24_62>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_62>d.<>1__state = -1;
				<<ExecuteAsync>b__24_62>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_62>d>(ref <<ExecuteAsync>b__24_62>d);
				return <<ExecuteAsync>b__24_62>d.<>t__builder.Task;
			}

			// Token: 0x060009FE RID: 2558 RVA: 0x0003FDF8 File Offset: 0x0003DFF8
			internal Task <ExecuteAsync>b__24_66()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_66>d <<ExecuteAsync>b__24_66>d;
				<<ExecuteAsync>b__24_66>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_66>d.<>1__state = -1;
				<<ExecuteAsync>b__24_66>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_66>d>(ref <<ExecuteAsync>b__24_66>d);
				return <<ExecuteAsync>b__24_66>d.<>t__builder.Task;
			}

			// Token: 0x060009FF RID: 2559 RVA: 0x0003FE34 File Offset: 0x0003E034
			internal Task <ExecuteAsync>b__24_69()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_69>d <<ExecuteAsync>b__24_69>d;
				<<ExecuteAsync>b__24_69>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_69>d.<>1__state = -1;
				<<ExecuteAsync>b__24_69>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_69>d>(ref <<ExecuteAsync>b__24_69>d);
				return <<ExecuteAsync>b__24_69>d.<>t__builder.Task;
			}

			// Token: 0x06000A00 RID: 2560 RVA: 0x0003FE70 File Offset: 0x0003E070
			internal Task <ExecuteAsync>b__24_71()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_71>d <<ExecuteAsync>b__24_71>d;
				<<ExecuteAsync>b__24_71>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_71>d.<>1__state = -1;
				<<ExecuteAsync>b__24_71>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_71>d>(ref <<ExecuteAsync>b__24_71>d);
				return <<ExecuteAsync>b__24_71>d.<>t__builder.Task;
			}

			// Token: 0x06000A01 RID: 2561 RVA: 0x0003FEAC File Offset: 0x0003E0AC
			internal Task <ExecuteAsync>b__24_74()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_74>d <<ExecuteAsync>b__24_74>d;
				<<ExecuteAsync>b__24_74>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_74>d.<>1__state = -1;
				<<ExecuteAsync>b__24_74>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_74>d>(ref <<ExecuteAsync>b__24_74>d);
				return <<ExecuteAsync>b__24_74>d.<>t__builder.Task;
			}

			// Token: 0x06000A02 RID: 2562 RVA: 0x0003FEE8 File Offset: 0x0003E0E8
			internal Task <ExecuteAsync>b__24_76()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_76>d <<ExecuteAsync>b__24_76>d;
				<<ExecuteAsync>b__24_76>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_76>d.<>1__state = -1;
				<<ExecuteAsync>b__24_76>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_76>d>(ref <<ExecuteAsync>b__24_76>d);
				return <<ExecuteAsync>b__24_76>d.<>t__builder.Task;
			}

			// Token: 0x06000A03 RID: 2563 RVA: 0x0003FF24 File Offset: 0x0003E124
			internal Task <ExecuteAsync>b__24_79()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_79>d <<ExecuteAsync>b__24_79>d;
				<<ExecuteAsync>b__24_79>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_79>d.<>1__state = -1;
				<<ExecuteAsync>b__24_79>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_79>d>(ref <<ExecuteAsync>b__24_79>d);
				return <<ExecuteAsync>b__24_79>d.<>t__builder.Task;
			}

			// Token: 0x06000A04 RID: 2564 RVA: 0x0003FF60 File Offset: 0x0003E160
			internal Task <ExecuteAsync>b__24_81()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_81>d <<ExecuteAsync>b__24_81>d;
				<<ExecuteAsync>b__24_81>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_81>d.<>1__state = -1;
				<<ExecuteAsync>b__24_81>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_81>d>(ref <<ExecuteAsync>b__24_81>d);
				return <<ExecuteAsync>b__24_81>d.<>t__builder.Task;
			}

			// Token: 0x06000A05 RID: 2565 RVA: 0x0003FF9C File Offset: 0x0003E19C
			internal Task <ExecuteAsync>b__24_84()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_84>d <<ExecuteAsync>b__24_84>d;
				<<ExecuteAsync>b__24_84>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_84>d.<>1__state = -1;
				<<ExecuteAsync>b__24_84>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_84>d>(ref <<ExecuteAsync>b__24_84>d);
				return <<ExecuteAsync>b__24_84>d.<>t__builder.Task;
			}

			// Token: 0x06000A06 RID: 2566 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
			internal Task <ExecuteAsync>b__24_86()
			{
				Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_86>d <<ExecuteAsync>b__24_86>d;
				<<ExecuteAsync>b__24_86>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_86>d.<>1__state = -1;
				<<ExecuteAsync>b__24_86>d.<>t__builder.Start<Areas_Admin_Views_SAML2_Edit.<>c.<<ExecuteAsync>b__24_86>d>(ref <<ExecuteAsync>b__24_86>d);
				return <<ExecuteAsync>b__24_86>d.<>t__builder.Task;
			}

			// Token: 0x0400077D RID: 1917
			public static readonly Areas_Admin_Views_SAML2_Edit.<>c <>9 = new Areas_Admin_Views_SAML2_Edit.<>c();

			// Token: 0x0400077E RID: 1918
			public static Func<Task> <>9__24_2;

			// Token: 0x0400077F RID: 1919
			public static Func<Task> <>9__24_4;

			// Token: 0x04000780 RID: 1920
			public static Func<Task> <>9__24_7;

			// Token: 0x04000781 RID: 1921
			public static Func<Task> <>9__24_9;

			// Token: 0x04000782 RID: 1922
			public static Func<Task> <>9__24_12;

			// Token: 0x04000783 RID: 1923
			public static Func<Task> <>9__24_14;

			// Token: 0x04000784 RID: 1924
			public static Func<Task> <>9__24_17;

			// Token: 0x04000785 RID: 1925
			public static Func<Task> <>9__24_19;

			// Token: 0x04000786 RID: 1926
			public static Func<Task> <>9__24_23;

			// Token: 0x04000787 RID: 1927
			public static Func<Task> <>9__24_25;

			// Token: 0x04000788 RID: 1928
			public static Func<Task> <>9__24_29;

			// Token: 0x04000789 RID: 1929
			public static Func<Task> <>9__24_31;

			// Token: 0x0400078A RID: 1930
			public static Func<Task> <>9__24_35;

			// Token: 0x0400078B RID: 1931
			public static Func<Task> <>9__24_37;

			// Token: 0x0400078C RID: 1932
			public static Func<Task> <>9__24_41;

			// Token: 0x0400078D RID: 1933
			public static Func<Task> <>9__24_43;

			// Token: 0x0400078E RID: 1934
			public static Func<Task> <>9__24_46;

			// Token: 0x0400078F RID: 1935
			public static Func<Task> <>9__24_48;

			// Token: 0x04000790 RID: 1936
			public static Func<Task> <>9__24_51;

			// Token: 0x04000791 RID: 1937
			public static Func<Task> <>9__24_54;

			// Token: 0x04000792 RID: 1938
			public static Func<Task> <>9__24_58;

			// Token: 0x04000793 RID: 1939
			public static Func<Task> <>9__24_62;

			// Token: 0x04000794 RID: 1940
			public static Func<Task> <>9__24_66;

			// Token: 0x04000795 RID: 1941
			public static Func<Task> <>9__24_69;

			// Token: 0x04000796 RID: 1942
			public static Func<Task> <>9__24_71;

			// Token: 0x04000797 RID: 1943
			public static Func<Task> <>9__24_74;

			// Token: 0x04000798 RID: 1944
			public static Func<Task> <>9__24_76;

			// Token: 0x04000799 RID: 1945
			public static Func<Task> <>9__24_79;

			// Token: 0x0400079A RID: 1946
			public static Func<Task> <>9__24_81;

			// Token: 0x0400079B RID: 1947
			public static Func<Task> <>9__24_84;

			// Token: 0x0400079C RID: 1948
			public static Func<Task> <>9__24_86;

			// Token: 0x020002F0 RID: 752
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_12>d : IAsyncStateMachine
			{
				// Token: 0x06000EEE RID: 3822 RVA: 0x0007375C File Offset: 0x0007195C
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

				// Token: 0x06000EEF RID: 3823 RVA: 0x000737AC File Offset: 0x000719AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E81 RID: 3713
				public int <>1__state;

				// Token: 0x04000E82 RID: 3714
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F1 RID: 753
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_14>d : IAsyncStateMachine
			{
				// Token: 0x06000EF0 RID: 3824 RVA: 0x000737BC File Offset: 0x000719BC
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

				// Token: 0x06000EF1 RID: 3825 RVA: 0x0007380C File Offset: 0x00071A0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E83 RID: 3715
				public int <>1__state;

				// Token: 0x04000E84 RID: 3716
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F2 RID: 754
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_17>d : IAsyncStateMachine
			{
				// Token: 0x06000EF2 RID: 3826 RVA: 0x0007381C File Offset: 0x00071A1C
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

				// Token: 0x06000EF3 RID: 3827 RVA: 0x0007386C File Offset: 0x00071A6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E85 RID: 3717
				public int <>1__state;

				// Token: 0x04000E86 RID: 3718
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F3 RID: 755
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_19>d : IAsyncStateMachine
			{
				// Token: 0x06000EF4 RID: 3828 RVA: 0x0007387C File Offset: 0x00071A7C
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

				// Token: 0x06000EF5 RID: 3829 RVA: 0x000738CC File Offset: 0x00071ACC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E87 RID: 3719
				public int <>1__state;

				// Token: 0x04000E88 RID: 3720
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F4 RID: 756
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_23>d : IAsyncStateMachine
			{
				// Token: 0x06000EF6 RID: 3830 RVA: 0x000738DC File Offset: 0x00071ADC
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

				// Token: 0x06000EF7 RID: 3831 RVA: 0x0007392C File Offset: 0x00071B2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E89 RID: 3721
				public int <>1__state;

				// Token: 0x04000E8A RID: 3722
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F5 RID: 757
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_25>d : IAsyncStateMachine
			{
				// Token: 0x06000EF8 RID: 3832 RVA: 0x0007393C File Offset: 0x00071B3C
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

				// Token: 0x06000EF9 RID: 3833 RVA: 0x0007398C File Offset: 0x00071B8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E8B RID: 3723
				public int <>1__state;

				// Token: 0x04000E8C RID: 3724
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F6 RID: 758
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_29>d : IAsyncStateMachine
			{
				// Token: 0x06000EFA RID: 3834 RVA: 0x0007399C File Offset: 0x00071B9C
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

				// Token: 0x06000EFB RID: 3835 RVA: 0x000739EC File Offset: 0x00071BEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E8D RID: 3725
				public int <>1__state;

				// Token: 0x04000E8E RID: 3726
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F7 RID: 759
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_2>d : IAsyncStateMachine
			{
				// Token: 0x06000EFC RID: 3836 RVA: 0x000739FC File Offset: 0x00071BFC
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

				// Token: 0x06000EFD RID: 3837 RVA: 0x00073A4C File Offset: 0x00071C4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E8F RID: 3727
				public int <>1__state;

				// Token: 0x04000E90 RID: 3728
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F8 RID: 760
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_31>d : IAsyncStateMachine
			{
				// Token: 0x06000EFE RID: 3838 RVA: 0x00073A5C File Offset: 0x00071C5C
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

				// Token: 0x06000EFF RID: 3839 RVA: 0x00073AAC File Offset: 0x00071CAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E91 RID: 3729
				public int <>1__state;

				// Token: 0x04000E92 RID: 3730
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002F9 RID: 761
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_35>d : IAsyncStateMachine
			{
				// Token: 0x06000F00 RID: 3840 RVA: 0x00073ABC File Offset: 0x00071CBC
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

				// Token: 0x06000F01 RID: 3841 RVA: 0x00073B0C File Offset: 0x00071D0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E93 RID: 3731
				public int <>1__state;

				// Token: 0x04000E94 RID: 3732
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FA RID: 762
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_37>d : IAsyncStateMachine
			{
				// Token: 0x06000F02 RID: 3842 RVA: 0x00073B1C File Offset: 0x00071D1C
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

				// Token: 0x06000F03 RID: 3843 RVA: 0x00073B6C File Offset: 0x00071D6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E95 RID: 3733
				public int <>1__state;

				// Token: 0x04000E96 RID: 3734
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FB RID: 763
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_41>d : IAsyncStateMachine
			{
				// Token: 0x06000F04 RID: 3844 RVA: 0x00073B7C File Offset: 0x00071D7C
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

				// Token: 0x06000F05 RID: 3845 RVA: 0x00073BCC File Offset: 0x00071DCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E97 RID: 3735
				public int <>1__state;

				// Token: 0x04000E98 RID: 3736
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FC RID: 764
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_43>d : IAsyncStateMachine
			{
				// Token: 0x06000F06 RID: 3846 RVA: 0x00073BDC File Offset: 0x00071DDC
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

				// Token: 0x06000F07 RID: 3847 RVA: 0x00073C2C File Offset: 0x00071E2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E99 RID: 3737
				public int <>1__state;

				// Token: 0x04000E9A RID: 3738
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FD RID: 765
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_46>d : IAsyncStateMachine
			{
				// Token: 0x06000F08 RID: 3848 RVA: 0x00073C3C File Offset: 0x00071E3C
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

				// Token: 0x06000F09 RID: 3849 RVA: 0x00073C8C File Offset: 0x00071E8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E9B RID: 3739
				public int <>1__state;

				// Token: 0x04000E9C RID: 3740
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FE RID: 766
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_48>d : IAsyncStateMachine
			{
				// Token: 0x06000F0A RID: 3850 RVA: 0x00073C9C File Offset: 0x00071E9C
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

				// Token: 0x06000F0B RID: 3851 RVA: 0x00073CEC File Offset: 0x00071EEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E9D RID: 3741
				public int <>1__state;

				// Token: 0x04000E9E RID: 3742
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002FF RID: 767
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_4>d : IAsyncStateMachine
			{
				// Token: 0x06000F0C RID: 3852 RVA: 0x00073CFC File Offset: 0x00071EFC
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

				// Token: 0x06000F0D RID: 3853 RVA: 0x00073D4C File Offset: 0x00071F4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E9F RID: 3743
				public int <>1__state;

				// Token: 0x04000EA0 RID: 3744
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000300 RID: 768
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_51>d : IAsyncStateMachine
			{
				// Token: 0x06000F0E RID: 3854 RVA: 0x00073D5C File Offset: 0x00071F5C
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

				// Token: 0x06000F0F RID: 3855 RVA: 0x00073DAC File Offset: 0x00071FAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EA1 RID: 3745
				public int <>1__state;

				// Token: 0x04000EA2 RID: 3746
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000301 RID: 769
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_54>d : IAsyncStateMachine
			{
				// Token: 0x06000F10 RID: 3856 RVA: 0x00073DBC File Offset: 0x00071FBC
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

				// Token: 0x06000F11 RID: 3857 RVA: 0x00073E0C File Offset: 0x0007200C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EA3 RID: 3747
				public int <>1__state;

				// Token: 0x04000EA4 RID: 3748
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000302 RID: 770
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_58>d : IAsyncStateMachine
			{
				// Token: 0x06000F12 RID: 3858 RVA: 0x00073E1C File Offset: 0x0007201C
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

				// Token: 0x06000F13 RID: 3859 RVA: 0x00073E6C File Offset: 0x0007206C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EA5 RID: 3749
				public int <>1__state;

				// Token: 0x04000EA6 RID: 3750
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000303 RID: 771
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_62>d : IAsyncStateMachine
			{
				// Token: 0x06000F14 RID: 3860 RVA: 0x00073E7C File Offset: 0x0007207C
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

				// Token: 0x06000F15 RID: 3861 RVA: 0x00073ECC File Offset: 0x000720CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EA7 RID: 3751
				public int <>1__state;

				// Token: 0x04000EA8 RID: 3752
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000304 RID: 772
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_66>d : IAsyncStateMachine
			{
				// Token: 0x06000F16 RID: 3862 RVA: 0x00073EDC File Offset: 0x000720DC
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

				// Token: 0x06000F17 RID: 3863 RVA: 0x00073F2C File Offset: 0x0007212C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EA9 RID: 3753
				public int <>1__state;

				// Token: 0x04000EAA RID: 3754
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000305 RID: 773
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_69>d : IAsyncStateMachine
			{
				// Token: 0x06000F18 RID: 3864 RVA: 0x00073F3C File Offset: 0x0007213C
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

				// Token: 0x06000F19 RID: 3865 RVA: 0x00073F8C File Offset: 0x0007218C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EAB RID: 3755
				public int <>1__state;

				// Token: 0x04000EAC RID: 3756
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000306 RID: 774
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_71>d : IAsyncStateMachine
			{
				// Token: 0x06000F1A RID: 3866 RVA: 0x00073F9C File Offset: 0x0007219C
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

				// Token: 0x06000F1B RID: 3867 RVA: 0x00073FEC File Offset: 0x000721EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EAD RID: 3757
				public int <>1__state;

				// Token: 0x04000EAE RID: 3758
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000307 RID: 775
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_74>d : IAsyncStateMachine
			{
				// Token: 0x06000F1C RID: 3868 RVA: 0x00073FFC File Offset: 0x000721FC
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

				// Token: 0x06000F1D RID: 3869 RVA: 0x0007404C File Offset: 0x0007224C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EAF RID: 3759
				public int <>1__state;

				// Token: 0x04000EB0 RID: 3760
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000308 RID: 776
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_76>d : IAsyncStateMachine
			{
				// Token: 0x06000F1E RID: 3870 RVA: 0x0007405C File Offset: 0x0007225C
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

				// Token: 0x06000F1F RID: 3871 RVA: 0x000740AC File Offset: 0x000722AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EB1 RID: 3761
				public int <>1__state;

				// Token: 0x04000EB2 RID: 3762
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000309 RID: 777
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_79>d : IAsyncStateMachine
			{
				// Token: 0x06000F20 RID: 3872 RVA: 0x000740BC File Offset: 0x000722BC
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

				// Token: 0x06000F21 RID: 3873 RVA: 0x0007410C File Offset: 0x0007230C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EB3 RID: 3763
				public int <>1__state;

				// Token: 0x04000EB4 RID: 3764
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200030A RID: 778
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_7>d : IAsyncStateMachine
			{
				// Token: 0x06000F22 RID: 3874 RVA: 0x0007411C File Offset: 0x0007231C
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

				// Token: 0x06000F23 RID: 3875 RVA: 0x0007416C File Offset: 0x0007236C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EB5 RID: 3765
				public int <>1__state;

				// Token: 0x04000EB6 RID: 3766
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200030B RID: 779
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_81>d : IAsyncStateMachine
			{
				// Token: 0x06000F24 RID: 3876 RVA: 0x0007417C File Offset: 0x0007237C
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

				// Token: 0x06000F25 RID: 3877 RVA: 0x000741CC File Offset: 0x000723CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EB7 RID: 3767
				public int <>1__state;

				// Token: 0x04000EB8 RID: 3768
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200030C RID: 780
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_84>d : IAsyncStateMachine
			{
				// Token: 0x06000F26 RID: 3878 RVA: 0x000741DC File Offset: 0x000723DC
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

				// Token: 0x06000F27 RID: 3879 RVA: 0x0007422C File Offset: 0x0007242C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EB9 RID: 3769
				public int <>1__state;

				// Token: 0x04000EBA RID: 3770
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200030D RID: 781
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_86>d : IAsyncStateMachine
			{
				// Token: 0x06000F28 RID: 3880 RVA: 0x0007423C File Offset: 0x0007243C
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

				// Token: 0x06000F29 RID: 3881 RVA: 0x0007428C File Offset: 0x0007248C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EBB RID: 3771
				public int <>1__state;

				// Token: 0x04000EBC RID: 3772
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200030E RID: 782
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_9>d : IAsyncStateMachine
			{
				// Token: 0x06000F2A RID: 3882 RVA: 0x0007429C File Offset: 0x0007249C
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

				// Token: 0x06000F2B RID: 3883 RVA: 0x000742EC File Offset: 0x000724EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000EBD RID: 3773
				public int <>1__state;

				// Token: 0x04000EBE RID: 3774
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000136 RID: 310
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__24 : IAsyncStateMachine
		{
			// Token: 0x06000A07 RID: 2567 RVA: 0x00040014 File Offset: 0x0003E214
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_SAML2_Edit areas_Admin_Views_SAML2_Edit = this.<>4__this;
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
							goto IL_01AD;
						}
						areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n<div class=\"x_panel\">\r\n");
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "5e149c68a3c6b4da68267db9b3b9f9c624491ec91097d2418a1bebcb983b83cd7878", new Func<Task>(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_0));
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_SAML2_Edit.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_8.Value;
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_8);
						areas_Admin_Views_SAML2_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_10.Value;
						areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_SAML2_Edit.__tagHelperAttribute_10);
						awaiter2 = areas_Admin_Views_SAML2_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<ExecuteAsync>d__24>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01B4;
					}
					awaiter = areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_SAML2_Edit.<ExecuteAsync>d__24>(ref awaiter, ref this);
						return;
					}
					IL_01AD:
					awaiter.GetResult();
					IL_01B4:
					areas_Admin_Views_SAML2_Edit.Write(areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_SAML2_Edit.__tagHelperExecutionContext = areas_Admin_Views_SAML2_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_SAML2_Edit.WriteLiteral("\r\n</div>\r\n\r\n");
					areas_Admin_Views_SAML2_Edit.DefineSection("Scripts", new RenderAsyncDelegate(areas_Admin_Views_SAML2_Edit.<ExecuteAsync>b__24_1));
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

			// Token: 0x06000A08 RID: 2568 RVA: 0x00040264 File Offset: 0x0003E464
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400079D RID: 1949
			public int <>1__state;

			// Token: 0x0400079E RID: 1950
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400079F RID: 1951
			public Areas_Admin_Views_SAML2_Edit <>4__this;

			// Token: 0x040007A0 RID: 1952
			private TaskAwaiter <>u__1;
		}
	}
}
