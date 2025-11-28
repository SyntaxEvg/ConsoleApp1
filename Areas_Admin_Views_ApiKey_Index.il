.class private auto ansi sealed beforefieldinit AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index
	extends class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>>
{
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(string, string, string) = (
		01 00 06 53 48 41 32 35 36 40 38 37 37 61 63 35
		64 37 38 30 34 31 61 38 30 61 31 32 34 66 38 30
		63 61 33 63 35 36 38 34 36 35 30 33 62 39 35 35
		66 65 34 66 32 63 38 36 32 64 32 63 39 61 32 34
		36 66 64 35 37 33 65 64 30 65 26 2f 41 72 65 61
		73 2f 41 64 6d 69 6e 2f 56 69 65 77 73 2f 41 70
		69 4b 65 79 2f 49 6e 64 65 78 2e 63 73 68 74 6d
		6c 00 00
	)
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(string, string, string) = (
		01 00 06 53 48 41 32 35 36 40 64 62 34 39 39 39
		30 62 38 33 38 37 33 62 64 30 61 38 64 61 65 32
		39 61 34 39 62 36 65 34 31 64 34 36 33 30 65 61
		36 38 38 37 35 37 35 66 36 64 33 66 39 34 66 61
		61 33 34 38 30 62 38 63 37 65 26 2f 41 72 65 61
		73 2f 41 64 6d 69 6e 2f 56 69 65 77 73 2f 5f 56
		69 65 77 49 6d 70 6f 72 74 73 2e 63 73 68 74 6d
		6c 00 00
	)
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute::.ctor(string, string) = (
		01 00 0a 49 64 65 6e 74 69 66 69 65 72 26 2f 41
		72 65 61 73 2f 41 64 6d 69 6e 2f 56 69 65 77 73
		2f 41 70 69 4b 65 79 2f 49 6e 64 65 78 2e 63 73
		68 74 6d 6c 00 00
	)
	.custom instance void [System.Runtime.Loader]System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute::.ctor() = (
		01 00 00 00
	)
	// Nested Types
	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__9_4>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 7
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index,
				[2] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] class [System.Runtime]System.Exception
			)

			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				IL_000E: ldloc.0
				IL_000F: brfalse   IL_00DB

				IL_0014: ldloc.0
				IL_0015: ldc.i4.1
				IL_0016: beq       IL_014A

				IL_001B: ldloc.1
				IL_001C: ldstr     "\r\n    "
				IL_0021: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0026: ldloc.1
				IL_0027: ldloc.1
				IL_0028: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager()
				IL_002D: ldstr     "script"
				IL_0032: ldc.i4.0
				IL_0033: ldstr     "877ac5d78041a80a124f80ca3c56846503b955fe4f2c862d2c9a246fd573ed0e13285"
				IL_0038: ldloc.1
				IL_0039: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<ExecuteAsync>b__9_8'()
				IL_003F: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0044: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_0049: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_004E: ldloc.1
				IL_004F: ldloc.1
				IL_0050: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper>()
				IL_0055: stfld     class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__HAS_Server_TagHelpers_NonceTagHelper
				IL_005A: ldloc.1
				IL_005B: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0060: ldloc.1
				IL_0061: ldfld     class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__HAS_Server_TagHelpers_NonceTagHelper
				IL_0066: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				IL_006B: ldloc.1
				IL_006C: ldfld     class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__HAS_Server_TagHelpers_NonceTagHelper
				IL_0071: ldc.i4.1
				IL_0072: callvirt  instance void [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper::set_AddNonce(bool)
				IL_0077: ldloc.1
				IL_0078: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_007D: ldstr     "asp-add-nonce"
				IL_0082: ldloc.1
				IL_0083: ldfld     class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__HAS_Server_TagHelpers_NonceTagHelper
				IL_0088: callvirt  instance bool [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper::get_AddNonce()
				IL_008D: box       [System.Runtime]System.Boolean
				IL_0092: ldc.i4.0
				IL_0093: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				IL_0098: ldloc.1
				IL_0099: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperRunner
				IL_009E: ldloc.1
				IL_009F: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_00A4: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_00A9: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_00AE: stloc.2
				IL_00AF: ldloca.s  V_2
				IL_00B1: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_00B6: brtrue.s  IL_00F7

				IL_00B8: ldarg.0
				IL_00B9: ldc.i4.0
				IL_00BA: dup
				IL_00BB: stloc.0
				IL_00BC: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
				IL_00C1: ldarg.0
				IL_00C2: ldloc.2
				IL_00C3: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_00C8: ldarg.0
				IL_00C9: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
				IL_00CE: ldloca.s  V_2
				IL_00D0: ldarg.0
				IL_00D1: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'>(!!0&, !!1&)
				IL_00D6: leave     IL_01C8

				IL_00DB: ldarg.0
				IL_00DC: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_00E1: stloc.2
				IL_00E2: ldarg.0
				IL_00E3: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_00E8: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_00EE: ldarg.0
				IL_00EF: ldc.i4.m1
				IL_00F0: dup
				IL_00F1: stloc.0
				IL_00F2: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'

				IL_00F7: ldloca.s  V_2
				IL_00F9: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				IL_00FE: ldloc.1
				IL_00FF: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0104: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0109: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_010E: brtrue.s  IL_016D

				IL_0110: ldloc.1
				IL_0111: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0116: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_011B: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0120: stloc.3
				IL_0121: ldloca.s  V_3
				IL_0123: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0128: brtrue.s  IL_0166

				IL_012A: ldarg.0
				IL_012B: ldc.i4.1
				IL_012C: dup
				IL_012D: stloc.0
				IL_012E: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
				IL_0133: ldarg.0
				IL_0134: ldloc.3
				IL_0135: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_013A: ldarg.0
				IL_013B: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
				IL_0140: ldloca.s  V_3
				IL_0142: ldarg.0
				IL_0143: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'>(!!0&, !!1&)
				IL_0148: leave.s   IL_01C8

				IL_014A: ldarg.0
				IL_014B: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_0150: stloc.3
				IL_0151: ldarg.0
				IL_0152: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>u__1'
				IL_0157: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_015D: ldarg.0
				IL_015E: ldc.i4.m1
				IL_015F: dup
				IL_0160: stloc.0
				IL_0161: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'

				IL_0166: ldloca.s  V_3
				IL_0168: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				IL_016D: ldloc.1
				IL_016E: ldloc.1
				IL_016F: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0174: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0179: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				IL_017E: ldloc.1
				IL_017F: ldloc.1
				IL_0180: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager()
				IL_0185: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_018A: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_018F: ldloc.1
				IL_0190: ldstr     "\r\n"
				IL_0195: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_019A: leave.s   IL_01B5
			} // end .try
			catch [System.Runtime]System.Exception
			{
				IL_019C: stloc.s   V_4
				IL_019E: ldarg.0
				IL_019F: ldc.i4.s  -2
				IL_01A1: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
				IL_01A6: ldarg.0
				IL_01A7: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
				IL_01AC: ldloc.s   V_4
				IL_01AE: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_01B3: leave.s   IL_01C8
			} // end handler

			IL_01B5: ldarg.0
			IL_01B6: ldc.i4.s  -2
			IL_01B8: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
			IL_01BD: ldarg.0
			IL_01BE: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
			IL_01C3: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_01C8: ret
		} // end of method '<<ExecuteAsync>b__9_4>d'::MoveNext

		.method private final hidebysig newslot virtual 
			instance void SetStateMachine (
				class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine
			) cil managed 
		{
			.custom instance void [System.Runtime]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = (
				01 00 00 00
			)
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			.param [1]
				.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
					01 00 01 00 00
				)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__9_4>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__9_4>d

	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__9_8>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index '<>4__this'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 2
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index,
				[2] class [System.Runtime]System.Exception
			)

			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				IL_000E: ldloc.1
				IL_000F: ldstr     "\r\n        $('#confirmationDialog').on('show.bs.modal', function (e) {\r\n            $(this).find('.btn-ok').attr('href', $(e.relatedTarget).data('href'));\r\n        });\r\n    "
				IL_0014: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0019: leave.s   IL_0032
			} // end .try
			catch [System.Runtime]System.Exception
			{
				IL_001B: stloc.2
				IL_001C: ldarg.0
				IL_001D: ldc.i4.s  -2
				IL_001F: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>1__state'
				IL_0024: ldarg.0
				IL_0025: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
				IL_002A: ldloc.2
				IL_002B: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_0030: leave.s   IL_0045
			} // end handler

			IL_0032: ldarg.0
			IL_0033: ldc.i4.s  -2
			IL_0035: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>1__state'
			IL_003A: ldarg.0
			IL_003B: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
			IL_0040: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_0045: ret
		} // end of method '<<ExecuteAsync>b__9_8>d'::MoveNext

		.method private final hidebysig newslot virtual 
			instance void SetStateMachine (
				class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine
			) cil managed 
		{
			.custom instance void [System.Runtime]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = (
				01 00 00 00
			)
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			.param [1]
				.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
					01 00 01 00 00
				)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__9_8>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__9_8>d

	.class nested private auto ansi sealed serializable beforefieldinit '<>c'
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Nested Types
		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__9_0>d'
			extends [System.Runtime]System.ValueType
			implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
		{
			// Fields
			.field public int32 '<>1__state'
			.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'

			// Methods
			.method private final hidebysig newslot virtual 
				instance void MoveNext () cil managed 
			{
				.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
				.maxstack 2
				.locals init (
					[0] int32,
					[1] class [System.Runtime]System.Exception
				)

				IL_0000: ldarg.0
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>1__state'
				IL_0006: stloc.0
				.try
				{
					IL_0007: leave.s   IL_0020
				} // end .try
				catch [System.Runtime]System.Exception
				{
					IL_0009: stloc.1
					IL_000A: ldarg.0
					IL_000B: ldc.i4.s  -2
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__9_0>d'::MoveNext

			.method private final hidebysig newslot virtual 
				instance void SetStateMachine (
					class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine
				) cil managed 
			{
				.custom instance void [System.Runtime]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = (
					01 00 00 00
				)
				.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				.param [1]
					.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
						01 00 01 00 00
					)
				.maxstack 8

				IL_0000: ldarg.0
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__9_0>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__9_0>d


		// Fields
		.field public static initonly class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c' '<>9'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__9_0'

		// Methods
		.method private hidebysig specialname rtspecialname static 
			void .cctor () cil managed 
		{
			.maxstack 8

			IL_0000: newobj    instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::.ctor()
			IL_0005: stsfld    class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c' AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::'<>9'
			IL_000A: ret
		} // end of method '<>c'::.cctor

		.method public hidebysig specialname rtspecialname 
			instance void .ctor () cil managed 
		{
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: call      instance void [System.Runtime]System.Object::.ctor()
			IL_0006: ret
		} // end of method '<>c'::.ctor

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__9_0' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 56 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 41
				72 65 61 73 5f 41 64 6d 69 6e 5f 56 69 65 77 73
				5f 41 70 69 4b 65 79 5f 49 6e 64 65 78 2b 3c 3e
				63 2b 3c 3c 45 78 65 63 75 74 65 41 73 79 6e 63
				3e 62 5f 5f 39 5f 30 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'/'<<ExecuteAsync>b__9_0>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__9_0'

	} // end of class <>c

	.class nested private auto ansi sealed beforefieldinit '<>c__DisplayClass9_0'
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel item

		// Methods
		.method public hidebysig specialname rtspecialname 
			instance void .ctor () cil managed 
		{
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: call      instance void [System.Runtime]System.Object::.ctor()
			IL_0006: ret
		} // end of method '<>c__DisplayClass9_0'::.ctor

	} // end of class <>c__DisplayClass9_0

	.class nested private auto ansi sealed beforefieldinit '<ExecuteAsync>d__9'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 7
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index,
				[2] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression,
				[5] class [System.Runtime]System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>,
				[6] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0' 'CS$<>8__locals0',
				[7] class [System.Runtime]System.Exception
			)

			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				IL_000E: ldloc.0
				IL_000F: brfalse   IL_00FE

				IL_0014: ldloc.0
				IL_0015: ldc.i4.1
				IL_0016: beq       IL_0170

				IL_001B: ldloc.1
				IL_001C: ldstr     "\r\n<div class=\"x_panel\">\r\n    <div class=\"x_title\">\r\n        <h2><b>API keys</b></h2>\r\n        <ul class=\"nav navbar-right panel_toolbox\">\r\n        </ul>\r\n        <a href='/uas/admin/apikey/create' class=\"btn btn-primary pull-right\">\r\n            Create\r\n        </a>\r\n        <div class=\"clearfix\"></div>\r\n    </div>\r\n    <div class=\"x_content\">\r\n        "
				IL_0021: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0026: ldloc.1
				IL_0027: ldloc.1
				IL_0028: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager()
				IL_002D: ldstr     "div"
				IL_0032: ldc.i4.0
				IL_0033: ldstr     "877ac5d78041a80a124f80ca3c56846503b955fe4f2c862d2c9a246fd573ed0e4303"
				IL_0038: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::'<>9__9_0'
				IL_003D: dup
				IL_003E: brtrue.s  IL_0057

				IL_0040: pop
				IL_0041: ldsfld    class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c' AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::'<>9'
				IL_0046: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::'<ExecuteAsync>b__9_0'()
				IL_004C: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0051: dup
				IL_0052: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c'::'<>9__9_0'

				IL_0057: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_005C: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0061: ldloc.1
				IL_0062: ldloc.1
				IL_0063: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>()
				IL_0068: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_006D: ldloc.1
				IL_006E: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0073: ldloc.1
				IL_0074: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_0079: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				IL_007E: ldloc.1
				IL_007F: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_0084: ldc.i4.2
				IL_0085: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::set_ValidationSummary(valuetype [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary)
				IL_008A: ldloc.1
				IL_008B: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0090: ldstr     "asp-validation-summary"
				IL_0095: ldloc.1
				IL_0096: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_009B: callvirt  instance valuetype [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::get_ValidationSummary()
				IL_00A0: box       [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary
				IL_00A5: ldc.i4.0
				IL_00A6: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				IL_00AB: ldloc.1
				IL_00AC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_00B1: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperAttribute_0
				IL_00B6: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				IL_00BB: ldloc.1
				IL_00BC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperRunner
				IL_00C1: ldloc.1
				IL_00C2: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_00C7: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_00CC: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_00D1: stloc.2
				IL_00D2: ldloca.s  V_2
				IL_00D4: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_00D9: brtrue.s  IL_011A

				IL_00DB: ldarg.0
				IL_00DC: ldc.i4.0
				IL_00DD: dup
				IL_00DE: stloc.0
				IL_00DF: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
				IL_00E4: ldarg.0
				IL_00E5: ldloc.2
				IL_00E6: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_00EB: ldarg.0
				IL_00EC: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
				IL_00F1: ldloca.s  V_2
				IL_00F3: ldarg.0
				IL_00F4: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'>(!!0&, !!1&)
				IL_00F9: leave     IL_05B6

				IL_00FE: ldarg.0
				IL_00FF: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_0104: stloc.2
				IL_0105: ldarg.0
				IL_0106: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_010B: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0111: ldarg.0
				IL_0112: ldc.i4.m1
				IL_0113: dup
				IL_0114: stloc.0
				IL_0115: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'

				IL_011A: ldloca.s  V_2
				IL_011C: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				IL_0121: ldloc.1
				IL_0122: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0127: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_012C: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_0131: brtrue.s  IL_0193

				IL_0133: ldloc.1
				IL_0134: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_0139: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_013E: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0143: stloc.3
				IL_0144: ldloca.s  V_3
				IL_0146: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_014B: brtrue.s  IL_018C

				IL_014D: ldarg.0
				IL_014E: ldc.i4.1
				IL_014F: dup
				IL_0150: stloc.0
				IL_0151: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
				IL_0156: ldarg.0
				IL_0157: ldloc.3
				IL_0158: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_015D: ldarg.0
				IL_015E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
				IL_0163: ldloca.s  V_3
				IL_0165: ldarg.0
				IL_0166: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'>(!!0&, !!1&)
				IL_016B: leave     IL_05B6

				IL_0170: ldarg.0
				IL_0171: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_0176: stloc.3
				IL_0177: ldarg.0
				IL_0178: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>u__1'
				IL_017D: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0183: ldarg.0
				IL_0184: ldc.i4.m1
				IL_0185: dup
				IL_0186: stloc.0
				IL_0187: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'

				IL_018C: ldloca.s  V_3
				IL_018E: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				IL_0193: ldloc.1
				IL_0194: ldloc.1
				IL_0195: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_019A: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_019F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				IL_01A4: ldloc.1
				IL_01A5: ldloc.1
				IL_01A6: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager()
				IL_01AB: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_01B0: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperExecutionContext
				IL_01B5: ldloc.1
				IL_01B6: ldstr     "\r\n"
				IL_01BB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_01C0: ldloc.1
				IL_01C1: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>>::get_Model()
				IL_01C6: brfalse   IL_055B

				IL_01CB: ldloc.1
				IL_01CC: ldstr     "            <table class=\"table table-striped table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            "
				IL_01D1: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_01D6: ldloc.1
				IL_01D7: ldloc.1
				IL_01D8: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
				IL_01DD: ldtoken   Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
				IL_01E2: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_01E7: ldstr     "model"
				IL_01EC: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_01F1: stloc.s   V_4
				IL_01F3: ldloc.s   V_4
				IL_01F5: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_TokenName()
				IL_01FA: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_01FF: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_0204: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_0209: ldc.i4.1
				IL_020A: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_020F: dup
				IL_0210: ldc.i4.0
				IL_0211: ldloc.s   V_4
				IL_0213: stelem.ref
				IL_0214: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_0219: call      string [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayNameExtensions::DisplayNameFor<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_021E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				IL_0223: ldloc.1
				IL_0224: ldstr     "\r\n                        </th>\r\n                        <th>\r\n                            "
				IL_0229: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_022E: ldloc.1
				IL_022F: ldloc.1
				IL_0230: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
				IL_0235: ldtoken   Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
				IL_023A: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_023F: ldstr     "model"
				IL_0244: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_0249: stloc.s   V_4
				IL_024B: ldloc.s   V_4
				IL_024D: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Description()
				IL_0252: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_0257: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_025C: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_0261: ldc.i4.1
				IL_0262: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_0267: dup
				IL_0268: ldc.i4.0
				IL_0269: ldloc.s   V_4
				IL_026B: stelem.ref
				IL_026C: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_0271: call      string [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayNameExtensions::DisplayNameFor<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_0276: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				IL_027B: ldloc.1
				IL_027C: ldstr     "\r\n                        </th>\r\n                        <th>\r\n                            "
				IL_0281: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0286: ldloc.1
				IL_0287: ldloc.1
				IL_0288: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
				IL_028D: ldtoken   Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
				IL_0292: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_0297: ldstr     "model"
				IL_029C: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_02A1: stloc.s   V_4
				IL_02A3: ldloc.s   V_4
				IL_02A5: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ExpirationDate()
				IL_02AA: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_02AF: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_02B4: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_02B9: ldc.i4.1
				IL_02BA: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_02BF: dup
				IL_02C0: ldc.i4.0
				IL_02C1: ldloc.s   V_4
				IL_02C3: stelem.ref
				IL_02C4: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_02C9: call      string [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayNameExtensions::DisplayNameFor<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_02CE: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				IL_02D3: ldloc.1
				IL_02D4: ldstr     "\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n"
				IL_02D9: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_02DE: ldloc.1
				IL_02DF: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>>::get_Model()
				IL_02E4: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerator`1<!0> class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::GetEnumerator()
				IL_02E9: stloc.s   V_5
				.try
				{
					IL_02EB: br        IL_0525
					// loop start (head: IL_0525)
						IL_02F0: newobj    instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::.ctor()
						IL_02F5: stloc.s   'CS$<>8__locals0'
						IL_02F7: ldloc.s   'CS$<>8__locals0'
						IL_02F9: ldloc.s   V_5
						IL_02FB: callvirt  instance !0 class [System.Runtime]System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Current()
						IL_0300: stfld     class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_0305: ldloc.1
						IL_0306: ldstr     "                        <tr"
						IL_030B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_0310: ldloc.1
						IL_0311: ldstr     "class"
						IL_0316: ldstr     " class=\""
						IL_031B: ldc.i4    1281
						IL_0320: ldstr     "\""
						IL_0325: ldc.i4    1326
						IL_032A: ldc.i4.1
						IL_032B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
						IL_0330: ldloc.1
						IL_0331: ldstr     ""
						IL_0336: ldc.i4    1289
						IL_033B: ldloc.s   'CS$<>8__locals0'
						IL_033D: ldfld     class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_0342: callvirt  instance bool Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel::get_IsExpired()
						IL_0347: brtrue.s  IL_0350

						IL_0349: ldstr     ""
						IL_034E: br.s      IL_0355

						IL_0350: ldstr     "bg-warning"

						IL_0355: ldc.i4    1289
						IL_035A: ldc.i4.s  37
						IL_035C: ldc.i4.0
						IL_035D: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						IL_0362: ldloc.1
						IL_0363: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
						IL_0368: ldloc.1
						IL_0369: ldstr     ">\r\n                            <td>\r\n                                "
						IL_036E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_0373: ldloc.1
						IL_0374: ldloc.1
						IL_0375: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
						IL_037A: ldtoken   class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
						IL_037F: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_0384: ldstr     "modelItem"
						IL_0389: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
						IL_038E: stloc.s   V_4
						IL_0390: ldloc.s   'CS$<>8__locals0'
						IL_0392: ldtoken   AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'
						IL_0397: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_039C: call      class [System.Linq.Expressions]System.Linq.Expressions.ConstantExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Constant(object, class [System.Runtime]System.Type)
						IL_03A1: ldtoken   field class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_03A6: call      class [System.Runtime]System.Reflection.FieldInfo [System.Runtime]System.Reflection.FieldInfo::GetFieldFromHandle(valuetype [System.Runtime]System.RuntimeFieldHandle)
						IL_03AB: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Field(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.FieldInfo)
						IL_03B0: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_TokenName()
						IL_03B5: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
						IL_03BA: castclass [System.Runtime]System.Reflection.MethodInfo
						IL_03BF: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
						IL_03C4: ldc.i4.1
						IL_03C5: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
						IL_03CA: dup
						IL_03CB: ldc.i4.0
						IL_03CC: ldloc.s   V_4
						IL_03CE: stelem.ref
						IL_03CF: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
						IL_03D4: call      class [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.IHtmlContent [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayExtensions::DisplayFor<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
						IL_03D9: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
						IL_03DE: ldloc.1
						IL_03DF: ldstr     "\r\n                            </td>\r\n                            <td>\r\n                                "
						IL_03E4: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_03E9: ldloc.1
						IL_03EA: ldloc.1
						IL_03EB: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
						IL_03F0: ldtoken   class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
						IL_03F5: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_03FA: ldstr     "modelItem"
						IL_03FF: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
						IL_0404: stloc.s   V_4
						IL_0406: ldloc.s   'CS$<>8__locals0'
						IL_0408: ldtoken   AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'
						IL_040D: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_0412: call      class [System.Linq.Expressions]System.Linq.Expressions.ConstantExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Constant(object, class [System.Runtime]System.Type)
						IL_0417: ldtoken   field class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_041C: call      class [System.Runtime]System.Reflection.FieldInfo [System.Runtime]System.Reflection.FieldInfo::GetFieldFromHandle(valuetype [System.Runtime]System.RuntimeFieldHandle)
						IL_0421: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Field(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.FieldInfo)
						IL_0426: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Description()
						IL_042B: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
						IL_0430: castclass [System.Runtime]System.Reflection.MethodInfo
						IL_0435: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
						IL_043A: ldc.i4.1
						IL_043B: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
						IL_0440: dup
						IL_0441: ldc.i4.0
						IL_0442: ldloc.s   V_4
						IL_0444: stelem.ref
						IL_0445: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
						IL_044A: call      class [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.IHtmlContent [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayExtensions::DisplayFor<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
						IL_044F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
						IL_0454: ldloc.1
						IL_0455: ldstr     "\r\n                            </td>\r\n                            <td>\r\n                                "
						IL_045A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_045F: ldloc.1
						IL_0460: ldloc.1
						IL_0461: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
						IL_0466: ldtoken   class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
						IL_046B: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_0470: ldstr     "modelItem"
						IL_0475: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
						IL_047A: stloc.s   V_4
						IL_047C: ldloc.s   'CS$<>8__locals0'
						IL_047E: ldtoken   AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'
						IL_0483: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
						IL_0488: call      class [System.Linq.Expressions]System.Linq.Expressions.ConstantExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Constant(object, class [System.Runtime]System.Type)
						IL_048D: ldtoken   field class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_0492: call      class [System.Runtime]System.Reflection.FieldInfo [System.Runtime]System.Reflection.FieldInfo::GetFieldFromHandle(valuetype [System.Runtime]System.RuntimeFieldHandle)
						IL_0497: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Field(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.FieldInfo)
						IL_049C: ldtoken   method instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ExpirationDate()
						IL_04A1: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
						IL_04A6: castclass [System.Runtime]System.Reflection.MethodInfo
						IL_04AB: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
						IL_04B0: ldc.i4.1
						IL_04B1: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
						IL_04B6: dup
						IL_04B7: ldc.i4.0
						IL_04B8: ldloc.s   V_4
						IL_04BA: stelem.ref
						IL_04BB: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
						IL_04C0: call      class [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.IHtmlContent [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.HtmlHelperDisplayExtensions::DisplayFor<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
						IL_04C5: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
						IL_04CA: ldloc.1
						IL_04CB: ldstr     "\r\n                            </td>\r\n                            <td>\r\n"
						IL_04D0: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_04D5: ldloc.s   'CS$<>8__locals0'
						IL_04D7: ldfld     class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_04DC: callvirt  instance string Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_TokenName()
						IL_04E1: ldstr     "admin"
						IL_04E6: call      bool [System.Runtime]System.String::op_Inequality(string, string)
						IL_04EB: brfalse.s IL_051A

						IL_04ED: ldloc.1
						IL_04EE: ldstr     "                                    <p data-bs-placement=\"top\" data-bs-toggle=\"tooltip\" title=\"Revoke\">\r\n                                        <button class=\"btn btn-danger btn-sm\" data-bs-title=\"Revoke\"\r\n                                                data-href=\"/uas/admin/apikey/delete/"
						IL_04F3: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						IL_04F8: ldloc.1
						IL_04F9: ldloc.s   'CS$<>8__locals0'
						IL_04FB: ldfld     class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<>c__DisplayClass9_0'::item
						IL_0500: ldfld     int32 Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::Id
						IL_0505: box       [System.Runtime]System.Int32
						IL_050A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
						IL_050F: ldloc.1
						IL_0510: ldstr     "\"\r\n                                                data-bs-toggle=\"modal\" data-bs-target=\"#confirmationDialog\">\r\n                                            <span class=\"fa fa-trash\"></span>\r\n                                        </button>\r\n                                    </p>\r\n"
						IL_0515: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

						IL_051A: ldloc.1
						IL_051B: ldstr     "                            </td>\r\n                        </tr>\r\n"
						IL_0520: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

						IL_0525: ldloc.s   V_5
						IL_0527: callvirt  instance bool [System.Runtime]System.Collections.IEnumerator::MoveNext()
						IL_052C: brtrue    IL_02F0
					// end loop

					IL_0531: leave.s   IL_0543
				} // end .try
				finally
				{
					IL_0533: ldloc.0
					IL_0534: ldc.i4.0
					IL_0535: bge.s     IL_0542

					IL_0537: ldloc.s   V_5
					IL_0539: brfalse.s IL_0542

					IL_053B: ldloc.s   V_5
					IL_053D: callvirt  instance void [System.Runtime]System.IDisposable::Dispose()

					IL_0542: endfinally
				} // end handler

				IL_0543: ldloc.1
				IL_0544: ldstr     "                </tbody>\r\n            </table>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\" id=\"confirmationDialog\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n                <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n                    <div class=\"modal-content\">\r\n                        <div class=\"modal-header\">\r\n                            <h5 class=\"modal-title\" id=\"exampleModalLongTitle\">Confirmation</h5>\r\n                            <button type=\"button\" class=\"close\" data-bs-dismiss=\"modal\" aria-label=\"Close\">\r\n                                <span aria-hidden=\"true\">&times;</span>\r\n                            </button>\r\n                        </div>\r\n                        <div class=\"modal-body\">\r\n                            Are you sure ?\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-default\" data-bs-dis"
				IL_0549: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_054E: ldloc.1
				IL_054F: ldstr     "miss=\"modal\">Cancel</button>\r\n                            <a class=\"btn btn-danger btn-ok\">Revoke</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n"
				IL_0554: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0559: br.s      IL_0566

				IL_055B: ldloc.1
				IL_055C: ldstr     "            <div class=\"text-center text-info\">There is no api keys </div>\r\n"
				IL_0561: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				IL_0566: ldloc.1
				IL_0567: ldstr     "    </div>\r\n</div>\r\n"
				IL_056C: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0571: ldloc.1
				IL_0572: ldstr     "scripts"
				IL_0577: ldloc.1
				IL_0578: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<ExecuteAsync>b__9_4'()
				IL_057E: newobj    instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate::.ctor(object, native int)
				IL_0583: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::DefineSection(string, class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate)
				IL_0588: leave.s   IL_05A3
			} // end .try
			catch [System.Runtime]System.Exception
			{
				IL_058A: stloc.s   V_7
				IL_058C: ldarg.0
				IL_058D: ldc.i4.s  -2
				IL_058F: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
				IL_0594: ldarg.0
				IL_0595: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
				IL_059A: ldloc.s   V_7
				IL_059C: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_05A1: leave.s   IL_05B6
			} // end handler

			IL_05A3: ldarg.0
			IL_05A4: ldc.i4.s  -2
			IL_05A6: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
			IL_05AB: ldarg.0
			IL_05AC: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
			IL_05B1: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_05B6: ret
		} // end of method '<ExecuteAsync>d__9'::MoveNext

		.method private final hidebysig newslot virtual 
			instance void SetStateMachine (
				class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine stateMachine
			) cil managed 
		{
			.custom instance void [System.Runtime]System.Diagnostics.DebuggerHiddenAttribute::.ctor() = (
				01 00 00 00
			)
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			.param [1]
				.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
					01 00 01 00 00
				)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<ExecuteAsync>d__9'::SetStateMachine

	} // end of class <ExecuteAsync>d__9


	// Fields
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner
	.field private string __tagHelperStringValueBuffer
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
	.field private class [HAS.Server.SiteModule]HAS.Server.TagHelpers.NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider '<ModelExpressionProvider>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.field private class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper '<Url>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.field private class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper '<Component>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.field private class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper '<Json>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.field private class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> '<Html>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)

	// Methods
	.method private hidebysig specialname 
		instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager get___tagHelperScopeManager () cil managed 
	{
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__backed__tagHelperScopeManager
		IL_0006: brtrue.s  IL_002B

		IL_0008: ldarg.0
		IL_0009: ldarg.0
		IL_000A: ldftn     instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::StartTagHelperWritingScope(class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder)
		IL_0010: newobj    instance void class [System.Runtime]System.Action`1<class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder>::.ctor(object, native int)
		IL_0015: ldarg.0
		IL_0016: ldftn     instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndTagHelperWritingScope()
		IL_001C: newobj    instance void class [System.Runtime]System.Func`1<class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent>::.ctor(object, native int)
		IL_0021: newobj    instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::.ctor(class [System.Runtime]System.Action`1<class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder>, class [System.Runtime]System.Func`1<class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent>)
		IL_0026: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__backed__tagHelperScopeManager

		IL_002B: ldarg.0
		IL_002C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__backed__tagHelperScopeManager
		IL_0031: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager

	.method public hidebysig virtual 
		instance class [System.Runtime]System.Threading.Tasks.Task ExecuteAsync () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 4d 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 41
			72 65 61 73 5f 41 64 6d 69 6e 5f 56 69 65 77 73
			5f 41 70 69 4b 65 79 5f 49 6e 64 65 78 2b 3c 45
			78 65 63 75 74 65 41 73 79 6e 63 3e 64 5f 5f 39
			00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<ExecuteAsync>d__9'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::ExecuteAsync

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider get_ModelExpressionProvider () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<ModelExpressionProvider>k__BackingField'
		IL_0006: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get_ModelExpressionProvider

	.method private hidebysig specialname 
		instance void set_ModelExpressionProvider (
			class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<ModelExpressionProvider>k__BackingField'
		IL_0007: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::set_ModelExpressionProvider

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper get_Url () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Url>k__BackingField'
		IL_0006: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get_Url

	.method private hidebysig specialname 
		instance void set_Url (
			class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Url>k__BackingField'
		IL_0007: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::set_Url

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper get_Component () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Component>k__BackingField'
		IL_0006: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get_Component

	.method private hidebysig specialname 
		instance void set_Component (
			class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Component>k__BackingField'
		IL_0007: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::set_Component

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper get_Json () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Json>k__BackingField'
		IL_0006: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get_Json

	.method private hidebysig specialname 
		instance void set_Json (
			class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Json>k__BackingField'
		IL_0007: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::set_Json

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> get_Html () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Html>k__BackingField'
		IL_0006: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::get_Html

	.method private hidebysig specialname 
		instance void set_Html (
			class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::'<Html>k__BackingField'
		IL_0007: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::set_Html

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: newobj    instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::.ctor()
		IL_0006: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperRunner
		IL_000B: ldarg.0
		IL_000C: call      instance void class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>>::.ctor()
		IL_0011: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::.ctor

	.method private hidebysig specialname rtspecialname static 
		void .cctor () cil managed 
	{
		.maxstack 8

		IL_0000: ldstr     "class"
		IL_0005: ldstr     "text-danger"
		IL_000A: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_000F: ldc.i4.0
		IL_0010: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0015: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::__tagHelperAttribute_0
		IL_001A: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::.cctor

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__9_4' () cil managed 
	{
		.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
			01 00 01 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 52 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 41
			72 65 61 73 5f 41 64 6d 69 6e 5f 56 69 65 77 73
			5f 41 70 69 4b 65 79 5f 49 6e 64 65 78 2b 3c 3c
			45 78 65 63 75 74 65 41 73 79 6e 63 3e 62 5f 5f
			39 5f 34 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_4>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::'<ExecuteAsync>b__9_4'

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__9_8' () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 52 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 41
			72 65 61 73 5f 41 64 6d 69 6e 5f 56 69 65 77 73
			5f 41 70 69 4b 65 79 5f 49 6e 64 65 78 2b 3c 3c
			45 78 65 63 75 74 65 41 73 79 6e 63 3e 62 5f 5f
			39 5f 38 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index/'<<ExecuteAsync>b__9_8>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Areas_Admin_Views_ApiKey_Index::'<ExecuteAsync>b__9_8'

	// Properties
	.property instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager()
	{
		.get instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get___tagHelperScopeManager()
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_ModelExpressionProvider()
		.set instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::set_ModelExpressionProvider(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper Url()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Url()
		.set instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::set_Url(class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper Component()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Component()
		.set instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::set_Component(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Json()
		.set instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::set_Json(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> Html()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::get_Html()
		.set instance void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index::set_Html(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>>)
	}

} // end of class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Index
