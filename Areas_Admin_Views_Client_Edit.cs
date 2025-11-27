using System;
using System.Collections.Generic;
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
	// Token: 0x02000035 RID: 53
	[RazorSourceChecksum("SHA256", "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa8745", "/Areas/Admin/Views/Client/Edit.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Client/Edit.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Client_Edit : BaseRazorPage<ClientInputViewModel>
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000A36F File Offset: 0x0000856F
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

		// Token: 0x060001FE RID: 510 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000A3E7 File Offset: 0x000085E7
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000A3EF File Offset: 0x000085EF
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000A3F8 File Offset: 0x000085F8
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000A400 File Offset: 0x00008600
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000A409 File Offset: 0x00008609
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000A411 File Offset: 0x00008611
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000A41A File Offset: 0x0000861A
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000A422 File Offset: 0x00008622
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000A42B File Offset: 0x0000862B
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000A433 File Offset: 0x00008633
		[RazorInject]
		public IHtmlHelper<ClientInputViewModel> Html { get; private set; }

		// Token: 0x0600020B RID: 523 RVA: 0x0000A600 File Offset: 0x00008800
		[CompilerGenerated]
		private Task <ExecuteAsync>b__28_23()
		{
			Areas_Admin_Views_Client_Edit.<<ExecuteAsync>b__28_23>d <<ExecuteAsync>b__28_23>d;
			<<ExecuteAsync>b__28_23>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__28_23>d.<>4__this = this;
			<<ExecuteAsync>b__28_23>d.<>1__state = -1;
			<<ExecuteAsync>b__28_23>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<<ExecuteAsync>b__28_23>d>(ref <<ExecuteAsync>b__28_23>d);
			return <<ExecuteAsync>b__28_23>d.<>t__builder.Task;
		}

		// Token: 0x040001B8 RID: 440
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", new HtmlString("text-danger"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001B9 RID: 441
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BA RID: 442
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", "Id", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BB RID: 443
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BC RID: 444
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("name", "ClientId", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BD RID: 445
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("id", new HtmlString("ClientId"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BE RID: 446
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("class", new HtmlString("form-control"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001BF RID: 447
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("name", "ClientName", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C0 RID: 448
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("id", new HtmlString("ClientName"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C1 RID: 449
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("name", "ClientSecret", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C2 RID: 450
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("id", new HtmlString("ClientSecret"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C3 RID: 451
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C4 RID: 452
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C5 RID: 453
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("name", "Description", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C6 RID: 454
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("id", new HtmlString("Description"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C7 RID: 455
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("name", "ClientUri", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C8 RID: 456
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("name", "Scopes", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001C9 RID: 457
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("id", new HtmlString("Scopes"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040001CA RID: 458
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040001CB RID: 459
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040001CC RID: 460
		private string __tagHelperStringValueBuffer;

		// Token: 0x040001CD RID: 461
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040001CE RID: 462
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x040001CF RID: 463
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x040001D0 RID: 464
		private ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;

		// Token: 0x040001D1 RID: 465
		private TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;

		// Token: 0x0200010C RID: 268
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__28_23>d : IAsyncStateMachine
		{
			// Token: 0x06000968 RID: 2408 RVA: 0x000302DC File Offset: 0x0002E4DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Edit areas_Admin_Views_Client_Edit = this.<>4__this;
				try
				{
					areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            ");
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

			// Token: 0x06000969 RID: 2409 RVA: 0x00030340 File Offset: 0x0002E540
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006D8 RID: 1752
			public int <>1__state;

			// Token: 0x040006D9 RID: 1753
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006DA RID: 1754
			public Areas_Admin_Views_Client_Edit <>4__this;
		}

		// Token: 0x0200010D RID: 269
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600096C RID: 2412 RVA: 0x00030364 File Offset: 0x0002E564
			internal Task <ExecuteAsync>b__28_0()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_0>d <<ExecuteAsync>b__28_0>d;
				<<ExecuteAsync>b__28_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_0>d.<>1__state = -1;
				<<ExecuteAsync>b__28_0>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_0>d>(ref <<ExecuteAsync>b__28_0>d);
				return <<ExecuteAsync>b__28_0>d.<>t__builder.Task;
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x000303A0 File Offset: 0x0002E5A0
			internal Task <ExecuteAsync>b__28_1()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_1>d <<ExecuteAsync>b__28_1>d;
				<<ExecuteAsync>b__28_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_1>d.<>1__state = -1;
				<<ExecuteAsync>b__28_1>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_1>d>(ref <<ExecuteAsync>b__28_1>d);
				return <<ExecuteAsync>b__28_1>d.<>t__builder.Task;
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x000303DC File Offset: 0x0002E5DC
			internal Task <ExecuteAsync>b__28_6()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_6>d <<ExecuteAsync>b__28_6>d;
				<<ExecuteAsync>b__28_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_6>d.<>1__state = -1;
				<<ExecuteAsync>b__28_6>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_6>d>(ref <<ExecuteAsync>b__28_6>d);
				return <<ExecuteAsync>b__28_6>d.<>t__builder.Task;
			}

			// Token: 0x0600096F RID: 2415 RVA: 0x00030418 File Offset: 0x0002E618
			internal Task <ExecuteAsync>b__28_9()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_9>d <<ExecuteAsync>b__28_9>d;
				<<ExecuteAsync>b__28_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_9>d.<>1__state = -1;
				<<ExecuteAsync>b__28_9>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_9>d>(ref <<ExecuteAsync>b__28_9>d);
				return <<ExecuteAsync>b__28_9>d.<>t__builder.Task;
			}

			// Token: 0x06000970 RID: 2416 RVA: 0x00030454 File Offset: 0x0002E654
			internal Task <ExecuteAsync>b__28_11()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_11>d <<ExecuteAsync>b__28_11>d;
				<<ExecuteAsync>b__28_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_11>d.<>1__state = -1;
				<<ExecuteAsync>b__28_11>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_11>d>(ref <<ExecuteAsync>b__28_11>d);
				return <<ExecuteAsync>b__28_11>d.<>t__builder.Task;
			}

			// Token: 0x06000971 RID: 2417 RVA: 0x00030490 File Offset: 0x0002E690
			internal Task <ExecuteAsync>b__28_13()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_13>d <<ExecuteAsync>b__28_13>d;
				<<ExecuteAsync>b__28_13>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_13>d.<>1__state = -1;
				<<ExecuteAsync>b__28_13>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_13>d>(ref <<ExecuteAsync>b__28_13>d);
				return <<ExecuteAsync>b__28_13>d.<>t__builder.Task;
			}

			// Token: 0x06000972 RID: 2418 RVA: 0x000304CC File Offset: 0x0002E6CC
			internal Task <ExecuteAsync>b__28_15()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_15>d <<ExecuteAsync>b__28_15>d;
				<<ExecuteAsync>b__28_15>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_15>d.<>1__state = -1;
				<<ExecuteAsync>b__28_15>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_15>d>(ref <<ExecuteAsync>b__28_15>d);
				return <<ExecuteAsync>b__28_15>d.<>t__builder.Task;
			}

			// Token: 0x06000973 RID: 2419 RVA: 0x00030508 File Offset: 0x0002E708
			internal Task <ExecuteAsync>b__28_18()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_18>d <<ExecuteAsync>b__28_18>d;
				<<ExecuteAsync>b__28_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_18>d.<>1__state = -1;
				<<ExecuteAsync>b__28_18>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_18>d>(ref <<ExecuteAsync>b__28_18>d);
				return <<ExecuteAsync>b__28_18>d.<>t__builder.Task;
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x00030544 File Offset: 0x0002E744
			internal Task <ExecuteAsync>b__28_20()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_20>d <<ExecuteAsync>b__28_20>d;
				<<ExecuteAsync>b__28_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_20>d.<>1__state = -1;
				<<ExecuteAsync>b__28_20>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_20>d>(ref <<ExecuteAsync>b__28_20>d);
				return <<ExecuteAsync>b__28_20>d.<>t__builder.Task;
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x00030580 File Offset: 0x0002E780
			internal Task <ExecuteAsync>b__28_25()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_25>d <<ExecuteAsync>b__28_25>d;
				<<ExecuteAsync>b__28_25>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_25>d.<>1__state = -1;
				<<ExecuteAsync>b__28_25>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_25>d>(ref <<ExecuteAsync>b__28_25>d);
				return <<ExecuteAsync>b__28_25>d.<>t__builder.Task;
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x000305BC File Offset: 0x0002E7BC
			internal Task <ExecuteAsync>b__28_28()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_28>d <<ExecuteAsync>b__28_28>d;
				<<ExecuteAsync>b__28_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_28>d.<>1__state = -1;
				<<ExecuteAsync>b__28_28>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_28>d>(ref <<ExecuteAsync>b__28_28>d);
				return <<ExecuteAsync>b__28_28>d.<>t__builder.Task;
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x000305F8 File Offset: 0x0002E7F8
			internal Task <ExecuteAsync>b__28_30()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_30>d <<ExecuteAsync>b__28_30>d;
				<<ExecuteAsync>b__28_30>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_30>d.<>1__state = -1;
				<<ExecuteAsync>b__28_30>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_30>d>(ref <<ExecuteAsync>b__28_30>d);
				return <<ExecuteAsync>b__28_30>d.<>t__builder.Task;
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x00030634 File Offset: 0x0002E834
			internal Task <ExecuteAsync>b__28_33()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_33>d <<ExecuteAsync>b__28_33>d;
				<<ExecuteAsync>b__28_33>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_33>d.<>1__state = -1;
				<<ExecuteAsync>b__28_33>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_33>d>(ref <<ExecuteAsync>b__28_33>d);
				return <<ExecuteAsync>b__28_33>d.<>t__builder.Task;
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x00030670 File Offset: 0x0002E870
			internal Task <ExecuteAsync>b__28_35()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_35>d <<ExecuteAsync>b__28_35>d;
				<<ExecuteAsync>b__28_35>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_35>d.<>1__state = -1;
				<<ExecuteAsync>b__28_35>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_35>d>(ref <<ExecuteAsync>b__28_35>d);
				return <<ExecuteAsync>b__28_35>d.<>t__builder.Task;
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x000306AC File Offset: 0x0002E8AC
			internal Task <ExecuteAsync>b__28_37()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_37>d <<ExecuteAsync>b__28_37>d;
				<<ExecuteAsync>b__28_37>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_37>d.<>1__state = -1;
				<<ExecuteAsync>b__28_37>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_37>d>(ref <<ExecuteAsync>b__28_37>d);
				return <<ExecuteAsync>b__28_37>d.<>t__builder.Task;
			}

			// Token: 0x0600097B RID: 2427 RVA: 0x000306E8 File Offset: 0x0002E8E8
			internal Task <ExecuteAsync>b__28_39()
			{
				Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_39>d <<ExecuteAsync>b__28_39>d;
				<<ExecuteAsync>b__28_39>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__28_39>d.<>1__state = -1;
				<<ExecuteAsync>b__28_39>d.<>t__builder.Start<Areas_Admin_Views_Client_Edit.<>c.<<ExecuteAsync>b__28_39>d>(ref <<ExecuteAsync>b__28_39>d);
				return <<ExecuteAsync>b__28_39>d.<>t__builder.Task;
			}

			// Token: 0x040006DB RID: 1755
			public static readonly Areas_Admin_Views_Client_Edit.<>c <>9 = new Areas_Admin_Views_Client_Edit.<>c();

			// Token: 0x040006DC RID: 1756
			public static Func<Task> <>9__28_0;

			// Token: 0x040006DD RID: 1757
			public static Func<Task> <>9__28_1;

			// Token: 0x040006DE RID: 1758
			public static Func<Task> <>9__28_6;

			// Token: 0x040006DF RID: 1759
			public static Func<Task> <>9__28_9;

			// Token: 0x040006E0 RID: 1760
			public static Func<Task> <>9__28_11;

			// Token: 0x040006E1 RID: 1761
			public static Func<Task> <>9__28_13;

			// Token: 0x040006E2 RID: 1762
			public static Func<Task> <>9__28_15;

			// Token: 0x040006E3 RID: 1763
			public static Func<Task> <>9__28_18;

			// Token: 0x040006E4 RID: 1764
			public static Func<Task> <>9__28_20;

			// Token: 0x040006E5 RID: 1765
			public static Func<Task> <>9__28_25;

			// Token: 0x040006E6 RID: 1766
			public static Func<Task> <>9__28_28;

			// Token: 0x040006E7 RID: 1767
			public static Func<Task> <>9__28_30;

			// Token: 0x040006E8 RID: 1768
			public static Func<Task> <>9__28_33;

			// Token: 0x040006E9 RID: 1769
			public static Func<Task> <>9__28_35;

			// Token: 0x040006EA RID: 1770
			public static Func<Task> <>9__28_37;

			// Token: 0x040006EB RID: 1771
			public static Func<Task> <>9__28_39;

			// Token: 0x020002C2 RID: 706
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_0>d : IAsyncStateMachine
			{
				// Token: 0x06000E92 RID: 3730 RVA: 0x0007261C File Offset: 0x0007081C
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

				// Token: 0x06000E93 RID: 3731 RVA: 0x0007266C File Offset: 0x0007086C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E25 RID: 3621
				public int <>1__state;

				// Token: 0x04000E26 RID: 3622
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C3 RID: 707
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_11>d : IAsyncStateMachine
			{
				// Token: 0x06000E94 RID: 3732 RVA: 0x0007267C File Offset: 0x0007087C
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

				// Token: 0x06000E95 RID: 3733 RVA: 0x000726CC File Offset: 0x000708CC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E27 RID: 3623
				public int <>1__state;

				// Token: 0x04000E28 RID: 3624
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C4 RID: 708
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_13>d : IAsyncStateMachine
			{
				// Token: 0x06000E96 RID: 3734 RVA: 0x000726DC File Offset: 0x000708DC
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

				// Token: 0x06000E97 RID: 3735 RVA: 0x0007272C File Offset: 0x0007092C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E29 RID: 3625
				public int <>1__state;

				// Token: 0x04000E2A RID: 3626
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C5 RID: 709
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_15>d : IAsyncStateMachine
			{
				// Token: 0x06000E98 RID: 3736 RVA: 0x0007273C File Offset: 0x0007093C
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

				// Token: 0x06000E99 RID: 3737 RVA: 0x0007278C File Offset: 0x0007098C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E2B RID: 3627
				public int <>1__state;

				// Token: 0x04000E2C RID: 3628
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C6 RID: 710
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_18>d : IAsyncStateMachine
			{
				// Token: 0x06000E9A RID: 3738 RVA: 0x0007279C File Offset: 0x0007099C
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

				// Token: 0x06000E9B RID: 3739 RVA: 0x000727EC File Offset: 0x000709EC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E2D RID: 3629
				public int <>1__state;

				// Token: 0x04000E2E RID: 3630
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C7 RID: 711
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_1>d : IAsyncStateMachine
			{
				// Token: 0x06000E9C RID: 3740 RVA: 0x000727FC File Offset: 0x000709FC
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

				// Token: 0x06000E9D RID: 3741 RVA: 0x0007284C File Offset: 0x00070A4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E2F RID: 3631
				public int <>1__state;

				// Token: 0x04000E30 RID: 3632
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C8 RID: 712
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_20>d : IAsyncStateMachine
			{
				// Token: 0x06000E9E RID: 3742 RVA: 0x0007285C File Offset: 0x00070A5C
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

				// Token: 0x06000E9F RID: 3743 RVA: 0x000728AC File Offset: 0x00070AAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E31 RID: 3633
				public int <>1__state;

				// Token: 0x04000E32 RID: 3634
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002C9 RID: 713
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_25>d : IAsyncStateMachine
			{
				// Token: 0x06000EA0 RID: 3744 RVA: 0x000728BC File Offset: 0x00070ABC
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

				// Token: 0x06000EA1 RID: 3745 RVA: 0x0007290C File Offset: 0x00070B0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E33 RID: 3635
				public int <>1__state;

				// Token: 0x04000E34 RID: 3636
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CA RID: 714
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_28>d : IAsyncStateMachine
			{
				// Token: 0x06000EA2 RID: 3746 RVA: 0x0007291C File Offset: 0x00070B1C
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

				// Token: 0x06000EA3 RID: 3747 RVA: 0x0007296C File Offset: 0x00070B6C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E35 RID: 3637
				public int <>1__state;

				// Token: 0x04000E36 RID: 3638
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CB RID: 715
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_30>d : IAsyncStateMachine
			{
				// Token: 0x06000EA4 RID: 3748 RVA: 0x0007297C File Offset: 0x00070B7C
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

				// Token: 0x06000EA5 RID: 3749 RVA: 0x000729CC File Offset: 0x00070BCC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E37 RID: 3639
				public int <>1__state;

				// Token: 0x04000E38 RID: 3640
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CC RID: 716
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_33>d : IAsyncStateMachine
			{
				// Token: 0x06000EA6 RID: 3750 RVA: 0x000729DC File Offset: 0x00070BDC
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

				// Token: 0x06000EA7 RID: 3751 RVA: 0x00072A2C File Offset: 0x00070C2C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E39 RID: 3641
				public int <>1__state;

				// Token: 0x04000E3A RID: 3642
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CD RID: 717
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_35>d : IAsyncStateMachine
			{
				// Token: 0x06000EA8 RID: 3752 RVA: 0x00072A3C File Offset: 0x00070C3C
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

				// Token: 0x06000EA9 RID: 3753 RVA: 0x00072A8C File Offset: 0x00070C8C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E3B RID: 3643
				public int <>1__state;

				// Token: 0x04000E3C RID: 3644
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CE RID: 718
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_37>d : IAsyncStateMachine
			{
				// Token: 0x06000EAA RID: 3754 RVA: 0x00072A9C File Offset: 0x00070C9C
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

				// Token: 0x06000EAB RID: 3755 RVA: 0x00072AEC File Offset: 0x00070CEC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E3D RID: 3645
				public int <>1__state;

				// Token: 0x04000E3E RID: 3646
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002CF RID: 719
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_39>d : IAsyncStateMachine
			{
				// Token: 0x06000EAC RID: 3756 RVA: 0x00072AFC File Offset: 0x00070CFC
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

				// Token: 0x06000EAD RID: 3757 RVA: 0x00072B4C File Offset: 0x00070D4C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E3F RID: 3647
				public int <>1__state;

				// Token: 0x04000E40 RID: 3648
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D0 RID: 720
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_6>d : IAsyncStateMachine
			{
				// Token: 0x06000EAE RID: 3758 RVA: 0x00072B5C File Offset: 0x00070D5C
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

				// Token: 0x06000EAF RID: 3759 RVA: 0x00072BAC File Offset: 0x00070DAC
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E41 RID: 3649
				public int <>1__state;

				// Token: 0x04000E42 RID: 3650
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x020002D1 RID: 721
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__28_9>d : IAsyncStateMachine
			{
				// Token: 0x06000EB0 RID: 3760 RVA: 0x00072BBC File Offset: 0x00070DBC
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

				// Token: 0x06000EB1 RID: 3761 RVA: 0x00072C0C File Offset: 0x00070E0C
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000E43 RID: 3651
				public int <>1__state;

				// Token: 0x04000E44 RID: 3652
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200010E RID: 270
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__28 : IAsyncStateMachine
		{
			// Token: 0x0600097C RID: 2428 RVA: 0x00030724 File Offset: 0x0002E924
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Client_Edit areas_Admin_Views_Client_Edit = this.<>4__this;
				try
				{
					if (num > 33)
					{
						areas_Admin_Views_Client_Edit.WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
						this.<>7__wrap1 = areas_Admin_Views_Client_Edit.Html.BeginForm(FormMethod.Post);
					}
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
							goto IL_0230;
						case 2:
							awaiter3 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_03E6;
						case 3:
							awaiter4 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_045B;
						case 4:
							awaiter5 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0704;
						case 5:
							awaiter6 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0779;
						case 6:
							awaiter7 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_09B1;
						case 7:
							awaiter8 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0A26;
						case 8:
							awaiter9 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0B98;
						case 9:
							awaiter10 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0C0E;
						case 10:
							awaiter11 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0DBB;
						case 11:
							awaiter12 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0E31;
						case 12:
							awaiter13 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_0FA4;
						case 13:
							awaiter14 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_101A;
						case 14:
							awaiter15 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1259;
						case 15:
							awaiter16 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_12CF;
						case 16:
							awaiter17 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1442;
						case 17:
							awaiter18 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_14B8;
						case 18:
							awaiter19 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_16AA;
						case 19:
							awaiter20 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1720;
						case 20:
							awaiter21 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1893;
						case 21:
							awaiter22 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1909;
						case 22:
							awaiter23 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1AFE;
						case 23:
							awaiter24 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1B74;
						case 24:
							awaiter25 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1CE7;
						case 25:
							awaiter26 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1D5D;
						case 26:
							awaiter27 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1F62;
						case 27:
							awaiter28 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_1FD8;
						case 28:
							awaiter29 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_214B;
						case 29:
							awaiter30 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_21C1;
						case 30:
							awaiter31 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_2334;
						case 31:
							awaiter32 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_23AA;
						case 32:
							awaiter33 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_251D;
						case 33:
							awaiter34 = this.<>u__1;
							this.<>u__1 = default(TaskAwaiter);
							num = (this.<>1__state = -1);
							goto IL_2593;
						default:
							areas_Admin_Views_Client_Edit.WriteLiteral("            ");
							areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa87459993", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_0));
							areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationSummaryTagHelper>();
							areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
							areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.ModelOnly;
							areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
							areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
							awaiter = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (this.<>1__state = 0);
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter, ref this);
								return;
							}
							break;
						}
						awaiter.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0237;
						}
						awaiter2 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.<>1__state = 1);
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter2, ref this);
							return;
						}
						IL_0230:
						awaiter2.GetResult();
						IL_0237:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874511657", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_1));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_1.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_1);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData = areas_Admin_Views_Client_Edit.ViewData;
						ParameterExpression parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<ClientInputViewModel, int>(viewData, Expression.Lambda<Func<ClientInputViewModel, int>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Id())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_2.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_2);
						awaiter3 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (this.<>1__state = 2);
							this.<>u__1 = awaiter3;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter3, ref this);
							return;
						}
						IL_03E6:
						awaiter3.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0462;
						}
						awaiter4 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = (this.<>1__state = 3);
							this.<>u__1 = awaiter4;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter4, ref this);
							return;
						}
						IL_045B:
						awaiter4.GetResult();
						IL_0462:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase.Write(html.DisplayNameFor<IEnumerable<SelectListItem>>(Expression.Lambda<Func<ClientInputViewModel, IEnumerable<SelectListItem>>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientTypes())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						RazorPageBase razorPageBase2 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html2 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "m");
						razorPageBase2.Write(html2.DropDownListFor(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientTypeId())), new ParameterExpression[] { parameterExpression }), areas_Admin_Views_Client_Edit.Model.ClientTypes, new
						{
							@class = "form-select"
						}));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase3 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html3 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase3.Write(html3.DisplayNameFor<bool>(Expression.Lambda<Func<ClientInputViewModel, bool>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874514696", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_6));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider2 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData2 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<ClientInputViewModel, bool>(viewData2, Expression.Lambda<Func<ClientInputViewModel, bool>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Enabled())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_3.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_3);
						awaiter5 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							num = (this.<>1__state = 4);
							this.<>u__1 = awaiter5;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter5, ref this);
							return;
						}
						IL_0704:
						awaiter5.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0780;
						}
						awaiter6 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter6.IsCompleted)
						{
							num = (this.<>1__state = 5);
							this.<>u__1 = awaiter6;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter6, ref this);
							return;
						}
						IL_0779:
						awaiter6.GetResult();
						IL_0780:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase4 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html4 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase4.Write(html4.DisplayNameFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874516764", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_9));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider3 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData3 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<ClientInputViewModel, string>(viewData3, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_4.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_4);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_5);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						areas_Admin_Views_Client_Edit.BeginWriteTagHelperAttribute();
						areas_Admin_Views_Client_Edit.__tagHelperStringValueBuffer = areas_Admin_Views_Client_Edit.EndWriteTagHelperAttribute();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute("disabled", areas_Admin_Views_Client_Edit.Html.Raw(areas_Admin_Views_Client_Edit.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						awaiter7 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter7.IsCompleted)
						{
							num = (this.<>1__state = 6);
							this.<>u__1 = awaiter7;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter7, ref this);
							return;
						}
						IL_09B1:
						awaiter7.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0A2D;
						}
						awaiter8 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter8.IsCompleted)
						{
							num = (this.<>1__state = 7);
							this.<>u__1 = awaiter8;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter8, ref this);
							return;
						}
						IL_0A26:
						awaiter8.GetResult();
						IL_0A2D:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874518934", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_11));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider4 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData4 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = modelExpressionProvider4.CreateModelExpression<ClientInputViewModel, string>(viewData4, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientId())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter9 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter9.IsCompleted)
						{
							num = (this.<>1__state = 8);
							this.<>u__1 = awaiter9;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter9, ref this);
							return;
						}
						IL_0B98:
						awaiter9.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0C15;
						}
						awaiter10 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter10.IsCompleted)
						{
							num = (this.<>1__state = 9);
							this.<>u__1 = awaiter10;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter10, ref this);
							return;
						}
						IL_0C0E:
						awaiter10.GetResult();
						IL_0C15:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"ClientName\">Title<span class=\"required\"> *</span></label>\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874520744", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_13));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider5 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData5 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider5.CreateModelExpression<ClientInputViewModel, string>(viewData5, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientName())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_7.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_7);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_8);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						awaiter11 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter11.IsCompleted)
						{
							num = (this.<>1__state = 10);
							this.<>u__1 = awaiter11;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter11, ref this);
							return;
						}
						IL_0DBB:
						awaiter11.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_0E38;
						}
						awaiter12 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter12.IsCompleted)
						{
							num = (this.<>1__state = 11);
							this.<>u__1 = awaiter12;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter12, ref this);
							return;
						}
						IL_0E31:
						awaiter12.GetResult();
						IL_0E38:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874522605", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_15));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider6 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData6 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper2.For = modelExpressionProvider6.CreateModelExpression<ClientInputViewModel, string>(viewData6, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientName())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter13 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter13.IsCompleted)
						{
							num = (this.<>1__state = 12);
							this.<>u__1 = awaiter13;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter13, ref this);
							return;
						}
						IL_0FA4:
						awaiter13.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1021;
						}
						awaiter14 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter14.IsCompleted)
						{
							num = (this.<>1__state = 13);
							this.<>u__1 = awaiter14;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter14, ref this);
							return;
						}
						IL_101A:
						awaiter14.GetResult();
						IL_1021:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase5 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html5 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase5.Write(html5.DisplayNameFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                <div class=\"input-group\" id=\"show_hide_password\">\r\n                    ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874524708", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_18));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider7 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData7 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider7.CreateModelExpression<ClientInputViewModel, string>(viewData7, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_9.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_9);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_10);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_11);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_12.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_12);
						awaiter15 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter15.IsCompleted)
						{
							num = (this.<>1__state = 14);
							this.<>u__1 = awaiter15;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter15, ref this);
							return;
						}
						IL_1259:
						awaiter15.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_12D6;
						}
						awaiter16 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter16.IsCompleted)
						{
							num = (this.<>1__state = 15);
							this.<>u__1 = awaiter16;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter16, ref this);
							return;
						}
						IL_12CF:
						awaiter16.GetResult();
						IL_12D6:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                    <button class=\"input-group-text eye rounded-right\" type=\"button\">\r\n                        <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\" tabindex=\"-1\"></i>\r\n                    </button>\r\n                    ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874527118", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_20));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider8 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData8 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper3.For = modelExpressionProvider8.CreateModelExpression<ClientInputViewModel, string>(viewData8, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientSecret())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter17 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter17.IsCompleted)
						{
							num = (this.<>1__state = 16);
							this.<>u__1 = awaiter17;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter17, ref this);
							return;
						}
						IL_1442:
						awaiter17.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_14BF;
						}
						awaiter18 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter18.IsCompleted)
						{
							num = (this.<>1__state = 17);
							this.<>u__1 = awaiter18;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter18, ref this);
							return;
						}
						IL_14B8:
						awaiter18.GetResult();
						IL_14BF:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase6 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html6 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase6.Write(html6.DisplayNameFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Description())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("textarea", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874529171", new Func<Task>(areas_Admin_Views_Client_Edit.<ExecuteAsync>b__28_23));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<TextAreaTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
						TextAreaTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
						IModelExpressionProvider modelExpressionProvider9 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData9 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = modelExpressionProvider9.CreateModelExpression<ClientInputViewModel, string>(viewData9, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_13.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_13);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_14);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						awaiter19 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter19.IsCompleted)
						{
							num = (this.<>1__state = 18);
							this.<>u__1 = awaiter19;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter19, ref this);
							return;
						}
						IL_16AA:
						awaiter19.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1727;
						}
						awaiter20 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter20.IsCompleted)
						{
							num = (this.<>1__state = 19);
							this.<>u__1 = awaiter20;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter20, ref this);
							return;
						}
						IL_1720:
						awaiter20.GetResult();
						IL_1727:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874531114", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_25));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider10 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData10 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper4.For = modelExpressionProvider10.CreateModelExpression<ClientInputViewModel, string>(viewData10, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Description())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter21 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter21.IsCompleted)
						{
							num = (this.<>1__state = 20);
							this.<>u__1 = awaiter21;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter21, ref this);
							return;
						}
						IL_1893:
						awaiter21.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1910;
						}
						awaiter22 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter22.IsCompleted)
						{
							num = (this.<>1__state = 21);
							this.<>u__1 = awaiter22;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter22, ref this);
							return;
						}
						IL_1909:
						awaiter22.GetResult();
						IL_1910:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase7 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html7 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase7.Write(html7.DisplayNameFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874533138", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_28));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider11 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData11 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider11.CreateModelExpression<ClientInputViewModel, string>(viewData11, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_15.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_15);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						awaiter23 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter23.IsCompleted)
						{
							num = (this.<>1__state = 22);
							this.<>u__1 = awaiter23;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter23, ref this);
							return;
						}
						IL_1AFE:
						awaiter23.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1B7B;
						}
						awaiter24 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter24.IsCompleted)
						{
							num = (this.<>1__state = 23);
							this.<>u__1 = awaiter24;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter24, ref this);
							return;
						}
						IL_1B74:
						awaiter24.GetResult();
						IL_1B7B:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874534917", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_30));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider12 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData12 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper5.For = modelExpressionProvider12.CreateModelExpression<ClientInputViewModel, string>(viewData12, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_ClientUri())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter25 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter25.IsCompleted)
						{
							num = (this.<>1__state = 24);
							this.<>u__1 = awaiter25;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter25, ref this);
							return;
						}
						IL_1CE7:
						awaiter25.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1D64;
						}
						awaiter26 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter26.IsCompleted)
						{
							num = (this.<>1__state = 25);
							this.<>u__1 = awaiter26;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter26, ref this);
							return;
						}
						IL_1D5D:
						awaiter26.GetResult();
						IL_1D64:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
						RazorPageBase razorPageBase8 = areas_Admin_Views_Client_Edit;
						IHtmlHelper<ClientInputViewModel> html8 = areas_Admin_Views_Client_Edit.Html;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "model");
						razorPageBase8.Write(html8.DisplayNameFor<string>(Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Scopes())), new ParameterExpression[] { parameterExpression })));
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874536936", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_33));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider13 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData13 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider13.CreateModelExpression<ClientInputViewModel, string>(viewData13, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Scopes())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Areas_Admin_Views_Client_Edit.__tagHelperAttribute_16.Value;
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_16);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_17);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						awaiter27 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter27.IsCompleted)
						{
							num = (this.<>1__state = 26);
							this.<>u__1 = awaiter27;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter27, ref this);
							return;
						}
						IL_1F62:
						awaiter27.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_1FDF;
						}
						awaiter28 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter28.IsCompleted)
						{
							num = (this.<>1__state = 27);
							this.<>u__1 = awaiter28;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter28, ref this);
							return;
						}
						IL_1FD8:
						awaiter28.GetResult();
						IL_1FDF:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874538796", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_35));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider14 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData14 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper6.For = modelExpressionProvider14.CreateModelExpression<ClientInputViewModel, string>(viewData14, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Scopes())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter29 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter29.IsCompleted)
						{
							num = (this.<>1__state = 28);
							this.<>u__1 = awaiter29;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter29, ref this);
							return;
						}
						IL_214B:
						awaiter29.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_21C8;
						}
						awaiter30 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter30.IsCompleted)
						{
							num = (this.<>1__state = 29);
							this.<>u__1 = awaiter30;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter30, ref this);
							return;
						}
						IL_21C1:
						awaiter30.GetResult();
						IL_21C8:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n\t\t\t<div class=\"form-group\">\r\n                <label for=\"Cors\" class=\"control-label\">Allowed Cors origins</label>\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874540597", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_37));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<InputTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider15 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData15 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider15.CreateModelExpression<ClientInputViewModel, string>(viewData15, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Cors())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_6);
						awaiter31 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter31.IsCompleted)
						{
							num = (this.<>1__state = 30);
							this.<>u__1 = awaiter31;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter31, ref this);
							return;
						}
						IL_2334:
						awaiter31.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_23B1;
						}
						awaiter32 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter32.IsCompleted)
						{
							num = (this.<>1__state = 31);
							this.<>u__1 = awaiter32;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter32, ref this);
							return;
						}
						IL_23AA:
						awaiter32.GetResult();
						IL_23B1:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n                ");
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.Begin("span", TagMode.StartTagAndEndTag, "becc10c10a04b4d108a9834618717022470a1c0b398315172d5f96154afa874542170", new Func<Task>(Areas_Admin_Views_Client_Edit.<>c.<>9.<ExecuteAsync>b__28_39));
						areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = areas_Admin_Views_Client_Edit.CreateTagHelper<ValidationMessageTagHelper>();
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Add(areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
						ValidationMessageTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7 = areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
						IModelExpressionProvider modelExpressionProvider16 = areas_Admin_Views_Client_Edit.ModelExpressionProvider;
						ViewDataDictionary<ClientInputViewModel> viewData16 = areas_Admin_Views_Client_Edit.ViewData;
						parameterExpression = Expression.Parameter(typeof(ClientInputViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper7.For = modelExpressionProvider16.CreateModelExpression<ClientInputViewModel, string>(viewData16, Expression.Lambda<Func<ClientInputViewModel, string>>(Expression.Property(parameterExpression, methodof(ClientInputViewModel.get_Cors())), new ParameterExpression[] { parameterExpression }));
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", areas_Admin_Views_Client_Edit.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.AddHtmlAttribute(Areas_Admin_Views_Client_Edit.__tagHelperAttribute_0);
						awaiter33 = areas_Admin_Views_Client_Edit.__tagHelperRunner.RunAsync(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter33.IsCompleted)
						{
							num = (this.<>1__state = 32);
							this.<>u__1 = awaiter33;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter33, ref this);
							return;
						}
						IL_251D:
						awaiter33.GetResult();
						if (areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output.IsContentModified)
						{
							goto IL_259A;
						}
						awaiter34 = areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!awaiter34.IsCompleted)
						{
							num = (this.<>1__state = 33);
							this.<>u__1 = awaiter34;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Areas_Admin_Views_Client_Edit.<ExecuteAsync>d__28>(ref awaiter34, ref this);
							return;
						}
						IL_2593:
						awaiter34.GetResult();
						IL_259A:
						areas_Admin_Views_Client_Edit.Write(areas_Admin_Views_Client_Edit.__tagHelperExecutionContext.Output);
						areas_Admin_Views_Client_Edit.__tagHelperExecutionContext = areas_Admin_Views_Client_Edit.__tagHelperScopeManager.End();
						areas_Admin_Views_Client_Edit.WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
					}
					finally
					{
						if (num < 0 && this.<>7__wrap1 != null)
						{
							((IDisposable)this.<>7__wrap1).Dispose();
						}
					}
					this.<>7__wrap1 = null;
					areas_Admin_Views_Client_Edit.WriteLiteral("    </div>\r\n</div>\r\n");
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

			// Token: 0x0600097D RID: 2429 RVA: 0x00032D88 File Offset: 0x00030F88
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040006EC RID: 1772
			public int <>1__state;

			// Token: 0x040006ED RID: 1773
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040006EE RID: 1774
			public Areas_Admin_Views_Client_Edit <>4__this;

			// Token: 0x040006EF RID: 1775
			private MvcForm <>7__wrap1;

			// Token: 0x040006F0 RID: 1776
			private TaskAwaiter <>u__1;
		}
	}
}
