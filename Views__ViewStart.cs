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
	// Token: 0x0200004F RID: 79
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "47e02b4da20d198892b7b1b00b12944068797c438ef2e82d20ff70b4d56bad39", "/Views/_ViewStart.cshtml")]
	[RazorSourceChecksum("SHA256", "c68eee8ac38defce2d4a072bcc9cf01bbc2882ac7d678ff69084a79c4d2ae0a8", "/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Views/_ViewStart.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Views__ViewStart : BaseRazorPage<object>
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		public override Task ExecuteAsync()
		{
			Views__ViewStart.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Views__ViewStart.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000DB0B File Offset: 0x0000BD0B
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0000DB13 File Offset: 0x0000BD13
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x0000DB24 File Offset: 0x0000BD24
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x0000DB2D File Offset: 0x0000BD2D
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x0000DB35 File Offset: 0x0000BD35
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0000DB3E File Offset: 0x0000BD3E
		// (set) Token: 0x060003AA RID: 938 RVA: 0x0000DB46 File Offset: 0x0000BD46
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0000DB4F File Offset: 0x0000BD4F
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000DB57 File Offset: 0x0000BD57
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x02000184 RID: 388
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x06000AE0 RID: 2784 RVA: 0x000502BC File Offset: 0x0004E4BC
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Views__ViewStart views__ViewStart = this.<>4__this;
				try
				{
					views__ViewStart.Layout = "_Layout";
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

			// Token: 0x06000AE1 RID: 2785 RVA: 0x00050320 File Offset: 0x0004E520
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040008C8 RID: 2248
			public int <>1__state;

			// Token: 0x040008C9 RID: 2249
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040008CA RID: 2250
			public Views__ViewStart <>4__this;
		}
	}
}
