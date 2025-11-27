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
	// Token: 0x02000032 RID: 50
	[RazorSourceChecksum("SHA256", "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab9960", "/Areas/Admin/Views/ApiKey/Create.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/ApiKey/Create.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_ApiKey_Create : BaseRazorPage<ApiKeyViewModel>
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00009A0F File Offset: 0x00007C0F
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

		// Token: 0x060001CA RID: 458 RVA: 0x00009A44 File Offset: 0x00007C44
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_ApiKey_Create.<ExecuteAsync>d__46 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<ExecuteAsync>d__46>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00009A87 File Offset: 0x00007C87
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00009A8F File Offset: 0x00007C8F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00009AA0 File Offset: 0x00007CA0
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00009AA9 File Offset: 0x00007CA9
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00009AB1 File Offset: 0x00007CB1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00009ABA File Offset: 0x00007CBA
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00009AC2 File Offset: 0x00007CC2
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00009ACB File Offset: 0x00007CCB
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00009AD3 File Offset: 0x00007CD3
		[RazorInject]
		public IHtmlHelper<ApiKeyViewModel> Html { get; private set; }

		// Token: 0x060001D7 RID: 471 RVA: 0x00009DD8 File Offset: 0x00007FD8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_0()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d <<ExecuteAsync>b__46_0>d;
			<<ExecuteAsync>b__46_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_0>d.<>4__this = this;
			<<ExecuteAsync>b__46_0>d.<>1__state = -1;
			<<ExecuteAsync>b__46_0>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref <<ExecuteAsync>b__46_0>d);
			return <<ExecuteAsync>b__46_0>d.<>t__builder.Task;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009E1C File Offset: 0x0000801C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_46()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_46>d <<ExecuteAsync>b__46_46>d;
			<<ExecuteAsync>b__46_46>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_46>d.<>4__this = this;
			<<ExecuteAsync>b__46_46>d.<>1__state = -1;
			<<ExecuteAsync>b__46_46>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_46>d>(ref <<ExecuteAsync>b__46_46>d);
			return <<ExecuteAsync>b__46_46>d.<>t__builder.Task;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00009E60 File Offset: 0x00008060
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_55()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_55>d <<ExecuteAsync>b__46_55>d;
			<<ExecuteAsync>b__46_55>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_55>d.<>4__this = this;
			<<ExecuteAsync>b__46_55>d.<>1__state = -1;
			<<ExecuteAsync>b__46_55>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_55>d>(ref <<ExecuteAsync>b__46_55>d);
			return <<ExecuteAsync>b__46_55>d.<>t__builder.Task;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00009EA4 File Offset: 0x000080A4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_1()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_1>d <<ExecuteAsync>b__46_1>d;
			<<ExecuteAsync>b__46_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_1>d.<>4__this = this;
			<<ExecuteAsync>b__46_1>d.<>1__state = -1;
			<<ExecuteAsync>b__46_1>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_1>d>(ref <<ExecuteAsync>b__46_1>d);
			return <<ExecuteAsync>b__46_1>d.<>t__builder.Task;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009EE8 File Offset: 0x000080E8
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_2()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d <<ExecuteAsync>b__46_2>d;
			<<ExecuteAsync>b__46_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_2>d.<>4__this = this;
			<<ExecuteAsync>b__46_2>d.<>1__state = -1;
			<<ExecuteAsync>b__46_2>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref <<ExecuteAsync>b__46_2>d);
			return <<ExecuteAsync>b__46_2>d.<>t__builder.Task;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00009F2C File Offset: 0x0000812C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_56()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_56>d <<ExecuteAsync>b__46_56>d;
			<<ExecuteAsync>b__46_56>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_56>d.<>4__this = this;
			<<ExecuteAsync>b__46_56>d.<>1__state = -1;
			<<ExecuteAsync>b__46_56>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_56>d>(ref <<ExecuteAsync>b__46_56>d);
			return <<ExecuteAsync>b__46_56>d.<>t__builder.Task;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00009F70 File Offset: 0x00008170
		[CompilerGenerated]
		private Task <ExecuteAsync>b__46_58()
		{
			Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_58>d <<ExecuteAsync>b__46_58>d;
			<<ExecuteAsync>b__46_58>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__46_58>d.<>4__this = this;
			<<ExecuteAsync>b__46_58>d.<>1__state = -1;
			<<ExecuteAsync>b__46_58>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_58>d>(ref <<ExecuteAsync>b__46_58>d);
			return <<ExecuteAsync>b__46_58>d.<>t__builder.Task;
		}

		// Token: 0x04000161 RID: 353
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000162 RID: 354
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000163 RID: 355
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("class", new HtmlString("form-control  col-md-7 col-xs-12"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000164 RID: 356
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("id", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000165 RID: 357
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("name", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000166 RID: 358
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("control-label col-md-3 col-sm-3 col-xs-12"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000167 RID: 359
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("type", "datetime", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000168 RID: 360
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000169 RID: 361
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("type", "radio", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016A RID: 362
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("class", new HtmlString("form-check-input"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016B RID: 363
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("value", "Y", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016C RID: 364
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("id", new HtmlString("isAdministratorYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016D RID: 365
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("data-bs-toggle", new HtmlString("collapse"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016E RID: 366
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400016F RID: 367
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("value", "N", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000170 RID: 368
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("id", new HtmlString("isAdministratorNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000171 RID: 369
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000172 RID: 370
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000173 RID: 371
		private static readonly TagHelperAttribute __tagHelperAttribute_18 = new TagHelperAttribute("class", new HtmlString("default"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000174 RID: 372
		private static readonly TagHelperAttribute __tagHelperAttribute_19 = new TagHelperAttribute("value", "true", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000175 RID: 373
		private static readonly TagHelperAttribute __tagHelperAttribute_20 = new TagHelperAttribute("id", new HtmlString("canOpenSessionYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000176 RID: 374
		private static readonly TagHelperAttribute __tagHelperAttribute_21 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000177 RID: 375
		private static readonly TagHelperAttribute __tagHelperAttribute_22 = new TagHelperAttribute("id", new HtmlString("canOpenSessionNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000178 RID: 376
		private static readonly TagHelperAttribute __tagHelperAttribute_23 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000179 RID: 377
		private static readonly TagHelperAttribute __tagHelperAttribute_24 = new TagHelperAttribute("autocomplete", new HtmlString("on"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017A RID: 378
		private static readonly TagHelperAttribute __tagHelperAttribute_25 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017B RID: 379
		private static readonly TagHelperAttribute __tagHelperAttribute_26 = new TagHelperAttribute("class", new HtmlString("select2_single form-select"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017C RID: 380
		private static readonly TagHelperAttribute __tagHelperAttribute_27 = new TagHelperAttribute("class", new HtmlString("form-horizontal form-label-left"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017D RID: 381
		private static readonly TagHelperAttribute __tagHelperAttribute_28 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017E RID: 382
		private static readonly TagHelperAttribute __tagHelperAttribute_29 = new TagHelperAttribute("src", "/uas/js/apiKey.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400017F RID: 383
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000180 RID: 384
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000181 RID: 385
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000182 RID: 386
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000183 RID: 387
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000184 RID: 388
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000185 RID: 389
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x04000186 RID: 390
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000187 RID: 391
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x04000188 RID: 392
		private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

		// Token: 0x04000189 RID: 393
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x0400018A RID: 394
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x0400018B RID: 395
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x0400018C RID: 396
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_0>d : IAsyncStateMachine
		{
			// Token: 0x06000918 RID: 2328 RVA: 0x00028044 File Offset: 0x00026244
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
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
						goto IL_02CD;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0456;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_04CB;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0654;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_06C9;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0852;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_08C7;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0A50;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0AC6;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0C50;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0CC6;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0E50;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0EC6;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1050;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_10C6;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_11F2;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1268;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_13D8;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_144E;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_15DE;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1654;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_17C4;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_183A;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1A18;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1A8E;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1BFE;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1C74;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1E18;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1E8E;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1FFE;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2074;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_227C;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_22F2;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_24FA;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2570;
					case 36:
					case 37:
					case 38:
					case 39:
					case 40:
					case 41:
					{
						IL_269A:
						try
						{
							if (num - 36 > 5)
							{
								goto IL_2F8F;
							}
							IL_26E4:
							try
							{
								TaskAwaiter awaiter37;
								TaskAwaiter awaiter38;
								TaskAwaiter awaiter39;
								TaskAwaiter awaiter40;
								TaskAwaiter awaiter41;
								TaskAwaiter awaiter42;
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
									goto IL_29F3;
								case 38:
									awaiter39 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2C13;
								case 39:
									awaiter40 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2C89;
								case 40:
									awaiter41 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2EA9;
								case 41:
									awaiter42 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2F1F;
								default:
									goto IL_2F53;
								}
								IL_297D:
								awaiter37.GetResult();
								if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_29FA;
								}
								awaiter38 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter38.IsCompleted)
								{
									num = (this.<>1__state = 37);
									this.<>u__1 = awaiter38;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter38, ref this);
									return;
								}
								IL_29F3:
								awaiter38.GetResult();
								IL_29FA:
								areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996058152", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_51));
								areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
								ViewDataDictionary<ApiKeyViewModel> viewData = areas_Admin_Views_ApiKey_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<ApiKeyViewModel, string>(viewData, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_ApiKey_Create, typeof(Areas_Admin_Views_ApiKey_Create)), methodof(RazorPage<ApiKeyViewModel>.get_Model())), methodof(InputApiKeyViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0)), fieldof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0.ix)) }), methodof(RoleViewModel.get_Name())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter39 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter39.IsCompleted)
								{
									num = (this.<>1__state = 38);
									this.<>u__1 = awaiter39;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter39, ref this);
									return;
								}
								IL_2C13:
								awaiter39.GetResult();
								if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2C90;
								}
								awaiter40 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter40.IsCompleted)
								{
									num = (this.<>1__state = 39);
									this.<>u__1 = awaiter40;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter40, ref this);
									return;
								}
								IL_2C89:
								awaiter40.GetResult();
								IL_2C90:
								areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996059989", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_53));
								areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
								ViewDataDictionary<ApiKeyViewModel> viewData2 = areas_Admin_Views_ApiKey_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<ApiKeyViewModel, string>(viewData2, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_ApiKey_Create, typeof(Areas_Admin_Views_ApiKey_Create)), methodof(RazorPage<ApiKeyViewModel>.get_Model())), methodof(InputApiKeyViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0)), fieldof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0.ix)) }), methodof(RoleViewModel.get_ModuleId())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter41 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter41.IsCompleted)
								{
									num = (this.<>1__state = 40);
									this.<>u__1 = awaiter41;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter41, ref this);
									return;
								}
								IL_2EA9:
								awaiter41.GetResult();
								if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2F26;
								}
								awaiter42 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter42.IsCompleted)
								{
									num = (this.<>1__state = 41);
									this.<>u__1 = awaiter42;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter42, ref this);
									return;
								}
								IL_2F1F:
								awaiter42.GetResult();
								IL_2F26:
								areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                                        <span class=\"slider round\"></span>\r\n                                                                    </label>\r\n                                                                </div>\r\n");
								IL_2F53:
								if (this.<>7__wrap2.MoveNext())
								{
									RoleViewModel role = this.<>7__wrap2.Current;
									int ix = this.<>8__1.ix;
									this.<>8__1.ix = ix + 1;
									areas_Admin_Views_ApiKey_Create.WriteLiteral("                                                                <div class=\"col-4\">\r\n                                                                    ");
									areas_Admin_Views_ApiKey_Create.Write(role.Title);
									areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                                    <label class=\"switch mt-1 me-1\">\r\n                                                                        ");
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996056009", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_49));
									areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
									areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_17.Value;
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_17);
									InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
									IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
									ViewDataDictionary<ApiKeyViewModel> viewData3 = areas_Admin_Views_ApiKey_Create.ViewData;
									parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
									_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<ApiKeyViewModel, bool>(viewData3, Expression.Lambda<Func<ApiKeyViewModel, bool>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_ApiKey_Create, typeof(Areas_Admin_Views_ApiKey_Create)), methodof(RazorPage<ApiKeyViewModel>.get_Model())), methodof(InputApiKeyViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0)), fieldof(Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0.ix)) }), methodof(RoleViewModel.get_IsSelected())), new ParameterExpression[] { parameterExpression }));
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_18);
									areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_19.Value;
									areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_19);
									awaiter37 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
									if (!awaiter37.IsCompleted)
									{
										num = (this.<>1__state = 36);
										this.<>u__1 = awaiter37;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter37, ref this);
										return;
									}
									goto IL_297D;
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
							areas_Admin_Views_ApiKey_Create.WriteLiteral("                                                        </div>\r\n                                                    </fieldset>\r\n");
							IL_2F8F:
							if (this.<>7__wrap1.MoveNext())
							{
								IGrouping<string, RoleViewModel> rolesByModule = this.<>7__wrap1.Current;
								areas_Admin_Views_ApiKey_Create.WriteLiteral("                                                    <fieldset class=\"border mb-2 p-2\">\r\n                                                        <legend class=\"w-auto px-2 text-secondary h6\">");
								areas_Admin_Views_ApiKey_Create.Write(rolesByModule.Key);
								areas_Admin_Views_ApiKey_Create.WriteLiteral("</legend>\r\n                                                        <div class=\"row\">\r\n");
								this.<>7__wrap2 = rolesByModule.GetEnumerator();
								goto IL_26E4;
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
						areas_Admin_Views_ApiKey_Create.WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!--End roles -->\r\n                        <!--Open Session -->\r\n                        <div class=\"form-group mt-3\">\r\n                            <label>Hopex session</label>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996063250", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_38));
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
						ViewDataDictionary<ApiKeyViewModel> viewData4 = areas_Admin_Views_ApiKey_Create.ViewData;
						parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider4.CreateModelExpression<ApiKeyViewModel, string>(viewData4, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8.Value;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8);
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_9);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_14.Value;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_14);
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_20);
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_12);
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_21);
						awaiter43 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter43.IsCompleted)
						{
							num = (this.<>1__state = 42);
							this.<>u__1 = awaiter43;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter43, ref this);
							return;
						}
						goto IL_318B;
					}
					case 42:
						awaiter43 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_318B;
					case 43:
						awaiter44 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3201;
					case 44:
						awaiter45 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_33F5;
					case 45:
						awaiter46 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_346B;
					case 46:
						awaiter47 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_36C5;
					case 47:
						awaiter48 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_373B;
					case 48:
						awaiter49 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_38AB;
					case 49:
						awaiter50 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3921;
					case 50:
						awaiter51 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3AB0;
					case 51:
						awaiter52 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3B26;
					default:
					{
						this.<>8__1 = new Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0();
						this.<>8__1.<>4__this = areas_Admin_Views_ApiKey_Create;
						areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996017881", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_3));
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
						ViewDataDictionary<ApiKeyViewModel> viewData5 = areas_Admin_Views_ApiKey_Create.ViewData;
						parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider5.CreateModelExpression<ApiKeyViewModel, string>(viewData5, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_AssignableElementId())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02D4;
					}
					awaiter2 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_02CD:
					awaiter2.GetResult();
					IL_02D4:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996019668", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_5));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData6 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider6.CreateModelExpression<ApiKeyViewModel, string>(viewData6, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Login())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter3 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (this.<>1__state = 2);
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0456:
					awaiter3.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04D2;
					}
					awaiter4 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (this.<>1__state = 3);
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_04CB:
					awaiter4.GetResult();
					IL_04D2:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996021441", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_7));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData7 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider7.CreateModelExpression<ApiKeyViewModel, string>(viewData7, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_UserId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter5 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (this.<>1__state = 4);
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_0654:
					awaiter5.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06D0;
					}
					awaiter6 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						num = (this.<>1__state = 5);
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_06C9:
					awaiter6.GetResult();
					IL_06D0:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996023215", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_9));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData8 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider8.CreateModelExpression<ApiKeyViewModel, string>(viewData8, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_RepositoryId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter7 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						num = (this.<>1__state = 6);
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_0852:
					awaiter7.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08CE;
					}
					awaiter8 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						num = (this.<>1__state = 7);
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_08C7:
					awaiter8.GetResult();
					IL_08CE:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996024995", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_11));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData9 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider9.CreateModelExpression<ApiKeyViewModel, string>(viewData9, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_GuiLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter9 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						num = (this.<>1__state = 8);
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A50:
					awaiter9.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0ACD;
					}
					awaiter10 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						num = (this.<>1__state = 9);
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0AC6:
					awaiter10.GetResult();
					IL_0ACD:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996026776", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_13));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData10 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider10.CreateModelExpression<ApiKeyViewModel, string>(viewData10, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_DataLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter11 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						num = (this.<>1__state = 10);
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0C50:
					awaiter11.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0CCD;
					}
					awaiter12 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						num = (this.<>1__state = 11);
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0CC6:
					awaiter12.GetResult();
					IL_0CCD:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996028558", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_15));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData11 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11.For = modelExpressionProvider11.CreateModelExpression<ApiKeyViewModel, string>(viewData11, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_ProfileId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter13 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						num = (this.<>1__state = 12);
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0E50:
					awaiter13.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0ECD;
					}
					awaiter14 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						num = (this.<>1__state = 13);
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0EC6:
					awaiter14.GetResult();
					IL_0ECD:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996030335", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_17));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData12 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12.For = modelExpressionProvider12.CreateModelExpression<ApiKeyViewModel, string>(viewData12, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_0);
					awaiter15 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						num = (this.<>1__state = 14);
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_1050:
					awaiter15.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_10CD;
					}
					awaiter16 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						num = (this.<>1__state = 15);
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_10C6:
					awaiter16.GetResult();
					IL_10CD:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n\r\n                        ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996032115", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_19));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ValidationSummaryTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_1);
					awaiter17 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						num = (this.<>1__state = 16);
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_11F2:
					awaiter17.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_126F;
					}
					awaiter18 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						num = (this.<>1__state = 17);
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_1268:
					awaiter18.GetResult();
					IL_126F:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label for=\"TokenName\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Name<span class=\"required\"> *</span></label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996034140", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_20));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData13 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13.For = modelExpressionProvider13.CreateModelExpression<ApiKeyViewModel, string>(viewData13, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_2);
					awaiter19 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						num = (this.<>1__state = 18);
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_13D8:
					awaiter19.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1455;
					}
					awaiter20 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						num = (this.<>1__state = 19);
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_144E:
					awaiter20.GetResult();
					IL_1455:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996035796", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_22));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData14 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider14.CreateModelExpression<ApiKeyViewModel, string>(viewData14, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_1);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_3);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_4);
					awaiter21 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						num = (this.<>1__state = 20);
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_15DE:
					awaiter21.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_165B;
					}
					awaiter22 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						num = (this.<>1__state = 21);
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1654:
					awaiter22.GetResult();
					IL_165B:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("label", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996037824", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_24));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<LabelTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData15 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider15.CreateModelExpression<ApiKeyViewModel, string>(viewData15, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_5);
					awaiter23 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						num = (this.<>1__state = 22);
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_17C4:
					awaiter23.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1841;
					}
					awaiter24 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						num = (this.<>1__state = 23);
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_183A:
					awaiter24.GetResult();
					IL_1841:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                            <div class=\"col-md-2 col-sm-2 col-xs-4\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996039565", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_26));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData16 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14.For = modelExpressionProvider16.CreateModelExpression<ApiKeyViewModel, string>(viewData16, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_6.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_6);
					areas_Admin_Views_ApiKey_Create.BeginWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer = areas_Admin_Views_ApiKey_Create.EndWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_ApiKey_Create.Html.Raw(areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_2);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_7);
					awaiter25 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						num = (this.<>1__state = 24);
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_1A18:
					awaiter25.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1A95;
					}
					awaiter26 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						num = (this.<>1__state = 25);
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1A8E:
					awaiter26.GetResult();
					IL_1A95:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996041851", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_28));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData17 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider17.CreateModelExpression<ApiKeyViewModel, string>(viewData17, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_ExpirationDate())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_1);
					awaiter27 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						num = (this.<>1__state = 26);
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1BFE:
					awaiter27.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1C7B;
					}
					awaiter28 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						num = (this.<>1__state = 27);
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1C74:
					awaiter28.GetResult();
					IL_1C7B:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Description\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Description</label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996043908", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_30));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider18 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData18 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15.For = modelExpressionProvider18.CreateModelExpression<ApiKeyViewModel, string>(viewData18, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.BeginWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer = areas_Admin_Views_ApiKey_Create.EndWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_ApiKey_Create.Html.Raw(areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_2);
					awaiter29 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						num = (this.<>1__state = 28);
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1E18:
					awaiter29.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1E95;
					}
					awaiter30 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						num = (this.<>1__state = 29);
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1E8E:
					awaiter30.GetResult();
					IL_1E95:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996045888", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_32));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider19 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData19 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider19.CreateModelExpression<ApiKeyViewModel, string>(viewData19, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_1);
					awaiter31 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						num = (this.<>1__state = 30);
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_1FFE:
					awaiter31.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_207B;
					}
					awaiter32 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						num = (this.<>1__state = 31);
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_2074:
					awaiter32.GetResult();
					IL_207B:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <!--Roles -->\r\n                    <div class=\"form-group mt-3\">\r\n                            <label>Roles</label>\r\n                            Model.Roles\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996047935", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_34));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider20 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData20 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16.For = modelExpressionProvider20.CreateModelExpression<ApiKeyViewModel, string>(viewData20, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_9);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_10.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_10);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_11);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_12);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_13);
					awaiter33 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						num = (this.<>1__state = 32);
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_227C:
					awaiter33.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_22F9;
					}
					awaiter34 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						num = (this.<>1__state = 33);
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_22F2:
					awaiter34.GetResult();
					IL_22F9:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                <label for=\"isAdministratorYes\" class=\"form-check-label\">Administrator</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996050513", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_36));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider21 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData21 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17.For = modelExpressionProvider21.CreateModelExpression<ApiKeyViewModel, string>(viewData21, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_9);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_14.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_14);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_15);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_12);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_16);
					awaiter35 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						num = (this.<>1__state = 34);
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_24FA:
					awaiter35.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2577;
					}
					awaiter36 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						num = (this.<>1__state = 35);
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_2570:
					awaiter36.GetResult();
					IL_2577:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                <label for=\"isAdministratorNo\" class=\"form-check-label\">Custom</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseRoles\"");
					areas_Admin_Views_ApiKey_Create.BeginWriteAttribute("class", " class=\"", 5644, "\"", 5735, 3);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue("", 5652, "panel-collapse", 5652, 14, true);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue(" ", 5666, "collapse", 5667, 9, true);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue(" ", 5675, (areas_Admin_Views_ApiKey_Create.Model.Roles.IsAdministrator == "N") ? "show" : string.Empty, 5676, 59, false);
					areas_Admin_Views_ApiKey_Create.EndWriteAttribute();
					areas_Admin_Views_ApiKey_Create.WriteLiteral(">\r\n                                        <div class=\"form-group mt-1 col-6\">\r\n");
					this.<>8__1.ix = -1;
					this.<>7__wrap1 = areas_Admin_Views_ApiKey_Create.Model.Roles.Items.GroupBy(new Func<RoleViewModel, string>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_48)).GetEnumerator();
					goto IL_269A;
					IL_318B:
					awaiter43.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3208;
					}
					awaiter44 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter44.IsCompleted)
					{
						num = (this.<>1__state = 43);
						this.<>u__1 = awaiter44;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter44, ref this);
						return;
					}
					IL_3201:
					awaiter44.GetResult();
					IL_3208:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                <label for=\"canOpenSessionYes\" class=\"form-check-label\">No session</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996065818", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_40));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider22 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData22 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18.For = modelExpressionProvider22.CreateModelExpression<ApiKeyViewModel, string>(viewData22, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_8);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_9);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_10.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_10);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_22);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_12);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_23);
					awaiter45 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter45.IsCompleted)
					{
						num = (this.<>1__state = 44);
						this.<>u__1 = awaiter45;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter45, ref this);
						return;
					}
					IL_33F5:
					awaiter45.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3472;
					}
					awaiter46 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter46.IsCompleted)
					{
						num = (this.<>1__state = 45);
						this.<>u__1 = awaiter46;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter46, ref this);
						return;
					}
					IL_346B:
					awaiter46.GetResult();
					IL_3472:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                <label for=\"canOpenSessionNo\" class=\"form-check-label\">Open session</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseSession\"");
					areas_Admin_Views_ApiKey_Create.BeginWriteAttribute("class", " class=\"", 9391, "\"", 9475, 3);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue("", 9399, "panel-collapse", 9399, 14, true);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue(" ", 9413, "collapse", 9414, 9, true);
					areas_Admin_Views_ApiKey_Create.WriteAttributeValue(" ", 9422, (areas_Admin_Views_ApiKey_Create.Model.CanOpenSession == "Y") ? "show" : string.Empty, 9423, 52, false);
					areas_Admin_Views_ApiKey_Create.EndWriteAttribute();
					areas_Admin_Views_ApiKey_Create.WriteLiteral(">\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"UserName\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">HOPEX login<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996069504", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_42));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider23 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData23 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19.For = modelExpressionProvider23.CreateModelExpression<ApiKeyViewModel, string>(viewData23, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.BeginWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer = areas_Admin_Views_ApiKey_Create.EndWriteTagHelperAttribute();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_ApiKey_Create.Html.Raw(areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_2);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_24);
					awaiter47 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter47.IsCompleted)
					{
						num = (this.<>1__state = 46);
						this.<>u__1 = awaiter47;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter47, ref this);
						return;
					}
					IL_36C5:
					awaiter47.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3742;
					}
					awaiter48 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter48.IsCompleted)
					{
						num = (this.<>1__state = 47);
						this.<>u__1 = awaiter48;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter48, ref this);
						return;
					}
					IL_373B:
					awaiter48.GetResult();
					IL_3742:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996071586", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_44));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider24 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData24 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider24.CreateModelExpression<ApiKeyViewModel, string>(viewData24, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_1);
					awaiter49 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter49.IsCompleted)
					{
						num = (this.<>1__state = 48);
						this.<>u__1 = awaiter49;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter49, ref this);
						return;
					}
					IL_38AB:
					awaiter49.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3928;
					}
					awaiter50 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter50.IsCompleted)
					{
						num = (this.<>1__state = 49);
						this.<>u__1 = awaiter50;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter50, ref this);
						return;
					}
					IL_3921:
					awaiter50.GetResult();
					IL_3928:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"EnvironmentId\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">EnvironmentId<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                ");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996073772", new Func<Task>(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_46));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider25 = areas_Admin_Views_ApiKey_Create.ModelExpressionProvider;
					ViewDataDictionary<ApiKeyViewModel> viewData25 = areas_Admin_Views_ApiKey_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(ApiKeyViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider25.CreateModelExpression<ApiKeyViewModel, string>(viewData25, Expression.Lambda<Func<ApiKeyViewModel, string>>(Expression.Property(parameterExpression, methodof(InputApiKeyViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = areas_Admin_Views_ApiKey_Create.Model.Environments;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_26);
					awaiter51 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter51.IsCompleted)
					{
						num = (this.<>1__state = 50);
						this.<>u__1 = awaiter51;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter51, ref this);
						return;
					}
					IL_3AB0:
					awaiter51.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3B2D;
					}
					awaiter52 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter52.IsCompleted)
					{
						num = (this.<>1__state = 51);
						this.<>u__1 = awaiter52;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_0>d>(ref awaiter52, ref this);
						return;
					}
					IL_3B26:
					awaiter52.GetResult();
					IL_3B2D:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"PersonGroups-group\">\r\n                                            <label for=\"PersonGroups\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Person<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"PersonGroups\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"Repositories-group\">\r\n                                            <label for=\"Repositories\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Repositories<span class=\"required\"> *</span></label>\r\n                                           ");
					areas_Admin_Views_ApiKey_Create.WriteLiteral(" <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"Repositories\" name=\"Repositories\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"Profiles-group\">\r\n                                            <label for=\"Profiles\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Profiles<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"Profiles\" name=\"Profiles\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n   ");
					areas_Admin_Views_ApiKey_Create.WriteLiteral("                                         <label for=\"SessionMode\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Session Mode</label>\r\n                                            <p class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <label class=\"control-label\">Multi</label>\r\n                                                <input type=\"radio\" name=\"SessionMode\" id=\"SessionMode\" value=\"MS\" class=\"flat\" checked />\r\n                                                <label class=\"control-label\">Single</label>\r\n                                                <input type=\"radio\" name=\"SessionMode\" id=\"SessionMode\" value=\"SS\" class=\"flat\" />\r\n                                            </p>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"ConnectionMode\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Connection Mode</label>\r\n                                 ");
					areas_Admin_Views_ApiKey_Create.WriteLiteral("           <p class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <label class=\"control-label\">Read/Write</label>\r\n                                                <input type=\"radio\" name=\"ConnectionMode\" id=\"ConnectionMode\" value=\"RW\" class=\"flat\" checked />\r\n                                                <label class=\"control-label\">Read only</label>\r\n                                                <input type=\"radio\" name=\"ConnectionMode\" id=\"ConnectionMode\" value=\"RO\" class=\"flat\" />\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"ln_solid\"></div>\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12 col-md-offset-3\">\r\n                                <button class=\"btn btn");
					areas_Admin_Views_ApiKey_Create.WriteLiteral("-primary pull-right\" type=\"submit\" id=\"btnSubmit\" disabled>\r\n                                    <span id=\"loading\" class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                                    Submit\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    ");
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

			// Token: 0x06000919 RID: 2329 RVA: 0x0002BC60 File Offset: 0x00029E60
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000672 RID: 1650
			public int <>1__state;

			// Token: 0x04000673 RID: 1651
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000674 RID: 1652
			public Areas_Admin_Views_ApiKey_Create <>4__this;

			// Token: 0x04000675 RID: 1653
			private Areas_Admin_Views_ApiKey_Create.<>c__DisplayClass46_0 <>8__1;

			// Token: 0x04000676 RID: 1654
			private TaskAwaiter <>u__1;

			// Token: 0x04000677 RID: 1655
			[global::System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1, 0, 0 })]
			private IEnumerator<IGrouping<string, RoleViewModel>> <>7__wrap1;

			// Token: 0x04000678 RID: 1656
			private IEnumerator<RoleViewModel> <>7__wrap2;
		}

		// Token: 0x020000FB RID: 251
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_1>d : IAsyncStateMachine
		{
			// Token: 0x0600091A RID: 2330 RVA: 0x0002BC70 File Offset: 0x00029E70
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"/uas/lib/jqueryui/themes/base/jquery-ui.min.css\" />\r\n<style>\r\n    .icon {\r\n        width: 16px;\r\n        height: 16px;\r\n        padding: 0;\r\n        margin: 0;\r\n        vertical-align: middle;\r\n    }\r\n</style>\r\n");
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

			// Token: 0x0600091B RID: 2331 RVA: 0x0002BCD4 File Offset: 0x00029ED4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000679 RID: 1657
			public int <>1__state;

			// Token: 0x0400067A RID: 1658
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400067B RID: 1659
			public Areas_Admin_Views_ApiKey_Create <>4__this;
		}

		// Token: 0x020000FC RID: 252
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_2>d : IAsyncStateMachine
		{
			// Token: 0x0600091C RID: 2332 RVA: 0x0002BCE4 File Offset: 0x00029EE4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
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
						goto IL_0441;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04B3;
					default:
						areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n");
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996084494", new Func<Task>(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_56));
						areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0181;
					}
					awaiter2 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter2, ref this);
						return;
					}
					IL_017A:
					awaiter2.GetResult();
					IL_0181:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n<script src=\"/uas/lib/jqueryui/jquery-ui.min.js\"></script>\r\n");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996086040", new Func<Task>(Areas_Admin_Views_ApiKey_Create.<>c.<>9.<ExecuteAsync>b__46_57));
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_29.Value;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_29);
					areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter3, ref this);
						return;
					}
					IL_02C4:
					awaiter3.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0340;
					}
					awaiter4 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter4, ref this);
						return;
					}
					IL_0339:
					awaiter4.GetResult();
					IL_0340:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n");
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996087749", new Func<Task>(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_58));
					areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<NonceTagHelper>();
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper);
					areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_ApiKey_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter5, ref this);
						return;
					}
					IL_0441:
					awaiter5.GetResult();
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04BA;
					}
					awaiter6 = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_2>d>(ref awaiter6, ref this);
						return;
					}
					IL_04B3:
					awaiter6.GetResult();
					IL_04BA:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n");
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

			// Token: 0x0600091D RID: 2333 RVA: 0x0002C224 File Offset: 0x0002A424
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400067C RID: 1660
			public int <>1__state;

			// Token: 0x0400067D RID: 1661
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400067E RID: 1662
			public Areas_Admin_Views_ApiKey_Create <>4__this;

			// Token: 0x0400067F RID: 1663
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000FD RID: 253
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_46>d : IAsyncStateMachine
		{
			// Token: 0x0600091E RID: 2334 RVA: 0x0002C234 File Offset: 0x0002A434
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
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
						areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                    ");
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996074117", new Func<Task>(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_55));
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<OptionTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_25.Value;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_25);
						awaiter2 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_46>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016A;
					}
					awaiter = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<<ExecuteAsync>b__46_46>d>(ref awaiter, ref this);
						return;
					}
					IL_0163:
					awaiter.GetResult();
					IL_016A:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n                                                ");
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

			// Token: 0x0600091F RID: 2335 RVA: 0x0002C424 File Offset: 0x0002A624
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000680 RID: 1664
			public int <>1__state;

			// Token: 0x04000681 RID: 1665
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000682 RID: 1666
			public Areas_Admin_Views_ApiKey_Create <>4__this;

			// Token: 0x04000683 RID: 1667
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000FE RID: 254
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_55>d : IAsyncStateMachine
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x0002C434 File Offset: 0x0002A634
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_ApiKey_Create.WriteLiteral("Select an environment...");
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

			// Token: 0x06000921 RID: 2337 RVA: 0x0002C498 File Offset: 0x0002A698
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000684 RID: 1668
			public int <>1__state;

			// Token: 0x04000685 RID: 1669
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000686 RID: 1670
			public Areas_Admin_Views_ApiKey_Create <>4__this;
		}

		// Token: 0x020000FF RID: 255
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_56>d : IAsyncStateMachine
		{
			// Token: 0x06000922 RID: 2338 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n    var editMode = false;\r\n");
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

			// Token: 0x06000923 RID: 2339 RVA: 0x0002C50C File Offset: 0x0002A70C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000687 RID: 1671
			public int <>1__state;

			// Token: 0x04000688 RID: 1672
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000689 RID: 1673
			public Areas_Admin_Views_ApiKey_Create <>4__this;
		}

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__46_58>d : IAsyncStateMachine
		{
			// Token: 0x06000924 RID: 2340 RVA: 0x0002C51C File Offset: 0x0002A71C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n    function copyToClipboard() {\r\n        var str = \"");
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.Model.Password);
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\";\r\n        const el = document.createElement('textarea');  // Create a <textarea> element\r\n        el.value = str;                                 // Set its value to the string that you want copied\r\n        el.setAttribute('readonly', '');                // Make it readonly to be tamper-proof\r\n        el.style.position = 'absolute';\r\n        el.style.left = '-9999px';                      // Move outside the screen to make it invisible\r\n        document.body.appendChild(el);                  // Append the <textarea> element to the HTML document\r\n        const selected =\r\n            document.getSelection().rangeCount > 0        // Check if there is any content selected previously\r\n                ? document.getSelection().getRangeAt(0)     // Store selection if found\r\n                : false;                                    // Mark as false to know no selection existed before\r\n        el.select();                                    // Select the <textarea> content\r\n        document.execCommand('copy');  ");
					areas_Admin_Views_ApiKey_Create.WriteLiteral("                 // Copy - only works as a result of a user action (e.g. click events)\r\n        document.body.removeChild(el);                  // Remove the <textarea> element\r\n        if (selected) {                                 // If a selection existed before copying\r\n            document.getSelection().removeAllRanges();    // Unselect everything on the HTML document\r\n            document.getSelection().addRange(selected);   // Restore the original selection\r\n        }\r\n    }\r\n");
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

			// Token: 0x06000925 RID: 2341 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400068A RID: 1674
			public int <>1__state;

			// Token: 0x0400068B RID: 1675
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400068C RID: 1676
			public Areas_Admin_Views_ApiKey_Create <>4__this;
		}

		// Token: 0x02000101 RID: 257
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000928 RID: 2344 RVA: 0x0002C5CC File Offset: 0x0002A7CC
			internal Task <ExecuteAsync>b__46_3()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_3>d <<ExecuteAsync>b__46_3>d;
				<<ExecuteAsync>b__46_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_3>d.<>1__state = -1;
				<<ExecuteAsync>b__46_3>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_3>d>(ref <<ExecuteAsync>b__46_3>d);
				return <<ExecuteAsync>b__46_3>d.<>t__builder.Task;
			}

			// Token: 0x06000929 RID: 2345 RVA: 0x0002C608 File Offset: 0x0002A808
			internal Task <ExecuteAsync>b__46_5()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_5>d <<ExecuteAsync>b__46_5>d;
				<<ExecuteAsync>b__46_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_5>d.<>1__state = -1;
				<<ExecuteAsync>b__46_5>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_5>d>(ref <<ExecuteAsync>b__46_5>d);
				return <<ExecuteAsync>b__46_5>d.<>t__builder.Task;
			}

			// Token: 0x0600092A RID: 2346 RVA: 0x0002C644 File Offset: 0x0002A844
			internal Task <ExecuteAsync>b__46_7()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_7>d <<ExecuteAsync>b__46_7>d;
				<<ExecuteAsync>b__46_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_7>d.<>1__state = -1;
				<<ExecuteAsync>b__46_7>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_7>d>(ref <<ExecuteAsync>b__46_7>d);
				return <<ExecuteAsync>b__46_7>d.<>t__builder.Task;
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x0002C680 File Offset: 0x0002A880
			internal Task <ExecuteAsync>b__46_9()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_9>d <<ExecuteAsync>b__46_9>d;
				<<ExecuteAsync>b__46_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_9>d.<>1__state = -1;
				<<ExecuteAsync>b__46_9>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_9>d>(ref <<ExecuteAsync>b__46_9>d);
				return <<ExecuteAsync>b__46_9>d.<>t__builder.Task;
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x0002C6BC File Offset: 0x0002A8BC
			internal Task <ExecuteAsync>b__46_11()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_11>d <<ExecuteAsync>b__46_11>d;
				<<ExecuteAsync>b__46_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_11>d.<>1__state = -1;
				<<ExecuteAsync>b__46_11>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_11>d>(ref <<ExecuteAsync>b__46_11>d);
				return <<ExecuteAsync>b__46_11>d.<>t__builder.Task;
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
			internal Task <ExecuteAsync>b__46_13()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_13>d <<ExecuteAsync>b__46_13>d;
				<<ExecuteAsync>b__46_13>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_13>d.<>1__state = -1;
				<<ExecuteAsync>b__46_13>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_13>d>(ref <<ExecuteAsync>b__46_13>d);
				return <<ExecuteAsync>b__46_13>d.<>t__builder.Task;
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x0002C734 File Offset: 0x0002A934
			internal Task <ExecuteAsync>b__46_15()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_15>d <<ExecuteAsync>b__46_15>d;
				<<ExecuteAsync>b__46_15>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_15>d.<>1__state = -1;
				<<ExecuteAsync>b__46_15>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_15>d>(ref <<ExecuteAsync>b__46_15>d);
				return <<ExecuteAsync>b__46_15>d.<>t__builder.Task;
			}

			// Token: 0x0600092F RID: 2351 RVA: 0x0002C770 File Offset: 0x0002A970
			internal Task <ExecuteAsync>b__46_17()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_17>d <<ExecuteAsync>b__46_17>d;
				<<ExecuteAsync>b__46_17>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_17>d.<>1__state = -1;
				<<ExecuteAsync>b__46_17>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_17>d>(ref <<ExecuteAsync>b__46_17>d);
				return <<ExecuteAsync>b__46_17>d.<>t__builder.Task;
			}

			// Token: 0x06000930 RID: 2352 RVA: 0x0002C7AC File Offset: 0x0002A9AC
			internal Task <ExecuteAsync>b__46_19()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_19>d <<ExecuteAsync>b__46_19>d;
				<<ExecuteAsync>b__46_19>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_19>d.<>1__state = -1;
				<<ExecuteAsync>b__46_19>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_19>d>(ref <<ExecuteAsync>b__46_19>d);
				return <<ExecuteAsync>b__46_19>d.<>t__builder.Task;
			}

			// Token: 0x06000931 RID: 2353 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
			internal Task <ExecuteAsync>b__46_20()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_20>d <<ExecuteAsync>b__46_20>d;
				<<ExecuteAsync>b__46_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_20>d.<>1__state = -1;
				<<ExecuteAsync>b__46_20>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_20>d>(ref <<ExecuteAsync>b__46_20>d);
				return <<ExecuteAsync>b__46_20>d.<>t__builder.Task;
			}

			// Token: 0x06000932 RID: 2354 RVA: 0x0002C824 File Offset: 0x0002AA24
			internal Task <ExecuteAsync>b__46_22()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_22>d <<ExecuteAsync>b__46_22>d;
				<<ExecuteAsync>b__46_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_22>d.<>1__state = -1;
				<<ExecuteAsync>b__46_22>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_22>d>(ref <<ExecuteAsync>b__46_22>d);
				return <<ExecuteAsync>b__46_22>d.<>t__builder.Task;
			}

			// Token: 0x06000933 RID: 2355 RVA: 0x0002C860 File Offset: 0x0002AA60
			internal Task <ExecuteAsync>b__46_24()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_24>d <<ExecuteAsync>b__46_24>d;
				<<ExecuteAsync>b__46_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_24>d.<>1__state = -1;
				<<ExecuteAsync>b__46_24>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_24>d>(ref <<ExecuteAsync>b__46_24>d);
				return <<ExecuteAsync>b__46_24>d.<>t__builder.Task;
			}

			// Token: 0x06000934 RID: 2356 RVA: 0x0002C89C File Offset: 0x0002AA9C
			internal Task <ExecuteAsync>b__46_26()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_26>d <<ExecuteAsync>b__46_26>d;
				<<ExecuteAsync>b__46_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_26>d.<>1__state = -1;
				<<ExecuteAsync>b__46_26>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_26>d>(ref <<ExecuteAsync>b__46_26>d);
				return <<ExecuteAsync>b__46_26>d.<>t__builder.Task;
			}

			// Token: 0x06000935 RID: 2357 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
			internal Task <ExecuteAsync>b__46_28()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_28>d <<ExecuteAsync>b__46_28>d;
				<<ExecuteAsync>b__46_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_28>d.<>1__state = -1;
				<<ExecuteAsync>b__46_28>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_28>d>(ref <<ExecuteAsync>b__46_28>d);
				return <<ExecuteAsync>b__46_28>d.<>t__builder.Task;
			}

			// Token: 0x06000936 RID: 2358 RVA: 0x0002C914 File Offset: 0x0002AB14
			internal Task <ExecuteAsync>b__46_30()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_30>d <<ExecuteAsync>b__46_30>d;
				<<ExecuteAsync>b__46_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_30>d.<>1__state = -1;
				<<ExecuteAsync>b__46_30>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_30>d>(ref <<ExecuteAsync>b__46_30>d);
				return <<ExecuteAsync>b__46_30>d.<>t__builder.Task;
			}

			// Token: 0x06000937 RID: 2359 RVA: 0x0002C950 File Offset: 0x0002AB50
			internal Task <ExecuteAsync>b__46_32()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_32>d <<ExecuteAsync>b__46_32>d;
				<<ExecuteAsync>b__46_32>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_32>d.<>1__state = -1;
				<<ExecuteAsync>b__46_32>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_32>d>(ref <<ExecuteAsync>b__46_32>d);
				return <<ExecuteAsync>b__46_32>d.<>t__builder.Task;
			}

			// Token: 0x06000938 RID: 2360 RVA: 0x0002C98C File Offset: 0x0002AB8C
			internal Task <ExecuteAsync>b__46_34()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_34>d <<ExecuteAsync>b__46_34>d;
				<<ExecuteAsync>b__46_34>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_34>d.<>1__state = -1;
				<<ExecuteAsync>b__46_34>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_34>d>(ref <<ExecuteAsync>b__46_34>d);
				return <<ExecuteAsync>b__46_34>d.<>t__builder.Task;
			}

			// Token: 0x06000939 RID: 2361 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
			internal Task <ExecuteAsync>b__46_36()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_36>d <<ExecuteAsync>b__46_36>d;
				<<ExecuteAsync>b__46_36>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_36>d.<>1__state = -1;
				<<ExecuteAsync>b__46_36>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_36>d>(ref <<ExecuteAsync>b__46_36>d);
				return <<ExecuteAsync>b__46_36>d.<>t__builder.Task;
			}

			// Token: 0x0600093A RID: 2362 RVA: 0x0002CA03 File Offset: 0x0002AC03
			internal string <ExecuteAsync>b__46_48(RoleViewModel r)
			{
				return r.ModuleId;
			}

			// Token: 0x0600093B RID: 2363 RVA: 0x0002CA0C File Offset: 0x0002AC0C
			internal Task <ExecuteAsync>b__46_49()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_49>d <<ExecuteAsync>b__46_49>d;
				<<ExecuteAsync>b__46_49>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_49>d.<>1__state = -1;
				<<ExecuteAsync>b__46_49>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_49>d>(ref <<ExecuteAsync>b__46_49>d);
				return <<ExecuteAsync>b__46_49>d.<>t__builder.Task;
			}

			// Token: 0x0600093C RID: 2364 RVA: 0x0002CA48 File Offset: 0x0002AC48
			internal Task <ExecuteAsync>b__46_51()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_51>d <<ExecuteAsync>b__46_51>d;
				<<ExecuteAsync>b__46_51>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_51>d.<>1__state = -1;
				<<ExecuteAsync>b__46_51>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_51>d>(ref <<ExecuteAsync>b__46_51>d);
				return <<ExecuteAsync>b__46_51>d.<>t__builder.Task;
			}

			// Token: 0x0600093D RID: 2365 RVA: 0x0002CA84 File Offset: 0x0002AC84
			internal Task <ExecuteAsync>b__46_53()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_53>d <<ExecuteAsync>b__46_53>d;
				<<ExecuteAsync>b__46_53>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_53>d.<>1__state = -1;
				<<ExecuteAsync>b__46_53>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_53>d>(ref <<ExecuteAsync>b__46_53>d);
				return <<ExecuteAsync>b__46_53>d.<>t__builder.Task;
			}

			// Token: 0x0600093E RID: 2366 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
			internal Task <ExecuteAsync>b__46_38()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_38>d <<ExecuteAsync>b__46_38>d;
				<<ExecuteAsync>b__46_38>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_38>d.<>1__state = -1;
				<<ExecuteAsync>b__46_38>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_38>d>(ref <<ExecuteAsync>b__46_38>d);
				return <<ExecuteAsync>b__46_38>d.<>t__builder.Task;
			}

			// Token: 0x0600093F RID: 2367 RVA: 0x0002CAFC File Offset: 0x0002ACFC
			internal Task <ExecuteAsync>b__46_40()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_40>d <<ExecuteAsync>b__46_40>d;
				<<ExecuteAsync>b__46_40>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_40>d.<>1__state = -1;
				<<ExecuteAsync>b__46_40>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_40>d>(ref <<ExecuteAsync>b__46_40>d);
				return <<ExecuteAsync>b__46_40>d.<>t__builder.Task;
			}

			// Token: 0x06000940 RID: 2368 RVA: 0x0002CB38 File Offset: 0x0002AD38
			internal Task <ExecuteAsync>b__46_42()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_42>d <<ExecuteAsync>b__46_42>d;
				<<ExecuteAsync>b__46_42>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_42>d.<>1__state = -1;
				<<ExecuteAsync>b__46_42>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_42>d>(ref <<ExecuteAsync>b__46_42>d);
				return <<ExecuteAsync>b__46_42>d.<>t__builder.Task;
			}

			// Token: 0x06000941 RID: 2369 RVA: 0x0002CB74 File Offset: 0x0002AD74
			internal Task <ExecuteAsync>b__46_44()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_44>d <<ExecuteAsync>b__46_44>d;
				<<ExecuteAsync>b__46_44>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_44>d.<>1__state = -1;
				<<ExecuteAsync>b__46_44>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_44>d>(ref <<ExecuteAsync>b__46_44>d);
				return <<ExecuteAsync>b__46_44>d.<>t__builder.Task;
			}

			// Token: 0x06000942 RID: 2370 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
			internal Task <ExecuteAsync>b__46_57()
			{
				Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_57>d <<ExecuteAsync>b__46_57>d;
				<<ExecuteAsync>b__46_57>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__46_57>d.<>1__state = -1;
				<<ExecuteAsync>b__46_57>d.<>t__builder.Start<Areas_Admin_Views_ApiKey_Create.<>c.<<ExecuteAsync>b__46_57>d>(ref <<ExecuteAsync>b__46_57>d);
				return <<ExecuteAsync>b__46_57>d.<>t__builder.Task;
			}

			// Token: 0x0400068D RID: 1677
			public static readonly Areas_Admin_Views_ApiKey_Create.<>c <>9 = new Areas_Admin_Views_ApiKey_Create.<>c();

			// Token: 0x0400068E RID: 1678
			public static Func<Task> <>9__46_3;

			// Token: 0x0400068F RID: 1679
			public static Func<Task> <>9__46_5;

			// Token: 0x04000690 RID: 1680
			public static Func<Task> <>9__46_7;

			// Token: 0x04000691 RID: 1681
			public static Func<Task> <>9__46_9;

			// Token: 0x04000692 RID: 1682
			public static Func<Task> <>9__46_11;

			// Token: 0x04000693 RID: 1683
			public static Func<Task> <>9__46_13;

			// Token: 0x04000694 RID: 1684
			public static Func<Task> <>9__46_15;

			// Token: 0x04000695 RID: 1685
			public static Func<Task> <>9__46_17;

			// Token: 0x04000696 RID: 1686
			public static Func<Task> <>9__46_19;

			// Token: 0x04000697 RID: 1687
			public static Func<Task> <>9__46_20;

			// Token: 0x04000698 RID: 1688
			public static Func<Task> <>9__46_22;

			// Token: 0x04000699 RID: 1689
			public static Func<Task> <>9__46_24;

			// Token: 0x0400069A RID: 1690
			public static Func<Task> <>9__46_26;

			// Token: 0x0400069B RID: 1691
			public static Func<Task> <>9__46_28;

			// Token: 0x0400069C RID: 1692
			public static Func<Task> <>9__46_30;

			// Token: 0x0400069D RID: 1693
			public static Func<Task> <>9__46_32;

			// Token: 0x0400069E RID: 1694
			public static Func<Task> <>9__46_34;

			// Token: 0x0400069F RID: 1695
			public static Func<Task> <>9__46_36;

			// Token: 0x040006A0 RID: 1696
			public static Func<RoleViewModel, string> <>9__46_48;

			// Token: 0x040006A1 RID: 1697
			public static Func<Task> <>9__46_49;

			// Token: 0x040006A2 RID: 1698
			public static Func<Task> <>9__46_51;

			// Token: 0x040006A3 RID: 1699
			public static Func<Task> <>9__46_53;

			// Token: 0x040006A4 RID: 1700
			public static Func<Task> <>9__46_38;

			// Token: 0x040006A5 RID: 1701
			public static Func<Task> <>9__46_40;

			// Token: 0x040006A6 RID: 1702
			public static Func<Task> <>9__46_42;

			// Token: 0x040006A7 RID: 1703
			public static Func<Task> <>9__46_44;

			// Token: 0x040006A8 RID: 1704
			public static Func<Task> <>9__46_57;

			// Token: 0x02000295 RID: 661
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_11>d : IAsyncStateMachine
			{
				// Token: 0x06000E38 RID: 3640 RVA: 0x0007153C File Offset: 0x0006F73C
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

				// Token: 0x06000E39 RID: 3641 RVA: 0x0007158C File Offset: 0x0006F78C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DCB RID: 3531
				public int <>1__state;

				// Token: 0x04000DCC RID: 3532
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000296 RID: 662
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_13>d : IAsyncStateMachine
			{
				// Token: 0x06000E3A RID: 3642 RVA: 0x0007159C File Offset: 0x0006F79C
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

				// Token: 0x06000E3B RID: 3643 RVA: 0x000715EC File Offset: 0x0006F7EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DCD RID: 3533
				public int <>1__state;

				// Token: 0x04000DCE RID: 3534
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000297 RID: 663
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_15>d : IAsyncStateMachine
			{
				// Token: 0x06000E3C RID: 3644 RVA: 0x000715FC File Offset: 0x0006F7FC
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

				// Token: 0x06000E3D RID: 3645 RVA: 0x0007164C File Offset: 0x0006F84C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DCF RID: 3535
				public int <>1__state;

				// Token: 0x04000DD0 RID: 3536
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000298 RID: 664
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_17>d : IAsyncStateMachine
			{
				// Token: 0x06000E3E RID: 3646 RVA: 0x0007165C File Offset: 0x0006F85C
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

				// Token: 0x06000E3F RID: 3647 RVA: 0x000716AC File Offset: 0x0006F8AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DD1 RID: 3537
				public int <>1__state;

				// Token: 0x04000DD2 RID: 3538
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000299 RID: 665
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_19>d : IAsyncStateMachine
			{
				// Token: 0x06000E40 RID: 3648 RVA: 0x000716BC File Offset: 0x0006F8BC
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

				// Token: 0x06000E41 RID: 3649 RVA: 0x0007170C File Offset: 0x0006F90C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DD3 RID: 3539
				public int <>1__state;

				// Token: 0x04000DD4 RID: 3540
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029A RID: 666
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_20>d : IAsyncStateMachine
			{
				// Token: 0x06000E42 RID: 3650 RVA: 0x0007171C File Offset: 0x0006F91C
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

				// Token: 0x06000E43 RID: 3651 RVA: 0x0007176C File Offset: 0x0006F96C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DD5 RID: 3541
				public int <>1__state;

				// Token: 0x04000DD6 RID: 3542
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029B RID: 667
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_22>d : IAsyncStateMachine
			{
				// Token: 0x06000E44 RID: 3652 RVA: 0x0007177C File Offset: 0x0006F97C
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

				// Token: 0x06000E45 RID: 3653 RVA: 0x000717CC File Offset: 0x0006F9CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DD7 RID: 3543
				public int <>1__state;

				// Token: 0x04000DD8 RID: 3544
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029C RID: 668
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_24>d : IAsyncStateMachine
			{
				// Token: 0x06000E46 RID: 3654 RVA: 0x000717DC File Offset: 0x0006F9DC
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

				// Token: 0x06000E47 RID: 3655 RVA: 0x0007182C File Offset: 0x0006FA2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DD9 RID: 3545
				public int <>1__state;

				// Token: 0x04000DDA RID: 3546
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029D RID: 669
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_26>d : IAsyncStateMachine
			{
				// Token: 0x06000E48 RID: 3656 RVA: 0x0007183C File Offset: 0x0006FA3C
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

				// Token: 0x06000E49 RID: 3657 RVA: 0x0007188C File Offset: 0x0006FA8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DDB RID: 3547
				public int <>1__state;

				// Token: 0x04000DDC RID: 3548
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029E RID: 670
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_28>d : IAsyncStateMachine
			{
				// Token: 0x06000E4A RID: 3658 RVA: 0x0007189C File Offset: 0x0006FA9C
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

				// Token: 0x06000E4B RID: 3659 RVA: 0x000718EC File Offset: 0x0006FAEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DDD RID: 3549
				public int <>1__state;

				// Token: 0x04000DDE RID: 3550
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200029F RID: 671
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_30>d : IAsyncStateMachine
			{
				// Token: 0x06000E4C RID: 3660 RVA: 0x000718FC File Offset: 0x0006FAFC
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

				// Token: 0x06000E4D RID: 3661 RVA: 0x0007194C File Offset: 0x0006FB4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DDF RID: 3551
				public int <>1__state;

				// Token: 0x04000DE0 RID: 3552
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A0 RID: 672
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_32>d : IAsyncStateMachine
			{
				// Token: 0x06000E4E RID: 3662 RVA: 0x0007195C File Offset: 0x0006FB5C
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

				// Token: 0x06000E4F RID: 3663 RVA: 0x000719AC File Offset: 0x0006FBAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DE1 RID: 3553
				public int <>1__state;

				// Token: 0x04000DE2 RID: 3554
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A1 RID: 673
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_34>d : IAsyncStateMachine
			{
				// Token: 0x06000E50 RID: 3664 RVA: 0x000719BC File Offset: 0x0006FBBC
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

				// Token: 0x06000E51 RID: 3665 RVA: 0x00071A0C File Offset: 0x0006FC0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DE3 RID: 3555
				public int <>1__state;

				// Token: 0x04000DE4 RID: 3556
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A2 RID: 674
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_36>d : IAsyncStateMachine
			{
				// Token: 0x06000E52 RID: 3666 RVA: 0x00071A1C File Offset: 0x0006FC1C
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

				// Token: 0x06000E53 RID: 3667 RVA: 0x00071A6C File Offset: 0x0006FC6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DE5 RID: 3557
				public int <>1__state;

				// Token: 0x04000DE6 RID: 3558
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A3 RID: 675
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_38>d : IAsyncStateMachine
			{
				// Token: 0x06000E54 RID: 3668 RVA: 0x00071A7C File Offset: 0x0006FC7C
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

				// Token: 0x06000E55 RID: 3669 RVA: 0x00071ACC File Offset: 0x0006FCCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DE7 RID: 3559
				public int <>1__state;

				// Token: 0x04000DE8 RID: 3560
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A4 RID: 676
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_3>d : IAsyncStateMachine
			{
				// Token: 0x06000E56 RID: 3670 RVA: 0x00071ADC File Offset: 0x0006FCDC
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

				// Token: 0x06000E57 RID: 3671 RVA: 0x00071B2C File Offset: 0x0006FD2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DE9 RID: 3561
				public int <>1__state;

				// Token: 0x04000DEA RID: 3562
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A5 RID: 677
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_40>d : IAsyncStateMachine
			{
				// Token: 0x06000E58 RID: 3672 RVA: 0x00071B3C File Offset: 0x0006FD3C
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

				// Token: 0x06000E59 RID: 3673 RVA: 0x00071B8C File Offset: 0x0006FD8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DEB RID: 3563
				public int <>1__state;

				// Token: 0x04000DEC RID: 3564
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A6 RID: 678
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_42>d : IAsyncStateMachine
			{
				// Token: 0x06000E5A RID: 3674 RVA: 0x00071B9C File Offset: 0x0006FD9C
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

				// Token: 0x06000E5B RID: 3675 RVA: 0x00071BEC File Offset: 0x0006FDEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DED RID: 3565
				public int <>1__state;

				// Token: 0x04000DEE RID: 3566
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A7 RID: 679
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_44>d : IAsyncStateMachine
			{
				// Token: 0x06000E5C RID: 3676 RVA: 0x00071BFC File Offset: 0x0006FDFC
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

				// Token: 0x06000E5D RID: 3677 RVA: 0x00071C4C File Offset: 0x0006FE4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DEF RID: 3567
				public int <>1__state;

				// Token: 0x04000DF0 RID: 3568
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A8 RID: 680
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_49>d : IAsyncStateMachine
			{
				// Token: 0x06000E5E RID: 3678 RVA: 0x00071C5C File Offset: 0x0006FE5C
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

				// Token: 0x06000E5F RID: 3679 RVA: 0x00071CAC File Offset: 0x0006FEAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DF1 RID: 3569
				public int <>1__state;

				// Token: 0x04000DF2 RID: 3570
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002A9 RID: 681
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_51>d : IAsyncStateMachine
			{
				// Token: 0x06000E60 RID: 3680 RVA: 0x00071CBC File Offset: 0x0006FEBC
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

				// Token: 0x06000E61 RID: 3681 RVA: 0x00071D0C File Offset: 0x0006FF0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DF3 RID: 3571
				public int <>1__state;

				// Token: 0x04000DF4 RID: 3572
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002AA RID: 682
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_53>d : IAsyncStateMachine
			{
				// Token: 0x06000E62 RID: 3682 RVA: 0x00071D1C File Offset: 0x0006FF1C
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

				// Token: 0x06000E63 RID: 3683 RVA: 0x00071D6C File Offset: 0x0006FF6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DF5 RID: 3573
				public int <>1__state;

				// Token: 0x04000DF6 RID: 3574
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002AB RID: 683
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_57>d : IAsyncStateMachine
			{
				// Token: 0x06000E64 RID: 3684 RVA: 0x00071D7C File Offset: 0x0006FF7C
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

				// Token: 0x06000E65 RID: 3685 RVA: 0x00071DCC File Offset: 0x0006FFCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DF7 RID: 3575
				public int <>1__state;

				// Token: 0x04000DF8 RID: 3576
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002AC RID: 684
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_5>d : IAsyncStateMachine
			{
				// Token: 0x06000E66 RID: 3686 RVA: 0x00071DDC File Offset: 0x0006FFDC
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

				// Token: 0x06000E67 RID: 3687 RVA: 0x00071E2C File Offset: 0x0007002C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DF9 RID: 3577
				public int <>1__state;

				// Token: 0x04000DFA RID: 3578
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002AD RID: 685
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_7>d : IAsyncStateMachine
			{
				// Token: 0x06000E68 RID: 3688 RVA: 0x00071E3C File Offset: 0x0007003C
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

				// Token: 0x06000E69 RID: 3689 RVA: 0x00071E8C File Offset: 0x0007008C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DFB RID: 3579
				public int <>1__state;

				// Token: 0x04000DFC RID: 3580
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002AE RID: 686
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__46_9>d : IAsyncStateMachine
			{
				// Token: 0x06000E6A RID: 3690 RVA: 0x00071E9C File Offset: 0x0007009C
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

				// Token: 0x06000E6B RID: 3691 RVA: 0x00071EEC File Offset: 0x000700EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000DFD RID: 3581
				public int <>1__state;

				// Token: 0x04000DFE RID: 3582
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x040006A9 RID: 1705
			public int ix;

			// Token: 0x040006AA RID: 1706
			public Areas_Admin_Views_ApiKey_Create <>4__this;
		}

		// Token: 0x02000103 RID: 259
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__46 : IAsyncStateMachine
		{
			// Token: 0x06000944 RID: 2372 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_ApiKey_Create areas_Admin_Views_ApiKey_Create = this.<>4__this;
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
							goto IL_0243;
						}
						areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"x_panel\">\r\n            <div class=\"x_title\">\r\n                <h2>Api key <small>Create a new api key</small></h2>\r\n            </div>\r\n            <div class=\"x_content\">\r\n");
						if (areas_Admin_Views_ApiKey_Create.Model.Password != null)
						{
							areas_Admin_Views_ApiKey_Create.WriteLiteral("                    <div class=\"border m-5 p-2 rounded col-4 bg-white\">\r\n                        <h5 class=\"alert-success p-1 text-center\">Api key created</h5>\r\n                        <div class=\"form-group\">\r\n                            <div>\r\n                                Copy and save the api key to use with <b>x-api-key</b>. This api key will not\r\n                                be visible anymore.\r\n                            </div>\r\n                            <div class=\"form-group mt-2 p-2\">\r\n                                <small>Copy the api key by clicking on the following icon.</small>\r\n                                <div class=\"input-group\">\r\n                                    <input type=\"text\" class=\"form-control\" readonly");
							areas_Admin_Views_ApiKey_Create.BeginWriteAttribute("value", " value=\"", 1148, "\"", 1171, 1);
							areas_Admin_Views_ApiKey_Create.WriteAttributeValue("", 1156, areas_Admin_Views_ApiKey_Create.Model.Password, 1156, 15, false);
							areas_Admin_Views_ApiKey_Create.EndWriteAttribute();
							areas_Admin_Views_ApiKey_Create.WriteLiteral(">\r\n                                    <button class=\"btn btn-outline-secondary\" type=\"button\" onclick=\"copyToClipboard()\">\r\n                                        <i class=\"fa fa-clipboard\" aria-hidden=\"true\"></i>\r\n                                    </button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"text-center\">\r\n                                <a class=\"btn btn-danger btn-ok\" href=\"/uas/admin/apikey\">Close</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
							goto IL_0277;
						}
						areas_Admin_Views_ApiKey_Create.WriteLiteral("                    ");
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996017574", new Func<Task>(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_0));
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_ApiKey_Create.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_ApiKey_Create.BeginWriteTagHelperAttribute();
						areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer = areas_Admin_Views_ApiKey_Create.EndWriteTagHelperAttribute();
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute("data-parsley-validate", areas_Admin_Views_ApiKey_Create.Html.Raw(areas_Admin_Views_ApiKey_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_27);
						areas_Admin_Views_ApiKey_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_28.Value;
						areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_ApiKey_Create.__tagHelperAttribute_28);
						awaiter2 = areas_Admin_Views_ApiKey_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<ExecuteAsync>d__46>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_024A;
					}
					awaiter = areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_ApiKey_Create.<ExecuteAsync>d__46>(ref awaiter, ref this);
						return;
					}
					IL_0243:
					awaiter.GetResult();
					IL_024A:
					areas_Admin_Views_ApiKey_Create.Write(areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_ApiKey_Create.__tagHelperExecutionContext = areas_Admin_Views_ApiKey_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_ApiKey_Create.WriteLiteral("\r\n");
					IL_0277:
					areas_Admin_Views_ApiKey_Create.WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
					areas_Admin_Views_ApiKey_Create.DefineSection("styleSheets", new RenderAsyncDelegate(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_1));
					areas_Admin_Views_ApiKey_Create.DefineSection("Scripts", new RenderAsyncDelegate(areas_Admin_Views_ApiKey_Create.<ExecuteAsync>b__46_2));
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

			// Token: 0x06000945 RID: 2373 RVA: 0x0002CEFC File Offset: 0x0002B0FC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006AB RID: 1707
			public int <>1__state;

			// Token: 0x040006AC RID: 1708
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006AD RID: 1709
			public Areas_Admin_Views_ApiKey_Create <>4__this;

			// Token: 0x040006AE RID: 1710
			private TaskAwaiter <>u__1;
		}
	}
}
