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
	// Token: 0x0200002F RID: 47
	[RazorSourceChecksum("SHA256", "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d", "/Areas/Admin/Views/AccessToken/Create.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/AccessToken/Create.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_AccessToken_Create : BaseRazorPage<AccessTokenViewModel>
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00008BD4 File Offset: 0x00006DD4
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

		// Token: 0x06000190 RID: 400 RVA: 0x00008C08 File Offset: 0x00006E08
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_AccessToken_Create.<ExecuteAsync>d__50 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<ExecuteAsync>d__50>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00008C4B File Offset: 0x00006E4B
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00008C53 File Offset: 0x00006E53
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00008C5C File Offset: 0x00006E5C
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00008C64 File Offset: 0x00006E64
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008C6D File Offset: 0x00006E6D
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00008C75 File Offset: 0x00006E75
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00008C7E File Offset: 0x00006E7E
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00008C86 File Offset: 0x00006E86
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00008C8F File Offset: 0x00006E8F
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00008C97 File Offset: 0x00006E97
		[RazorInject]
		public IHtmlHelper<AccessTokenViewModel> Html { get; private set; }

		// Token: 0x0600019D RID: 413 RVA: 0x00009018 File Offset: 0x00007218
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_0()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d <<ExecuteAsync>b__50_0>d;
			<<ExecuteAsync>b__50_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_0>d.<>4__this = this;
			<<ExecuteAsync>b__50_0>d.<>1__state = -1;
			<<ExecuteAsync>b__50_0>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref <<ExecuteAsync>b__50_0>d);
			return <<ExecuteAsync>b__50_0>d.<>t__builder.Task;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000905C File Offset: 0x0000725C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_46()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_46>d <<ExecuteAsync>b__50_46>d;
			<<ExecuteAsync>b__50_46>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_46>d.<>4__this = this;
			<<ExecuteAsync>b__50_46>d.<>1__state = -1;
			<<ExecuteAsync>b__50_46>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_46>d>(ref <<ExecuteAsync>b__50_46>d);
			return <<ExecuteAsync>b__50_46>d.<>t__builder.Task;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000090A0 File Offset: 0x000072A0
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_57()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_57>d <<ExecuteAsync>b__50_57>d;
			<<ExecuteAsync>b__50_57>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_57>d.<>4__this = this;
			<<ExecuteAsync>b__50_57>d.<>1__state = -1;
			<<ExecuteAsync>b__50_57>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_57>d>(ref <<ExecuteAsync>b__50_57>d);
			return <<ExecuteAsync>b__50_57>d.<>t__builder.Task;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000090E4 File Offset: 0x000072E4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_1()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_1>d <<ExecuteAsync>b__50_1>d;
			<<ExecuteAsync>b__50_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_1>d.<>4__this = this;
			<<ExecuteAsync>b__50_1>d.<>1__state = -1;
			<<ExecuteAsync>b__50_1>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_1>d>(ref <<ExecuteAsync>b__50_1>d);
			return <<ExecuteAsync>b__50_1>d.<>t__builder.Task;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009128 File Offset: 0x00007328
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_2()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d <<ExecuteAsync>b__50_2>d;
			<<ExecuteAsync>b__50_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_2>d.<>4__this = this;
			<<ExecuteAsync>b__50_2>d.<>1__state = -1;
			<<ExecuteAsync>b__50_2>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref <<ExecuteAsync>b__50_2>d);
			return <<ExecuteAsync>b__50_2>d.<>t__builder.Task;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000916C File Offset: 0x0000736C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__50_62()
		{
			Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_62>d <<ExecuteAsync>b__50_62>d;
			<<ExecuteAsync>b__50_62>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__50_62>d.<>4__this = this;
			<<ExecuteAsync>b__50_62>d.<>1__state = -1;
			<<ExecuteAsync>b__50_62>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_62>d>(ref <<ExecuteAsync>b__50_62>d);
			return <<ExecuteAsync>b__50_62>d.<>t__builder.Task;
		}

		// Token: 0x040000E6 RID: 230
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000E7 RID: 231
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000E8 RID: 232
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("class", new HtmlString("form-control col-6"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000E9 RID: 233
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("id", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000EA RID: 234
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("name", new HtmlString("tokenName_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000EB RID: 235
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000EC RID: 236
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000ED RID: 237
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000EE RID: 238
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("id", new HtmlString("password_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000EF RID: 239
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("name", new HtmlString("password_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F0 RID: 240
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("id", new HtmlString("currentAdminPassword_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F1 RID: 241
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("name", new HtmlString("currentAdminPassword_warning"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F2 RID: 242
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("type", "radio", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F3 RID: 243
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("class", new HtmlString("form-check-input"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F4 RID: 244
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("value", "Y", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F5 RID: 245
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("id", new HtmlString("isAdministratorYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F6 RID: 246
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("data-bs-toggle", new HtmlString("collapse"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F7 RID: 247
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F8 RID: 248
		private static readonly TagHelperAttribute __tagHelperAttribute_18 = new TagHelperAttribute("value", "N", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000F9 RID: 249
		private static readonly TagHelperAttribute __tagHelperAttribute_19 = new TagHelperAttribute("id", new HtmlString("isAdministratorNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FA RID: 250
		private static readonly TagHelperAttribute __tagHelperAttribute_20 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseRoles:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FB RID: 251
		private static readonly TagHelperAttribute __tagHelperAttribute_21 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FC RID: 252
		private static readonly TagHelperAttribute __tagHelperAttribute_22 = new TagHelperAttribute("class", new HtmlString("default"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FD RID: 253
		private static readonly TagHelperAttribute __tagHelperAttribute_23 = new TagHelperAttribute("value", "true", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FE RID: 254
		private static readonly TagHelperAttribute __tagHelperAttribute_24 = new TagHelperAttribute("id", new HtmlString("canOpenSessionYes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040000FF RID: 255
		private static readonly TagHelperAttribute __tagHelperAttribute_25 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession.show"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000100 RID: 256
		private static readonly TagHelperAttribute __tagHelperAttribute_26 = new TagHelperAttribute("id", new HtmlString("canOpenSessionNo"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000101 RID: 257
		private static readonly TagHelperAttribute __tagHelperAttribute_27 = new TagHelperAttribute("data-bs-target", new HtmlString("#collapseSession:not(.show)"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000102 RID: 258
		private static readonly TagHelperAttribute __tagHelperAttribute_28 = new TagHelperAttribute("autocomplete", new HtmlString("on"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000103 RID: 259
		private static readonly TagHelperAttribute __tagHelperAttribute_29 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000104 RID: 260
		private static readonly TagHelperAttribute __tagHelperAttribute_30 = new TagHelperAttribute("class", new HtmlString("select2_single form-select col-6"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000105 RID: 261
		private static readonly TagHelperAttribute __tagHelperAttribute_31 = new TagHelperAttribute("class", new HtmlString("form-horizontal form-label-left"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000106 RID: 262
		private static readonly TagHelperAttribute __tagHelperAttribute_32 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000107 RID: 263
		private static readonly TagHelperAttribute __tagHelperAttribute_33 = new TagHelperAttribute("src", "/uas/js/userAccount.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000108 RID: 264
		private static readonly TagHelperAttribute __tagHelperAttribute_34 = new TagHelperAttribute("src", "/uas/js/apiKey.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000109 RID: 265
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x0400010A RID: 266
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x0400010B RID: 267
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400010C RID: 268
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400010D RID: 269
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x0400010E RID: 270
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x0400010F RID: 271
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x04000110 RID: 272
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000111 RID: 273
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x04000112 RID: 274
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x04000113 RID: 275
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x04000114 RID: 276
		private NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper;

		// Token: 0x04000115 RID: 277
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x020000E1 RID: 225
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_0>d : IAsyncStateMachine
		{
			// Token: 0x060008AA RID: 2218 RVA: 0x0001BE14 File Offset: 0x0001A014
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
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
						goto IL_02E8;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0471;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_04E6;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_066F;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_06E4;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_086D;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_08E2;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0A6B;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0AE1;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0C6B;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0CE1;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0E6B;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0EE1;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_100D;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1083;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_11F3;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1269;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_13F9;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_146F;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_16FA;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1770;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1900;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1976;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1B20;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1B96;
					case 26:
						awaiter27 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1D26;
					case 27:
						awaiter28 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1D9C;
					case 28:
						awaiter29 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1F40;
					case 29:
						awaiter30 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_1FB6;
					case 30:
						awaiter31 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2126;
					case 31:
						awaiter32 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_219C;
					case 32:
						awaiter33 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_23A4;
					case 33:
						awaiter34 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_241A;
					case 34:
						awaiter35 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2622;
					case 35:
						awaiter36 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_2698;
					case 36:
					case 37:
					case 38:
					case 39:
					case 40:
					case 41:
					case 42:
					case 43:
					{
						IL_27C2:
						try
						{
							if (num - 36 > 7)
							{
								goto IL_3355;
							}
							IL_280C:
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
									goto IL_2B23;
								case 38:
									awaiter39 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2D43;
								case 39:
									awaiter40 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2DB9;
								case 40:
									awaiter41 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_2FD9;
								case 41:
									awaiter42 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_304F;
								case 42:
									awaiter43 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_326F;
								case 43:
									awaiter44 = this.<>u__1;
									this.<>u__1 = default(TaskAwaiter);
									num = (this.<>1__state = -1);
									goto IL_32E5;
								default:
									goto IL_3319;
								}
								IL_2AAD:
								awaiter37.GetResult();
								if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2B2A;
								}
								awaiter38 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter38.IsCompleted)
								{
									num = (this.<>1__state = 37);
									this.<>u__1 = awaiter38;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter38, ref this);
									return;
								}
								IL_2B23:
								awaiter38.GetResult();
								IL_2B2A:
								areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d60541", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_51));
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData = areas_Admin_Views_AccessToken_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<AccessTokenViewModel, string>(viewData, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Create, typeof(Areas_Admin_Views_AccessToken_Create)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0)), fieldof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0.ix)) }), methodof(RoleViewModel.get_Name())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter39 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter39.IsCompleted)
								{
									num = (this.<>1__state = 38);
									this.<>u__1 = awaiter39;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter39, ref this);
									return;
								}
								IL_2D43:
								awaiter39.GetResult();
								if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_2DC0;
								}
								awaiter40 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter40.IsCompleted)
								{
									num = (this.<>1__state = 39);
									this.<>u__1 = awaiter40;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter40, ref this);
									return;
								}
								IL_2DB9:
								awaiter40.GetResult();
								IL_2DC0:
								areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d62383", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_53));
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData2 = areas_Admin_Views_AccessToken_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<AccessTokenViewModel, string>(viewData2, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Create, typeof(Areas_Admin_Views_AccessToken_Create)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0)), fieldof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0.ix)) }), methodof(RoleViewModel.get_Title())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter41 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter41.IsCompleted)
								{
									num = (this.<>1__state = 40);
									this.<>u__1 = awaiter41;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter41, ref this);
									return;
								}
								IL_2FD9:
								awaiter41.GetResult();
								if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_3056;
								}
								awaiter42 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter42.IsCompleted)
								{
									num = (this.<>1__state = 41);
									this.<>u__1 = awaiter42;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter42, ref this);
									return;
								}
								IL_304F:
								awaiter42.GetResult();
								IL_3056:
								areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                                        ");
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d64226", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_55));
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData3 = areas_Admin_Views_AccessToken_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<AccessTokenViewModel, string>(viewData3, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Create, typeof(Areas_Admin_Views_AccessToken_Create)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0)), fieldof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0.ix)) }), methodof(RoleViewModel.get_ModuleId())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter43 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter43.IsCompleted)
								{
									num = (this.<>1__state = 42);
									this.<>u__1 = awaiter43;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter43, ref this);
									return;
								}
								IL_326F:
								awaiter43.GetResult();
								if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
								{
									goto IL_32EC;
								}
								awaiter44 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
								if (!awaiter44.IsCompleted)
								{
									num = (this.<>1__state = 43);
									this.<>u__1 = awaiter44;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter44, ref this);
									return;
								}
								IL_32E5:
								awaiter44.GetResult();
								IL_32EC:
								areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
								areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                                        <span class=\"slider round\"></span>\r\n                                                                    </label>\r\n                                                                </div>\r\n");
								IL_3319:
								if (this.<>7__wrap2.MoveNext())
								{
									RoleViewModel role = this.<>7__wrap2.Current;
									int ix = this.<>8__1.ix;
									this.<>8__1.ix = ix + 1;
									areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                                <div class=\"col-4\">\r\n                                                                    ");
									areas_Admin_Views_AccessToken_Create.Write(role.Title);
									areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                                    <label class=\"switch mt-1 me-1\">\r\n                                                                        ");
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d58393", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_49));
									areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
									areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_21.Value;
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_21);
									InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
									IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
									ViewDataDictionary<AccessTokenViewModel> viewData4 = areas_Admin_Views_AccessToken_Create.ViewData;
									parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
									_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider4.CreateModelExpression<AccessTokenViewModel, bool>(viewData4, Expression.Lambda<Func<AccessTokenViewModel, bool>>(Expression.Property(Expression.Call(Expression.Property(Expression.Property(Expression.Property(Expression.Constant(areas_Admin_Views_AccessToken_Create, typeof(Areas_Admin_Views_AccessToken_Create)), methodof(RazorPage<AccessTokenViewModel>.get_Model())), methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_Items())), methodof(List<RoleViewModel>.get_Item(int)), new Expression[] { Expression.Field(Expression.Constant(this.<>8__1, typeof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0)), fieldof(Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0.ix)) }), methodof(RoleViewModel.get_IsSelected())), new ParameterExpression[] { parameterExpression }));
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_22);
									areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_23.Value;
									areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_23);
									awaiter37 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
									if (!awaiter37.IsCompleted)
									{
										num = (this.<>1__state = 36);
										this.<>u__1 = awaiter37;
										this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter37, ref this);
										return;
									}
									goto IL_2AAD;
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
							areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                        </div>\r\n                                                    </fieldset>\r\n");
							IL_3355:
							if (this.<>7__wrap1.MoveNext())
							{
								IGrouping<string, RoleViewModel> rolesByModule = this.<>7__wrap1.Current;
								areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                    <fieldset class=\"border mb-2 p-2\">\r\n                                                        <legend class=\"w-auto px-2 text-secondary h6\">");
								areas_Admin_Views_AccessToken_Create.Write(rolesByModule.Key);
								areas_Admin_Views_AccessToken_Create.WriteLiteral("</legend>\r\n                                                        <div class=\"row\">\r\n");
								this.<>7__wrap2 = rolesByModule.GetEnumerator();
								goto IL_280C;
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
						areas_Admin_Views_AccessToken_Create.WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!--End roles -->\r\n                        <!--Open Session -->\r\n                        <div class=\"form-group mt-3\">\r\n                            <label>Hopex session</label>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d67502", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_38));
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
						ViewDataDictionary<AccessTokenViewModel> viewData5 = areas_Admin_Views_AccessToken_Create.ViewData;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider5.CreateModelExpression<AccessTokenViewModel, string>(viewData5, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_13);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_18.Value;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_18);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_24);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_16);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_25);
						awaiter45 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter45.IsCompleted)
						{
							num = (this.<>1__state = 44);
							this.<>u__1 = awaiter45;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter45, ref this);
							return;
						}
						goto IL_3551;
					}
					case 44:
						awaiter45 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3551;
					case 45:
						awaiter46 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_35C7;
					case 46:
						awaiter47 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_37BB;
					case 47:
						awaiter48 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3831;
					case 48:
						awaiter49 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3A8B;
					case 49:
						awaiter50 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3B01;
					case 50:
						awaiter51 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3C71;
					case 51:
						awaiter52 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3CE7;
					case 52:
						awaiter53 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3E76;
					case 53:
						awaiter54 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_3EEC;
					case 54:
					case 55:
						IL_3F41:
						try
						{
							TaskAwaiter awaiter55;
							TaskAwaiter awaiter56;
							if (num != 54)
							{
								if (num != 55)
								{
									goto IL_424A;
								}
								awaiter55 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								num = (this.<>1__state = -1);
								goto IL_41EE;
							}
							else
							{
								awaiter56 = this.<>u__1;
								this.<>u__1 = default(TaskAwaiter);
								num = (this.<>1__state = -1);
							}
							IL_4178:
							awaiter56.GetResult();
							if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
							{
								goto IL_41F5;
							}
							awaiter55 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
							if (!awaiter55.IsCompleted)
							{
								num = (this.<>1__state = 55);
								this.<>u__1 = awaiter55;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter55, ref this);
								return;
							}
							IL_41EE:
							awaiter55.GetResult();
							IL_41F5:
							areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
							areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n");
							areas_Admin_Views_AccessToken_Create.Write(this.<sessionMode>5__5.Value);
							areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                    <br />\r\n");
							this.<sessionMode>5__5 = default(KeyValuePair<string, string>);
							IL_424A:
							if (this.<>7__wrap3.MoveNext())
							{
								this.<sessionMode>5__5 = this.<>7__wrap3.Current;
								areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                    ");
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d83568", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_58));
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
								areas_Admin_Views_AccessToken_Create.BeginAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext, "id", 2, HtmlAttributeValueStyle.DoubleQuotes);
								areas_Admin_Views_AccessToken_Create.AddHtmlAttributeValue("", 13295, "ConnectionMode_", 13295, 15, true);
								areas_Admin_Views_AccessToken_Create.AddHtmlAttributeValue("", 13310, this.<sessionMode>5__5.Key, 13310, 16, false);
								areas_Admin_Views_AccessToken_Create.EndAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext);
								InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
								IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
								ViewDataDictionary<AccessTokenViewModel> viewData6 = areas_Admin_Views_AccessToken_Create.ViewData;
								parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
								_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider6.CreateModelExpression<AccessTokenViewModel, string>(viewData6, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_SessionMode())), new ParameterExpression[] { parameterExpression }));
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
								areas_Admin_Views_AccessToken_Create.BeginWriteTagHelperAttribute();
								areas_Admin_Views_AccessToken_Create.WriteLiteral(this.<sessionMode>5__5.Key);
								areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Create.EndWriteTagHelperAttribute();
								areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer;
								areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
								awaiter56 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
								if (!awaiter56.IsCompleted)
								{
									num = (this.<>1__state = 54);
									this.<>u__1 = awaiter56;
									this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter56, ref this);
									return;
								}
								goto IL_4178;
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
						areas_Admin_Views_AccessToken_Create.WriteLiteral("                                            </p>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"ConnectionMode\" class=\"control-label\">Connection Mode</label>\r\n                                            <p class=\"ms-4\">\r\n");
						this.<>7__wrap3 = areas_Admin_Views_AccessToken_Create.Model.ConnectionModes.GetEnumerator();
						goto IL_429F;
					case 56:
					case 57:
						goto IL_429F;
					default:
					{
						this.<>8__1 = new Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0();
						this.<>8__1.<>4__this = areas_Admin_Views_AccessToken_Create;
						areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d17120", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_3));
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
						ViewDataDictionary<AccessTokenViewModel> viewData7 = areas_Admin_Views_AccessToken_Create.ViewData;
						parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider7.CreateModelExpression<AccessTokenViewModel, string>(viewData7, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_AssignableElementId())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
						awaiter = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.<>1__state = 0);
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02EF;
					}
					awaiter2 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter2, ref this);
						return;
					}
					IL_02E8:
					awaiter2.GetResult();
					IL_02EF:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d18912", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_5));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData8 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider8.CreateModelExpression<AccessTokenViewModel, string>(viewData8, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Login())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter3 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (this.<>1__state = 2);
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter3, ref this);
						return;
					}
					IL_0471:
					awaiter3.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04ED;
					}
					awaiter4 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (this.<>1__state = 3);
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter4, ref this);
						return;
					}
					IL_04E6:
					awaiter4.GetResult();
					IL_04ED:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d20690", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_7));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData9 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider9.CreateModelExpression<AccessTokenViewModel, string>(viewData9, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter5 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (this.<>1__state = 4);
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter5, ref this);
						return;
					}
					IL_066F:
					awaiter5.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06EB;
					}
					awaiter6 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						num = (this.<>1__state = 5);
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter6, ref this);
						return;
					}
					IL_06E4:
					awaiter6.GetResult();
					IL_06EB:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d22469", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_9));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData10 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider10.CreateModelExpression<AccessTokenViewModel, string>(viewData10, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_RepositoryId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter7 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						num = (this.<>1__state = 6);
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter7, ref this);
						return;
					}
					IL_086D:
					awaiter7.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08E9;
					}
					awaiter8 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						num = (this.<>1__state = 7);
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter8, ref this);
						return;
					}
					IL_08E2:
					awaiter8.GetResult();
					IL_08E9:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d24254", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_11));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData11 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper11.For = modelExpressionProvider11.CreateModelExpression<AccessTokenViewModel, string>(viewData11, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ProfileId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter9 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						num = (this.<>1__state = 8);
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter9, ref this);
						return;
					}
					IL_0A6B:
					awaiter9.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0AE8;
					}
					awaiter10 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						num = (this.<>1__state = 9);
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter10, ref this);
						return;
					}
					IL_0AE1:
					awaiter10.GetResult();
					IL_0AE8:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d26036", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_13));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData12 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper12.For = modelExpressionProvider12.CreateModelExpression<AccessTokenViewModel, string>(viewData12, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_DataLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter11 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						num = (this.<>1__state = 10);
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter11, ref this);
						return;
					}
					IL_0C6B:
					awaiter11.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0CE8;
					}
					awaiter12 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						num = (this.<>1__state = 11);
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter12, ref this);
						return;
					}
					IL_0CE1:
					awaiter12.GetResult();
					IL_0CE8:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d27823", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_15));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData13 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper13.For = modelExpressionProvider13.CreateModelExpression<AccessTokenViewModel, string>(viewData13, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_GuiLanguageId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_0);
					awaiter13 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						num = (this.<>1__state = 12);
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter13, ref this);
						return;
					}
					IL_0E6B:
					awaiter13.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0EE8;
					}
					awaiter14 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						num = (this.<>1__state = 13);
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter14, ref this);
						return;
					}
					IL_0EE1:
					awaiter14.GetResult();
					IL_0EE8:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n\r\n                        ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d29613", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_17));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationSummaryTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					awaiter15 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						num = (this.<>1__state = 14);
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter15, ref this);
						return;
					}
					IL_100D:
					awaiter15.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_108A;
					}
					awaiter16 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						num = (this.<>1__state = 15);
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter16, ref this);
						return;
					}
					IL_1083:
					awaiter16.GetResult();
					IL_108A:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-6\">\r\n                                <label for=\"TokenName\" class=\"control-label\">User Name<span class=\"required\"> *</span></label>\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d31606", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_18));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData14 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper14.For = modelExpressionProvider14.CreateModelExpression<AccessTokenViewModel, string>(viewData14, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_2);
					awaiter17 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter17.IsCompleted)
					{
						num = (this.<>1__state = 16);
						this.<>u__1 = awaiter17;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter17, ref this);
						return;
					}
					IL_11F3:
					awaiter17.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1270;
					}
					awaiter18 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						num = (this.<>1__state = 17);
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter18, ref this);
						return;
					}
					IL_1269:
					awaiter18.GetResult();
					IL_1270:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d33267", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_20));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData15 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider15.CreateModelExpression<AccessTokenViewModel, string>(viewData15, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_TokenName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_3);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_4);
					awaiter19 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter19.IsCompleted)
					{
						num = (this.<>1__state = 18);
						this.<>u__1 = awaiter19;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter19, ref this);
						return;
					}
					IL_13F9:
					awaiter19.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1476;
					}
					awaiter20 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						num = (this.<>1__state = 19);
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter20, ref this);
						return;
					}
					IL_146F:
					awaiter20.GetResult();
					IL_1476:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Password\" class=\"control-label\">Password<span class=\"required\"> *</span></label>\r\n");
					string content = string.Concat(new string[]
					{
						"The password must:<br/>\r\n                            <ul>\r\n                            <li>include at least ",
						areas_Admin_Views_AccessToken_Create.Model.Settings.RequiredLength.ToString(),
						" characters",
						areas_Admin_Views_AccessToken_Create.Model.Settings.RequireUppercase ? ", one uppercase" : "",
						areas_Admin_Views_AccessToken_Create.Model.Settings.RequireLowercase ? ", one lowercase" : "",
						areas_Admin_Views_AccessToken_Create.Model.Settings.RequireDigit ? ", one digit" : "",
						areas_Admin_Views_AccessToken_Create.Model.Settings.RequireNonAlphanumeric ? ", one special character" : "",
						"</li>\r\n                            <li>not use any sequence of characters (e.g; 12345, qwert) nor contextual words (e.g.: hopex, mega)</li>\r\n                            <li>be complex enough to meet your enterprise security requirements</li>\r\n                            </ul>\r\n                            "
					});
					areas_Admin_Views_AccessToken_Create.WriteLiteral("                            <span data-bs-toggle=\"popover\" data-bs-html=\"true\" data-bs-trigger=\"hover\" title=\"Password policy\" data-bs-content=\"");
					areas_Admin_Views_AccessToken_Create.Write(content);
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\"><i class=\"fa fa-question-circle\" aria-hidden=\"true\"></i></span>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-6 pe-0\">\r\n                                    ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d37099", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_22));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData16 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper15.For = modelExpressionProvider16.CreateModelExpression<AccessTokenViewModel, string>(viewData16, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_5);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_6);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_7.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_7);
					awaiter21 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						num = (this.<>1__state = 20);
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter21, ref this);
						return;
					}
					IL_16FA:
					awaiter21.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1777;
					}
					awaiter22 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						num = (this.<>1__state = 21);
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter22, ref this);
						return;
					}
					IL_1770:
					awaiter22.GetResult();
					IL_1777:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-6\">\r\n                                    <button class=\"btn btn-primary\" id=\"generatePassword\" type=\"button\">Generate</button>\r\n                                </div>\r\n                            </div>\r\n                            <label>\r\n                                <strong>User will be prompted to change the password at next login. This temporary password will expire in 2 days</strong><br />\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d39560", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_24));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider17 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData17 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider17.CreateModelExpression<AccessTokenViewModel, string>(viewData17, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_8);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_9);
					awaiter23 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						num = (this.<>1__state = 22);
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter23, ref this);
						return;
					}
					IL_1900:
					awaiter23.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_197D;
					}
					awaiter24 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						num = (this.<>1__state = 23);
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter24, ref this);
						return;
					}
					IL_1976:
					awaiter24.GetResult();
					IL_197D:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"CurrentAdminPassword\" class=\"control-label\">Your current password<span class=\"required\"> *</span></label>\r\n                            <div class=\"form-row\">\r\n                                <div class=\"form-group col-6\">\r\n                                    ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d41870", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_26));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider18 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData18 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper16.For = modelExpressionProvider18.CreateModelExpression<AccessTokenViewModel, string>(viewData18, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CurrentAdminPassword())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_5);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_6);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_7.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_7);
					awaiter25 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						num = (this.<>1__state = 24);
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter25, ref this);
						return;
					}
					IL_1B20:
					awaiter25.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1B9D;
					}
					awaiter26 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						num = (this.<>1__state = 25);
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter26, ref this);
						return;
					}
					IL_1B96:
					awaiter26.GetResult();
					IL_1B9D:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <label>\r\n                                <small>In order to create or edit an user account you must enter your password</small><br />\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d44083", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_28));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider19 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData19 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider19.CreateModelExpression<AccessTokenViewModel, string>(viewData19, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CurrentAdminPassword())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_10);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_11);
					awaiter27 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter27.IsCompleted)
					{
						num = (this.<>1__state = 26);
						this.<>u__1 = awaiter27;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter27, ref this);
						return;
					}
					IL_1D26:
					awaiter27.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1DA3;
					}
					awaiter28 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter28.IsCompleted)
					{
						num = (this.<>1__state = 27);
						this.<>u__1 = awaiter28;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter28, ref this);
						return;
					}
					IL_1D9C:
					awaiter28.GetResult();
					IL_1DA3:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-6\">\r\n                                <label for=\"Description\" class=\"control-label\">Description</label>\r\n                            ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d46281", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_30));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider20 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData20 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper17.For = modelExpressionProvider20.CreateModelExpression<AccessTokenViewModel, string>(viewData20, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Create.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_AccessToken_Create.Html.Raw(areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_2);
					awaiter29 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter29.IsCompleted)
					{
						num = (this.<>1__state = 28);
						this.<>u__1 = awaiter29;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter29, ref this);
						return;
					}
					IL_1F40:
					awaiter29.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1FBD;
					}
					awaiter30 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter30.IsCompleted)
					{
						num = (this.<>1__state = 29);
						this.<>u__1 = awaiter30;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter30, ref this);
						return;
					}
					IL_1FB6:
					awaiter30.GetResult();
					IL_1FBD:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                            ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d48262", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_32));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider21 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData21 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider21.CreateModelExpression<AccessTokenViewModel, string>(viewData21, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					awaiter31 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter31.IsCompleted)
					{
						num = (this.<>1__state = 30);
						this.<>u__1 = awaiter31;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter31, ref this);
						return;
					}
					IL_2126:
					awaiter31.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_21A3;
					}
					awaiter32 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter32.IsCompleted)
					{
						num = (this.<>1__state = 31);
						this.<>u__1 = awaiter32;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter32, ref this);
						return;
					}
					IL_219C:
					awaiter32.GetResult();
					IL_21A3:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <!--Roles -->\r\n                        <div class=\"form-group mt-3\">\r\n                            <label>Roles</label>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d50277", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_34));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider22 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData22 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper18.For = modelExpressionProvider22.CreateModelExpression<AccessTokenViewModel, string>(viewData22, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_14.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_14);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_15);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_16);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_17);
					awaiter33 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter33.IsCompleted)
					{
						num = (this.<>1__state = 32);
						this.<>u__1 = awaiter33;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter33, ref this);
						return;
					}
					IL_23A4:
					awaiter33.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_2421;
					}
					awaiter34 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter34.IsCompleted)
					{
						num = (this.<>1__state = 33);
						this.<>u__1 = awaiter34;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter34, ref this);
						return;
					}
					IL_241A:
					awaiter34.GetResult();
					IL_2421:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                <label for=\"isAdministratorYes\" class=\"form-check-label\">Administrator</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d52863", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_36));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider23 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData23 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper19.For = modelExpressionProvider23.CreateModelExpression<AccessTokenViewModel, string>(viewData23, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_Roles())), methodof(RolesViewModel.get_IsAdministrator())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_18.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_18);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_19);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_16);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_20);
					awaiter35 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter35.IsCompleted)
					{
						num = (this.<>1__state = 34);
						this.<>u__1 = awaiter35;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter35, ref this);
						return;
					}
					IL_2622:
					awaiter35.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_269F;
					}
					awaiter36 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter36.IsCompleted)
					{
						num = (this.<>1__state = 35);
						this.<>u__1 = awaiter36;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter36, ref this);
						return;
					}
					IL_2698:
					awaiter36.GetResult();
					IL_269F:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                <label for=\"isAdministratorNo\" class=\"form-check-label\">Custom</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseRoles\"");
					areas_Admin_Views_AccessToken_Create.BeginWriteAttribute("class", " class=\"", 6424, "\"", 6515, 3);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue("", 6432, "panel-collapse", 6432, 14, true);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue(" ", 6446, "collapse", 6447, 9, true);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue(" ", 6455, (areas_Admin_Views_AccessToken_Create.Model.Roles.IsAdministrator == "N") ? "show" : string.Empty, 6456, 59, false);
					areas_Admin_Views_AccessToken_Create.EndWriteAttribute();
					areas_Admin_Views_AccessToken_Create.WriteLiteral(">\r\n                                        <div class=\"form-group mt-1 col-6\">\r\n");
					this.<>8__1.ix = -1;
					this.<>7__wrap1 = areas_Admin_Views_AccessToken_Create.Model.Roles.Items.GroupBy(new Func<RoleViewModel, string>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_48)).GetEnumerator();
					goto IL_27C2;
					IL_3551:
					awaiter45.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_35CE;
					}
					awaiter46 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter46.IsCompleted)
					{
						num = (this.<>1__state = 45);
						this.<>u__1 = awaiter46;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter46, ref this);
						return;
					}
					IL_35C7:
					awaiter46.GetResult();
					IL_35CE:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                <label for=\"canOpenSessionYes\" class=\"form-check-label\">No session</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.StartTagOnly, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d70078", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_40));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper20 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider24 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData24 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper20.For = modelExpressionProvider24.CreateModelExpression<AccessTokenViewModel, string>(viewData24, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_CanOpenSession())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_13);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_14.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_14);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_26);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_16);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_27);
					awaiter47 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter47.IsCompleted)
					{
						num = (this.<>1__state = 46);
						this.<>u__1 = awaiter47;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter47, ref this);
						return;
					}
					IL_37BB:
					awaiter47.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3838;
					}
					awaiter48 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter48.IsCompleted)
					{
						num = (this.<>1__state = 47);
						this.<>u__1 = awaiter48;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter48, ref this);
						return;
					}
					IL_3831:
					awaiter48.GetResult();
					IL_3838:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                <label for=\"canOpenSessionNo\" class=\"form-check-label\">Open session</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseSession\"");
					areas_Admin_Views_AccessToken_Create.BeginWriteAttribute("class", " class=\"", 10304, "\"", 10388, 3);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue("", 10312, "panel-collapse", 10312, 14, true);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue(" ", 10326, "collapse", 10327, 9, true);
					areas_Admin_Views_AccessToken_Create.WriteAttributeValue(" ", 10335, (areas_Admin_Views_AccessToken_Create.Model.CanOpenSession == "Y") ? "show" : string.Empty, 10336, 52, false);
					areas_Admin_Views_AccessToken_Create.EndWriteAttribute();
					areas_Admin_Views_AccessToken_Create.WriteLiteral(">\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"UserName\" class=\"control-label\">HOPEX login<span class=\"required\"> *</span></label>\r\n                                            ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d73669", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_42));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper21 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider25 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData25 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper21.For = modelExpressionProvider25.CreateModelExpression<AccessTokenViewModel, string>(viewData25, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.BeginWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Create.EndWriteTagHelperAttribute();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute("checked", areas_Admin_Views_AccessToken_Create.Html.Raw(areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_2);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_28);
					awaiter49 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter49.IsCompleted)
					{
						num = (this.<>1__state = 48);
						this.<>u__1 = awaiter49;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter49, ref this);
						return;
					}
					IL_3A8B:
					awaiter49.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3B08;
					}
					awaiter50 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter50.IsCompleted)
					{
						num = (this.<>1__state = 49);
						this.<>u__1 = awaiter50;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter50, ref this);
						return;
					}
					IL_3B01:
					awaiter50.GetResult();
					IL_3B08:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                            ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d75752", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_44));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ValidationMessageTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
					ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
					IModelExpressionProvider modelExpressionProvider26 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData26 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider26.CreateModelExpression<AccessTokenViewModel, string>(viewData26, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_1);
					awaiter51 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter51.IsCompleted)
					{
						num = (this.<>1__state = 50);
						this.<>u__1 = awaiter51;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter51, ref this);
						return;
					}
					IL_3C71:
					awaiter51.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3CEE;
					}
					awaiter52 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter52.IsCompleted)
					{
						num = (this.<>1__state = 51);
						this.<>u__1 = awaiter52;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter52, ref this);
						return;
					}
					IL_3CE7:
					awaiter52.GetResult();
					IL_3CEE:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"EnvironmentId\" class=\"control-label\">EnvironmentId<span class=\"required\"> *</span></label>\r\n                                            ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d77772", new Func<Task>(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_46));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<SelectTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					IModelExpressionProvider modelExpressionProvider27 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
					ViewDataDictionary<AccessTokenViewModel> viewData27 = areas_Admin_Views_AccessToken_Create.ViewData;
					parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider27.CreateModelExpression<AccessTokenViewModel, string>(viewData27, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = areas_Admin_Views_AccessToken_Create.Model.Environments;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_30);
					awaiter53 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter53.IsCompleted)
					{
						num = (this.<>1__state = 52);
						this.<>u__1 = awaiter53;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter53, ref this);
						return;
					}
					IL_3E76:
					awaiter53.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_3EF3;
					}
					awaiter54 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter54.IsCompleted)
					{
						num = (this.<>1__state = 53);
						this.<>u__1 = awaiter54;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter54, ref this);
						return;
					}
					IL_3EEC:
					awaiter54.GetResult();
					IL_3EF3:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group\" id=\"PersonGroups-group\">\r\n                                            <label for=\"PersonGroups\" class=\"control-label\">Person<span class=\"required\"> *</span></label>\r\n                                            <select id=\"PersonGroups\" class=\"select2_single form-select col-6\">\r\n                                            </select>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group\" id=\"Repositories-group\">\r\n                                            <label for=\"Repositories\" class=\"control-label\">Repositories<span class=\"required\"> *</span></label>\r\n                                            <select id=\"Repositories\" name=\"Repositories\" class=\"select2_single form-select col-6\">\r\n                                            </select>\r\n                                        </div>\r\n\r\n                                        <div class");
					areas_Admin_Views_AccessToken_Create.WriteLiteral("=\"form-group\" id=\"Profiles-group\">\r\n                                            <label for=\"Profiles\" class=\"control-label\">Profiles<span class=\"required\"> *</span></label>\r\n                                            <select id=\"Profiles\" name=\"Profiles\" class=\"select2_single form-select col-6\">\r\n                                            </select>\r\n                                        </div>\r\n\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"SessionMode\" class=\"control-label\">Session Mode</label>\r\n                                            <p class=\"ms-4\">\r\n");
					this.<>7__wrap3 = areas_Admin_Views_AccessToken_Create.Model.SessionModes.GetEnumerator();
					goto IL_3F41;
					IL_429F:
					try
					{
						TaskAwaiter awaiter57;
						TaskAwaiter awaiter58;
						if (num != 56)
						{
							if (num != 57)
							{
								goto IL_45A8;
							}
							awaiter57 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_454C;
						}
						else
						{
							awaiter58 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
						}
						IL_44D6:
						awaiter58.GetResult();
						if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_4553;
						}
						awaiter57 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter57.IsCompleted)
						{
							num = (this.<>1__state = 57);
							this.<>u__1 = awaiter57;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter57, ref this);
							return;
						}
						IL_454C:
						awaiter57.GetResult();
						IL_4553:
						areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
						areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n");
						areas_Admin_Views_AccessToken_Create.Write(this.<sessionMode>5__5.Value);
						areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                    <br />\r\n");
						this.<sessionMode>5__5 = default(KeyValuePair<string, string>);
						IL_45A8:
						if (this.<>7__wrap3.MoveNext())
						{
							this.<sessionMode>5__5 = this.<>7__wrap3.Current;
							areas_Admin_Views_AccessToken_Create.WriteLiteral("                                                    ");
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d88032", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_60));
							areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<InputTagHelper>();
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
							areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12.Value;
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_12);
							areas_Admin_Views_AccessToken_Create.BeginAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext, "id", 2, HtmlAttributeValueStyle.DoubleQuotes);
							areas_Admin_Views_AccessToken_Create.AddHtmlAttributeValue("", 14143, "ConnectionMode_", 14143, 15, true);
							areas_Admin_Views_AccessToken_Create.AddHtmlAttributeValue("", 14158, this.<sessionMode>5__5.Key, 14158, 19, false);
							areas_Admin_Views_AccessToken_Create.EndAddHtmlAttributeValues(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext);
							InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper22 = areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
							IModelExpressionProvider modelExpressionProvider28 = areas_Admin_Views_AccessToken_Create.ModelExpressionProvider;
							ViewDataDictionary<AccessTokenViewModel> viewData28 = areas_Admin_Views_AccessToken_Create.ViewData;
							parameterExpression = Expression.Parameter(typeof(AccessTokenViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper22.For = modelExpressionProvider28.CreateModelExpression<AccessTokenViewModel, string>(viewData28, Expression.Lambda<Func<AccessTokenViewModel, string>>(Expression.Property(parameterExpression, methodof(InputAccessTokenViewModel.get_ConnectionMode())), new ParameterExpression[] { parameterExpression }));
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							areas_Admin_Views_AccessToken_Create.BeginWriteTagHelperAttribute();
							areas_Admin_Views_AccessToken_Create.WriteLiteral(this.<sessionMode>5__5.Key);
							areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Create.EndWriteTagHelperAttribute();
							areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer;
							areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("value", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter58 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter58.IsCompleted)
							{
								num = (this.<>1__state = 56);
								this.<>u__1 = awaiter58;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_0>d>(ref awaiter58, ref this);
								return;
							}
							goto IL_44D6;
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
					areas_Admin_Views_AccessToken_Create.WriteLiteral("                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!-- End Open Session -->\r\n\r\n                        <div class=\"ln_solid\"></div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-offset-3\">\r\n                                <button class=\"btn btn-primary pull-right\" type=\"submit\" id=\"btnSubmit\" disabled>\r\n                                    <span id=\"loading\" class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                                    Submit\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    ");
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

			// Token: 0x060008AB RID: 2219 RVA: 0x000204C0 File Offset: 0x0001E6C0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005DE RID: 1502
			public int <>1__state;

			// Token: 0x040005DF RID: 1503
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005E0 RID: 1504
			public Areas_Admin_Views_AccessToken_Create <>4__this;

			// Token: 0x040005E1 RID: 1505
			private Areas_Admin_Views_AccessToken_Create.<>c__DisplayClass50_0 <>8__1;

			// Token: 0x040005E2 RID: 1506
			private TaskAwaiter <>u__1;

			// Token: 0x040005E3 RID: 1507
			[global::System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1, 0, 0 })]
			private IEnumerator<IGrouping<string, RoleViewModel>> <>7__wrap1;

			// Token: 0x040005E4 RID: 1508
			private IEnumerator<RoleViewModel> <>7__wrap2;

			// Token: 0x040005E5 RID: 1509
			private Dictionary<string, string>.Enumerator <>7__wrap3;

			// Token: 0x040005E6 RID: 1510
			private KeyValuePair<string, string> <sessionMode>5__5;
		}

		// Token: 0x020000E2 RID: 226
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_1>d : IAsyncStateMachine
		{
			// Token: 0x060008AC RID: 2220 RVA: 0x000204D0 File Offset: 0x0001E6D0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/uas/lib/jqueryui/themes/base/jquery-ui.min.css\" />\r\n");
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

			// Token: 0x060008AD RID: 2221 RVA: 0x00020534 File Offset: 0x0001E734
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005E7 RID: 1511
			public int <>1__state;

			// Token: 0x040005E8 RID: 1512
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005E9 RID: 1513
			public Areas_Admin_Views_AccessToken_Create <>4__this;
		}

		// Token: 0x020000E3 RID: 227
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_2>d : IAsyncStateMachine
		{
			// Token: 0x060008AE RID: 2222 RVA: 0x00020544 File Offset: 0x0001E744
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
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
						areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n    ");
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d94682", new Func<Task>(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_62));
						areas_Admin_Views_AccessToken_Create.__HAS_Server_TagHelpers_NonceTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<NonceTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__HAS_Server_TagHelpers_NonceTagHelper);
						areas_Admin_Views_AccessToken_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce = true;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-add-nonce", areas_Admin_Views_AccessToken_Create.__HAS_Server_TagHelpers_NonceTagHelper.AddNonce, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0181;
					}
					awaiter2 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter2, ref this);
						return;
					}
					IL_017A:
					awaiter2.GetResult();
					IL_0181:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n    <script src=\"/uas/lib/jqueryui/jquery-ui.min.js\"></script>\r\n    ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d96485", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_63));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_33.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_33);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter3 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter3, ref this);
						return;
					}
					IL_02C4:
					awaiter3.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0340;
					}
					awaiter4 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter4, ref this);
						return;
					}
					IL_0339:
					awaiter4.GetResult();
					IL_0340:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n    ");
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d98203", new Func<Task>(Areas_Admin_Views_AccessToken_Create.<>c.<>9.<ExecuteAsync>b__50_64));
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<ScriptTagHelper>();
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_34.Value;
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_34);
					areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter5 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter5, ref this);
						return;
					}
					IL_0483:
					awaiter5.GetResult();
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04FC;
					}
					awaiter6 = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_2>d>(ref awaiter6, ref this);
						return;
					}
					IL_04F5:
					awaiter6.GetResult();
					IL_04FC:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n");
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

			// Token: 0x060008AF RID: 2223 RVA: 0x00020AC4 File Offset: 0x0001ECC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005EA RID: 1514
			public int <>1__state;

			// Token: 0x040005EB RID: 1515
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005EC RID: 1516
			public Areas_Admin_Views_AccessToken_Create <>4__this;

			// Token: 0x040005ED RID: 1517
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000E4 RID: 228
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_46>d : IAsyncStateMachine
		{
			// Token: 0x060008B0 RID: 2224 RVA: 0x00020AD4 File Offset: 0x0001ECD4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
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
						areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                                ");
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d78113", new Func<Task>(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_57));
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<OptionTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_29.Value;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_29);
						awaiter2 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_46>d>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_016A;
					}
					awaiter = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<<ExecuteAsync>b__50_46>d>(ref awaiter, ref this);
						return;
					}
					IL_0163:
					awaiter.GetResult();
					IL_016A:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                                            ");
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

			// Token: 0x060008B1 RID: 2225 RVA: 0x00020CC4 File Offset: 0x0001EEC4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005EE RID: 1518
			public int <>1__state;

			// Token: 0x040005EF RID: 1519
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005F0 RID: 1520
			public Areas_Admin_Views_AccessToken_Create <>4__this;

			// Token: 0x040005F1 RID: 1521
			private TaskAwaiter <>u__1;
		}

		// Token: 0x020000E5 RID: 229
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_57>d : IAsyncStateMachine
		{
			// Token: 0x060008B2 RID: 2226 RVA: 0x00020CD4 File Offset: 0x0001EED4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Create.WriteLiteral("Select an environment...");
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

			// Token: 0x060008B3 RID: 2227 RVA: 0x00020D38 File Offset: 0x0001EF38
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005F2 RID: 1522
			public int <>1__state;

			// Token: 0x040005F3 RID: 1523
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005F4 RID: 1524
			public Areas_Admin_Views_AccessToken_Create <>4__this;
		}

		// Token: 0x020000E6 RID: 230
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__50_62>d : IAsyncStateMachine
		{
			// Token: 0x060008B4 RID: 2228 RVA: 0x00020D48 File Offset: 0x0001EF48
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
				try
				{
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n        $(function () {\r\n            $('[data-bs-toggle=\"popover\"]').popover()\r\n        })\r\n\r\n        var editMode = false;\r\n        $(document).ready(function () {\r\n            $(\"#generatePassword\").on(\"click\", generatePassword)\r\n        });\r\n    ");
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

			// Token: 0x060008B5 RID: 2229 RVA: 0x00020DAC File Offset: 0x0001EFAC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040005F5 RID: 1525
			public int <>1__state;

			// Token: 0x040005F6 RID: 1526
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040005F7 RID: 1527
			public Areas_Admin_Views_AccessToken_Create <>4__this;
		}

		// Token: 0x020000E7 RID: 231
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060008B8 RID: 2232 RVA: 0x00020DD0 File Offset: 0x0001EFD0
			internal Task <ExecuteAsync>b__50_3()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_3>d <<ExecuteAsync>b__50_3>d;
				<<ExecuteAsync>b__50_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_3>d.<>1__state = -1;
				<<ExecuteAsync>b__50_3>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_3>d>(ref <<ExecuteAsync>b__50_3>d);
				return <<ExecuteAsync>b__50_3>d.<>t__builder.Task;
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x00020E0C File Offset: 0x0001F00C
			internal Task <ExecuteAsync>b__50_5()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_5>d <<ExecuteAsync>b__50_5>d;
				<<ExecuteAsync>b__50_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_5>d.<>1__state = -1;
				<<ExecuteAsync>b__50_5>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_5>d>(ref <<ExecuteAsync>b__50_5>d);
				return <<ExecuteAsync>b__50_5>d.<>t__builder.Task;
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x00020E48 File Offset: 0x0001F048
			internal Task <ExecuteAsync>b__50_7()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_7>d <<ExecuteAsync>b__50_7>d;
				<<ExecuteAsync>b__50_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_7>d.<>1__state = -1;
				<<ExecuteAsync>b__50_7>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_7>d>(ref <<ExecuteAsync>b__50_7>d);
				return <<ExecuteAsync>b__50_7>d.<>t__builder.Task;
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x00020E84 File Offset: 0x0001F084
			internal Task <ExecuteAsync>b__50_9()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_9>d <<ExecuteAsync>b__50_9>d;
				<<ExecuteAsync>b__50_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_9>d.<>1__state = -1;
				<<ExecuteAsync>b__50_9>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_9>d>(ref <<ExecuteAsync>b__50_9>d);
				return <<ExecuteAsync>b__50_9>d.<>t__builder.Task;
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x00020EC0 File Offset: 0x0001F0C0
			internal Task <ExecuteAsync>b__50_11()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_11>d <<ExecuteAsync>b__50_11>d;
				<<ExecuteAsync>b__50_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_11>d.<>1__state = -1;
				<<ExecuteAsync>b__50_11>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_11>d>(ref <<ExecuteAsync>b__50_11>d);
				return <<ExecuteAsync>b__50_11>d.<>t__builder.Task;
			}

			// Token: 0x060008BD RID: 2237 RVA: 0x00020EFC File Offset: 0x0001F0FC
			internal Task <ExecuteAsync>b__50_13()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_13>d <<ExecuteAsync>b__50_13>d;
				<<ExecuteAsync>b__50_13>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_13>d.<>1__state = -1;
				<<ExecuteAsync>b__50_13>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_13>d>(ref <<ExecuteAsync>b__50_13>d);
				return <<ExecuteAsync>b__50_13>d.<>t__builder.Task;
			}

			// Token: 0x060008BE RID: 2238 RVA: 0x00020F38 File Offset: 0x0001F138
			internal Task <ExecuteAsync>b__50_15()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_15>d <<ExecuteAsync>b__50_15>d;
				<<ExecuteAsync>b__50_15>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_15>d.<>1__state = -1;
				<<ExecuteAsync>b__50_15>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_15>d>(ref <<ExecuteAsync>b__50_15>d);
				return <<ExecuteAsync>b__50_15>d.<>t__builder.Task;
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x00020F74 File Offset: 0x0001F174
			internal Task <ExecuteAsync>b__50_17()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_17>d <<ExecuteAsync>b__50_17>d;
				<<ExecuteAsync>b__50_17>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_17>d.<>1__state = -1;
				<<ExecuteAsync>b__50_17>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_17>d>(ref <<ExecuteAsync>b__50_17>d);
				return <<ExecuteAsync>b__50_17>d.<>t__builder.Task;
			}

			// Token: 0x060008C0 RID: 2240 RVA: 0x00020FB0 File Offset: 0x0001F1B0
			internal Task <ExecuteAsync>b__50_18()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_18>d <<ExecuteAsync>b__50_18>d;
				<<ExecuteAsync>b__50_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_18>d.<>1__state = -1;
				<<ExecuteAsync>b__50_18>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_18>d>(ref <<ExecuteAsync>b__50_18>d);
				return <<ExecuteAsync>b__50_18>d.<>t__builder.Task;
			}

			// Token: 0x060008C1 RID: 2241 RVA: 0x00020FEC File Offset: 0x0001F1EC
			internal Task <ExecuteAsync>b__50_20()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_20>d <<ExecuteAsync>b__50_20>d;
				<<ExecuteAsync>b__50_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_20>d.<>1__state = -1;
				<<ExecuteAsync>b__50_20>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_20>d>(ref <<ExecuteAsync>b__50_20>d);
				return <<ExecuteAsync>b__50_20>d.<>t__builder.Task;
			}

			// Token: 0x060008C2 RID: 2242 RVA: 0x00021028 File Offset: 0x0001F228
			internal Task <ExecuteAsync>b__50_22()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_22>d <<ExecuteAsync>b__50_22>d;
				<<ExecuteAsync>b__50_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_22>d.<>1__state = -1;
				<<ExecuteAsync>b__50_22>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_22>d>(ref <<ExecuteAsync>b__50_22>d);
				return <<ExecuteAsync>b__50_22>d.<>t__builder.Task;
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x00021064 File Offset: 0x0001F264
			internal Task <ExecuteAsync>b__50_24()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_24>d <<ExecuteAsync>b__50_24>d;
				<<ExecuteAsync>b__50_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_24>d.<>1__state = -1;
				<<ExecuteAsync>b__50_24>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_24>d>(ref <<ExecuteAsync>b__50_24>d);
				return <<ExecuteAsync>b__50_24>d.<>t__builder.Task;
			}

			// Token: 0x060008C4 RID: 2244 RVA: 0x000210A0 File Offset: 0x0001F2A0
			internal Task <ExecuteAsync>b__50_26()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_26>d <<ExecuteAsync>b__50_26>d;
				<<ExecuteAsync>b__50_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_26>d.<>1__state = -1;
				<<ExecuteAsync>b__50_26>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_26>d>(ref <<ExecuteAsync>b__50_26>d);
				return <<ExecuteAsync>b__50_26>d.<>t__builder.Task;
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x000210DC File Offset: 0x0001F2DC
			internal Task <ExecuteAsync>b__50_28()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_28>d <<ExecuteAsync>b__50_28>d;
				<<ExecuteAsync>b__50_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_28>d.<>1__state = -1;
				<<ExecuteAsync>b__50_28>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_28>d>(ref <<ExecuteAsync>b__50_28>d);
				return <<ExecuteAsync>b__50_28>d.<>t__builder.Task;
			}

			// Token: 0x060008C6 RID: 2246 RVA: 0x00021118 File Offset: 0x0001F318
			internal Task <ExecuteAsync>b__50_30()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_30>d <<ExecuteAsync>b__50_30>d;
				<<ExecuteAsync>b__50_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_30>d.<>1__state = -1;
				<<ExecuteAsync>b__50_30>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_30>d>(ref <<ExecuteAsync>b__50_30>d);
				return <<ExecuteAsync>b__50_30>d.<>t__builder.Task;
			}

			// Token: 0x060008C7 RID: 2247 RVA: 0x00021154 File Offset: 0x0001F354
			internal Task <ExecuteAsync>b__50_32()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_32>d <<ExecuteAsync>b__50_32>d;
				<<ExecuteAsync>b__50_32>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_32>d.<>1__state = -1;
				<<ExecuteAsync>b__50_32>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_32>d>(ref <<ExecuteAsync>b__50_32>d);
				return <<ExecuteAsync>b__50_32>d.<>t__builder.Task;
			}

			// Token: 0x060008C8 RID: 2248 RVA: 0x00021190 File Offset: 0x0001F390
			internal Task <ExecuteAsync>b__50_34()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_34>d <<ExecuteAsync>b__50_34>d;
				<<ExecuteAsync>b__50_34>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_34>d.<>1__state = -1;
				<<ExecuteAsync>b__50_34>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_34>d>(ref <<ExecuteAsync>b__50_34>d);
				return <<ExecuteAsync>b__50_34>d.<>t__builder.Task;
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x000211CC File Offset: 0x0001F3CC
			internal Task <ExecuteAsync>b__50_36()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_36>d <<ExecuteAsync>b__50_36>d;
				<<ExecuteAsync>b__50_36>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_36>d.<>1__state = -1;
				<<ExecuteAsync>b__50_36>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_36>d>(ref <<ExecuteAsync>b__50_36>d);
				return <<ExecuteAsync>b__50_36>d.<>t__builder.Task;
			}

			// Token: 0x060008CA RID: 2250 RVA: 0x00021207 File Offset: 0x0001F407
			internal string <ExecuteAsync>b__50_48(RoleViewModel r)
			{
				return r.ModuleId;
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x00021210 File Offset: 0x0001F410
			internal Task <ExecuteAsync>b__50_49()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_49>d <<ExecuteAsync>b__50_49>d;
				<<ExecuteAsync>b__50_49>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_49>d.<>1__state = -1;
				<<ExecuteAsync>b__50_49>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_49>d>(ref <<ExecuteAsync>b__50_49>d);
				return <<ExecuteAsync>b__50_49>d.<>t__builder.Task;
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x0002124C File Offset: 0x0001F44C
			internal Task <ExecuteAsync>b__50_51()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_51>d <<ExecuteAsync>b__50_51>d;
				<<ExecuteAsync>b__50_51>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_51>d.<>1__state = -1;
				<<ExecuteAsync>b__50_51>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_51>d>(ref <<ExecuteAsync>b__50_51>d);
				return <<ExecuteAsync>b__50_51>d.<>t__builder.Task;
			}

			// Token: 0x060008CD RID: 2253 RVA: 0x00021288 File Offset: 0x0001F488
			internal Task <ExecuteAsync>b__50_53()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_53>d <<ExecuteAsync>b__50_53>d;
				<<ExecuteAsync>b__50_53>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_53>d.<>1__state = -1;
				<<ExecuteAsync>b__50_53>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_53>d>(ref <<ExecuteAsync>b__50_53>d);
				return <<ExecuteAsync>b__50_53>d.<>t__builder.Task;
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x000212C4 File Offset: 0x0001F4C4
			internal Task <ExecuteAsync>b__50_55()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_55>d <<ExecuteAsync>b__50_55>d;
				<<ExecuteAsync>b__50_55>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_55>d.<>1__state = -1;
				<<ExecuteAsync>b__50_55>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_55>d>(ref <<ExecuteAsync>b__50_55>d);
				return <<ExecuteAsync>b__50_55>d.<>t__builder.Task;
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x00021300 File Offset: 0x0001F500
			internal Task <ExecuteAsync>b__50_38()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_38>d <<ExecuteAsync>b__50_38>d;
				<<ExecuteAsync>b__50_38>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_38>d.<>1__state = -1;
				<<ExecuteAsync>b__50_38>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_38>d>(ref <<ExecuteAsync>b__50_38>d);
				return <<ExecuteAsync>b__50_38>d.<>t__builder.Task;
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x0002133C File Offset: 0x0001F53C
			internal Task <ExecuteAsync>b__50_40()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_40>d <<ExecuteAsync>b__50_40>d;
				<<ExecuteAsync>b__50_40>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_40>d.<>1__state = -1;
				<<ExecuteAsync>b__50_40>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_40>d>(ref <<ExecuteAsync>b__50_40>d);
				return <<ExecuteAsync>b__50_40>d.<>t__builder.Task;
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x00021378 File Offset: 0x0001F578
			internal Task <ExecuteAsync>b__50_42()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_42>d <<ExecuteAsync>b__50_42>d;
				<<ExecuteAsync>b__50_42>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_42>d.<>1__state = -1;
				<<ExecuteAsync>b__50_42>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_42>d>(ref <<ExecuteAsync>b__50_42>d);
				return <<ExecuteAsync>b__50_42>d.<>t__builder.Task;
			}

			// Token: 0x060008D2 RID: 2258 RVA: 0x000213B4 File Offset: 0x0001F5B4
			internal Task <ExecuteAsync>b__50_44()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_44>d <<ExecuteAsync>b__50_44>d;
				<<ExecuteAsync>b__50_44>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_44>d.<>1__state = -1;
				<<ExecuteAsync>b__50_44>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_44>d>(ref <<ExecuteAsync>b__50_44>d);
				return <<ExecuteAsync>b__50_44>d.<>t__builder.Task;
			}

			// Token: 0x060008D3 RID: 2259 RVA: 0x000213F0 File Offset: 0x0001F5F0
			internal Task <ExecuteAsync>b__50_58()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_58>d <<ExecuteAsync>b__50_58>d;
				<<ExecuteAsync>b__50_58>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_58>d.<>1__state = -1;
				<<ExecuteAsync>b__50_58>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_58>d>(ref <<ExecuteAsync>b__50_58>d);
				return <<ExecuteAsync>b__50_58>d.<>t__builder.Task;
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x0002142C File Offset: 0x0001F62C
			internal Task <ExecuteAsync>b__50_60()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_60>d <<ExecuteAsync>b__50_60>d;
				<<ExecuteAsync>b__50_60>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_60>d.<>1__state = -1;
				<<ExecuteAsync>b__50_60>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_60>d>(ref <<ExecuteAsync>b__50_60>d);
				return <<ExecuteAsync>b__50_60>d.<>t__builder.Task;
			}

			// Token: 0x060008D5 RID: 2261 RVA: 0x00021468 File Offset: 0x0001F668
			internal Task <ExecuteAsync>b__50_63()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_63>d <<ExecuteAsync>b__50_63>d;
				<<ExecuteAsync>b__50_63>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_63>d.<>1__state = -1;
				<<ExecuteAsync>b__50_63>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_63>d>(ref <<ExecuteAsync>b__50_63>d);
				return <<ExecuteAsync>b__50_63>d.<>t__builder.Task;
			}

			// Token: 0x060008D6 RID: 2262 RVA: 0x000214A4 File Offset: 0x0001F6A4
			internal Task <ExecuteAsync>b__50_64()
			{
				Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_64>d <<ExecuteAsync>b__50_64>d;
				<<ExecuteAsync>b__50_64>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__50_64>d.<>1__state = -1;
				<<ExecuteAsync>b__50_64>d.<>t__builder.Start<Areas_Admin_Views_AccessToken_Create.<>c.<<ExecuteAsync>b__50_64>d>(ref <<ExecuteAsync>b__50_64>d);
				return <<ExecuteAsync>b__50_64>d.<>t__builder.Task;
			}

			// Token: 0x040005F8 RID: 1528
			public static readonly Areas_Admin_Views_AccessToken_Create.<>c <>9 = new Areas_Admin_Views_AccessToken_Create.<>c();

			// Token: 0x040005F9 RID: 1529
			public static Func<Task> <>9__50_3;

			// Token: 0x040005FA RID: 1530
			public static Func<Task> <>9__50_5;

			// Token: 0x040005FB RID: 1531
			public static Func<Task> <>9__50_7;

			// Token: 0x040005FC RID: 1532
			public static Func<Task> <>9__50_9;

			// Token: 0x040005FD RID: 1533
			public static Func<Task> <>9__50_11;

			// Token: 0x040005FE RID: 1534
			public static Func<Task> <>9__50_13;

			// Token: 0x040005FF RID: 1535
			public static Func<Task> <>9__50_15;

			// Token: 0x04000600 RID: 1536
			public static Func<Task> <>9__50_17;

			// Token: 0x04000601 RID: 1537
			public static Func<Task> <>9__50_18;

			// Token: 0x04000602 RID: 1538
			public static Func<Task> <>9__50_20;

			// Token: 0x04000603 RID: 1539
			public static Func<Task> <>9__50_22;

			// Token: 0x04000604 RID: 1540
			public static Func<Task> <>9__50_24;

			// Token: 0x04000605 RID: 1541
			public static Func<Task> <>9__50_26;

			// Token: 0x04000606 RID: 1542
			public static Func<Task> <>9__50_28;

			// Token: 0x04000607 RID: 1543
			public static Func<Task> <>9__50_30;

			// Token: 0x04000608 RID: 1544
			public static Func<Task> <>9__50_32;

			// Token: 0x04000609 RID: 1545
			public static Func<Task> <>9__50_34;

			// Token: 0x0400060A RID: 1546
			public static Func<Task> <>9__50_36;

			// Token: 0x0400060B RID: 1547
			public static Func<RoleViewModel, string> <>9__50_48;

			// Token: 0x0400060C RID: 1548
			public static Func<Task> <>9__50_49;

			// Token: 0x0400060D RID: 1549
			public static Func<Task> <>9__50_51;

			// Token: 0x0400060E RID: 1550
			public static Func<Task> <>9__50_53;

			// Token: 0x0400060F RID: 1551
			public static Func<Task> <>9__50_55;

			// Token: 0x04000610 RID: 1552
			public static Func<Task> <>9__50_38;

			// Token: 0x04000611 RID: 1553
			public static Func<Task> <>9__50_40;

			// Token: 0x04000612 RID: 1554
			public static Func<Task> <>9__50_42;

			// Token: 0x04000613 RID: 1555
			public static Func<Task> <>9__50_44;

			// Token: 0x04000614 RID: 1556
			public static Func<Task> <>9__50_58;

			// Token: 0x04000615 RID: 1557
			public static Func<Task> <>9__50_60;

			// Token: 0x04000616 RID: 1558
			public static Func<Task> <>9__50_63;

			// Token: 0x04000617 RID: 1559
			public static Func<Task> <>9__50_64;

			// Token: 0x02000258 RID: 600
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_11>d : IAsyncStateMachine
			{
				// Token: 0x06000DBE RID: 3518 RVA: 0x0006FE5C File Offset: 0x0006E05C
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

				// Token: 0x06000DBF RID: 3519 RVA: 0x0006FEAC File Offset: 0x0006E0AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D51 RID: 3409
				public int <>1__state;

				// Token: 0x04000D52 RID: 3410
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000259 RID: 601
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_13>d : IAsyncStateMachine
			{
				// Token: 0x06000DC0 RID: 3520 RVA: 0x0006FEBC File Offset: 0x0006E0BC
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

				// Token: 0x06000DC1 RID: 3521 RVA: 0x0006FF0C File Offset: 0x0006E10C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D53 RID: 3411
				public int <>1__state;

				// Token: 0x04000D54 RID: 3412
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025A RID: 602
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_15>d : IAsyncStateMachine
			{
				// Token: 0x06000DC2 RID: 3522 RVA: 0x0006FF1C File Offset: 0x0006E11C
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

				// Token: 0x06000DC3 RID: 3523 RVA: 0x0006FF6C File Offset: 0x0006E16C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D55 RID: 3413
				public int <>1__state;

				// Token: 0x04000D56 RID: 3414
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025B RID: 603
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_17>d : IAsyncStateMachine
			{
				// Token: 0x06000DC4 RID: 3524 RVA: 0x0006FF7C File Offset: 0x0006E17C
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

				// Token: 0x06000DC5 RID: 3525 RVA: 0x0006FFCC File Offset: 0x0006E1CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D57 RID: 3415
				public int <>1__state;

				// Token: 0x04000D58 RID: 3416
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025C RID: 604
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_18>d : IAsyncStateMachine
			{
				// Token: 0x06000DC6 RID: 3526 RVA: 0x0006FFDC File Offset: 0x0006E1DC
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

				// Token: 0x06000DC7 RID: 3527 RVA: 0x0007002C File Offset: 0x0006E22C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D59 RID: 3417
				public int <>1__state;

				// Token: 0x04000D5A RID: 3418
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025D RID: 605
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_20>d : IAsyncStateMachine
			{
				// Token: 0x06000DC8 RID: 3528 RVA: 0x0007003C File Offset: 0x0006E23C
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

				// Token: 0x06000DC9 RID: 3529 RVA: 0x0007008C File Offset: 0x0006E28C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D5B RID: 3419
				public int <>1__state;

				// Token: 0x04000D5C RID: 3420
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025E RID: 606
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_22>d : IAsyncStateMachine
			{
				// Token: 0x06000DCA RID: 3530 RVA: 0x0007009C File Offset: 0x0006E29C
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

				// Token: 0x06000DCB RID: 3531 RVA: 0x000700EC File Offset: 0x0006E2EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D5D RID: 3421
				public int <>1__state;

				// Token: 0x04000D5E RID: 3422
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200025F RID: 607
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_24>d : IAsyncStateMachine
			{
				// Token: 0x06000DCC RID: 3532 RVA: 0x000700FC File Offset: 0x0006E2FC
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

				// Token: 0x06000DCD RID: 3533 RVA: 0x0007014C File Offset: 0x0006E34C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D5F RID: 3423
				public int <>1__state;

				// Token: 0x04000D60 RID: 3424
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000260 RID: 608
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_26>d : IAsyncStateMachine
			{
				// Token: 0x06000DCE RID: 3534 RVA: 0x0007015C File Offset: 0x0006E35C
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

				// Token: 0x06000DCF RID: 3535 RVA: 0x000701AC File Offset: 0x0006E3AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D61 RID: 3425
				public int <>1__state;

				// Token: 0x04000D62 RID: 3426
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000261 RID: 609
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_28>d : IAsyncStateMachine
			{
				// Token: 0x06000DD0 RID: 3536 RVA: 0x000701BC File Offset: 0x0006E3BC
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

				// Token: 0x06000DD1 RID: 3537 RVA: 0x0007020C File Offset: 0x0006E40C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D63 RID: 3427
				public int <>1__state;

				// Token: 0x04000D64 RID: 3428
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000262 RID: 610
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_30>d : IAsyncStateMachine
			{
				// Token: 0x06000DD2 RID: 3538 RVA: 0x0007021C File Offset: 0x0006E41C
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

				// Token: 0x06000DD3 RID: 3539 RVA: 0x0007026C File Offset: 0x0006E46C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D65 RID: 3429
				public int <>1__state;

				// Token: 0x04000D66 RID: 3430
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000263 RID: 611
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_32>d : IAsyncStateMachine
			{
				// Token: 0x06000DD4 RID: 3540 RVA: 0x0007027C File Offset: 0x0006E47C
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

				// Token: 0x06000DD5 RID: 3541 RVA: 0x000702CC File Offset: 0x0006E4CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D67 RID: 3431
				public int <>1__state;

				// Token: 0x04000D68 RID: 3432
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000264 RID: 612
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_34>d : IAsyncStateMachine
			{
				// Token: 0x06000DD6 RID: 3542 RVA: 0x000702DC File Offset: 0x0006E4DC
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

				// Token: 0x06000DD7 RID: 3543 RVA: 0x0007032C File Offset: 0x0006E52C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D69 RID: 3433
				public int <>1__state;

				// Token: 0x04000D6A RID: 3434
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000265 RID: 613
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_36>d : IAsyncStateMachine
			{
				// Token: 0x06000DD8 RID: 3544 RVA: 0x0007033C File Offset: 0x0006E53C
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

				// Token: 0x06000DD9 RID: 3545 RVA: 0x0007038C File Offset: 0x0006E58C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D6B RID: 3435
				public int <>1__state;

				// Token: 0x04000D6C RID: 3436
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000266 RID: 614
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_38>d : IAsyncStateMachine
			{
				// Token: 0x06000DDA RID: 3546 RVA: 0x0007039C File Offset: 0x0006E59C
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

				// Token: 0x06000DDB RID: 3547 RVA: 0x000703EC File Offset: 0x0006E5EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D6D RID: 3437
				public int <>1__state;

				// Token: 0x04000D6E RID: 3438
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000267 RID: 615
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_3>d : IAsyncStateMachine
			{
				// Token: 0x06000DDC RID: 3548 RVA: 0x000703FC File Offset: 0x0006E5FC
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

				// Token: 0x06000DDD RID: 3549 RVA: 0x0007044C File Offset: 0x0006E64C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D6F RID: 3439
				public int <>1__state;

				// Token: 0x04000D70 RID: 3440
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000268 RID: 616
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_40>d : IAsyncStateMachine
			{
				// Token: 0x06000DDE RID: 3550 RVA: 0x0007045C File Offset: 0x0006E65C
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

				// Token: 0x06000DDF RID: 3551 RVA: 0x000704AC File Offset: 0x0006E6AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D71 RID: 3441
				public int <>1__state;

				// Token: 0x04000D72 RID: 3442
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000269 RID: 617
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_42>d : IAsyncStateMachine
			{
				// Token: 0x06000DE0 RID: 3552 RVA: 0x000704BC File Offset: 0x0006E6BC
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

				// Token: 0x06000DE1 RID: 3553 RVA: 0x0007050C File Offset: 0x0006E70C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D73 RID: 3443
				public int <>1__state;

				// Token: 0x04000D74 RID: 3444
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026A RID: 618
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_44>d : IAsyncStateMachine
			{
				// Token: 0x06000DE2 RID: 3554 RVA: 0x0007051C File Offset: 0x0006E71C
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

				// Token: 0x06000DE3 RID: 3555 RVA: 0x0007056C File Offset: 0x0006E76C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D75 RID: 3445
				public int <>1__state;

				// Token: 0x04000D76 RID: 3446
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026B RID: 619
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_49>d : IAsyncStateMachine
			{
				// Token: 0x06000DE4 RID: 3556 RVA: 0x0007057C File Offset: 0x0006E77C
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

				// Token: 0x06000DE5 RID: 3557 RVA: 0x000705CC File Offset: 0x0006E7CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D77 RID: 3447
				public int <>1__state;

				// Token: 0x04000D78 RID: 3448
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026C RID: 620
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_51>d : IAsyncStateMachine
			{
				// Token: 0x06000DE6 RID: 3558 RVA: 0x000705DC File Offset: 0x0006E7DC
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

				// Token: 0x06000DE7 RID: 3559 RVA: 0x0007062C File Offset: 0x0006E82C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D79 RID: 3449
				public int <>1__state;

				// Token: 0x04000D7A RID: 3450
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026D RID: 621
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_53>d : IAsyncStateMachine
			{
				// Token: 0x06000DE8 RID: 3560 RVA: 0x0007063C File Offset: 0x0006E83C
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

				// Token: 0x06000DE9 RID: 3561 RVA: 0x0007068C File Offset: 0x0006E88C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D7B RID: 3451
				public int <>1__state;

				// Token: 0x04000D7C RID: 3452
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026E RID: 622
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_55>d : IAsyncStateMachine
			{
				// Token: 0x06000DEA RID: 3562 RVA: 0x0007069C File Offset: 0x0006E89C
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

				// Token: 0x06000DEB RID: 3563 RVA: 0x000706EC File Offset: 0x0006E8EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D7D RID: 3453
				public int <>1__state;

				// Token: 0x04000D7E RID: 3454
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200026F RID: 623
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_58>d : IAsyncStateMachine
			{
				// Token: 0x06000DEC RID: 3564 RVA: 0x000706FC File Offset: 0x0006E8FC
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

				// Token: 0x06000DED RID: 3565 RVA: 0x0007074C File Offset: 0x0006E94C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D7F RID: 3455
				public int <>1__state;

				// Token: 0x04000D80 RID: 3456
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000270 RID: 624
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_5>d : IAsyncStateMachine
			{
				// Token: 0x06000DEE RID: 3566 RVA: 0x0007075C File Offset: 0x0006E95C
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

				// Token: 0x06000DEF RID: 3567 RVA: 0x000707AC File Offset: 0x0006E9AC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D81 RID: 3457
				public int <>1__state;

				// Token: 0x04000D82 RID: 3458
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000271 RID: 625
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_60>d : IAsyncStateMachine
			{
				// Token: 0x06000DF0 RID: 3568 RVA: 0x000707BC File Offset: 0x0006E9BC
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

				// Token: 0x06000DF1 RID: 3569 RVA: 0x0007080C File Offset: 0x0006EA0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D83 RID: 3459
				public int <>1__state;

				// Token: 0x04000D84 RID: 3460
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000272 RID: 626
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_63>d : IAsyncStateMachine
			{
				// Token: 0x06000DF2 RID: 3570 RVA: 0x0007081C File Offset: 0x0006EA1C
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

				// Token: 0x06000DF3 RID: 3571 RVA: 0x0007086C File Offset: 0x0006EA6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D85 RID: 3461
				public int <>1__state;

				// Token: 0x04000D86 RID: 3462
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000273 RID: 627
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_64>d : IAsyncStateMachine
			{
				// Token: 0x06000DF4 RID: 3572 RVA: 0x0007087C File Offset: 0x0006EA7C
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

				// Token: 0x06000DF5 RID: 3573 RVA: 0x000708CC File Offset: 0x0006EACC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D87 RID: 3463
				public int <>1__state;

				// Token: 0x04000D88 RID: 3464
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000274 RID: 628
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_7>d : IAsyncStateMachine
			{
				// Token: 0x06000DF6 RID: 3574 RVA: 0x000708DC File Offset: 0x0006EADC
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

				// Token: 0x06000DF7 RID: 3575 RVA: 0x0007092C File Offset: 0x0006EB2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D89 RID: 3465
				public int <>1__state;

				// Token: 0x04000D8A RID: 3466
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000275 RID: 629
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__50_9>d : IAsyncStateMachine
			{
				// Token: 0x06000DF8 RID: 3576 RVA: 0x0007093C File Offset: 0x0006EB3C
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

				// Token: 0x06000DF9 RID: 3577 RVA: 0x0007098C File Offset: 0x0006EB8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000D8B RID: 3467
				public int <>1__state;

				// Token: 0x04000D8C RID: 3468
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x020000E8 RID: 232
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x04000618 RID: 1560
			public int ix;

			// Token: 0x04000619 RID: 1561
			public Areas_Admin_Views_AccessToken_Create <>4__this;
		}

		// Token: 0x020000E9 RID: 233
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__50 : IAsyncStateMachine
		{
			// Token: 0x060008D8 RID: 2264 RVA: 0x000214E8 File Offset: 0x0001F6E8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_AccessToken_Create areas_Admin_Views_AccessToken_Create = this.<>4__this;
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
						areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div class=\"m-1\">\r\n                    <h2>User account</h2>\r\n                </div>\r\n                <div class=\"border bg-light py-2 px-3 rounded shadow\">\r\n                    ");
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "a543bfd4a0146f6f615459243b3c497100f1fb9100ae73e1b94c728a90cdbe7d16813", new Func<Task>(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_0));
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<FormTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = areas_Admin_Views_AccessToken_Create.CreateTagHelper<RenderAtEndOfFormTagHelper>();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Add(areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
						areas_Admin_Views_AccessToken_Create.BeginWriteTagHelperAttribute();
						areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer = areas_Admin_Views_AccessToken_Create.EndWriteTagHelperAttribute();
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute("data-parsley-validate", areas_Admin_Views_AccessToken_Create.Html.Raw(areas_Admin_Views_AccessToken_Create.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_31);
						areas_Admin_Views_AccessToken_Create.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_32.Value;
						areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_AccessToken_Create.__tagHelperAttribute_32);
						awaiter2 = areas_Admin_Views_AccessToken_Create.__tagHelperRunner.RunAsync(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<ExecuteAsync>d__50>(ref awaiter2, ref this);
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
					if (areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01CE;
					}
					awaiter = areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_AccessToken_Create.<ExecuteAsync>d__50>(ref awaiter, ref this);
						return;
					}
					IL_01C7:
					awaiter.GetResult();
					IL_01CE:
					areas_Admin_Views_AccessToken_Create.Write(areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext.Output);
					areas_Admin_Views_AccessToken_Create.__tagHelperExecutionContext = areas_Admin_Views_AccessToken_Create.__tagHelperScopeManager.End();
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
					areas_Admin_Views_AccessToken_Create.DefineSection("styleSheets", new RenderAsyncDelegate(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_1));
					areas_Admin_Views_AccessToken_Create.WriteLiteral("\r\n");
					areas_Admin_Views_AccessToken_Create.DefineSection("Scripts", new RenderAsyncDelegate(areas_Admin_Views_AccessToken_Create.<ExecuteAsync>b__50_2));
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

			// Token: 0x060008D9 RID: 2265 RVA: 0x00021774 File Offset: 0x0001F974
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400061A RID: 1562
			public int <>1__state;

			// Token: 0x0400061B RID: 1563
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400061C RID: 1564
			public Areas_Admin_Views_AccessToken_Create <>4__this;

			// Token: 0x0400061D RID: 1565
			private TaskAwaiter <>u__1;
		}
	}
}
