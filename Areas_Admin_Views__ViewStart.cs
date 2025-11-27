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
	// Token: 0x02000041 RID: 65
	[Dynamic(new bool[] { false, true })]
	[RazorSourceChecksum("SHA256", "328d2e24b4019ca1ed5dc21c8e2986d30ce2c8845478f3a1b4840b75fe46db70", "/Areas/Admin/Views/_ViewStart.cshtml")]
	[RazorSourceChecksum("SHA256", "db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e", "/Areas/Admin/Views/_ViewImports.cshtml")]
	[RazorCompiledItemMetadata("Identifier", "/Areas/Admin/Views/_ViewStart.cshtml")]
	[CreateNewOnMetadataUpdate]
	internal sealed class Areas_Admin_Views__ViewStart : BaseRazorPage<object>
	{
		// Token: 0x060002CA RID: 714 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public override Task ExecuteAsync()
		{
			Areas_Admin_Views__ViewStart.<ExecuteAsync>d__0 <ExecuteAsync>d__;
			<ExecuteAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ExecuteAsync>d__.<>4__this = this;
			<ExecuteAsync>d__.<>1__state = -1;
			<ExecuteAsync>d__.<>t__builder.Start<Areas_Admin_Views__ViewStart.<ExecuteAsync>d__0>(ref <ExecuteAsync>d__);
			return <ExecuteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000BF6F File Offset: 0x0000A16F
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0000BF77 File Offset: 0x0000A177
		[RazorInject]
		public IModelExpressionProvider ModelExpressionProvider { get; private set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000BF80 File Offset: 0x0000A180
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000BF88 File Offset: 0x0000A188
		[RazorInject]
		public IUrlHelper Url { get; private set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000BF91 File Offset: 0x0000A191
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000BF99 File Offset: 0x0000A199
		[RazorInject]
		public IViewComponentHelper Component { get; private set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000BFA2 File Offset: 0x0000A1A2
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000BFAA File Offset: 0x0000A1AA
		[RazorInject]
		public IJsonHelper Json { get; private set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000BFB3 File Offset: 0x0000A1B3
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000BFBB File Offset: 0x0000A1BB
		[Dynamic(new bool[] { false, true })]
		[RazorInject]
		public IHtmlHelper<dynamic> Html
		{
			[return: Dynamic(new bool[] { false, true })]
			get;
			[param: Dynamic(new bool[] { false, true })]
			private set;
		}

		// Token: 0x0200014E RID: 334
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		private struct <ExecuteAsync>d__0 : IAsyncStateMachine
		{
			// Token: 0x06000A4C RID: 2636 RVA: 0x00045568 File Offset: 0x00043768
			void IAsyncStateMachine.MoveNext()
			{
				int num = this.<>1__state;
				Areas_Admin_Views__ViewStart areas_Admin_Views__ViewStart = this.<>4__this;
				try
				{
					areas_Admin_Views__ViewStart.Layout = "_AdminLayout";
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

			// Token: 0x06000A4D RID: 2637 RVA: 0x000455CC File Offset: 0x000437CC
			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine([global::System.Runtime.CompilerServices.Nullable(1)] IAsyncStateMachine stateMachine)
			{
				this.<>t__builder.SetStateMachine(stateMachine);
			}

			// Token: 0x040007FC RID: 2044
			public int <>1__state;

			// Token: 0x040007FD RID: 2045
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040007FE RID: 2046
			public Areas_Admin_Views__ViewStart <>4__this;
		}
	}
}
