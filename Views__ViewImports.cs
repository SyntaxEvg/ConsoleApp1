using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HAS.Server.SiteModule.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;

namespace AspNetCoreGeneratedDocument
{
	// Token: 0x0200004E RID: 78
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/_ViewImports.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views__ViewImports : BaseRazorPage<object>
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0000DA28 File Offset: 0x0000BC28
		public override Task ExecuteAsync()
		{
			Views__ViewImports.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views__ViewImports.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000DA6B File Offset: 0x0000BC6B
		// (set) Token: 0x06000398 RID: 920 RVA: 0x0000DA73 File Offset: 0x0000BC73
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		// (set) Token: 0x0600039A RID: 922 RVA: 0x0000DA84 File Offset: 0x0000BC84
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000DA8D File Offset: 0x0000BC8D
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000DA95 File Offset: 0x0000BC95
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000DA9E File Offset: 0x0000BC9E
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000DAA6 File Offset: 0x0000BCA6
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000DAAF File Offset: 0x0000BCAF
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000DAB7 File Offset: 0x0000BCB7
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x02000183 RID: 387
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x06000ADE RID: 2782 RVA: 0x00050248 File Offset: 0x0004E448
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views__ViewImports views__ViewImports = this.<>4__this;
				try
				{
					views__ViewImports.WriteLiteral("\r\n");
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

			// Token: 0x06000ADF RID: 2783 RVA: 0x000502AC File Offset: 0x0004E4AC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008C5 RID: 2245
			public int <>1__state;

			// Token: 0x040008C6 RID: 2246
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008C7 RID: 2247
			public Views__ViewImports <>4__this;
		}
	}
}
