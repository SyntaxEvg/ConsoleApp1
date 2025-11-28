.class private auto ansi sealed beforefieldinit AspNetCoreGeneratedDocument.Views_Account_Login
	extends class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>
{
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(string, string, string) = (
		01 00 06 53 48 41 32 35 36 40 35 30 61 33 66 39
		63 37 35 62 39 33 33 35 35 61 64 66 31 39 64 34
		34 64 33 65 32 61 64 62 36 65 34 33 61 38 39 39
		36 63 66 63 36 32 30 34 37 33 33 38 62 61 65 64
		34 30 30 35 33 61 36 30 30 63 1b 2f 56 69 65 77
		73 2f 41 63 63 6f 75 6e 74 2f 4c 6f 67 69 6e 2e
		63 73 68 74 6d 6c 00 00
	)
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(string, string, string) = (
		01 00 06 53 48 41 32 35 36 40 63 36 38 65 65 65
		38 61 63 33 38 64 65 66 63 65 32 64 34 61 30 37
		32 62 63 63 39 63 66 30 31 62 62 63 32 38 38 32
		61 63 37 64 36 37 38 66 66 36 39 30 38 34 61 37
		39 63 34 64 32 61 65 30 61 38 1a 2f 56 69 65 77
		73 2f 5f 56 69 65 77 49 6d 70 6f 72 74 73 2e 63
		73 68 74 6d 6c 00 00
	)
	.custom instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute::.ctor(string, string) = (
		01 00 0a 49 64 65 6e 74 69 66 69 65 72 1b 2f 56
		69 65 77 73 2f 41 63 63 6f 75 6e 74 2f 4c 6f 67
		69 6e 2e 63 73 68 74 6d 6c 00 00
	)
	.custom instance void [System.Runtime.Loader]System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute::.ctor() = (
		01 00 00 00
	)
	// Nested Types
	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_11>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Views_Account_Login '<>4__this'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 3
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Views_Account_Login,
				[2] class [System.Runtime]System.Exception
			)

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				/* (74,56)-(74,85) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_000E: ldloc.1
				IL_000F: ldloc.1
				IL_0010: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0015: ldstr     "Select your environment"
				IL_001A: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_001F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0024: ldloc.1
				IL_0025: ldstr     "..."
				IL_002A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_002F: leave.s   IL_0048
			} // end .try
			catch [System.Runtime]System.Exception
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0031: stloc.2
				IL_0032: ldarg.0
				IL_0033: ldc.i4.s  -2
				IL_0035: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>1__state'
				IL_003A: ldarg.0
				IL_003B: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
				IL_0040: ldloc.2
				IL_0041: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_0046: leave.s   IL_005B
			} // end handler

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0048: ldarg.0
			IL_0049: ldc.i4.s  -2
			IL_004B: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>1__state'
			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0050: ldarg.0
			IL_0051: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
			IL_0056: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_005B: ret
		} // end of method '<<ExecuteAsync>b__29_11>d'::MoveNext

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
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__29_11>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__29_11>d

	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_3>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Views_Account_Login '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 8
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Views_Account_Login,
				[2] class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[5] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[6] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[7] class [System.Runtime]System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Models.ExternalProvider>,
				[8] class Mega.Has.Modules.UAS.Models.ExternalProvider provider,
				[9] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[10] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[11] class [System.Runtime]System.Exception
			)

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_000E: ldloc.0
				IL_000F: switch    (IL_01F8, IL_026C, IL_040A, IL_047F, IL_0959, IL_09CE)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_002C: ldloc.1
				IL_002D: ldstr     "\r\n            <!-- Environment -->\r\n"
				IL_0032: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (64,14)-(64,45) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0037: ldloc.1
				IL_0038: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_003D: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Environments()
				IL_0042: brfalse   IL_04D0

				/* (66,17)-(66,53) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0047: ldloc.1
				IL_0048: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_004D: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Environments()
				IL_0052: call      int32 [System.Linq]System.Linq.Enumerable::Count<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
				IL_0057: ldc.i4.1
				IL_0058: bne.un    IL_02C2

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_005D: ldloc.1
				IL_005E: ldstr     "                    "
				IL_0063: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0068: ldloc.1
				IL_0069: ldloc.1
				IL_006A: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_006F: ldstr     "input"
				IL_0074: ldc.i4.1
				IL_0075: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c21957"
				IL_007A: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_5'
				IL_007F: dup
				IL_0080: brtrue.s  IL_0099

				IL_0082: pop
				IL_0083: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_0088: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_5'()
				IL_008E: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0093: dup
				IL_0094: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_5'

				IL_0099: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_009E: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00A3: ldloc.1
				IL_00A4: ldloc.1
				IL_00A5: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
				IL_00AA: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00AF: ldloc.1
				IL_00B0: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00B5: ldloc.1
				IL_00B6: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_00BB: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (68,1)-(68,150) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00C0: ldloc.1
				IL_00C1: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_00C6: ldloc.1
				IL_00C7: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::get_ModelExpressionProvider()
				IL_00CC: ldloc.1
				IL_00CD: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!0> class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_ViewData()
				IL_00D2: ldtoken   Mega.Has.Modules.UAS.ViewModels.LoginViewModel
				IL_00D7: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_00DC: ldstr     "__model"
				IL_00E1: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_00E6: stloc.2
				IL_00E7: ldloc.2
				IL_00E8: ldtoken   method instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_EnvironmentId()
				IL_00ED: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_00F2: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_00F7: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_00FC: ldc.i4.1
				IL_00FD: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_0102: dup
				IL_0103: ldc.i4.0
				IL_0104: ldloc.2
				IL_0105: stelem.ref
				IL_0106: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_010B: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_0110: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0115: ldloc.1
				IL_0116: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_011B: ldstr     "asp-for"
				IL_0120: ldloc.1
				IL_0121: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_0126: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For()
				IL_012B: ldc.i4.0
				IL_012C: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0131: ldloc.1
				IL_0132: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_0137: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_4
				IL_013C: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_0141: castclass [System.Runtime]System.String
				IL_0146: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_014B: ldloc.1
				IL_014C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0151: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_4
				IL_0156: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_015B: ldloc.1
				IL_015C: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute()
				/* (68,74)-(68,107) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0161: ldloc.1
				IL_0162: ldloc.1
				IL_0163: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0168: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Environments()
				IL_016D: call      !!0 [System.Linq]System.Linq.Enumerable::First<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
				IL_0172: callvirt  instance string [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem::get_Value()
				IL_0177: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_017C: ldloc.1
				IL_017D: ldloc.1
				IL_017E: call      instance string [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute()
				IL_0183: stfld     string AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperStringValueBuffer
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0188: ldloc.1
				IL_0189: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_018E: ldloc.1
				IL_018F: ldfld     string AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperStringValueBuffer
				IL_0194: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0199: ldloc.1
				IL_019A: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_019F: ldstr     "value"
				IL_01A4: ldloc.1
				IL_01A5: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_01AA: callvirt  instance string [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_Value()
				IL_01AF: ldc.i4.0
				IL_01B0: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01B5: ldloc.1
				IL_01B6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_01BB: ldloc.1
				IL_01BC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_01C1: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_01C6: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_01CB: stloc.3
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01CC: ldloca.s  V_3
				IL_01CE: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_01D3: brtrue.s  IL_0214

				IL_01D5: ldarg.0
				IL_01D6: ldc.i4.0
				IL_01D7: dup
				IL_01D8: stloc.0
				IL_01D9: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_01DE: ldarg.0
				IL_01DF: ldloc.3
				IL_01E0: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_01E5: ldarg.0
				IL_01E6: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_01EB: ldloca.s  V_3
				IL_01ED: ldarg.0
				IL_01EE: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_01F3: leave     IL_0B62

				/* Resume Instruction */
				IL_01F8: ldarg.0
				IL_01F9: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_01FE: stloc.3
				IL_01FF: ldarg.0
				IL_0200: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0205: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_020B: ldarg.0
				IL_020C: ldc.i4.m1
				IL_020D: dup
				IL_020E: stloc.0
				IL_020F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_0214: ldloca.s  V_3
				IL_0216: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_021B: ldloc.1
				IL_021C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0221: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0226: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_022B: brtrue.s  IL_0290

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_022D: ldloc.1
				IL_022E: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0233: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_0238: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_023D: stloc.s   V_4
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_023F: ldloca.s  V_4
				IL_0241: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0246: brtrue.s  IL_0289

				IL_0248: ldarg.0
				IL_0249: ldc.i4.1
				IL_024A: dup
				IL_024B: stloc.0
				IL_024C: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_0251: ldarg.0
				IL_0252: ldloc.s   V_4
				IL_0254: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0259: ldarg.0
				IL_025A: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_025F: ldloca.s  V_4
				IL_0261: ldarg.0
				IL_0262: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_0267: leave     IL_0B62

				/* Resume Instruction */
				IL_026C: ldarg.0
				IL_026D: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0272: stloc.s   V_4
				IL_0274: ldarg.0
				IL_0275: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_027A: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0280: ldarg.0
				IL_0281: ldc.i4.m1
				IL_0282: dup
				IL_0283: stloc.0
				IL_0284: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_0289: ldloca.s  V_4
				IL_028B: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0290: ldloc.1
				IL_0291: ldloc.1
				IL_0292: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0297: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_029C: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02A1: ldloc.1
				IL_02A2: ldloc.1
				IL_02A3: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_02A8: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_02AD: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02B2: ldloc.1
				IL_02B3: ldstr     "\r\n"
				IL_02B8: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02BD: br        IL_04D0

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02C2: ldloc.1
				IL_02C3: ldstr     "                    <div class=\"form-group my-4 mx-5\">\r\n                        "
				IL_02C8: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02CD: ldloc.1
				IL_02CE: ldloc.1
				IL_02CF: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_02D4: ldstr     "select"
				IL_02D9: ldc.i4.0
				IL_02DA: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c24749"
				IL_02DF: ldloc.1
				IL_02E0: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login::'<ExecuteAsync>b__29_7'()
				IL_02E6: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_02EB: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_02F0: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02F5: ldloc.1
				IL_02F6: ldloc.1
				IL_02F7: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>()
				IL_02FC: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0301: ldloc.1
				IL_0302: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0307: ldloc.1
				IL_0308: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				IL_030D: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (73,1)-(73,151) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0312: ldloc.1
				IL_0313: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				IL_0318: ldloc.1
				IL_0319: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::get_ModelExpressionProvider()
				IL_031E: ldloc.1
				IL_031F: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!0> class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_ViewData()
				IL_0324: ldtoken   Mega.Has.Modules.UAS.ViewModels.LoginViewModel
				IL_0329: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_032E: ldstr     "__model"
				IL_0333: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_0338: stloc.2
				IL_0339: ldloc.2
				IL_033A: ldtoken   method instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_EnvironmentId()
				IL_033F: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_0344: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_0349: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_034E: ldc.i4.1
				IL_034F: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_0354: dup
				IL_0355: ldc.i4.0
				IL_0356: ldloc.2
				IL_0357: stelem.ref
				IL_0358: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_035D: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_0362: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::set_For(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0367: ldloc.1
				IL_0368: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_036D: ldstr     "asp-for"
				IL_0372: ldloc.1
				IL_0373: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				IL_0378: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::get_For()
				IL_037D: ldc.i4.0
				IL_037E: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (73,1)-(73,82) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0383: ldloc.1
				IL_0384: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				IL_0389: ldloc.1
				IL_038A: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_038F: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Environments()
				IL_0394: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::set_Items(class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0399: ldloc.1
				IL_039A: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_039F: ldstr     "asp-items"
				IL_03A4: ldloc.1
				IL_03A5: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
				IL_03AA: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::get_Items()
				IL_03AF: ldc.i4.0
				IL_03B0: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_03B5: ldloc.1
				IL_03B6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_03BB: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_6
				IL_03C0: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_03C5: ldloc.1
				IL_03C6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_03CB: ldloc.1
				IL_03CC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_03D1: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_03D6: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_03DB: stloc.s   V_5
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_03DD: ldloca.s  V_5
				IL_03DF: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_03E4: brtrue.s  IL_0427

				IL_03E6: ldarg.0
				IL_03E7: ldc.i4.2
				IL_03E8: dup
				IL_03E9: stloc.0
				IL_03EA: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_03EF: ldarg.0
				IL_03F0: ldloc.s   V_5
				IL_03F2: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_03F7: ldarg.0
				IL_03F8: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_03FD: ldloca.s  V_5
				IL_03FF: ldarg.0
				IL_0400: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_0405: leave     IL_0B62

				/* Resume Instruction */
				IL_040A: ldarg.0
				IL_040B: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0410: stloc.s   V_5
				IL_0412: ldarg.0
				IL_0413: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0418: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_041E: ldarg.0
				IL_041F: ldc.i4.m1
				IL_0420: dup
				IL_0421: stloc.0
				IL_0422: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_0427: ldloca.s  V_5
				IL_0429: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_042E: ldloc.1
				IL_042F: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0434: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0439: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_043E: brtrue.s  IL_04A3

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0440: ldloc.1
				IL_0441: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0446: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_044B: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0450: stloc.s   V_6
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0452: ldloca.s  V_6
				IL_0454: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0459: brtrue.s  IL_049C

				IL_045B: ldarg.0
				IL_045C: ldc.i4.3
				IL_045D: dup
				IL_045E: stloc.0
				IL_045F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_0464: ldarg.0
				IL_0465: ldloc.s   V_6
				IL_0467: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_046C: ldarg.0
				IL_046D: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_0472: ldloca.s  V_6
				IL_0474: ldarg.0
				IL_0475: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_047A: leave     IL_0B62

				/* Resume Instruction */
				IL_047F: ldarg.0
				IL_0480: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0485: stloc.s   V_6
				IL_0487: ldarg.0
				IL_0488: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_048D: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0493: ldarg.0
				IL_0494: ldc.i4.m1
				IL_0495: dup
				IL_0496: stloc.0
				IL_0497: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_049C: ldloca.s  V_6
				IL_049E: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04A3: ldloc.1
				IL_04A4: ldloc.1
				IL_04A5: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_04AA: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_04AF: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04B4: ldloc.1
				IL_04B5: ldloc.1
				IL_04B6: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_04BB: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_04C0: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04C5: ldloc.1
				IL_04C6: ldstr     "\r\n                    </div>\r\n"
				IL_04CB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04D0: ldloc.1
				IL_04D1: ldstr     "\r\n"
				IL_04D6: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (80,14)-(80,55) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04DB: ldloc.1
				IL_04DC: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_04E1: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Models.ExternalProvider> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_VisibleExternalProviders()
				IL_04E6: call      bool [System.Linq]System.Linq.Enumerable::Any<class Mega.Has.Modules.UAS.Models.ExternalProvider>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
				IL_04EB: brfalse   IL_06A5

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04F0: ldloc.1
				IL_04F1: ldstr     "                <h6>"
				IL_04F6: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (82,22)-(82,38) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04FB: ldloc.1
				IL_04FC: ldloc.1
				IL_04FD: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0502: ldstr     "Login with"
				IL_0507: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_050C: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0511: ldloc.1
				IL_0512: ldstr     " </h6>\r\n                <div class=\"row mx-1 my-3\">\r\n"
				IL_0517: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (84,47)-(84,77) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_051C: ldloc.1
				IL_051D: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0522: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Models.ExternalProvider> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_VisibleExternalProviders()
				IL_0527: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerator`1<!0> class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Models.ExternalProvider>::GetEnumerator()
				IL_052C: stloc.s   V_7
				.try
				{
					/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
					IL_052E: br        IL_0643
					// loop start (head: IL_0643)
						/* (84,31)-(84,43) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0533: ldloc.s   V_7
						IL_0535: callvirt  instance !0 class [System.Runtime]System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Models.ExternalProvider>::get_Current()
						IL_053A: stloc.s   provider
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_053C: ldloc.1
						IL_053D: ldstr     "                        <div class=\"col mb-3\">\r\n                            <a class=\"btn btn-secondary text-white btn-sso-login\""
						IL_0542: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0547: ldloc.1
						IL_0548: ldstr     "onclick"
						IL_054D: ldstr     " onclick=\""
						IL_0552: ldc.i4    3671
						IL_0557: ldstr     "\""
						IL_055C: ldc.i4    3739
						IL_0561: ldc.i4.6
						IL_0562: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0567: ldloc.1
						IL_0568: ldstr     ""
						IL_056D: ldc.i4    3681
						IL_0572: ldstr     "ExternalLogin('"
						IL_0577: ldc.i4    3681
						IL_057C: ldc.i4.s  15
						IL_057E: ldc.i4.1
						IL_057F: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (87,107)-(87,129) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0584: ldloc.1
						IL_0585: ldstr     ""
						IL_058A: ldc.i4    3696
						IL_058F: ldloc.s   provider
						IL_0591: callvirt  instance string Mega.Has.Modules.UAS.Models.ExternalProvider::get_DisplayName()
						IL_0596: ldc.i4    3696
						IL_059B: ldc.i4.s  21
						IL_059D: ldc.i4.0
						IL_059E: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_05A3: ldloc.1
						IL_05A4: ldstr     ""
						IL_05A9: ldc.i4    3717
						IL_05AE: ldstr     "',"
						IL_05B3: ldc.i4    3717
						IL_05B8: ldc.i4.2
						IL_05B9: ldc.i4.1
						IL_05BA: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_05BF: ldloc.1
						IL_05C0: ldstr     " "
						IL_05C5: ldc.i4    3719
						IL_05CA: ldstr     "'"
						IL_05CF: ldc.i4    3720
						IL_05D4: ldc.i4.2
						IL_05D5: ldc.i4.1
						IL_05D6: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (87,132)-(87,149) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_05DB: ldloc.1
						IL_05DC: ldstr     ""
						IL_05E1: ldc.i4    3721
						IL_05E6: ldloc.1
						IL_05E7: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
						IL_05EC: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_ReturnUrl()
						IL_05F1: ldc.i4    3721
						IL_05F6: ldc.i4.s  16
						IL_05F8: ldc.i4.0
						IL_05F9: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_05FE: ldloc.1
						IL_05FF: ldstr     ""
						IL_0604: ldc.i4    3737
						IL_0609: ldstr     "')"
						IL_060E: ldc.i4    3737
						IL_0613: ldc.i4.2
						IL_0614: ldc.i4.1
						IL_0615: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_061A: ldloc.1
						IL_061B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0620: ldloc.1
						IL_0621: ldstr     ">\r\n                                <span class=\"fa fa-share-alt\"></span>\r\n                                "
						IL_0626: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
						/* (89,34)-(89,55) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_062B: ldloc.1
						IL_062C: ldloc.s   provider
						IL_062E: callvirt  instance string Mega.Has.Modules.UAS.Models.ExternalProvider::get_DisplayName()
						IL_0633: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
						/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0638: ldloc.1
						IL_0639: ldstr     "\r\n                            </a>\r\n                        </div>\r\n"
						IL_063E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

						/* (84,44)-(84,46) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
						IL_0643: ldloc.s   V_7
						IL_0645: callvirt  instance bool [System.Runtime]System.Collections.IEnumerator::MoveNext()
						IL_064A: brtrue    IL_0533
					// end loop

					IL_064F: leave.s   IL_0661
				} // end .try
				finally
				{
					/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
					IL_0651: ldloc.0
					IL_0652: ldc.i4.0
					IL_0653: bge.s     IL_0660

					IL_0655: ldloc.s   V_7
					IL_0657: brfalse.s IL_0660

					IL_0659: ldloc.s   V_7
					IL_065B: callvirt  instance void [System.Runtime]System.IDisposable::Dispose()

					/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
					IL_0660: endfinally
				} // end handler

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0661: ldloc.1
				IL_0662: ldstr     "                </div>\r\n"
				IL_0667: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (94,18)-(94,44) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_066C: ldloc.1
				IL_066D: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0672: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ShowBasicSignin()
				IL_0677: brfalse.s IL_06A5

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0679: ldloc.1
				IL_067A: ldstr     "                    <!-- OR -->\r\n                    <div class=\"login-or\">\r\n                        <hr class=\"hr-or\">\r\n                        <span class=\"span-or\">"
				IL_067F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (99,48)-(99,56) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0684: ldloc.1
				IL_0685: ldloc.1
				IL_0686: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_068B: ldstr     "or"
				IL_0690: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0695: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_069A: ldloc.1
				IL_069B: ldstr     "</span>\r\n                    </div>\r\n"
				IL_06A0: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06A5: ldloc.1
				IL_06A6: ldstr     "\r\n"
				IL_06AB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (104,14)-(104,40) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06B0: ldloc.1
				IL_06B1: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_06B6: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ShowBasicSignin()
				IL_06BB: brfalse   IL_0A50

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06C0: ldloc.1
				IL_06C1: ldstr     "                <!-- Basic -->\r\n                <div class=\"form-group my-4 mx-5\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">"
				IL_06C6: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (108,114)-(108,125) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06CB: ldloc.1
				IL_06CC: ldloc.1
				IL_06CD: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_06D2: ldstr     "login"
				IL_06D7: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_06DC: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06E1: ldloc.1
				IL_06E2: ldstr     "</label></div></div>\r\n                    <input class=\"form-control bg-light\" autofocus autocomplete=\"off\""
				IL_06E7: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06EC: ldloc.1
				IL_06ED: ldstr     "placeholder"
				IL_06F2: ldstr     " placeholder=\""
				IL_06F7: ldc.i4    4664
				IL_06FC: ldstr     "\""
				IL_0701: ldc.i4    4689
				IL_0706: ldc.i4.1
				IL_0707: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
				/* (109,100)-(109,112) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_070C: ldloc.1
				IL_070D: ldstr     ""
				IL_0712: ldc.i4    4678
				IL_0717: ldloc.1
				IL_0718: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_071D: ldstr     "login"
				IL_0722: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0727: ldc.i4    4678
				IL_072C: ldc.i4.s  11
				IL_072E: ldc.i4.0
				IL_072F: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0734: ldloc.1
				IL_0735: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_073A: ldloc.1
				IL_073B: ldstr     "value"
				IL_0740: ldstr     " value=\""
				IL_0745: ldc.i4    4690
				IL_074A: ldstr     "\""
				IL_074F: ldc.i4    4713
				IL_0754: ldc.i4.1
				IL_0755: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
				/* (109,120)-(109,136) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_075A: ldloc.1
				IL_075B: ldstr     ""
				IL_0760: ldc.i4    4698
				IL_0765: ldloc.1
				IL_0766: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_076B: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_UserName()
				IL_0770: ldc.i4    4698
				IL_0775: ldc.i4.s  15
				IL_0777: ldc.i4.0
				IL_0778: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_077D: ldloc.1
				IL_077E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0783: ldloc.1
				IL_0784: ldstr     " name=\"UserName\" id=\"UserName\" />\r\n                </div>\r\n"
				IL_0789: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_078E: ldloc.1
				IL_078F: ldstr     "                <div class=\"form-group my-4 mx-5\">\r\n                    <div class=\"show-v6\" style=\"display:none;\"><div class=\"text-start\"><label class=\"mx-2 my-1\">"
				IL_0794: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (113,114)-(113,128) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0799: ldloc.1
				IL_079A: ldloc.1
				IL_079B: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_07A0: ldstr     "password"
				IL_07A5: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_07AA: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07AF: ldloc.1
				IL_07B0: ldstr     "</label></div></div>\r\n                    <div class=\"input-group\" id=\"show_hide_password\">\r\n                        "
				IL_07B5: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07BA: ldloc.1
				IL_07BB: ldloc.1
				IL_07BC: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_07C1: ldstr     "input"
				IL_07C6: ldc.i4.1
				IL_07C7: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c35275"
				IL_07CC: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_9'
				IL_07D1: dup
				IL_07D2: brtrue.s  IL_07EB

				IL_07D4: pop
				IL_07D5: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_07DA: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_9'()
				IL_07E0: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_07E5: dup
				IL_07E6: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_9'

				IL_07EB: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_07F0: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07F5: ldloc.1
				IL_07F6: ldloc.1
				IL_07F7: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
				IL_07FC: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0801: ldloc.1
				IL_0802: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0807: ldloc.1
				IL_0808: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_080D: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0812: ldloc.1
				IL_0813: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_0818: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_7
				IL_081D: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_0822: castclass [System.Runtime]System.String
				IL_0827: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_082C: ldloc.1
				IL_082D: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0832: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_7
				IL_0837: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_083C: ldloc.1
				IL_083D: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0842: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_8
				IL_0847: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_084C: ldloc.1
				IL_084D: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0852: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_9
				IL_0857: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (115,1)-(115,145) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_085C: ldloc.1
				IL_085D: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_0862: ldloc.1
				IL_0863: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::get_ModelExpressionProvider()
				IL_0868: ldloc.1
				IL_0869: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!0> class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_ViewData()
				IL_086E: ldtoken   Mega.Has.Modules.UAS.ViewModels.LoginViewModel
				IL_0873: call      class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
				IL_0878: ldstr     "__model"
				IL_087D: call      class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Parameter(class [System.Runtime]System.Type, string)
				IL_0882: stloc.2
				IL_0883: ldloc.2
				IL_0884: ldtoken   method instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_Password()
				IL_0889: call      class [System.Runtime]System.Reflection.MethodBase [System.Runtime]System.Reflection.MethodBase::GetMethodFromHandle(valuetype [System.Runtime]System.RuntimeMethodHandle)
				IL_088E: castclass [System.Runtime]System.Reflection.MethodInfo
				IL_0893: call      class [System.Linq.Expressions]System.Linq.Expressions.MemberExpression [System.Linq.Expressions]System.Linq.Expressions.Expression::Property(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Runtime]System.Reflection.MethodInfo)
				IL_0898: ldc.i4.1
				IL_0899: newarr    [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression
				IL_089E: dup
				IL_089F: ldc.i4.0
				IL_08A0: ldloc.2
				IL_08A1: stelem.ref
				IL_08A2: call      class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<!!0> [System.Linq.Expressions]System.Linq.Expressions.Expression::Lambda<class [System.Runtime]System.Func`2<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>>(class [System.Linq.Expressions]System.Linq.Expressions.Expression, class [System.Linq.Expressions]System.Linq.Expressions.ParameterExpression[])
				IL_08A7: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel, string>(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, class [System.Linq.Expressions]System.Linq.Expressions.Expression`1<class [System.Runtime]System.Func`2<!!0, !!1>>)
				IL_08AC: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08B1: ldloc.1
				IL_08B2: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_08B7: ldstr     "asp-for"
				IL_08BC: ldloc.1
				IL_08BD: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
				IL_08C2: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For()
				IL_08C7: ldc.i4.0
				IL_08C8: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08CD: ldloc.1
				IL_08CE: ldloc.1
				IL_08CF: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_08D4: ldstr     "placeholder"
				IL_08D9: ldc.i4.1
				IL_08DA: ldc.i4.0
				IL_08DB: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginAddHtmlAttributeValues(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext, string, int32, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (115,129)-(115,144) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08E0: ldloc.1
				IL_08E1: ldstr     ""
				IL_08E6: ldc.i4    5174
				IL_08EB: ldloc.1
				IL_08EC: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_08F1: ldstr     "password"
				IL_08F6: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_08FB: ldc.i4    5174
				IL_0900: ldc.i4.s  14
				IL_0902: ldc.i4.0
				IL_0903: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::AddHtmlAttributeValue(string, int32, object, int32, int32, bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0908: ldloc.1
				IL_0909: ldloc.1
				IL_090A: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_090F: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndAddHtmlAttributeValues(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0914: ldloc.1
				IL_0915: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_091A: ldloc.1
				IL_091B: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0920: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_0925: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_092A: stloc.s   V_9
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_092C: ldloca.s  V_9
				IL_092E: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0933: brtrue.s  IL_0976

				IL_0935: ldarg.0
				IL_0936: ldc.i4.4
				IL_0937: dup
				IL_0938: stloc.0
				IL_0939: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_093E: ldarg.0
				IL_093F: ldloc.s   V_9
				IL_0941: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0946: ldarg.0
				IL_0947: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_094C: ldloca.s  V_9
				IL_094E: ldarg.0
				IL_094F: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_0954: leave     IL_0B62

				/* Resume Instruction */
				IL_0959: ldarg.0
				IL_095A: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_095F: stloc.s   V_9
				IL_0961: ldarg.0
				IL_0962: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_0967: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_096D: ldarg.0
				IL_096E: ldc.i4.m1
				IL_096F: dup
				IL_0970: stloc.0
				IL_0971: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_0976: ldloca.s  V_9
				IL_0978: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_097D: ldloc.1
				IL_097E: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0983: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0988: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_098D: brtrue.s  IL_09F2

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_098F: ldloc.1
				IL_0990: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0995: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_099A: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_099F: stloc.s   V_10
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09A1: ldloca.s  V_10
				IL_09A3: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_09A8: brtrue.s  IL_09EB

				IL_09AA: ldarg.0
				IL_09AB: ldc.i4.5
				IL_09AC: dup
				IL_09AD: stloc.0
				IL_09AE: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				/* Yield Instruction */
				IL_09B3: ldarg.0
				IL_09B4: ldloc.s   V_10
				IL_09B6: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_09BB: ldarg.0
				IL_09BC: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_09C1: ldloca.s  V_10
				IL_09C3: ldarg.0
				IL_09C4: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&, !!1&)
				IL_09C9: leave     IL_0B62

				/* Resume Instruction */
				IL_09CE: ldarg.0
				IL_09CF: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_09D4: stloc.s   V_10
				IL_09D6: ldarg.0
				IL_09D7: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>u__1'
				IL_09DC: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_09E2: ldarg.0
				IL_09E3: ldc.i4.m1
				IL_09E4: dup
				IL_09E5: stloc.0
				IL_09E6: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'

				IL_09EB: ldloca.s  V_10
				IL_09ED: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09F2: ldloc.1
				IL_09F3: ldloc.1
				IL_09F4: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_09F9: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_09FE: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A03: ldloc.1
				IL_0A04: ldloc.1
				IL_0A05: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_0A0A: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_0A0F: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A14: ldloc.1
				IL_0A15: ldstr     "\r\n                        <a class=\"input-group-text eye\""
				IL_0A1A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A1F: ldloc.1
				IL_0A20: ldstr     "href"
				IL_0A25: ldstr     " href=\""
				IL_0A2A: ldc.i4    5249
				IL_0A2F: ldstr     "\""
				IL_0A34: ldc.i4    5256
				IL_0A39: ldc.i4.0
				IL_0A3A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A3F: ldloc.1
				IL_0A40: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A45: ldloc.1
				IL_0A46: ldstr     " >\r\n                            <i id=\"show_hide_password_icon\" class=\"fa fa-eye-slash\" aria-hidden=\"true\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n"
				IL_0A4B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A50: ldloc.1
				IL_0A51: ldstr     "            <div class=\"mt-auto swapcontainer\">\r\n\r\n                <!-- Button -->\r\n"
				IL_0A56: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (126,18)-(126,44) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A5B: ldloc.1
				IL_0A5C: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0A61: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ShowBasicSignin()
				IL_0A66: brfalse.s IL_0A94

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A68: ldloc.1
				IL_0A69: ldstr     "                    <button class=\"btn btn-hopex btn-success mx-50 my-20 first_div\" type=\"submit\" id=\"btnSubmit\">"
				IL_0A6E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (128,115)-(128,128) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A73: ldloc.1
				IL_0A74: ldloc.1
				IL_0A75: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0A7A: ldstr     "Sign in"
				IL_0A7F: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0A84: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A89: ldloc.1
				IL_0A8A: ldstr     "</button>\r\n"
				IL_0A8F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A94: ldloc.1
				IL_0A95: ldstr     "\r\n"
				IL_0A9A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (131,18)-(131,44) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A9F: ldloc.1
				IL_0AA0: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0AA5: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ShowBasicSignin()
				IL_0AAA: brfalse.s IL_0AE5

				/* (133,21)-(133,44) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AAC: ldloc.1
				IL_0AAD: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0AB2: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_IsSetupMode()
				IL_0AB7: brtrue.s  IL_0AE5

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AB9: ldloc.1
				IL_0ABA: ldstr     "                        <div class=\"mx-5 text-center mb-2 second_div forgot-password\">\r\n                            <i class=\"mx-2 fa fa-key show-v6\" style=\"display:none\"></i>\r\n\r\n                            <a href=\"/uas/password/lostpassword\" class=\"text-dark\">\r\n                                <h6 class=\"d-inline\">"
				IL_0ABF: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (139,55)-(139,76) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AC4: ldloc.1
				IL_0AC5: ldloc.1
				IL_0AC6: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0ACB: ldstr     "Forgot password"
				IL_0AD0: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0AD5: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0ADA: ldloc.1
				IL_0ADB: ldstr     "</h6>\r\n                            </a>\r\n                        </div>\r\n"
				IL_0AE0: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AE5: ldloc.1
				IL_0AE6: ldstr     "\r\n"
				IL_0AEB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (145,18)-(145,43) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AF0: ldloc.1
				IL_0AF1: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0AF6: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_IsInitialized()
				IL_0AFB: brtrue.s  IL_0B29

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0AFD: ldloc.1
				IL_0AFE: ldstr     "                    <div class=\"text-center mb-2\">\r\n                        <h6>"
				IL_0B03: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (148,30)-(148,66) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0B08: ldloc.1
				IL_0B09: ldloc.1
				IL_0B0A: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0B0F: ldstr     "SETUP MODE - Use default login"
				IL_0B14: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0B19: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0B1E: ldloc.1
				IL_0B1F: ldstr     "</h6>\r\n                    </div>\r\n"
				IL_0B24: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0B29: ldloc.1
				IL_0B2A: ldstr     "\r\n\r\n            </div>\r\n        "
				IL_0B2F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0B34: leave.s   IL_0B4F
			} // end .try
			catch [System.Runtime]System.Exception
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0B36: stloc.s   V_11
				IL_0B38: ldarg.0
				IL_0B39: ldc.i4.s  -2
				IL_0B3B: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
				IL_0B40: ldarg.0
				IL_0B41: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
				IL_0B46: ldloc.s   V_11
				IL_0B48: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_0B4D: leave.s   IL_0B62
			} // end handler

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0B4F: ldarg.0
			IL_0B50: ldc.i4.s  -2
			IL_0B52: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0B57: ldarg.0
			IL_0B58: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
			IL_0B5D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_0B62: ret
		} // end of method '<<ExecuteAsync>b__29_3>d'::MoveNext

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
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__29_3>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__29_3>d

	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_4>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Views_Account_Login '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 7
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Views_Account_Login,
				[2] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] class [System.Runtime]System.Exception
			)

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_000E: ldloc.0
				IL_000F: brfalse   IL_011D

				IL_0014: ldloc.0
				IL_0015: ldc.i4.1
				IL_0016: beq       IL_018C

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_001B: ldloc.1
				IL_001C: ldstr     "\r\n    "
				IL_0021: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0026: ldloc.1
				IL_0027: ldloc.1
				IL_0028: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_002D: ldstr     "script"
				IL_0032: ldc.i4.0
				IL_0033: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c45613"
				IL_0038: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_12'
				IL_003D: dup
				IL_003E: brtrue.s  IL_0057

				IL_0040: pop
				IL_0041: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_0046: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_12'()
				IL_004C: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0051: dup
				IL_0052: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_12'

				IL_0057: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_005C: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0061: ldloc.1
				IL_0062: ldloc.1
				IL_0063: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>()
				IL_0068: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_006D: ldloc.1
				IL_006E: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0073: ldloc.1
				IL_0074: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
				IL_0079: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_007E: ldloc.1
				IL_007F: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
				IL_0084: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_14
				IL_0089: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_008E: castclass [System.Runtime]System.String
				IL_0093: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::set_Src(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0098: ldloc.1
				IL_0099: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_009E: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_14
				IL_00A3: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (173,1)-(173,76) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00A8: ldloc.1
				IL_00A9: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
				IL_00AE: ldc.i4.1
				IL_00AF: newobj    instance void valuetype [System.Runtime]System.Nullable`1<bool>::.ctor(!0)
				IL_00B4: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::set_AppendVersion(valuetype [System.Runtime]System.Nullable`1<bool>)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00B9: ldloc.1
				IL_00BA: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00BF: ldstr     "asp-append-version"
				IL_00C4: ldloc.1
				IL_00C5: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
				IL_00CA: callvirt  instance valuetype [System.Runtime]System.Nullable`1<bool> [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::get_AppendVersion()
				IL_00CF: box       valuetype [System.Runtime]System.Nullable`1<bool>
				IL_00D4: ldc.i4.0
				IL_00D5: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00DA: ldloc.1
				IL_00DB: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_00E0: ldloc.1
				IL_00E1: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00E6: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_00EB: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_00F0: stloc.2
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00F1: ldloca.s  V_2
				IL_00F3: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_00F8: brtrue.s  IL_0139

				IL_00FA: ldarg.0
				IL_00FB: ldc.i4.0
				IL_00FC: dup
				IL_00FD: stloc.0
				IL_00FE: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
				/* Yield Instruction */
				IL_0103: ldarg.0
				IL_0104: ldloc.2
				IL_0105: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_010A: ldarg.0
				IL_010B: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
				IL_0110: ldloca.s  V_2
				IL_0112: ldarg.0
				IL_0113: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'>(!!0&, !!1&)
				IL_0118: leave     IL_020A

				/* Resume Instruction */
				IL_011D: ldarg.0
				IL_011E: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_0123: stloc.2
				IL_0124: ldarg.0
				IL_0125: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_012A: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0130: ldarg.0
				IL_0131: ldc.i4.m1
				IL_0132: dup
				IL_0133: stloc.0
				IL_0134: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'

				IL_0139: ldloca.s  V_2
				IL_013B: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0140: ldloc.1
				IL_0141: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0146: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_014B: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_0150: brtrue.s  IL_01AF

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0152: ldloc.1
				IL_0153: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0158: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_015D: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0162: stloc.3
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0163: ldloca.s  V_3
				IL_0165: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_016A: brtrue.s  IL_01A8

				IL_016C: ldarg.0
				IL_016D: ldc.i4.1
				IL_016E: dup
				IL_016F: stloc.0
				IL_0170: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
				/* Yield Instruction */
				IL_0175: ldarg.0
				IL_0176: ldloc.3
				IL_0177: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_017C: ldarg.0
				IL_017D: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
				IL_0182: ldloca.s  V_3
				IL_0184: ldarg.0
				IL_0185: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'>(!!0&, !!1&)
				IL_018A: leave.s   IL_020A

				/* Resume Instruction */
				IL_018C: ldarg.0
				IL_018D: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_0192: stloc.3
				IL_0193: ldarg.0
				IL_0194: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>u__1'
				IL_0199: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_019F: ldarg.0
				IL_01A0: ldc.i4.m1
				IL_01A1: dup
				IL_01A2: stloc.0
				IL_01A3: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'

				IL_01A8: ldloca.s  V_3
				IL_01AA: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01AF: ldloc.1
				IL_01B0: ldloc.1
				IL_01B1: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_01B6: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_01BB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01C0: ldloc.1
				IL_01C1: ldloc.1
				IL_01C2: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_01C7: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_01CC: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01D1: ldloc.1
				IL_01D2: ldstr     "\r\n    <script>\r\n        function GoToRedirectUri(returnUrl) {\r\n            var urlParams = new URLSearchParams(returnUrl);\r\n            var redirectUri = urlParams.get('redirect_uri');\r\n            redirectUri = redirectUri.replace('/signin-oidc', '');\r\n            window.location.href = redirectUri;\r\n        }\r\n    </script>\r\n"
				IL_01D7: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_01DC: leave.s   IL_01F7
			} // end .try
			catch [System.Runtime]System.Exception
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01DE: stloc.s   V_4
				IL_01E0: ldarg.0
				IL_01E1: ldc.i4.s  -2
				IL_01E3: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
				IL_01E8: ldarg.0
				IL_01E9: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
				IL_01EE: ldloc.s   V_4
				IL_01F0: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_01F5: leave.s   IL_020A
			} // end handler

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_01F7: ldarg.0
			IL_01F8: ldc.i4.s  -2
			IL_01FA: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_01FF: ldarg.0
			IL_0200: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
			IL_0205: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_020A: ret
		} // end of method '<<ExecuteAsync>b__29_4>d'::MoveNext

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
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__29_4>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__29_4>d

	.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_7>d'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Views_Account_Login '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 7
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Views_Account_Login,
				[2] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] class [System.Runtime]System.Exception
			)

			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				IL_000E: ldloc.0
				IL_000F: brfalse   IL_010C

				IL_0014: ldloc.0
				IL_0015: ldc.i4.1
				IL_0016: beq       IL_017B

				IL_001B: ldloc.1
				IL_001C: ldstr     "\r\n                            "
				IL_0021: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_0026: ldloc.1
				IL_0027: ldloc.1
				IL_0028: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_002D: ldstr     "option"
				IL_0032: ldc.i4.0
				IL_0033: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c25070"
				IL_0038: ldloc.1
				IL_0039: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login::'<ExecuteAsync>b__29_11'()
				IL_003F: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0044: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_0049: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_004E: ldloc.1
				IL_004F: ldloc.1
				IL_0050: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>()
				IL_0055: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
				IL_005A: ldloc.1
				IL_005B: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0060: ldloc.1
				IL_0061: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
				IL_0066: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				IL_006B: ldloc.1
				IL_006C: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute()
				IL_0071: ldloc.1
				IL_0072: ldloc.1
				IL_0073: call      instance string [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute()
				IL_0078: stfld     string AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperStringValueBuffer
				IL_007D: ldloc.1
				IL_007E: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0083: ldstr     "disabled"
				IL_0088: ldloc.1
				IL_0089: call      instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> AspNetCoreGeneratedDocument.Views_Account_Login::get_Html()
				IL_008E: ldloc.1
				IL_008F: ldfld     string AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperStringValueBuffer
				IL_0094: callvirt  instance class [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.IHtmlContent class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::Raw(string)
				IL_0099: ldc.i4.3
				IL_009A: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				IL_009F: ldloc.1
				IL_00A0: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
				IL_00A5: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_5
				IL_00AA: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_00AF: castclass [System.Runtime]System.String
				IL_00B4: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper::set_Value(string)
				IL_00B9: ldloc.1
				IL_00BA: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00BF: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_5
				IL_00C4: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				IL_00C9: ldloc.1
				IL_00CA: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_00CF: ldloc.1
				IL_00D0: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00D5: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_00DA: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_00DF: stloc.2
				IL_00E0: ldloca.s  V_2
				IL_00E2: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_00E7: brtrue.s  IL_0128

				IL_00E9: ldarg.0
				IL_00EA: ldc.i4.0
				IL_00EB: dup
				IL_00EC: stloc.0
				IL_00ED: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
				IL_00F2: ldarg.0
				IL_00F3: ldloc.2
				IL_00F4: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_00F9: ldarg.0
				IL_00FA: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
				IL_00FF: ldloca.s  V_2
				IL_0101: ldarg.0
				IL_0102: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'>(!!0&, !!1&)
				IL_0107: leave     IL_01F9

				IL_010C: ldarg.0
				IL_010D: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_0112: stloc.2
				IL_0113: ldarg.0
				IL_0114: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_0119: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_011F: ldarg.0
				IL_0120: ldc.i4.m1
				IL_0121: dup
				IL_0122: stloc.0
				IL_0123: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'

				IL_0128: ldloca.s  V_2
				IL_012A: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				IL_012F: ldloc.1
				IL_0130: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0135: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_013A: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_013F: brtrue.s  IL_019E

				IL_0141: ldloc.1
				IL_0142: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0147: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_014C: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0151: stloc.3
				IL_0152: ldloca.s  V_3
				IL_0154: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0159: brtrue.s  IL_0197

				IL_015B: ldarg.0
				IL_015C: ldc.i4.1
				IL_015D: dup
				IL_015E: stloc.0
				IL_015F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
				IL_0164: ldarg.0
				IL_0165: ldloc.3
				IL_0166: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_016B: ldarg.0
				IL_016C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
				IL_0171: ldloca.s  V_3
				IL_0173: ldarg.0
				IL_0174: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'>(!!0&, !!1&)
				IL_0179: leave.s   IL_01F9

				IL_017B: ldarg.0
				IL_017C: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_0181: stloc.3
				IL_0182: ldarg.0
				IL_0183: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>u__1'
				IL_0188: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_018E: ldarg.0
				IL_018F: ldc.i4.m1
				IL_0190: dup
				IL_0191: stloc.0
				IL_0192: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'

				IL_0197: ldloca.s  V_3
				IL_0199: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				IL_019E: ldloc.1
				IL_019F: ldloc.1
				IL_01A0: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_01A5: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_01AA: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				IL_01AF: ldloc.1
				IL_01B0: ldloc.1
				IL_01B1: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_01B6: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_01BB: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_01C0: ldloc.1
				IL_01C1: ldstr     "\r\n                        "
				IL_01C6: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				IL_01CB: leave.s   IL_01E6
			} // end .try
			catch [System.Runtime]System.Exception
			{
				IL_01CD: stloc.s   V_4
				IL_01CF: ldarg.0
				IL_01D0: ldc.i4.s  -2
				IL_01D2: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
				IL_01D7: ldarg.0
				IL_01D8: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
				IL_01DD: ldloc.s   V_4
				IL_01DF: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_01E4: leave.s   IL_01F9
			} // end handler

			IL_01E6: ldarg.0
			IL_01E7: ldc.i4.s  -2
			IL_01E9: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
			IL_01EE: ldarg.0
			IL_01EF: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
			IL_01F4: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_01F9: ret
		} // end of method '<<ExecuteAsync>b__29_7>d'::MoveNext

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
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<<ExecuteAsync>b__29_7>d'::SetStateMachine

	} // end of class <<ExecuteAsync>b__29_7>d

	.class nested private auto ansi sealed serializable beforefieldinit '<>c'
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Nested Types
		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_0>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_0>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_0>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_0>d

		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_12>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_12>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_12>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_12>d

		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_1>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_1>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_1>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_1>d

		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_2>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_2>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_2>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_2>d

		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_5>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_5>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_5>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_5>d

		.class nested private auto ansi sealed beforefieldinit '<<ExecuteAsync>b__29_9>d'
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
				IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>1__state'
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
					IL_000D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>1__state'
					IL_0012: ldarg.0
					IL_0013: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
					IL_0018: ldloc.1
					IL_0019: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
					IL_001E: leave.s   IL_0033
				} // end handler

				IL_0020: ldarg.0
				IL_0021: ldc.i4.s  -2
				IL_0023: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>1__state'
				IL_0028: ldarg.0
				IL_0029: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
				IL_002E: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

				IL_0033: ret
			} // end of method '<<ExecuteAsync>b__29_9>d'::MoveNext

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
				IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
				IL_0006: ldarg.1
				IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
				IL_000C: ret
			} // end of method '<<ExecuteAsync>b__29_9>d'::SetStateMachine

		} // end of class <<ExecuteAsync>b__29_9>d


		// Fields
		.field public static initonly class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' '<>9'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_0'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_1'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_2'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_5'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_9'
		.field public static class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> '<>9__29_12'

		// Methods
		.method private hidebysig specialname rtspecialname static 
			void .cctor () cil managed 
		{
			.maxstack 8

			IL_0000: newobj    instance void AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::.ctor()
			IL_0005: stsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
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
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_0' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4c 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 30 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_0>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_0'

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_1' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4c 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 31 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_1>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_1'

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_2' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4c 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 32 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_2>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_2'

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_5' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4c 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 35 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_5>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_5'

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_9' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4c 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 39 3e 64 00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_9>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_9'

		.method assembly hidebysig 
			instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_12' () cil managed 
		{
			.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
				01 00 4d 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
				65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
				69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
				69 6e 2b 3c 3e 63 2b 3c 3c 45 78 65 63 75 74 65
				41 73 79 6e 63 3e 62 5f 5f 32 39 5f 31 32 3e 64
				00 00
			)
			.maxstack 2
			.locals init (
				[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'
			)

			IL_0000: ldloca.s  V_0
			IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
			IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
			IL_000C: ldloca.s  V_0
			IL_000E: ldc.i4.m1
			IL_000F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>1__state'
			IL_0014: ldloca.s  V_0
			IL_0016: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
			IL_001B: ldloca.s  V_0
			IL_001D: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'>(!!0&)
			IL_0022: ldloca.s  V_0
			IL_0024: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'/'<<ExecuteAsync>b__29_12>d'::'<>t__builder'
			IL_0029: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
			IL_002E: ret
		} // end of method '<>c'::'<ExecuteAsync>b__29_12'

	} // end of class <>c

	.class nested private auto ansi sealed beforefieldinit '<ExecuteAsync>d__29'
		extends [System.Runtime]System.ValueType
		implements [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public int32 '<>1__state'
		.field public valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '<>t__builder'
		.field public class AspNetCoreGeneratedDocument.Views_Account_Login '<>4__this'
		.field private valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter '<>u__1'

		// Methods
		.method private final hidebysig newslot virtual 
			instance void MoveNext () cil managed 
		{
			.override method instance void [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine::MoveNext()
			.maxstack 7
			.locals init (
				[0] int32,
				[1] class AspNetCoreGeneratedDocument.Views_Account_Login,
				[2] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[3] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[4] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[5] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[6] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[7] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[8] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[9] valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter,
				[10] class [System.Runtime]System.Exception
			)

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0000: ldarg.0
			IL_0001: ldfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
			IL_0006: stloc.0
			IL_0007: ldarg.0
			IL_0008: ldfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>4__this'
			IL_000D: stloc.1
			.try
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_000E: ldloc.0
				IL_000F: switch    (IL_016C, IL_01DE, IL_03BA, IL_042F, IL_064E, IL_06C3, IL_083A, IL_08AF)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0034: ldloc.1
				IL_0035: ldstr     "\r\n"
				IL_003A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (3,2)-(3,28) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_003F: ldloc.1
				IL_0040: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0045: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_IsLoginDisabled()
				IL_004A: brfalse   IL_029B

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_004F: ldloc.1
				IL_0050: ldstr     "    <div class=\"p-0 py-3 account-login border shadow rounded d-flex align-items-start flex-column justify-content-center\">\r\n        <div class=\"py-3 mx-auto\">\r\n            "
				IL_0055: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_005A: ldloc.1
				IL_005B: ldloc.1
				IL_005C: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_0061: ldstr     "img"
				IL_0066: ldc.i4.1
				IL_0067: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c10026"
				IL_006C: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_0'
				IL_0071: dup
				IL_0072: brtrue.s  IL_008B

				IL_0074: pop
				IL_0075: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_007A: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_0'()
				IL_0080: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_0085: dup
				IL_0086: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_0'

				IL_008B: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_0090: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0095: ldloc.1
				IL_0096: ldloc.1
				IL_0097: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>()
				IL_009C: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00A1: ldloc.1
				IL_00A2: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00A7: ldloc.1
				IL_00A8: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_00AD: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00B2: ldloc.1
				IL_00B3: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_00B8: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_0
				IL_00BD: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_00C2: castclass [System.Runtime]System.String
				IL_00C7: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::set_Src(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00CC: ldloc.1
				IL_00CD: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00D2: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_0
				IL_00D7: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00DC: ldloc.1
				IL_00DD: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00E2: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_1
				IL_00E7: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00EC: ldloc.1
				IL_00ED: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_00F2: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_2
				IL_00F7: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (7,1)-(7,75) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_00FC: ldloc.1
				IL_00FD: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_0102: ldc.i4.1
				IL_0103: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::set_AppendVersion(bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0108: ldloc.1
				IL_0109: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_010E: ldstr     "asp-append-version"
				IL_0113: ldloc.1
				IL_0114: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_0119: callvirt  instance bool [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::get_AppendVersion()
				IL_011E: box       [System.Runtime]System.Boolean
				IL_0123: ldc.i4.0
				IL_0124: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0129: ldloc.1
				IL_012A: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_012F: ldloc.1
				IL_0130: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0135: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_013A: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_013F: stloc.2
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0140: ldloca.s  V_2
				IL_0142: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0147: brtrue.s  IL_0188

				IL_0149: ldarg.0
				IL_014A: ldc.i4.0
				IL_014B: dup
				IL_014C: stloc.0
				IL_014D: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_0152: ldarg.0
				IL_0153: ldloc.2
				IL_0154: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0159: ldarg.0
				IL_015A: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_015F: ldloca.s  V_2
				IL_0161: ldarg.0
				IL_0162: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_0167: leave     IL_0A6E

				/* Resume Instruction */
				IL_016C: ldarg.0
				IL_016D: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0172: stloc.2
				IL_0173: ldarg.0
				IL_0174: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0179: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_017F: ldarg.0
				IL_0180: ldc.i4.m1
				IL_0181: dup
				IL_0182: stloc.0
				IL_0183: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_0188: ldloca.s  V_2
				IL_018A: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_018F: ldloc.1
				IL_0190: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0195: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_019A: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_019F: brtrue.s  IL_0201

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01A1: ldloc.1
				IL_01A2: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_01A7: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_01AC: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_01B1: stloc.3
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_01B2: ldloca.s  V_3
				IL_01B4: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_01B9: brtrue.s  IL_01FA

				IL_01BB: ldarg.0
				IL_01BC: ldc.i4.1
				IL_01BD: dup
				IL_01BE: stloc.0
				IL_01BF: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_01C4: ldarg.0
				IL_01C5: ldloc.3
				IL_01C6: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_01CB: ldarg.0
				IL_01CC: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_01D1: ldloca.s  V_3
				IL_01D3: ldarg.0
				IL_01D4: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_01D9: leave     IL_0A6E

				/* Resume Instruction */
				IL_01DE: ldarg.0
				IL_01DF: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_01E4: stloc.3
				IL_01E5: ldarg.0
				IL_01E6: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_01EB: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_01F1: ldarg.0
				IL_01F2: ldc.i4.m1
				IL_01F3: dup
				IL_01F4: stloc.0
				IL_01F5: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_01FA: ldloca.s  V_3
				IL_01FC: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0201: ldloc.1
				IL_0202: ldloc.1
				IL_0203: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0208: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_020D: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0212: ldloc.1
				IL_0213: ldloc.1
				IL_0214: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_0219: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_021E: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0223: ldloc.1
				IL_0224: ldstr     "\r\n        </div>\r\n        <div class=\"mx-auto py-1 module-name\">\r\n"
				IL_0229: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (10,14)-(10,42) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_022E: ldloc.1
				IL_022F: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0234: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_HideFriendlyName()
				IL_0239: brtrue.s  IL_024C

				/* (12,18)-(12,43) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_023B: ldloc.1
				IL_023C: ldloc.1
				IL_023D: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0242: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ModuleFriendlyName()
				IL_0247: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_024C: ldloc.1
				IL_024D: ldstr     "        </div>\r\n\r\n"
				IL_0252: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (16,10)-(16,36) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0257: ldloc.1
				IL_0258: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_025D: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Message()
				IL_0262: brfalse.s IL_028B

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0264: ldloc.1
				IL_0265: ldstr     "            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                <div class=\"col\">"
				IL_026A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (20,35)-(20,49) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_026F: ldloc.1
				IL_0270: ldloc.1
				IL_0271: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0276: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Message()
				IL_027B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0280: ldloc.1
				IL_0281: ldstr     "</div>\r\n            </div>\r\n"
				IL_0286: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_028B: ldloc.1
				IL_028C: ldstr     "    </div>\r\n"
				IL_0291: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0296: br        IL_0A1E

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_029B: ldloc.1
				IL_029C: ldstr     "    <div class=\"p-0 py-3 account-login border shadow rounded d-flex align-items-start flex-column justify-content-center\">\r\n        <div class=\"py-3 mx-auto\">\r\n            "
				IL_02A1: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02A6: ldloc.1
				IL_02A7: ldloc.1
				IL_02A8: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_02AD: ldstr     "img"
				IL_02B2: ldc.i4.1
				IL_02B3: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c14038"
				IL_02B8: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_1'
				IL_02BD: dup
				IL_02BE: brtrue.s  IL_02D7

				IL_02C0: pop
				IL_02C1: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_02C6: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_1'()
				IL_02CC: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_02D1: dup
				IL_02D2: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_1'

				IL_02D7: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_02DC: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02E1: ldloc.1
				IL_02E2: ldloc.1
				IL_02E3: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>()
				IL_02E8: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02ED: ldloc.1
				IL_02EE: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_02F3: ldloc.1
				IL_02F4: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_02F9: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_02FE: ldloc.1
				IL_02FF: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_0304: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_0
				IL_0309: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_030E: castclass [System.Runtime]System.String
				IL_0313: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::set_Src(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0318: ldloc.1
				IL_0319: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_031E: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_0
				IL_0323: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0328: ldloc.1
				IL_0329: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_032E: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_1
				IL_0333: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0338: ldloc.1
				IL_0339: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_033E: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_2
				IL_0343: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (29,1)-(29,75) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0348: ldloc.1
				IL_0349: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_034E: ldc.i4.1
				IL_034F: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::set_AppendVersion(bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0354: ldloc.1
				IL_0355: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_035A: ldstr     "asp-append-version"
				IL_035F: ldloc.1
				IL_0360: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
				IL_0365: callvirt  instance bool [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper::get_AppendVersion()
				IL_036A: box       [System.Runtime]System.Boolean
				IL_036F: ldc.i4.0
				IL_0370: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0375: ldloc.1
				IL_0376: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_037B: ldloc.1
				IL_037C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0381: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_0386: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_038B: stloc.s   V_4
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_038D: ldloca.s  V_4
				IL_038F: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0394: brtrue.s  IL_03D7

				IL_0396: ldarg.0
				IL_0397: ldc.i4.2
				IL_0398: dup
				IL_0399: stloc.0
				IL_039A: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_039F: ldarg.0
				IL_03A0: ldloc.s   V_4
				IL_03A2: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_03A7: ldarg.0
				IL_03A8: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_03AD: ldloca.s  V_4
				IL_03AF: ldarg.0
				IL_03B0: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_03B5: leave     IL_0A6E

				/* Resume Instruction */
				IL_03BA: ldarg.0
				IL_03BB: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_03C0: stloc.s   V_4
				IL_03C2: ldarg.0
				IL_03C3: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_03C8: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_03CE: ldarg.0
				IL_03CF: ldc.i4.m1
				IL_03D0: dup
				IL_03D1: stloc.0
				IL_03D2: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_03D7: ldloca.s  V_4
				IL_03D9: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_03DE: ldloc.1
				IL_03DF: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_03E4: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_03E9: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_03EE: brtrue.s  IL_0453

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_03F0: ldloc.1
				IL_03F1: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_03F6: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_03FB: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0400: stloc.s   V_5
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0402: ldloca.s  V_5
				IL_0404: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0409: brtrue.s  IL_044C

				IL_040B: ldarg.0
				IL_040C: ldc.i4.3
				IL_040D: dup
				IL_040E: stloc.0
				IL_040F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_0414: ldarg.0
				IL_0415: ldloc.s   V_5
				IL_0417: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_041C: ldarg.0
				IL_041D: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_0422: ldloca.s  V_5
				IL_0424: ldarg.0
				IL_0425: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_042A: leave     IL_0A6E

				/* Resume Instruction */
				IL_042F: ldarg.0
				IL_0430: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0435: stloc.s   V_5
				IL_0437: ldarg.0
				IL_0438: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_043D: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0443: ldarg.0
				IL_0444: ldc.i4.m1
				IL_0445: dup
				IL_0446: stloc.0
				IL_0447: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_044C: ldloca.s  V_5
				IL_044E: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0453: ldloc.1
				IL_0454: ldloc.1
				IL_0455: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_045A: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_045F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0464: ldloc.1
				IL_0465: ldloc.1
				IL_0466: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_046B: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_0470: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0475: ldloc.1
				IL_0476: ldstr     "\r\n        </div>\r\n        <div class=\"mx-auto py-1 module-name\">\r\n"
				IL_047B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (32,14)-(32,42) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0480: ldloc.1
				IL_0481: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0486: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_HideFriendlyName()
				IL_048B: brtrue.s  IL_049E

				/* (34,18)-(34,43) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_048D: ldloc.1
				IL_048E: ldloc.1
				IL_048F: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_0494: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ModuleFriendlyName()
				IL_0499: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_049E: ldloc.1
				IL_049F: ldstr     "        </div>\r\n\r\n"
				IL_04A4: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (38,10)-(38,36) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04A9: ldloc.1
				IL_04AA: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_04AF: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Message()
				IL_04B4: brfalse.s IL_04DD

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04B6: ldloc.1
				IL_04B7: ldstr     "            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                <div class=\"col\">"
				IL_04BC: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (42,35)-(42,49) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04C1: ldloc.1
				IL_04C2: ldloc.1
				IL_04C3: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_04C8: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_Message()
				IL_04CD: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04D2: ldloc.1
				IL_04D3: ldstr     "</div>\r\n            </div>\r\n"
				IL_04D8: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04DD: ldloc.1
				IL_04DE: ldstr     "        <!-- warning-->\r\n"
				IL_04E3: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (46,10)-(46,78) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_04E8: ldloc.1
				IL_04E9: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_04EE: callvirt  instance bool Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_ShowBasicSignin()
				IL_04F3: brtrue.s  IL_0554

				IL_04F5: ldloc.1
				IL_04F6: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_04FB: callvirt  instance class [System.Runtime]System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Models.ExternalProvider> Mega.Has.Modules.UAS.ViewModels.LoginViewModel::get_VisibleExternalProviders()
				IL_0500: call      bool [System.Linq]System.Linq.Enumerable::Any<class Mega.Has.Modules.UAS.Models.ExternalProvider>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
				IL_0505: brtrue.s  IL_0554

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0507: ldloc.1
				IL_0508: ldstr     "            <div class=\"alert alert-warning mx-auto error-login-page\">\r\n                <strong>"
				IL_050D: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (49,26)-(49,53) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0512: ldloc.1
				IL_0513: ldloc.1
				IL_0514: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0519: ldstr     "Invalid login request"
				IL_051E: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0523: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0528: ldloc.1
				IL_0529: ldstr     "</strong>\r\n                <br />\r\n                "
				IL_052E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (51,18)-(51,78) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0533: ldloc.1
				IL_0534: ldloc.1
				IL_0535: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_053A: ldstr     "There are no login schemes configured for this client."
				IL_053F: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0544: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0549: ldloc.1
				IL_054A: ldstr     "\r\n            </div>\r\n"
				IL_054F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (54,10)-(54,46) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0554: ldloc.1
				IL_0555: callvirt  instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.ViewContext [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::get_ViewContext()
				IL_055A: callvirt  instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.ActionContext::get_ModelState()
				IL_055F: callvirt  instance bool [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary::get_IsValid()
				IL_0564: brtrue    IL_0714

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0569: ldloc.1
				IL_056A: ldstr     "            <div class=\"row alert alert-danger mx-auto error-login-page\">\r\n                <div class=\"col-1 show-v6\" style=\"display:none;\"><i class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i></div>\r\n                "
				IL_056F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0574: ldloc.1
				IL_0575: ldloc.1
				IL_0576: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_057B: ldstr     "div"
				IL_0580: ldc.i4.0
				IL_0581: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c19369"
				IL_0586: ldsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_2'
				IL_058B: dup
				IL_058C: brtrue.s  IL_05A5

				IL_058E: pop
				IL_058F: ldsfld    class AspNetCoreGeneratedDocument.Views_Account_Login/'<>c' AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9'
				IL_0594: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<ExecuteAsync>b__29_2'()
				IL_059A: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_059F: dup
				IL_05A0: stsfld    class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Views_Account_Login/'<>c'::'<>9__29_2'

				IL_05A5: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_05AA: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_05AF: ldloc.1
				IL_05B0: ldloc.1
				IL_05B1: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>()
				IL_05B6: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_05BB: ldloc.1
				IL_05BC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_05C1: ldloc.1
				IL_05C2: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_05C7: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (58,1)-(58,151) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_05CC: ldloc.1
				IL_05CD: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_05D2: ldc.i4.2
				IL_05D3: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::set_ValidationSummary(valuetype [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_05D8: ldloc.1
				IL_05D9: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_05DE: ldstr     "asp-validation-summary"
				IL_05E3: ldloc.1
				IL_05E4: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
				IL_05E9: callvirt  instance valuetype [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::get_ValidationSummary()
				IL_05EE: box       [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary
				IL_05F3: ldc.i4.0
				IL_05F4: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_05F9: ldloc.1
				IL_05FA: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_05FF: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_3
				IL_0604: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0609: ldloc.1
				IL_060A: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_060F: ldloc.1
				IL_0610: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0615: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_061A: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_061F: stloc.s   V_6
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0621: ldloca.s  V_6
				IL_0623: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0628: brtrue.s  IL_066B

				IL_062A: ldarg.0
				IL_062B: ldc.i4.4
				IL_062C: dup
				IL_062D: stloc.0
				IL_062E: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_0633: ldarg.0
				IL_0634: ldloc.s   V_6
				IL_0636: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_063B: ldarg.0
				IL_063C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_0641: ldloca.s  V_6
				IL_0643: ldarg.0
				IL_0644: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_0649: leave     IL_0A6E

				/* Resume Instruction */
				IL_064E: ldarg.0
				IL_064F: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0654: stloc.s   V_6
				IL_0656: ldarg.0
				IL_0657: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_065C: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_0662: ldarg.0
				IL_0663: ldc.i4.m1
				IL_0664: dup
				IL_0665: stloc.0
				IL_0666: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_066B: ldloca.s  V_6
				IL_066D: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0672: ldloc.1
				IL_0673: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0678: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_067D: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_0682: brtrue.s  IL_06E7

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0684: ldloc.1
				IL_0685: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_068A: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_068F: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0694: stloc.s   V_7
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0696: ldloca.s  V_7
				IL_0698: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_069D: brtrue.s  IL_06E0

				IL_069F: ldarg.0
				IL_06A0: ldc.i4.5
				IL_06A1: dup
				IL_06A2: stloc.0
				IL_06A3: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_06A8: ldarg.0
				IL_06A9: ldloc.s   V_7
				IL_06AB: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_06B0: ldarg.0
				IL_06B1: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_06B6: ldloca.s  V_7
				IL_06B8: ldarg.0
				IL_06B9: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_06BE: leave     IL_0A6E

				/* Resume Instruction */
				IL_06C3: ldarg.0
				IL_06C4: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_06C9: stloc.s   V_7
				IL_06CB: ldarg.0
				IL_06CC: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_06D1: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_06D7: ldarg.0
				IL_06D8: ldc.i4.m1
				IL_06D9: dup
				IL_06DA: stloc.0
				IL_06DB: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_06E0: ldloca.s  V_7
				IL_06E2: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06E7: ldloc.1
				IL_06E8: ldloc.1
				IL_06E9: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_06EE: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_06F3: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_06F8: ldloc.1
				IL_06F9: ldloc.1
				IL_06FA: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_06FF: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_0704: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0709: ldloc.1
				IL_070A: ldstr     "\r\n            </div>\r\n"
				IL_070F: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0714: ldloc.1
				IL_0715: ldstr     "        <!-- form-->\r\n        "
				IL_071A: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_071F: ldloc.1
				IL_0720: ldloc.1
				IL_0721: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_0726: ldstr     "form"
				IL_072B: ldc.i4.0
				IL_072C: ldstr     "50a3f9c75b93355adf19d44d3e2adb6e43a8996cfc62047338baed40053a600c21276"
				IL_0731: ldloc.1
				IL_0732: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login::'<ExecuteAsync>b__29_3'()
				IL_0738: newobj    instance void class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>::.ctor(object, native int)
				IL_073D: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin(string, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagMode, string, class [System.Runtime]System.Func`1<class [System.Runtime]System.Threading.Tasks.Task>)
				IL_0742: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0747: ldloc.1
				IL_0748: ldloc.1
				IL_0749: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>()
				IL_074E: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0753: ldloc.1
				IL_0754: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0759: ldloc.1
				IL_075A: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
				IL_075F: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0764: ldloc.1
				IL_0765: ldloc.1
				IL_0766: call      instance !!0 [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>()
				IL_076B: stfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0770: ldloc.1
				IL_0771: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0776: ldloc.1
				IL_0777: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
				IL_077C: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.ITagHelper)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0781: ldloc.1
				IL_0782: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
				IL_0787: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_10
				IL_078C: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_0791: castclass [System.Runtime]System.String
				IL_0796: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper::set_Route(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_079B: ldloc.1
				IL_079C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_07A1: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_10
				IL_07A6: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07AB: ldloc.1
				IL_07AC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_07B1: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_11
				IL_07B6: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07BB: ldloc.1
				IL_07BC: ldfld     class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Views_Account_Login::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
				IL_07C1: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_12
				IL_07C6: callvirt  instance object [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value()
				IL_07CB: castclass [System.Runtime]System.String
				IL_07D0: callvirt  instance void [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper::set_Method(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07D5: ldloc.1
				IL_07D6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_07DB: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_12
				IL_07E0: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07E5: ldloc.1
				IL_07E6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_07EB: ldsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_13
				IL_07F0: callvirt  instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute(class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_07F5: ldloc.1
				IL_07F6: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
				IL_07FB: ldloc.1
				IL_07FC: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0801: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync(class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext)
				IL_0806: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_080B: stloc.s   V_8
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_080D: ldloca.s  V_8
				IL_080F: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0814: brtrue.s  IL_0857

				IL_0816: ldarg.0
				IL_0817: ldc.i4.6
				IL_0818: dup
				IL_0819: stloc.0
				IL_081A: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_081F: ldarg.0
				IL_0820: ldloc.s   V_8
				IL_0822: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0827: ldarg.0
				IL_0828: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_082D: ldloca.s  V_8
				IL_082F: ldarg.0
				IL_0830: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_0835: leave     IL_0A6E

				/* Resume Instruction */
				IL_083A: ldarg.0
				IL_083B: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0840: stloc.s   V_8
				IL_0842: ldarg.0
				IL_0843: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_0848: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_084E: ldarg.0
				IL_084F: ldc.i4.m1
				IL_0850: dup
				IL_0851: stloc.0
				IL_0852: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_0857: ldloca.s  V_8
				IL_0859: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_085E: ldloc.1
				IL_085F: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0864: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_0869: callvirt  instance bool [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified()
				IL_086E: brtrue.s  IL_08D3

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0870: ldloc.1
				IL_0871: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_0876: callvirt  instance class [System.Runtime]System.Threading.Tasks.Task [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync()
				IL_087B: callvirt  instance valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter [System.Runtime]System.Threading.Tasks.Task::GetAwaiter()
				IL_0880: stloc.s   V_9
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0882: ldloca.s  V_9
				IL_0884: call      instance bool [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
				IL_0889: brtrue.s  IL_08CC

				IL_088B: ldarg.0
				IL_088C: ldc.i4.7
				IL_088D: dup
				IL_088E: stloc.0
				IL_088F: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				/* Yield Instruction */
				IL_0894: ldarg.0
				IL_0895: ldloc.s   V_9
				IL_0897: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_089C: ldarg.0
				IL_089D: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_08A2: ldloca.s  V_9
				IL_08A4: ldarg.0
				IL_08A5: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&, !!1&)
				IL_08AA: leave     IL_0A6E

				/* Resume Instruction */
				IL_08AF: ldarg.0
				IL_08B0: ldfld     valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_08B5: stloc.s   V_9
				IL_08B7: ldarg.0
				IL_08B8: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>u__1'
				IL_08BD: initobj   [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter
				IL_08C3: ldarg.0
				IL_08C4: ldc.i4.m1
				IL_08C5: dup
				IL_08C6: stloc.0
				IL_08C7: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'

				IL_08CC: ldloca.s  V_9
				IL_08CE: call      instance void [System.Runtime]System.Runtime.CompilerServices.TaskAwaiter::GetResult()

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08D3: ldloc.1
				IL_08D4: ldloc.1
				IL_08D5: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				IL_08DA: callvirt  instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output()
				IL_08DF: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08E4: ldloc.1
				IL_08E5: ldloc.1
				IL_08E6: call      instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
				IL_08EB: callvirt  instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End()
				IL_08F0: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperExecutionContext
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_08F5: ldloc.1
				IL_08F6: ldstr     "\r\n        <!-- Timeout message -->\r\n        <div id=\"timeout\" style=\"display: none;\" class=\"mx-auto\">\r\n            <p class=\"alert alert-dark text-center p-3 m-3\">"
				IL_08FB: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (157,62)-(157,117) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0900: ldloc.1
				IL_0901: ldloc.1
				IL_0902: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0907: ldstr     "You took too long to login, please try again now."
				IL_090C: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0911: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0916: ldloc.1
				IL_0917: ldstr     "</p>\r\n            <button class=\"btn btn-hopex btn-success mx-50 my-20\""
				IL_091C: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0921: ldloc.1
				IL_0922: ldstr     "onclick"
				IL_0927: ldstr     " onclick=\""
				IL_092C: ldc.i4    7039
				IL_0931: ldstr     "\""
				IL_0936: ldc.i4    7085
				IL_093B: ldc.i4.3
				IL_093C: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute(string, string, int32, string, int32, int32)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0941: ldloc.1
				IL_0942: ldstr     ""
				IL_0947: ldc.i4    7049
				IL_094C: ldstr     "GoToRedirectUri('"
				IL_0951: ldc.i4    7049
				IL_0956: ldc.i4.s  17
				IL_0958: ldc.i4.1
				IL_0959: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
				/* (158,93)-(158,110) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_095E: ldloc.1
				IL_095F: ldstr     ""
				IL_0964: ldc.i4    7066
				IL_0969: ldloc.1
				IL_096A: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_096F: callvirt  instance string Mega.Has.Modules.UAS.ViewModels.LoginInputModel::get_ReturnUrl()
				IL_0974: ldc.i4    7066
				IL_0979: ldc.i4.s  16
				IL_097B: ldc.i4.0
				IL_097C: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0981: ldloc.1
				IL_0982: ldstr     ""
				IL_0987: ldc.i4    7082
				IL_098C: ldstr     "');"
				IL_0991: ldc.i4    7082
				IL_0996: ldc.i4.3
				IL_0997: ldc.i4.1
				IL_0998: call      instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue(string, int32, object, int32, int32, bool)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_099D: ldloc.1
				IL_099E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute()
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09A3: ldloc.1
				IL_09A4: ldstr     ">"
				IL_09A9: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (158,115)-(158,123) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09AE: ldloc.1
				IL_09AF: ldloc.1
				IL_09B0: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_09B5: ldstr     "OK"
				IL_09BA: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_09BF: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09C4: ldloc.1
				IL_09C5: ldstr     "</button>\r\n        </div>\r\n\r\n"
				IL_09CA: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09CF: ldloc.1
				IL_09D0: ldstr     "        <div class=\"mt-5 mb-3 footer w-100 show-v6 text-dark\" style=\"display:none;\">\r\n            <label>\r\n                "
				IL_09D5: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (164,18)-(164,34) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09DA: ldloc.1
				IL_09DB: ldloc.1
				IL_09DC: call      instance !0 class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_Model()
				IL_09E1: dup
				IL_09E2: brtrue.s  IL_09E8

				IL_09E4: pop
				IL_09E5: ldnull
				IL_09E6: br.s      IL_09ED

				IL_09E8: call      instance string Mega.Has.Modules.UAS.ViewModels.GlobalViewModel::get_MegaInfo()

				IL_09ED: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09F2: ldloc.1
				IL_09F3: ldstr     " <br>\r\n                <a class=\"text-white privacy-link\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#privacyModal\">"
				IL_09F8: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (165,116)-(165,147) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_09FD: ldloc.1
				IL_09FE: ldloc.1
				IL_09FF: call      instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::get_T()
				IL_0A04: ldstr     "Privacy and Cookie Policy"
				IL_0A09: callvirt  instance class [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.LocalizedHtmlString [Microsoft.AspNetCore.Mvc.Localization]Microsoft.AspNetCore.Mvc.Localization.IHtmlLocalizer::get_Item(string)
				IL_0A0E: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write(object)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A13: ldloc.1
				IL_0A14: ldstr     "</a>\r\n            </label>\r\n        </div>\r\n\r\n    </div>\r\n"
				IL_0A19: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)

				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A1E: ldloc.1
				IL_0A1F: ldstr     "\r\n"
				IL_0A24: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral(string)
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A29: ldloc.1
				IL_0A2A: ldstr     "Scripts"
				IL_0A2F: ldloc.1
				IL_0A30: ldftn     instance class [System.Runtime]System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Views_Account_Login::'<ExecuteAsync>b__29_4'()
				IL_0A36: newobj    instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate::.ctor(object, native int)
				IL_0A3B: callvirt  instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::DefineSection(string, class [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate)
				IL_0A40: leave.s   IL_0A5B
			} // end .try
			catch [System.Runtime]System.Exception
			{
				/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
				IL_0A42: stloc.s   V_10
				IL_0A44: ldarg.0
				IL_0A45: ldc.i4.s  -2
				IL_0A47: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
				IL_0A4C: ldarg.0
				IL_0A4D: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
				IL_0A52: ldloc.s   V_10
				IL_0A54: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(class [System.Runtime]System.Exception)
				IL_0A59: leave.s   IL_0A6E
			} // end handler

			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0A5B: ldarg.0
			IL_0A5C: ldc.i4.s  -2
			IL_0A5E: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
			/* (hidden)-(hidden) C:\build-agents\agent1\_work\1\s\Modules\UAS\src\HAS.Modules.UAS\Views\Account\Login.cshtml */
			IL_0A63: ldarg.0
			IL_0A64: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
			IL_0A69: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult()

			IL_0A6E: ret
		} // end of method '<ExecuteAsync>d__29'::MoveNext

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
			IL_0001: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
			IL_0006: ldarg.1
			IL_0007: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(class [System.Runtime]System.Runtime.CompilerServices.IAsyncStateMachine)
			IL_000C: ret
		} // end of method '<ExecuteAsync>d__29'::SetStateMachine

	} // end of class <ExecuteAsync>d__29


	// Fields
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13
	.field private static initonly class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner
	.field private string __tagHelperStringValueBuffer
	.field private class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
	.field private class [Microsoft.AspNetCore.Mvc.TagHelpers]Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
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
	.field private class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> '<Html>k__BackingField'
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)

	// Methods
	.method private hidebysig specialname 
		instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager get___tagHelperScopeManager () cil managed 
	{
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::__backed__tagHelperScopeManager
		IL_0006: brtrue.s  IL_002B

		IL_0008: ldarg.0
		IL_0009: ldarg.0
		IL_000A: ldftn     instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::StartTagHelperWritingScope(class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder)
		IL_0010: newobj    instance void class [System.Runtime]System.Action`1<class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder>::.ctor(object, native int)
		IL_0015: ldarg.0
		IL_0016: ldftn     instance class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndTagHelperWritingScope()
		IL_001C: newobj    instance void class [System.Runtime]System.Func`1<class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent>::.ctor(object, native int)
		IL_0021: newobj    instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::.ctor(class [System.Runtime]System.Action`1<class [System.Text.Encodings.Web]System.Text.Encodings.Web.HtmlEncoder>, class [System.Runtime]System.Func`1<class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent>)
		IL_0026: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::__backed__tagHelperScopeManager

		IL_002B: ldarg.0
		IL_002C: ldfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::__backed__tagHelperScopeManager
		IL_0031: ret
	} // end of method Views_Account_Login::get___tagHelperScopeManager

	.method public hidebysig virtual 
		instance class [System.Runtime]System.Threading.Tasks.Task ExecuteAsync () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 43 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
			69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
			69 6e 2b 3c 45 78 65 63 75 74 65 41 73 79 6e 63
			3e 64 5f 5f 32 39 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<ExecuteAsync>d__29'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Views_Account_Login::ExecuteAsync

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider get_ModelExpressionProvider () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::'<ModelExpressionProvider>k__BackingField'
		IL_0006: ret
	} // end of method Views_Account_Login::get_ModelExpressionProvider

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
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::'<ModelExpressionProvider>k__BackingField'
		IL_0007: ret
	} // end of method Views_Account_Login::set_ModelExpressionProvider

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper get_Url () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Url>k__BackingField'
		IL_0006: ret
	} // end of method Views_Account_Login::get_Url

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
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Url>k__BackingField'
		IL_0007: ret
	} // end of method Views_Account_Login::set_Url

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper get_Component () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Component>k__BackingField'
		IL_0006: ret
	} // end of method Views_Account_Login::get_Component

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
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Component>k__BackingField'
		IL_0007: ret
	} // end of method Views_Account_Login::set_Component

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper get_Json () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Json>k__BackingField'
		IL_0006: ret
	} // end of method Views_Account_Login::get_Json

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
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Views_Account_Login::'<Json>k__BackingField'
		IL_0007: ret
	} // end of method Views_Account_Login::set_Json

	.method public hidebysig specialname 
		instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> get_Html () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> AspNetCoreGeneratedDocument.Views_Account_Login::'<Html>k__BackingField'
		IL_0006: ret
	} // end of method Views_Account_Login::get_Html

	.method private hidebysig specialname 
		instance void set_Html (
			class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> 'value'
		) cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: ldarg.1
		IL_0002: stfld     class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> AspNetCoreGeneratedDocument.Views_Account_Login::'<Html>k__BackingField'
		IL_0007: ret
	} // end of method Views_Account_Login::set_Html

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: newobj    instance void [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::.ctor()
		IL_0006: stfld     class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperRunner
		IL_000B: ldarg.0
		IL_000C: call      instance void class [HAS.Server.SiteModule]HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>::.ctor()
		IL_0011: ret
	} // end of method Views_Account_Login::.ctor

	.method private hidebysig specialname rtspecialname static 
		void .cctor () cil managed 
	{
		.maxstack 3

		IL_0000: ldstr     "src"
		IL_0005: ldstr     "/_customs/has.uas/images/logo-H.png"
		IL_000A: ldc.i4.0
		IL_000B: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0010: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_0
		IL_0015: ldstr     "class"
		IL_001A: ldstr     "titleimg"
		IL_001F: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_0024: ldc.i4.0
		IL_0025: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_002A: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_1
		IL_002F: ldstr     "alt"
		IL_0034: ldstr     "HOPEX"
		IL_0039: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_003E: ldc.i4.0
		IL_003F: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0044: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_2
		IL_0049: ldstr     "class"
		IL_004E: ldstr     "col"
		IL_0053: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_0058: ldc.i4.0
		IL_0059: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_005E: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_3
		IL_0063: ldstr     "type"
		IL_0068: ldstr     "hidden"
		IL_006D: ldc.i4.0
		IL_006E: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0073: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_4
		IL_0078: ldstr     "value"
		IL_007D: ldstr     ""
		IL_0082: ldc.i4.0
		IL_0083: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0088: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_5
		IL_008D: ldstr     "class"
		IL_0092: ldstr     "form-select bg-light"
		IL_0097: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_009C: ldc.i4.0
		IL_009D: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_00A2: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_6
		IL_00A7: ldstr     "type"
		IL_00AC: ldstr     "password"
		IL_00B1: ldc.i4.0
		IL_00B2: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_00B7: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_7
		IL_00BC: ldstr     "class"
		IL_00C1: ldstr     "form-control bg-light"
		IL_00C6: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_00CB: ldc.i4.0
		IL_00CC: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_00D1: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_8
		IL_00D6: ldstr     "autocomplete"
		IL_00DB: ldstr     "off"
		IL_00E0: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_00E5: ldc.i4.0
		IL_00E6: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_00EB: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_9
		IL_00F0: ldstr     "asp-route"
		IL_00F5: ldstr     "Login"
		IL_00FA: ldc.i4.0
		IL_00FB: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0100: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_10
		IL_0105: ldstr     "class"
		IL_010A: ldstr     "form-signin mx-auto"
		IL_010F: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_0114: ldc.i4.0
		IL_0115: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_011A: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_11
		IL_011F: ldstr     "method"
		IL_0124: ldstr     "post"
		IL_0129: ldc.i4.0
		IL_012A: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_012F: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_12
		IL_0134: ldstr     "id"
		IL_0139: ldstr     "loginForm"
		IL_013E: newobj    instance void [Microsoft.AspNetCore.Html.Abstractions]Microsoft.AspNetCore.Html.HtmlString::.ctor(string)
		IL_0143: ldc.i4.0
		IL_0144: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_0149: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_13
		IL_014E: ldstr     "src"
		IL_0153: ldstr     "/uas/js/login.js"
		IL_0158: ldc.i4.0
		IL_0159: newobj    instance void [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor(string, object, valuetype [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle)
		IL_015E: stsfld    class [Microsoft.AspNetCore.Razor]Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Views_Account_Login::__tagHelperAttribute_14
		IL_0163: ret
	} // end of method Views_Account_Login::.cctor

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_3' () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 48 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
			69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
			69 6e 2b 3c 3c 45 78 65 63 75 74 65 41 73 79 6e
			63 3e 62 5f 5f 32 39 5f 33 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_3>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Views_Account_Login::'<ExecuteAsync>b__29_3'

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_7' () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 48 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
			69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
			69 6e 2b 3c 3c 45 78 65 63 75 74 65 41 73 79 6e
			63 3e 62 5f 5f 32 39 5f 37 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_7>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Views_Account_Login::'<ExecuteAsync>b__29_7'

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_11' () cil managed 
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 49 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
			69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
			69 6e 2b 3c 3c 45 78 65 63 75 74 65 41 73 79 6e
			63 3e 62 5f 5f 32 39 5f 31 31 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_11>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Views_Account_Login::'<ExecuteAsync>b__29_11'

	.method private hidebysig 
		instance class [System.Runtime]System.Threading.Tasks.Task '<ExecuteAsync>b__29_4' () cil managed 
	{
		.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
			01 00 01 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.AsyncStateMachineAttribute::.ctor(class [System.Runtime]System.Type) = (
			01 00 48 41 73 70 4e 65 74 43 6f 72 65 47 65 6e
			65 72 61 74 65 64 44 6f 63 75 6d 65 6e 74 2e 56
			69 65 77 73 5f 41 63 63 6f 75 6e 74 5f 4c 6f 67
			69 6e 2b 3c 3c 45 78 65 63 75 74 65 41 73 79 6e
			63 3e 62 5f 5f 32 39 5f 34 3e 64 00 00
		)
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		.maxstack 2
		.locals init (
			[0] valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'
		)

		IL_0000: ldloca.s  V_0
		IL_0002: call      valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create()
		IL_0007: stfld     valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
		IL_000C: ldloca.s  V_0
		IL_000E: ldarg.0
		IL_000F: stfld     class AspNetCoreGeneratedDocument.Views_Account_Login AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>4__this'
		IL_0014: ldloca.s  V_0
		IL_0016: ldc.i4.m1
		IL_0017: stfld     int32 AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>1__state'
		IL_001C: ldloca.s  V_0
		IL_001E: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
		IL_0023: ldloca.s  V_0
		IL_0025: call      instance void [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'>(!!0&)
		IL_002A: ldloca.s  V_0
		IL_002C: ldflda    valuetype [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Views_Account_Login/'<<ExecuteAsync>b__29_4>d'::'<>t__builder'
		IL_0031: call      instance class [System.Runtime]System.Threading.Tasks.Task [System.Runtime]System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task()
		IL_0036: ret
	} // end of method Views_Account_Login::'<ExecuteAsync>b__29_4'

	// Properties
	.property instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager()
	{
		.get instance class [Microsoft.AspNetCore.Razor.Runtime]Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Views_Account_Login::get___tagHelperScopeManager()
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Views_Account_Login::get_ModelExpressionProvider()
		.set instance void AspNetCoreGeneratedDocument.Views_Account_Login::set_ModelExpressionProvider(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper Url()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Views_Account_Login::get_Url()
		.set instance void AspNetCoreGeneratedDocument.Views_Account_Login::set_Url(class [Microsoft.AspNetCore.Mvc.Abstractions]Microsoft.AspNetCore.Mvc.IUrlHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper Component()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Views_Account_Login::get_Component()
		.set instance void AspNetCoreGeneratedDocument.Views_Account_Login::set_Component(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.IViewComponentHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Views_Account_Login::get_Json()
		.set instance void AspNetCoreGeneratedDocument.Views_Account_Login::set_Json(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper)
	}
	.property instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> Html()
	{
		.custom instance void [Microsoft.AspNetCore.Mvc.Razor]Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute::.ctor() = (
			01 00 00 00
		)
		.get instance class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel> AspNetCoreGeneratedDocument.Views_Account_Login::get_Html()
		.set instance void AspNetCoreGeneratedDocument.Views_Account_Login::set_Html(class [Microsoft.AspNetCore.Mvc.ViewFeatures]Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.ViewModels.LoginViewModel>)
	}

} // end of class AspNetCoreGeneratedDocument.Views_Account_Login
