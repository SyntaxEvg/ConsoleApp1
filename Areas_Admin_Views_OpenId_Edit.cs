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
	// Token: 0x02000038 RID: 56
	[RazorSourceChecksum("SHA256", "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c9", "/Areas/Admin/Views/OpenId/Edit.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/OpenId/Edit.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_OpenId_Edit : BaseRazorPage<OpenIdConfigViewModel>
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000A993 File Offset: 0x00008B93
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

		// Token: 0x0600022C RID: 556 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_OpenId_Edit.<ExecuteAsync>d__24 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<ExecuteAsync>d__24>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000AA0B File Offset: 0x00008C0B
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000AA13 File Offset: 0x00008C13
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000AA1C File Offset: 0x00008C1C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000AA24 File Offset: 0x00008C24
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000AA2D File Offset: 0x00008C2D
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0000AA35 File Offset: 0x00008C35
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000AA3E File Offset: 0x00008C3E
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000AA46 File Offset: 0x00008C46
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000AA4F File Offset: 0x00008C4F
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000AA57 File Offset: 0x00008C57
		[RazorInject]
		public IHtmlHelper<OpenIdConfigViewModel> Html { get; private set; }

		// Token: 0x06000239 RID: 569 RVA: 0x0000AB8C File Offset: 0x00008D8C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_0()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d <<ExecuteAsync>b__24_0>d;
			<<ExecuteAsync>b__24_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_0>d.<>4__this = this;
			<<ExecuteAsync>b__24_0>d.<>1__state = -1;
			<<ExecuteAsync>b__24_0>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref <<ExecuteAsync>b__24_0>d);
			return <<ExecuteAsync>b__24_0>d.<>t__builder.Task;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000ABD0 File Offset: 0x00008DD0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_6()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_6>d <<ExecuteAsync>b__24_6>d;
			<<ExecuteAsync>b__24_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_6>d.<>4__this = this;
			<<ExecuteAsync>b__24_6>d.<>1__state = -1;
			<<ExecuteAsync>b__24_6>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_6>d>(ref <<ExecuteAsync>b__24_6>d);
			return <<ExecuteAsync>b__24_6>d.<>t__builder.Task;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000AC14 File Offset: 0x00008E14
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_12()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_12>d <<ExecuteAsync>b__24_12>d;
			<<ExecuteAsync>b__24_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_12>d.<>4__this = this;
			<<ExecuteAsync>b__24_12>d.<>1__state = -1;
			<<ExecuteAsync>b__24_12>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_12>d>(ref <<ExecuteAsync>b__24_12>d);
			return <<ExecuteAsync>b__24_12>d.<>t__builder.Task;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000AC58 File Offset: 0x00008E58
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_18()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_18>d <<ExecuteAsync>b__24_18>d;
			<<ExecuteAsync>b__24_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_18>d.<>4__this = this;
			<<ExecuteAsync>b__24_18>d.<>1__state = -1;
			<<ExecuteAsync>b__24_18>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_18>d>(ref <<ExecuteAsync>b__24_18>d);
			return <<ExecuteAsync>b__24_18>d.<>t__builder.Task;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000AC9C File Offset: 0x00008E9C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_24()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_24>d <<ExecuteAsync>b__24_24>d;
			<<ExecuteAsync>b__24_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_24>d.<>4__this = this;
			<<ExecuteAsync>b__24_24>d.<>1__state = -1;
			<<ExecuteAsync>b__24_24>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_24>d>(ref <<ExecuteAsync>b__24_24>d);
			return <<ExecuteAsync>b__24_24>d.<>t__builder.Task;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_30()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_30>d <<ExecuteAsync>b__24_30>d;
			<<ExecuteAsync>b__24_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_30>d.<>4__this = this;
			<<ExecuteAsync>b__24_30>d.<>1__state = -1;
			<<ExecuteAsync>b__24_30>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_30>d>(ref <<ExecuteAsync>b__24_30>d);
			return <<ExecuteAsync>b__24_30>d.<>t__builder.Task;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000AD24 File Offset: 0x00008F24
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_36()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_36>d <<ExecuteAsync>b__24_36>d;
			<<ExecuteAsync>b__24_36>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_36>d.<>4__this = this;
			<<ExecuteAsync>b__24_36>d.<>1__state = -1;
			<<ExecuteAsync>b__24_36>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_36>d>(ref <<ExecuteAsync>b__24_36>d);
			return <<ExecuteAsync>b__24_36>d.<>t__builder.Task;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000AD68 File Offset: 0x00008F68
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_42()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_42>d <<ExecuteAsync>b__24_42>d;
			<<ExecuteAsync>b__24_42>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_42>d.<>4__this = this;
			<<ExecuteAsync>b__24_42>d.<>1__state = -1;
			<<ExecuteAsync>b__24_42>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_42>d>(ref <<ExecuteAsync>b__24_42>d);
			return <<ExecuteAsync>b__24_42>d.<>t__builder.Task;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000ADAC File Offset: 0x00008FAC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_48()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_48>d <<ExecuteAsync>b__24_48>d;
			<<ExecuteAsync>b__24_48>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_48>d.<>4__this = this;
			<<ExecuteAsync>b__24_48>d.<>1__state = -1;
			<<ExecuteAsync>b__24_48>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_48>d>(ref <<ExecuteAsync>b__24_48>d);
			return <<ExecuteAsync>b__24_48>d.<>t__builder.Task;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000ADF0 File Offset: 0x00008FF0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_54()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_54>d <<ExecuteAsync>b__24_54>d;
			<<ExecuteAsync>b__24_54>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_54>d.<>4__this = this;
			<<ExecuteAsync>b__24_54>d.<>1__state = -1;
			<<ExecuteAsync>b__24_54>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_54>d>(ref <<ExecuteAsync>b__24_54>d);
			return <<ExecuteAsync>b__24_54>d.<>t__builder.Task;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000AE34 File Offset: 0x00009034
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_60()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_60>d <<ExecuteAsync>b__24_60>d;
			<<ExecuteAsync>b__24_60>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_60>d.<>4__this = this;
			<<ExecuteAsync>b__24_60>d.<>1__state = -1;
			<<ExecuteAsync>b__24_60>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_60>d>(ref <<ExecuteAsync>b__24_60>d);
			return <<ExecuteAsync>b__24_60>d.<>t__builder.Task;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000AE78 File Offset: 0x00009078
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_66()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_66>d <<ExecuteAsync>b__24_66>d;
			<<ExecuteAsync>b__24_66>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_66>d.<>4__this = this;
			<<ExecuteAsync>b__24_66>d.<>1__state = -1;
			<<ExecuteAsync>b__24_66>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_66>d>(ref <<ExecuteAsync>b__24_66>d);
			return <<ExecuteAsync>b__24_66>d.<>t__builder.Task;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000AEBC File Offset: 0x000090BC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_72()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_72>d <<ExecuteAsync>b__24_72>d;
			<<ExecuteAsync>b__24_72>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_72>d.<>4__this = this;
			<<ExecuteAsync>b__24_72>d.<>1__state = -1;
			<<ExecuteAsync>b__24_72>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_72>d>(ref <<ExecuteAsync>b__24_72>d);
			return <<ExecuteAsync>b__24_72>d.<>t__builder.Task;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000AF00 File Offset: 0x00009100
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_78()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_78>d <<ExecuteAsync>b__24_78>d;
			<<ExecuteAsync>b__24_78>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_78>d.<>4__this = this;
			<<ExecuteAsync>b__24_78>d.<>1__state = -1;
			<<ExecuteAsync>b__24_78>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_78>d>(ref <<ExecuteAsync>b__24_78>d);
			return <<ExecuteAsync>b__24_78>d.<>t__builder.Task;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000AF44 File Offset: 0x00009144
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__24_1()
		{
			Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_1>d <<ExecuteAsync>b__24_1>d;
			<<ExecuteAsync>b__24_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__24_1>d.<>4__this = this;
			<<ExecuteAsync>b__24_1>d.<>1__state = -1;
			<<ExecuteAsync>b__24_1>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_1>d>(ref <<ExecuteAsync>b__24_1>d);
			return <<ExecuteAsync>b__24_1>d.<>t__builder.Task;
		}

		// Token: 0x040001F4 RID: 500
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001F5 RID: 501
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001F6 RID: 502
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("class", new HtmlString("control-label"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001F7 RID: 503
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001F8 RID: 504
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("onchange", new HtmlString("DisplayNameChanged(value);"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001F9 RID: 505
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("autocomplete", new HtmlString("false"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FA RID: 506
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FB RID: 507
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("onfocus", new HtmlString("this.removeAttribute('readonly');"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FC RID: 508
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("asp-route", "Admin/OpenId", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FD RID: 509
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("class", new HtmlString("btn btn-primary"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FE RID: 510
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001FF RID: 511
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000200 RID: 512
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000201 RID: 513
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000202 RID: 514
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000203 RID: 515
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000204 RID: 516
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000205 RID: 517
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000206 RID: 518
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x04000207 RID: 519
		private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

		// Token: 0x04000208 RID: 520
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x04000209 RID: 521
		private AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_0>d : IAsyncStateMachine
		{
			// Token: 0x06000992 RID: 2450 RVA: 0x00034130 File Offset: 0x00032330
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
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
					TaskAwaiter awaiter73;
					TaskAwaiter awaiter74;
					TaskAwaiter awaiter75;
					TaskAwaiter awaiter76;
					TaskAwaiter awaiter77;
					TaskAwaiter awaiter78;
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
						goto IL_0341;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04CD;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0542;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_06F9;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_076E;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_08F0;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0965;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0AD7;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0B4D;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0CAD;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0D23;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0E96;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0F0C;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_107F;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_10F5;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1255;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_12CB;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_143E;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_14B4;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1627;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_169D;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_17FD;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1873;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19E6;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1A5C;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1BCF;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1C45;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1DA5;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1E1B;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1F8E;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2004;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2177;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_21ED;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_234D;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_23C3;
					case 36:
						awaiter37 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2536;
					case 37:
						awaiter38 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_25AC;
					case 38:
						awaiter39 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_271F;
					case 39:
						awaiter40 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2795;
					case 40:
						awaiter41 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_28F5;
					case 41:
						awaiter42 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_296B;
					case 42:
						awaiter43 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2BAC;
					case 43:
						awaiter44 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2C22;
					case 44:
						awaiter45 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2D95;
					case 45:
						awaiter46 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2E0B;
					case 46:
						awaiter47 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_2FA8;
					case 47:
						awaiter48 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_301E;
					case 48:
						awaiter49 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3191;
					case 49:
						awaiter50 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3207;
					case 50:
						awaiter51 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_337A;
					case 51:
						awaiter52 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_33F0;
					case 52:
						awaiter53 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3550;
					case 53:
						awaiter54 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_35C6;
					case 54:
						awaiter55 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3739;
					case 55:
						awaiter56 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_37AF;
					case 56:
						awaiter57 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3922;
					case 57:
						awaiter58 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3998;
					case 58:
						awaiter59 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3AF8;
					case 59:
						awaiter60 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3B6E;
					case 60:
						awaiter61 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3CE1;
					case 61:
						awaiter62 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3D57;
					case 62:
						awaiter63 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3ECA;
					case 63:
						awaiter64 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_3F40;
					case 64:
						awaiter65 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_40A0;
					case 65:
						awaiter66 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4116;
					case 66:
						awaiter67 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4289;
					case 67:
						awaiter68 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_42FF;
					case 68:
						awaiter69 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4472;
					case 69:
						awaiter70 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_44E8;
					case 70:
						awaiter71 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4648;
					case 71:
						awaiter72 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_46BE;
					case 72:
						awaiter73 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4831;
					case 73:
						awaiter74 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_48A7;
					case 74:
						awaiter75 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4A1A;
					case 75:
						awaiter76 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4A90;
					case 76:
						awaiter77 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4BA6;
					case 77:
						awaiter78 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_4C19;
					default:
						areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"OpenIDModal\" tabindex=\"-1\" role=\"dialog\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-body text-center h5\">\r\n                            ");
						areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.T["To <strong>save</strong> and <strong>apply</strong> the changes, the instance and all related nodes will be totally restarted."]);
						areas_Admin_Views_OpenId_Edit.WriteLiteral("<br>\r\n                            ");
						areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.T["All users will be disconnected."]);
						areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                        </div>\r\n                        <div class=\"modal-footer justify-content-center\">\r\n                            <button type=\"submit\" class=\"btn btn-danger w-100\">");
						areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.T["I understand the consequences, restart\u200b"]);
						areas_Admin_Views_OpenId_Edit.WriteLiteral("</button>\r\n                            <button type=\"button\" class=\"btn btn-success w-100 mb-3\" data-bs-dismiss=\"modal\">");
						areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.T["Cancel changes, don’t restart\u200b"]);
						areas_Admin_Views_OpenId_Edit.WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c910663", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_2));
						areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationSummaryTagHelper>();
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
						areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0348;
					}
					awaiter2 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_0341:
					awaiter2.GetResult();
					IL_0348:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-heading\">General</div>\r\n                        <div class=\"panel-body\">\r\n                            <div class=\"form-group\">\r\n                                <div class=\"checkbox\">\r\n                                    <label>\r\n                                        ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c912828", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_3));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData = areas_Admin_Views_OpenId_Edit.ViewData;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<OpenIdConfigViewModel, bool>(viewData, Expression.Lambda<Func<OpenIdConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_1.Value;
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_1);
					awaiter3 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_04CD:
					awaiter3.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0549;
					}
					awaiter4 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_0542:
					awaiter4.GetResult();
					IL_0549:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("   ");
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<bool>(Expression.Lambda<Func<OpenIdConfigViewModel, bool>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                    </label>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c915085", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_6));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData2 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider2.CreateModelExpression<OpenIdConfigViewModel, string>(viewData2, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter5 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_06F9:
					awaiter5.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0775;
					}
					awaiter6 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_076E:
					awaiter6.GetResult();
					IL_0775:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c917044", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_8));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData3 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<OpenIdConfigViewModel, string>(viewData3, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_4);
					awaiter7 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_08F0:
					awaiter7.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_096C;
					}
					awaiter8 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_0965:
					awaiter8.GetResult();
					IL_096C:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c918787", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_10));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData4 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider4.CreateModelExpression<OpenIdConfigViewModel, string>(viewData4, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter9 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0AD7:
					awaiter9.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0B54;
					}
					awaiter10 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0B4D:
					awaiter10.GetResult();
					IL_0B54:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c920615", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_12));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData5 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2.For = modelExpressionProvider5.CreateModelExpression<OpenIdConfigViewModel, string>(viewData5, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Authority())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter11 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0CAD:
					awaiter11.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0D2A;
					}
					awaiter12 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0D23:
					awaiter12.GetResult();
					IL_0D2A:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c922529", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_14));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData6 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider6.CreateModelExpression<OpenIdConfigViewModel, string>(viewData6, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Authority())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter13 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						this.<>1__state = 12;
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0E96:
					awaiter13.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0F13;
					}
					awaiter14 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						this.<>1__state = 13;
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0F0C:
					awaiter14.GetResult();
					IL_0F13:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c924183", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_16));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData7 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider7.CreateModelExpression<OpenIdConfigViewModel, string>(viewData7, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Authority())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter15 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						this.<>1__state = 14;
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_107F:
					awaiter15.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_10FC;
					}
					awaiter16 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						this.<>1__state = 15;
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_10F5:
					awaiter16.GetResult();
					IL_10FC:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c926009", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_18));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData8 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3.For = modelExpressionProvider8.CreateModelExpression<OpenIdConfigViewModel, string>(viewData8, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Proxy())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter17 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						this.<>1__state = 16;
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_1255:
					awaiter17.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_12D2;
					}
					awaiter18 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						this.<>1__state = 17;
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_12CB:
					awaiter18.GetResult();
					IL_12D2:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c927915", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_20));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData9 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider9.CreateModelExpression<OpenIdConfigViewModel, string>(viewData9, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Proxy())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter19 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						this.<>1__state = 18;
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_143E:
					awaiter19.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_14BB;
					}
					awaiter20 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						this.<>1__state = 19;
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_14B4:
					awaiter20.GetResult();
					IL_14BB:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c929565", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_22));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData10 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider10.CreateModelExpression<OpenIdConfigViewModel, string>(viewData10, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Proxy())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter21 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						this.<>1__state = 20;
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_1627:
					awaiter21.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_16A4;
					}
					awaiter22 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						this.<>1__state = 21;
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_169D:
					awaiter22.GetResult();
					IL_16A4:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c931387", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_24));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData11 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4.For = modelExpressionProvider11.CreateModelExpression<OpenIdConfigViewModel, string>(viewData11, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter23 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						this.<>1__state = 22;
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_17FD:
					awaiter23.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_187A;
					}
					awaiter24 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						this.<>1__state = 23;
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_1873:
					awaiter24.GetResult();
					IL_187A:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c933299", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_26));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData12 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider12.CreateModelExpression<OpenIdConfigViewModel, string>(viewData12, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter25 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						this.<>1__state = 24;
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_19E6:
					awaiter25.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1A63;
					}
					awaiter26 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						this.<>1__state = 25;
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1A5C:
					awaiter26.GetResult();
					IL_1A63:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c934952", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_28));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData13 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider13.CreateModelExpression<OpenIdConfigViewModel, string>(viewData13, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter27 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						this.<>1__state = 26;
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1BCF:
					awaiter27.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1C4C;
					}
					awaiter28 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						this.<>1__state = 27;
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1C45:
					awaiter28.GetResult();
					IL_1C4C:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n\r\n                            <nav class=\"nav nav-tabs\">\r\n                                <a class=\"nav-item nav-link active\" href=\"#tabCertificate\" data-bs-toggle=\"tab\">Certificate</a>\r\n                                <a class=\"nav-item nav-link\" href=\"#tabSecret\" data-bs-toggle=\"tab\">Secret</a>\r\n                            </nav>\r\n                            <div class=\"card bg-light mb-3\">\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"tab-content\">\r\n                                        <div class=\"tab-pane active\" id=\"tabCertificate\">\r\n                                            <div class=\"form-group\">\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c937436", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_30));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData14 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5.For = modelExpressionProvider14.CreateModelExpression<OpenIdConfigViewModel, string>(viewData14, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Thumbprint())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter29 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						this.<>1__state = 28;
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1DA5:
					awaiter29.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1E22;
					}
					awaiter30 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						this.<>1__state = 29;
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1E1B:
					awaiter30.GetResult();
					IL_1E22:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c939369", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_32));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData15 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider15.CreateModelExpression<OpenIdConfigViewModel, string>(viewData15, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Thumbprint())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter31 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						this.<>1__state = 30;
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_1F8E:
					awaiter31.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_200B;
					}
					awaiter32 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						this.<>1__state = 31;
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_2004:
					awaiter32.GetResult();
					IL_200B:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c941040", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_34));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData16 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider16.CreateModelExpression<OpenIdConfigViewModel, string>(viewData16, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Thumbprint())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter33 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						this.<>1__state = 32;
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_2177:
					awaiter33.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_21F4;
					}
					awaiter34 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						this.<>1__state = 33;
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_21ED:
					awaiter34.GetResult();
					IL_21F4:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"form-group\">\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c942915", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_36));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData17 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6.For = modelExpressionProvider17.CreateModelExpression<OpenIdConfigViewModel, string>(viewData17, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Audience())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter35 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						this.<>1__state = 34;
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_234D:
					awaiter35.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_23CA;
					}
					awaiter36 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						this.<>1__state = 35;
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_23C3:
					awaiter36.GetResult();
					IL_23CA:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c944843", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_38));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider18 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData18 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider18.CreateModelExpression<OpenIdConfigViewModel, string>(viewData18, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Audience())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter37 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter37.IsCompleted)
					{
						this.<>1__state = 36;
						this.<>u__1 = awaiter37;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter37, ref this);
						return;
					}
					IL_2536:
					awaiter37.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_25B3;
					}
					awaiter38 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter38.IsCompleted)
					{
						this.<>1__state = 37;
						this.<>u__1 = awaiter38;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter38, ref this);
						return;
					}
					IL_25AC:
					awaiter38.GetResult();
					IL_25B3:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c946512", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_40));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider19 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData19 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6.For = modelExpressionProvider19.CreateModelExpression<OpenIdConfigViewModel, string>(viewData19, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Audience())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter39 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter39.IsCompleted)
					{
						this.<>1__state = 38;
						this.<>u__1 = awaiter39;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter39, ref this);
						return;
					}
					IL_271F:
					awaiter39.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_279C;
					}
					awaiter40 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter40.IsCompleted)
					{
						this.<>1__state = 39;
						this.<>u__1 = awaiter40;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter40, ref this);
						return;
					}
					IL_2795:
					awaiter40.GetResult();
					IL_279C:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"tab-pane\" id=\"tabSecret\">\r\n                                            <div class=\"form-group\">\r\n                                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c948511", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_42));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper7 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider20 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData20 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper7.For = modelExpressionProvider20.CreateModelExpression<OpenIdConfigViewModel, string>(viewData20, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter41 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter41.IsCompleted)
					{
						this.<>1__state = 40;
						this.<>u__1 = awaiter41;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter41, ref this);
						return;
					}
					IL_28F5:
					awaiter41.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2972;
					}
					awaiter42 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter42.IsCompleted)
					{
						this.<>1__state = 41;
						this.<>u__1 = awaiter42;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter42, ref this);
						return;
					}
					IL_296B:
					awaiter42.GetResult();
					IL_2972:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                <div class=\"input-group\" id=\"show_hide_password\">\r\n                                                    ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c950557", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_44));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider21 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData21 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider21.CreateModelExpression<OpenIdConfigViewModel, string>(viewData21, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_5);
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_6.Value;
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_6);
					areas_Admin_Views_OpenId_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_OpenId_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_OpenId_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute("readonly", areas_Admin_Views_OpenId_Edit.Html.Raw(areas_Admin_Views_OpenId_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_7);
					areas_Admin_Views_OpenId_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_OpenId_Edit.WriteLiteral(areas_Admin_Views_OpenId_Edit.Model.ClientSecret);
					areas_Admin_Views_OpenId_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_OpenId_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_OpenId_Edit.__tagHelperStringValueBuffer;
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter43 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter43.IsCompleted)
					{
						this.<>1__state = 42;
						this.<>u__1 = awaiter43;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter43, ref this);
						return;
					}
					IL_2BAC:
					awaiter43.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2C29;
					}
					awaiter44 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter44.IsCompleted)
					{
						this.<>1__state = 43;
						this.<>u__1 = awaiter44;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter44, ref this);
						return;
					}
					IL_2C22:
					awaiter44.GetResult();
					IL_2C29:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                    <button class=\"input-group-text eye rounded-right\" type=\"button\">\r\n                                                        <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\" tabindex=\"-1\"></i>\r\n                                                    </button>\r\n                                                    ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c953983", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_46));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider22 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData22 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7.For = modelExpressionProvider22.CreateModelExpression<OpenIdConfigViewModel, string>(viewData22, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter45 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter45.IsCompleted)
					{
						this.<>1__state = 44;
						this.<>u__1 = awaiter45;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter45, ref this);
						return;
					}
					IL_2D95:
					awaiter45.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2E12;
					}
					awaiter46 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter46.IsCompleted)
					{
						this.<>1__state = 45;
						this.<>u__1 = awaiter46;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter46, ref this);
						return;
					}
					IL_2E0B:
					awaiter46.GetResult();
					IL_2E12:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                <p id=\"SignInUrl\">RedirectURI: ");
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.Model.PublicOrigin);
					areas_Admin_Views_OpenId_Edit.WriteLiteral("/uas/signin-");
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.Model.DisplayName.ToLower());
					areas_Admin_Views_OpenId_Edit.WriteLiteral("</p>\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c956766", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_48));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper8 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider23 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData23 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper8.For = modelExpressionProvider23.CreateModelExpression<OpenIdConfigViewModel, string>(viewData23, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Scope())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter47 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter47.IsCompleted)
					{
						this.<>1__state = 46;
						this.<>u__1 = awaiter47;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter47, ref this);
						return;
					}
					IL_2FA8:
					awaiter47.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3025;
					}
					awaiter48 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter48.IsCompleted)
					{
						this.<>1__state = 47;
						this.<>u__1 = awaiter48;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter48, ref this);
						return;
					}
					IL_301E:
					awaiter48.GetResult();
					IL_3025:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c958675", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_50));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider24 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData24 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider24.CreateModelExpression<OpenIdConfigViewModel, string>(viewData24, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Scope())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter49 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter49.IsCompleted)
					{
						this.<>1__state = 48;
						this.<>u__1 = awaiter49;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter49, ref this);
						return;
					}
					IL_3191:
					awaiter49.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_320E;
					}
					awaiter50 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter50.IsCompleted)
					{
						this.<>1__state = 49;
						this.<>u__1 = awaiter50;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter50, ref this);
						return;
					}
					IL_3207:
					awaiter50.GetResult();
					IL_320E:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c960326", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_52));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider25 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData25 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper8.For = modelExpressionProvider25.CreateModelExpression<OpenIdConfigViewModel, string>(viewData25, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Scope())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter51 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter51.IsCompleted)
					{
						this.<>1__state = 50;
						this.<>u__1 = awaiter51;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter51, ref this);
						return;
					}
					IL_337A:
					awaiter51.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_33F7;
					}
					awaiter52 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter52.IsCompleted)
					{
						this.<>1__state = 51;
						this.<>u__1 = awaiter52;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter52, ref this);
						return;
					}
					IL_33F0:
					awaiter52.GetResult();
					IL_33F7:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c962153", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_54));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper9 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider26 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData26 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper9.For = modelExpressionProvider26.CreateModelExpression<OpenIdConfigViewModel, string>(viewData26, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter53 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter53.IsCompleted)
					{
						this.<>1__state = 52;
						this.<>u__1 = awaiter53;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter53, ref this);
						return;
					}
					IL_3550:
					awaiter53.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_35CD;
					}
					awaiter54 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter54.IsCompleted)
					{
						this.<>1__state = 53;
						this.<>u__1 = awaiter54;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter54, ref this);
						return;
					}
					IL_35C6:
					awaiter54.GetResult();
					IL_35CD:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c964078", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_56));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider27 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData27 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider27.CreateModelExpression<OpenIdConfigViewModel, string>(viewData27, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter55 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter55.IsCompleted)
					{
						this.<>1__state = 54;
						this.<>u__1 = awaiter55;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter55, ref this);
						return;
					}
					IL_3739:
					awaiter55.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_37B6;
					}
					awaiter56 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter56.IsCompleted)
					{
						this.<>1__state = 55;
						this.<>u__1 = awaiter56;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter56, ref this);
						return;
					}
					IL_37AF:
					awaiter56.GetResult();
					IL_37B6:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c965737", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_58));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper9 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider28 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData28 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper9.For = modelExpressionProvider28.CreateModelExpression<OpenIdConfigViewModel, string>(viewData28, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter57 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter57.IsCompleted)
					{
						this.<>1__state = 56;
						this.<>u__1 = awaiter57;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter57, ref this);
						return;
					}
					IL_3922:
					awaiter57.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_399F;
					}
					awaiter58 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter58.IsCompleted)
					{
						this.<>1__state = 57;
						this.<>u__1 = awaiter58;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter58, ref this);
						return;
					}
					IL_3998:
					awaiter58.GetResult();
					IL_399F:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                            \r\n                             <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c967601", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_60));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper10 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider29 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData29 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper10.For = modelExpressionProvider29.CreateModelExpression<OpenIdConfigViewModel, string>(viewData29, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter59 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter59.IsCompleted)
					{
						this.<>1__state = 58;
						this.<>u__1 = awaiter59;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter59, ref this);
						return;
					}
					IL_3AF8:
					awaiter59.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3B75;
					}
					awaiter60 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter60.IsCompleted)
					{
						this.<>1__state = 59;
						this.<>u__1 = awaiter60;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter60, ref this);
						return;
					}
					IL_3B6E:
					awaiter60.GetResult();
					IL_3B75:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c969522", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_62));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider30 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData30 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11.For = modelExpressionProvider30.CreateModelExpression<OpenIdConfigViewModel, string>(viewData30, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter61 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter61.IsCompleted)
					{
						this.<>1__state = 60;
						this.<>u__1 = awaiter61;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter61, ref this);
						return;
					}
					IL_3CE1:
					awaiter61.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3D5E;
					}
					awaiter62 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter62.IsCompleted)
					{
						this.<>1__state = 61;
						this.<>u__1 = awaiter62;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter62, ref this);
						return;
					}
					IL_3D57:
					awaiter62.GetResult();
					IL_3D5E:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c971179", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_64));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper10 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider31 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData31 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper10.For = modelExpressionProvider31.CreateModelExpression<OpenIdConfigViewModel, string>(viewData31, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter63 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter63.IsCompleted)
					{
						this.<>1__state = 62;
						this.<>u__1 = awaiter63;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter63, ref this);
						return;
					}
					IL_3ECA:
					awaiter63.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3F47;
					}
					awaiter64 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter64.IsCompleted)
					{
						this.<>1__state = 63;
						this.<>u__1 = awaiter64;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter64, ref this);
						return;
					}
					IL_3F40:
					awaiter64.GetResult();
					IL_3F47:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c973012", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_66));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper11 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider32 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData32 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper11.For = modelExpressionProvider32.CreateModelExpression<OpenIdConfigViewModel, string>(viewData32, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_MetadataAddress())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter65 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter65.IsCompleted)
					{
						this.<>1__state = 64;
						this.<>u__1 = awaiter65;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter65, ref this);
						return;
					}
					IL_40A0:
					awaiter65.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_411D;
					}
					awaiter66 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter66.IsCompleted)
					{
						this.<>1__state = 65;
						this.<>u__1 = awaiter66;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter66, ref this);
						return;
					}
					IL_4116:
					awaiter66.GetResult();
					IL_411D:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c974941", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_68));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider33 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData33 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12.For = modelExpressionProvider33.CreateModelExpression<OpenIdConfigViewModel, string>(viewData33, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_MetadataAddress())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter67 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter67.IsCompleted)
					{
						this.<>1__state = 66;
						this.<>u__1 = awaiter67;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter67, ref this);
						return;
					}
					IL_4289:
					awaiter67.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4306;
					}
					awaiter68 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter68.IsCompleted)
					{
						this.<>1__state = 67;
						this.<>u__1 = awaiter68;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter68, ref this);
						return;
					}
					IL_42FF:
					awaiter68.GetResult();
					IL_4306:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c976602", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_70));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper11 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider34 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData34 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper11.For = modelExpressionProvider34.CreateModelExpression<OpenIdConfigViewModel, string>(viewData34, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_MetadataAddress())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter69 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter69.IsCompleted)
					{
						this.<>1__state = 68;
						this.<>u__1 = awaiter69;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter69, ref this);
						return;
					}
					IL_4472:
					awaiter69.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_44EF;
					}
					awaiter70 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter70.IsCompleted)
					{
						this.<>1__state = 69;
						this.<>u__1 = awaiter70;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter70, ref this);
						return;
					}
					IL_44E8:
					awaiter70.GetResult();
					IL_44EF:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                            \r\n                            <div class=\"form-group\">\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c978467", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_72));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper12 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider35 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData35 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper12.For = modelExpressionProvider35.CreateModelExpression<OpenIdConfigViewModel, string>(viewData35, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_2);
					awaiter71 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter71.IsCompleted)
					{
						this.<>1__state = 70;
						this.<>u__1 = awaiter71;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter71, ref this);
						return;
					}
					IL_4648:
					awaiter71.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_46C5;
					}
					awaiter72 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter72.IsCompleted)
					{
						this.<>1__state = 71;
						this.<>u__1 = awaiter72;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter72, ref this);
						return;
					}
					IL_46BE:
					awaiter72.GetResult();
					IL_46C5:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c980398", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_74));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider36 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData36 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13.For = modelExpressionProvider36.CreateModelExpression<OpenIdConfigViewModel, string>(viewData36, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_3);
					awaiter73 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter73.IsCompleted)
					{
						this.<>1__state = 72;
						this.<>u__1 = awaiter73;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter73, ref this);
						return;
					}
					IL_4831:
					awaiter73.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_48AE;
					}
					awaiter74 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter74.IsCompleted)
					{
						this.<>1__state = 73;
						this.<>u__1 = awaiter74;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter74, ref this);
						return;
					}
					IL_48A7:
					awaiter74.GetResult();
					IL_48AE:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c982060", new Func<Task>(Areas_Admin_Views_OpenId_Edit.<>c.<>9.<ExecuteAsync>b__24_76));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper12 = areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider37 = areas_Admin_Views_OpenId_Edit.ModelExpressionProvider;
					ViewDataDictionary<OpenIdConfigViewModel> viewData37 = areas_Admin_Views_OpenId_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper12.For = modelExpressionProvider37.CreateModelExpression<OpenIdConfigViewModel, string>(viewData37, Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_0);
					awaiter75 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter75.IsCompleted)
					{
						this.<>1__state = 74;
						this.<>u__1 = awaiter75;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter75, ref this);
						return;
					}
					IL_4A1A:
					awaiter75.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4A97;
					}
					awaiter76 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter76.IsCompleted)
					{
						this.<>1__state = 75;
						this.<>u__1 = awaiter76;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter76, ref this);
						return;
					}
					IL_4A90:
					awaiter76.GetResult();
					IL_4A97:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group pull-right\">\r\n                ");
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("a", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c983985", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_78));
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<AnchorTagHelper>();
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
					areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_8.Value;
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_8);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_9);
					awaiter77 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter77.IsCompleted)
					{
						this.<>1__state = 76;
						this.<>u__1 = awaiter77;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter77, ref this);
						return;
					}
					IL_4BA6:
					awaiter77.GetResult();
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_4C20;
					}
					awaiter78 = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter78.IsCompleted)
					{
						this.<>1__state = 77;
						this.<>u__1 = awaiter78;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<<ExecuteAsync>b__24_0>d>(ref awaiter78, ref this);
						return;
					}
					IL_4C19:
					awaiter78.GetResult();
					IL_4C20:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-success\" data-bs-toggle=\"modal\" data-bs-target=\"#OpenIDModal\">Save</button>\r\n            </div>\r\n        ");
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

			// Token: 0x06000993 RID: 2451 RVA: 0x00038DD4 File Offset: 0x00036FD4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400070C RID: 1804
			public int <>1__state;

			// Token: 0x0400070D RID: 1805
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400070E RID: 1806
			public Areas_Admin_Views_OpenId_Edit <>4__this;

			// Token: 0x0400070F RID: 1807
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000119 RID: 281
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_12>d : IAsyncStateMachine
		{
			// Token: 0x06000994 RID: 2452 RVA: 0x00038DE4 File Offset: 0x00036FE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Authority())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x06000995 RID: 2453 RVA: 0x00038E88 File Offset: 0x00037088
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000710 RID: 1808
			public int <>1__state;

			// Token: 0x04000711 RID: 1809
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000712 RID: 1810
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011A RID: 282
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_18>d : IAsyncStateMachine
		{
			// Token: 0x06000996 RID: 2454 RVA: 0x00038E98 File Offset: 0x00037098
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Proxy())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x06000997 RID: 2455 RVA: 0x00038F3C File Offset: 0x0003713C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000713 RID: 1811
			public int <>1__state;

			// Token: 0x04000714 RID: 1812
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000715 RID: 1813
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_1>d : IAsyncStateMachine
		{
			// Token: 0x06000998 RID: 2456 RVA: 0x00038F4C File Offset: 0x0003714C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n    <script>\r\n        function DisplayNameChanged(value) {\r\n            var publicOrigin = \"");
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.Model.PublicOrigin);
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\";\r\n            $(\"#SignInUrl\").text(\"RedirectURI: \" + publicOrigin + \"/uas/signin-\" + value.toLowerCase());\r\n        }\r\n    </script>\r\n");
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

			// Token: 0x06000999 RID: 2457 RVA: 0x00038FCC File Offset: 0x000371CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000716 RID: 1814
			public int <>1__state;

			// Token: 0x04000717 RID: 1815
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000718 RID: 1816
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011C RID: 284
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_24>d : IAsyncStateMachine
		{
			// Token: 0x0600099A RID: 2458 RVA: 0x00038FDC File Offset: 0x000371DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x0600099B RID: 2459 RVA: 0x00039080 File Offset: 0x00037280
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000719 RID: 1817
			public int <>1__state;

			// Token: 0x0400071A RID: 1818
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400071B RID: 1819
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011D RID: 285
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_30>d : IAsyncStateMachine
		{
			// Token: 0x0600099C RID: 2460 RVA: 0x00039090 File Offset: 0x00037290
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Thumbprint())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x0600099D RID: 2461 RVA: 0x00039134 File Offset: 0x00037334
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400071C RID: 1820
			public int <>1__state;

			// Token: 0x0400071D RID: 1821
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400071E RID: 1822
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011E RID: 286
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_36>d : IAsyncStateMachine
		{
			// Token: 0x0600099E RID: 2462 RVA: 0x00039144 File Offset: 0x00037344
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Audience())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x0600099F RID: 2463 RVA: 0x000391E8 File Offset: 0x000373E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400071F RID: 1823
			public int <>1__state;

			// Token: 0x04000720 RID: 1824
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000721 RID: 1825
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x0200011F RID: 287
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_42>d : IAsyncStateMachine
		{
			// Token: 0x060009A0 RID: 2464 RVA: 0x000391F8 File Offset: 0x000373F8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009A1 RID: 2465 RVA: 0x0003929C File Offset: 0x0003749C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000722 RID: 1826
			public int <>1__state;

			// Token: 0x04000723 RID: 1827
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000724 RID: 1828
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000120 RID: 288
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_48>d : IAsyncStateMachine
		{
			// Token: 0x060009A2 RID: 2466 RVA: 0x000392AC File Offset: 0x000374AC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_Scope())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009A3 RID: 2467 RVA: 0x00039350 File Offset: 0x00037550
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000725 RID: 1829
			public int <>1__state;

			// Token: 0x04000726 RID: 1830
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000727 RID: 1831
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000121 RID: 289
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_54>d : IAsyncStateMachine
		{
			// Token: 0x060009A4 RID: 2468 RVA: 0x00039360 File Offset: 0x00037560
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009A5 RID: 2469 RVA: 0x00039404 File Offset: 0x00037604
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000728 RID: 1832
			public int <>1__state;

			// Token: 0x04000729 RID: 1833
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400072A RID: 1834
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000122 RID: 290
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_60>d : IAsyncStateMachine
		{
			// Token: 0x060009A6 RID: 2470 RVA: 0x00039414 File Offset: 0x00037614
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_ClaimForSub())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009A7 RID: 2471 RVA: 0x000394B8 File Offset: 0x000376B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400072B RID: 1835
			public int <>1__state;

			// Token: 0x0400072C RID: 1836
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400072D RID: 1837
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_66>d : IAsyncStateMachine
		{
			// Token: 0x060009A8 RID: 2472 RVA: 0x000394C8 File Offset: 0x000376C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_MetadataAddress())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009A9 RID: 2473 RVA: 0x0003956C File Offset: 0x0003776C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400072E RID: 1838
			public int <>1__state;

			// Token: 0x0400072F RID: 1839
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000730 RID: 1840
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000124 RID: 292
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_6>d : IAsyncStateMachine
		{
			// Token: 0x060009AA RID: 2474 RVA: 0x0003957C File Offset: 0x0003777C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_OpenId_Edit.WriteLiteral("  ");
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_DisplayName())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009AB RID: 2475 RVA: 0x00039628 File Offset: 0x00037828
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000731 RID: 1841
			public int <>1__state;

			// Token: 0x04000732 RID: 1842
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000733 RID: 1843
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000125 RID: 293
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_72>d : IAsyncStateMachine
		{
			// Token: 0x060009AC RID: 2476 RVA: 0x00039638 File Offset: 0x00037838
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					RazorPageBase razorPageBase = areas_Admin_Views_OpenId_Edit;
					IHtmlHelper<OpenIdConfigViewModel> html = areas_Admin_Views_OpenId_Edit.Html;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(OpenIdConfigViewModel), "model");
					razorPageBase.Write(html.DisplayNameFor<string>(Expression.Lambda<Func<OpenIdConfigViewModel, string>>(Expression.Property(parameterExpression, methodof(OpenIdConfigViewModel.get_GroupsAuthorized())), new ParameterExpression[] { parameterExpression })));
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

			// Token: 0x060009AD RID: 2477 RVA: 0x000396DC File Offset: 0x000378DC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000734 RID: 1844
			public int <>1__state;

			// Token: 0x04000735 RID: 1845
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000736 RID: 1846
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000126 RID: 294
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__24_78>d : IAsyncStateMachine
		{
			// Token: 0x060009AE RID: 2478 RVA: 0x000396EC File Offset: 0x000378EC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_OpenId_Edit.WriteLiteral("Cancel");
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

			// Token: 0x060009AF RID: 2479 RVA: 0x00039750 File Offset: 0x00037950
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000737 RID: 1847
			public int <>1__state;

			// Token: 0x04000738 RID: 1848
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000739 RID: 1849
			public Areas_Admin_Views_OpenId_Edit <>4__this;
		}

		// Token: 0x02000127 RID: 295
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060009B2 RID: 2482 RVA: 0x00039774 File Offset: 0x00037974
			internal Task <ExecuteAsync>b__24_2()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_2>d <<ExecuteAsync>b__24_2>d;
				<<ExecuteAsync>b__24_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_2>d.<>1__state = -1;
				<<ExecuteAsync>b__24_2>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_2>d>(ref <<ExecuteAsync>b__24_2>d);
				return <<ExecuteAsync>b__24_2>d.<>t__builder.Task;
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x000397B0 File Offset: 0x000379B0
			internal Task <ExecuteAsync>b__24_3()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_3>d <<ExecuteAsync>b__24_3>d;
				<<ExecuteAsync>b__24_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_3>d.<>1__state = -1;
				<<ExecuteAsync>b__24_3>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_3>d>(ref <<ExecuteAsync>b__24_3>d);
				return <<ExecuteAsync>b__24_3>d.<>t__builder.Task;
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x000397EC File Offset: 0x000379EC
			internal Task <ExecuteAsync>b__24_8()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_8>d <<ExecuteAsync>b__24_8>d;
				<<ExecuteAsync>b__24_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_8>d.<>1__state = -1;
				<<ExecuteAsync>b__24_8>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_8>d>(ref <<ExecuteAsync>b__24_8>d);
				return <<ExecuteAsync>b__24_8>d.<>t__builder.Task;
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x00039828 File Offset: 0x00037A28
			internal Task <ExecuteAsync>b__24_10()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_10>d <<ExecuteAsync>b__24_10>d;
				<<ExecuteAsync>b__24_10>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_10>d.<>1__state = -1;
				<<ExecuteAsync>b__24_10>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_10>d>(ref <<ExecuteAsync>b__24_10>d);
				return <<ExecuteAsync>b__24_10>d.<>t__builder.Task;
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00039864 File Offset: 0x00037A64
			internal Task <ExecuteAsync>b__24_14()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_14>d <<ExecuteAsync>b__24_14>d;
				<<ExecuteAsync>b__24_14>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_14>d.<>1__state = -1;
				<<ExecuteAsync>b__24_14>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_14>d>(ref <<ExecuteAsync>b__24_14>d);
				return <<ExecuteAsync>b__24_14>d.<>t__builder.Task;
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x000398A0 File Offset: 0x00037AA0
			internal Task <ExecuteAsync>b__24_16()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_16>d <<ExecuteAsync>b__24_16>d;
				<<ExecuteAsync>b__24_16>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_16>d.<>1__state = -1;
				<<ExecuteAsync>b__24_16>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_16>d>(ref <<ExecuteAsync>b__24_16>d);
				return <<ExecuteAsync>b__24_16>d.<>t__builder.Task;
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x000398DC File Offset: 0x00037ADC
			internal Task <ExecuteAsync>b__24_20()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_20>d <<ExecuteAsync>b__24_20>d;
				<<ExecuteAsync>b__24_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_20>d.<>1__state = -1;
				<<ExecuteAsync>b__24_20>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_20>d>(ref <<ExecuteAsync>b__24_20>d);
				return <<ExecuteAsync>b__24_20>d.<>t__builder.Task;
			}

			// Token: 0x060009B9 RID: 2489 RVA: 0x00039918 File Offset: 0x00037B18
			internal Task <ExecuteAsync>b__24_22()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_22>d <<ExecuteAsync>b__24_22>d;
				<<ExecuteAsync>b__24_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_22>d.<>1__state = -1;
				<<ExecuteAsync>b__24_22>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_22>d>(ref <<ExecuteAsync>b__24_22>d);
				return <<ExecuteAsync>b__24_22>d.<>t__builder.Task;
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x00039954 File Offset: 0x00037B54
			internal Task <ExecuteAsync>b__24_26()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_26>d <<ExecuteAsync>b__24_26>d;
				<<ExecuteAsync>b__24_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_26>d.<>1__state = -1;
				<<ExecuteAsync>b__24_26>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_26>d>(ref <<ExecuteAsync>b__24_26>d);
				return <<ExecuteAsync>b__24_26>d.<>t__builder.Task;
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x00039990 File Offset: 0x00037B90
			internal Task <ExecuteAsync>b__24_28()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_28>d <<ExecuteAsync>b__24_28>d;
				<<ExecuteAsync>b__24_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_28>d.<>1__state = -1;
				<<ExecuteAsync>b__24_28>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_28>d>(ref <<ExecuteAsync>b__24_28>d);
				return <<ExecuteAsync>b__24_28>d.<>t__builder.Task;
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x000399CC File Offset: 0x00037BCC
			internal Task <ExecuteAsync>b__24_32()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_32>d <<ExecuteAsync>b__24_32>d;
				<<ExecuteAsync>b__24_32>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_32>d.<>1__state = -1;
				<<ExecuteAsync>b__24_32>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_32>d>(ref <<ExecuteAsync>b__24_32>d);
				return <<ExecuteAsync>b__24_32>d.<>t__builder.Task;
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x00039A08 File Offset: 0x00037C08
			internal Task <ExecuteAsync>b__24_34()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_34>d <<ExecuteAsync>b__24_34>d;
				<<ExecuteAsync>b__24_34>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_34>d.<>1__state = -1;
				<<ExecuteAsync>b__24_34>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_34>d>(ref <<ExecuteAsync>b__24_34>d);
				return <<ExecuteAsync>b__24_34>d.<>t__builder.Task;
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x00039A44 File Offset: 0x00037C44
			internal Task <ExecuteAsync>b__24_38()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_38>d <<ExecuteAsync>b__24_38>d;
				<<ExecuteAsync>b__24_38>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_38>d.<>1__state = -1;
				<<ExecuteAsync>b__24_38>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_38>d>(ref <<ExecuteAsync>b__24_38>d);
				return <<ExecuteAsync>b__24_38>d.<>t__builder.Task;
			}

			// Token: 0x060009BF RID: 2495 RVA: 0x00039A80 File Offset: 0x00037C80
			internal Task <ExecuteAsync>b__24_40()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_40>d <<ExecuteAsync>b__24_40>d;
				<<ExecuteAsync>b__24_40>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_40>d.<>1__state = -1;
				<<ExecuteAsync>b__24_40>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_40>d>(ref <<ExecuteAsync>b__24_40>d);
				return <<ExecuteAsync>b__24_40>d.<>t__builder.Task;
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x00039ABC File Offset: 0x00037CBC
			internal Task <ExecuteAsync>b__24_44()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_44>d <<ExecuteAsync>b__24_44>d;
				<<ExecuteAsync>b__24_44>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_44>d.<>1__state = -1;
				<<ExecuteAsync>b__24_44>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_44>d>(ref <<ExecuteAsync>b__24_44>d);
				return <<ExecuteAsync>b__24_44>d.<>t__builder.Task;
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x00039AF8 File Offset: 0x00037CF8
			internal Task <ExecuteAsync>b__24_46()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_46>d <<ExecuteAsync>b__24_46>d;
				<<ExecuteAsync>b__24_46>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_46>d.<>1__state = -1;
				<<ExecuteAsync>b__24_46>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_46>d>(ref <<ExecuteAsync>b__24_46>d);
				return <<ExecuteAsync>b__24_46>d.<>t__builder.Task;
			}

			// Token: 0x060009C2 RID: 2498 RVA: 0x00039B34 File Offset: 0x00037D34
			internal Task <ExecuteAsync>b__24_50()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_50>d <<ExecuteAsync>b__24_50>d;
				<<ExecuteAsync>b__24_50>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_50>d.<>1__state = -1;
				<<ExecuteAsync>b__24_50>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_50>d>(ref <<ExecuteAsync>b__24_50>d);
				return <<ExecuteAsync>b__24_50>d.<>t__builder.Task;
			}

			// Token: 0x060009C3 RID: 2499 RVA: 0x00039B70 File Offset: 0x00037D70
			internal Task <ExecuteAsync>b__24_52()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_52>d <<ExecuteAsync>b__24_52>d;
				<<ExecuteAsync>b__24_52>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_52>d.<>1__state = -1;
				<<ExecuteAsync>b__24_52>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_52>d>(ref <<ExecuteAsync>b__24_52>d);
				return <<ExecuteAsync>b__24_52>d.<>t__builder.Task;
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x00039BAC File Offset: 0x00037DAC
			internal Task <ExecuteAsync>b__24_56()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_56>d <<ExecuteAsync>b__24_56>d;
				<<ExecuteAsync>b__24_56>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_56>d.<>1__state = -1;
				<<ExecuteAsync>b__24_56>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_56>d>(ref <<ExecuteAsync>b__24_56>d);
				return <<ExecuteAsync>b__24_56>d.<>t__builder.Task;
			}

			// Token: 0x060009C5 RID: 2501 RVA: 0x00039BE8 File Offset: 0x00037DE8
			internal Task <ExecuteAsync>b__24_58()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_58>d <<ExecuteAsync>b__24_58>d;
				<<ExecuteAsync>b__24_58>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_58>d.<>1__state = -1;
				<<ExecuteAsync>b__24_58>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_58>d>(ref <<ExecuteAsync>b__24_58>d);
				return <<ExecuteAsync>b__24_58>d.<>t__builder.Task;
			}

			// Token: 0x060009C6 RID: 2502 RVA: 0x00039C24 File Offset: 0x00037E24
			internal Task <ExecuteAsync>b__24_62()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_62>d <<ExecuteAsync>b__24_62>d;
				<<ExecuteAsync>b__24_62>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_62>d.<>1__state = -1;
				<<ExecuteAsync>b__24_62>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_62>d>(ref <<ExecuteAsync>b__24_62>d);
				return <<ExecuteAsync>b__24_62>d.<>t__builder.Task;
			}

			// Token: 0x060009C7 RID: 2503 RVA: 0x00039C60 File Offset: 0x00037E60
			internal Task <ExecuteAsync>b__24_64()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_64>d <<ExecuteAsync>b__24_64>d;
				<<ExecuteAsync>b__24_64>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_64>d.<>1__state = -1;
				<<ExecuteAsync>b__24_64>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_64>d>(ref <<ExecuteAsync>b__24_64>d);
				return <<ExecuteAsync>b__24_64>d.<>t__builder.Task;
			}

			// Token: 0x060009C8 RID: 2504 RVA: 0x00039C9C File Offset: 0x00037E9C
			internal Task <ExecuteAsync>b__24_68()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_68>d <<ExecuteAsync>b__24_68>d;
				<<ExecuteAsync>b__24_68>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_68>d.<>1__state = -1;
				<<ExecuteAsync>b__24_68>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_68>d>(ref <<ExecuteAsync>b__24_68>d);
				return <<ExecuteAsync>b__24_68>d.<>t__builder.Task;
			}

			// Token: 0x060009C9 RID: 2505 RVA: 0x00039CD8 File Offset: 0x00037ED8
			internal Task <ExecuteAsync>b__24_70()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_70>d <<ExecuteAsync>b__24_70>d;
				<<ExecuteAsync>b__24_70>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_70>d.<>1__state = -1;
				<<ExecuteAsync>b__24_70>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_70>d>(ref <<ExecuteAsync>b__24_70>d);
				return <<ExecuteAsync>b__24_70>d.<>t__builder.Task;
			}

			// Token: 0x060009CA RID: 2506 RVA: 0x00039D14 File Offset: 0x00037F14
			internal Task <ExecuteAsync>b__24_74()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_74>d <<ExecuteAsync>b__24_74>d;
				<<ExecuteAsync>b__24_74>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_74>d.<>1__state = -1;
				<<ExecuteAsync>b__24_74>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_74>d>(ref <<ExecuteAsync>b__24_74>d);
				return <<ExecuteAsync>b__24_74>d.<>t__builder.Task;
			}

			// Token: 0x060009CB RID: 2507 RVA: 0x00039D50 File Offset: 0x00037F50
			internal Task <ExecuteAsync>b__24_76()
			{
				Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_76>d <<ExecuteAsync>b__24_76>d;
				<<ExecuteAsync>b__24_76>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__24_76>d.<>1__state = -1;
				<<ExecuteAsync>b__24_76>d.<>t__builder.Start<Areas_Admin_Views_OpenId_Edit.<>c.<<ExecuteAsync>b__24_76>d>(ref <<ExecuteAsync>b__24_76>d);
				return <<ExecuteAsync>b__24_76>d.<>t__builder.Task;
			}

			// Token: 0x0400073A RID: 1850
			public static readonly Areas_Admin_Views_OpenId_Edit.<>c <>9 = new Areas_Admin_Views_OpenId_Edit.<>c();

			// Token: 0x0400073B RID: 1851
			public static Func<Task> <>9__24_2;

			// Token: 0x0400073C RID: 1852
			public static Func<Task> <>9__24_3;

			// Token: 0x0400073D RID: 1853
			public static Func<Task> <>9__24_8;

			// Token: 0x0400073E RID: 1854
			public static Func<Task> <>9__24_10;

			// Token: 0x0400073F RID: 1855
			public static Func<Task> <>9__24_14;

			// Token: 0x04000740 RID: 1856
			public static Func<Task> <>9__24_16;

			// Token: 0x04000741 RID: 1857
			public static Func<Task> <>9__24_20;

			// Token: 0x04000742 RID: 1858
			public static Func<Task> <>9__24_22;

			// Token: 0x04000743 RID: 1859
			public static Func<Task> <>9__24_26;

			// Token: 0x04000744 RID: 1860
			public static Func<Task> <>9__24_28;

			// Token: 0x04000745 RID: 1861
			public static Func<Task> <>9__24_32;

			// Token: 0x04000746 RID: 1862
			public static Func<Task> <>9__24_34;

			// Token: 0x04000747 RID: 1863
			public static Func<Task> <>9__24_38;

			// Token: 0x04000748 RID: 1864
			public static Func<Task> <>9__24_40;

			// Token: 0x04000749 RID: 1865
			public static Func<Task> <>9__24_44;

			// Token: 0x0400074A RID: 1866
			public static Func<Task> <>9__24_46;

			// Token: 0x0400074B RID: 1867
			public static Func<Task> <>9__24_50;

			// Token: 0x0400074C RID: 1868
			public static Func<Task> <>9__24_52;

			// Token: 0x0400074D RID: 1869
			public static Func<Task> <>9__24_56;

			// Token: 0x0400074E RID: 1870
			public static Func<Task> <>9__24_58;

			// Token: 0x0400074F RID: 1871
			public static Func<Task> <>9__24_62;

			// Token: 0x04000750 RID: 1872
			public static Func<Task> <>9__24_64;

			// Token: 0x04000751 RID: 1873
			public static Func<Task> <>9__24_68;

			// Token: 0x04000752 RID: 1874
			public static Func<Task> <>9__24_70;

			// Token: 0x04000753 RID: 1875
			public static Func<Task> <>9__24_74;

			// Token: 0x04000754 RID: 1876
			public static Func<Task> <>9__24_76;

			// Token: 0x020002D5 RID: 725
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_10>d : IAsyncStateMachine
			{
				// Token: 0x06000EB8 RID: 3768 RVA: 0x00072D3C File Offset: 0x00070F3C
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

				// Token: 0x06000EB9 RID: 3769 RVA: 0x00072D8C File Offset: 0x00070F8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E4B RID: 3659
				public int <>1__state;

				// Token: 0x04000E4C RID: 3660
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D6 RID: 726
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_14>d : IAsyncStateMachine
			{
				// Token: 0x06000EBA RID: 3770 RVA: 0x00072D9C File Offset: 0x00070F9C
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

				// Token: 0x06000EBB RID: 3771 RVA: 0x00072DEC File Offset: 0x00070FEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E4D RID: 3661
				public int <>1__state;

				// Token: 0x04000E4E RID: 3662
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D7 RID: 727
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_16>d : IAsyncStateMachine
			{
				// Token: 0x06000EBC RID: 3772 RVA: 0x00072DFC File Offset: 0x00070FFC
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

				// Token: 0x06000EBD RID: 3773 RVA: 0x00072E4C File Offset: 0x0007104C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E4F RID: 3663
				public int <>1__state;

				// Token: 0x04000E50 RID: 3664
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D8 RID: 728
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_20>d : IAsyncStateMachine
			{
				// Token: 0x06000EBE RID: 3774 RVA: 0x00072E5C File Offset: 0x0007105C
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

				// Token: 0x06000EBF RID: 3775 RVA: 0x00072EAC File Offset: 0x000710AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E51 RID: 3665
				public int <>1__state;

				// Token: 0x04000E52 RID: 3666
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D9 RID: 729
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_22>d : IAsyncStateMachine
			{
				// Token: 0x06000EC0 RID: 3776 RVA: 0x00072EBC File Offset: 0x000710BC
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

				// Token: 0x06000EC1 RID: 3777 RVA: 0x00072F0C File Offset: 0x0007110C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E53 RID: 3667
				public int <>1__state;

				// Token: 0x04000E54 RID: 3668
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DA RID: 730
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_26>d : IAsyncStateMachine
			{
				// Token: 0x06000EC2 RID: 3778 RVA: 0x00072F1C File Offset: 0x0007111C
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

				// Token: 0x06000EC3 RID: 3779 RVA: 0x00072F6C File Offset: 0x0007116C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E55 RID: 3669
				public int <>1__state;

				// Token: 0x04000E56 RID: 3670
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DB RID: 731
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_28>d : IAsyncStateMachine
			{
				// Token: 0x06000EC4 RID: 3780 RVA: 0x00072F7C File Offset: 0x0007117C
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

				// Token: 0x06000EC5 RID: 3781 RVA: 0x00072FCC File Offset: 0x000711CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E57 RID: 3671
				public int <>1__state;

				// Token: 0x04000E58 RID: 3672
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DC RID: 732
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_2>d : IAsyncStateMachine
			{
				// Token: 0x06000EC6 RID: 3782 RVA: 0x00072FDC File Offset: 0x000711DC
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

				// Token: 0x06000EC7 RID: 3783 RVA: 0x0007302C File Offset: 0x0007122C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E59 RID: 3673
				public int <>1__state;

				// Token: 0x04000E5A RID: 3674
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DD RID: 733
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_32>d : IAsyncStateMachine
			{
				// Token: 0x06000EC8 RID: 3784 RVA: 0x0007303C File Offset: 0x0007123C
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

				// Token: 0x06000EC9 RID: 3785 RVA: 0x0007308C File Offset: 0x0007128C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E5B RID: 3675
				public int <>1__state;

				// Token: 0x04000E5C RID: 3676
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DE RID: 734
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_34>d : IAsyncStateMachine
			{
				// Token: 0x06000ECA RID: 3786 RVA: 0x0007309C File Offset: 0x0007129C
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

				// Token: 0x06000ECB RID: 3787 RVA: 0x000730EC File Offset: 0x000712EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E5D RID: 3677
				public int <>1__state;

				// Token: 0x04000E5E RID: 3678
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002DF RID: 735
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_38>d : IAsyncStateMachine
			{
				// Token: 0x06000ECC RID: 3788 RVA: 0x000730FC File Offset: 0x000712FC
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

				// Token: 0x06000ECD RID: 3789 RVA: 0x0007314C File Offset: 0x0007134C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E5F RID: 3679
				public int <>1__state;

				// Token: 0x04000E60 RID: 3680
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E0 RID: 736
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_3>d : IAsyncStateMachine
			{
				// Token: 0x06000ECE RID: 3790 RVA: 0x0007315C File Offset: 0x0007135C
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

				// Token: 0x06000ECF RID: 3791 RVA: 0x000731AC File Offset: 0x000713AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E61 RID: 3681
				public int <>1__state;

				// Token: 0x04000E62 RID: 3682
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E1 RID: 737
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_40>d : IAsyncStateMachine
			{
				// Token: 0x06000ED0 RID: 3792 RVA: 0x000731BC File Offset: 0x000713BC
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

				// Token: 0x06000ED1 RID: 3793 RVA: 0x0007320C File Offset: 0x0007140C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E63 RID: 3683
				public int <>1__state;

				// Token: 0x04000E64 RID: 3684
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E2 RID: 738
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_44>d : IAsyncStateMachine
			{
				// Token: 0x06000ED2 RID: 3794 RVA: 0x0007321C File Offset: 0x0007141C
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

				// Token: 0x06000ED3 RID: 3795 RVA: 0x0007326C File Offset: 0x0007146C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E65 RID: 3685
				public int <>1__state;

				// Token: 0x04000E66 RID: 3686
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E3 RID: 739
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_46>d : IAsyncStateMachine
			{
				// Token: 0x06000ED4 RID: 3796 RVA: 0x0007327C File Offset: 0x0007147C
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

				// Token: 0x06000ED5 RID: 3797 RVA: 0x000732CC File Offset: 0x000714CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E67 RID: 3687
				public int <>1__state;

				// Token: 0x04000E68 RID: 3688
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E4 RID: 740
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_50>d : IAsyncStateMachine
			{
				// Token: 0x06000ED6 RID: 3798 RVA: 0x000732DC File Offset: 0x000714DC
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

				// Token: 0x06000ED7 RID: 3799 RVA: 0x0007332C File Offset: 0x0007152C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E69 RID: 3689
				public int <>1__state;

				// Token: 0x04000E6A RID: 3690
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E5 RID: 741
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_52>d : IAsyncStateMachine
			{
				// Token: 0x06000ED8 RID: 3800 RVA: 0x0007333C File Offset: 0x0007153C
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

				// Token: 0x06000ED9 RID: 3801 RVA: 0x0007338C File Offset: 0x0007158C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E6B RID: 3691
				public int <>1__state;

				// Token: 0x04000E6C RID: 3692
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E6 RID: 742
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_56>d : IAsyncStateMachine
			{
				// Token: 0x06000EDA RID: 3802 RVA: 0x0007339C File Offset: 0x0007159C
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

				// Token: 0x06000EDB RID: 3803 RVA: 0x000733EC File Offset: 0x000715EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E6D RID: 3693
				public int <>1__state;

				// Token: 0x04000E6E RID: 3694
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E7 RID: 743
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_58>d : IAsyncStateMachine
			{
				// Token: 0x06000EDC RID: 3804 RVA: 0x000733FC File Offset: 0x000715FC
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

				// Token: 0x06000EDD RID: 3805 RVA: 0x0007344C File Offset: 0x0007164C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E6F RID: 3695
				public int <>1__state;

				// Token: 0x04000E70 RID: 3696
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E8 RID: 744
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_62>d : IAsyncStateMachine
			{
				// Token: 0x06000EDE RID: 3806 RVA: 0x0007345C File Offset: 0x0007165C
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

				// Token: 0x06000EDF RID: 3807 RVA: 0x000734AC File Offset: 0x000716AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E71 RID: 3697
				public int <>1__state;

				// Token: 0x04000E72 RID: 3698
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002E9 RID: 745
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_64>d : IAsyncStateMachine
			{
				// Token: 0x06000EE0 RID: 3808 RVA: 0x000734BC File Offset: 0x000716BC
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

				// Token: 0x06000EE1 RID: 3809 RVA: 0x0007350C File Offset: 0x0007170C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E73 RID: 3699
				public int <>1__state;

				// Token: 0x04000E74 RID: 3700
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002EA RID: 746
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_68>d : IAsyncStateMachine
			{
				// Token: 0x06000EE2 RID: 3810 RVA: 0x0007351C File Offset: 0x0007171C
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

				// Token: 0x06000EE3 RID: 3811 RVA: 0x0007356C File Offset: 0x0007176C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E75 RID: 3701
				public int <>1__state;

				// Token: 0x04000E76 RID: 3702
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002EB RID: 747
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_70>d : IAsyncStateMachine
			{
				// Token: 0x06000EE4 RID: 3812 RVA: 0x0007357C File Offset: 0x0007177C
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

				// Token: 0x06000EE5 RID: 3813 RVA: 0x000735CC File Offset: 0x000717CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E77 RID: 3703
				public int <>1__state;

				// Token: 0x04000E78 RID: 3704
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002EC RID: 748
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_74>d : IAsyncStateMachine
			{
				// Token: 0x06000EE6 RID: 3814 RVA: 0x000735DC File Offset: 0x000717DC
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

				// Token: 0x06000EE7 RID: 3815 RVA: 0x0007362C File Offset: 0x0007182C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E79 RID: 3705
				public int <>1__state;

				// Token: 0x04000E7A RID: 3706
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002ED RID: 749
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_76>d : IAsyncStateMachine
			{
				// Token: 0x06000EE8 RID: 3816 RVA: 0x0007363C File Offset: 0x0007183C
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

				// Token: 0x06000EE9 RID: 3817 RVA: 0x0007368C File Offset: 0x0007188C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E7B RID: 3707
				public int <>1__state;

				// Token: 0x04000E7C RID: 3708
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002EE RID: 750
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__24_8>d : IAsyncStateMachine
			{
				// Token: 0x06000EEA RID: 3818 RVA: 0x0007369C File Offset: 0x0007189C
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

				// Token: 0x06000EEB RID: 3819 RVA: 0x000736EC File Offset: 0x000718EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E7D RID: 3709
				public int <>1__state;

				// Token: 0x04000E7E RID: 3710
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000128 RID: 296
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__24 : IAsyncStateMachine
		{
			// Token: 0x060009CC RID: 2508 RVA: 0x00039D8C File Offset: 0x00037F8C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_OpenId_Edit areas_Admin_Views_OpenId_Edit = this.<>4__this;
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
							goto IL_0183;
						}
						areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>OpenId Configuration</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        ");
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "4ce2281505407231f16350b7227f9cce9b1675c8a6d9ddd64f8d7941afc172c98287", new Func<Task>(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_0));
						areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_OpenId_Edit.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_OpenId_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_10.Value;
						areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_OpenId_Edit.__tagHelperAttribute_10);
						awaiter2 = areas_Admin_Views_OpenId_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<ExecuteAsync>d__24>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_018A;
					}
					awaiter = areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_OpenId_Edit.<ExecuteAsync>d__24>(ref awaiter, ref this);
						return;
					}
					IL_0183:
					awaiter.GetResult();
					IL_018A:
					areas_Admin_Views_OpenId_Edit.Write(areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_OpenId_Edit.__tagHelperExecutionContext = areas_Admin_Views_OpenId_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_OpenId_Edit.WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
					areas_Admin_Views_OpenId_Edit.DefineSection("Scripts", new RenderAsyncDelegate(areas_Admin_Views_OpenId_Edit.<ExecuteAsync>b__24_1));
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

			// Token: 0x060009CD RID: 2509 RVA: 0x00039FB4 File Offset: 0x000381B4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000755 RID: 1877
			public int <>1__state;

			// Token: 0x04000756 RID: 1878
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000757 RID: 1879
			public Areas_Admin_Views_OpenId_Edit <>4__this;

			// Token: 0x04000758 RID: 1880
			private TaskAwaiter <>u__1;
		}
	}
}
