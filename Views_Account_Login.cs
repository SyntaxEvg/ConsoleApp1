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
using Mega.Has.Modules.UAS.Models;
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
	// Token: 0x02000046 RID: 70
	[RazorSourceChecksum("SHA256", "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c", "/Views/Account/Login.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/Account/Login.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views_Account_Login : BaseRazorPage<LoginViewModel>
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000C603 File Offset: 0x0000A803
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

		// Token: 0x06000312 RID: 786 RVA: 0x0000C638 File Offset: 0x0000A838
		public override Task ExecuteAsync()
		{
			Views_Account_Login.<ExecuteAsync>d__29 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views_Account_Login.<ExecuteAsync>d__29>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000C67B File Offset: 0x0000A87B
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000C683 File Offset: 0x0000A883
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000C68C File Offset: 0x0000A88C
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000C694 File Offset: 0x0000A894
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000C69D File Offset: 0x0000A89D
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000C6A5 File Offset: 0x0000A8A5
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000C6AE File Offset: 0x0000A8AE
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000C6B6 File Offset: 0x0000A8B6
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000C6BF File Offset: 0x0000A8BF
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000C6C7 File Offset: 0x0000A8C7
		[RazorInject]
		public IHtmlHelper<LoginViewModel> Html { get; private set; }

		// Token: 0x0600031F RID: 799 RVA: 0x0000C854 File Offset: 0x0000AA54
		[CompilerGenerated]
		private Task <ExecuteAsync>b__29_3()
		{
			Views_Account_Login.<<ExecuteAsync>b__29_3>d <<ExecuteAsync>b__29_3>d;
			<<ExecuteAsync>b__29_3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__29_3>d.<>4__this = this;
			<<ExecuteAsync>b__29_3>d.<>1__state = -1;
			<<ExecuteAsync>b__29_3>d.<>t__builder.Start<Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref <<ExecuteAsync>b__29_3>d);
			return <<ExecuteAsync>b__29_3>d.<>t__builder.Task;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000C898 File Offset: 0x0000AA98
		[CompilerGenerated]
		private Task <ExecuteAsync>b__29_7()
		{
			Views_Account_Login.<<ExecuteAsync>b__29_7>d <<ExecuteAsync>b__29_7>d;
			<<ExecuteAsync>b__29_7>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__29_7>d.<>4__this = this;
			<<ExecuteAsync>b__29_7>d.<>1__state = -1;
			<<ExecuteAsync>b__29_7>d.<>t__builder.Start<Views_Account_Login.<<ExecuteAsync>b__29_7>d>(ref <<ExecuteAsync>b__29_7>d);
			return <<ExecuteAsync>b__29_7>d.<>t__builder.Task;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000C8DC File Offset: 0x0000AADC
		[CompilerGenerated]
		private Task <ExecuteAsync>b__29_11()
		{
			Views_Account_Login.<<ExecuteAsync>b__29_11>d <<ExecuteAsync>b__29_11>d;
			<<ExecuteAsync>b__29_11>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__29_11>d.<>4__this = this;
			<<ExecuteAsync>b__29_11>d.<>1__state = -1;
			<<ExecuteAsync>b__29_11>d.<>t__builder.Start<Views_Account_Login.<<ExecuteAsync>b__29_11>d>(ref <<ExecuteAsync>b__29_11>d);
			return <<ExecuteAsync>b__29_11>d.<>t__builder.Task;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000C920 File Offset: 0x0000AB20
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		[CompilerGenerated]
		private Task <ExecuteAsync>b__29_4()
		{
			Views_Account_Login.<<ExecuteAsync>b__29_4>d <<ExecuteAsync>b__29_4>d;
			<<ExecuteAsync>b__29_4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
			<<ExecuteAsync>b__29_4>d.<>4__this = this;
			<<ExecuteAsync>b__29_4>d.<>1__state = -1;
			<<ExecuteAsync>b__29_4>d.<>t__builder.Start<Views_Account_Login.<<ExecuteAsync>b__29_4>d>(ref <<ExecuteAsync>b__29_4>d);
			return <<ExecuteAsync>b__29_4>d.<>t__builder.Task;
		}

		// Token: 0x040002D4 RID: 724
		private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", "/_customs/has.uas/images/logo-H.png", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002D5 RID: 725
		private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("class", new HtmlString("titleimg"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002D6 RID: 726
		private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("alt", new HtmlString("HOPEX"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002D7 RID: 727
		private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", new HtmlString("col"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002D8 RID: 728
		private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("type", "hidden", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002D9 RID: 729
		private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("value", "", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DA RID: 730
		private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("class", new HtmlString("form-select bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DB RID: 731
		private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("type", "password", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DC RID: 732
		private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("class", new HtmlString("form-control bg-light"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DD RID: 733
		private static readonly TagHelperAttribute __tagHelperAttribute_9 = new TagHelperAttribute("autocomplete", new HtmlString("off"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DE RID: 734
		private static readonly TagHelperAttribute __tagHelperAttribute_10 = new TagHelperAttribute("asp-route", "Login", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002DF RID: 735
		private static readonly TagHelperAttribute __tagHelperAttribute_11 = new TagHelperAttribute("class", new HtmlString("form-signin mx-auto"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002E0 RID: 736
		private static readonly TagHelperAttribute __tagHelperAttribute_12 = new TagHelperAttribute("method", "post", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002E1 RID: 737
		private static readonly TagHelperAttribute __tagHelperAttribute_13 = new TagHelperAttribute("id", new HtmlString("loginForm"), HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002E2 RID: 738
		private static readonly TagHelperAttribute __tagHelperAttribute_14 = new TagHelperAttribute("src", "/uas/js/login.js", HtmlAttributeValueStyle.DoubleQuotes);

		// Token: 0x040002E3 RID: 739
		private TagHelperExecutionContext __tagHelperExecutionContext;

		// Token: 0x040002E4 RID: 740
		private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

		// Token: 0x040002E5 RID: 741
		private string __tagHelperStringValueBuffer;

		// Token: 0x040002E6 RID: 742
		private TagHelperScopeManager __backed__tagHelperScopeManager;

		// Token: 0x040002E7 RID: 743
		private ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;

		// Token: 0x040002E8 RID: 744
		private ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;

		// Token: 0x040002E9 RID: 745
		private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

		// Token: 0x040002EA RID: 746
		private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

		// Token: 0x040002EB RID: 747
		private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

		// Token: 0x040002EC RID: 748
		private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

		// Token: 0x040002ED RID: 749
		private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

		// Token: 0x040002EE RID: 750
		private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

		// Token: 0x0200015C RID: 348
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__29_11>d : IAsyncStateMachine
		{
			// Token: 0x06000A6E RID: 2670 RVA: 0x00046CD0 File Offset: 0x00044ED0
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Login views_Account_Login = this.<>4__this;
				try
				{
					views_Account_Login.Write(views_Account_Login.T["Select your environment"]);
					views_Account_Login.WriteLiteral("...");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x00046D48 File Offset: 0x00044F48
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000829 RID: 2089
			public int <>1__state;

			// Token: 0x0400082A RID: 2090
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400082B RID: 2091
			public Views_Account_Login <>4__this;
		}

		// Token: 0x0200015D RID: 349
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__29_3>d : IAsyncStateMachine
		{
			// Token: 0x06000A70 RID: 2672 RVA: 0x00046D58 File Offset: 0x00044F58
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Login views_Account_Login = this.<>4__this;
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter awaiter2;
					TaskAwaiter awaiter3;
					TaskAwaiter awaiter4;
					TaskAwaiter awaiter5;
					TaskAwaiter awaiter6;
					ParameterExpression parameterExpression;
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
						goto IL_0289;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0427;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_049C;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_0976;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						num = (this.<>1__state = -1);
						goto IL_09EB;
					default:
						views_Account_Login.WriteLiteral("\r\n            <!-- Environment -->\r\n");
						if (views_Account_Login.Model.Environments == null)
						{
							goto IL_04D0;
						}
						if (views_Account_Login.Model.Environments.Count<SelectListItem>() == 1)
						{
							views_Account_Login.WriteLiteral("                    ");
							views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c21957", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_5));
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Login.CreateTagHelper<InputTagHelper>();
							views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
							InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
							IModelExpressionProvider modelExpressionProvider = views_Account_Login.ModelExpressionProvider;
							ViewDataDictionary<LoginViewModel> viewData = views_Account_Login.ViewData;
							parameterExpression = Expression.Parameter(typeof(LoginViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider.CreateModelExpression<LoginViewModel, string>(viewData, Expression.Lambda<Func<LoginViewModel, string>>(Expression.Property(parameterExpression, methodof(LoginInputModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Login.__tagHelperAttribute_4.Value;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_4);
							views_Account_Login.BeginWriteTagHelperAttribute();
							views_Account_Login.WriteLiteral(views_Account_Login.Model.Environments.First<SelectListItem>().Value);
							views_Account_Login.__tagHelperStringValueBuffer = views_Account_Login.EndWriteTagHelperAttribute();
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = views_Account_Login.__tagHelperStringValueBuffer;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("value", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (this.<>1__state = 0);
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							views_Account_Login.WriteLiteral("                    <div class=\"form-group my-4 mx-5\">\r\n                        ");
							views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("select", TagMode.StartTagAndEndTag, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c24749", new Func<Task>(views_Account_Login.<ExecuteAsync>b__29_7));
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Account_Login.CreateTagHelper<SelectTagHelper>();
							views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
							SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
							IModelExpressionProvider modelExpressionProvider2 = views_Account_Login.ModelExpressionProvider;
							ViewDataDictionary<LoginViewModel> viewData2 = views_Account_Login.ViewData;
							parameterExpression = Expression.Parameter(typeof(LoginViewModel), "__model");
							_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider2.CreateModelExpression<LoginViewModel, string>(viewData2, Expression.Lambda<Func<LoginViewModel, string>>(Expression.Property(parameterExpression, methodof(LoginInputModel.get_EnvironmentId())), new ParameterExpression[] { parameterExpression }));
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = views_Account_Login.Model.Environments;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, HtmlAttributeValueStyle.DoubleQuotes);
							views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_6);
							awaiter3 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (this.<>1__state = 2);
								this.<>u__1 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter3, ref this);
								return;
							}
							goto IL_0427;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0290;
					}
					awaiter2 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (this.<>1__state = 1);
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter2, ref this);
						return;
					}
					IL_0289:
					awaiter2.GetResult();
					IL_0290:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n");
					goto IL_04D0;
					IL_0427:
					awaiter3.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_04A3;
					}
					awaiter4 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (this.<>1__state = 3);
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter4, ref this);
						return;
					}
					IL_049C:
					awaiter4.GetResult();
					IL_04A3:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n                    </div>\r\n");
					IL_04D0:
					views_Account_Login.WriteLiteral("\r\n");
					if (views_Account_Login.Model.VisibleExternalProviders.Any<ExternalProvider>())
					{
						views_Account_Login.WriteLiteral("                <h6>");
						views_Account_Login.Write(views_Account_Login.T["Login with"]);
						views_Account_Login.WriteLiteral(" </h6>\r\n                <div class=\"row mx-1 my-3\">\r\n");
						IEnumerator<ExternalProvider> enumerator = views_Account_Login.Model.VisibleExternalProviders.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ExternalProvider provider = enumerator.Current;
								views_Account_Login.WriteLiteral("                        <div class=\"col mb-3\">\r\n                            <a class=\"btn btn-secondary text-white btn-sso-login\"");
								views_Account_Login.BeginWriteAttribute("onclick", " onclick=\"", 3671, "\"", 3739, 6);
								views_Account_Login.WriteAttributeValue("", 3681, "ExternalLogin('", 3681, 15, true);
								views_Account_Login.WriteAttributeValue("", 3696, provider.DisplayName, 3696, 21, false);
								views_Account_Login.WriteAttributeValue("", 3717, "',", 3717, 2, true);
								views_Account_Login.WriteAttributeValue(" ", 3719, "'", 3720, 2, true);
								views_Account_Login.WriteAttributeValue("", 3721, views_Account_Login.Model.ReturnUrl, 3721, 16, false);
								views_Account_Login.WriteAttributeValue("", 3737, "')", 3737, 2, true);
								views_Account_Login.EndWriteAttribute();
								views_Account_Login.WriteLiteral(">\r\n                                <span class=\"fa fa-share-alt\"></span>\r\n                                ");
								views_Account_Login.Write(provider.DisplayName);
								views_Account_Login.WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n");
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						views_Account_Login.WriteLiteral("                </div>\r\n");
						if (views_Account_Login.Model.ShowBasicSignin)
						{
							views_Account_Login.WriteLiteral("                    <!-- OR -->\r\n                    <div class=\"login-or\">\r\n                        <hr class=\"hr-or\">\r\n                        <span class=\"span-or\">");
							views_Account_Login.Write(views_Account_Login.T["or"]);
							views_Account_Login.WriteLiteral("</span>\r\n                    </div>\r\n");
						}
					}
					views_Account_Login.WriteLiteral("\r\n");
					if (!views_Account_Login.Model.ShowBasicSignin)
					{
						goto IL_0A50;
					}
					views_Account_Login.WriteLiteral("                <!-- Basic -->\r\n                <div class=\"form-group my-4 mx-5\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">");
					views_Account_Login.Write(views_Account_Login.T["login"]);
					views_Account_Login.WriteLiteral("</label></div></div>\r\n                    <input class=\"form-control bg-light\" autofocus autocomplete=\"off\"");
					views_Account_Login.BeginWriteAttribute("placeholder", " placeholder=\"", 4664, "\"", 4689, 1);
					views_Account_Login.WriteAttributeValue("", 4678, views_Account_Login.T["login"], 4678, 11, false);
					views_Account_Login.EndWriteAttribute();
					views_Account_Login.BeginWriteAttribute("value", " value=\"", 4690, "\"", 4713, 1);
					views_Account_Login.WriteAttributeValue("", 4698, views_Account_Login.Model.UserName, 4698, 15, false);
					views_Account_Login.EndWriteAttribute();
					views_Account_Login.WriteLiteral(" name=\"UserName\" id=\"UserName\" />\r\n                </div>\r\n");
					views_Account_Login.WriteLiteral("                <div class=\"form-group my-4 mx-5\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">");
					views_Account_Login.Write(views_Account_Login.T["password"]);
					views_Account_Login.WriteLiteral("</label></div></div>\r\n                    <div class=\"input-group\" id=\"show_hide_password\">\r\n                        ");
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("input", TagMode.SelfClosing, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c35275", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_9));
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = views_Account_Login.CreateTagHelper<InputTagHelper>();
					views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)Views_Account_Login.__tagHelperAttribute_7.Value;
					views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_7);
					views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_8);
					views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_9);
					InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					IModelExpressionProvider modelExpressionProvider3 = views_Account_Login.ModelExpressionProvider;
					ViewDataDictionary<LoginViewModel> viewData3 = views_Account_Login.ViewData;
					parameterExpression = Expression.Parameter(typeof(LoginViewModel), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<LoginViewModel, string>(viewData3, Expression.Lambda<Func<LoginViewModel, string>>(Expression.Property(parameterExpression, methodof(LoginInputModel.get_Password())), new ParameterExpression[] { parameterExpression }));
					views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Login.BeginAddHtmlAttributeValues(views_Account_Login.__tagHelperExecutionContext, "placeholder", 1, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Login.AddHtmlAttributeValue("", 5174, views_Account_Login.T["password"], 5174, 14, false);
					views_Account_Login.EndAddHtmlAttributeValues(views_Account_Login.__tagHelperExecutionContext);
					awaiter5 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						num = (this.<>1__state = 4);
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter5, ref this);
						return;
					}
					IL_0976:
					awaiter5.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_09F2;
					}
					awaiter6 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						num = (this.<>1__state = 5);
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_3>d>(ref awaiter6, ref this);
						return;
					}
					IL_09EB:
					awaiter6.GetResult();
					IL_09F2:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n                        <a class=\"input-group-text eye\"");
					views_Account_Login.BeginWriteAttribute("href", " href=\"", 5249, "\"", 5256, 0);
					views_Account_Login.EndWriteAttribute();
					views_Account_Login.WriteLiteral(" >\r\n                            <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n");
					IL_0A50:
					views_Account_Login.WriteLiteral("            <div class=\"mt-auto swapcontainer\">\r\n\r\n                <!-- Button -->\r\n");
					if (views_Account_Login.Model.ShowBasicSignin)
					{
						views_Account_Login.WriteLiteral("                    <button class=\"btn btn-hopex btn-success mx-50 my-20 first_div\" type=\"submit\" id=\"btnSubmit\">");
						views_Account_Login.Write(views_Account_Login.T["Sign in"]);
						views_Account_Login.WriteLiteral("</button>\r\n");
					}
					views_Account_Login.WriteLiteral("\r\n");
					if (views_Account_Login.Model.ShowBasicSignin && !views_Account_Login.Model.IsSetupMode)
					{
						views_Account_Login.WriteLiteral("                        <div class=\"mx-5 text-center mb-2 second_div forgot-password\">\r\n                            <i class=\"mx-2 fa fa-key show-v6\" style=\"display:none\"></i>\r\n\r\n                            <a href=\"/uas/password/lostpassword\" class=\"text-dark\">\r\n                                <h6 class=\"d-inline\">");
						views_Account_Login.Write(views_Account_Login.T["Forgot password"]);
						views_Account_Login.WriteLiteral("</h6>\r\n                            </a>\r\n                        </div>\r\n");
					}
					views_Account_Login.WriteLiteral("\r\n");
					if (!views_Account_Login.Model.IsInitialized)
					{
						views_Account_Login.WriteLiteral("                    <div class=\"text-center mb-2\">\r\n                        <h6>");
						views_Account_Login.Write(views_Account_Login.T["SETUP MODE - Use default login"]);
						views_Account_Login.WriteLiteral("</h6>\r\n                    </div>\r\n");
					}
					views_Account_Login.WriteLiteral("\r\n\r\n            </div>\r\n        ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x000478FC File Offset: 0x00045AFC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400082C RID: 2092
			public int <>1__state;

			// Token: 0x0400082D RID: 2093
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400082E RID: 2094
			public Views_Account_Login <>4__this;

			// Token: 0x0400082F RID: 2095
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200015E RID: 350
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__29_4>d : IAsyncStateMachine
		{
			// Token: 0x06000A72 RID: 2674 RVA: 0x0004790C File Offset: 0x00045B0C
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Login views_Account_Login = this.<>4__this;
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
							goto IL_01A8;
						}
						views_Account_Login.WriteLiteral("\r\n    ");
						views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("script", TagMode.StartTagAndEndTag, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c45613", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_12));
						views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = views_Account_Login.CreateTagHelper<ScriptTagHelper>();
						views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
						views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)Views_Account_Login.__tagHelperAttribute_14.Value;
						views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_14);
						views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = new bool?(true);
						views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
						awaiter2 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_4>d>(ref awaiter2, ref this);
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
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_01AF;
					}
					awaiter = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_4>d>(ref awaiter, ref this);
						return;
					}
					IL_01A8:
					awaiter.GetResult();
					IL_01AF:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n    <script>\r\n        function GoToRedirectUri(returnUrl) {\r\n            var urlParams = new URLSearchParams(returnUrl);\r\n            var redirectUri = urlParams.get('redirect_uri');\r\n            redirectUri = redirectUri.replace('/signin-oidc', '');\r\n            window.location.href = redirectUri;\r\n        }\r\n    </script>\r\n");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A73 RID: 2675 RVA: 0x00047B40 File Offset: 0x00045D40
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000830 RID: 2096
			public int <>1__state;

			// Token: 0x04000831 RID: 2097
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000832 RID: 2098
			public Views_Account_Login <>4__this;

			// Token: 0x04000833 RID: 2099
			private TaskAwaiter <>u__1;
		}

		// Token: 0x0200015F RID: 351
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <<ExecuteAsync>b__29_7>d : IAsyncStateMachine
		{
			// Token: 0x06000A74 RID: 2676 RVA: 0x00047B50 File Offset: 0x00045D50
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Login views_Account_Login = this.<>4__this;
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
						views_Account_Login.WriteLiteral("\r\n                            ");
						views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("option", TagMode.StartTagAndEndTag, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c25070", new Func<Task>(views_Account_Login.<ExecuteAsync>b__29_11));
						views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = views_Account_Login.CreateTagHelper<OptionTagHelper>();
						views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
						views_Account_Login.BeginWriteTagHelperAttribute();
						views_Account_Login.__tagHelperStringValueBuffer = views_Account_Login.EndWriteTagHelperAttribute();
						views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute("disabled", views_Account_Login.Html.Raw(views_Account_Login.__tagHelperStringValueBuffer), HtmlAttributeValueStyle.Minimized);
						views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)Views_Account_Login.__tagHelperAttribute_5.Value;
						views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_5);
						awaiter2 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							this.<>1__state = 0;
							this.<>u__1 = awaiter2;
							this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_7>d>(ref awaiter2, ref this);
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
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_019E;
					}
					awaiter = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<<ExecuteAsync>b__29_7>d>(ref awaiter, ref this);
						return;
					}
					IL_0197:
					awaiter.GetResult();
					IL_019E:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n                        ");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x00047D74 File Offset: 0x00045F74
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x04000834 RID: 2100
			public int <>1__state;

			// Token: 0x04000835 RID: 2101
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000836 RID: 2102
			public Views_Account_Login <>4__this;

			// Token: 0x04000837 RID: 2103
			private TaskAwaiter <>u__1;
		}

		// Token: 0x02000160 RID: 352
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000A78 RID: 2680 RVA: 0x00047D98 File Offset: 0x00045F98
			internal Task <ExecuteAsync>b__29_0()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_0>d <<ExecuteAsync>b__29_0>d;
				<<ExecuteAsync>b__29_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_0>d.<>1__state = -1;
				<<ExecuteAsync>b__29_0>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_0>d>(ref <<ExecuteAsync>b__29_0>d);
				return <<ExecuteAsync>b__29_0>d.<>t__builder.Task;
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x00047DD4 File Offset: 0x00045FD4
			internal Task <ExecuteAsync>b__29_1()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_1>d <<ExecuteAsync>b__29_1>d;
				<<ExecuteAsync>b__29_1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_1>d.<>1__state = -1;
				<<ExecuteAsync>b__29_1>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_1>d>(ref <<ExecuteAsync>b__29_1>d);
				return <<ExecuteAsync>b__29_1>d.<>t__builder.Task;
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x00047E10 File Offset: 0x00046010
			internal Task <ExecuteAsync>b__29_2()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_2>d <<ExecuteAsync>b__29_2>d;
				<<ExecuteAsync>b__29_2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_2>d.<>1__state = -1;
				<<ExecuteAsync>b__29_2>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_2>d>(ref <<ExecuteAsync>b__29_2>d);
				return <<ExecuteAsync>b__29_2>d.<>t__builder.Task;
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00047E4C File Offset: 0x0004604C
			internal Task <ExecuteAsync>b__29_5()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_5>d <<ExecuteAsync>b__29_5>d;
				<<ExecuteAsync>b__29_5>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_5>d.<>1__state = -1;
				<<ExecuteAsync>b__29_5>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_5>d>(ref <<ExecuteAsync>b__29_5>d);
				return <<ExecuteAsync>b__29_5>d.<>t__builder.Task;
			}

			// Token: 0x06000A7C RID: 2684 RVA: 0x00047E88 File Offset: 0x00046088
			internal Task <ExecuteAsync>b__29_9()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_9>d <<ExecuteAsync>b__29_9>d;
				<<ExecuteAsync>b__29_9>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_9>d.<>1__state = -1;
				<<ExecuteAsync>b__29_9>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_9>d>(ref <<ExecuteAsync>b__29_9>d);
				return <<ExecuteAsync>b__29_9>d.<>t__builder.Task;
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x00047EC4 File Offset: 0x000460C4
			internal Task <ExecuteAsync>b__29_12()
			{
				Views_Account_Login.<>c.<<ExecuteAsync>b__29_12>d <<ExecuteAsync>b__29_12>d;
				<<ExecuteAsync>b__29_12>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<ExecuteAsync>b__29_12>d.<>1__state = -1;
				<<ExecuteAsync>b__29_12>d.<>t__builder.Start<Views_Account_Login.<>c.<<ExecuteAsync>b__29_12>d>(ref <<ExecuteAsync>b__29_12>d);
				return <<ExecuteAsync>b__29_12>d.<>t__builder.Task;
			}

			// Token: 0x04000838 RID: 2104
			public static readonly Views_Account_Login.<>c <>9 = new Views_Account_Login.<>c();

			// Token: 0x04000839 RID: 2105
			public static Func<Task> <>9__29_0;

			// Token: 0x0400083A RID: 2106
			public static Func<Task> <>9__29_1;

			// Token: 0x0400083B RID: 2107
			public static Func<Task> <>9__29_2;

			// Token: 0x0400083C RID: 2108
			public static Func<Task> <>9__29_5;

			// Token: 0x0400083D RID: 2109
			public static Func<Task> <>9__29_9;

			// Token: 0x0400083E RID: 2110
			public static Func<Task> <>9__29_12;

			// Token: 0x02000330 RID: 816
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_0>d : IAsyncStateMachine
			{
				// Token: 0x06000F6E RID: 3950 RVA: 0x00075D48 File Offset: 0x00073F48
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

				// Token: 0x06000F6F RID: 3951 RVA: 0x00075D98 File Offset: 0x00073F98
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F03 RID: 3843
				public int <>1__state;

				// Token: 0x04000F04 RID: 3844
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000331 RID: 817
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_12>d : IAsyncStateMachine
			{
				// Token: 0x06000F70 RID: 3952 RVA: 0x00075DA8 File Offset: 0x00073FA8
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

				// Token: 0x06000F71 RID: 3953 RVA: 0x00075DF8 File Offset: 0x00073FF8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F05 RID: 3845
				public int <>1__state;

				// Token: 0x04000F06 RID: 3846
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000332 RID: 818
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_1>d : IAsyncStateMachine
			{
				// Token: 0x06000F72 RID: 3954 RVA: 0x00075E08 File Offset: 0x00074008
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

				// Token: 0x06000F73 RID: 3955 RVA: 0x00075E58 File Offset: 0x00074058
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F07 RID: 3847
				public int <>1__state;

				// Token: 0x04000F08 RID: 3848
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000333 RID: 819
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_2>d : IAsyncStateMachine
			{
				// Token: 0x06000F74 RID: 3956 RVA: 0x00075E68 File Offset: 0x00074068
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

				// Token: 0x06000F75 RID: 3957 RVA: 0x00075EB8 File Offset: 0x000740B8
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F09 RID: 3849
				public int <>1__state;

				// Token: 0x04000F0A RID: 3850
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000334 RID: 820
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_5>d : IAsyncStateMachine
			{
				// Token: 0x06000F76 RID: 3958 RVA: 0x00075EC8 File Offset: 0x000740C8
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

				// Token: 0x06000F77 RID: 3959 RVA: 0x00075F18 File Offset: 0x00074118
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F0B RID: 3851
				public int <>1__state;

				// Token: 0x04000F0C RID: 3852
				public AsyncTaskMethodBuilder <>t__builder;
			}

			// Token: 0x02000335 RID: 821
			[StructLayout(LayoutKind.Auto)]
			private struct <<ExecuteAsync>b__29_9>d : IAsyncStateMachine
			{
				// Token: 0x06000F78 RID: 3960 RVA: 0x00075F28 File Offset: 0x00074128
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

				// Token: 0x06000F79 RID: 3961 RVA: 0x00075F78 File Offset: 0x00074178
				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
				{
					this.<>t__builder.SetStateMachine(stateMachine);
				}

				// Token: 0x04000F0D RID: 3853
				public int <>1__state;

				// Token: 0x04000F0E RID: 3854
				public AsyncTaskMethodBuilder <>t__builder;
			}
		}

		// Token: 0x02000161 RID: 353
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__29 : IAsyncStateMachine
		{
			// Token: 0x06000A7E RID: 2686 RVA: 0x00047F00 File Offset: 0x00046100
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views_Account_Login views_Account_Login = this.<>4__this;
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
						goto IL_01FA;
					case 2:
						awaiter3 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_03D7;
					case 3:
						awaiter4 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_044C;
					case 4:
						awaiter5 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_066B;
					case 5:
						awaiter6 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_06E0;
					case 6:
						awaiter7 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_0857;
					case 7:
						awaiter8 = this.<>u__1;
						this.<>u__1 = default(TaskAwaiter);
						this.<>1__state = -1;
						goto IL_08CC;
					default:
						views_Account_Login.WriteLiteral("\r\n");
						if (views_Account_Login.Model.IsLoginDisabled)
						{
							views_Account_Login.WriteLiteral("    <div class=\"p-0 py-3 account-login border shadow rounded d-flex align-items-start flex-column justify-content-center\">\r\n        <div class=\"py-3 mx-auto\">\r\n            ");
							views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c10026", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_0));
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_Login.CreateTagHelper<ImageTagHelper>();
							views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_Login.__tagHelperAttribute_0.Value;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_0);
							views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_1);
							views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_2);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.<>1__state = 0;
								this.<>u__1 = awaiter;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							views_Account_Login.WriteLiteral("    <div class=\"p-0 py-3 account-login border shadow rounded d-flex align-items-start flex-column justify-content-center\">\r\n        <div class=\"py-3 mx-auto\">\r\n            ");
							views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("img", TagMode.SelfClosing, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c14038", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_1));
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = views_Account_Login.CreateTagHelper<ImageTagHelper>();
							views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)Views_Account_Login.__tagHelperAttribute_0.Value;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_0);
							views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_1);
							views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_2);
							views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;
							views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, HtmlAttributeValueStyle.DoubleQuotes);
							awaiter3 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								this.<>1__state = 2;
								this.<>u__1 = awaiter3;
								this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter3, ref this);
								return;
							}
							goto IL_03D7;
						}
						break;
					}
					awaiter.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0201;
					}
					awaiter2 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						this.<>1__state = 1;
						this.<>u__1 = awaiter2;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter2, ref this);
						return;
					}
					IL_01FA:
					awaiter2.GetResult();
					IL_0201:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n        </div>\r\n        <div class=\"mx-auto py-1 module-name\">\r\n");
					if (!views_Account_Login.Model.HideFriendlyName)
					{
						views_Account_Login.Write(views_Account_Login.Model.ModuleFriendlyName);
					}
					views_Account_Login.WriteLiteral("        </div>\r\n\r\n");
					if (views_Account_Login.Model.Message != null)
					{
						views_Account_Login.WriteLiteral("            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                <div class=\"col\">");
						views_Account_Login.Write(views_Account_Login.Model.Message);
						views_Account_Login.WriteLiteral("</div>\r\n            </div>\r\n");
					}
					views_Account_Login.WriteLiteral("    </div>\r\n");
					goto IL_0A1E;
					IL_03D7:
					awaiter3.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_0453;
					}
					awaiter4 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						this.<>1__state = 3;
						this.<>u__1 = awaiter4;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter4, ref this);
						return;
					}
					IL_044C:
					awaiter4.GetResult();
					IL_0453:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n        </div>\r\n        <div class=\"mx-auto py-1 module-name\">\r\n");
					if (!views_Account_Login.Model.HideFriendlyName)
					{
						views_Account_Login.Write(views_Account_Login.Model.ModuleFriendlyName);
					}
					views_Account_Login.WriteLiteral("        </div>\r\n\r\n");
					if (views_Account_Login.Model.Message != null)
					{
						views_Account_Login.WriteLiteral("            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                <div class=\"col\">");
						views_Account_Login.Write(views_Account_Login.Model.Message);
						views_Account_Login.WriteLiteral("</div>\r\n            </div>\r\n");
					}
					views_Account_Login.WriteLiteral("        <!-- warning-->\r\n");
					if (!views_Account_Login.Model.ShowBasicSignin && !views_Account_Login.Model.VisibleExternalProviders.Any<ExternalProvider>())
					{
						views_Account_Login.WriteLiteral("            <div class=\"alert alert-warning mx-auto error-login-page\">\r\n                <strong>");
						views_Account_Login.Write(views_Account_Login.T["Invalid login request"]);
						views_Account_Login.WriteLiteral("</strong>\r\n                <br />\r\n                ");
						views_Account_Login.Write(views_Account_Login.T["There are no login schemes configured for this client."]);
						views_Account_Login.WriteLiteral("\r\n            </div>\r\n");
					}
					if (views_Account_Login.ViewContext.ModelState.IsValid)
					{
						goto IL_0714;
					}
					views_Account_Login.WriteLiteral("            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                ");
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("div", TagMode.StartTagAndEndTag, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c19369", new Func<Task>(Views_Account_Login.<>c.<>9.<ExecuteAsync>b__29_2));
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = views_Account_Login.CreateTagHelper<ValidationSummaryTagHelper>();
					views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = ValidationSummary.All;
					views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, HtmlAttributeValueStyle.DoubleQuotes);
					views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_3);
					awaiter5 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter5.IsCompleted)
					{
						this.<>1__state = 4;
						this.<>u__1 = awaiter5;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter5, ref this);
						return;
					}
					IL_066B:
					awaiter5.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_06E7;
					}
					awaiter6 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter6.IsCompleted)
					{
						this.<>1__state = 5;
						this.<>u__1 = awaiter6;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter6, ref this);
						return;
					}
					IL_06E0:
					awaiter6.GetResult();
					IL_06E7:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n            </div>\r\n");
					IL_0714:
					views_Account_Login.WriteLiteral("        <!-- form-->\r\n        ");
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.Begin("form", TagMode.StartTagAndEndTag, "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c21276", new Func<Task>(views_Account_Login.<ExecuteAsync>b__29_3));
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = views_Account_Login.CreateTagHelper<FormTagHelper>();
					views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = views_Account_Login.CreateTagHelper<RenderAtEndOfFormTagHelper>();
					views_Account_Login.__tagHelperExecutionContext.Add(views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)Views_Account_Login.__tagHelperAttribute_10.Value;
					views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_10);
					views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_11);
					views_Account_Login.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)Views_Account_Login.__tagHelperAttribute_12.Value;
					views_Account_Login.__tagHelperExecutionContext.AddTagHelperAttribute(Views_Account_Login.__tagHelperAttribute_12);
					views_Account_Login.__tagHelperExecutionContext.AddHtmlAttribute(Views_Account_Login.__tagHelperAttribute_13);
					awaiter7 = views_Account_Login.__tagHelperRunner.RunAsync(views_Account_Login.__tagHelperExecutionContext).GetAwaiter();
					if (!awaiter7.IsCompleted)
					{
						this.<>1__state = 6;
						this.<>u__1 = awaiter7;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter7, ref this);
						return;
					}
					IL_0857:
					awaiter7.GetResult();
					if (views_Account_Login.__tagHelperExecutionContext.Output.IsContentModified)
					{
						goto IL_08D3;
					}
					awaiter8 = views_Account_Login.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!awaiter8.IsCompleted)
					{
						this.<>1__state = 7;
						this.<>u__1 = awaiter8;
						this.<>t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, Views_Account_Login.<ExecuteAsync>d__29>(ref awaiter8, ref this);
						return;
					}
					IL_08CC:
					awaiter8.GetResult();
					IL_08D3:
					views_Account_Login.Write(views_Account_Login.__tagHelperExecutionContext.Output);
					views_Account_Login.__tagHelperExecutionContext = views_Account_Login.__tagHelperScopeManager.End();
					views_Account_Login.WriteLiteral("\r\n        <!-- Timeout message -->\r\n        <div id=\"timeout\" style=\"display: none;\" class=\"mx-auto\">\r\n            <p class=\"alert alert-dark text-center p-3 m-3\">");
					views_Account_Login.Write(views_Account_Login.T["You took too long to login, please try again now."]);
					views_Account_Login.WriteLiteral("</p>\r\n            <button class=\"btn btn-hopex btn-success mx-50 my-20\"");
					views_Account_Login.BeginWriteAttribute("onclick", " onclick=\"", 7039, "\"", 7085, 3);
					views_Account_Login.WriteAttributeValue("", 7049, "GoToRedirectUri('", 7049, 17, true);
					views_Account_Login.WriteAttributeValue("", 7066, views_Account_Login.Model.ReturnUrl, 7066, 16, false);
					views_Account_Login.WriteAttributeValue("", 7082, "');", 7082, 3, true);
					views_Account_Login.EndWriteAttribute();
					views_Account_Login.WriteLiteral(">");
					views_Account_Login.Write(views_Account_Login.T["OK"]);
					views_Account_Login.WriteLiteral("</button>\r\n        </div>\r\n\r\n");
					views_Account_Login.WriteLiteral("        <div class=\"mt-5 mb-3 footer w-100 show-v6 text-dark\" style=\"display:none;\">\r\n            <label>\r\n                ");
					RazorPageBase razorPageBase = views_Account_Login;
					LoginViewModel model = views_Account_Login.Model;
					razorPageBase.Write((model != null) ? model.MegaInfo : null);
					views_Account_Login.WriteLiteral(" <br>\r\n                <a class=\"text-white privacy-link\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#privacyModal\">");
					views_Account_Login.Write(views_Account_Login.T["Privacy and Cookie Policy"]);
					views_Account_Login.WriteLiteral("</a>\r\n            </label>\r\n        </div>\r\n\r\n    </div>\r\n");
					IL_0A1E:
					views_Account_Login.WriteLiteral("\r\n");
					views_Account_Login.DefineSection("Scripts", new RenderAsyncDelegate(views_Account_Login.<ExecuteAsync>b__29_4));
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00048998 File Offset: 0x00046B98
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x0400083F RID: 2111
			public int <>1__state;

			// Token: 0x04000840 RID: 2112
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000841 RID: 2113
			public Views_Account_Login <>4__this;

			// Token: 0x04000842 RID: 2114
			private TaskAwaiter <>u__1;
		}
	}
}
