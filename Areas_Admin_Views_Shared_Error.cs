using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using IdentityServer4.Models;
using Mega.Has.Modules.UAS.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200003C RID: 60
	[RazorSourceChecksum("SHA256", "3c021ad78f412eac7c002eec039f2debd18d7e47cb9d3bf4ab340c549adacfcd", "/Areas/Admin/Views/Shared/Error.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/Shared/Error.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views_Shared_Error : BaseRazorPage<ErrorViewModel>
	{
		// Token: 0x0600027D RID: 637 RVA: 0x0000B65C File Offset: 0x0000985C
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views_Shared_Error.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views_Shared_Error.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000B69F File Offset: 0x0000989F
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000B6A7 File Offset: 0x000098A7
		[RazorInject]
		public IWebHostEnvironment Host { get; private set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000B6B0 File Offset: 0x000098B0
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000B6C1 File Offset: 0x000098C1
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000B6C9 File Offset: 0x000098C9
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000B6D2 File Offset: 0x000098D2
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000B6DA File Offset: 0x000098DA
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000B6E3 File Offset: 0x000098E3
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000B6EB File Offset: 0x000098EB
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000B6F4 File Offset: 0x000098F4
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000B6FC File Offset: 0x000098FC
		[RazorInject]
		public IHtmlHelper<ErrorViewModel> Html { get; private set; }

		// Token: 0x0200013C RID: 316
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x06000A13 RID: 2579 RVA: 0x000409B8 File Offset: 0x0003EBB8
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views_Shared_Error areas_Admin_Views_Shared_Error = this.<>4__this;
				try
				{
					areas_Admin_Views_Shared_Error.WriteLiteral("\r\n");
					ErrorViewModel model = areas_Admin_Views_Shared_Error.Model;
					string text;
					if (model == null)
					{
						text = null;
					}
					else
					{
						ErrorMessage error2 = model.Error;
						text = ((error2 != null) ? error2.Error : null);
					}
					string error = text;
					string text2;
					if (!areas_Admin_Views_Shared_Error.Host.IsDevelopment())
					{
						text2 = null;
					}
					else
					{
						ErrorViewModel model2 = areas_Admin_Views_Shared_Error.Model;
						if (model2 == null)
						{
							text2 = null;
						}
						else
						{
							ErrorMessage error3 = model2.Error;
							text2 = ((error3 != null) ? error3.ErrorDescription : null);
						}
					}
					string errorDescription = text2;
					ErrorViewModel model3 = areas_Admin_Views_Shared_Error.Model;
					string text3;
					if (model3 == null)
					{
						text3 = null;
					}
					else
					{
						ErrorMessage error4 = model3.Error;
						text3 = ((error4 != null) ? error4.RequestId : null);
					}
					string request_id = text3;
					areas_Admin_Views_Shared_Error.WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"page-header\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12 col-md-12 col-lg-12\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
					if (error != null)
					{
						areas_Admin_Views_Shared_Error.WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
						areas_Admin_Views_Shared_Error.Write(error);
						areas_Admin_Views_Shared_Error.WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
						if (errorDescription != null)
						{
							areas_Admin_Views_Shared_Error.WriteLiteral("                        <div>");
							areas_Admin_Views_Shared_Error.Write(errorDescription);
							areas_Admin_Views_Shared_Error.WriteLiteral("</div>\r\n");
						}
					}
					areas_Admin_Views_Shared_Error.WriteLiteral("            </div>\r\n\r\n");
					if (request_id != null)
					{
						areas_Admin_Views_Shared_Error.WriteLiteral("                <div class=\"request-id\">Request Id: ");
						areas_Admin_Views_Shared_Error.Write(request_id);
						areas_Admin_Views_Shared_Error.WriteLiteral("</div>\r\n");
					}
					areas_Admin_Views_Shared_Error.WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
				}
				catch (Exception ex)
				{
					this.<>1__state = -2;
					this.<>t__builder.SetException(ex);
					return;
				}
				this.<>1__state = -2;
				this.<>t__builder.SetResult();
			}

			// Token: 0x06000A14 RID: 2580 RVA: 0x00040B10 File Offset: 0x0003ED10
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007AF RID: 1967
			public int <>1__state;

			// Token: 0x040007B0 RID: 1968
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007B1 RID: 1969
			public Areas_Admin_Views_Shared_Error <>4__this;
		}
	}
}
