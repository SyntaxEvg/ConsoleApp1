using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
	// Token: 0x02000030 RID: 48
	[RazorSourceChecksum("SHA256", "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa5", "/Areas/Admin/Views/AccessToken/Edit.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/AccessToken/Edit.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_AccessToken_Edit : BaseRazorPage<AccessTokenViewModel>
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000091AF File Offset: 0x000073AF
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

		// Token: 0x060001A4 RID: 420 RVA: 0x000091E4 File Offset: 0x000073E4
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>d__55 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>d__55>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00009227 File Offset: 0x00007427
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000922F File Offset: 0x0000742F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00009238 File Offset: 0x00007438
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00009240 File Offset: 0x00007440
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00009249 File Offset: 0x00007449
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00009251 File Offset: 0x00007451
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000925A File Offset: 0x0000745A
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00009262 File Offset: 0x00007462
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000926B File Offset: 0x0000746B
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00009273 File Offset: 0x00007473
		[RazorInject]
		public IHtmlHelper<AccessTokenViewModel> Html { get; private set; }

		// Token: 0x060001B1 RID: 433 RVA: 0x0000966C File Offset: 0x0000786C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_0()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d <<ExecuteAsync>b__55_0>d;
			<<ExecuteAsync>b__55_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_0>d.<>4__this = this;
			<<ExecuteAsync>b__55_0>d.<>1__state = -1;
			<<ExecuteAsync>b__55_0>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref <<ExecuteAsync>b__55_0>d);
			return <<ExecuteAsync>b__55_0>d.<>t__builder.Task;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000096B0 File Offset: 0x000078B0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_46()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_46>d <<ExecuteAsync>b__55_46>d;
			<<ExecuteAsync>b__55_46>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_46>d.<>4__this = this;
			<<ExecuteAsync>b__55_46>d.<>1__state = -1;
			<<ExecuteAsync>b__55_46>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_46>d>(ref <<ExecuteAsync>b__55_46>d);
			return <<ExecuteAsync>b__55_46>d.<>t__builder.Task;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000096F4 File Offset: 0x000078F4
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_61()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_61>d <<ExecuteAsync>b__55_61>d;
			<<ExecuteAsync>b__55_61>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_61>d.<>4__this = this;
			<<ExecuteAsync>b__55_61>d.<>1__state = -1;
			<<ExecuteAsync>b__55_61>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_61>d>(ref <<ExecuteAsync>b__55_61>d);
			return <<ExecuteAsync>b__55_61>d.<>t__builder.Task;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009738 File Offset: 0x00007938
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_48()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_48>d <<ExecuteAsync>b__55_48>d;
			<<ExecuteAsync>b__55_48>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_48>d.<>4__this = this;
			<<ExecuteAsync>b__55_48>d.<>1__state = -1;
			<<ExecuteAsync>b__55_48>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_48>d>(ref <<ExecuteAsync>b__55_48>d);
			return <<ExecuteAsync>b__55_48>d.<>t__builder.Task;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000977C File Offset: 0x0000797C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_50()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_50>d <<ExecuteAsync>b__55_50>d;
			<<ExecuteAsync>b__55_50>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_50>d.<>4__this = this;
			<<ExecuteAsync>b__55_50>d.<>1__state = -1;
			<<ExecuteAsync>b__55_50>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_50>d>(ref <<ExecuteAsync>b__55_50>d);
			return <<ExecuteAsync>b__55_50>d.<>t__builder.Task;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000097C0 File Offset: 0x000079C0
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_1()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_1>d <<ExecuteAsync>b__55_1>d;
			<<ExecuteAsync>b__55_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_1>d.<>4__this = this;
			<<ExecuteAsync>b__55_1>d.<>1__state = -1;
			<<ExecuteAsync>b__55_1>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_1>d>(ref <<ExecuteAsync>b__55_1>d);
			return <<ExecuteAsync>b__55_1>d.<>t__builder.Task;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009804 File Offset: 0x00007A04
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_2()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d <<ExecuteAsync>b__55_2>d;
			<<ExecuteAsync>b__55_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_2>d.<>4__this = this;
			<<ExecuteAsync>b__55_2>d.<>1__state = -1;
			<<ExecuteAsync>b__55_2>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref <<ExecuteAsync>b__55_2>d);
			return <<ExecuteAsync>b__55_2>d.<>t__builder.Task;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009848 File Offset: 0x00007A48
		[CompilerGenerated]
		private Task <ExecuteAsync>b__55_66()
		{
			Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_66>d <<ExecuteAsync>b__55_66>d;
			<<ExecuteAsync>b__55_66>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__55_66>d.<>4__this = this;
			<<ExecuteAsync>b__55_66>d.<>1__state = -1;
			<<ExecuteAsync>b__55_66>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_66>d>(ref <<ExecuteAsync>b__55_66>d);
			return <<ExecuteAsync>b__55_66>d.<>t__builder.Task;
		}

		// Token: 0x0400011B RID: 283
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400011C RID: 284
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400011D RID: 285
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("class", new HtmlString("form-control col-6"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400011E RID: 286
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("id", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400011F RID: 287
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("name", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000120 RID: 288
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000121 RID: 289
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000122 RID: 290
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000123 RID: 291
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("onfocus", new HtmlString("this.removeAttribute('readonly');"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000124 RID: 292
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("id", new HtmlString("password_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000125 RID: 293
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("name", new HtmlString("password_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000126 RID: 294
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("id", new HtmlString("currentAdminPassword_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000127 RID: 295
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("name", new HtmlString("currentAdminPassword_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000128 RID: 296
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("type", "radio", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000129 RID: 297
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("class", new HtmlString("form-check-input"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012A RID: 298
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("value", "Y", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012B RID: 299
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("id", new HtmlString("isAdministratorYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012C RID: 300
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("data-bs-toggle", new HtmlString("collapse"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012D RID: 301
		private static readonly TagHelperAttribute __tagHelperAttribute_18 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012E RID: 302
		private static readonly TagHelperAttribute __tagHelperAttribute_19 = new TagHelperAttribute("value", "N", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400012F RID: 303
		private static readonly TagHelperAttribute __tagHelperAttribute_20 = new TagHelperAttribute("id", new HtmlString("isAdministratorNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000130 RID: 304
		private static readonly TagHelperAttribute __tagHelperAttribute_21 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000131 RID: 305
		private static readonly TagHelperAttribute __tagHelperAttribute_22 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000132 RID: 306
		private static readonly TagHelperAttribute __tagHelperAttribute_23 = new TagHelperAttribute("class", new HtmlString("default"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000133 RID: 307
		private static readonly TagHelperAttribute __tagHelperAttribute_24 = new TagHelperAttribute("value", "true", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000134 RID: 308
		private static readonly TagHelperAttribute __tagHelperAttribute_25 = new TagHelperAttribute("id", new HtmlString("canOpenSessionYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000135 RID: 309
		private static readonly TagHelperAttribute __tagHelperAttribute_26 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000136 RID: 310
		private static readonly TagHelperAttribute __tagHelperAttribute_27 = new TagHelperAttribute("id", new HtmlString("canOpenSessionNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000137 RID: 311
		private static readonly TagHelperAttribute __tagHelperAttribute_28 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000138 RID: 312
		private static readonly TagHelperAttribute __tagHelperAttribute_29 = new TagHelperAttribute("autocomplete", new HtmlString("on"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000139 RID: 313
		private static readonly TagHelperAttribute __tagHelperAttribute_30 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013A RID: 314
		private static readonly TagHelperAttribute __tagHelperAttribute_31 = new TagHelperAttribute("class", new HtmlString("select2_single form-select col-6"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013B RID: 315
		private static readonly TagHelperAttribute __tagHelperAttribute_32 = new TagHelperAttribute("id", new HtmlString("Repositories"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013C RID: 316
		private static readonly TagHelperAttribute __tagHelperAttribute_33 = new TagHelperAttribute("name", "Repositories", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013D RID: 317
		private static readonly TagHelperAttribute __tagHelperAttribute_34 = new TagHelperAttribute("id", new HtmlString("Profiles"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013E RID: 318
		private static readonly TagHelperAttribute __tagHelperAttribute_35 = new TagHelperAttribute("name", "Profiles", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400013F RID: 319
		private static readonly TagHelperAttribute __tagHelperAttribute_36 = new TagHelperAttribute("class", new HtmlString("form-horizontal form-label-left"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000140 RID: 320
		private static readonly TagHelperAttribute __tagHelperAttribute_37 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000141 RID: 321
		private static readonly TagHelperAttribute __tagHelperAttribute_38 = new TagHelperAttribute("src", "/uas/js/userAccount.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000142 RID: 322
		private static readonly TagHelperAttribute __tagHelperAttribute_39 = new TagHelperAttribute("src", "/uas/js/apiKey.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000143 RID: 323
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000144 RID: 324
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000145 RID: 325
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000146 RID: 326
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000147 RID: 327
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000148 RID: 328
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000149 RID: 329
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x0400014A RID: 330
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x0400014B RID: 331
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x0400014C RID: 332
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x0400014D RID: 333
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x0400014E RID: 334
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x0400014F RID: 335
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x020000EA RID: 234
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_0>d : IAsyncStateMachine
		{
			// Token: 0x060008DA RID: 2266 RVA: 0x00021784 File Offset: 0x0001F984
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
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
					ParameterExpression parameterExpression;
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
					switch (num)
					{
					case 0:
						awaiter = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						break;
					case 1:
						awaiter2 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_02F8;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0481;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_04F6;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_067F;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_06F4;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_087D;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_08F2;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0A7B;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0AF1;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0C7B;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0CF1;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0E7B;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0EF1;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_101D;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1093;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1237;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_12AD;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_143D;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_14B3;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_17D2;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1848;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_19D8;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1A4E;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1BF8;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1C6E;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1DFE;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1E74;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2018;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_208E;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_21FE;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2274;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_247C;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_24F2;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_26FA;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2770;
					case 36:
					case 37:
					case 38:
					case 39:
					case 40:
					case 41:
					case 42:
					case 43:
					{
						IL_289A:
						try
						{
							if (num - 36 > 7)
							{
								goto IL_342D;
							}
							IL_28E4:
							try
							{
								TaskAwaiter awaiter37;
								TaskAwaiter awaiter38;
								TaskAwaiter awaiter39;
								TaskAwaiter awaiter40;
								TaskAwaiter awaiter41;
								TaskAwaiter awaiter42;
								TaskAwaiter awaiter43;
								TaskAwaiter awaiter44;
								switch (num)
								{
								case 36:
									awaiter37 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									break;
								case 37:
									awaiter38 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2BFB;
								case 38:
									awaiter39 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2E1B;
								case 39:
									awaiter40 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2E91;
								case 40:
									awaiter41 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_30B1;
								case 41:
									awaiter42 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_3127;
								case 42:
									awaiter43 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_3347;
								case 43:
									awaiter44 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_33BD;
								default:
									goto IL_33F1;
								}
								IL_2B85:
								awaiter37.GetResult();
								if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2C02;
								}
								awaiter38 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter38.IsCompleted)
								{
									num = (this.<>1__state = 37);
									this.<>u__1 = awaiter38;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter38, ref this);
									return;
								}
								IL_2BFB:
								awaiter38.GetResult();
								IL_2C02:
								areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa563823", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_55));
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData = areas_Admin_Views_AccessToken_Edit.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<AccessTokenViewModel, string>(viewData, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Edit, typeof(Areas_Admin_Views_AccessToken_Edit)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0)), fieldof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0.ix)) }), methodof(RoleViewModel.get_Name())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter39 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter39.IsCompleted)
								{
									num = (this.<>1__state = 38);
									this.<>u__1 = awaiter39;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter39, ref this);
									return;
								}
								IL_2E1B:
								awaiter39.GetResult();
								if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2E98;
								}
								awaiter40 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter40.IsCompleted)
								{
									num = (this.<>1__state = 39);
									this.<>u__1 = awaiter40;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter40, ref this);
									return;
								}
								IL_2E91:
								awaiter40.GetResult();
								IL_2E98:
								areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa565663", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_57));
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData2 = areas_Admin_Views_AccessToken_Edit.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<AccessTokenViewModel, string>(viewData2, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Edit, typeof(Areas_Admin_Views_AccessToken_Edit)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0)), fieldof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0.ix)) }), methodof(RoleViewModel.get_Title())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter41 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter41.IsCompleted)
								{
									num = (this.<>1__state = 40);
									this.<>u__1 = awaiter41;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter41, ref this);
									return;
								}
								IL_30B1:
								awaiter41.GetResult();
								if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_312E;
								}
								awaiter42 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter42.IsCompleted)
								{
									num = (this.<>1__state = 41);
									this.<>u__1 = awaiter42;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter42, ref this);
									return;
								}
								IL_3127:
								awaiter42.GetResult();
								IL_312E:
								areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa567504", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_59));
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData3 = areas_Admin_Views_AccessToken_Edit.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<AccessTokenViewModel, string>(viewData3, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Edit, typeof(Areas_Admin_Views_AccessToken_Edit)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0)), fieldof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0.ix)) }), methodof(RoleViewModel.get_ModuleId())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter43 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter43.IsCompleted)
								{
									num = (this.<>1__state = 42);
									this.<>u__1 = awaiter43;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter43, ref this);
									return;
								}
								IL_3347:
								awaiter43.GetResult();
								if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_33C4;
								}
								awaiter44 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter44.IsCompleted)
								{
									num = (this.<>1__state = 43);
									this.<>u__1 = awaiter44;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter44, ref this);
									return;
								}
								IL_33BD:
								awaiter44.GetResult();
								IL_33C4:
								areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                                        <span class=\"slider round\"></span>\r\n                                                                    </label>\r\n                                                                </div>\r\n");
								IL_33F1:
								if (this.<>7__wrap2.MoveNext())
								{
									RoleViewModel role = this.<>7__wrap2.Current;
									int ix = this.<>8__1.ix;
									this.<>8__1.ix = ix + 1;
									areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                                <div class=\"col-4\">\r\n                                                                    ");
									areas_Admin_Views_AccessToken_Edit.Write(role.Title);
									areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                                    <label class=\"switch mt-1 me-1\">\r\n                                                                        ");
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa561677", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_53));
									areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
									areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_22.Value;
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_22);
									InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
									IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
									ViewDataDictionary<AccessTokenViewModel> viewData4 = areas_Admin_Views_AccessToken_Edit.ViewData;
									parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
									_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider4.CreateModelExpression<AccessTokenViewModel, bool>(viewData4, Expression.Lambda<Func<AccessTokenViewModel, bool>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Edit, typeof(Areas_Admin_Views_AccessToken_Edit)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0)), fieldof(Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0.ix)) }), methodof(RoleViewModel.get_IsSelected())), new ParameterExpression[] { parameterExpression }));
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_23);
									areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_24.Value;
									areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_24);
									awaiter37 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
									if (!awaiter37.IsCompleted)
									{
										num = (this.<>1__state = 36);
										this.<>u__1 = awaiter37;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter37, ref this);
										return;
									}
									goto IL_2B85;
								}
							}
							finally
							{
								if (num < 0 && this.<>7__wrap2 != null)
								{
									this.<>7__wrap2.Dispose();
								}
							}
							this.<>7__wrap2 = null;
							areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                        </div>\r\n                                                    </fieldset>\r\n");
							IL_342D:
							if (this.<>7__wrap1.MoveNext())
							{
								IGrouping<string, RoleViewModel> rolesByModule = this.<>7__wrap1.Current;
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                    <fieldset class=\"border mb-2 p-2\">\r\n                                                        <legend class=\"w-auto px-2 text-secondary h6\">");
								areas_Admin_Views_AccessToken_Edit.Write(rolesByModule.Key);
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("</legend>\r\n                                                        <div class=\"row\">\r\n");
								this.<>7__wrap2 = rolesByModule.GetEnumerator();
								goto IL_28E4;
							}
						}
						finally
						{
							if (num < 0 && this.<>7__wrap1 != null)
							{
								this.<>7__wrap1.Dispose();
							}
						}
						this.<>7__wrap1 = null;
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!--End roles -->\r\n");
						if (!(areas_Admin_Views_AccessToken_Edit.Model.TokenName != "admin"))
						{
							goto IL_4AF3;
						}
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("                            <!--Open Session -->\r\n                            <div class=\"form-group mt-3\">\r\n                                <label>Hopex session</label>\r\n                                <div class=\"form-check ms-3\">\r\n                                    ");
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa571114", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_38));
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
						ViewDataDictionary<AccessTokenViewModel> viewData5 = areas_Admin_Views_AccessToken_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider5.CreateModelExpression<AccessTokenViewModel, string>(viewData5, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_14);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_19.Value;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_19);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_25);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_17);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_26);
						awaiter45 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter45.IsCompleted)
						{
							num = (this.<>1__state = 44);
							this.<>u__1 = awaiter45;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter45, ref this);
							return;
						}
						goto IL_364E;
					}
					case 44:
						awaiter45 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_364E;
					case 45:
						awaiter46 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_36C4;
					case 46:
						awaiter47 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_38B8;
					case 47:
						awaiter48 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_392E;
					case 48:
						awaiter49 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3B88;
					case 49:
						awaiter50 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3BFE;
					case 50:
						awaiter51 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3D6E;
					case 51:
						awaiter52 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3DE4;
					case 52:
						awaiter53 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3F73;
					case 53:
						awaiter54 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3FE9;
					case 54:
						awaiter55 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_4180;
					case 55:
						awaiter56 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_41F6;
					case 56:
						awaiter57 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_438D;
					case 57:
						awaiter58 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_4403;
					case 58:
					case 59:
						IL_444D:
						try
						{
							TaskAwaiter awaiter59;
							TaskAwaiter awaiter60;
							if (num != 58)
							{
								if (num != 59)
								{
									goto IL_4756;
								}
								awaiter59 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								num = (this.<>1__state = -1);
								goto IL_46FA;
							}
							else
							{
								awaiter60 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								num = (this.<>1__state = -1);
							}
							IL_4684:
							awaiter60.GetResult();
							if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
							{
								goto IL_4701;
							}
							awaiter59 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
							if (!awaiter59.IsCompleted)
							{
								num = (this.<>1__state = 59);
								this.<>u__1 = awaiter59;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter59, ref this);
								return;
							}
							IL_46FA:
							awaiter59.GetResult();
							IL_4701:
							areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
							areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n");
							areas_Admin_Views_AccessToken_Edit.Write(this.<sessionMode>5__5.Value);
							areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                        <br />\r\n");
							this.<sessionMode>5__5 = default(KeyValuePair<string, string>);
							IL_4756:
							if (this.<>7__wrap3.MoveNext())
							{
								this.<sessionMode>5__5 = this.<>7__wrap3.Current;
								areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                        ");
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa591048", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_62));
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
								areas_Admin_Views_AccessToken_Edit.BeginAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext, "id", 2, HtmlAttributeValueStyle.DoubleQuotes);
								areas_Admin_Views_AccessToken_Edit.AddHtmlAttributeValue("", 13758, "ConnectionMode_", 13758, 15, true);
								areas_Admin_Views_AccessToken_Edit.AddHtmlAttributeValue("", 13773, this.<sessionMode>5__5.Key, 13773, 16, false);
								areas_Admin_Views_AccessToken_Edit.EndAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData6 = areas_Admin_Views_AccessToken_Edit.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider6.CreateModelExpression<AccessTokenViewModel, string>(viewData6, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_SessionMode())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
								areas_Admin_Views_AccessToken_Edit.WriteLiteral(this.<sessionMode>5__5.Key);
								areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
								areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer;
								areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter60 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter60.IsCompleted)
								{
									num = (this.<>1__state = 58);
									this.<>u__1 = awaiter60;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter60, ref this);
									return;
								}
								goto IL_4684;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)this.<>7__wrap3).Dispose();
							}
						}
						this.<>7__wrap3 = default(Dictionary<string, string>.Enumerator);
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                </p>\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\">\r\n                                                <label for=\"ConnectionMode\" class=\"control-label\">Connection Mode</label>\r\n                                                <p class=\"ms-4\">\r\n");
						this.<>7__wrap3 = areas_Admin_Views_AccessToken_Edit.Model.ConnectionModes.GetEnumerator();
						goto IL_47AB;
					case 60:
					case 61:
						goto IL_47AB;
					default:
					{
						this.<>8__1 = new Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0();
						this.<>8__1.<>4__this = areas_Admin_Views_AccessToken_Edit;
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa519021", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_3));
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
						ViewDataDictionary<AccessTokenViewModel> viewData7 = areas_Admin_Views_AccessToken_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider7.CreateModelExpression<AccessTokenViewModel, string>(viewData7, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_AssignableElementId())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02FF;
					}
					awaiter2 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_02F8:
					awaiter2.GetResult();
					IL_02FF:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa520811", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_5));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData8 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider8.CreateModelExpression<AccessTokenViewModel, string>(viewData8, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Login())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter3 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (this.<>1__state = 2);
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0481:
					awaiter3.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04FD;
					}
					awaiter4 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (this.<>1__state = 3);
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_04F6:
					awaiter4.GetResult();
					IL_04FD:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa522587", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_7));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData9 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider9.CreateModelExpression<AccessTokenViewModel, string>(viewData9, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter5 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (this.<>1__state = 4);
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_067F:
					awaiter5.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06FB;
					}
					awaiter6 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						num = (this.<>1__state = 5);
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_06F4:
					awaiter6.GetResult();
					IL_06FB:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa524364", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_9));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData10 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider10.CreateModelExpression<AccessTokenViewModel, string>(viewData10, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_RepositoryId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter7 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						num = (this.<>1__state = 6);
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_087D:
					awaiter7.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08F9;
					}
					awaiter8 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						num = (this.<>1__state = 7);
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_08F2:
					awaiter8.GetResult();
					IL_08F9:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa526147", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_11));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData11 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11.For = modelExpressionProvider11.CreateModelExpression<AccessTokenViewModel, string>(viewData11, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ProfileId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter9 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						num = (this.<>1__state = 8);
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A7B:
					awaiter9.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0AF8;
					}
					awaiter10 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						num = (this.<>1__state = 9);
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0AF1:
					awaiter10.GetResult();
					IL_0AF8:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa527927", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_13));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData12 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12.For = modelExpressionProvider12.CreateModelExpression<AccessTokenViewModel, string>(viewData12, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_DataLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter11 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						num = (this.<>1__state = 10);
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0C7B:
					awaiter11.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0CF8;
					}
					awaiter12 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						num = (this.<>1__state = 11);
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0CF1:
					awaiter12.GetResult();
					IL_0CF8:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa529712", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_15));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData13 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13.For = modelExpressionProvider13.CreateModelExpression<AccessTokenViewModel, string>(viewData13, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_GuiLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_0);
					awaiter13 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						num = (this.<>1__state = 12);
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0E7B:
					awaiter13.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0EF8;
					}
					awaiter14 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						num = (this.<>1__state = 13);
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0EF1:
					awaiter14.GetResult();
					IL_0EF8:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n\r\n                        ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa531500", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_17));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationSummaryTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					awaiter15 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						num = (this.<>1__state = 14);
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_101D:
					awaiter15.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_109A;
					}
					awaiter16 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						num = (this.<>1__state = 15);
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_1093:
					awaiter16.GetResult();
					IL_109A:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-6\">\r\n                                <label for=\"TokenName\" class=\"control-label\">User Name<span class=\"required\"> *</span></label>\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa533489", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_18));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData14 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14.For = modelExpressionProvider14.CreateModelExpression<AccessTokenViewModel, string>(viewData14, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute("readonly", areas_Admin_Views_AccessToken_Edit.Html.Raw(areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					awaiter17 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						num = (this.<>1__state = 16);
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_1237:
					awaiter17.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_12B4;
					}
					awaiter18 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						num = (this.<>1__state = 17);
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_12AD:
					awaiter18.GetResult();
					IL_12B4:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa535471", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_20));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData15 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider15.CreateModelExpression<AccessTokenViewModel, string>(viewData15, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_3);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_4);
					awaiter19 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						num = (this.<>1__state = 18);
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_143D:
					awaiter19.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_14BA;
					}
					awaiter20 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						num = (this.<>1__state = 19);
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_14B3:
					awaiter20.GetResult();
					IL_14BA:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Password\" class=\"control-label\">Password<span class=\"required\"> *</span></label>\r\n");
					string content = string.Concat(new string[]
					{
						"The password must:<br/>\r\n                            <ul>\r\n                            <li>include at least ",
						areas_Admin_Views_AccessToken_Edit.Model.Settings.RequiredLength.ToString(),
						" characters",
						areas_Admin_Views_AccessToken_Edit.Model.Settings.RequireUppercase ? ", one uppercase" : "",
						areas_Admin_Views_AccessToken_Edit.Model.Settings.RequireLowercase ? ", one lowercase" : "",
						areas_Admin_Views_AccessToken_Edit.Model.Settings.RequireDigit ? ", one digit" : "",
						areas_Admin_Views_AccessToken_Edit.Model.Settings.RequireNonAlphanumeric ? ", one special character" : "",
						"</li>\r\n                            <li>not use any sequence of characters (e.g; 12345, qwert) nor contextual words (e.g.: hopex, mega)</li>\r\n                            <li>be complex enough to meet your enterprise security requirements</li>\r\n                            </ul>\r\n                            "
					});
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("                            <span data-bs-toggle=\"popover\" data-bs-html=\"true\" data-bs-trigger=\"hover\" title=\"Password policy\" data-bs-content=\"");
					areas_Admin_Views_AccessToken_Edit.Write(content);
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\"><i class=\"fa fa-question-circle\" aria-hidden=\"true\"></i></span>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-6 pe-0\">\r\n                                    ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa539297", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_22));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData16 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15.For = modelExpressionProvider16.CreateModelExpression<AccessTokenViewModel, string>(viewData16, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_5);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_6);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_7.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_7);
					areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute("readonly", areas_Admin_Views_AccessToken_Edit.Html.Raw(areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_8);
					areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral(areas_Admin_Views_AccessToken_Edit.Model.Password);
					areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter21 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						num = (this.<>1__state = 20);
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_17D2:
					awaiter21.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_184F;
					}
					awaiter22 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						num = (this.<>1__state = 21);
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1848:
					awaiter22.GetResult();
					IL_184F:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <button class=\"btn btn-primary\" id=\"generatePassword\" type=\"button\">Generate</button>\r\n                                </div>\r\n                            </div>\r\n                            <label>\r\n                                <strong>User will be prompted to change the password at next login. This temporary password will expire in 2 days</strong><br />\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa542859", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_24));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData17 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider17.CreateModelExpression<AccessTokenViewModel, string>(viewData17, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_9);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_10);
					awaiter23 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						num = (this.<>1__state = 22);
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_19D8:
					awaiter23.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1A55;
					}
					awaiter24 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						num = (this.<>1__state = 23);
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_1A4E:
					awaiter24.GetResult();
					IL_1A55:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"CurrentAdminPassword\" class=\"control-label\">Your current password<span class=\"required\"> *</span></label>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"form-group col-6\">\r\n                                    ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa545168", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_26));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider18 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData18 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16.For = modelExpressionProvider18.CreateModelExpression<AccessTokenViewModel, string>(viewData18, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CurrentAdminPassword())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_5);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_6);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_7.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_7);
					awaiter25 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						num = (this.<>1__state = 24);
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_1BF8:
					awaiter25.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1C75;
					}
					awaiter26 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						num = (this.<>1__state = 25);
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1C6E:
					awaiter26.GetResult();
					IL_1C75:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <label>\r\n                                <small>In order to create or edit an user account you must enter your password</small><br />\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa547379", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_28));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider19 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData19 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider19.CreateModelExpression<AccessTokenViewModel, string>(viewData19, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CurrentAdminPassword())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_11);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_12);
					awaiter27 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						num = (this.<>1__state = 26);
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1DFE:
					awaiter27.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1E7B;
					}
					awaiter28 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						num = (this.<>1__state = 27);
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1E74:
					awaiter28.GetResult();
					IL_1E7B:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-6\">\r\n                                <label for=\"Description\" class=\"control-label\">Description</label>\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa549579", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_30));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider20 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData20 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17.For = modelExpressionProvider20.CreateModelExpression<AccessTokenViewModel, string>(viewData20, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_AccessToken_Edit.Html.Raw(areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_2);
					awaiter29 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						num = (this.<>1__state = 28);
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_2018:
					awaiter29.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2095;
					}
					awaiter30 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						num = (this.<>1__state = 29);
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_208E:
					awaiter30.GetResult();
					IL_2095:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa551562", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_32));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider21 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData21 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider21.CreateModelExpression<AccessTokenViewModel, string>(viewData21, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					awaiter31 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						num = (this.<>1__state = 30);
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_21FE:
					awaiter31.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_227B;
					}
					awaiter32 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						num = (this.<>1__state = 31);
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_2274:
					awaiter32.GetResult();
					IL_227B:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <!--Roles -->\r\n                        <div class=\"form-group mt-3\">\r\n                            <label>Roles</label>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa553575", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_34));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider22 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData22 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18.For = modelExpressionProvider22.CreateModelExpression<AccessTokenViewModel, string>(viewData22, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_14);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_15.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_15);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_16);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_17);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_18);
					awaiter33 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						num = (this.<>1__state = 32);
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_247C:
					awaiter33.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_24F9;
					}
					awaiter34 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						num = (this.<>1__state = 33);
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_24F2:
					awaiter34.GetResult();
					IL_24F9:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                <label for=\"isAdministratorYes\" class=\"form-check-label\">Administrator</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa556159", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_36));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider23 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData23 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19.For = modelExpressionProvider23.CreateModelExpression<AccessTokenViewModel, string>(viewData23, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_14);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_19.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_19);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_20);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_17);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_21);
					awaiter35 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						num = (this.<>1__state = 34);
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_26FA:
					awaiter35.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2777;
					}
					awaiter36 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						num = (this.<>1__state = 35);
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_2770:
					awaiter36.GetResult();
					IL_2777:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                <label for=\"isAdministratorNo\" class=\"form-check-label\">Custom</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseRoles\"");
					areas_Admin_Views_AccessToken_Edit.BeginWriteAttribute("class", " class=\"", 6568, "\"", 6659, 3);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue("", 6576, "panel-collapse", 6576, 14, true);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue(" ", 6590, "collapse", 6591, 9, true);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue(" ", 6599, (areas_Admin_Views_AccessToken_Edit.Model.Roles.IsAdministrator == "N") ? "show" : string.Empty, 6600, 59, false);
					areas_Admin_Views_AccessToken_Edit.EndWriteAttribute();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral(">\r\n                                        <div class=\"form-group mt-1 col-6\">\r\n");
					this.<>8__1.ix = -1;
					this.<>7__wrap1 = areas_Admin_Views_AccessToken_Edit.Model.Roles.Items.GroupBy(new Func<RoleViewModel, string>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_52)).GetEnumerator();
					goto IL_289A;
					IL_364E:
					awaiter45.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_36CB;
					}
					awaiter46 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter46.IsCompleted)
					{
						num = (this.<>1__state = 45);
						this.<>u__1 = awaiter46;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter46, ref this);
						return;
					}
					IL_36C4:
					awaiter46.GetResult();
					IL_36CB:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                    <label for=\"canOpenSessionYes\" class=\"form-check-label\">No session</label>\r\n                                </div>\r\n                                <div class=\"form-check ms-3\">\r\n                                    ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa573704", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_40));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper20 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider24 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData24 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper20.For = modelExpressionProvider24.CreateModelExpression<AccessTokenViewModel, string>(viewData24, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_14);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_15.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_15);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_27);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_17);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_28);
					awaiter47 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter47.IsCompleted)
					{
						num = (this.<>1__state = 46);
						this.<>u__1 = awaiter47;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter47, ref this);
						return;
					}
					IL_38B8:
					awaiter47.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3935;
					}
					awaiter48 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter48.IsCompleted)
					{
						num = (this.<>1__state = 47);
						this.<>u__1 = awaiter48;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter48, ref this);
						return;
					}
					IL_392E:
					awaiter48.GetResult();
					IL_3935:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                    <label for=\"canOpenSessionNo\" class=\"form-check-label\">Open session</label>\r\n                                </div>\r\n                                <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                    <div class=\"panel panel-default\">\r\n                                        <div id=\"collapseSession\"");
					areas_Admin_Views_AccessToken_Edit.BeginWriteAttribute("class", " class=\"", 10596, "\"", 10680, 3);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue("", 10604, "panel-collapse", 10604, 14, true);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue(" ", 10618, "collapse", 10619, 9, true);
					areas_Admin_Views_AccessToken_Edit.WriteAttributeValue(" ", 10627, (areas_Admin_Views_AccessToken_Edit.Model.CanOpenSession == "Y") ? "show" : string.Empty, 10628, 52, false);
					areas_Admin_Views_AccessToken_Edit.EndWriteAttribute();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral(">\r\n                                            <div class=\"form-group\">\r\n                                                <label for=\"UserName\" class=\"control-label\">HOPEX login<span class=\"required\"> *</span></label>\r\n                                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa577318", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_42));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper21 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider25 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData25 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper21.For = modelExpressionProvider25.CreateModelExpression<AccessTokenViewModel, string>(viewData25, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_AccessToken_Edit.Html.Raw(areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_2);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_29);
					awaiter49 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter49.IsCompleted)
					{
						num = (this.<>1__state = 48);
						this.<>u__1 = awaiter49;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter49, ref this);
						return;
					}
					IL_3B88:
					awaiter49.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3C05;
					}
					awaiter50 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter50.IsCompleted)
					{
						num = (this.<>1__state = 49);
						this.<>u__1 = awaiter50;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter50, ref this);
						return;
					}
					IL_3BFE:
					awaiter50.GetResult();
					IL_3C05:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa579403", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_44));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider26 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData26 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider26.CreateModelExpression<AccessTokenViewModel, string>(viewData26, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_1);
					awaiter51 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter51.IsCompleted)
					{
						num = (this.<>1__state = 50);
						this.<>u__1 = awaiter51;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter51, ref this);
						return;
					}
					IL_3D6E:
					awaiter51.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3DEB;
					}
					awaiter52 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter52.IsCompleted)
					{
						num = (this.<>1__state = 51);
						this.<>u__1 = awaiter52;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter52, ref this);
						return;
					}
					IL_3DE4:
					awaiter52.GetResult();
					IL_3DEB:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\">\r\n                                                <label for=\"EnvironmentId\" class=\"control-label\">EnvironmentId<span class=\"required\"> *</span></label>\r\n                                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa581437", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_46));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider27 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData27 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider27.CreateModelExpression<AccessTokenViewModel, string>(viewData27, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = areas_Admin_Views_AccessToken_Edit.Model.Environments;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_31);
					awaiter53 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter53.IsCompleted)
					{
						num = (this.<>1__state = 52);
						this.<>u__1 = awaiter53;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter53, ref this);
						return;
					}
					IL_3F73:
					awaiter53.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3FF0;
					}
					awaiter54 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter54.IsCompleted)
					{
						num = (this.<>1__state = 53);
						this.<>u__1 = awaiter54;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter54, ref this);
						return;
					}
					IL_3FE9:
					awaiter54.GetResult();
					IL_3FF0:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\" id=\"PersonGroups-group\">\r\n                                                <label for=\"PersonGroups\" class=\"control-label\">Person<span class=\"required\"> *</span></label>\r\n                                                <select id=\"PersonGroups\" class=\"select2_single form-select col-6\">\r\n                                                </select>\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\" id=\"Repositories-group\">\r\n                                                <label for=\"Repositories\" class=\"control-label\">Repositories<span class=\"required\"> *</span></label>\r\n                                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa585892", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_48));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper2 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider28 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData28 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper2.For = modelExpressionProvider28.CreateModelExpression<AccessTokenViewModel, string>(viewData28, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_RepositoryId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_32);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_33.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_33);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_31);
					awaiter55 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter55.IsCompleted)
					{
						num = (this.<>1__state = 54);
						this.<>u__1 = awaiter55;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter55, ref this);
						return;
					}
					IL_4180:
					awaiter55.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_41FD;
					}
					awaiter56 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter56.IsCompleted)
					{
						num = (this.<>1__state = 55);
						this.<>u__1 = awaiter56;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter56, ref this);
						return;
					}
					IL_41F6:
					awaiter56.GetResult();
					IL_41FD:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\" id=\"Profiles-group\">\r\n                                                <label for=\"Profiles\" class=\"control-label\">Profiles<span class=\"required\"> *</span></label>\r\n                                                ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa588268", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_50));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper3 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider29 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData29 = areas_Admin_Views_AccessToken_Edit.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper3.For = modelExpressionProvider29.CreateModelExpression<AccessTokenViewModel, string>(viewData29, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ProfileId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_34);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_35.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_35);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_31);
					awaiter57 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter57.IsCompleted)
					{
						num = (this.<>1__state = 56);
						this.<>u__1 = awaiter57;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter57, ref this);
						return;
					}
					IL_438D:
					awaiter57.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_440A;
					}
					awaiter58 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter58.IsCompleted)
					{
						num = (this.<>1__state = 57);
						this.<>u__1 = awaiter58;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter58, ref this);
						return;
					}
					IL_4403:
					awaiter58.GetResult();
					IL_440A:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group\">\r\n                                                <label for=\"SessionMode\" class=\"control-label\">Session Mode</label>\r\n                                                <p class=\"ms-4\">\r\n");
					this.<>7__wrap3 = areas_Admin_Views_AccessToken_Edit.Model.SessionModes.GetEnumerator();
					goto IL_444D;
					IL_47AB:
					try
					{
						TaskAwaiter awaiter61;
						TaskAwaiter awaiter62;
						if (num != 60)
						{
							if (num != 61)
							{
								goto IL_4AB4;
							}
							awaiter61 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_4A58;
						}
						else
						{
							awaiter62 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
						}
						IL_49E2:
						awaiter62.GetResult();
						if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_4A5F;
						}
						awaiter61 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter61.IsCompleted)
						{
							num = (this.<>1__state = 61);
							this.<>u__1 = awaiter61;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter61, ref this);
							return;
						}
						IL_4A58:
						awaiter61.GetResult();
						IL_4A5F:
						areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n");
						areas_Admin_Views_AccessToken_Edit.Write(this.<sessionMode>5__5.Value);
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                        <br />\r\n");
						this.<sessionMode>5__5 = default(KeyValuePair<string, string>);
						IL_4AB4:
						if (this.<>7__wrap3.MoveNext())
						{
							this.<sessionMode>5__5 = this.<>7__wrap3.Current;
							areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                        ");
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa595540", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_64));
							areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<InputTagHelper>();
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
							areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13.Value;
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_13);
							areas_Admin_Views_AccessToken_Edit.BeginAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext, "id", 2, HtmlAttributeValueStyle.DoubleQuotes);
							areas_Admin_Views_AccessToken_Edit.AddHtmlAttributeValue("", 14650, "ConnectionMode_", 14650, 15, true);
							areas_Admin_Views_AccessToken_Edit.AddHtmlAttributeValue("", 14665, this.<sessionMode>5__5.Key, 14665, 19, false);
							areas_Admin_Views_AccessToken_Edit.EndAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext);
							InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper22 = areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
							IModelExpressionProvider modelExpressionProvider30 = areas_Admin_Views_AccessToken_Edit.ModelExpressionProvider;
							ViewDataDictionary<AccessTokenViewModel> viewData30 = areas_Admin_Views_AccessToken_Edit.ViewData;
							parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper22.For = modelExpressionProvider30.CreateModelExpression<AccessTokenViewModel, string>(viewData30, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ConnectionMode())), new ParameterExpression[] { parameterExpression }));
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
							areas_Admin_Views_AccessToken_Edit.WriteLiteral(this.<sessionMode>5__5.Key);
							areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
							areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer;
							areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter62 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter62.IsCompleted)
							{
								num = (this.<>1__state = 60);
								this.<>u__1 = awaiter62;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_0>d>(ref awaiter62, ref this);
								return;
							}
							goto IL_49E2;
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)this.<>7__wrap3).Dispose();
						}
					}
					this.<>7__wrap3 = default(Dictionary<string, string>.Enumerator);
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("                                                </p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
					IL_4AF3:
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("                        <div class=\"ln_solid\"></div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-offset-3\">\r\n                                <button class=\"btn btn-primary pull-right\" type=\"submit\" id=\"btnSubmit\">\r\n                                    <span id=\"loading\" class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                                    Save\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>8__1 = null;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>8__1 = null;
				this.<>t__builder.SetResult();
			}

			// Token: 0x060008DB RID: 2267 RVA: 0x00026348 File Offset: 0x00024548
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400061E RID: 1566
			public int <>1__state;

			// Token: 0x0400061F RID: 1567
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000620 RID: 1568
			public Areas_Admin_Views_AccessToken_Edit <>4__this;

			// Token: 0x04000621 RID: 1569
			private Areas_Admin_Views_AccessToken_Edit.<>c__DisplayClass55_0 <>8__1;

			// Token: 0x04000622 RID: 1570
			private TaskAwaiter <>u__1;

			// Token: 0x04000623 RID: 1571
			[global::System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1, 0, 0 })]
			private IEnumerator<IGrouping<string, RoleViewModel>> <>7__wrap1;

			// Token: 0x04000624 RID: 1572
			private IEnumerator<RoleViewModel> <>7__wrap2;

			// Token: 0x04000625 RID: 1573
			private Dictionary<string, string>.Enumerator <>7__wrap3;

			// Token: 0x04000626 RID: 1574
			private KeyValuePair<string, string> <sessionMode>5__5;
		}

		// Token: 0x020000EB RID: 235
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_1>d : IAsyncStateMachine
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x00026358 File Offset: 0x00024558
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/uas/lib/jqueryui/themes/base/jquery-ui.min.css\" />\r\n");
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

			// Token: 0x060008DD RID: 2269 RVA: 0x000263BC File Offset: 0x000245BC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000627 RID: 1575
			public int <>1__state;

			// Token: 0x04000628 RID: 1576
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000629 RID: 1577
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000EC RID: 236
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_2>d : IAsyncStateMachine
		{
			// Token: 0x060008DE RID: 2270 RVA: 0x000263CC File Offset: 0x000245CC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
					TaskAwaiter awaiter5;
					TaskAwaiter awaiter6;
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
						goto IL_017A;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_02C4;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0339;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0483;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04F5;
					default:
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n    ");
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa5102400", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_66));
						areas_Admin_Views_AccessToken_Edit.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_AccessToken_Edit.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_AccessToken_Edit.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0181;
					}
					awaiter2 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter2, ref this);
						return;
					}
					IL_017A:
					awaiter2.GetResult();
					IL_0181:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n    <script src=\"/uas/lib/jqueryui/jquery-ui.min.js\"></script>\r\n    ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa5104201", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_67));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_38.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_38);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter3, ref this);
						return;
					}
					IL_02C4:
					awaiter3.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0340;
					}
					awaiter4 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter4, ref this);
						return;
					}
					IL_0339:
					awaiter4.GetResult();
					IL_0340:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n    ");
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa5105918", new Func<Task>(Areas_Admin_Views_AccessToken_Edit.<>c.<>9.<ExecuteAsync>b__55_68));
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_39.Value;
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_39);
					areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter5, ref this);
						return;
					}
					IL_0483:
					awaiter5.GetResult();
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04FC;
					}
					awaiter6 = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_2>d>(ref awaiter6, ref this);
						return;
					}
					IL_04F5:
					awaiter6.GetResult();
					IL_04FC:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n");
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

			// Token: 0x060008DF RID: 2271 RVA: 0x0002694C File Offset: 0x00024B4C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400062A RID: 1578
			public int <>1__state;

			// Token: 0x0400062B RID: 1579
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400062C RID: 1580
			public Areas_Admin_Views_AccessToken_Edit <>4__this;

			// Token: 0x0400062D RID: 1581
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000ED RID: 237
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_46>d : IAsyncStateMachine
		{
			// Token: 0x060008E0 RID: 2272 RVA: 0x0002695C File Offset: 0x00024B5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
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
							goto IL_0163;
						}
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                    ");
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa581782", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_61));
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<OptionTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_30.Value;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_30);
						awaiter2 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_46>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016A;
					}
					awaiter = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<<ExecuteAsync>b__55_46>d>(ref awaiter, ref this);
						return;
					}
					IL_0163:
					awaiter.GetResult();
					IL_016A:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                ");
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

			// Token: 0x060008E1 RID: 2273 RVA: 0x00026B4C File Offset: 0x00024D4C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400062E RID: 1582
			public int <>1__state;

			// Token: 0x0400062F RID: 1583
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000630 RID: 1584
			public Areas_Admin_Views_AccessToken_Edit <>4__this;

			// Token: 0x04000631 RID: 1585
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000EE RID: 238
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_48>d : IAsyncStateMachine
		{
			// Token: 0x060008E2 RID: 2274 RVA: 0x00026B5C File Offset: 0x00024D5C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                ");
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

			// Token: 0x060008E3 RID: 2275 RVA: 0x00026BC0 File Offset: 0x00024DC0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000632 RID: 1586
			public int <>1__state;

			// Token: 0x04000633 RID: 1587
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000634 RID: 1588
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000EF RID: 239
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_50>d : IAsyncStateMachine
		{
			// Token: 0x060008E4 RID: 2276 RVA: 0x00026BD0 File Offset: 0x00024DD0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                                                ");
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

			// Token: 0x060008E5 RID: 2277 RVA: 0x00026C34 File Offset: 0x00024E34
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000635 RID: 1589
			public int <>1__state;

			// Token: 0x04000636 RID: 1590
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000637 RID: 1591
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000F0 RID: 240
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_61>d : IAsyncStateMachine
		{
			// Token: 0x060008E6 RID: 2278 RVA: 0x00026C44 File Offset: 0x00024E44
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("Select an environment...");
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

			// Token: 0x060008E7 RID: 2279 RVA: 0x00026CA8 File Offset: 0x00024EA8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000638 RID: 1592
			public int <>1__state;

			// Token: 0x04000639 RID: 1593
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400063A RID: 1594
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000F1 RID: 241
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__55_66>d : IAsyncStateMachine
		{
			// Token: 0x060008E8 RID: 2280 RVA: 0x00026CB8 File Offset: 0x00024EB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n        $(function () {\r\n            $('[data-bs-toggle=\"popover\"]').popover()\r\n        })\r\n\r\n        var editMode = true;\r\n        $(document).ready(function () {\r\n            $(\"#generatePassword\").on(\"click\", generatePassword)\r\n        });\r\n    ");
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

			// Token: 0x060008E9 RID: 2281 RVA: 0x00026D1C File Offset: 0x00024F1C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400063B RID: 1595
			public int <>1__state;

			// Token: 0x0400063C RID: 1596
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400063D RID: 1597
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000F2 RID: 242
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060008EC RID: 2284 RVA: 0x00026D40 File Offset: 0x00024F40
			internal Task <ExecuteAsync>b__55_3()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_3>d <<ExecuteAsync>b__55_3>d;
				<<ExecuteAsync>b__55_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_3>d.<>1__state = -1;
				<<ExecuteAsync>b__55_3>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_3>d>(ref <<ExecuteAsync>b__55_3>d);
				return <<ExecuteAsync>b__55_3>d.<>t__builder.Task;
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x00026D7C File Offset: 0x00024F7C
			internal Task <ExecuteAsync>b__55_5()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_5>d <<ExecuteAsync>b__55_5>d;
				<<ExecuteAsync>b__55_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_5>d.<>1__state = -1;
				<<ExecuteAsync>b__55_5>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_5>d>(ref <<ExecuteAsync>b__55_5>d);
				return <<ExecuteAsync>b__55_5>d.<>t__builder.Task;
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x00026DB8 File Offset: 0x00024FB8
			internal Task <ExecuteAsync>b__55_7()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_7>d <<ExecuteAsync>b__55_7>d;
				<<ExecuteAsync>b__55_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_7>d.<>1__state = -1;
				<<ExecuteAsync>b__55_7>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_7>d>(ref <<ExecuteAsync>b__55_7>d);
				return <<ExecuteAsync>b__55_7>d.<>t__builder.Task;
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x00026DF4 File Offset: 0x00024FF4
			internal Task <ExecuteAsync>b__55_9()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_9>d <<ExecuteAsync>b__55_9>d;
				<<ExecuteAsync>b__55_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_9>d.<>1__state = -1;
				<<ExecuteAsync>b__55_9>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_9>d>(ref <<ExecuteAsync>b__55_9>d);
				return <<ExecuteAsync>b__55_9>d.<>t__builder.Task;
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x00026E30 File Offset: 0x00025030
			internal Task <ExecuteAsync>b__55_11()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_11>d <<ExecuteAsync>b__55_11>d;
				<<ExecuteAsync>b__55_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_11>d.<>1__state = -1;
				<<ExecuteAsync>b__55_11>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_11>d>(ref <<ExecuteAsync>b__55_11>d);
				return <<ExecuteAsync>b__55_11>d.<>t__builder.Task;
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x00026E6C File Offset: 0x0002506C
			internal Task <ExecuteAsync>b__55_13()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_13>d <<ExecuteAsync>b__55_13>d;
				<<ExecuteAsync>b__55_13>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_13>d.<>1__state = -1;
				<<ExecuteAsync>b__55_13>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_13>d>(ref <<ExecuteAsync>b__55_13>d);
				return <<ExecuteAsync>b__55_13>d.<>t__builder.Task;
			}

			// Token: 0x060008F2 RID: 2290 RVA: 0x00026EA8 File Offset: 0x000250A8
			internal Task <ExecuteAsync>b__55_15()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_15>d <<ExecuteAsync>b__55_15>d;
				<<ExecuteAsync>b__55_15>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_15>d.<>1__state = -1;
				<<ExecuteAsync>b__55_15>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_15>d>(ref <<ExecuteAsync>b__55_15>d);
				return <<ExecuteAsync>b__55_15>d.<>t__builder.Task;
			}

			// Token: 0x060008F3 RID: 2291 RVA: 0x00026EE4 File Offset: 0x000250E4
			internal Task <ExecuteAsync>b__55_17()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_17>d <<ExecuteAsync>b__55_17>d;
				<<ExecuteAsync>b__55_17>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_17>d.<>1__state = -1;
				<<ExecuteAsync>b__55_17>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_17>d>(ref <<ExecuteAsync>b__55_17>d);
				return <<ExecuteAsync>b__55_17>d.<>t__builder.Task;
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x00026F20 File Offset: 0x00025120
			internal Task <ExecuteAsync>b__55_18()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_18>d <<ExecuteAsync>b__55_18>d;
				<<ExecuteAsync>b__55_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_18>d.<>1__state = -1;
				<<ExecuteAsync>b__55_18>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_18>d>(ref <<ExecuteAsync>b__55_18>d);
				return <<ExecuteAsync>b__55_18>d.<>t__builder.Task;
			}

			// Token: 0x060008F5 RID: 2293 RVA: 0x00026F5C File Offset: 0x0002515C
			internal Task <ExecuteAsync>b__55_20()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_20>d <<ExecuteAsync>b__55_20>d;
				<<ExecuteAsync>b__55_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_20>d.<>1__state = -1;
				<<ExecuteAsync>b__55_20>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_20>d>(ref <<ExecuteAsync>b__55_20>d);
				return <<ExecuteAsync>b__55_20>d.<>t__builder.Task;
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x00026F98 File Offset: 0x00025198
			internal Task <ExecuteAsync>b__55_22()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_22>d <<ExecuteAsync>b__55_22>d;
				<<ExecuteAsync>b__55_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_22>d.<>1__state = -1;
				<<ExecuteAsync>b__55_22>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_22>d>(ref <<ExecuteAsync>b__55_22>d);
				return <<ExecuteAsync>b__55_22>d.<>t__builder.Task;
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x00026FD4 File Offset: 0x000251D4
			internal Task <ExecuteAsync>b__55_24()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_24>d <<ExecuteAsync>b__55_24>d;
				<<ExecuteAsync>b__55_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_24>d.<>1__state = -1;
				<<ExecuteAsync>b__55_24>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_24>d>(ref <<ExecuteAsync>b__55_24>d);
				return <<ExecuteAsync>b__55_24>d.<>t__builder.Task;
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x00027010 File Offset: 0x00025210
			internal Task <ExecuteAsync>b__55_26()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_26>d <<ExecuteAsync>b__55_26>d;
				<<ExecuteAsync>b__55_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_26>d.<>1__state = -1;
				<<ExecuteAsync>b__55_26>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_26>d>(ref <<ExecuteAsync>b__55_26>d);
				return <<ExecuteAsync>b__55_26>d.<>t__builder.Task;
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x0002704C File Offset: 0x0002524C
			internal Task <ExecuteAsync>b__55_28()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_28>d <<ExecuteAsync>b__55_28>d;
				<<ExecuteAsync>b__55_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_28>d.<>1__state = -1;
				<<ExecuteAsync>b__55_28>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_28>d>(ref <<ExecuteAsync>b__55_28>d);
				return <<ExecuteAsync>b__55_28>d.<>t__builder.Task;
			}

			// Token: 0x060008FA RID: 2298 RVA: 0x00027088 File Offset: 0x00025288
			internal Task <ExecuteAsync>b__55_30()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_30>d <<ExecuteAsync>b__55_30>d;
				<<ExecuteAsync>b__55_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_30>d.<>1__state = -1;
				<<ExecuteAsync>b__55_30>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_30>d>(ref <<ExecuteAsync>b__55_30>d);
				return <<ExecuteAsync>b__55_30>d.<>t__builder.Task;
			}

			// Token: 0x060008FB RID: 2299 RVA: 0x000270C4 File Offset: 0x000252C4
			internal Task <ExecuteAsync>b__55_32()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_32>d <<ExecuteAsync>b__55_32>d;
				<<ExecuteAsync>b__55_32>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_32>d.<>1__state = -1;
				<<ExecuteAsync>b__55_32>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_32>d>(ref <<ExecuteAsync>b__55_32>d);
				return <<ExecuteAsync>b__55_32>d.<>t__builder.Task;
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x00027100 File Offset: 0x00025300
			internal Task <ExecuteAsync>b__55_34()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_34>d <<ExecuteAsync>b__55_34>d;
				<<ExecuteAsync>b__55_34>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_34>d.<>1__state = -1;
				<<ExecuteAsync>b__55_34>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_34>d>(ref <<ExecuteAsync>b__55_34>d);
				return <<ExecuteAsync>b__55_34>d.<>t__builder.Task;
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x0002713C File Offset: 0x0002533C
			internal Task <ExecuteAsync>b__55_36()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_36>d <<ExecuteAsync>b__55_36>d;
				<<ExecuteAsync>b__55_36>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_36>d.<>1__state = -1;
				<<ExecuteAsync>b__55_36>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_36>d>(ref <<ExecuteAsync>b__55_36>d);
				return <<ExecuteAsync>b__55_36>d.<>t__builder.Task;
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x00027177 File Offset: 0x00025377
			internal string <ExecuteAsync>b__55_52(RoleViewModel r)
			{
				return r.ModuleId;
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00027180 File Offset: 0x00025380
			internal Task <ExecuteAsync>b__55_53()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_53>d <<ExecuteAsync>b__55_53>d;
				<<ExecuteAsync>b__55_53>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_53>d.<>1__state = -1;
				<<ExecuteAsync>b__55_53>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_53>d>(ref <<ExecuteAsync>b__55_53>d);
				return <<ExecuteAsync>b__55_53>d.<>t__builder.Task;
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x000271BC File Offset: 0x000253BC
			internal Task <ExecuteAsync>b__55_55()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_55>d <<ExecuteAsync>b__55_55>d;
				<<ExecuteAsync>b__55_55>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_55>d.<>1__state = -1;
				<<ExecuteAsync>b__55_55>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_55>d>(ref <<ExecuteAsync>b__55_55>d);
				return <<ExecuteAsync>b__55_55>d.<>t__builder.Task;
			}

			// Token: 0x06000901 RID: 2305 RVA: 0x000271F8 File Offset: 0x000253F8
			internal Task <ExecuteAsync>b__55_57()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_57>d <<ExecuteAsync>b__55_57>d;
				<<ExecuteAsync>b__55_57>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_57>d.<>1__state = -1;
				<<ExecuteAsync>b__55_57>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_57>d>(ref <<ExecuteAsync>b__55_57>d);
				return <<ExecuteAsync>b__55_57>d.<>t__builder.Task;
			}

			// Token: 0x06000902 RID: 2306 RVA: 0x00027234 File Offset: 0x00025434
			internal Task <ExecuteAsync>b__55_59()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_59>d <<ExecuteAsync>b__55_59>d;
				<<ExecuteAsync>b__55_59>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_59>d.<>1__state = -1;
				<<ExecuteAsync>b__55_59>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_59>d>(ref <<ExecuteAsync>b__55_59>d);
				return <<ExecuteAsync>b__55_59>d.<>t__builder.Task;
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x00027270 File Offset: 0x00025470
			internal Task <ExecuteAsync>b__55_38()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_38>d <<ExecuteAsync>b__55_38>d;
				<<ExecuteAsync>b__55_38>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_38>d.<>1__state = -1;
				<<ExecuteAsync>b__55_38>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_38>d>(ref <<ExecuteAsync>b__55_38>d);
				return <<ExecuteAsync>b__55_38>d.<>t__builder.Task;
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x000272AC File Offset: 0x000254AC
			internal Task <ExecuteAsync>b__55_40()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_40>d <<ExecuteAsync>b__55_40>d;
				<<ExecuteAsync>b__55_40>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_40>d.<>1__state = -1;
				<<ExecuteAsync>b__55_40>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_40>d>(ref <<ExecuteAsync>b__55_40>d);
				return <<ExecuteAsync>b__55_40>d.<>t__builder.Task;
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x000272E8 File Offset: 0x000254E8
			internal Task <ExecuteAsync>b__55_42()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_42>d <<ExecuteAsync>b__55_42>d;
				<<ExecuteAsync>b__55_42>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_42>d.<>1__state = -1;
				<<ExecuteAsync>b__55_42>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_42>d>(ref <<ExecuteAsync>b__55_42>d);
				return <<ExecuteAsync>b__55_42>d.<>t__builder.Task;
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00027324 File Offset: 0x00025524
			internal Task <ExecuteAsync>b__55_44()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_44>d <<ExecuteAsync>b__55_44>d;
				<<ExecuteAsync>b__55_44>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_44>d.<>1__state = -1;
				<<ExecuteAsync>b__55_44>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_44>d>(ref <<ExecuteAsync>b__55_44>d);
				return <<ExecuteAsync>b__55_44>d.<>t__builder.Task;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00027360 File Offset: 0x00025560
			internal Task <ExecuteAsync>b__55_62()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_62>d <<ExecuteAsync>b__55_62>d;
				<<ExecuteAsync>b__55_62>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_62>d.<>1__state = -1;
				<<ExecuteAsync>b__55_62>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_62>d>(ref <<ExecuteAsync>b__55_62>d);
				return <<ExecuteAsync>b__55_62>d.<>t__builder.Task;
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x0002739C File Offset: 0x0002559C
			internal Task <ExecuteAsync>b__55_64()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_64>d <<ExecuteAsync>b__55_64>d;
				<<ExecuteAsync>b__55_64>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_64>d.<>1__state = -1;
				<<ExecuteAsync>b__55_64>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_64>d>(ref <<ExecuteAsync>b__55_64>d);
				return <<ExecuteAsync>b__55_64>d.<>t__builder.Task;
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x000273D8 File Offset: 0x000255D8
			internal Task <ExecuteAsync>b__55_67()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_67>d <<ExecuteAsync>b__55_67>d;
				<<ExecuteAsync>b__55_67>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_67>d.<>1__state = -1;
				<<ExecuteAsync>b__55_67>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_67>d>(ref <<ExecuteAsync>b__55_67>d);
				return <<ExecuteAsync>b__55_67>d.<>t__builder.Task;
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x00027414 File Offset: 0x00025614
			internal Task <ExecuteAsync>b__55_68()
			{
				Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_68>d <<ExecuteAsync>b__55_68>d;
				<<ExecuteAsync>b__55_68>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__55_68>d.<>1__state = -1;
				<<ExecuteAsync>b__55_68>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Edit.<>c.<<ExecuteAsync>b__55_68>d>(ref <<ExecuteAsync>b__55_68>d);
				return <<ExecuteAsync>b__55_68>d.<>t__builder.Task;
			}

			// Token: 0x0400063E RID: 1598
			public static readonly Areas_Admin_Views_AccessToken_Edit.<>c <>9 = new Areas_Admin_Views_AccessToken_Edit.<>c();

			// Token: 0x0400063F RID: 1599
			public static Func<Task> <>9__55_3;

			// Token: 0x04000640 RID: 1600
			public static Func<Task> <>9__55_5;

			// Token: 0x04000641 RID: 1601
			public static Func<Task> <>9__55_7;

			// Token: 0x04000642 RID: 1602
			public static Func<Task> <>9__55_9;

			// Token: 0x04000643 RID: 1603
			public static Func<Task> <>9__55_11;

			// Token: 0x04000644 RID: 1604
			public static Func<Task> <>9__55_13;

			// Token: 0x04000645 RID: 1605
			public static Func<Task> <>9__55_15;

			// Token: 0x04000646 RID: 1606
			public static Func<Task> <>9__55_17;

			// Token: 0x04000647 RID: 1607
			public static Func<Task> <>9__55_18;

			// Token: 0x04000648 RID: 1608
			public static Func<Task> <>9__55_20;

			// Token: 0x04000649 RID: 1609
			public static Func<Task> <>9__55_22;

			// Token: 0x0400064A RID: 1610
			public static Func<Task> <>9__55_24;

			// Token: 0x0400064B RID: 1611
			public static Func<Task> <>9__55_26;

			// Token: 0x0400064C RID: 1612
			public static Func<Task> <>9__55_28;

			// Token: 0x0400064D RID: 1613
			public static Func<Task> <>9__55_30;

			// Token: 0x0400064E RID: 1614
			public static Func<Task> <>9__55_32;

			// Token: 0x0400064F RID: 1615
			public static Func<Task> <>9__55_34;

			// Token: 0x04000650 RID: 1616
			public static Func<Task> <>9__55_36;

			// Token: 0x04000651 RID: 1617
			public static Func<RoleViewModel, string> <>9__55_52;

			// Token: 0x04000652 RID: 1618
			public static Func<Task> <>9__55_53;

			// Token: 0x04000653 RID: 1619
			public static Func<Task> <>9__55_55;

			// Token: 0x04000654 RID: 1620
			public static Func<Task> <>9__55_57;

			// Token: 0x04000655 RID: 1621
			public static Func<Task> <>9__55_59;

			// Token: 0x04000656 RID: 1622
			public static Func<Task> <>9__55_38;

			// Token: 0x04000657 RID: 1623
			public static Func<Task> <>9__55_40;

			// Token: 0x04000658 RID: 1624
			public static Func<Task> <>9__55_42;

			// Token: 0x04000659 RID: 1625
			public static Func<Task> <>9__55_44;

			// Token: 0x0400065A RID: 1626
			public static Func<Task> <>9__55_62;

			// Token: 0x0400065B RID: 1627
			public static Func<Task> <>9__55_64;

			// Token: 0x0400065C RID: 1628
			public static Func<Task> <>9__55_67;

			// Token: 0x0400065D RID: 1629
			public static Func<Task> <>9__55_68;

			// Token: 0x02000276 RID: 630
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_11>d : IAsyncStateMachine
			{
				// Token: 0x06000DFA RID: 3578 RVA: 0x0007099C File Offset: 0x0006EB9C
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

				// Token: 0x06000DFB RID: 3579 RVA: 0x000709EC File Offset: 0x0006EBEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D8D RID: 3469
				public int <>1__state;

				// Token: 0x04000D8E RID: 3470
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000277 RID: 631
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_13>d : IAsyncStateMachine
			{
				// Token: 0x06000DFC RID: 3580 RVA: 0x000709FC File Offset: 0x0006EBFC
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

				// Token: 0x06000DFD RID: 3581 RVA: 0x00070A4C File Offset: 0x0006EC4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D8F RID: 3471
				public int <>1__state;

				// Token: 0x04000D90 RID: 3472
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000278 RID: 632
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_15>d : IAsyncStateMachine
			{
				// Token: 0x06000DFE RID: 3582 RVA: 0x00070A5C File Offset: 0x0006EC5C
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

				// Token: 0x06000DFF RID: 3583 RVA: 0x00070AAC File Offset: 0x0006ECAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D91 RID: 3473
				public int <>1__state;

				// Token: 0x04000D92 RID: 3474
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000279 RID: 633
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_17>d : IAsyncStateMachine
			{
				// Token: 0x06000E00 RID: 3584 RVA: 0x00070ABC File Offset: 0x0006ECBC
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

				// Token: 0x06000E01 RID: 3585 RVA: 0x00070B0C File Offset: 0x0006ED0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D93 RID: 3475
				public int <>1__state;

				// Token: 0x04000D94 RID: 3476
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027A RID: 634
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_18>d : IAsyncStateMachine
			{
				// Token: 0x06000E02 RID: 3586 RVA: 0x00070B1C File Offset: 0x0006ED1C
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

				// Token: 0x06000E03 RID: 3587 RVA: 0x00070B6C File Offset: 0x0006ED6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D95 RID: 3477
				public int <>1__state;

				// Token: 0x04000D96 RID: 3478
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027B RID: 635
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_20>d : IAsyncStateMachine
			{
				// Token: 0x06000E04 RID: 3588 RVA: 0x00070B7C File Offset: 0x0006ED7C
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

				// Token: 0x06000E05 RID: 3589 RVA: 0x00070BCC File Offset: 0x0006EDCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D97 RID: 3479
				public int <>1__state;

				// Token: 0x04000D98 RID: 3480
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027C RID: 636
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_22>d : IAsyncStateMachine
			{
				// Token: 0x06000E06 RID: 3590 RVA: 0x00070BDC File Offset: 0x0006EDDC
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

				// Token: 0x06000E07 RID: 3591 RVA: 0x00070C2C File Offset: 0x0006EE2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D99 RID: 3481
				public int <>1__state;

				// Token: 0x04000D9A RID: 3482
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027D RID: 637
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_24>d : IAsyncStateMachine
			{
				// Token: 0x06000E08 RID: 3592 RVA: 0x00070C3C File Offset: 0x0006EE3C
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

				// Token: 0x06000E09 RID: 3593 RVA: 0x00070C8C File Offset: 0x0006EE8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D9B RID: 3483
				public int <>1__state;

				// Token: 0x04000D9C RID: 3484
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027E RID: 638
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_26>d : IAsyncStateMachine
			{
				// Token: 0x06000E0A RID: 3594 RVA: 0x00070C9C File Offset: 0x0006EE9C
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

				// Token: 0x06000E0B RID: 3595 RVA: 0x00070CEC File Offset: 0x0006EEEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D9D RID: 3485
				public int <>1__state;

				// Token: 0x04000D9E RID: 3486
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200027F RID: 639
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_28>d : IAsyncStateMachine
			{
				// Token: 0x06000E0C RID: 3596 RVA: 0x00070CFC File Offset: 0x0006EEFC
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

				// Token: 0x06000E0D RID: 3597 RVA: 0x00070D4C File Offset: 0x0006EF4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D9F RID: 3487
				public int <>1__state;

				// Token: 0x04000DA0 RID: 3488
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000280 RID: 640
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_30>d : IAsyncStateMachine
			{
				// Token: 0x06000E0E RID: 3598 RVA: 0x00070D5C File Offset: 0x0006EF5C
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

				// Token: 0x06000E0F RID: 3599 RVA: 0x00070DAC File Offset: 0x0006EFAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DA1 RID: 3489
				public int <>1__state;

				// Token: 0x04000DA2 RID: 3490
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000281 RID: 641
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_32>d : IAsyncStateMachine
			{
				// Token: 0x06000E10 RID: 3600 RVA: 0x00070DBC File Offset: 0x0006EFBC
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

				// Token: 0x06000E11 RID: 3601 RVA: 0x00070E0C File Offset: 0x0006F00C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DA3 RID: 3491
				public int <>1__state;

				// Token: 0x04000DA4 RID: 3492
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000282 RID: 642
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_34>d : IAsyncStateMachine
			{
				// Token: 0x06000E12 RID: 3602 RVA: 0x00070E1C File Offset: 0x0006F01C
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

				// Token: 0x06000E13 RID: 3603 RVA: 0x00070E6C File Offset: 0x0006F06C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DA5 RID: 3493
				public int <>1__state;

				// Token: 0x04000DA6 RID: 3494
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000283 RID: 643
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_36>d : IAsyncStateMachine
			{
				// Token: 0x06000E14 RID: 3604 RVA: 0x00070E7C File Offset: 0x0006F07C
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

				// Token: 0x06000E15 RID: 3605 RVA: 0x00070ECC File Offset: 0x0006F0CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DA7 RID: 3495
				public int <>1__state;

				// Token: 0x04000DA8 RID: 3496
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000284 RID: 644
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_38>d : IAsyncStateMachine
			{
				// Token: 0x06000E16 RID: 3606 RVA: 0x00070EDC File Offset: 0x0006F0DC
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

				// Token: 0x06000E17 RID: 3607 RVA: 0x00070F2C File Offset: 0x0006F12C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DA9 RID: 3497
				public int <>1__state;

				// Token: 0x04000DAA RID: 3498
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000285 RID: 645
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_3>d : IAsyncStateMachine
			{
				// Token: 0x06000E18 RID: 3608 RVA: 0x00070F3C File Offset: 0x0006F13C
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

				// Token: 0x06000E19 RID: 3609 RVA: 0x00070F8C File Offset: 0x0006F18C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DAB RID: 3499
				public int <>1__state;

				// Token: 0x04000DAC RID: 3500
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000286 RID: 646
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_40>d : IAsyncStateMachine
			{
				// Token: 0x06000E1A RID: 3610 RVA: 0x00070F9C File Offset: 0x0006F19C
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

				// Token: 0x06000E1B RID: 3611 RVA: 0x00070FEC File Offset: 0x0006F1EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DAD RID: 3501
				public int <>1__state;

				// Token: 0x04000DAE RID: 3502
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000287 RID: 647
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_42>d : IAsyncStateMachine
			{
				// Token: 0x06000E1C RID: 3612 RVA: 0x00070FFC File Offset: 0x0006F1FC
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

				// Token: 0x06000E1D RID: 3613 RVA: 0x0007104C File Offset: 0x0006F24C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DAF RID: 3503
				public int <>1__state;

				// Token: 0x04000DB0 RID: 3504
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000288 RID: 648
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_44>d : IAsyncStateMachine
			{
				// Token: 0x06000E1E RID: 3614 RVA: 0x0007105C File Offset: 0x0006F25C
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

				// Token: 0x06000E1F RID: 3615 RVA: 0x000710AC File Offset: 0x0006F2AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DB1 RID: 3505
				public int <>1__state;

				// Token: 0x04000DB2 RID: 3506
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000289 RID: 649
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_53>d : IAsyncStateMachine
			{
				// Token: 0x06000E20 RID: 3616 RVA: 0x000710BC File Offset: 0x0006F2BC
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

				// Token: 0x06000E21 RID: 3617 RVA: 0x0007110C File Offset: 0x0006F30C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DB3 RID: 3507
				public int <>1__state;

				// Token: 0x04000DB4 RID: 3508
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028A RID: 650
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_55>d : IAsyncStateMachine
			{
				// Token: 0x06000E22 RID: 3618 RVA: 0x0007111C File Offset: 0x0006F31C
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

				// Token: 0x06000E23 RID: 3619 RVA: 0x0007116C File Offset: 0x0006F36C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DB5 RID: 3509
				public int <>1__state;

				// Token: 0x04000DB6 RID: 3510
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028B RID: 651
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_57>d : IAsyncStateMachine
			{
				// Token: 0x06000E24 RID: 3620 RVA: 0x0007117C File Offset: 0x0006F37C
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

				// Token: 0x06000E25 RID: 3621 RVA: 0x000711CC File Offset: 0x0006F3CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DB7 RID: 3511
				public int <>1__state;

				// Token: 0x04000DB8 RID: 3512
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028C RID: 652
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_59>d : IAsyncStateMachine
			{
				// Token: 0x06000E26 RID: 3622 RVA: 0x000711DC File Offset: 0x0006F3DC
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

				// Token: 0x06000E27 RID: 3623 RVA: 0x0007122C File Offset: 0x0006F42C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DB9 RID: 3513
				public int <>1__state;

				// Token: 0x04000DBA RID: 3514
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028D RID: 653
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_5>d : IAsyncStateMachine
			{
				// Token: 0x06000E28 RID: 3624 RVA: 0x0007123C File Offset: 0x0006F43C
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

				// Token: 0x06000E29 RID: 3625 RVA: 0x0007128C File Offset: 0x0006F48C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DBB RID: 3515
				public int <>1__state;

				// Token: 0x04000DBC RID: 3516
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028E RID: 654
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_62>d : IAsyncStateMachine
			{
				// Token: 0x06000E2A RID: 3626 RVA: 0x0007129C File Offset: 0x0006F49C
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

				// Token: 0x06000E2B RID: 3627 RVA: 0x000712EC File Offset: 0x0006F4EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DBD RID: 3517
				public int <>1__state;

				// Token: 0x04000DBE RID: 3518
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200028F RID: 655
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_64>d : IAsyncStateMachine
			{
				// Token: 0x06000E2C RID: 3628 RVA: 0x000712FC File Offset: 0x0006F4FC
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

				// Token: 0x06000E2D RID: 3629 RVA: 0x0007134C File Offset: 0x0006F54C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DBF RID: 3519
				public int <>1__state;

				// Token: 0x04000DC0 RID: 3520
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000290 RID: 656
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_67>d : IAsyncStateMachine
			{
				// Token: 0x06000E2E RID: 3630 RVA: 0x0007135C File Offset: 0x0006F55C
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

				// Token: 0x06000E2F RID: 3631 RVA: 0x000713AC File Offset: 0x0006F5AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DC1 RID: 3521
				public int <>1__state;

				// Token: 0x04000DC2 RID: 3522
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000291 RID: 657
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_68>d : IAsyncStateMachine
			{
				// Token: 0x06000E30 RID: 3632 RVA: 0x000713BC File Offset: 0x0006F5BC
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

				// Token: 0x06000E31 RID: 3633 RVA: 0x0007140C File Offset: 0x0006F60C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DC3 RID: 3523
				public int <>1__state;

				// Token: 0x04000DC4 RID: 3524
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000292 RID: 658
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_7>d : IAsyncStateMachine
			{
				// Token: 0x06000E32 RID: 3634 RVA: 0x0007141C File Offset: 0x0006F61C
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

				// Token: 0x06000E33 RID: 3635 RVA: 0x0007146C File Offset: 0x0006F66C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DC5 RID: 3525
				public int <>1__state;

				// Token: 0x04000DC6 RID: 3526
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000293 RID: 659
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__55_9>d : IAsyncStateMachine
			{
				// Token: 0x06000E34 RID: 3636 RVA: 0x0007147C File Offset: 0x0006F67C
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

				// Token: 0x06000E35 RID: 3637 RVA: 0x000714CC File Offset: 0x0006F6CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DC7 RID: 3527
				public int <>1__state;

				// Token: 0x04000DC8 RID: 3528
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x020000F3 RID: 243
		[CompilerGenerated]
		private sealed class <>c__DisplayClass55_0
		{
			// Token: 0x0400065E RID: 1630
			public int ix;

			// Token: 0x0400065F RID: 1631
			public Areas_Admin_Views_AccessToken_Edit <>4__this;
		}

		// Token: 0x020000F4 RID: 244
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__55 : IAsyncStateMachine
		{
			// Token: 0x0600090C RID: 2316 RVA: 0x00027458 File Offset: 0x00025658
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Edit areas_Admin_Views_AccessToken_Edit = this.<>4__this;
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
							goto IL_01C7;
						}
						areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"m-1\">\r\n                    <h2>User account</h2>\r\n                </div>\r\n                <div class=\"border bg-light py-2 px-3 rounded shadow\">\r\n                    ");
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "52a92aeb976d9815aa2c1eea4829e53971b116f3ff6de966c6901baffaa98fa518714", new Func<Task>(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_0));
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_AccessToken_Edit.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_AccessToken_Edit.BeginWriteTagHelperAttribute();
						areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Edit.EndWriteTagHelperAttribute();
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute("data-parsley-validate", areas_Admin_Views_AccessToken_Edit.Html.Raw(areas_Admin_Views_AccessToken_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_36);
						areas_Admin_Views_AccessToken_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_37.Value;
						areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Edit.__tagHelperAttribute_37);
						awaiter2 = areas_Admin_Views_AccessToken_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>d__55>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01CE;
					}
					awaiter = areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>d__55>(ref awaiter, ref this);
						return;
					}
					IL_01C7:
					awaiter.GetResult();
					IL_01CE:
					areas_Admin_Views_AccessToken_Edit.Write(areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Edit.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Edit.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
					areas_Admin_Views_AccessToken_Edit.DefineSection("styleSheets", new RenderAsyncDelegate(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_1));
					areas_Admin_Views_AccessToken_Edit.WriteLiteral("\r\n");
					areas_Admin_Views_AccessToken_Edit.DefineSection("Scripts", new RenderAsyncDelegate(areas_Admin_Views_AccessToken_Edit.<ExecuteAsync>b__55_2));
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

			// Token: 0x0600090D RID: 2317 RVA: 0x000276E4 File Offset: 0x000258E4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000660 RID: 1632
			public int <>1__state;

			// Token: 0x04000661 RID: 1633
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000662 RID: 1634
			public Areas_Admin_Views_AccessToken_Edit <>4__this;

			// Token: 0x04000663 RID: 1635
			private TaskAwaiter <>u__1;
		}
	}
}
