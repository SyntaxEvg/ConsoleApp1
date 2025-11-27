using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using HAS.Modules.UAS.ViewModels;
using HAS.Server.SiteModule.Razor;
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
	// Token: 0x0200004A RID: 74
	[RazorSourceChecksum("SHA256", "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad83459", "/Views/Password/LostPassword.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Password/LostPassword.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Password_LostPassword : BaseRazorPage<LostPasswordViewModel>
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000D11E File Offset: 0x0000B31E
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

		// Token: 0x06000355 RID: 853 RVA: 0x0000D154 File Offset: 0x0000B354
		public override Task ExecuteAsync()
		{
			Views_Password_LostPassword.<ExecuteAsync>d__23 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Password_LostPassword.<ExecuteAsync>d__23>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000D197 File Offset: 0x0000B397
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000D19F File Offset: 0x0000B39F
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000D1B9 File Offset: 0x0000B3B9
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000D1C1 File Offset: 0x0000B3C1
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000D1CA File Offset: 0x0000B3CA
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0000D1D2 File Offset: 0x0000B3D2
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000D1DB File Offset: 0x0000B3DB
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000D1E3 File Offset: 0x0000B3E3
		[RazorInject]
		public IHtmlHelper<LostPasswordViewModel> Html { get; private set; }

		// Token: 0x06000362 RID: 866 RVA: 0x0000D314 File Offset: 0x0000B514
		[CompilerGenerated]
		private Task <ExecuteAsync>b__23_1()
		{
			Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d <<ExecuteAsync>b__23_1>d;
			<<ExecuteAsync>b__23_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__23_1>d.<>4__this = this;
			<<ExecuteAsync>b__23_1>d.<>1__state = -1;
			<<ExecuteAsync>b__23_1>d.<>t__builder.Start<Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref <<ExecuteAsync>b__23_1>d);
			return <<ExecuteAsync>b__23_1>d.<>t__builder.Task;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000D358 File Offset: 0x0000B558
		[CompilerGenerated]
		private Task <ExecuteAsync>b__23_4()
		{
			Views_Password_LostPassword.<<ExecuteAsync>b__23_4>d <<ExecuteAsync>b__23_4>d;
			<<ExecuteAsync>b__23_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__23_4>d.<>4__this = this;
			<<ExecuteAsync>b__23_4>d.<>1__state = -1;
			<<ExecuteAsync>b__23_4>d.<>t__builder.Start<Views_Password_LostPassword.<<ExecuteAsync>b__23_4>d>(ref <<ExecuteAsync>b__23_4>d);
			return <<ExecuteAsync>b__23_4>d.<>t__builder.Task;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000D39C File Offset: 0x0000B59C
		[CompilerGenerated]
		private Task <ExecuteAsync>b__23_12()
		{
			Views_Password_LostPassword.<<ExecuteAsync>b__23_12>d <<ExecuteAsync>b__23_12>d;
			<<ExecuteAsync>b__23_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__23_12>d.<>4__this = this;
			<<ExecuteAsync>b__23_12>d.<>1__state = -1;
			<<ExecuteAsync>b__23_12>d.<>t__builder.Start<Views_Password_LostPassword.<<ExecuteAsync>b__23_12>d>(ref <<ExecuteAsync>b__23_12>d);
			return <<ExecuteAsync>b__23_12>d.<>t__builder.Task;
		}

		// Token: 0x0400033C RID: 828
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400033D RID: 829
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400033E RID: 830
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x0400033F RID: 831
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000340 RID: 832
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000341 RID: 833
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", new HtmlString("form-select bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000342 RID: 834
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("class", new HtmlString("form-control bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000343 RID: 835
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000344 RID: 836
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("asp-action", "LostPassword", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000345 RID: 837
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000346 RID: 838
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("id", new HtmlString("loginForm"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x04000347 RID: 839
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x04000348 RID: 840
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x04000349 RID: 841
		private string __tagHelperStringValueBuffer;

		// Token: 0x0400034A RID: 842
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x0400034B RID: 843
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x0400034C RID: 844
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x0400034D RID: 845
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x0400034E RID: 846
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x0400034F RID: 847
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x04000350 RID: 848
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x02000170 RID: 368
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__23_12>d : IAsyncStateMachine
		{
			// Token: 0x06000AA8 RID: 2728 RVA: 0x0004C058 File Offset: 0x0004A258
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Password_LostPassword views_Password_LostPassword = this.<>4__this;
				try
				{
					views_Password_LostPassword.Write(views_Password_LostPassword.T["Select your environment"]);
					views_Password_LostPassword.WriteLiteral("...");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000AA9 RID: 2729 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000879 RID: 2169
			public int <>1__state;

			// Token: 0x0400087A RID: 2170
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400087B RID: 2171
			public Views_Password_LostPassword <>4__this;
		}

		// Token: 0x02000171 RID: 369
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__23_1>d : IAsyncStateMachine
		{
			// Token: 0x06000AAA RID: 2730 RVA: 0x0004C0E0 File Offset: 0x0004A2E0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Password_LostPassword views_Password_LostPassword = this.<>4__this;
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
						goto IL_02E8;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0486;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_04FB;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_069F;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0714;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_094B;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_09C0;
					case 8:
						awaiter9 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0BEB;
					case 9:
						awaiter10 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0C61;
					default:
						views_Password_LostPassword.WriteLiteral("\r\n                <h6 class=\"text-center\">");
						views_Password_LostPassword.Write(views_Password_LostPassword.T["Lost password"]);
						views_Password_LostPassword.WriteLiteral("</h6>\r\n");
						if (views_Password_LostPassword.Model.Environments == null)
						{
							views_Password_LostPassword.WriteLiteral("                    <div>");
							views_Password_LostPassword.Write(views_Password_LostPassword.T["No environment found"]);
							views_Password_LostPassword.WriteLiteral("..</div>\r\n");
							goto IL_0CE2;
						}
						if (views_Password_LostPassword.Model.Environments.Count<SelectListItem>() == 1)
						{
							views_Password_LostPassword.WriteLiteral("                        ");
							views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345913998", new Func<Task>(Views_Password_LostPassword.<>c.<>9.<ExecuteAsync>b__23_2));
							views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Password_LostPassword.CreateTagHelper<InputTagHelper>();
							views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
							InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
							IModelExpressionProvider modelExpressionProvider = views_Password_LostPassword.ModelExpressionProvider;
							ViewDataDictionary<LostPasswordViewModel> viewData = views_Password_LostPassword.ViewData;
							parameterExpression = Expression.Parameter(typeof(LostPasswordViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<LostPasswordViewModel, string>(viewData, Expression.Lambda<Func<LostPasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(InputLostPasswordViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
							views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Password_LostPassword.__tagHelperAttribute_3.Value;
							views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_3);
							views_Password_LostPassword.BeginWriteTagHelperAttribute();
							views_Password_LostPassword.WriteLiteral(views_Password_LostPassword.Model.Environments.First<SelectListItem>().Value);
							views_Password_LostPassword.__tagHelperStringValueBuffer = views_Password_LostPassword.EndWriteTagHelperAttribute();
							views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Password_LostPassword.__tagHelperStringValueBuffer;
							views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							views_Password_LostPassword.WriteLiteral("                        <div class=\"form-group my-4 mx-5\">\r\n                            ");
							views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345916834", new Func<Task>(views_Password_LostPassword.<ExecuteAsync>b__23_4));
							views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Password_LostPassword.CreateTagHelper<SelectTagHelper>();
							views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
							SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
							IModelExpressionProvider modelExpressionProvider2 = views_Password_LostPassword.ModelExpressionProvider;
							ViewDataDictionary<LostPasswordViewModel> viewData2 = views_Password_LostPassword.ViewData;
							parameterExpression = Expression.Parameter(typeof(LostPasswordViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider2.CreateModelExpression<LostPasswordViewModel, string>(viewData2, Expression.Lambda<Func<LostPasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(InputLostPasswordViewModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
							views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = views_Password_LostPassword.Model.Environments;
							views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
							views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_5);
							awaiter3 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 2;
								this.<>u__1 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter3, ref this);
								return;
							}
							goto IL_0486;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_02EF;
					}
					awaiter2 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter2, ref this);
						return;
					}
					IL_02E8:
					awaiter2.GetResult();
					IL_02EF:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n");
					goto IL_052F;
					IL_0486:
					awaiter3.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0502;
					}
					awaiter4 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter4, ref this);
						return;
					}
					IL_04FB:
					awaiter4.GetResult();
					IL_0502:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n                        </div>\r\n");
					IL_052F:
					if (views_Password_LostPassword.Model.Question != null)
					{
						views_Password_LostPassword.WriteLiteral("                        ");
						views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345921356", new Func<Task>(Views_Password_LostPassword.<>c.<>9.<ExecuteAsync>b__23_6));
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Password_LostPassword.CreateTagHelper<InputTagHelper>();
						views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider3 = views_Password_LostPassword.ModelExpressionProvider;
						ViewDataDictionary<LostPasswordViewModel> viewData3 = views_Password_LostPassword.ViewData;
						parameterExpression = Expression.Parameter(typeof(LostPasswordViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<LostPasswordViewModel, string>(viewData3, Expression.Lambda<Func<LostPasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(InputLostPasswordViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Password_LostPassword.__tagHelperAttribute_3.Value;
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_3);
						awaiter5 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							this.<>1__state = 4;
							this.<>u__1 = awaiter5;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter5, ref this);
							return;
						}
					}
					else
					{
						views_Password_LostPassword.WriteLiteral("                        <div class=\"form-group my-4 mx-5\">\r\n                            <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">");
						views_Password_LostPassword.Write(views_Password_LostPassword.T["User"]);
						views_Password_LostPassword.WriteLiteral("</label></div></div>\r\n                            ");
						views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345927339", new Func<Task>(Views_Password_LostPassword.<>c.<>9.<ExecuteAsync>b__23_10));
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Password_LostPassword.CreateTagHelper<InputTagHelper>();
						views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
						InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
						IModelExpressionProvider modelExpressionProvider4 = views_Password_LostPassword.ModelExpressionProvider;
						ViewDataDictionary<LostPasswordViewModel> viewData4 = views_Password_LostPassword.ViewData;
						parameterExpression = Expression.Parameter(typeof(LostPasswordViewModel), "__model");
						_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider4.CreateModelExpression<LostPasswordViewModel, string>(viewData4, Expression.Lambda<Func<LostPasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(InputLostPasswordViewModel.get_UserName())), new ParameterExpression[] { parameterExpression }));
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_6);
						views_Password_LostPassword.BeginWriteTagHelperAttribute();
						views_Password_LostPassword.__tagHelperStringValueBuffer = views_Password_LostPassword.EndWriteTagHelperAttribute();
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute("autofocus", views_Password_LostPassword.Html.Raw(views_Password_LostPassword.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_7);
						views_Password_LostPassword.BeginAddHtmlAttributeValues(views_Password_LostPassword.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
						views_Password_LostPassword.AddHtmlAttributeValue("", 3009, views_Password_LostPassword.T["User"], 3009, 10, false);
						views_Password_LostPassword.EndAddHtmlAttributeValues(views_Password_LostPassword.__tagHelperExecutionContext);
						awaiter9 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter9.IsCompleted)
						{
							this.<>1__state = 8;
							this.<>u__1 = awaiter9;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter9, ref this);
							return;
						}
						goto IL_0BEB;
					}
					IL_069F:
					awaiter5.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_071B;
					}
					awaiter6 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter6, ref this);
						return;
					}
					IL_0714:
					awaiter6.GetResult();
					IL_071B:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n                        <div class=\"border rounded m-2 p-1 text-center\">");
					views_Password_LostPassword.Write(views_Password_LostPassword.Model.Question);
					views_Password_LostPassword.WriteLiteral("</div>\r\n                        <div class=\"form-group my-4 mx-5\">\r\n                            <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">");
					views_Password_LostPassword.Write(views_Password_LostPassword.T["Answer"]);
					views_Password_LostPassword.WriteLiteral("</label></div></div>\r\n                            ");
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345923941", new Func<Task>(Views_Password_LostPassword.<>c.<>9.<ExecuteAsync>b__23_8));
					views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Password_LostPassword.CreateTagHelper<InputTagHelper>();
					views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider5 = views_Password_LostPassword.ModelExpressionProvider;
					ViewDataDictionary<LostPasswordViewModel> viewData5 = views_Password_LostPassword.ViewData;
					parameterExpression = Expression.Parameter(typeof(LostPasswordViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider5.CreateModelExpression<LostPasswordViewModel, string>(viewData5, Expression.Lambda<Func<LostPasswordViewModel, string>>(Expression.Property(parameterExpression, methodof(InputLostPasswordViewModel.get_Answer())), new ParameterExpression[] { parameterExpression }));
					views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_6);
					views_Password_LostPassword.BeginWriteTagHelperAttribute();
					views_Password_LostPassword.__tagHelperStringValueBuffer = views_Password_LostPassword.EndWriteTagHelperAttribute();
					views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute("autofocus", views_Password_LostPassword.Html.Raw(views_Password_LostPassword.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
					views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_7);
					views_Password_LostPassword.BeginAddHtmlAttributeValues(views_Password_LostPassword.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
					views_Password_LostPassword.AddHtmlAttributeValue("", 2510, views_Password_LostPassword.T["Answer"], 2510, 12, false);
					views_Password_LostPassword.EndAddHtmlAttributeValues(views_Password_LostPassword.__tagHelperExecutionContext);
					awaiter7 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter7, ref this);
						return;
					}
					IL_094B:
					awaiter7.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_09C7;
					}
					awaiter8 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter8, ref this);
						return;
					}
					IL_09C0:
					awaiter8.GetResult();
					IL_09C7:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n                        </div>\r\n");
					goto IL_0C95;
					IL_0BEB:
					awaiter9.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0C68;
					}
					awaiter10 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter10.IsCompleted)
					{
						this.<>1__state = 9;
						this.<>u__1 = awaiter10;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_1>d>(ref awaiter10, ref this);
						return;
					}
					IL_0C61:
					awaiter10.GetResult();
					IL_0C68:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n                        </div>\r\n");
					IL_0C95:
					views_Password_LostPassword.WriteLiteral("                    <!-- Button -->\r\n                    <button class=\"btn btn-hopex btn-success\" type=\"submit\" id=\"btnSubmit\">");
					views_Password_LostPassword.Write(views_Password_LostPassword.T["Continue"]);
					views_Password_LostPassword.WriteLiteral("</button>\r\n                    <div class=\"text-center mt-0\">\r\n                        <a href=\"/hopex\" class=\"btn btn-light btn-cancel\">\r\n                            ");
					views_Password_LostPassword.Write(views_Password_LostPassword.T["Cancel"]);
					views_Password_LostPassword.WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n");
					IL_0CE2:
					views_Password_LostPassword.WriteLiteral("            ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000AAB RID: 2731 RVA: 0x0004CE24 File Offset: 0x0004B024
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400087C RID: 2172
			public int <>1__state;

			// Token: 0x0400087D RID: 2173
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400087E RID: 2174
			public Views_Password_LostPassword <>4__this;

			// Token: 0x0400087F RID: 2175
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000172 RID: 370
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__23_4>d : IAsyncStateMachine
		{
			// Token: 0x06000AAC RID: 2732 RVA: 0x0004CE34 File Offset: 0x0004B034
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Password_LostPassword views_Password_LostPassword = this.<>4__this;
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
						views_Password_LostPassword.WriteLiteral("\r\n                                ");
						views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345917159", new Func<Task>(views_Password_LostPassword.<ExecuteAsync>b__23_12));
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = views_Password_LostPassword.CreateTagHelper<OptionTagHelper>();
						views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						views_Password_LostPassword.BeginWriteTagHelperAttribute();
						views_Password_LostPassword.__tagHelperStringValueBuffer = views_Password_LostPassword.EndWriteTagHelperAttribute();
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute("disabled", views_Password_LostPassword.Html.Raw(views_Password_LostPassword.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Views_Password_LostPassword.__tagHelperAttribute_4.Value;
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_4);
						awaiter2 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_4>d>(ref awaiter2, ref this);
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
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_019E;
					}
					awaiter = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<<ExecuteAsync>b__23_4>d>(ref awaiter, ref this);
						return;
					}
					IL_0197:
					awaiter.GetResult();
					IL_019E:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n                            ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x0004D058 File Offset: 0x0004B258
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000880 RID: 2176
			public int <>1__state;

			// Token: 0x04000881 RID: 2177
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000882 RID: 2178
			public Views_Password_LostPassword <>4__this;

			// Token: 0x04000883 RID: 2179
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000173 RID: 371
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AB0 RID: 2736 RVA: 0x0004D07C File Offset: 0x0004B27C
			internal Task <ExecuteAsync>b__23_0()
			{
				Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_0>d <<ExecuteAsync>b__23_0>d;
				<<ExecuteAsync>b__23_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_0>d.<>1__state = -1;
				<<ExecuteAsync>b__23_0>d.<>t__builder.Start<Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_0>d>(ref <<ExecuteAsync>b__23_0>d);
				return <<ExecuteAsync>b__23_0>d.<>t__builder.Task;
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
			internal Task <ExecuteAsync>b__23_2()
			{
				Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_2>d <<ExecuteAsync>b__23_2>d;
				<<ExecuteAsync>b__23_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_2>d.<>1__state = -1;
				<<ExecuteAsync>b__23_2>d.<>t__builder.Start<Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_2>d>(ref <<ExecuteAsync>b__23_2>d);
				return <<ExecuteAsync>b__23_2>d.<>t__builder.Task;
			}

			// Token: 0x06000AB2 RID: 2738 RVA: 0x0004D0F4 File Offset: 0x0004B2F4
			internal Task <ExecuteAsync>b__23_6()
			{
				Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_6>d <<ExecuteAsync>b__23_6>d;
				<<ExecuteAsync>b__23_6>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_6>d.<>1__state = -1;
				<<ExecuteAsync>b__23_6>d.<>t__builder.Start<Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_6>d>(ref <<ExecuteAsync>b__23_6>d);
				return <<ExecuteAsync>b__23_6>d.<>t__builder.Task;
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x0004D130 File Offset: 0x0004B330
			internal Task <ExecuteAsync>b__23_8()
			{
				Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_8>d <<ExecuteAsync>b__23_8>d;
				<<ExecuteAsync>b__23_8>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_8>d.<>1__state = -1;
				<<ExecuteAsync>b__23_8>d.<>t__builder.Start<Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_8>d>(ref <<ExecuteAsync>b__23_8>d);
				return <<ExecuteAsync>b__23_8>d.<>t__builder.Task;
			}

			// Token: 0x06000AB4 RID: 2740 RVA: 0x0004D16C File Offset: 0x0004B36C
			internal Task <ExecuteAsync>b__23_10()
			{
				Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_10>d <<ExecuteAsync>b__23_10>d;
				<<ExecuteAsync>b__23_10>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__23_10>d.<>1__state = -1;
				<<ExecuteAsync>b__23_10>d.<>t__builder.Start<Views_Password_LostPassword.<>c.<<ExecuteAsync>b__23_10>d>(ref <<ExecuteAsync>b__23_10>d);
				return <<ExecuteAsync>b__23_10>d.<>t__builder.Task;
			}

			// Token: 0x04000884 RID: 2180
			public static readonly Views_Password_LostPassword.<>c <>9 = new Views_Password_LostPassword.<>c();

			// Token: 0x04000885 RID: 2181
			public static Func<Task> <>9__23_0;

			// Token: 0x04000886 RID: 2182
			public static Func<Task> <>9__23_2;

			// Token: 0x04000887 RID: 2183
			public static Func<Task> <>9__23_6;

			// Token: 0x04000888 RID: 2184
			public static Func<Task> <>9__23_8;

			// Token: 0x04000889 RID: 2185
			public static Func<Task> <>9__23_10;

			// Token: 0x02000344 RID: 836
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F96 RID: 3990 RVA: 0x000764C8 File Offset: 0x000746C8
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

				// Token: 0x06000F97 RID: 3991 RVA: 0x00076518 File Offset: 0x00074718
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F2B RID: 3883
				public int <>1__state;

				// Token: 0x04000F2C RID: 3884
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000345 RID: 837
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_10>d : IAsyncStateMachine
			{
				// Token: 0x06000F98 RID: 3992 RVA: 0x00076528 File Offset: 0x00074728
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

				// Token: 0x06000F99 RID: 3993 RVA: 0x00076578 File Offset: 0x00074778
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F2D RID: 3885
				public int <>1__state;

				// Token: 0x04000F2E RID: 3886
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000346 RID: 838
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_2>d : IAsyncStateMachine
			{
				// Token: 0x06000F9A RID: 3994 RVA: 0x00076588 File Offset: 0x00074788
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

				// Token: 0x06000F9B RID: 3995 RVA: 0x000765D8 File Offset: 0x000747D8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F2F RID: 3887
				public int <>1__state;

				// Token: 0x04000F30 RID: 3888
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000347 RID: 839
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_6>d : IAsyncStateMachine
			{
				// Token: 0x06000F9C RID: 3996 RVA: 0x000765E8 File Offset: 0x000747E8
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

				// Token: 0x06000F9D RID: 3997 RVA: 0x00076638 File Offset: 0x00074838
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F31 RID: 3889
				public int <>1__state;

				// Token: 0x04000F32 RID: 3890
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000348 RID: 840
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__23_8>d : IAsyncStateMachine
			{
				// Token: 0x06000F9E RID: 3998 RVA: 0x00076648 File Offset: 0x00074848
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

				// Token: 0x06000F9F RID: 3999 RVA: 0x00076698 File Offset: 0x00074898
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F33 RID: 3891
				public int <>1__state;

				// Token: 0x04000F34 RID: 3892
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__23 : IAsyncStateMachine
		{
			// Token: 0x06000AB5 RID: 2741 RVA: 0x0004D1A8 File Offset: 0x0004B3A8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Password_LostPassword views_Password_LostPassword = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
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
						goto IL_01DA;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03DA;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_044F;
					default:
						views_Password_LostPassword.Layout = "_Layout";
						views_Password_LostPassword.WriteLiteral("\r\n<div class=\"login\">\r\n    <div class=\"account-login border shadow rounded py-3\">\r\n        <div class=\"text-center py-3 \">\r\n            ");
						views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad834598436", new Func<Task>(Views_Password_LostPassword.<>c.<>9.<ExecuteAsync>b__23_0));
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Password_LostPassword.CreateTagHelper<ImageTagHelper>();
						views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Password_LostPassword.__tagHelperAttribute_0.Value;
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_0);
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_1);
						views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_2);
						views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
						views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<ExecuteAsync>d__23>(ref awaiter, ref this);
							return;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01E1;
					}
					awaiter2 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<ExecuteAsync>d__23>(ref awaiter2, ref this);
						return;
					}
					IL_01DA:
					awaiter2.GetResult();
					IL_01E1:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n        </div>\r\n");
					if (views_Password_LostPassword.Model.ErrorMessage != null)
					{
						views_Password_LostPassword.WriteLiteral("            <div class=\"border border-danger rounded m-2 p-1 text-center\">");
						views_Password_LostPassword.Write(views_Password_LostPassword.Model.ErrorMessage);
						views_Password_LostPassword.WriteLiteral("</div>\r\n");
					}
					views_Password_LostPassword.WriteLiteral("\r\n");
					if (views_Password_LostPassword.Model.ConfirmationMessage != null)
					{
						views_Password_LostPassword.WriteLiteral("            <div class=\"border border-success rounded m-2 p-1 text-center\">");
						views_Password_LostPassword.Write(views_Password_LostPassword.Model.ConfirmationMessage);
						views_Password_LostPassword.WriteLiteral("</div>\r\n            <div class=\"text-center mt-0\">\r\n                <a href=\"/hopex\" class=\"btn btn-light btn-cancel\">\r\n                    ");
						views_Password_LostPassword.Write(views_Password_LostPassword.T["Back to login page"]);
						views_Password_LostPassword.WriteLiteral("\r\n                </a>\r\n            </div>\r\n");
						goto IL_0483;
					}
					views_Password_LostPassword.WriteLiteral("            <!-- form-->\r\n            ");
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "dba5a6669167e16ed2b4bf024a7d94dc3ebd03091a34aef36ec69b8e3ad8345912436", new Func<Task>(views_Password_LostPassword.<ExecuteAsync>b__23_1));
					views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = views_Password_LostPassword.CreateTagHelper<FormTagHelper>();
					views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = views_Password_LostPassword.CreateTagHelper<RenderAtEndOfFormTagHelper>();
					views_Password_LostPassword.__tagHelperExecutionContext.Add(views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)Views_Password_LostPassword.__tagHelperAttribute_8.Value;
					views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_8);
					views_Password_LostPassword.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Views_Password_LostPassword.__tagHelperAttribute_9.Value;
					views_Password_LostPassword.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Password_LostPassword.__tagHelperAttribute_9);
					views_Password_LostPassword.__tagHelperExecutionContext.AddHtmlAttribute(Views_Password_LostPassword.__tagHelperAttribute_10);
					awaiter3 = views_Password_LostPassword.__tagHelperRunner.RunAsync(views_Password_LostPassword.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						this.<>1__state = 2;
						this.<>u__1 = awaiter3;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<ExecuteAsync>d__23>(ref awaiter3, ref this);
						return;
					}
					IL_03DA:
					awaiter3.GetResult();
					if (views_Password_LostPassword.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0456;
					}
					awaiter4 = views_Password_LostPassword.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Password_LostPassword.<ExecuteAsync>d__23>(ref awaiter4, ref this);
						return;
					}
					IL_044F:
					awaiter4.GetResult();
					IL_0456:
					views_Password_LostPassword.Write(views_Password_LostPassword.__tagHelperExecutionContext.Output);
					views_Password_LostPassword.__tagHelperExecutionContext = views_Password_LostPassword.__tagHelperScopeManager.End();
					views_Password_LostPassword.WriteLiteral("\r\n");
					IL_0483:
					views_Password_LostPassword.WriteLiteral("    </div>\r\n</div>\r\n\r\n");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000AB6 RID: 2742 RVA: 0x0004D690 File Offset: 0x0004B890
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400088A RID: 2186
			public int <>1__state;

			// Token: 0x0400088B RID: 2187
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400088C RID: 2188
			public Views_Password_LostPassword <>4__this;

			// Token: 0x0400088D RID: 2189
			private TaskAwaiter <>u__1;
		}
	}
}
