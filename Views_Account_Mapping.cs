using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using Mega.Has.Modules.UAS.ViewModels;
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
	// Token: 0x02000048 RID: 72
	[RazorSourceChecksum("SHA256", "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da955", "/Views/Account/Mapping.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/Mapping.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_Mapping : BaseRazorPage<MappingViewModel>
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000CAF3 File Offset: 0x0000ACF3
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

		// Token: 0x06000333 RID: 819 RVA: 0x0000CB28 File Offset: 0x0000AD28
		public override Task ExecuteAsync()
		{
			Views_Account_Mapping.<ExecuteAsync>d__40 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_Mapping.<ExecuteAsync>d__40>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000CB6B File Offset: 0x0000AD6B
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000CB73 File Offset: 0x0000AD73
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000CB84 File Offset: 0x0000AD84
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000CB8D File Offset: 0x0000AD8D
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000CB95 File Offset: 0x0000AD95
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CB9E File Offset: 0x0000AD9E
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000CBA6 File Offset: 0x0000ADA6
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000CBAF File Offset: 0x0000ADAF
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
		[RazorInject]
		public IHtmlHelper<MappingViewModel> Html { get; private set; }

		// Token: 0x06000340 RID: 832 RVA: 0x0000CE50 File Offset: 0x0000B050
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_2()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_2>d <<ExecuteAsync>b__40_2>d;
			<<ExecuteAsync>b__40_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_2>d.<>4__this = this;
			<<ExecuteAsync>b__40_2>d.<>1__state = -1;
			<<ExecuteAsync>b__40_2>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref <<ExecuteAsync>b__40_2>d);
			return <<ExecuteAsync>b__40_2>d.<>t__builder.Task;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000CE94 File Offset: 0x0000B094
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_22()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_22>d <<ExecuteAsync>b__40_22>d;
			<<ExecuteAsync>b__40_22>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_22>d.<>4__this = this;
			<<ExecuteAsync>b__40_22>d.<>1__state = -1;
			<<ExecuteAsync>b__40_22>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_22>d>(ref <<ExecuteAsync>b__40_22>d);
			return <<ExecuteAsync>b__40_22>d.<>t__builder.Task;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_28()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_28>d <<ExecuteAsync>b__40_28>d;
			<<ExecuteAsync>b__40_28>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_28>d.<>4__this = this;
			<<ExecuteAsync>b__40_28>d.<>1__state = -1;
			<<ExecuteAsync>b__40_28>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_28>d>(ref <<ExecuteAsync>b__40_28>d);
			return <<ExecuteAsync>b__40_28>d.<>t__builder.Task;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000CF1C File Offset: 0x0000B11C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_26()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_26>d <<ExecuteAsync>b__40_26>d;
			<<ExecuteAsync>b__40_26>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_26>d.<>4__this = this;
			<<ExecuteAsync>b__40_26>d.<>1__state = -1;
			<<ExecuteAsync>b__40_26>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_26>d>(ref <<ExecuteAsync>b__40_26>d);
			return <<ExecuteAsync>b__40_26>d.<>t__builder.Task;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000CF60 File Offset: 0x0000B160
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_27()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_27>d <<ExecuteAsync>b__40_27>d;
			<<ExecuteAsync>b__40_27>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_27>d.<>4__this = this;
			<<ExecuteAsync>b__40_27>d.<>1__state = -1;
			<<ExecuteAsync>b__40_27>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_27>d>(ref <<ExecuteAsync>b__40_27>d);
			return <<ExecuteAsync>b__40_27>d.<>t__builder.Task;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__40_3()
		{
			Views_Account_Mapping.<<ExecuteAsync>b__40_3>d <<ExecuteAsync>b__40_3>d;
			<<ExecuteAsync>b__40_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__40_3>d.<>4__this = this;
			<<ExecuteAsync>b__40_3>d.<>1__state = -1;
			<<ExecuteAsync>b__40_3>d.<>t__builder.Start<Views_Account_Mapping.<<ExecuteAsync>b__40_3>d>(ref <<ExecuteAsync>b__40_3>d);
			return <<ExecuteAsync>b__40_3>d.<>t__builder.Task;
		}

		// Token: 0x04000304 RID: 772
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000305 RID: 773
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000306 RID: 774
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000307 RID: 775
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("col"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000308 RID: 776
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000309 RID: 777
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("name", "ReturnUrl", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030A RID: 778
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("name", "ClaimForRoles", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030B RID: 779
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("name", "Provider", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030C RID: 780
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("name", "ProfileId", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030D RID: 781
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("id", new HtmlString("ProfileId"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030E RID: 782
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400030F RID: 783
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("class", new HtmlString("form-select bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000310 RID: 784
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("type", "checkbox", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000311 RID: 785
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("id", new HtmlString("btnSubmit"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000312 RID: 786
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("asp-action", "MappingSubmit", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000313 RID: 787
		private static readonly TagHelperAttribute __tagHelperAttribute_15 = new TagHelperAttribute("class", new HtmlString("btn btn-hopex btn-success"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000314 RID: 788
		private static readonly TagHelperAttribute __tagHelperAttribute_16 = new TagHelperAttribute("name", new HtmlString("btnSubmit"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000315 RID: 789
		private static readonly TagHelperAttribute __tagHelperAttribute_17 = new TagHelperAttribute("value", new HtmlString("login"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000316 RID: 790
		private static readonly TagHelperAttribute __tagHelperAttribute_18 = new TagHelperAttribute("type", new HtmlString("submit"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000317 RID: 791
		private static readonly TagHelperAttribute __tagHelperAttribute_19 = new TagHelperAttribute("id", new HtmlString("back"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000318 RID: 792
		private static readonly TagHelperAttribute __tagHelperAttribute_20 = new TagHelperAttribute("asp-action", "MappingCancel", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000319 RID: 793
		private static readonly TagHelperAttribute __tagHelperAttribute_21 = new TagHelperAttribute("class", new HtmlString("btn btn-lg btn-light btn-block btn-signin my-2"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400031A RID: 794
		private static readonly TagHelperAttribute __tagHelperAttribute_22 = new TagHelperAttribute("name", new HtmlString("back"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400031B RID: 795
		private static readonly TagHelperAttribute __tagHelperAttribute_23 = new TagHelperAttribute("value", new HtmlString("back"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400031C RID: 796
		private static readonly TagHelperAttribute __tagHelperAttribute_24 = new TagHelperAttribute("asp-action", "Mapping", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400031D RID: 797
		private static readonly TagHelperAttribute __tagHelperAttribute_25 = new TagHelperAttribute("id", new HtmlString("loginForm"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400031E RID: 798
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x0400031F RID: 799
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000320 RID: 800
		private string __tagHelperStringValueBuffer;

		// Token: 0x04000321 RID: 801
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x04000322 RID: 802
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x04000323 RID: 803
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x04000324 RID: 804
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x04000325 RID: 805
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x04000326 RID: 806
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x04000327 RID: 807
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x04000328 RID: 808
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x04000329 RID: 809
		private FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;

		// Token: 0x02000165 RID: 357
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_22>d : IAsyncStateMachine
		{
			// Token: 0x06000A87 RID: 2695 RVA: 0x00048F00 File Offset: 0x00047100
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
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
							goto IL_0197;
						}
						views_Account_Mapping.WriteLiteral("\r\n                            ");
						views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95543279", new Func<Task>(views_Account_Mapping.<ExecuteAsync>b__40_28));
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = views_Account_Mapping.CreateTagHelper<OptionTagHelper>();
						views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						views_Account_Mapping.BeginWriteTagHelperAttribute();
						views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
						views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute("disabled", views_Account_Mapping.Html.Raw(views_Account_Mapping.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Views_Account_Mapping.__tagHelperAttribute_10.Value;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_10);
						awaiter2 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_22>d>(ref awaiter2, ref this);
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
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_019E;
					}
					awaiter = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_22>d>(ref awaiter, ref this);
						return;
					}
					IL_0197:
					awaiter.GetResult();
					IL_019E:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n                        ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A88 RID: 2696 RVA: 0x00049124 File Offset: 0x00047324
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400084C RID: 2124
			public int <>1__state;

			// Token: 0x0400084D RID: 2125
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400084E RID: 2126
			public Views_Account_Mapping <>4__this;

			// Token: 0x0400084F RID: 2127
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000166 RID: 358
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_26>d : IAsyncStateMachine
		{
			// Token: 0x06000A89 RID: 2697 RVA: 0x00049134 File Offset: 0x00047334
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
				try
				{
					views_Account_Mapping.WriteLiteral("\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["ENTER"]);
					views_Account_Mapping.WriteLiteral("\r\n            ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x000491B8 File Offset: 0x000473B8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000850 RID: 2128
			public int <>1__state;

			// Token: 0x04000851 RID: 2129
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000852 RID: 2130
			public Views_Account_Mapping <>4__this;
		}

		// Token: 0x02000167 RID: 359
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_27>d : IAsyncStateMachine
		{
			// Token: 0x06000A8B RID: 2699 RVA: 0x000491C8 File Offset: 0x000473C8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
				try
				{
					views_Account_Mapping.WriteLiteral("\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["Back to login page"]);
					views_Account_Mapping.WriteLiteral("\r\n            ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x0004924C File Offset: 0x0004744C
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000853 RID: 2131
			public int <>1__state;

			// Token: 0x04000854 RID: 2132
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000855 RID: 2133
			public Views_Account_Mapping <>4__this;
		}

		// Token: 0x02000168 RID: 360
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_28>d : IAsyncStateMachine
		{
			// Token: 0x06000A8D RID: 2701 RVA: 0x0004925C File Offset: 0x0004745C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
				try
				{
					views_Account_Mapping.Write(views_Account_Mapping.T["Select your environment"]);
					views_Account_Mapping.WriteLiteral("...");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x000492D4 File Offset: 0x000474D4
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000856 RID: 2134
			public int <>1__state;

			// Token: 0x04000857 RID: 2135
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000858 RID: 2136
			public Views_Account_Mapping <>4__this;
		}

		// Token: 0x02000169 RID: 361
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_2>d : IAsyncStateMachine
		{
			// Token: 0x06000A8F RID: 2703 RVA: 0x000492E4 File Offset: 0x000474E4
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
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
					ParameterExpression parameterExpression;
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
						goto IL_0278;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_042B;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04A0;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0653;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_06C8;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_08A1;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0916;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0AEF;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0B65;
					case 10:
						awaiter11 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0D79;
					case 11:
						awaiter12 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0DEF;
					case 12:
						awaiter13 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0F79;
					case 13:
						awaiter14 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0FEF;
					case 14:
						awaiter15 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1179;
					case 15:
						awaiter16 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_11EF;
					case 16:
						awaiter17 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_144E;
					case 17:
						awaiter18 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_14C4;
					case 18:
						awaiter19 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1663;
					case 19:
						awaiter20 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_16D9;
					case 20:
						awaiter21 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1955;
					case 21:
						awaiter22 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_19CB;
					case 22:
						awaiter23 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1B76;
					case 23:
						awaiter24 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1BEC;
					case 24:
						awaiter25 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1D32;
					case 25:
						awaiter26 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_1DA5;
					default:
					{
						views_Account_Mapping.WriteLiteral("\r\n\r\n            ");
						views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95521726", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_4));
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
						views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider = views_Account_Mapping.ModelExpressionProvider;
						ViewDataDictionary<MappingViewModel> viewData = views_Account_Mapping.ViewData;
						parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<MappingViewModel, string>(viewData, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_ReturnUrl())), new ParameterExpression[] { parameterExpression }));
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Views_Account_Mapping.__tagHelperAttribute_5.Value;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_5);
						awaiter = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter, ref this);
							return;
						}
						break;
					}
					}
					awaiter.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_027F;
					}
					awaiter2 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter2, ref this);
						return;
					}
					IL_0278:
					awaiter2.GetResult();
					IL_027F:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95523688", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_6));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider2 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData2 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider2.CreateModelExpression<MappingViewModel, string>(viewData2, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_ClaimForRoles())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Views_Account_Mapping.__tagHelperAttribute_6.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_6);
					awaiter3 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter3, ref this);
						return;
					}
					IL_042B:
					awaiter3.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04A7;
					}
					awaiter4 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter4, ref this);
						return;
					}
					IL_04A0:
					awaiter4.GetResult();
					IL_04A7:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95525654", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_8));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData3 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider3.CreateModelExpression<MappingViewModel, string>(viewData3, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_Provider())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Views_Account_Mapping.__tagHelperAttribute_7.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_7);
					awaiter5 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter5, ref this);
						return;
					}
					IL_0653:
					awaiter5.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06CF;
					}
					awaiter6 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter6, ref this);
						return;
					}
					IL_06C8:
					awaiter6.GetResult();
					IL_06CF:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95527615", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_10));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider4 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData4 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider4.CreateModelExpression<MappingViewModel, string>(viewData4, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					views_Account_Mapping.BeginWriteTagHelperAttribute();
					views_Account_Mapping.WriteLiteral(views_Account_Mapping.Model.UserName);
					views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Account_Mapping.__tagHelperStringValueBuffer;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter7 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter7, ref this);
						return;
					}
					IL_08A1:
					awaiter7.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_091D;
					}
					awaiter8 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter8, ref this);
						return;
					}
					IL_0916:
					awaiter8.GetResult();
					IL_091D:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95530047", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_12));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData5 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider5.CreateModelExpression<MappingViewModel, string>(viewData5, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_RepositoryId())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					views_Account_Mapping.BeginWriteTagHelperAttribute();
					views_Account_Mapping.WriteLiteral(views_Account_Mapping.Model.RepositoryId);
					views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Account_Mapping.__tagHelperStringValueBuffer;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter9 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						this.<>1__state = 8;
						this.<>u__1 = awaiter9;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter9, ref this);
						return;
					}
					IL_0AEF:
					awaiter9.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0B6C;
					}
					awaiter10 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter10, ref this);
						return;
					}
					IL_0B65:
					awaiter10.GetResult();
					IL_0B6C:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            <input name=\"AssignableElementId\" id=\"AssignableElementId\" type=\"hidden\" />\r\n            <input name=\"Login\" id=\"Login\" type=\"hidden\" />\r\n            <input name=\"UserId\" id=\"UserId\" type=\"hidden\" />\r\n            <input name=\"GuiLanguageId\" id=\"GuiLanguageId\" type=\"hidden\" />\r\n            <input name=\"DataLanguageId\" id=\"DataLanguageId\" type=\"hidden\" />\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95532885", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_14));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider6 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData6 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider6.CreateModelExpression<MappingViewModel, string>(viewData6, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_ProfileId())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)Views_Account_Mapping.__tagHelperAttribute_8.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_8);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_9);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					views_Account_Mapping.BeginWriteTagHelperAttribute();
					views_Account_Mapping.WriteLiteral(views_Account_Mapping.Model.ProfileId);
					views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Account_Mapping.__tagHelperStringValueBuffer;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter11 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter11.IsCompleted)
					{
						this.<>1__state = 10;
						this.<>u__1 = awaiter11;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter11, ref this);
						return;
					}
					IL_0D79:
					awaiter11.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0DF6;
					}
					awaiter12 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter12.IsCompleted)
					{
						this.<>1__state = 11;
						this.<>u__1 = awaiter12;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter12, ref this);
						return;
					}
					IL_0DEF:
					awaiter12.GetResult();
					IL_0DF6:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95535614", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_16));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider7 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData7 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider7.CreateModelExpression<MappingViewModel, bool>(viewData7, Expression.Lambda<Func<MappingViewModel, bool>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_WasAcceptedPolicy())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					awaiter13 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter13.IsCompleted)
					{
						this.<>1__state = 12;
						this.<>u__1 = awaiter13;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter13, ref this);
						return;
					}
					IL_0F79:
					awaiter13.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0FF6;
					}
					awaiter14 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter14.IsCompleted)
					{
						this.<>1__state = 13;
						this.<>u__1 = awaiter14;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter14, ref this);
						return;
					}
					IL_0FEF:
					awaiter14.GetResult();
					IL_0FF6:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95537377", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_18));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider8 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData8 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider8.CreateModelExpression<MappingViewModel, bool>(viewData8, Expression.Lambda<Func<MappingViewModel, bool>>(Expression.Property(parameterExpression, methodof(MappingViewModel.get_RequireValidation())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
					awaiter15 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter15.IsCompleted)
					{
						this.<>1__state = 14;
						this.<>u__1 = awaiter15;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter15, ref this);
						return;
					}
					IL_1179:
					awaiter15.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_11F6;
					}
					awaiter16 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter16.IsCompleted)
					{
						this.<>1__state = 15;
						this.<>u__1 = awaiter16;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter16, ref this);
						return;
					}
					IL_11EF:
					awaiter16.GetResult();
					IL_11F6:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n\r\n            <!-- Environment -->\r\n");
					if (views_Account_Mapping.Model.Environments == null)
					{
						views_Account_Mapping.WriteLiteral("                <div>");
						views_Account_Mapping.Write(views_Account_Mapping.T["No environments found"]);
						views_Account_Mapping.WriteLiteral("</div>\r\n");
						goto IL_170D;
					}
					if (views_Account_Mapping.Model.Environments.Count<SelectListItem>() == 1 || views_Account_Mapping.Model.EnvironmentId != null)
					{
						views_Account_Mapping.WriteLiteral("                    ");
						views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95540113", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_20));
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
						views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider9 = views_Account_Mapping.ModelExpressionProvider;
						ViewDataDictionary<MappingViewModel> viewData9 = views_Account_Mapping.ViewData;
						parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper9.For = modelExpressionProvider9.CreateModelExpression<MappingViewModel, string>(viewData9, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_4.Value;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_4);
						views_Account_Mapping.BeginWriteTagHelperAttribute();
						views_Account_Mapping.WriteLiteral(views_Account_Mapping.Model.EnvironmentId ?? views_Account_Mapping.Model.Environments.First<SelectListItem>().Value);
						views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Account_Mapping.__tagHelperStringValueBuffer;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter17 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter17.IsCompleted)
						{
							this.<>1__state = 16;
							this.<>u__1 = awaiter17;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter17, ref this);
							return;
						}
					}
					else
					{
						views_Account_Mapping.WriteLiteral("                    <div class=\"form-group my-4 mx-5\" style=\"display: none\">\r\n                        ");
						views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95542958", new Func<Task>(views_Account_Mapping.<ExecuteAsync>b__40_22));
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Account_Mapping.CreateTagHelper<SelectTagHelper>();
						views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
						SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
						IModelExpressionProvider modelExpressionProvider10 = views_Account_Mapping.ModelExpressionProvider;
						ViewDataDictionary<MappingViewModel> viewData10 = views_Account_Mapping.ViewData;
						parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider10.CreateModelExpression<MappingViewModel, string>(viewData10, Expression.Lambda<Func<MappingViewModel, string>>(Expression.Property(parameterExpression, methodof(MappingInputViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = views_Account_Mapping.Model.Environments;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
						views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_11);
						awaiter19 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter19.IsCompleted)
						{
							this.<>1__state = 18;
							this.<>u__1 = awaiter19;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter19, ref this);
							return;
						}
						goto IL_1663;
					}
					IL_144E:
					awaiter17.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_14CB;
					}
					awaiter18 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter18.IsCompleted)
					{
						this.<>1__state = 17;
						this.<>u__1 = awaiter18;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter18, ref this);
						return;
					}
					IL_14C4:
					awaiter18.GetResult();
					IL_14CB:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n");
					goto IL_170D;
					IL_1663:
					awaiter19.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_16E0;
					}
					awaiter20 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter20.IsCompleted)
					{
						this.<>1__state = 19;
						this.<>u__1 = awaiter20;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter20, ref this);
						return;
					}
					IL_16D9:
					awaiter20.GetResult();
					IL_16E0:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n                    </div>\r\n");
					IL_170D:
					views_Account_Mapping.WriteLiteral("\r\n            <div class=\"form-group my-4 mx-5\" id=\"PersonGroups-group\" style=\"display: none\">\r\n                <label for=\"PersonGroups\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Person group"]);
					views_Account_Mapping.WriteLiteral("</label>\r\n                <select id=\"PersonGroups\" class=\"form-select\"></select>\r\n            </div>\r\n\r\n            <div class=\"form-group my-4 mx-5\" id=\"Repositories-group\" style=\"display: none\">\r\n                <label for=\"Repositories\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Repository"]);
					views_Account_Mapping.WriteLiteral("</label>\r\n                <select id=\"Repositories\" name=\"Repositories\" class=\"form-select\"></select>\r\n            </div>\r\n\r\n            <div class=\"alert alert-warning mx-2\" style=\"display:none;\" id=\"private-session-exists-current\">\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["You have an existing private session"]);
					views_Account_Mapping.WriteLiteral(".<br />\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["You can reconnect to this session or choose a public profile"]);
					views_Account_Mapping.WriteLiteral(".\r\n            </div>\r\n            <div class=\"alert alert-warning mx-2\" style=\"display:none;\" id=\"private-session-exists-other\">\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["You have an existing private session on "]);
					views_Account_Mapping.WriteLiteral("'<span id=\"privateSessionRepositoryName\"></span>'.<br />\r\n                ");
					views_Account_Mapping.Write(views_Account_Mapping.T["You can reconnect to this session or choose a public profile"]);
					views_Account_Mapping.WriteLiteral(".\r\n            </div>\r\n\r\n            <div class=\"form-group my-4 mx-5\" id=\"Profiles-group\" style=\"display: none\">\r\n                <label for=\"Profiles\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Profile"]);
					views_Account_Mapping.WriteLiteral("</label>\r\n                <select id=\"Profiles\" name=\"Profiles\" class=\"form-select\"></select>\r\n            </div>\r\n\r\n            <div id=\"policyArea\" style=\"display: none\">\r\n                <div class=\"text-center\">\r\n                    ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95550613", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_24));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Mapping.CreateTagHelper<InputTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Mapping.__tagHelperAttribute_12.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_12);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10 = views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider11 = views_Account_Mapping.ModelExpressionProvider;
					ViewDataDictionary<MappingViewModel> viewData11 = views_Account_Mapping.ViewData;
					parameterExpression = Expression.Parameter(typeof(MappingViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper10.For = modelExpressionProvider11.CreateModelExpression<MappingViewModel, bool>(viewData11, Expression.Lambda<Func<MappingViewModel, bool>>(Expression.Property(parameterExpression, methodof(MappingViewModel.get_PolicyAccepted())), new ParameterExpression[] { parameterExpression }));
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					awaiter21 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter21.IsCompleted)
					{
						this.<>1__state = 20;
						this.<>u__1 = awaiter21;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter21, ref this);
						return;
					}
					IL_1955:
					awaiter21.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_19D2;
					}
					awaiter22 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter22.IsCompleted)
					{
						this.<>1__state = 21;
						this.<>u__1 = awaiter22;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter22, ref this);
						return;
					}
					IL_19CB:
					awaiter22.GetResult();
					IL_19D2:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n                    &nbsp;<a>");
					views_Account_Mapping.Write(views_Account_Mapping.T["I have read and accept the privacy policy"]);
					views_Account_Mapping.WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n            <hr class=\"hide-v6\"/>\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("button", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95552783", new Func<Task>(views_Account_Mapping.<ExecuteAsync>b__40_26));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = views_Account_Mapping.CreateTagHelper<FormActionTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
					views_Account_Mapping.BeginWriteTagHelperAttribute();
					views_Account_Mapping.__tagHelperStringValueBuffer = views_Account_Mapping.EndWriteTagHelperAttribute();
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute("disabled", views_Account_Mapping.Html.Raw(views_Account_Mapping.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_13);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)Views_Account_Mapping.__tagHelperAttribute_14.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_14);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_15);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_16);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_17);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_18);
					awaiter23 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter23.IsCompleted)
					{
						this.<>1__state = 22;
						this.<>u__1 = awaiter23;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter23, ref this);
						return;
					}
					IL_1B76:
					awaiter23.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1BF3;
					}
					awaiter24 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter24.IsCompleted)
					{
						this.<>1__state = 23;
						this.<>u__1 = awaiter24;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter24, ref this);
						return;
					}
					IL_1BEC:
					awaiter24.GetResult();
					IL_1BF3:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("button", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95555106", new Func<Task>(views_Account_Mapping.<ExecuteAsync>b__40_27));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = views_Account_Mapping.CreateTagHelper<FormActionTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_19);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)Views_Account_Mapping.__tagHelperAttribute_20.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_20);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_21);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_22);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_23);
					awaiter25 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter25.IsCompleted)
					{
						this.<>1__state = 24;
						this.<>u__1 = awaiter25;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter25, ref this);
						return;
					}
					IL_1D32:
					awaiter25.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_1DAC;
					}
					awaiter26 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter26.IsCompleted)
					{
						this.<>1__state = 25;
						this.<>u__1 = awaiter26;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<<ExecuteAsync>b__40_2>d>(ref awaiter26, ref this);
						return;
					}
					IL_1DA5:
					awaiter26.GetResult();
					IL_1DAC:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n\r\n        ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x0004B114 File Offset: 0x00049314
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000859 RID: 2137
			public int <>1__state;

			// Token: 0x0400085A RID: 2138
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400085B RID: 2139
			public Views_Account_Mapping <>4__this;

			// Token: 0x0400085C RID: 2140
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200016A RID: 362
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__40_3>d : IAsyncStateMachine
		{
			// Token: 0x06000A91 RID: 2705 RVA: 0x0004B124 File Offset: 0x00049324
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
				try
				{
					views_Account_Mapping.WriteLiteral("\r\n    <script>\r\n        var noRepository = ");
					views_Account_Mapping.Write(views_Account_Mapping.Model.NoRepository.ToString().ToLowerInvariant());
					views_Account_Mapping.WriteLiteral(";\r\n        var model = ");
					views_Account_Mapping.Write(views_Account_Mapping.Html.Raw(JsonSerializer.Serialize<MappingViewModel>(views_Account_Mapping.Model, new JsonSerializerOptions
					{
						PropertyNamingPolicy = JsonNamingPolicy.CamelCase
					})));
					views_Account_Mapping.WriteLiteral(";\r\n    </script>\r\n    <script src=\"/uas/js/mapping.js\"></script>\r\n");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x0004B1E8 File Offset: 0x000493E8
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400085D RID: 2141
			public int <>1__state;

			// Token: 0x0400085E RID: 2142
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400085F RID: 2143
			public Views_Account_Mapping <>4__this;
		}

		// Token: 0x0200016B RID: 363
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A95 RID: 2709 RVA: 0x0004B20C File Offset: 0x0004940C
			internal Task <ExecuteAsync>b__40_0()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_0>d <<ExecuteAsync>b__40_0>d;
				<<ExecuteAsync>b__40_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_0>d.<>1__state = -1;
				<<ExecuteAsync>b__40_0>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_0>d>(ref <<ExecuteAsync>b__40_0>d);
				return <<ExecuteAsync>b__40_0>d.<>t__builder.Task;
			}

			// Token: 0x06000A96 RID: 2710 RVA: 0x0004B248 File Offset: 0x00049448
			internal Task <ExecuteAsync>b__40_1()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_1>d <<ExecuteAsync>b__40_1>d;
				<<ExecuteAsync>b__40_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_1>d.<>1__state = -1;
				<<ExecuteAsync>b__40_1>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_1>d>(ref <<ExecuteAsync>b__40_1>d);
				return <<ExecuteAsync>b__40_1>d.<>t__builder.Task;
			}

			// Token: 0x06000A97 RID: 2711 RVA: 0x0004B284 File Offset: 0x00049484
			internal Task <ExecuteAsync>b__40_4()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_4>d <<ExecuteAsync>b__40_4>d;
				<<ExecuteAsync>b__40_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_4>d.<>1__state = -1;
				<<ExecuteAsync>b__40_4>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_4>d>(ref <<ExecuteAsync>b__40_4>d);
				return <<ExecuteAsync>b__40_4>d.<>t__builder.Task;
			}

			// Token: 0x06000A98 RID: 2712 RVA: 0x0004B2C0 File Offset: 0x000494C0
			internal Task <ExecuteAsync>b__40_6()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_6>d <<ExecuteAsync>b__40_6>d;
				<<ExecuteAsync>b__40_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_6>d.<>1__state = -1;
				<<ExecuteAsync>b__40_6>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_6>d>(ref <<ExecuteAsync>b__40_6>d);
				return <<ExecuteAsync>b__40_6>d.<>t__builder.Task;
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x0004B2FC File Offset: 0x000494FC
			internal Task <ExecuteAsync>b__40_8()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_8>d <<ExecuteAsync>b__40_8>d;
				<<ExecuteAsync>b__40_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_8>d.<>1__state = -1;
				<<ExecuteAsync>b__40_8>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_8>d>(ref <<ExecuteAsync>b__40_8>d);
				return <<ExecuteAsync>b__40_8>d.<>t__builder.Task;
			}

			// Token: 0x06000A9A RID: 2714 RVA: 0x0004B338 File Offset: 0x00049538
			internal Task <ExecuteAsync>b__40_10()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_10>d <<ExecuteAsync>b__40_10>d;
				<<ExecuteAsync>b__40_10>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_10>d.<>1__state = -1;
				<<ExecuteAsync>b__40_10>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_10>d>(ref <<ExecuteAsync>b__40_10>d);
				return <<ExecuteAsync>b__40_10>d.<>t__builder.Task;
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x0004B374 File Offset: 0x00049574
			internal Task <ExecuteAsync>b__40_12()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_12>d <<ExecuteAsync>b__40_12>d;
				<<ExecuteAsync>b__40_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_12>d.<>1__state = -1;
				<<ExecuteAsync>b__40_12>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_12>d>(ref <<ExecuteAsync>b__40_12>d);
				return <<ExecuteAsync>b__40_12>d.<>t__builder.Task;
			}

			// Token: 0x06000A9C RID: 2716 RVA: 0x0004B3B0 File Offset: 0x000495B0
			internal Task <ExecuteAsync>b__40_14()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_14>d <<ExecuteAsync>b__40_14>d;
				<<ExecuteAsync>b__40_14>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_14>d.<>1__state = -1;
				<<ExecuteAsync>b__40_14>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_14>d>(ref <<ExecuteAsync>b__40_14>d);
				return <<ExecuteAsync>b__40_14>d.<>t__builder.Task;
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x0004B3EC File Offset: 0x000495EC
			internal Task <ExecuteAsync>b__40_16()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_16>d <<ExecuteAsync>b__40_16>d;
				<<ExecuteAsync>b__40_16>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_16>d.<>1__state = -1;
				<<ExecuteAsync>b__40_16>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_16>d>(ref <<ExecuteAsync>b__40_16>d);
				return <<ExecuteAsync>b__40_16>d.<>t__builder.Task;
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x0004B428 File Offset: 0x00049628
			internal Task <ExecuteAsync>b__40_18()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_18>d <<ExecuteAsync>b__40_18>d;
				<<ExecuteAsync>b__40_18>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_18>d.<>1__state = -1;
				<<ExecuteAsync>b__40_18>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_18>d>(ref <<ExecuteAsync>b__40_18>d);
				return <<ExecuteAsync>b__40_18>d.<>t__builder.Task;
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x0004B464 File Offset: 0x00049664
			internal Task <ExecuteAsync>b__40_20()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_20>d <<ExecuteAsync>b__40_20>d;
				<<ExecuteAsync>b__40_20>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_20>d.<>1__state = -1;
				<<ExecuteAsync>b__40_20>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_20>d>(ref <<ExecuteAsync>b__40_20>d);
				return <<ExecuteAsync>b__40_20>d.<>t__builder.Task;
			}

			// Token: 0x06000AA0 RID: 2720 RVA: 0x0004B4A0 File Offset: 0x000496A0
			internal Task <ExecuteAsync>b__40_24()
			{
				Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_24>d <<ExecuteAsync>b__40_24>d;
				<<ExecuteAsync>b__40_24>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__40_24>d.<>1__state = -1;
				<<ExecuteAsync>b__40_24>d.<>t__builder.Start<Views_Account_Mapping.<>c.<<ExecuteAsync>b__40_24>d>(ref <<ExecuteAsync>b__40_24>d);
				return <<ExecuteAsync>b__40_24>d.<>t__builder.Task;
			}

			// Token: 0x04000860 RID: 2144
			public static readonly Views_Account_Mapping.<>c <>9 = new Views_Account_Mapping.<>c();

			// Token: 0x04000861 RID: 2145
			public static Func<Task> <>9__40_0;

			// Token: 0x04000862 RID: 2146
			public static Func<Task> <>9__40_1;

			// Token: 0x04000863 RID: 2147
			public static Func<Task> <>9__40_4;

			// Token: 0x04000864 RID: 2148
			public static Func<Task> <>9__40_6;

			// Token: 0x04000865 RID: 2149
			public static Func<Task> <>9__40_8;

			// Token: 0x04000866 RID: 2150
			public static Func<Task> <>9__40_10;

			// Token: 0x04000867 RID: 2151
			public static Func<Task> <>9__40_12;

			// Token: 0x04000868 RID: 2152
			public static Func<Task> <>9__40_14;

			// Token: 0x04000869 RID: 2153
			public static Func<Task> <>9__40_16;

			// Token: 0x0400086A RID: 2154
			public static Func<Task> <>9__40_18;

			// Token: 0x0400086B RID: 2155
			public static Func<Task> <>9__40_20;

			// Token: 0x0400086C RID: 2156
			public static Func<Task> <>9__40_24;

			// Token: 0x02000337 RID: 823
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F7C RID: 3964 RVA: 0x00075FE8 File Offset: 0x000741E8
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

				// Token: 0x06000F7D RID: 3965 RVA: 0x00076038 File Offset: 0x00074238
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F11 RID: 3857
				public int <>1__state;

				// Token: 0x04000F12 RID: 3858
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000338 RID: 824
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_10>d : IAsyncStateMachine
			{
				// Token: 0x06000F7E RID: 3966 RVA: 0x00076048 File Offset: 0x00074248
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

				// Token: 0x06000F7F RID: 3967 RVA: 0x00076098 File Offset: 0x00074298
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F13 RID: 3859
				public int <>1__state;

				// Token: 0x04000F14 RID: 3860
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000339 RID: 825
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_12>d : IAsyncStateMachine
			{
				// Token: 0x06000F80 RID: 3968 RVA: 0x000760A8 File Offset: 0x000742A8
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

				// Token: 0x06000F81 RID: 3969 RVA: 0x000760F8 File Offset: 0x000742F8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F15 RID: 3861
				public int <>1__state;

				// Token: 0x04000F16 RID: 3862
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033A RID: 826
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_14>d : IAsyncStateMachine
			{
				// Token: 0x06000F82 RID: 3970 RVA: 0x00076108 File Offset: 0x00074308
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

				// Token: 0x06000F83 RID: 3971 RVA: 0x00076158 File Offset: 0x00074358
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F17 RID: 3863
				public int <>1__state;

				// Token: 0x04000F18 RID: 3864
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033B RID: 827
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_16>d : IAsyncStateMachine
			{
				// Token: 0x06000F84 RID: 3972 RVA: 0x00076168 File Offset: 0x00074368
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

				// Token: 0x06000F85 RID: 3973 RVA: 0x000761B8 File Offset: 0x000743B8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F19 RID: 3865
				public int <>1__state;

				// Token: 0x04000F1A RID: 3866
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033C RID: 828
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_18>d : IAsyncStateMachine
			{
				// Token: 0x06000F86 RID: 3974 RVA: 0x000761C8 File Offset: 0x000743C8
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

				// Token: 0x06000F87 RID: 3975 RVA: 0x00076218 File Offset: 0x00074418
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F1B RID: 3867
				public int <>1__state;

				// Token: 0x04000F1C RID: 3868
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033D RID: 829
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_1>d : IAsyncStateMachine
			{
				// Token: 0x06000F88 RID: 3976 RVA: 0x00076228 File Offset: 0x00074428
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

				// Token: 0x06000F89 RID: 3977 RVA: 0x00076278 File Offset: 0x00074478
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F1D RID: 3869
				public int <>1__state;

				// Token: 0x04000F1E RID: 3870
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033E RID: 830
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_20>d : IAsyncStateMachine
			{
				// Token: 0x06000F8A RID: 3978 RVA: 0x00076288 File Offset: 0x00074488
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

				// Token: 0x06000F8B RID: 3979 RVA: 0x000762D8 File Offset: 0x000744D8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F1F RID: 3871
				public int <>1__state;

				// Token: 0x04000F20 RID: 3872
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x0200033F RID: 831
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_24>d : IAsyncStateMachine
			{
				// Token: 0x06000F8C RID: 3980 RVA: 0x000762E8 File Offset: 0x000744E8
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

				// Token: 0x06000F8D RID: 3981 RVA: 0x00076338 File Offset: 0x00074538
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F21 RID: 3873
				public int <>1__state;

				// Token: 0x04000F22 RID: 3874
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000340 RID: 832
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_4>d : IAsyncStateMachine
			{
				// Token: 0x06000F8E RID: 3982 RVA: 0x00076348 File Offset: 0x00074548
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

				// Token: 0x06000F8F RID: 3983 RVA: 0x00076398 File Offset: 0x00074598
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F23 RID: 3875
				public int <>1__state;

				// Token: 0x04000F24 RID: 3876
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000341 RID: 833
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_6>d : IAsyncStateMachine
			{
				// Token: 0x06000F90 RID: 3984 RVA: 0x000763A8 File Offset: 0x000745A8
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

				// Token: 0x06000F91 RID: 3985 RVA: 0x000763F8 File Offset: 0x000745F8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F25 RID: 3877
				public int <>1__state;

				// Token: 0x04000F26 RID: 3878
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000342 RID: 834
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__40_8>d : IAsyncStateMachine
			{
				// Token: 0x06000F92 RID: 3986 RVA: 0x00076408 File Offset: 0x00074608
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

				// Token: 0x06000F93 RID: 3987 RVA: 0x00076458 File Offset: 0x00074658
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F27 RID: 3879
				public int <>1__state;

				// Token: 0x04000F28 RID: 3880
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x0200016C RID: 364
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__40 : IAsyncStateMachine
		{
			// Token: 0x06000AA1 RID: 2721 RVA: 0x0004B4DC File Offset: 0x000496DC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Mapping views_Account_Mapping = this.<>4__this;
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
						goto IL_01D7;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0350;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03C5;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_05D0;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0645;
					default:
						views_Account_Mapping.WriteLiteral("\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95513638", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_0));
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_Mapping.CreateTagHelper<ImageTagHelper>();
						views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_Mapping.__tagHelperAttribute_0.Value;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_0);
						views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_1);
						views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_2);
						views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01DE;
					}
					awaiter2 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter2, ref this);
						return;
					}
					IL_01D7:
					awaiter2.GetResult();
					IL_01DE:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"mx-auto py-1 module-name show-v6\" style=\"display:none;\">\r\n");
					if (!string.IsNullOrEmpty(views_Account_Mapping.Model.ModuleFriendlyName))
					{
						views_Account_Mapping.Write(views_Account_Mapping.Model.ModuleFriendlyName);
					}
					views_Account_Mapping.WriteLiteral("        </div>\r\n\r\n");
					if (views_Account_Mapping.ViewContext.ModelState.IsValid)
					{
						goto IL_03F9;
					}
					views_Account_Mapping.WriteLiteral("            <div class=\"row alert alert-danger mx-2\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95516791", new Func<Task>(Views_Account_Mapping.<>c.<>9.<ExecuteAsync>b__40_1));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = views_Account_Mapping.CreateTagHelper<ValidationSummaryTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_3);
					awaiter3 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter3, ref this);
						return;
					}
					IL_0350:
					awaiter3.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_03CC;
					}
					awaiter4 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter4, ref this);
						return;
					}
					IL_03C5:
					awaiter4.GetResult();
					IL_03CC:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n            </div>\r\n");
					IL_03F9:
					views_Account_Mapping.WriteLiteral("\r\n");
					if (views_Account_Mapping.Model.ErrorMessage != null)
					{
						views_Account_Mapping.WriteLiteral("            <div class=\"alert alert-danger mx-2\">\r\n                <div class=\"alert-danger\">");
						views_Account_Mapping.Write(views_Account_Mapping.Model.ErrorMessage);
						views_Account_Mapping.WriteLiteral("</div>\r\n            </div>\r\n");
					}
					views_Account_Mapping.WriteLiteral("\r\n        <div class=\"alert alert-danger mx-2\" id=\"forbid\" style=\"display: none\">\r\n            <div class=\"alert-danger\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["You are already connected on another device "]);
					views_Account_Mapping.WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"alert alert-danger mx-2\" style=\"display:none;\" id=\"no-repository\">\r\n");
					views_Account_Mapping.WriteLiteral("            <div class=\"alert-danger\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Login is not possible.<br/>Please contact your HOPEX administrator to check logs."]);
					views_Account_Mapping.WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"alert alert-danger mx-2\" style=\"display:none;\" id=\"no-groups\">\r\n            <div class=\"alert-danger\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["User does not belong to any groups"]);
					views_Account_Mapping.WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"text-center my-2\" id=\"loading\">\r\n            <div class=\"spinner-border spinner-border-sm text-success\" role=\"status\">\r\n                <span class=\"sr-only\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Loading"]);
					views_Account_Mapping.WriteLiteral("...</span>\r\n            </div>\r\n        </div>\r\n\r\n        ");
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "d700504b6bf55ffa28d7ca0152911490550e1859fdf3916f6363c6c61e3da95521427", new Func<Task>(views_Account_Mapping.<ExecuteAsync>b__40_2));
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = views_Account_Mapping.CreateTagHelper<FormTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = views_Account_Mapping.CreateTagHelper<RenderAtEndOfFormTagHelper>();
					views_Account_Mapping.__tagHelperExecutionContext.Add(views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					views_Account_Mapping.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)Views_Account_Mapping.__tagHelperAttribute_24.Value;
					views_Account_Mapping.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Mapping.__tagHelperAttribute_24);
					views_Account_Mapping.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Mapping.__tagHelperAttribute_25);
					awaiter5 = views_Account_Mapping.__tagHelperRunner.RunAsync(views_Account_Mapping.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter5, ref this);
						return;
					}
					IL_05D0:
					awaiter5.GetResult();
					if (views_Account_Mapping.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_064C;
					}
					awaiter6 = views_Account_Mapping.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Mapping.<ExecuteAsync>d__40>(ref awaiter6, ref this);
						return;
					}
					IL_0645:
					awaiter6.GetResult();
					IL_064C:
					views_Account_Mapping.Write(views_Account_Mapping.__tagHelperExecutionContext.Output);
					views_Account_Mapping.__tagHelperExecutionContext = views_Account_Mapping.__tagHelperScopeManager.End();
					views_Account_Mapping.WriteLiteral("\r\n\r\n");
					views_Account_Mapping.WriteLiteral("        <div class=\"mt-5 mb-3 footer w-100 show-v6 text-dark\" style=\"display:none;\">\r\n            <label>\r\n                ");
					RazorPageBase razorPageBase = views_Account_Mapping;
					MappingViewModel model = views_Account_Mapping.Model;
					razorPageBase.Write((model != null) ? model.MegaInfo : null);
					views_Account_Mapping.WriteLiteral(" <br>\r\n                <a class=\"text-white privacy-link\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#privacyModal\">");
					views_Account_Mapping.Write(views_Account_Mapping.T["Privacy and Cookie Policy"]);
					views_Account_Mapping.WriteLiteral("</a>\r\n            </label>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
					views_Account_Mapping.DefineSection("Scripts", new RenderAsyncDelegate(views_Account_Mapping.<ExecuteAsync>b__40_3));
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x0004BC14 File Offset: 0x00049E14
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400086D RID: 2157
			public int <>1__state;

			// Token: 0x0400086E RID: 2158
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400086F RID: 2159
			public Views_Account_Mapping <>4__this;

			// Token: 0x04000870 RID: 2160
			private TaskAwaiter <>u__1;
		}
	}
}
