// TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create
// Token: 0x02000032

.class private sealed auto ansi beforefieldinit Areas_Admin_Views_ApiKey_Create
    extends HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
{
    .custom instance void Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(String, String, String) = { SHA256, f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab9960, /Areas/Admin/Views/ApiKey/Create.cshtml }
    .custom instance void Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute::.ctor(String, String, String) = { SHA256, db49990b83873bd0a8dae29a49b6e41d4630ea6887575f6d3f94faa3480b8c7e, /Areas/Admin/Views/_ViewImports.cshtml }
    .custom instance void Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute::.ctor(String, String) = { Identifier, /Areas/Admin/Views/ApiKey/Create.cshtml }
    .custom instance void System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute::.ctor()
    // === STATIC CTOR ===
    // 0x060001D6 RVA:0x00009AF0
    .method private static hidebysig specialname rtspecialname 
        Void .cctor() cil managed
    {
        .maxstack 3

        IL_0000: ldstr      "type"
        IL_0005: ldstr      "hidden"
        IL_000A: ldc.i4.0   
        IL_000B: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0010: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
        IL_0015: ldstr      "class"
        IL_001A: ldstr      "text-danger"
        IL_001F: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0024: ldc.i4.0   
        IL_0025: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_002A: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
        IL_002F: ldstr      "class"
        IL_0034: ldstr      "form-control  col-md-7 col-xs-12"
        IL_0039: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_003E: ldc.i4.0   
        IL_003F: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0044: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_2
        IL_0049: ldstr      "id"
        IL_004E: ldstr      "tokenName_warning"
        IL_0053: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0058: ldc.i4.0   
        IL_0059: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_005E: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_3
        IL_0063: ldstr      "name"
        IL_0068: ldstr      "tokenName_warning"
        IL_006D: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0072: ldc.i4.0   
        IL_0073: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0078: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_4
        IL_007D: ldstr      "class"
        IL_0082: ldstr      "control-label col-md-3 col-sm-3 col-xs-12"
        IL_0087: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_008C: ldc.i4.0   
        IL_008D: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0092: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_5
        IL_0097: ldstr      "type"
        IL_009C: ldstr      "datetime"
        IL_00A1: ldc.i4.0   
        IL_00A2: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_00A7: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_6
        IL_00AC: ldstr      "autocomplete"
        IL_00B1: ldstr      "off"
        IL_00B6: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_00BB: ldc.i4.0   
        IL_00BC: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_00C1: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_7
        IL_00C6: ldstr      "type"
        IL_00CB: ldstr      "radio"
        IL_00D0: ldc.i4.0   
        IL_00D1: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_00D6: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
        IL_00DB: ldstr      "class"
        IL_00E0: ldstr      "form-check-input"
        IL_00E5: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_00EA: ldc.i4.0   
        IL_00EB: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_00F0: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_9
        IL_00F5: ldstr      "value"
        IL_00FA: ldstr      "Y"
        IL_00FF: ldc.i4.0   
        IL_0100: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0105: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_10
        IL_010A: ldstr      "id"
        IL_010F: ldstr      "isAdministratorYes"
        IL_0114: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0119: ldc.i4.0   
        IL_011A: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_011F: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_11
        IL_0124: ldstr      "data-bs-toggle"
        IL_0129: ldstr      "collapse"
        IL_012E: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0133: ldc.i4.0   
        IL_0134: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0139: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_12
        IL_013E: ldstr      "data-bs-target"
        IL_0143: ldstr      "#collapseRoles.show"
        IL_0148: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_014D: ldc.i4.0   
        IL_014E: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0153: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_13
        IL_0158: ldstr      "value"
        IL_015D: ldstr      "N"
        IL_0162: ldc.i4.0   
        IL_0163: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0168: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_14
        IL_016D: ldstr      "id"
        IL_0172: ldstr      "isAdministratorNo"
        IL_0177: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_017C: ldc.i4.0   
        IL_017D: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0182: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_15
        IL_0187: ldstr      "data-bs-target"
        IL_018C: ldstr      "#collapseRoles:not(.show)"
        IL_0191: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0196: ldc.i4.0   
        IL_0197: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_019C: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_16
        IL_01A1: ldstr      "type"
        IL_01A6: ldstr      "checkbox"
        IL_01AB: ldc.i4.0   
        IL_01AC: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_01B1: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_17
        IL_01B6: ldstr      "class"
        IL_01BB: ldstr      "default"
        IL_01C0: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_01C5: ldc.i4.0   
        IL_01C6: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_01CB: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_18
        IL_01D0: ldstr      "value"
        IL_01D5: ldstr      "true"
        IL_01DA: ldc.i4.0   
        IL_01DB: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_01E0: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_19
        IL_01E5: ldstr      "id"
        IL_01EA: ldstr      "canOpenSessionYes"
        IL_01EF: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_01F4: ldc.i4.0   
        IL_01F5: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_01FA: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_20
        IL_01FF: ldstr      "data-bs-target"
        IL_0204: ldstr      "#collapseSession.show"
        IL_0209: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_020E: ldc.i4.0   
        IL_020F: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0214: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_21
        IL_0219: ldstr      "id"
        IL_021E: ldstr      "canOpenSessionNo"
        IL_0223: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0228: ldc.i4.0   
        IL_0229: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_022E: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_22
        IL_0233: ldstr      "data-bs-target"
        IL_0238: ldstr      "#collapseSession:not(.show)"
        IL_023D: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_0242: ldc.i4.0   
        IL_0243: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0248: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_23
        IL_024D: ldstr      "autocomplete"
        IL_0252: ldstr      "on"
        IL_0257: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_025C: ldc.i4.0   
        IL_025D: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0262: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_24
        IL_0267: ldstr      "value"
        IL_026C: ldstr      ""
        IL_0271: ldc.i4.0   
        IL_0272: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0277: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_25
        IL_027C: ldstr      "class"
        IL_0281: ldstr      "select2_single form-select"
        IL_0286: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_028B: ldc.i4.0   
        IL_028C: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_0291: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_26
        IL_0296: ldstr      "class"
        IL_029B: ldstr      "form-horizontal form-label-left"
        IL_02A0: newobj     void Microsoft.AspNetCore.Html.HtmlString::.ctor
        IL_02A5: ldc.i4.0   
        IL_02A6: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_02AB: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_27
        IL_02B0: ldstr      "method"
        IL_02B5: ldstr      "post"
        IL_02BA: ldc.i4.0   
        IL_02BB: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_02C0: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_28
        IL_02C5: ldstr      "src"
        IL_02CA: ldstr      "/uas/js/apiKey.js"
        IL_02CF: ldc.i4.0   
        IL_02D0: newobj     void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::.ctor
        IL_02D5: stsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_29
        IL_02DA: ret        
    } // .cctor

    // === FIELDS ===
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_19
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_20
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_21
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_22
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_23
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_24
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_25
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_26
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_27
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_28
    .field private static initonly class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_29
    .field private class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext
    .field private class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner
    .field private String __tagHelperStringValueBuffer
    .field private class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
    .field private class HAS.Server.TagHelpers.NonceTagHelper __HAS_Server_TagHelpers_NonceTagHelper
    .field private class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
    .field private class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider _modelExpressionProvider
    .field private class Microsoft.AspNetCore.Mvc.IUrlHelper _url
    .field private class Microsoft.AspNetCore.Mvc.IViewComponentHelper _component
    .field private class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper _json
    .field private Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> _html
    // === PROPERTIES ===
    .property instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager()
    {
        .get instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
    }
    .property instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider()
    {
        .get instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
        .set instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::set_ModelExpressionProvider(class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider)
    }
    .property instance class Microsoft.AspNetCore.Mvc.IUrlHelper Url()
    {
        .get instance class Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Url()
        .set instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::set_Url(class Microsoft.AspNetCore.Mvc.IUrlHelper)
    }
    .property instance class Microsoft.AspNetCore.Mvc.IViewComponentHelper Component()
    {
        .get instance class Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Component()
        .set instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::set_Component(class Microsoft.AspNetCore.Mvc.IViewComponentHelper)
    }
    .property instance class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json()
    {
        .get instance class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Json()
        .set instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::set_Json(class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper)
    }
    .property instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> Html()
    {
        .get instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Html()
        .set instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::set_Html(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>)
    }
    // === METHODS ===
    // 0x060001C9 RVA:0x00009A0F
    .method private hidebysig specialname instance 
        class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager get___tagHelperScopeManager() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__backed__tagHelperScopeManager
        IL_0006: brtrue.s   IL_002B
        IL_0008: ldarg.0    
        IL_0009: ldarg.0    
        IL_000A: ldftn      void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::StartTagHelperWritingScope
        IL_0010: newobj     void System.Action`1<class System.Text.Encodings.Web.HtmlEncoder>::.ctor
        IL_0015: ldarg.0    
        IL_0016: ldftn      void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndTagHelperWritingScope
        IL_001C: newobj     void System.Func`1<class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContent>::.ctor
        IL_0021: newobj     void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::.ctor
        IL_0026: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__backed__tagHelperScopeManager
        IL_002B: ldarg.0    
        IL_002C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__backed__tagHelperScopeManager
        IL_0031: ret        
    } // get___tagHelperScopeManager

    // 0x060001CA RVA:0x00009A44
    .method public virtual hidebysig instance 
        class System.Threading.Tasks.Task ExecuteAsync() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<ExecuteAsync>d__46>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // ExecuteAsync

    // 0x060001CB RVA:0x00009A87
    .method public hidebysig specialname instance 
        class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider get_ModelExpressionProvider() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_modelExpressionProvider
        IL_0006: ret        
    } // get_ModelExpressionProvider

    // 0x060001CC RVA:0x00009A8F
    .method private hidebysig specialname instance 
        Void set_ModelExpressionProvider(class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider value) cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldarg.1    
        IL_0002: stfld      class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_modelExpressionProvider
        IL_0007: ret        
    } // set_ModelExpressionProvider

    // 0x060001CD RVA:0x00009A98
    .method public hidebysig specialname instance 
        class Microsoft.AspNetCore.Mvc.IUrlHelper get_Url() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      class Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_url
        IL_0006: ret        
    } // get_Url

    // 0x060001CE RVA:0x00009AA0
    .method private hidebysig specialname instance 
        Void set_Url(class Microsoft.AspNetCore.Mvc.IUrlHelper value) cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldarg.1    
        IL_0002: stfld      class Microsoft.AspNetCore.Mvc.IUrlHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_url
        IL_0007: ret        
    } // set_Url

    // 0x060001CF RVA:0x00009AA9
    .method public hidebysig specialname instance 
        class Microsoft.AspNetCore.Mvc.IViewComponentHelper get_Component() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      class Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_component
        IL_0006: ret        
    } // get_Component

    // 0x060001D0 RVA:0x00009AB1
    .method private hidebysig specialname instance 
        Void set_Component(class Microsoft.AspNetCore.Mvc.IViewComponentHelper value) cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldarg.1    
        IL_0002: stfld      class Microsoft.AspNetCore.Mvc.IViewComponentHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_component
        IL_0007: ret        
    } // set_Component

    // 0x060001D1 RVA:0x00009ABA
    .method public hidebysig specialname instance 
        class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper get_Json() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_json
        IL_0006: ret        
    } // get_Json

    // 0x060001D2 RVA:0x00009AC2
    .method private hidebysig specialname instance 
        Void set_Json(class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper value) cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldarg.1    
        IL_0002: stfld      class Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_json
        IL_0007: ret        
    } // set_Json

    // 0x060001D3 RVA:0x00009ACB
    .method public hidebysig specialname instance 
        Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> get_Html() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldfld      Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_html
        IL_0006: ret        
    } // get_Html

    // 0x060001D4 RVA:0x00009AD3
    .method private hidebysig specialname instance 
        Void set_Html(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> value) cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: ldarg.1    
        IL_0002: stfld      Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_html
        IL_0007: ret        
    } // set_Html

    // 0x060001D5 RVA:0x00009ADC
    .method public hidebysig specialname rtspecialname instance 
        Void .ctor() cil managed
    {
        .maxstack 8

        IL_0000: ldarg.0    
        IL_0001: newobj     void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::.ctor
        IL_0006: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
        IL_000B: ldarg.0    
        IL_000C: call       void HAS.Server.SiteModule.Razor.BaseRazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::.ctor
        IL_0011: ret        
    } // .ctor

    // 0x060001D7 RVA:0x00009DD8
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_0() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_0

    // 0x060001D8 RVA:0x00009E1C
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_46() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_46>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_46

    // 0x060001D9 RVA:0x00009E60
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_55() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_55>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_55

    // 0x060001DA RVA:0x00009EA4
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_1() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_1>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_1

    // 0x060001DB RVA:0x00009EE8
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_2() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_2

    // 0x060001DC RVA:0x00009F2C
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_56() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_56>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_56

    // 0x060001DD RVA:0x00009F70
    .method private hidebysig instance 
        class System.Threading.Tasks.Task _lm_ExecuteAsync_46_58() cil managed
    {
        .maxstack 2
        .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d)

        IL_0000: ldloca.s   V_0
        IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
        IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
        IL_000C: ldloca.s   V_0
        IL_000E: ldarg.0    
        IL_000F: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_this
        IL_0014: ldloca.s   V_0
        IL_0016: ldc.i4.m1  
        IL_0017: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_state
        IL_001C: ldloca.s   V_0
        IL_001E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
        IL_0023: ldloca.s   V_0
        IL_0025: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_58>d>(!!0&)
        IL_002A: ldloca.s   V_0
        IL_002C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
        IL_0031: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
        IL_0036: ret        
    } // _lm_ExecuteAsync_46_58

    // === NESTED ===
    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d
    // Token: 0x020000FA

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_0_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        .field private class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 _h1
        .field private valuetype System.Runtime.CompilerServices.TaskAwaiter _aw1
        .field private System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> _wr1
        .field private System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> _wr2
        // === METHODS ===
        // 0x06000918 RVA:0x00028044
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 10
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] class System.Linq.Expressions.ParameterExpression, [3] valuetype System.Runtime.CompilerServices.TaskAwaiter, [4] valuetype System.Runtime.CompilerServices.TaskAwaiter, [5] valuetype System.Runtime.CompilerServices.TaskAwaiter, [6] valuetype System.Runtime.CompilerServices.TaskAwaiter, [7] valuetype System.Runtime.CompilerServices.TaskAwaiter, [8] valuetype System.Runtime.CompilerServices.TaskAwaiter, [9] valuetype System.Runtime.CompilerServices.TaskAwaiter, [10] valuetype System.Runtime.CompilerServices.TaskAwaiter, [11] valuetype System.Runtime.CompilerServices.TaskAwaiter, [12] valuetype System.Runtime.CompilerServices.TaskAwaiter, [13] valuetype System.Runtime.CompilerServices.TaskAwaiter, [14] valuetype System.Runtime.CompilerServices.TaskAwaiter, [15] valuetype System.Runtime.CompilerServices.TaskAwaiter, [16] valuetype System.Runtime.CompilerServices.TaskAwaiter, [17] valuetype System.Runtime.CompilerServices.TaskAwaiter, [18] valuetype System.Runtime.CompilerServices.TaskAwaiter, [19] valuetype System.Runtime.CompilerServices.TaskAwaiter, [20] valuetype System.Runtime.CompilerServices.TaskAwaiter, [21] valuetype System.Runtime.CompilerServices.TaskAwaiter, [22] valuetype System.Runtime.CompilerServices.TaskAwaiter, [23] valuetype System.Runtime.CompilerServices.TaskAwaiter, [24] valuetype System.Runtime.CompilerServices.TaskAwaiter, [25] valuetype System.Runtime.CompilerServices.TaskAwaiter, [26] valuetype System.Runtime.CompilerServices.TaskAwaiter, [27] valuetype System.Runtime.CompilerServices.TaskAwaiter, [28] valuetype System.Runtime.CompilerServices.TaskAwaiter, [29] valuetype System.Runtime.CompilerServices.TaskAwaiter, [30] valuetype System.Runtime.CompilerServices.TaskAwaiter, [31] valuetype System.Runtime.CompilerServices.TaskAwaiter, [32] valuetype System.Runtime.CompilerServices.TaskAwaiter, [33] valuetype System.Runtime.CompilerServices.TaskAwaiter, [34] valuetype System.Runtime.CompilerServices.TaskAwaiter, [35] valuetype System.Runtime.CompilerServices.TaskAwaiter, [36] valuetype System.Runtime.CompilerServices.TaskAwaiter, [37] valuetype System.Runtime.CompilerServices.TaskAwaiter, [38] valuetype System.Runtime.CompilerServices.TaskAwaiter, [39] System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>, [40] class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, [41] Int32, [42] valuetype System.Runtime.CompilerServices.TaskAwaiter, [43] valuetype System.Runtime.CompilerServices.TaskAwaiter, [44] valuetype System.Runtime.CompilerServices.TaskAwaiter, [45] valuetype System.Runtime.CompilerServices.TaskAwaiter, [46] valuetype System.Runtime.CompilerServices.TaskAwaiter, [47] valuetype System.Runtime.CompilerServices.TaskAwaiter, [48] valuetype System.Runtime.CompilerServices.TaskAwaiter, [49] valuetype System.Runtime.CompilerServices.TaskAwaiter, [50] valuetype System.Runtime.CompilerServices.TaskAwaiter, [51] valuetype System.Runtime.CompilerServices.TaskAwaiter, [52] valuetype System.Runtime.CompilerServices.TaskAwaiter, [53] valuetype System.Runtime.CompilerServices.TaskAwaiter, [54] valuetype System.Runtime.CompilerServices.TaskAwaiter, [55] valuetype System.Runtime.CompilerServices.TaskAwaiter, [56] valuetype System.Runtime.CompilerServices.TaskAwaiter, [57] valuetype System.Runtime.CompilerServices.TaskAwaiter, [58] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.0    
            IL_000F: switch     (IL_023C, IL_02B0, IL_0439, IL_04AE, IL_0637, IL_06AC, IL_0835, IL_08AA, IL_0A33, IL_0AA9, IL_0C33, IL_0CA9, IL_0E33, IL_0EA9, IL_1033, IL_10A9, IL_11D5, IL_124B, IL_13BB, IL_1431, IL_15C1, IL_1637, IL_17A7, IL_181D, IL_19FB, IL_1A71, IL_1BE1, IL_1C57, IL_1DFB, IL_1E71, IL_1FE1, IL_2057, IL_225F, IL_22D5, IL_24DD, IL_2553, IL_269A, IL_269A, IL_269A, IL_269A, IL_269A, IL_269A, IL_316E, IL_31E4, IL_33D8, IL_344E, IL_36A8, IL_371E, IL_388E, IL_3904, IL_3A93, IL_3B09)
            IL_00E4: ldarg.0    
            IL_00E5: newobj     instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::.ctor()
            IL_00EA: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_00EF: ldarg.0    
            IL_00F0: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_00F5: ldloc.1    
            IL_00F6: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::_this
            IL_00FB: ldloc.1    
            IL_00FC: ldstr      "\r\n                        "
            IL_0101: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0106: ldloc.1    
            IL_0107: ldloc.1    
            IL_0108: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_010D: ldstr      "input"
            IL_0112: ldc.i4.1   
            IL_0113: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996017881"
            IL_0118: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_3
            IL_011D: dup        
            IL_011E: brtrue.s   IL_0137
            IL_0120: pop        
            IL_0121: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_0126: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_3()
            IL_012C: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0131: dup        
            IL_0132: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_3
            IL_0137: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_013C: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0141: ldloc.1    
            IL_0142: ldloc.1    
            IL_0143: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0148: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_014D: ldloc.1    
            IL_014E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0153: ldloc.1    
            IL_0154: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0159: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_015E: ldloc.1    
            IL_015F: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0164: ldloc.1    
            IL_0165: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_016A: ldloc.1    
            IL_016B: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0170: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_0175: call       void System.Type::GetTypeFromHandle
            IL_017A: ldstr      "__model"
            IL_017F: call       void System.Linq.Expressions.Expression::Parameter
            IL_0184: stloc.2    
            IL_0185: ldloc.2    
            IL_0186: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_AssignableElementId()
            IL_018B: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0190: castclass  System.Reflection.MethodInfo
            IL_0195: call       void System.Linq.Expressions.Expression::Property
            IL_019A: ldc.i4.1   
            IL_019B: newarr     System.Linq.Expressions.ParameterExpression
            IL_01A0: dup        
            IL_01A1: ldc.i4.0   
            IL_01A2: ldloc.2    
            IL_01A3: stelem.ref 
            IL_01A4: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_01A9: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_01AE: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_01B3: ldloc.1    
            IL_01B4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01B9: ldstr      "asp-for"
            IL_01BE: ldloc.1    
            IL_01BF: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_01C4: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_01C9: ldc.i4.0   
            IL_01CA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_01CF: ldloc.1    
            IL_01D0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_01D5: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_01DA: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_01DF: castclass  System.String
            IL_01E4: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_01E9: ldloc.1    
            IL_01EA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01EF: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_01F4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_01F9: ldloc.1    
            IL_01FA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_01FF: ldloc.1    
            IL_0200: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0205: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_020A: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_020F: stloc.3    
            IL_0210: ldloca.s   V_3
            IL_0212: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0217: brtrue.s   IL_0258
            IL_0219: ldarg.0    
            IL_021A: ldc.i4.0   
            IL_021B: dup        
            IL_021C: stloc.0    
            IL_021D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0222: ldarg.0    
            IL_0223: ldloc.3    
            IL_0224: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0229: ldarg.0    
            IL_022A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_022F: ldloca.s   V_3
            IL_0231: ldarg.0    
            IL_0232: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0237: leave      IL_3BC2
            IL_023C: ldarg.0    
            IL_023D: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0242: stloc.3    
            IL_0243: ldarg.0    
            IL_0244: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0249: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_024F: ldarg.0    
            IL_0250: ldc.i4.m1  
            IL_0251: dup        
            IL_0252: stloc.0    
            IL_0253: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0258: ldloca.s   V_3
            IL_025A: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_025F: ldloc.1    
            IL_0260: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0265: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_026A: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_026F: brtrue.s   IL_02D4
            IL_0271: ldloc.1    
            IL_0272: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0277: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_027C: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0281: stloc.s    V_4
            IL_0283: ldloca.s   V_4
            IL_0285: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_028A: brtrue.s   IL_02CD
            IL_028C: ldarg.0    
            IL_028D: ldc.i4.1   
            IL_028E: dup        
            IL_028F: stloc.0    
            IL_0290: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0295: ldarg.0    
            IL_0296: ldloc.s    V_4
            IL_0298: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_029D: ldarg.0    
            IL_029E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_02A3: ldloca.s   V_4
            IL_02A5: ldarg.0    
            IL_02A6: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_02AB: leave      IL_3BC2
            IL_02B0: ldarg.0    
            IL_02B1: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_02B6: stloc.s    V_4
            IL_02B8: ldarg.0    
            IL_02B9: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_02BE: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_02C4: ldarg.0    
            IL_02C5: ldc.i4.m1  
            IL_02C6: dup        
            IL_02C7: stloc.0    
            IL_02C8: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_02CD: ldloca.s   V_4
            IL_02CF: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_02D4: ldloc.1    
            IL_02D5: ldloc.1    
            IL_02D6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_02DB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_02E0: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_02E5: ldloc.1    
            IL_02E6: ldloc.1    
            IL_02E7: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_02EC: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_02F1: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_02F6: ldloc.1    
            IL_02F7: ldstr      "\r\n                        "
            IL_02FC: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0301: ldloc.1    
            IL_0302: ldloc.1    
            IL_0303: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0308: ldstr      "input"
            IL_030D: ldc.i4.1   
            IL_030E: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996019668"
            IL_0313: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_5
            IL_0318: dup        
            IL_0319: brtrue.s   IL_0332
            IL_031B: pop        
            IL_031C: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_0321: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_5()
            IL_0327: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_032C: dup        
            IL_032D: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_5
            IL_0332: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0337: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_033C: ldloc.1    
            IL_033D: ldloc.1    
            IL_033E: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0343: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0348: ldloc.1    
            IL_0349: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_034E: ldloc.1    
            IL_034F: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0354: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0359: ldloc.1    
            IL_035A: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_035F: ldloc.1    
            IL_0360: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0365: ldloc.1    
            IL_0366: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_036B: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_0370: call       void System.Type::GetTypeFromHandle
            IL_0375: ldstr      "__model"
            IL_037A: call       void System.Linq.Expressions.Expression::Parameter
            IL_037F: stloc.2    
            IL_0380: ldloc.2    
            IL_0381: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Login()
            IL_0386: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_038B: castclass  System.Reflection.MethodInfo
            IL_0390: call       void System.Linq.Expressions.Expression::Property
            IL_0395: ldc.i4.1   
            IL_0396: newarr     System.Linq.Expressions.ParameterExpression
            IL_039B: dup        
            IL_039C: ldc.i4.0   
            IL_039D: ldloc.2    
            IL_039E: stelem.ref 
            IL_039F: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_03A4: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_03A9: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_03AE: ldloc.1    
            IL_03AF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_03B4: ldstr      "asp-for"
            IL_03B9: ldloc.1    
            IL_03BA: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_03BF: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_03C4: ldc.i4.0   
            IL_03C5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_03CA: ldloc.1    
            IL_03CB: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_03D0: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_03D5: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_03DA: castclass  System.String
            IL_03DF: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_03E4: ldloc.1    
            IL_03E5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_03EA: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_03EF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_03F4: ldloc.1    
            IL_03F5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_03FA: ldloc.1    
            IL_03FB: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0400: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0405: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_040A: stloc.s    V_5
            IL_040C: ldloca.s   V_5
            IL_040E: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0413: brtrue.s   IL_0456
            IL_0415: ldarg.0    
            IL_0416: ldc.i4.2   
            IL_0417: dup        
            IL_0418: stloc.0    
            IL_0419: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_041E: ldarg.0    
            IL_041F: ldloc.s    V_5
            IL_0421: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0426: ldarg.0    
            IL_0427: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_042C: ldloca.s   V_5
            IL_042E: ldarg.0    
            IL_042F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0434: leave      IL_3BC2
            IL_0439: ldarg.0    
            IL_043A: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_043F: stloc.s    V_5
            IL_0441: ldarg.0    
            IL_0442: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0447: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_044D: ldarg.0    
            IL_044E: ldc.i4.m1  
            IL_044F: dup        
            IL_0450: stloc.0    
            IL_0451: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0456: ldloca.s   V_5
            IL_0458: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_045D: ldloc.1    
            IL_045E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0463: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0468: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_046D: brtrue.s   IL_04D2
            IL_046F: ldloc.1    
            IL_0470: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0475: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_047A: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_047F: stloc.s    V_6
            IL_0481: ldloca.s   V_6
            IL_0483: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0488: brtrue.s   IL_04CB
            IL_048A: ldarg.0    
            IL_048B: ldc.i4.3   
            IL_048C: dup        
            IL_048D: stloc.0    
            IL_048E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0493: ldarg.0    
            IL_0494: ldloc.s    V_6
            IL_0496: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_049B: ldarg.0    
            IL_049C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_04A1: ldloca.s   V_6
            IL_04A3: ldarg.0    
            IL_04A4: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_04A9: leave      IL_3BC2
            IL_04AE: ldarg.0    
            IL_04AF: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_04B4: stloc.s    V_6
            IL_04B6: ldarg.0    
            IL_04B7: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_04BC: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_04C2: ldarg.0    
            IL_04C3: ldc.i4.m1  
            IL_04C4: dup        
            IL_04C5: stloc.0    
            IL_04C6: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_04CB: ldloca.s   V_6
            IL_04CD: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_04D2: ldloc.1    
            IL_04D3: ldloc.1    
            IL_04D4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_04D9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_04DE: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_04E3: ldloc.1    
            IL_04E4: ldloc.1    
            IL_04E5: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_04EA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_04EF: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_04F4: ldloc.1    
            IL_04F5: ldstr      "\r\n                        "
            IL_04FA: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_04FF: ldloc.1    
            IL_0500: ldloc.1    
            IL_0501: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0506: ldstr      "input"
            IL_050B: ldc.i4.1   
            IL_050C: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996021441"
            IL_0511: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_7
            IL_0516: dup        
            IL_0517: brtrue.s   IL_0530
            IL_0519: pop        
            IL_051A: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_051F: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_7()
            IL_0525: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_052A: dup        
            IL_052B: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_7
            IL_0530: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0535: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_053A: ldloc.1    
            IL_053B: ldloc.1    
            IL_053C: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0541: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0546: ldloc.1    
            IL_0547: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_054C: ldloc.1    
            IL_054D: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0552: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0557: ldloc.1    
            IL_0558: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_055D: ldloc.1    
            IL_055E: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0563: ldloc.1    
            IL_0564: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0569: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_056E: call       void System.Type::GetTypeFromHandle
            IL_0573: ldstr      "__model"
            IL_0578: call       void System.Linq.Expressions.Expression::Parameter
            IL_057D: stloc.2    
            IL_057E: ldloc.2    
            IL_057F: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_UserId()
            IL_0584: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0589: castclass  System.Reflection.MethodInfo
            IL_058E: call       void System.Linq.Expressions.Expression::Property
            IL_0593: ldc.i4.1   
            IL_0594: newarr     System.Linq.Expressions.ParameterExpression
            IL_0599: dup        
            IL_059A: ldc.i4.0   
            IL_059B: ldloc.2    
            IL_059C: stelem.ref 
            IL_059D: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_05A2: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_05A7: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_05AC: ldloc.1    
            IL_05AD: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_05B2: ldstr      "asp-for"
            IL_05B7: ldloc.1    
            IL_05B8: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_05BD: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_05C2: ldc.i4.0   
            IL_05C3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_05C8: ldloc.1    
            IL_05C9: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_05CE: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_05D3: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_05D8: castclass  System.String
            IL_05DD: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_05E2: ldloc.1    
            IL_05E3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_05E8: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_05ED: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_05F2: ldloc.1    
            IL_05F3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_05F8: ldloc.1    
            IL_05F9: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_05FE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0603: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0608: stloc.s    V_7
            IL_060A: ldloca.s   V_7
            IL_060C: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0611: brtrue.s   IL_0654
            IL_0613: ldarg.0    
            IL_0614: ldc.i4.4   
            IL_0615: dup        
            IL_0616: stloc.0    
            IL_0617: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_061C: ldarg.0    
            IL_061D: ldloc.s    V_7
            IL_061F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0624: ldarg.0    
            IL_0625: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_062A: ldloca.s   V_7
            IL_062C: ldarg.0    
            IL_062D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0632: leave      IL_3BC2
            IL_0637: ldarg.0    
            IL_0638: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_063D: stloc.s    V_7
            IL_063F: ldarg.0    
            IL_0640: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0645: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_064B: ldarg.0    
            IL_064C: ldc.i4.m1  
            IL_064D: dup        
            IL_064E: stloc.0    
            IL_064F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0654: ldloca.s   V_7
            IL_0656: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_065B: ldloc.1    
            IL_065C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0661: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0666: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_066B: brtrue.s   IL_06D0
            IL_066D: ldloc.1    
            IL_066E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0673: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0678: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_067D: stloc.s    V_8
            IL_067F: ldloca.s   V_8
            IL_0681: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0686: brtrue.s   IL_06C9
            IL_0688: ldarg.0    
            IL_0689: ldc.i4.5   
            IL_068A: dup        
            IL_068B: stloc.0    
            IL_068C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0691: ldarg.0    
            IL_0692: ldloc.s    V_8
            IL_0694: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0699: ldarg.0    
            IL_069A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_069F: ldloca.s   V_8
            IL_06A1: ldarg.0    
            IL_06A2: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_06A7: leave      IL_3BC2
            IL_06AC: ldarg.0    
            IL_06AD: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_06B2: stloc.s    V_8
            IL_06B4: ldarg.0    
            IL_06B5: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_06BA: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_06C0: ldarg.0    
            IL_06C1: ldc.i4.m1  
            IL_06C2: dup        
            IL_06C3: stloc.0    
            IL_06C4: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_06C9: ldloca.s   V_8
            IL_06CB: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_06D0: ldloc.1    
            IL_06D1: ldloc.1    
            IL_06D2: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_06D7: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_06DC: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_06E1: ldloc.1    
            IL_06E2: ldloc.1    
            IL_06E3: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_06E8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_06ED: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_06F2: ldloc.1    
            IL_06F3: ldstr      "\r\n                        "
            IL_06F8: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_06FD: ldloc.1    
            IL_06FE: ldloc.1    
            IL_06FF: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0704: ldstr      "input"
            IL_0709: ldc.i4.1   
            IL_070A: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996023215"
            IL_070F: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_9
            IL_0714: dup        
            IL_0715: brtrue.s   IL_072E
            IL_0717: pop        
            IL_0718: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_071D: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_9()
            IL_0723: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0728: dup        
            IL_0729: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_9
            IL_072E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0733: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0738: ldloc.1    
            IL_0739: ldloc.1    
            IL_073A: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_073F: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0744: ldloc.1    
            IL_0745: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_074A: ldloc.1    
            IL_074B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0750: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0755: ldloc.1    
            IL_0756: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_075B: ldloc.1    
            IL_075C: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0761: ldloc.1    
            IL_0762: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0767: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_076C: call       void System.Type::GetTypeFromHandle
            IL_0771: ldstr      "__model"
            IL_0776: call       void System.Linq.Expressions.Expression::Parameter
            IL_077B: stloc.2    
            IL_077C: ldloc.2    
            IL_077D: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_RepositoryId()
            IL_0782: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0787: castclass  System.Reflection.MethodInfo
            IL_078C: call       void System.Linq.Expressions.Expression::Property
            IL_0791: ldc.i4.1   
            IL_0792: newarr     System.Linq.Expressions.ParameterExpression
            IL_0797: dup        
            IL_0798: ldc.i4.0   
            IL_0799: ldloc.2    
            IL_079A: stelem.ref 
            IL_079B: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_07A0: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_07A5: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_07AA: ldloc.1    
            IL_07AB: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_07B0: ldstr      "asp-for"
            IL_07B5: ldloc.1    
            IL_07B6: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_07BB: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_07C0: ldc.i4.0   
            IL_07C1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_07C6: ldloc.1    
            IL_07C7: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_07CC: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_07D1: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_07D6: castclass  System.String
            IL_07DB: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_07E0: ldloc.1    
            IL_07E1: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_07E6: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_07EB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_07F0: ldloc.1    
            IL_07F1: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_07F6: ldloc.1    
            IL_07F7: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_07FC: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0801: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0806: stloc.s    V_9
            IL_0808: ldloca.s   V_9
            IL_080A: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_080F: brtrue.s   IL_0852
            IL_0811: ldarg.0    
            IL_0812: ldc.i4.6   
            IL_0813: dup        
            IL_0814: stloc.0    
            IL_0815: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_081A: ldarg.0    
            IL_081B: ldloc.s    V_9
            IL_081D: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0822: ldarg.0    
            IL_0823: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0828: ldloca.s   V_9
            IL_082A: ldarg.0    
            IL_082B: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0830: leave      IL_3BC2
            IL_0835: ldarg.0    
            IL_0836: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_083B: stloc.s    V_9
            IL_083D: ldarg.0    
            IL_083E: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0843: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0849: ldarg.0    
            IL_084A: ldc.i4.m1  
            IL_084B: dup        
            IL_084C: stloc.0    
            IL_084D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0852: ldloca.s   V_9
            IL_0854: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0859: ldloc.1    
            IL_085A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_085F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0864: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_0869: brtrue.s   IL_08CE
            IL_086B: ldloc.1    
            IL_086C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0871: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0876: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_087B: stloc.s    V_10
            IL_087D: ldloca.s   V_10
            IL_087F: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0884: brtrue.s   IL_08C7
            IL_0886: ldarg.0    
            IL_0887: ldc.i4.7   
            IL_0888: dup        
            IL_0889: stloc.0    
            IL_088A: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_088F: ldarg.0    
            IL_0890: ldloc.s    V_10
            IL_0892: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0897: ldarg.0    
            IL_0898: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_089D: ldloca.s   V_10
            IL_089F: ldarg.0    
            IL_08A0: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_08A5: leave      IL_3BC2
            IL_08AA: ldarg.0    
            IL_08AB: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_08B0: stloc.s    V_10
            IL_08B2: ldarg.0    
            IL_08B3: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_08B8: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_08BE: ldarg.0    
            IL_08BF: ldc.i4.m1  
            IL_08C0: dup        
            IL_08C1: stloc.0    
            IL_08C2: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_08C7: ldloca.s   V_10
            IL_08C9: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_08CE: ldloc.1    
            IL_08CF: ldloc.1    
            IL_08D0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_08D5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_08DA: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_08DF: ldloc.1    
            IL_08E0: ldloc.1    
            IL_08E1: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_08E6: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_08EB: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_08F0: ldloc.1    
            IL_08F1: ldstr      "\r\n                        "
            IL_08F6: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_08FB: ldloc.1    
            IL_08FC: ldloc.1    
            IL_08FD: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0902: ldstr      "input"
            IL_0907: ldc.i4.1   
            IL_0908: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996024995"
            IL_090D: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_11
            IL_0912: dup        
            IL_0913: brtrue.s   IL_092C
            IL_0915: pop        
            IL_0916: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_091B: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_11()
            IL_0921: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0926: dup        
            IL_0927: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_11
            IL_092C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0931: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0936: ldloc.1    
            IL_0937: ldloc.1    
            IL_0938: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_093D: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0942: ldloc.1    
            IL_0943: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0948: ldloc.1    
            IL_0949: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_094E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0953: ldloc.1    
            IL_0954: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0959: ldloc.1    
            IL_095A: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_095F: ldloc.1    
            IL_0960: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0965: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_096A: call       void System.Type::GetTypeFromHandle
            IL_096F: ldstr      "__model"
            IL_0974: call       void System.Linq.Expressions.Expression::Parameter
            IL_0979: stloc.2    
            IL_097A: ldloc.2    
            IL_097B: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_GuiLanguageId()
            IL_0980: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0985: castclass  System.Reflection.MethodInfo
            IL_098A: call       void System.Linq.Expressions.Expression::Property
            IL_098F: ldc.i4.1   
            IL_0990: newarr     System.Linq.Expressions.ParameterExpression
            IL_0995: dup        
            IL_0996: ldc.i4.0   
            IL_0997: ldloc.2    
            IL_0998: stelem.ref 
            IL_0999: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_099E: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_09A3: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_09A8: ldloc.1    
            IL_09A9: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_09AE: ldstr      "asp-for"
            IL_09B3: ldloc.1    
            IL_09B4: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_09B9: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_09BE: ldc.i4.0   
            IL_09BF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_09C4: ldloc.1    
            IL_09C5: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_09CA: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_09CF: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_09D4: castclass  System.String
            IL_09D9: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_09DE: ldloc.1    
            IL_09DF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_09E4: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_09E9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_09EE: ldloc.1    
            IL_09EF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_09F4: ldloc.1    
            IL_09F5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_09FA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_09FF: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0A04: stloc.s    V_11
            IL_0A06: ldloca.s   V_11
            IL_0A08: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0A0D: brtrue.s   IL_0A50
            IL_0A0F: ldarg.0    
            IL_0A10: ldc.i4.8   
            IL_0A11: dup        
            IL_0A12: stloc.0    
            IL_0A13: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0A18: ldarg.0    
            IL_0A19: ldloc.s    V_11
            IL_0A1B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0A20: ldarg.0    
            IL_0A21: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0A26: ldloca.s   V_11
            IL_0A28: ldarg.0    
            IL_0A29: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0A2E: leave      IL_3BC2
            IL_0A33: ldarg.0    
            IL_0A34: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0A39: stloc.s    V_11
            IL_0A3B: ldarg.0    
            IL_0A3C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0A41: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0A47: ldarg.0    
            IL_0A48: ldc.i4.m1  
            IL_0A49: dup        
            IL_0A4A: stloc.0    
            IL_0A4B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0A50: ldloca.s   V_11
            IL_0A52: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0A57: ldloc.1    
            IL_0A58: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0A5D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0A62: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_0A67: brtrue.s   IL_0ACD
            IL_0A69: ldloc.1    
            IL_0A6A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0A6F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0A74: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0A79: stloc.s    V_12
            IL_0A7B: ldloca.s   V_12
            IL_0A7D: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0A82: brtrue.s   IL_0AC6
            IL_0A84: ldarg.0    
            IL_0A85: ldc.i4.s   9
            IL_0A87: dup        
            IL_0A88: stloc.0    
            IL_0A89: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0A8E: ldarg.0    
            IL_0A8F: ldloc.s    V_12
            IL_0A91: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0A96: ldarg.0    
            IL_0A97: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0A9C: ldloca.s   V_12
            IL_0A9E: ldarg.0    
            IL_0A9F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0AA4: leave      IL_3BC2
            IL_0AA9: ldarg.0    
            IL_0AAA: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0AAF: stloc.s    V_12
            IL_0AB1: ldarg.0    
            IL_0AB2: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0AB7: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0ABD: ldarg.0    
            IL_0ABE: ldc.i4.m1  
            IL_0ABF: dup        
            IL_0AC0: stloc.0    
            IL_0AC1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0AC6: ldloca.s   V_12
            IL_0AC8: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0ACD: ldloc.1    
            IL_0ACE: ldloc.1    
            IL_0ACF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0AD4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0AD9: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_0ADE: ldloc.1    
            IL_0ADF: ldloc.1    
            IL_0AE0: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0AE5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_0AEA: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0AEF: ldloc.1    
            IL_0AF0: ldstr      "\r\n                        "
            IL_0AF5: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0AFA: ldloc.1    
            IL_0AFB: ldloc.1    
            IL_0AFC: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0B01: ldstr      "input"
            IL_0B06: ldc.i4.1   
            IL_0B07: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996026776"
            IL_0B0C: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_13
            IL_0B11: dup        
            IL_0B12: brtrue.s   IL_0B2B
            IL_0B14: pop        
            IL_0B15: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_0B1A: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_13()
            IL_0B20: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0B25: dup        
            IL_0B26: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_13
            IL_0B2B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0B30: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0B35: ldloc.1    
            IL_0B36: ldloc.1    
            IL_0B37: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0B3C: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0B41: ldloc.1    
            IL_0B42: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0B47: ldloc.1    
            IL_0B48: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0B4D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0B52: ldloc.1    
            IL_0B53: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0B58: ldloc.1    
            IL_0B59: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0B5E: ldloc.1    
            IL_0B5F: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0B64: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_0B69: call       void System.Type::GetTypeFromHandle
            IL_0B6E: ldstr      "__model"
            IL_0B73: call       void System.Linq.Expressions.Expression::Parameter
            IL_0B78: stloc.2    
            IL_0B79: ldloc.2    
            IL_0B7A: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_DataLanguageId()
            IL_0B7F: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0B84: castclass  System.Reflection.MethodInfo
            IL_0B89: call       void System.Linq.Expressions.Expression::Property
            IL_0B8E: ldc.i4.1   
            IL_0B8F: newarr     System.Linq.Expressions.ParameterExpression
            IL_0B94: dup        
            IL_0B95: ldc.i4.0   
            IL_0B96: ldloc.2    
            IL_0B97: stelem.ref 
            IL_0B98: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_0B9D: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_0BA2: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_0BA7: ldloc.1    
            IL_0BA8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0BAD: ldstr      "asp-for"
            IL_0BB2: ldloc.1    
            IL_0BB3: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0BB8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_0BBD: ldc.i4.0   
            IL_0BBE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0BC3: ldloc.1    
            IL_0BC4: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0BC9: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0BCE: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_0BD3: castclass  System.String
            IL_0BD8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_0BDD: ldloc.1    
            IL_0BDE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0BE3: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0BE8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0BED: ldloc.1    
            IL_0BEE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_0BF3: ldloc.1    
            IL_0BF4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0BF9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0BFE: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0C03: stloc.s    V_13
            IL_0C05: ldloca.s   V_13
            IL_0C07: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0C0C: brtrue.s   IL_0C50
            IL_0C0E: ldarg.0    
            IL_0C0F: ldc.i4.s   10
            IL_0C11: dup        
            IL_0C12: stloc.0    
            IL_0C13: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0C18: ldarg.0    
            IL_0C19: ldloc.s    V_13
            IL_0C1B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0C20: ldarg.0    
            IL_0C21: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0C26: ldloca.s   V_13
            IL_0C28: ldarg.0    
            IL_0C29: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0C2E: leave      IL_3BC2
            IL_0C33: ldarg.0    
            IL_0C34: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0C39: stloc.s    V_13
            IL_0C3B: ldarg.0    
            IL_0C3C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0C41: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0C47: ldarg.0    
            IL_0C48: ldc.i4.m1  
            IL_0C49: dup        
            IL_0C4A: stloc.0    
            IL_0C4B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0C50: ldloca.s   V_13
            IL_0C52: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0C57: ldloc.1    
            IL_0C58: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0C5D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0C62: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_0C67: brtrue.s   IL_0CCD
            IL_0C69: ldloc.1    
            IL_0C6A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0C6F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0C74: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0C79: stloc.s    V_14
            IL_0C7B: ldloca.s   V_14
            IL_0C7D: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0C82: brtrue.s   IL_0CC6
            IL_0C84: ldarg.0    
            IL_0C85: ldc.i4.s   11
            IL_0C87: dup        
            IL_0C88: stloc.0    
            IL_0C89: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0C8E: ldarg.0    
            IL_0C8F: ldloc.s    V_14
            IL_0C91: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0C96: ldarg.0    
            IL_0C97: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0C9C: ldloca.s   V_14
            IL_0C9E: ldarg.0    
            IL_0C9F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0CA4: leave      IL_3BC2
            IL_0CA9: ldarg.0    
            IL_0CAA: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0CAF: stloc.s    V_14
            IL_0CB1: ldarg.0    
            IL_0CB2: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0CB7: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0CBD: ldarg.0    
            IL_0CBE: ldc.i4.m1  
            IL_0CBF: dup        
            IL_0CC0: stloc.0    
            IL_0CC1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0CC6: ldloca.s   V_14
            IL_0CC8: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0CCD: ldloc.1    
            IL_0CCE: ldloc.1    
            IL_0CCF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0CD4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0CD9: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_0CDE: ldloc.1    
            IL_0CDF: ldloc.1    
            IL_0CE0: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0CE5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_0CEA: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0CEF: ldloc.1    
            IL_0CF0: ldstr      "\r\n                        "
            IL_0CF5: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0CFA: ldloc.1    
            IL_0CFB: ldloc.1    
            IL_0CFC: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0D01: ldstr      "input"
            IL_0D06: ldc.i4.1   
            IL_0D07: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996028558"
            IL_0D0C: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_15
            IL_0D11: dup        
            IL_0D12: brtrue.s   IL_0D2B
            IL_0D14: pop        
            IL_0D15: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_0D1A: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_15()
            IL_0D20: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0D25: dup        
            IL_0D26: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_15
            IL_0D2B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0D30: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0D35: ldloc.1    
            IL_0D36: ldloc.1    
            IL_0D37: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0D3C: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0D41: ldloc.1    
            IL_0D42: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0D47: ldloc.1    
            IL_0D48: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0D4D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0D52: ldloc.1    
            IL_0D53: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0D58: ldloc.1    
            IL_0D59: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0D5E: ldloc.1    
            IL_0D5F: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0D64: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_0D69: call       void System.Type::GetTypeFromHandle
            IL_0D6E: ldstr      "__model"
            IL_0D73: call       void System.Linq.Expressions.Expression::Parameter
            IL_0D78: stloc.2    
            IL_0D79: ldloc.2    
            IL_0D7A: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ProfileId()
            IL_0D7F: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0D84: castclass  System.Reflection.MethodInfo
            IL_0D89: call       void System.Linq.Expressions.Expression::Property
            IL_0D8E: ldc.i4.1   
            IL_0D8F: newarr     System.Linq.Expressions.ParameterExpression
            IL_0D94: dup        
            IL_0D95: ldc.i4.0   
            IL_0D96: ldloc.2    
            IL_0D97: stelem.ref 
            IL_0D98: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_0D9D: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_0DA2: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_0DA7: ldloc.1    
            IL_0DA8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0DAD: ldstr      "asp-for"
            IL_0DB2: ldloc.1    
            IL_0DB3: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0DB8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_0DBD: ldc.i4.0   
            IL_0DBE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0DC3: ldloc.1    
            IL_0DC4: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0DC9: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0DCE: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_0DD3: castclass  System.String
            IL_0DD8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_0DDD: ldloc.1    
            IL_0DDE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0DE3: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0DE8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0DED: ldloc.1    
            IL_0DEE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_0DF3: ldloc.1    
            IL_0DF4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0DF9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0DFE: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0E03: stloc.s    V_15
            IL_0E05: ldloca.s   V_15
            IL_0E07: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0E0C: brtrue.s   IL_0E50
            IL_0E0E: ldarg.0    
            IL_0E0F: ldc.i4.s   12
            IL_0E11: dup        
            IL_0E12: stloc.0    
            IL_0E13: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0E18: ldarg.0    
            IL_0E19: ldloc.s    V_15
            IL_0E1B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0E20: ldarg.0    
            IL_0E21: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0E26: ldloca.s   V_15
            IL_0E28: ldarg.0    
            IL_0E29: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0E2E: leave      IL_3BC2
            IL_0E33: ldarg.0    
            IL_0E34: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0E39: stloc.s    V_15
            IL_0E3B: ldarg.0    
            IL_0E3C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0E41: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0E47: ldarg.0    
            IL_0E48: ldc.i4.m1  
            IL_0E49: dup        
            IL_0E4A: stloc.0    
            IL_0E4B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0E50: ldloca.s   V_15
            IL_0E52: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0E57: ldloc.1    
            IL_0E58: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0E5D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0E62: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_0E67: brtrue.s   IL_0ECD
            IL_0E69: ldloc.1    
            IL_0E6A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0E6F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0E74: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0E79: stloc.s    V_16
            IL_0E7B: ldloca.s   V_16
            IL_0E7D: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0E82: brtrue.s   IL_0EC6
            IL_0E84: ldarg.0    
            IL_0E85: ldc.i4.s   13
            IL_0E87: dup        
            IL_0E88: stloc.0    
            IL_0E89: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0E8E: ldarg.0    
            IL_0E8F: ldloc.s    V_16
            IL_0E91: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0E96: ldarg.0    
            IL_0E97: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0E9C: ldloca.s   V_16
            IL_0E9E: ldarg.0    
            IL_0E9F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_0EA4: leave      IL_3BC2
            IL_0EA9: ldarg.0    
            IL_0EAA: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0EAF: stloc.s    V_16
            IL_0EB1: ldarg.0    
            IL_0EB2: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_0EB7: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0EBD: ldarg.0    
            IL_0EBE: ldc.i4.m1  
            IL_0EBF: dup        
            IL_0EC0: stloc.0    
            IL_0EC1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_0EC6: ldloca.s   V_16
            IL_0EC8: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0ECD: ldloc.1    
            IL_0ECE: ldloc.1    
            IL_0ECF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0ED4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0ED9: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_0EDE: ldloc.1    
            IL_0EDF: ldloc.1    
            IL_0EE0: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0EE5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_0EEA: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0EEF: ldloc.1    
            IL_0EF0: ldstr      "\r\n                        "
            IL_0EF5: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0EFA: ldloc.1    
            IL_0EFB: ldloc.1    
            IL_0EFC: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0F01: ldstr      "input"
            IL_0F06: ldc.i4.1   
            IL_0F07: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996030335"
            IL_0F0C: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_17
            IL_0F11: dup        
            IL_0F12: brtrue.s   IL_0F2B
            IL_0F14: pop        
            IL_0F15: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_0F1A: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_17()
            IL_0F20: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0F25: dup        
            IL_0F26: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_17
            IL_0F2B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0F30: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0F35: ldloc.1    
            IL_0F36: ldloc.1    
            IL_0F37: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_0F3C: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0F41: ldloc.1    
            IL_0F42: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0F47: ldloc.1    
            IL_0F48: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0F4D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0F52: ldloc.1    
            IL_0F53: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0F58: ldloc.1    
            IL_0F59: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_0F5E: ldloc.1    
            IL_0F5F: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_0F64: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_0F69: call       void System.Type::GetTypeFromHandle
            IL_0F6E: ldstr      "__model"
            IL_0F73: call       void System.Linq.Expressions.Expression::Parameter
            IL_0F78: stloc.2    
            IL_0F79: ldloc.2    
            IL_0F7A: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Password()
            IL_0F7F: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_0F84: castclass  System.Reflection.MethodInfo
            IL_0F89: call       void System.Linq.Expressions.Expression::Property
            IL_0F8E: ldc.i4.1   
            IL_0F8F: newarr     System.Linq.Expressions.ParameterExpression
            IL_0F94: dup        
            IL_0F95: ldc.i4.0   
            IL_0F96: ldloc.2    
            IL_0F97: stelem.ref 
            IL_0F98: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_0F9D: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_0FA2: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_0FA7: ldloc.1    
            IL_0FA8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0FAD: ldstr      "asp-for"
            IL_0FB2: ldloc.1    
            IL_0FB3: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0FB8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_0FBD: ldc.i4.0   
            IL_0FBE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0FC3: ldloc.1    
            IL_0FC4: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_0FC9: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0FCE: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_0FD3: castclass  System.String
            IL_0FD8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_0FDD: ldloc.1    
            IL_0FDE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0FE3: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_0FE8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0FED: ldloc.1    
            IL_0FEE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_0FF3: ldloc.1    
            IL_0FF4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0FF9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0FFE: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1003: stloc.s    V_17
            IL_1005: ldloca.s   V_17
            IL_1007: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_100C: brtrue.s   IL_1050
            IL_100E: ldarg.0    
            IL_100F: ldc.i4.s   14
            IL_1011: dup        
            IL_1012: stloc.0    
            IL_1013: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1018: ldarg.0    
            IL_1019: ldloc.s    V_17
            IL_101B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1020: ldarg.0    
            IL_1021: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1026: ldloca.s   V_17
            IL_1028: ldarg.0    
            IL_1029: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_102E: leave      IL_3BC2
            IL_1033: ldarg.0    
            IL_1034: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1039: stloc.s    V_17
            IL_103B: ldarg.0    
            IL_103C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1041: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1047: ldarg.0    
            IL_1048: ldc.i4.m1  
            IL_1049: dup        
            IL_104A: stloc.0    
            IL_104B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1050: ldloca.s   V_17
            IL_1052: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1057: ldloc.1    
            IL_1058: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_105D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1062: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_1067: brtrue.s   IL_10CD
            IL_1069: ldloc.1    
            IL_106A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_106F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1074: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1079: stloc.s    V_18
            IL_107B: ldloca.s   V_18
            IL_107D: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1082: brtrue.s   IL_10C6
            IL_1084: ldarg.0    
            IL_1085: ldc.i4.s   15
            IL_1087: dup        
            IL_1088: stloc.0    
            IL_1089: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_108E: ldarg.0    
            IL_108F: ldloc.s    V_18
            IL_1091: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1096: ldarg.0    
            IL_1097: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_109C: ldloca.s   V_18
            IL_109E: ldarg.0    
            IL_109F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_10A4: leave      IL_3BC2
            IL_10A9: ldarg.0    
            IL_10AA: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_10AF: stloc.s    V_18
            IL_10B1: ldarg.0    
            IL_10B2: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_10B7: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_10BD: ldarg.0    
            IL_10BE: ldc.i4.m1  
            IL_10BF: dup        
            IL_10C0: stloc.0    
            IL_10C1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_10C6: ldloca.s   V_18
            IL_10C8: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_10CD: ldloc.1    
            IL_10CE: ldloc.1    
            IL_10CF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_10D4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_10D9: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_10DE: ldloc.1    
            IL_10DF: ldloc.1    
            IL_10E0: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_10E5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_10EA: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_10EF: ldloc.1    
            IL_10F0: ldstr      "\r\n\r\n                        "
            IL_10F5: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_10FA: ldloc.1    
            IL_10FB: ldloc.1    
            IL_10FC: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1101: ldstr      "div"
            IL_1106: ldc.i4.0   
            IL_1107: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996032115"
            IL_110C: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_19
            IL_1111: dup        
            IL_1112: brtrue.s   IL_112B
            IL_1114: pop        
            IL_1115: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_111A: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_19()
            IL_1120: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_1125: dup        
            IL_1126: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_19
            IL_112B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_1130: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1135: ldloc.1    
            IL_1136: ldloc.1    
            IL_1137: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>()
            IL_113C: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
            IL_1141: ldloc.1    
            IL_1142: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1147: ldloc.1    
            IL_1148: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
            IL_114D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_1152: ldloc.1    
            IL_1153: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
            IL_1158: ldc.i4.1   
            IL_1159: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::set_ValidationSummary
            IL_115E: ldloc.1    
            IL_115F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1164: ldstr      "asp-validation-summary"
            IL_1169: ldloc.1    
            IL_116A: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper
            IL_116F: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper::get_ValidationSummary
            IL_1174: box        Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary
            IL_1179: ldc.i4.0   
            IL_117A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_117F: ldloc.1    
            IL_1180: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1185: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
            IL_118A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_118F: ldloc.1    
            IL_1190: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1195: ldloc.1    
            IL_1196: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_119B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_11A0: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_11A5: stloc.s    V_19
            IL_11A7: ldloca.s   V_19
            IL_11A9: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_11AE: brtrue.s   IL_11F2
            IL_11B0: ldarg.0    
            IL_11B1: ldc.i4.s   16
            IL_11B3: dup        
            IL_11B4: stloc.0    
            IL_11B5: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_11BA: ldarg.0    
            IL_11BB: ldloc.s    V_19
            IL_11BD: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_11C2: ldarg.0    
            IL_11C3: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_11C8: ldloca.s   V_19
            IL_11CA: ldarg.0    
            IL_11CB: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_11D0: leave      IL_3BC2
            IL_11D5: ldarg.0    
            IL_11D6: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_11DB: stloc.s    V_19
            IL_11DD: ldarg.0    
            IL_11DE: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_11E3: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_11E9: ldarg.0    
            IL_11EA: ldc.i4.m1  
            IL_11EB: dup        
            IL_11EC: stloc.0    
            IL_11ED: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_11F2: ldloca.s   V_19
            IL_11F4: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_11F9: ldloc.1    
            IL_11FA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_11FF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1204: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_1209: brtrue.s   IL_126F
            IL_120B: ldloc.1    
            IL_120C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1211: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1216: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_121B: stloc.s    V_20
            IL_121D: ldloca.s   V_20
            IL_121F: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1224: brtrue.s   IL_1268
            IL_1226: ldarg.0    
            IL_1227: ldc.i4.s   17
            IL_1229: dup        
            IL_122A: stloc.0    
            IL_122B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1230: ldarg.0    
            IL_1231: ldloc.s    V_20
            IL_1233: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1238: ldarg.0    
            IL_1239: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_123E: ldloca.s   V_20
            IL_1240: ldarg.0    
            IL_1241: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1246: leave      IL_3BC2
            IL_124B: ldarg.0    
            IL_124C: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1251: stloc.s    V_20
            IL_1253: ldarg.0    
            IL_1254: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1259: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_125F: ldarg.0    
            IL_1260: ldc.i4.m1  
            IL_1261: dup        
            IL_1262: stloc.0    
            IL_1263: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1268: ldloca.s   V_20
            IL_126A: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_126F: ldloc.1    
            IL_1270: ldloc.1    
            IL_1271: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1276: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_127B: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1280: ldloc.1    
            IL_1281: ldloc.1    
            IL_1282: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1287: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_128C: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1291: ldloc.1    
            IL_1292: ldstr      "\r\n                        <div class=\"form-group\">\r\n                            <label for=\"TokenName\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Name<span class=\"required\"> *</span></label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                "
            IL_1297: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_129C: ldloc.1    
            IL_129D: ldloc.1    
            IL_129E: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_12A3: ldstr      "input"
            IL_12A8: ldc.i4.1   
            IL_12A9: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996034140"
            IL_12AE: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_20
            IL_12B3: dup        
            IL_12B4: brtrue.s   IL_12CD
            IL_12B6: pop        
            IL_12B7: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_12BC: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_20()
            IL_12C2: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_12C7: dup        
            IL_12C8: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_20
            IL_12CD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_12D2: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_12D7: ldloc.1    
            IL_12D8: ldloc.1    
            IL_12D9: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_12DE: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_12E3: ldloc.1    
            IL_12E4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_12E9: ldloc.1    
            IL_12EA: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_12EF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_12F4: ldloc.1    
            IL_12F5: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_12FA: ldloc.1    
            IL_12FB: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_1300: ldloc.1    
            IL_1301: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_1306: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_130B: call       void System.Type::GetTypeFromHandle
            IL_1310: ldstr      "__model"
            IL_1315: call       void System.Linq.Expressions.Expression::Parameter
            IL_131A: stloc.2    
            IL_131B: ldloc.2    
            IL_131C: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_TokenName()
            IL_1321: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_1326: castclass  System.Reflection.MethodInfo
            IL_132B: call       void System.Linq.Expressions.Expression::Property
            IL_1330: ldc.i4.1   
            IL_1331: newarr     System.Linq.Expressions.ParameterExpression
            IL_1336: dup        
            IL_1337: ldc.i4.0   
            IL_1338: ldloc.2    
            IL_1339: stelem.ref 
            IL_133A: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_133F: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1344: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_1349: ldloc.1    
            IL_134A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_134F: ldstr      "asp-for"
            IL_1354: ldloc.1    
            IL_1355: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_135A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_135F: ldc.i4.0   
            IL_1360: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1365: ldloc.1    
            IL_1366: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_136B: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_2
            IL_1370: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1375: ldloc.1    
            IL_1376: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_137B: ldloc.1    
            IL_137C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1381: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_1386: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_138B: stloc.s    V_21
            IL_138D: ldloca.s   V_21
            IL_138F: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1394: brtrue.s   IL_13D8
            IL_1396: ldarg.0    
            IL_1397: ldc.i4.s   18
            IL_1399: dup        
            IL_139A: stloc.0    
            IL_139B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_13A0: ldarg.0    
            IL_13A1: ldloc.s    V_21
            IL_13A3: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_13A8: ldarg.0    
            IL_13A9: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_13AE: ldloca.s   V_21
            IL_13B0: ldarg.0    
            IL_13B1: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_13B6: leave      IL_3BC2
            IL_13BB: ldarg.0    
            IL_13BC: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_13C1: stloc.s    V_21
            IL_13C3: ldarg.0    
            IL_13C4: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_13C9: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_13CF: ldarg.0    
            IL_13D0: ldc.i4.m1  
            IL_13D1: dup        
            IL_13D2: stloc.0    
            IL_13D3: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_13D8: ldloca.s   V_21
            IL_13DA: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_13DF: ldloc.1    
            IL_13E0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_13E5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_13EA: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_13EF: brtrue.s   IL_1455
            IL_13F1: ldloc.1    
            IL_13F2: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_13F7: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_13FC: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1401: stloc.s    V_22
            IL_1403: ldloca.s   V_22
            IL_1405: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_140A: brtrue.s   IL_144E
            IL_140C: ldarg.0    
            IL_140D: ldc.i4.s   19
            IL_140F: dup        
            IL_1410: stloc.0    
            IL_1411: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1416: ldarg.0    
            IL_1417: ldloc.s    V_22
            IL_1419: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_141E: ldarg.0    
            IL_141F: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1424: ldloca.s   V_22
            IL_1426: ldarg.0    
            IL_1427: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_142C: leave      IL_3BC2
            IL_1431: ldarg.0    
            IL_1432: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1437: stloc.s    V_22
            IL_1439: ldarg.0    
            IL_143A: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_143F: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1445: ldarg.0    
            IL_1446: ldc.i4.m1  
            IL_1447: dup        
            IL_1448: stloc.0    
            IL_1449: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_144E: ldloca.s   V_22
            IL_1450: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1455: ldloc.1    
            IL_1456: ldloc.1    
            IL_1457: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_145C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1461: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1466: ldloc.1    
            IL_1467: ldloc.1    
            IL_1468: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_146D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_1472: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1477: ldloc.1    
            IL_1478: ldstr      "\r\n                                "
            IL_147D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_1482: ldloc.1    
            IL_1483: ldloc.1    
            IL_1484: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1489: ldstr      "span"
            IL_148E: ldc.i4.0   
            IL_148F: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996035796"
            IL_1494: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_22
            IL_1499: dup        
            IL_149A: brtrue.s   IL_14B3
            IL_149C: pop        
            IL_149D: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_14A2: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_22()
            IL_14A8: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_14AD: dup        
            IL_14AE: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_22
            IL_14B3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_14B8: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_14BD: ldloc.1    
            IL_14BE: ldloc.1    
            IL_14BF: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>()
            IL_14C4: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_14C9: ldloc.1    
            IL_14CA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_14CF: ldloc.1    
            IL_14D0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_14D5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_14DA: ldloc.1    
            IL_14DB: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_14E0: ldloc.1    
            IL_14E1: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_14E6: ldloc.1    
            IL_14E7: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_14EC: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_14F1: call       void System.Type::GetTypeFromHandle
            IL_14F6: ldstr      "__model"
            IL_14FB: call       void System.Linq.Expressions.Expression::Parameter
            IL_1500: stloc.2    
            IL_1501: ldloc.2    
            IL_1502: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_TokenName()
            IL_1507: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_150C: castclass  System.Reflection.MethodInfo
            IL_1511: call       void System.Linq.Expressions.Expression::Property
            IL_1516: ldc.i4.1   
            IL_1517: newarr     System.Linq.Expressions.ParameterExpression
            IL_151C: dup        
            IL_151D: ldc.i4.0   
            IL_151E: ldloc.2    
            IL_151F: stelem.ref 
            IL_1520: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_1525: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_152A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::set_For
            IL_152F: ldloc.1    
            IL_1530: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1535: ldstr      "asp-validation-for"
            IL_153A: ldloc.1    
            IL_153B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1540: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::get_For
            IL_1545: ldc.i4.0   
            IL_1546: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_154B: ldloc.1    
            IL_154C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1551: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
            IL_1556: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_155B: ldloc.1    
            IL_155C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1561: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_3
            IL_1566: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_156B: ldloc.1    
            IL_156C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1571: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_4
            IL_1576: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_157B: ldloc.1    
            IL_157C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1581: ldloc.1    
            IL_1582: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1587: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_158C: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1591: stloc.s    V_23
            IL_1593: ldloca.s   V_23
            IL_1595: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_159A: brtrue.s   IL_15DE
            IL_159C: ldarg.0    
            IL_159D: ldc.i4.s   20
            IL_159F: dup        
            IL_15A0: stloc.0    
            IL_15A1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_15A6: ldarg.0    
            IL_15A7: ldloc.s    V_23
            IL_15A9: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_15AE: ldarg.0    
            IL_15AF: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_15B4: ldloca.s   V_23
            IL_15B6: ldarg.0    
            IL_15B7: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_15BC: leave      IL_3BC2
            IL_15C1: ldarg.0    
            IL_15C2: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_15C7: stloc.s    V_23
            IL_15C9: ldarg.0    
            IL_15CA: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_15CF: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_15D5: ldarg.0    
            IL_15D6: ldc.i4.m1  
            IL_15D7: dup        
            IL_15D8: stloc.0    
            IL_15D9: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_15DE: ldloca.s   V_23
            IL_15E0: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_15E5: ldloc.1    
            IL_15E6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_15EB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_15F0: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_15F5: brtrue.s   IL_165B
            IL_15F7: ldloc.1    
            IL_15F8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_15FD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1602: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1607: stloc.s    V_24
            IL_1609: ldloca.s   V_24
            IL_160B: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1610: brtrue.s   IL_1654
            IL_1612: ldarg.0    
            IL_1613: ldc.i4.s   21
            IL_1615: dup        
            IL_1616: stloc.0    
            IL_1617: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_161C: ldarg.0    
            IL_161D: ldloc.s    V_24
            IL_161F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1624: ldarg.0    
            IL_1625: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_162A: ldloca.s   V_24
            IL_162C: ldarg.0    
            IL_162D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1632: leave      IL_3BC2
            IL_1637: ldarg.0    
            IL_1638: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_163D: stloc.s    V_24
            IL_163F: ldarg.0    
            IL_1640: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1645: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_164B: ldarg.0    
            IL_164C: ldc.i4.m1  
            IL_164D: dup        
            IL_164E: stloc.0    
            IL_164F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1654: ldloca.s   V_24
            IL_1656: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_165B: ldloc.1    
            IL_165C: ldloc.1    
            IL_165D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1662: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1667: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_166C: ldloc.1    
            IL_166D: ldloc.1    
            IL_166E: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1673: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_1678: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_167D: ldloc.1    
            IL_167E: ldstr      "\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            "
            IL_1683: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_1688: ldloc.1    
            IL_1689: ldloc.1    
            IL_168A: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_168F: ldstr      "label"
            IL_1694: ldc.i4.0   
            IL_1695: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996037824"
            IL_169A: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_24
            IL_169F: dup        
            IL_16A0: brtrue.s   IL_16B9
            IL_16A2: pop        
            IL_16A3: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_16A8: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_24()
            IL_16AE: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_16B3: dup        
            IL_16B4: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_24
            IL_16B9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_16BE: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_16C3: ldloc.1    
            IL_16C4: ldloc.1    
            IL_16C5: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>()
            IL_16CA: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper
            IL_16CF: ldloc.1    
            IL_16D0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_16D5: ldloc.1    
            IL_16D6: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper
            IL_16DB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_16E0: ldloc.1    
            IL_16E1: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper
            IL_16E6: ldloc.1    
            IL_16E7: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_16EC: ldloc.1    
            IL_16ED: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_16F2: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_16F7: call       void System.Type::GetTypeFromHandle
            IL_16FC: ldstr      "__model"
            IL_1701: call       void System.Linq.Expressions.Expression::Parameter
            IL_1706: stloc.2    
            IL_1707: ldloc.2    
            IL_1708: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ExpirationDate()
            IL_170D: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_1712: castclass  System.Reflection.MethodInfo
            IL_1717: call       void System.Linq.Expressions.Expression::Property
            IL_171C: ldc.i4.1   
            IL_171D: newarr     System.Linq.Expressions.ParameterExpression
            IL_1722: dup        
            IL_1723: ldc.i4.0   
            IL_1724: ldloc.2    
            IL_1725: stelem.ref 
            IL_1726: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_172B: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1730: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper::set_For
            IL_1735: ldloc.1    
            IL_1736: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_173B: ldstr      "asp-for"
            IL_1740: ldloc.1    
            IL_1741: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper
            IL_1746: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper::get_For
            IL_174B: ldc.i4.0   
            IL_174C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1751: ldloc.1    
            IL_1752: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1757: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_5
            IL_175C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1761: ldloc.1    
            IL_1762: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1767: ldloc.1    
            IL_1768: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_176D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_1772: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1777: stloc.s    V_25
            IL_1779: ldloca.s   V_25
            IL_177B: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1780: brtrue.s   IL_17C4
            IL_1782: ldarg.0    
            IL_1783: ldc.i4.s   22
            IL_1785: dup        
            IL_1786: stloc.0    
            IL_1787: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_178C: ldarg.0    
            IL_178D: ldloc.s    V_25
            IL_178F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1794: ldarg.0    
            IL_1795: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_179A: ldloca.s   V_25
            IL_179C: ldarg.0    
            IL_179D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_17A2: leave      IL_3BC2
            IL_17A7: ldarg.0    
            IL_17A8: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_17AD: stloc.s    V_25
            IL_17AF: ldarg.0    
            IL_17B0: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_17B5: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_17BB: ldarg.0    
            IL_17BC: ldc.i4.m1  
            IL_17BD: dup        
            IL_17BE: stloc.0    
            IL_17BF: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_17C4: ldloca.s   V_25
            IL_17C6: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_17CB: ldloc.1    
            IL_17CC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_17D1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_17D6: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_17DB: brtrue.s   IL_1841
            IL_17DD: ldloc.1    
            IL_17DE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_17E3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_17E8: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_17ED: stloc.s    V_26
            IL_17EF: ldloca.s   V_26
            IL_17F1: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_17F6: brtrue.s   IL_183A
            IL_17F8: ldarg.0    
            IL_17F9: ldc.i4.s   23
            IL_17FB: dup        
            IL_17FC: stloc.0    
            IL_17FD: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1802: ldarg.0    
            IL_1803: ldloc.s    V_26
            IL_1805: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_180A: ldarg.0    
            IL_180B: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1810: ldloca.s   V_26
            IL_1812: ldarg.0    
            IL_1813: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1818: leave      IL_3BC2
            IL_181D: ldarg.0    
            IL_181E: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1823: stloc.s    V_26
            IL_1825: ldarg.0    
            IL_1826: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_182B: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1831: ldarg.0    
            IL_1832: ldc.i4.m1  
            IL_1833: dup        
            IL_1834: stloc.0    
            IL_1835: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_183A: ldloca.s   V_26
            IL_183C: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1841: ldloc.1    
            IL_1842: ldloc.1    
            IL_1843: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1848: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_184D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1852: ldloc.1    
            IL_1853: ldloc.1    
            IL_1854: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1859: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_185E: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1863: ldloc.1    
            IL_1864: ldstr      "\r\n                            <div class=\"col-md-2 col-sm-2 col-xs-4\">\r\n                                "
            IL_1869: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_186E: ldloc.1    
            IL_186F: ldloc.1    
            IL_1870: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1875: ldstr      "input"
            IL_187A: ldc.i4.1   
            IL_187B: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996039565"
            IL_1880: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_26
            IL_1885: dup        
            IL_1886: brtrue.s   IL_189F
            IL_1888: pop        
            IL_1889: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_188E: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_26()
            IL_1894: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_1899: dup        
            IL_189A: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_26
            IL_189F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_18A4: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_18A9: ldloc.1    
            IL_18AA: ldloc.1    
            IL_18AB: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_18B0: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_18B5: ldloc.1    
            IL_18B6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_18BB: ldloc.1    
            IL_18BC: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_18C1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_18C6: ldloc.1    
            IL_18C7: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_18CC: ldloc.1    
            IL_18CD: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_18D2: ldloc.1    
            IL_18D3: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_18D8: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_18DD: call       void System.Type::GetTypeFromHandle
            IL_18E2: ldstr      "__model"
            IL_18E7: call       void System.Linq.Expressions.Expression::Parameter
            IL_18EC: stloc.2    
            IL_18ED: ldloc.2    
            IL_18EE: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ExpirationDate()
            IL_18F3: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_18F8: castclass  System.Reflection.MethodInfo
            IL_18FD: call       void System.Linq.Expressions.Expression::Property
            IL_1902: ldc.i4.1   
            IL_1903: newarr     System.Linq.Expressions.ParameterExpression
            IL_1908: dup        
            IL_1909: ldc.i4.0   
            IL_190A: ldloc.2    
            IL_190B: stelem.ref 
            IL_190C: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_1911: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1916: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_191B: ldloc.1    
            IL_191C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1921: ldstr      "asp-for"
            IL_1926: ldloc.1    
            IL_1927: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_192C: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_1931: ldc.i4.0   
            IL_1932: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1937: ldloc.1    
            IL_1938: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_193D: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_6
            IL_1942: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_1947: castclass  System.String
            IL_194C: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_1951: ldloc.1    
            IL_1952: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1957: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_6
            IL_195C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1961: ldloc.1    
            IL_1962: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute
            IL_1967: ldloc.1    
            IL_1968: ldloc.1    
            IL_1969: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute
            IL_196E: stfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_1973: ldloc.1    
            IL_1974: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1979: ldstr      "checked"
            IL_197E: ldloc.1    
            IL_197F: call       instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Html()
            IL_1984: ldloc.1    
            IL_1985: ldfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_198A: callvirt   void Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::Raw
            IL_198F: ldc.i4.3   
            IL_1990: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1995: ldloc.1    
            IL_1996: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_199B: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_2
            IL_19A0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_19A5: ldloc.1    
            IL_19A6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_19AB: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_7
            IL_19B0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_19B5: ldloc.1    
            IL_19B6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_19BB: ldloc.1    
            IL_19BC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_19C1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_19C6: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_19CB: stloc.s    V_27
            IL_19CD: ldloca.s   V_27
            IL_19CF: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_19D4: brtrue.s   IL_1A18
            IL_19D6: ldarg.0    
            IL_19D7: ldc.i4.s   24
            IL_19D9: dup        
            IL_19DA: stloc.0    
            IL_19DB: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_19E0: ldarg.0    
            IL_19E1: ldloc.s    V_27
            IL_19E3: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_19E8: ldarg.0    
            IL_19E9: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_19EE: ldloca.s   V_27
            IL_19F0: ldarg.0    
            IL_19F1: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_19F6: leave      IL_3BC2
            IL_19FB: ldarg.0    
            IL_19FC: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1A01: stloc.s    V_27
            IL_1A03: ldarg.0    
            IL_1A04: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1A09: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1A0F: ldarg.0    
            IL_1A10: ldc.i4.m1  
            IL_1A11: dup        
            IL_1A12: stloc.0    
            IL_1A13: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1A18: ldloca.s   V_27
            IL_1A1A: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1A1F: ldloc.1    
            IL_1A20: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1A25: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1A2A: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_1A2F: brtrue.s   IL_1A95
            IL_1A31: ldloc.1    
            IL_1A32: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1A37: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1A3C: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1A41: stloc.s    V_28
            IL_1A43: ldloca.s   V_28
            IL_1A45: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1A4A: brtrue.s   IL_1A8E
            IL_1A4C: ldarg.0    
            IL_1A4D: ldc.i4.s   25
            IL_1A4F: dup        
            IL_1A50: stloc.0    
            IL_1A51: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1A56: ldarg.0    
            IL_1A57: ldloc.s    V_28
            IL_1A59: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1A5E: ldarg.0    
            IL_1A5F: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1A64: ldloca.s   V_28
            IL_1A66: ldarg.0    
            IL_1A67: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1A6C: leave      IL_3BC2
            IL_1A71: ldarg.0    
            IL_1A72: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1A77: stloc.s    V_28
            IL_1A79: ldarg.0    
            IL_1A7A: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1A7F: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1A85: ldarg.0    
            IL_1A86: ldc.i4.m1  
            IL_1A87: dup        
            IL_1A88: stloc.0    
            IL_1A89: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1A8E: ldloca.s   V_28
            IL_1A90: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1A95: ldloc.1    
            IL_1A96: ldloc.1    
            IL_1A97: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1A9C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1AA1: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1AA6: ldloc.1    
            IL_1AA7: ldloc.1    
            IL_1AA8: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1AAD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_1AB2: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1AB7: ldloc.1    
            IL_1AB8: ldstr      "\r\n                                "
            IL_1ABD: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_1AC2: ldloc.1    
            IL_1AC3: ldloc.1    
            IL_1AC4: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1AC9: ldstr      "span"
            IL_1ACE: ldc.i4.0   
            IL_1ACF: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996041851"
            IL_1AD4: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_28
            IL_1AD9: dup        
            IL_1ADA: brtrue.s   IL_1AF3
            IL_1ADC: pop        
            IL_1ADD: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_1AE2: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_28()
            IL_1AE8: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_1AED: dup        
            IL_1AEE: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_28
            IL_1AF3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_1AF8: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1AFD: ldloc.1    
            IL_1AFE: ldloc.1    
            IL_1AFF: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>()
            IL_1B04: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1B09: ldloc.1    
            IL_1B0A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1B0F: ldloc.1    
            IL_1B10: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1B15: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_1B1A: ldloc.1    
            IL_1B1B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1B20: ldloc.1    
            IL_1B21: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_1B26: ldloc.1    
            IL_1B27: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_1B2C: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_1B31: call       void System.Type::GetTypeFromHandle
            IL_1B36: ldstr      "__model"
            IL_1B3B: call       void System.Linq.Expressions.Expression::Parameter
            IL_1B40: stloc.2    
            IL_1B41: ldloc.2    
            IL_1B42: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_ExpirationDate()
            IL_1B47: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_1B4C: castclass  System.Reflection.MethodInfo
            IL_1B51: call       void System.Linq.Expressions.Expression::Property
            IL_1B56: ldc.i4.1   
            IL_1B57: newarr     System.Linq.Expressions.ParameterExpression
            IL_1B5C: dup        
            IL_1B5D: ldc.i4.0   
            IL_1B5E: ldloc.2    
            IL_1B5F: stelem.ref 
            IL_1B60: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_1B65: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1B6A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::set_For
            IL_1B6F: ldloc.1    
            IL_1B70: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1B75: ldstr      "asp-validation-for"
            IL_1B7A: ldloc.1    
            IL_1B7B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1B80: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::get_For
            IL_1B85: ldc.i4.0   
            IL_1B86: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1B8B: ldloc.1    
            IL_1B8C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1B91: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
            IL_1B96: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1B9B: ldloc.1    
            IL_1B9C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1BA1: ldloc.1    
            IL_1BA2: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1BA7: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_1BAC: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1BB1: stloc.s    V_29
            IL_1BB3: ldloca.s   V_29
            IL_1BB5: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1BBA: brtrue.s   IL_1BFE
            IL_1BBC: ldarg.0    
            IL_1BBD: ldc.i4.s   26
            IL_1BBF: dup        
            IL_1BC0: stloc.0    
            IL_1BC1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1BC6: ldarg.0    
            IL_1BC7: ldloc.s    V_29
            IL_1BC9: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1BCE: ldarg.0    
            IL_1BCF: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1BD4: ldloca.s   V_29
            IL_1BD6: ldarg.0    
            IL_1BD7: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1BDC: leave      IL_3BC2
            IL_1BE1: ldarg.0    
            IL_1BE2: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1BE7: stloc.s    V_29
            IL_1BE9: ldarg.0    
            IL_1BEA: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1BEF: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1BF5: ldarg.0    
            IL_1BF6: ldc.i4.m1  
            IL_1BF7: dup        
            IL_1BF8: stloc.0    
            IL_1BF9: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1BFE: ldloca.s   V_29
            IL_1C00: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1C05: ldloc.1    
            IL_1C06: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1C0B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1C10: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_1C15: brtrue.s   IL_1C7B
            IL_1C17: ldloc.1    
            IL_1C18: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1C1D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1C22: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1C27: stloc.s    V_30
            IL_1C29: ldloca.s   V_30
            IL_1C2B: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1C30: brtrue.s   IL_1C74
            IL_1C32: ldarg.0    
            IL_1C33: ldc.i4.s   27
            IL_1C35: dup        
            IL_1C36: stloc.0    
            IL_1C37: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1C3C: ldarg.0    
            IL_1C3D: ldloc.s    V_30
            IL_1C3F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1C44: ldarg.0    
            IL_1C45: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1C4A: ldloca.s   V_30
            IL_1C4C: ldarg.0    
            IL_1C4D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1C52: leave      IL_3BC2
            IL_1C57: ldarg.0    
            IL_1C58: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1C5D: stloc.s    V_30
            IL_1C5F: ldarg.0    
            IL_1C60: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1C65: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1C6B: ldarg.0    
            IL_1C6C: ldc.i4.m1  
            IL_1C6D: dup        
            IL_1C6E: stloc.0    
            IL_1C6F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1C74: ldloca.s   V_30
            IL_1C76: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1C7B: ldloc.1    
            IL_1C7C: ldloc.1    
            IL_1C7D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1C82: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1C87: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1C8C: ldloc.1    
            IL_1C8D: ldloc.1    
            IL_1C8E: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1C93: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_1C98: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1C9D: ldloc.1    
            IL_1C9E: ldstr      "\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"Description\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Description</label>\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                "
            IL_1CA3: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_1CA8: ldloc.1    
            IL_1CA9: ldloc.1    
            IL_1CAA: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1CAF: ldstr      "input"
            IL_1CB4: ldc.i4.1   
            IL_1CB5: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996043908"
            IL_1CBA: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_30
            IL_1CBF: dup        
            IL_1CC0: brtrue.s   IL_1CD9
            IL_1CC2: pop        
            IL_1CC3: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_1CC8: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_30()
            IL_1CCE: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_1CD3: dup        
            IL_1CD4: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_30
            IL_1CD9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_1CDE: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1CE3: ldloc.1    
            IL_1CE4: ldloc.1    
            IL_1CE5: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_1CEA: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_1CEF: ldloc.1    
            IL_1CF0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1CF5: ldloc.1    
            IL_1CF6: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_1CFB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_1D00: ldloc.1    
            IL_1D01: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_1D06: ldloc.1    
            IL_1D07: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_1D0C: ldloc.1    
            IL_1D0D: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_1D12: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_1D17: call       void System.Type::GetTypeFromHandle
            IL_1D1C: ldstr      "__model"
            IL_1D21: call       void System.Linq.Expressions.Expression::Parameter
            IL_1D26: stloc.2    
            IL_1D27: ldloc.2    
            IL_1D28: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Description()
            IL_1D2D: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_1D32: castclass  System.Reflection.MethodInfo
            IL_1D37: call       void System.Linq.Expressions.Expression::Property
            IL_1D3C: ldc.i4.1   
            IL_1D3D: newarr     System.Linq.Expressions.ParameterExpression
            IL_1D42: dup        
            IL_1D43: ldc.i4.0   
            IL_1D44: ldloc.2    
            IL_1D45: stelem.ref 
            IL_1D46: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_1D4B: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1D50: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_1D55: ldloc.1    
            IL_1D56: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1D5B: ldstr      "asp-for"
            IL_1D60: ldloc.1    
            IL_1D61: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_1D66: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_1D6B: ldc.i4.0   
            IL_1D6C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1D71: ldloc.1    
            IL_1D72: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute
            IL_1D77: ldloc.1    
            IL_1D78: ldloc.1    
            IL_1D79: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute
            IL_1D7E: stfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_1D83: ldloc.1    
            IL_1D84: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1D89: ldstr      "checked"
            IL_1D8E: ldloc.1    
            IL_1D8F: call       instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Html()
            IL_1D94: ldloc.1    
            IL_1D95: ldfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_1D9A: callvirt   void Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::Raw
            IL_1D9F: ldc.i4.3   
            IL_1DA0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1DA5: ldloc.1    
            IL_1DA6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1DAB: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_2
            IL_1DB0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1DB5: ldloc.1    
            IL_1DB6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1DBB: ldloc.1    
            IL_1DBC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1DC1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_1DC6: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1DCB: stloc.s    V_31
            IL_1DCD: ldloca.s   V_31
            IL_1DCF: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1DD4: brtrue.s   IL_1E18
            IL_1DD6: ldarg.0    
            IL_1DD7: ldc.i4.s   28
            IL_1DD9: dup        
            IL_1DDA: stloc.0    
            IL_1DDB: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1DE0: ldarg.0    
            IL_1DE1: ldloc.s    V_31
            IL_1DE3: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1DE8: ldarg.0    
            IL_1DE9: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1DEE: ldloca.s   V_31
            IL_1DF0: ldarg.0    
            IL_1DF1: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1DF6: leave      IL_3BC2
            IL_1DFB: ldarg.0    
            IL_1DFC: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1E01: stloc.s    V_31
            IL_1E03: ldarg.0    
            IL_1E04: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1E09: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1E0F: ldarg.0    
            IL_1E10: ldc.i4.m1  
            IL_1E11: dup        
            IL_1E12: stloc.0    
            IL_1E13: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1E18: ldloca.s   V_31
            IL_1E1A: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1E1F: ldloc.1    
            IL_1E20: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1E25: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1E2A: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_1E2F: brtrue.s   IL_1E95
            IL_1E31: ldloc.1    
            IL_1E32: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1E37: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_1E3C: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1E41: stloc.s    V_32
            IL_1E43: ldloca.s   V_32
            IL_1E45: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1E4A: brtrue.s   IL_1E8E
            IL_1E4C: ldarg.0    
            IL_1E4D: ldc.i4.s   29
            IL_1E4F: dup        
            IL_1E50: stloc.0    
            IL_1E51: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1E56: ldarg.0    
            IL_1E57: ldloc.s    V_32
            IL_1E59: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1E5E: ldarg.0    
            IL_1E5F: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1E64: ldloca.s   V_32
            IL_1E66: ldarg.0    
            IL_1E67: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1E6C: leave      IL_3BC2
            IL_1E71: ldarg.0    
            IL_1E72: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1E77: stloc.s    V_32
            IL_1E79: ldarg.0    
            IL_1E7A: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1E7F: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1E85: ldarg.0    
            IL_1E86: ldc.i4.m1  
            IL_1E87: dup        
            IL_1E88: stloc.0    
            IL_1E89: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1E8E: ldloca.s   V_32
            IL_1E90: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_1E95: ldloc.1    
            IL_1E96: ldloc.1    
            IL_1E97: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1E9C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_1EA1: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_1EA6: ldloc.1    
            IL_1EA7: ldloc.1    
            IL_1EA8: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1EAD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_1EB2: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1EB7: ldloc.1    
            IL_1EB8: ldstr      "\r\n                                "
            IL_1EBD: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_1EC2: ldloc.1    
            IL_1EC3: ldloc.1    
            IL_1EC4: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_1EC9: ldstr      "span"
            IL_1ECE: ldc.i4.0   
            IL_1ECF: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996045888"
            IL_1ED4: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_32
            IL_1ED9: dup        
            IL_1EDA: brtrue.s   IL_1EF3
            IL_1EDC: pop        
            IL_1EDD: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_1EE2: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_32()
            IL_1EE8: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_1EED: dup        
            IL_1EEE: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_32
            IL_1EF3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_1EF8: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1EFD: ldloc.1    
            IL_1EFE: ldloc.1    
            IL_1EFF: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>()
            IL_1F04: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1F09: ldloc.1    
            IL_1F0A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1F0F: ldloc.1    
            IL_1F10: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1F15: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_1F1A: ldloc.1    
            IL_1F1B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1F20: ldloc.1    
            IL_1F21: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_1F26: ldloc.1    
            IL_1F27: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_1F2C: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_1F31: call       void System.Type::GetTypeFromHandle
            IL_1F36: ldstr      "__model"
            IL_1F3B: call       void System.Linq.Expressions.Expression::Parameter
            IL_1F40: stloc.2    
            IL_1F41: ldloc.2    
            IL_1F42: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Description()
            IL_1F47: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_1F4C: castclass  System.Reflection.MethodInfo
            IL_1F51: call       void System.Linq.Expressions.Expression::Property
            IL_1F56: ldc.i4.1   
            IL_1F57: newarr     System.Linq.Expressions.ParameterExpression
            IL_1F5C: dup        
            IL_1F5D: ldc.i4.0   
            IL_1F5E: ldloc.2    
            IL_1F5F: stelem.ref 
            IL_1F60: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_1F65: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_1F6A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::set_For
            IL_1F6F: ldloc.1    
            IL_1F70: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1F75: ldstr      "asp-validation-for"
            IL_1F7A: ldloc.1    
            IL_1F7B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_1F80: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::get_For
            IL_1F85: ldc.i4.0   
            IL_1F86: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_1F8B: ldloc.1    
            IL_1F8C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1F91: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
            IL_1F96: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_1F9B: ldloc.1    
            IL_1F9C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_1FA1: ldloc.1    
            IL_1FA2: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_1FA7: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_1FAC: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_1FB1: stloc.s    V_33
            IL_1FB3: ldloca.s   V_33
            IL_1FB5: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_1FBA: brtrue.s   IL_1FFE
            IL_1FBC: ldarg.0    
            IL_1FBD: ldc.i4.s   30
            IL_1FBF: dup        
            IL_1FC0: stloc.0    
            IL_1FC1: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1FC6: ldarg.0    
            IL_1FC7: ldloc.s    V_33
            IL_1FC9: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1FCE: ldarg.0    
            IL_1FCF: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_1FD4: ldloca.s   V_33
            IL_1FD6: ldarg.0    
            IL_1FD7: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_1FDC: leave      IL_3BC2
            IL_1FE1: ldarg.0    
            IL_1FE2: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1FE7: stloc.s    V_33
            IL_1FE9: ldarg.0    
            IL_1FEA: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_1FEF: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_1FF5: ldarg.0    
            IL_1FF6: ldc.i4.m1  
            IL_1FF7: dup        
            IL_1FF8: stloc.0    
            IL_1FF9: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_1FFE: ldloca.s   V_33
            IL_2000: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2005: ldloc.1    
            IL_2006: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_200B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2010: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2015: brtrue.s   IL_207B
            IL_2017: ldloc.1    
            IL_2018: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_201D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_2022: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2027: stloc.s    V_34
            IL_2029: ldloca.s   V_34
            IL_202B: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2030: brtrue.s   IL_2074
            IL_2032: ldarg.0    
            IL_2033: ldc.i4.s   31
            IL_2035: dup        
            IL_2036: stloc.0    
            IL_2037: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_203C: ldarg.0    
            IL_203D: ldloc.s    V_34
            IL_203F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2044: ldarg.0    
            IL_2045: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_204A: ldloca.s   V_34
            IL_204C: ldarg.0    
            IL_204D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_2052: leave      IL_3BC2
            IL_2057: ldarg.0    
            IL_2058: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_205D: stloc.s    V_34
            IL_205F: ldarg.0    
            IL_2060: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2065: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_206B: ldarg.0    
            IL_206C: ldc.i4.m1  
            IL_206D: dup        
            IL_206E: stloc.0    
            IL_206F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2074: ldloca.s   V_34
            IL_2076: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_207B: ldloc.1    
            IL_207C: ldloc.1    
            IL_207D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2082: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2087: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_208C: ldloc.1    
            IL_208D: ldloc.1    
            IL_208E: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2093: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2098: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_209D: ldloc.1    
            IL_209E: ldstr      "\r\n                            </div>\r\n                        </div>\r\n\r\n                        <!--Roles -->\r\n                    <div class=\"form-group mt-3\">\r\n                            <label>Roles</label>\r\n                            Model.Roles\r\n                            <div class=\"form-check ms-3\">\r\n                                "
            IL_20A3: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_20A8: ldloc.1    
            IL_20A9: ldloc.1    
            IL_20AA: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_20AF: ldstr      "input"
            IL_20B4: ldc.i4.2   
            IL_20B5: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996047935"
            IL_20BA: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_34
            IL_20BF: dup        
            IL_20C0: brtrue.s   IL_20D9
            IL_20C2: pop        
            IL_20C3: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_20C8: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_34()
            IL_20CE: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_20D3: dup        
            IL_20D4: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_34
            IL_20D9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_20DE: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_20E3: ldloc.1    
            IL_20E4: ldloc.1    
            IL_20E5: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_20EA: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_20EF: ldloc.1    
            IL_20F0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_20F5: ldloc.1    
            IL_20F6: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_20FB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_2100: ldloc.1    
            IL_2101: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2106: ldloc.1    
            IL_2107: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_210C: ldloc.1    
            IL_210D: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_2112: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_2117: call       void System.Type::GetTypeFromHandle
            IL_211C: ldstr      "__model"
            IL_2121: call       void System.Linq.Expressions.Expression::Parameter
            IL_2126: stloc.2    
            IL_2127: ldloc.2    
            IL_2128: ldtoken    instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_212D: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2132: castclass  System.Reflection.MethodInfo
            IL_2137: call       void System.Linq.Expressions.Expression::Property
            IL_213C: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_IsAdministrator()
            IL_2141: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2146: castclass  System.Reflection.MethodInfo
            IL_214B: call       void System.Linq.Expressions.Expression::Property
            IL_2150: ldc.i4.1   
            IL_2151: newarr     System.Linq.Expressions.ParameterExpression
            IL_2156: dup        
            IL_2157: ldc.i4.0   
            IL_2158: ldloc.2    
            IL_2159: stelem.ref 
            IL_215A: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_215F: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_2164: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_2169: ldloc.1    
            IL_216A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_216F: ldstr      "asp-for"
            IL_2174: ldloc.1    
            IL_2175: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_217A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_217F: ldc.i4.0   
            IL_2180: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2185: ldloc.1    
            IL_2186: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_218B: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_2190: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_2195: castclass  System.String
            IL_219A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_219F: ldloc.1    
            IL_21A0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_21A5: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_21AA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_21AF: ldloc.1    
            IL_21B0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_21B5: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_9
            IL_21BA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_21BF: ldloc.1    
            IL_21C0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_21C5: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_10
            IL_21CA: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_21CF: castclass  System.String
            IL_21D4: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value
            IL_21D9: ldloc.1    
            IL_21DA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_21DF: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_10
            IL_21E4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_21E9: ldloc.1    
            IL_21EA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_21EF: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_11
            IL_21F4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_21F9: ldloc.1    
            IL_21FA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_21FF: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_12
            IL_2204: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_2209: ldloc.1    
            IL_220A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_220F: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_13
            IL_2214: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_2219: ldloc.1    
            IL_221A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_221F: ldloc.1    
            IL_2220: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2225: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_222A: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_222F: stloc.s    V_35
            IL_2231: ldloca.s   V_35
            IL_2233: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2238: brtrue.s   IL_227C
            IL_223A: ldarg.0    
            IL_223B: ldc.i4.s   32
            IL_223D: dup        
            IL_223E: stloc.0    
            IL_223F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2244: ldarg.0    
            IL_2245: ldloc.s    V_35
            IL_2247: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_224C: ldarg.0    
            IL_224D: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2252: ldloca.s   V_35
            IL_2254: ldarg.0    
            IL_2255: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_225A: leave      IL_3BC2
            IL_225F: ldarg.0    
            IL_2260: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2265: stloc.s    V_35
            IL_2267: ldarg.0    
            IL_2268: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_226D: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2273: ldarg.0    
            IL_2274: ldc.i4.m1  
            IL_2275: dup        
            IL_2276: stloc.0    
            IL_2277: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_227C: ldloca.s   V_35
            IL_227E: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2283: ldloc.1    
            IL_2284: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2289: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_228E: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2293: brtrue.s   IL_22F9
            IL_2295: ldloc.1    
            IL_2296: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_229B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_22A0: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_22A5: stloc.s    V_36
            IL_22A7: ldloca.s   V_36
            IL_22A9: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_22AE: brtrue.s   IL_22F2
            IL_22B0: ldarg.0    
            IL_22B1: ldc.i4.s   33
            IL_22B3: dup        
            IL_22B4: stloc.0    
            IL_22B5: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_22BA: ldarg.0    
            IL_22BB: ldloc.s    V_36
            IL_22BD: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_22C2: ldarg.0    
            IL_22C3: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_22C8: ldloca.s   V_36
            IL_22CA: ldarg.0    
            IL_22CB: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_22D0: leave      IL_3BC2
            IL_22D5: ldarg.0    
            IL_22D6: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_22DB: stloc.s    V_36
            IL_22DD: ldarg.0    
            IL_22DE: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_22E3: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_22E9: ldarg.0    
            IL_22EA: ldc.i4.m1  
            IL_22EB: dup        
            IL_22EC: stloc.0    
            IL_22ED: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_22F2: ldloca.s   V_36
            IL_22F4: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_22F9: ldloc.1    
            IL_22FA: ldloc.1    
            IL_22FB: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2300: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2305: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_230A: ldloc.1    
            IL_230B: ldloc.1    
            IL_230C: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2311: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2316: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_231B: ldloc.1    
            IL_231C: ldstr      "\r\n                                <label for=\"isAdministratorYes\" class=\"form-check-label\">Administrator</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                "
            IL_2321: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2326: ldloc.1    
            IL_2327: ldloc.1    
            IL_2328: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_232D: ldstr      "input"
            IL_2332: ldc.i4.2   
            IL_2333: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996050513"
            IL_2338: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_36
            IL_233D: dup        
            IL_233E: brtrue.s   IL_2357
            IL_2340: pop        
            IL_2341: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_2346: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_36()
            IL_234C: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_2351: dup        
            IL_2352: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_36
            IL_2357: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_235C: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2361: ldloc.1    
            IL_2362: ldloc.1    
            IL_2363: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_2368: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_236D: ldloc.1    
            IL_236E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2373: ldloc.1    
            IL_2374: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2379: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_237E: ldloc.1    
            IL_237F: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2384: ldloc.1    
            IL_2385: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_238A: ldloc.1    
            IL_238B: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_2390: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_2395: call       void System.Type::GetTypeFromHandle
            IL_239A: ldstr      "__model"
            IL_239F: call       void System.Linq.Expressions.Expression::Parameter
            IL_23A4: stloc.2    
            IL_23A5: ldloc.2    
            IL_23A6: ldtoken    instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_23AB: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_23B0: castclass  System.Reflection.MethodInfo
            IL_23B5: call       void System.Linq.Expressions.Expression::Property
            IL_23BA: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_IsAdministrator()
            IL_23BF: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_23C4: castclass  System.Reflection.MethodInfo
            IL_23C9: call       void System.Linq.Expressions.Expression::Property
            IL_23CE: ldc.i4.1   
            IL_23CF: newarr     System.Linq.Expressions.ParameterExpression
            IL_23D4: dup        
            IL_23D5: ldc.i4.0   
            IL_23D6: ldloc.2    
            IL_23D7: stelem.ref 
            IL_23D8: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_23DD: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_23E2: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_23E7: ldloc.1    
            IL_23E8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_23ED: ldstr      "asp-for"
            IL_23F2: ldloc.1    
            IL_23F3: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_23F8: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_23FD: ldc.i4.0   
            IL_23FE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2403: ldloc.1    
            IL_2404: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2409: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_240E: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_2413: castclass  System.String
            IL_2418: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_241D: ldloc.1    
            IL_241E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2423: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_2428: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_242D: ldloc.1    
            IL_242E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2433: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_9
            IL_2438: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_243D: ldloc.1    
            IL_243E: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2443: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_14
            IL_2448: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_244D: castclass  System.String
            IL_2452: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value
            IL_2457: ldloc.1    
            IL_2458: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_245D: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_14
            IL_2462: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2467: ldloc.1    
            IL_2468: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_246D: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_15
            IL_2472: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_2477: ldloc.1    
            IL_2478: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_247D: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_12
            IL_2482: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_2487: ldloc.1    
            IL_2488: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_248D: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_16
            IL_2492: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_2497: ldloc.1    
            IL_2498: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_249D: ldloc.1    
            IL_249E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_24A3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_24A8: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_24AD: stloc.s    V_37
            IL_24AF: ldloca.s   V_37
            IL_24B1: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_24B6: brtrue.s   IL_24FA
            IL_24B8: ldarg.0    
            IL_24B9: ldc.i4.s   34
            IL_24BB: dup        
            IL_24BC: stloc.0    
            IL_24BD: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_24C2: ldarg.0    
            IL_24C3: ldloc.s    V_37
            IL_24C5: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_24CA: ldarg.0    
            IL_24CB: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_24D0: ldloca.s   V_37
            IL_24D2: ldarg.0    
            IL_24D3: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_24D8: leave      IL_3BC2
            IL_24DD: ldarg.0    
            IL_24DE: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_24E3: stloc.s    V_37
            IL_24E5: ldarg.0    
            IL_24E6: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_24EB: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_24F1: ldarg.0    
            IL_24F2: ldc.i4.m1  
            IL_24F3: dup        
            IL_24F4: stloc.0    
            IL_24F5: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_24FA: ldloca.s   V_37
            IL_24FC: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2501: ldloc.1    
            IL_2502: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2507: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_250C: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2511: brtrue.s   IL_2577
            IL_2513: ldloc.1    
            IL_2514: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2519: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_251E: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2523: stloc.s    V_38
            IL_2525: ldloca.s   V_38
            IL_2527: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_252C: brtrue.s   IL_2570
            IL_252E: ldarg.0    
            IL_252F: ldc.i4.s   35
            IL_2531: dup        
            IL_2532: stloc.0    
            IL_2533: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2538: ldarg.0    
            IL_2539: ldloc.s    V_38
            IL_253B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2540: ldarg.0    
            IL_2541: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2546: ldloca.s   V_38
            IL_2548: ldarg.0    
            IL_2549: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_254E: leave      IL_3BC2
            IL_2553: ldarg.0    
            IL_2554: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2559: stloc.s    V_38
            IL_255B: ldarg.0    
            IL_255C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2561: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2567: ldarg.0    
            IL_2568: ldc.i4.m1  
            IL_2569: dup        
            IL_256A: stloc.0    
            IL_256B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2570: ldloca.s   V_38
            IL_2572: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2577: ldloc.1    
            IL_2578: ldloc.1    
            IL_2579: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_257E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2583: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_2588: ldloc.1    
            IL_2589: ldloc.1    
            IL_258A: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_258F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2594: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2599: ldloc.1    
            IL_259A: ldstr      "\r\n                                <label for=\"isAdministratorNo\" class=\"form-check-label\">Custom</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseRoles\""
            IL_259F: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_25A4: ldloc.1    
            IL_25A5: ldstr      "class"
            IL_25AA: ldstr      " class=\""
            IL_25AF: ldc.i4     5644
            IL_25B4: ldstr      "\""
            IL_25B9: ldc.i4     5735
            IL_25BE: ldc.i4.3   
            IL_25BF: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute
            IL_25C4: ldloc.1    
            IL_25C5: ldstr      ""
            IL_25CA: ldc.i4     5652
            IL_25CF: ldstr      "panel-collapse"
            IL_25D4: ldc.i4     5652
            IL_25D9: ldc.i4.s   14
            IL_25DB: ldc.i4.1   
            IL_25DC: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_25E1: ldloc.1    
            IL_25E2: ldstr      " "
            IL_25E7: ldc.i4     5666
            IL_25EC: ldstr      "collapse"
            IL_25F1: ldc.i4     5667
            IL_25F6: ldc.i4.s   9
            IL_25F8: ldc.i4.1   
            IL_25F9: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_25FE: ldloc.1    
            IL_25FF: ldstr      " "
            IL_2604: ldc.i4     5675
            IL_2609: ldloc.1    
            IL_260A: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_260F: callvirt   instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_2614: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_IsAdministrator()
            IL_2619: ldstr      "N"
            IL_261E: call       void System.String::op_Equality
            IL_2623: brtrue.s   IL_262C
            IL_2625: ldsfld     String System.String::Empty
            IL_262A: br.s       IL_2631
            IL_262C: ldstr      "show"
            IL_2631: ldc.i4     5676
            IL_2636: ldc.i4.s   59
            IL_2638: ldc.i4.0   
            IL_2639: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_263E: ldloc.1    
            IL_263F: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute
            IL_2644: ldloc.1    
            IL_2645: ldstr      ">\r\n                                        <div class=\"form-group mt-1 col-6\">\r\n"
            IL_264A: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_264F: ldarg.0    
            IL_2650: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_2655: ldc.i4.m1  
            IL_2656: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_265B: ldarg.0    
            IL_265C: ldloc.1    
            IL_265D: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_2662: callvirt   instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_2667: callvirt   instance System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_Items()
            IL_266C: ldsfld     System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, String> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_48
            IL_2671: dup        
            IL_2672: brtrue.s   IL_268B
            IL_2674: pop        
            IL_2675: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_267A: ldftn      instance String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_48(class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel)
            IL_2680: newobj     void System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, String>::.ctor
            IL_2685: dup        
            IL_2686: stsfld     System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, String> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_48
            IL_268B: call       System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<!!1, !!0>> System.Linq.Enumerable::GroupBy<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, String>(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0, !!1>)
            IL_2690: callvirt   void System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>>::GetEnumerator
            IL_2695: stfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_269A: nop        
            IL_269B: ldloc.0    
            IL_269C: ldc.i4.s   36
            IL_269E: sub        
            IL_269F: ldc.i4.5   
            IL_26A0: ble.un.s   IL_26E4
            IL_26A2: br         IL_2F8F
            IL_26A7: ldarg.0    
            IL_26A8: ldfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_26AD: callvirt   void System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>>::get_Current
            IL_26B2: stloc.s    V_39
            IL_26B4: ldloc.1    
            IL_26B5: ldstr      "                                                    <fieldset class=\"border mb-2 p-2\">\r\n                                                        <legend class=\"w-auto px-2 text-secondary h6\">"
            IL_26BA: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_26BF: ldloc.1    
            IL_26C0: ldloc.s    V_39
            IL_26C2: callvirt   void System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::get_Key
            IL_26C7: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_26CC: ldloc.1    
            IL_26CD: ldstr      "</legend>\r\n                                                        <div class=\"row\">\r\n"
            IL_26D2: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_26D7: ldarg.0    
            IL_26D8: ldloc.s    V_39
            IL_26DA: callvirt   void System.Collections.Generic.IEnumerable`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::GetEnumerator
            IL_26DF: stfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_26E4: nop        
            IL_26E5: ldloc.0    
            IL_26E6: ldc.i4.s   36
            IL_26E8: sub        
            IL_26E9: switch     (IL_2960, IL_29D6, IL_2BF6, IL_2C6C, IL_2E8C, IL_2F02)
            IL_2706: br         IL_2F53
            IL_270B: ldarg.0    
            IL_270C: ldfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_2711: callvirt   void System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::get_Current
            IL_2716: stloc.s    V_40
            IL_2718: ldarg.0    
            IL_2719: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_271E: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_2723: stloc.s    V_41
            IL_2725: ldarg.0    
            IL_2726: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_272B: ldloc.s    V_41
            IL_272D: ldc.i4.1   
            IL_272E: add        
            IL_272F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_2734: ldloc.1    
            IL_2735: ldstr      "                                                                <div class=\"col-4\">\r\n                                                                    "
            IL_273A: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_273F: ldloc.1    
            IL_2740: ldloc.s    V_40
            IL_2742: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel::get_Title()
            IL_2747: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_274C: ldloc.1    
            IL_274D: ldstr      "\r\n                                                                    <label class=\"switch mt-1 me-1\">\r\n                                                                        "
            IL_2752: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2757: ldloc.1    
            IL_2758: ldloc.1    
            IL_2759: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_275E: ldstr      "input"
            IL_2763: ldc.i4.2   
            IL_2764: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996056009"
            IL_2769: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_49
            IL_276E: dup        
            IL_276F: brtrue.s   IL_2788
            IL_2771: pop        
            IL_2772: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_2777: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_49()
            IL_277D: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_2782: dup        
            IL_2783: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_49
            IL_2788: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_278D: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2792: ldloc.1    
            IL_2793: ldloc.1    
            IL_2794: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_2799: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_279E: ldloc.1    
            IL_279F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_27A4: ldloc.1    
            IL_27A5: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_27AA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_27AF: ldloc.1    
            IL_27B0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_27B5: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_17
            IL_27BA: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_27BF: castclass  System.String
            IL_27C4: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_27C9: ldloc.1    
            IL_27CA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_27CF: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_17
            IL_27D4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_27D9: ldloc.1    
            IL_27DA: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_27DF: ldloc.1    
            IL_27E0: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_27E5: ldloc.1    
            IL_27E6: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_27EB: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_27F0: call       void System.Type::GetTypeFromHandle
            IL_27F5: ldstr      "__model"
            IL_27FA: call       void System.Linq.Expressions.Expression::Parameter
            IL_27FF: stloc.2    
            IL_2800: ldloc.1    
            IL_2801: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create
            IL_2806: call       void System.Type::GetTypeFromHandle
            IL_280B: call       void System.Linq.Expressions.Expression::Constant
            IL_2810: ldtoken    void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_2815: ldtoken    Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
            IL_281A: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_281F: castclass  System.Reflection.MethodInfo
            IL_2824: call       void System.Linq.Expressions.Expression::Property
            IL_2829: ldtoken    instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_282E: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2833: castclass  System.Reflection.MethodInfo
            IL_2838: call       void System.Linq.Expressions.Expression::Property
            IL_283D: ldtoken    instance System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_Items()
            IL_2842: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2847: castclass  System.Reflection.MethodInfo
            IL_284C: call       void System.Linq.Expressions.Expression::Property
            IL_2851: ldtoken    void System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::get_Item
            IL_2856: ldtoken    System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>
            IL_285B: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2860: castclass  System.Reflection.MethodInfo
            IL_2865: ldc.i4.1   
            IL_2866: newarr     System.Linq.Expressions.Expression
            IL_286B: dup        
            IL_286C: ldc.i4.0   
            IL_286D: ldarg.0    
            IL_286E: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_2873: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0
            IL_2878: call       void System.Type::GetTypeFromHandle
            IL_287D: call       void System.Linq.Expressions.Expression::Constant
            IL_2882: ldtoken    Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_2887: call       void System.Reflection.FieldInfo::GetFieldFromHandle
            IL_288C: call       void System.Linq.Expressions.Expression::Field
            IL_2891: stelem.ref 
            IL_2892: call       void System.Linq.Expressions.Expression::Call
            IL_2897: ldtoken    instance Boolean Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel::get_IsSelected()
            IL_289C: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_28A1: castclass  System.Reflection.MethodInfo
            IL_28A6: call       void System.Linq.Expressions.Expression::Property
            IL_28AB: ldc.i4.1   
            IL_28AC: newarr     System.Linq.Expressions.ParameterExpression
            IL_28B1: dup        
            IL_28B2: ldc.i4.0   
            IL_28B3: ldloc.2    
            IL_28B4: stelem.ref 
            IL_28B5: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, Boolean>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_28BA: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, Boolean>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_28BF: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_28C4: ldloc.1    
            IL_28C5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_28CA: ldstr      "asp-for"
            IL_28CF: ldloc.1    
            IL_28D0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_28D5: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_28DA: ldc.i4.0   
            IL_28DB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_28E0: ldloc.1    
            IL_28E1: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_28E6: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_18
            IL_28EB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_28F0: ldloc.1    
            IL_28F1: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_28F6: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_19
            IL_28FB: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_2900: castclass  System.String
            IL_2905: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value
            IL_290A: ldloc.1    
            IL_290B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2910: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_19
            IL_2915: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_291A: ldloc.1    
            IL_291B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_2920: ldloc.1    
            IL_2921: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2926: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_292B: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2930: stloc.s    V_42
            IL_2932: ldloca.s   V_42
            IL_2934: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2939: brtrue.s   IL_297D
            IL_293B: ldarg.0    
            IL_293C: ldc.i4.s   36
            IL_293E: dup        
            IL_293F: stloc.0    
            IL_2940: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2945: ldarg.0    
            IL_2946: ldloc.s    V_42
            IL_2948: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_294D: ldarg.0    
            IL_294E: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2953: ldloca.s   V_42
            IL_2955: ldarg.0    
            IL_2956: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_295B: leave      IL_3BC2
            IL_2960: ldarg.0    
            IL_2961: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2966: stloc.s    V_42
            IL_2968: ldarg.0    
            IL_2969: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_296E: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2974: ldarg.0    
            IL_2975: ldc.i4.m1  
            IL_2976: dup        
            IL_2977: stloc.0    
            IL_2978: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_297D: ldloca.s   V_42
            IL_297F: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2984: ldloc.1    
            IL_2985: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_298A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_298F: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2994: brtrue.s   IL_29FA
            IL_2996: ldloc.1    
            IL_2997: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_299C: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_29A1: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_29A6: stloc.s    V_43
            IL_29A8: ldloca.s   V_43
            IL_29AA: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_29AF: brtrue.s   IL_29F3
            IL_29B1: ldarg.0    
            IL_29B2: ldc.i4.s   37
            IL_29B4: dup        
            IL_29B5: stloc.0    
            IL_29B6: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_29BB: ldarg.0    
            IL_29BC: ldloc.s    V_43
            IL_29BE: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_29C3: ldarg.0    
            IL_29C4: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_29C9: ldloca.s   V_43
            IL_29CB: ldarg.0    
            IL_29CC: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_29D1: leave      IL_3BC2
            IL_29D6: ldarg.0    
            IL_29D7: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_29DC: stloc.s    V_43
            IL_29DE: ldarg.0    
            IL_29DF: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_29E4: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_29EA: ldarg.0    
            IL_29EB: ldc.i4.m1  
            IL_29EC: dup        
            IL_29ED: stloc.0    
            IL_29EE: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_29F3: ldloca.s   V_43
            IL_29F5: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_29FA: ldloc.1    
            IL_29FB: ldloc.1    
            IL_29FC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2A01: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2A06: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_2A0B: ldloc.1    
            IL_2A0C: ldloc.1    
            IL_2A0D: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2A12: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2A17: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2A1C: ldloc.1    
            IL_2A1D: ldstr      "\r\n                                                                        "
            IL_2A22: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2A27: ldloc.1    
            IL_2A28: ldloc.1    
            IL_2A29: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2A2E: ldstr      "input"
            IL_2A33: ldc.i4.2   
            IL_2A34: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996058152"
            IL_2A39: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_51
            IL_2A3E: dup        
            IL_2A3F: brtrue.s   IL_2A58
            IL_2A41: pop        
            IL_2A42: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_2A47: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_51()
            IL_2A4D: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_2A52: dup        
            IL_2A53: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_51
            IL_2A58: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_2A5D: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2A62: ldloc.1    
            IL_2A63: ldloc.1    
            IL_2A64: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_2A69: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2A6E: ldloc.1    
            IL_2A6F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2A74: ldloc.1    
            IL_2A75: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2A7A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_2A7F: ldloc.1    
            IL_2A80: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2A85: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_2A8A: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_2A8F: castclass  System.String
            IL_2A94: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_2A99: ldloc.1    
            IL_2A9A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2A9F: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_2AA4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2AA9: ldloc.1    
            IL_2AAA: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2AAF: ldloc.1    
            IL_2AB0: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_2AB5: ldloc.1    
            IL_2AB6: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_2ABB: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_2AC0: call       void System.Type::GetTypeFromHandle
            IL_2AC5: ldstr      "__model"
            IL_2ACA: call       void System.Linq.Expressions.Expression::Parameter
            IL_2ACF: stloc.2    
            IL_2AD0: ldloc.1    
            IL_2AD1: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create
            IL_2AD6: call       void System.Type::GetTypeFromHandle
            IL_2ADB: call       void System.Linq.Expressions.Expression::Constant
            IL_2AE0: ldtoken    void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_2AE5: ldtoken    Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
            IL_2AEA: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2AEF: castclass  System.Reflection.MethodInfo
            IL_2AF4: call       void System.Linq.Expressions.Expression::Property
            IL_2AF9: ldtoken    instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_2AFE: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2B03: castclass  System.Reflection.MethodInfo
            IL_2B08: call       void System.Linq.Expressions.Expression::Property
            IL_2B0D: ldtoken    instance System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_Items()
            IL_2B12: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2B17: castclass  System.Reflection.MethodInfo
            IL_2B1C: call       void System.Linq.Expressions.Expression::Property
            IL_2B21: ldtoken    void System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::get_Item
            IL_2B26: ldtoken    System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>
            IL_2B2B: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2B30: castclass  System.Reflection.MethodInfo
            IL_2B35: ldc.i4.1   
            IL_2B36: newarr     System.Linq.Expressions.Expression
            IL_2B3B: dup        
            IL_2B3C: ldc.i4.0   
            IL_2B3D: ldarg.0    
            IL_2B3E: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_2B43: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0
            IL_2B48: call       void System.Type::GetTypeFromHandle
            IL_2B4D: call       void System.Linq.Expressions.Expression::Constant
            IL_2B52: ldtoken    Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_2B57: call       void System.Reflection.FieldInfo::GetFieldFromHandle
            IL_2B5C: call       void System.Linq.Expressions.Expression::Field
            IL_2B61: stelem.ref 
            IL_2B62: call       void System.Linq.Expressions.Expression::Call
            IL_2B67: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel::get_Name()
            IL_2B6C: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2B71: castclass  System.Reflection.MethodInfo
            IL_2B76: call       void System.Linq.Expressions.Expression::Property
            IL_2B7B: ldc.i4.1   
            IL_2B7C: newarr     System.Linq.Expressions.ParameterExpression
            IL_2B81: dup        
            IL_2B82: ldc.i4.0   
            IL_2B83: ldloc.2    
            IL_2B84: stelem.ref 
            IL_2B85: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_2B8A: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_2B8F: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_2B94: ldloc.1    
            IL_2B95: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2B9A: ldstr      "asp-for"
            IL_2B9F: ldloc.1    
            IL_2BA0: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2BA5: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_2BAA: ldc.i4.0   
            IL_2BAB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2BB0: ldloc.1    
            IL_2BB1: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_2BB6: ldloc.1    
            IL_2BB7: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2BBC: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_2BC1: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2BC6: stloc.s    V_44
            IL_2BC8: ldloca.s   V_44
            IL_2BCA: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2BCF: brtrue.s   IL_2C13
            IL_2BD1: ldarg.0    
            IL_2BD2: ldc.i4.s   38
            IL_2BD4: dup        
            IL_2BD5: stloc.0    
            IL_2BD6: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2BDB: ldarg.0    
            IL_2BDC: ldloc.s    V_44
            IL_2BDE: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2BE3: ldarg.0    
            IL_2BE4: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2BE9: ldloca.s   V_44
            IL_2BEB: ldarg.0    
            IL_2BEC: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_2BF1: leave      IL_3BC2
            IL_2BF6: ldarg.0    
            IL_2BF7: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2BFC: stloc.s    V_44
            IL_2BFE: ldarg.0    
            IL_2BFF: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2C04: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2C0A: ldarg.0    
            IL_2C0B: ldc.i4.m1  
            IL_2C0C: dup        
            IL_2C0D: stloc.0    
            IL_2C0E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2C13: ldloca.s   V_44
            IL_2C15: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2C1A: ldloc.1    
            IL_2C1B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2C20: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2C25: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2C2A: brtrue.s   IL_2C90
            IL_2C2C: ldloc.1    
            IL_2C2D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2C32: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_2C37: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2C3C: stloc.s    V_45
            IL_2C3E: ldloca.s   V_45
            IL_2C40: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2C45: brtrue.s   IL_2C89
            IL_2C47: ldarg.0    
            IL_2C48: ldc.i4.s   39
            IL_2C4A: dup        
            IL_2C4B: stloc.0    
            IL_2C4C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2C51: ldarg.0    
            IL_2C52: ldloc.s    V_45
            IL_2C54: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2C59: ldarg.0    
            IL_2C5A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2C5F: ldloca.s   V_45
            IL_2C61: ldarg.0    
            IL_2C62: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_2C67: leave      IL_3BC2
            IL_2C6C: ldarg.0    
            IL_2C6D: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2C72: stloc.s    V_45
            IL_2C74: ldarg.0    
            IL_2C75: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2C7A: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2C80: ldarg.0    
            IL_2C81: ldc.i4.m1  
            IL_2C82: dup        
            IL_2C83: stloc.0    
            IL_2C84: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2C89: ldloca.s   V_45
            IL_2C8B: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2C90: ldloc.1    
            IL_2C91: ldloc.1    
            IL_2C92: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2C97: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2C9C: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_2CA1: ldloc.1    
            IL_2CA2: ldloc.1    
            IL_2CA3: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2CA8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2CAD: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2CB2: ldloc.1    
            IL_2CB3: ldstr      "\r\n                                                                        "
            IL_2CB8: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2CBD: ldloc.1    
            IL_2CBE: ldloc.1    
            IL_2CBF: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2CC4: ldstr      "input"
            IL_2CC9: ldc.i4.2   
            IL_2CCA: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996059989"
            IL_2CCF: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_53
            IL_2CD4: dup        
            IL_2CD5: brtrue.s   IL_2CEE
            IL_2CD7: pop        
            IL_2CD8: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_2CDD: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_53()
            IL_2CE3: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_2CE8: dup        
            IL_2CE9: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_53
            IL_2CEE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_2CF3: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2CF8: ldloc.1    
            IL_2CF9: ldloc.1    
            IL_2CFA: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_2CFF: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2D04: ldloc.1    
            IL_2D05: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2D0A: ldloc.1    
            IL_2D0B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2D10: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_2D15: ldloc.1    
            IL_2D16: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2D1B: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_2D20: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_2D25: castclass  System.String
            IL_2D2A: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_2D2F: ldloc.1    
            IL_2D30: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2D35: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_0
            IL_2D3A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2D3F: ldloc.1    
            IL_2D40: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2D45: ldloc.1    
            IL_2D46: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_2D4B: ldloc.1    
            IL_2D4C: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_2D51: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_2D56: call       void System.Type::GetTypeFromHandle
            IL_2D5B: ldstr      "__model"
            IL_2D60: call       void System.Linq.Expressions.Expression::Parameter
            IL_2D65: stloc.2    
            IL_2D66: ldloc.1    
            IL_2D67: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create
            IL_2D6C: call       void System.Type::GetTypeFromHandle
            IL_2D71: call       void System.Linq.Expressions.Expression::Constant
            IL_2D76: ldtoken    void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_2D7B: ldtoken    Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>
            IL_2D80: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2D85: castclass  System.Reflection.MethodInfo
            IL_2D8A: call       void System.Linq.Expressions.Expression::Property
            IL_2D8F: ldtoken    instance class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Roles()
            IL_2D94: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2D99: castclass  System.Reflection.MethodInfo
            IL_2D9E: call       void System.Linq.Expressions.Expression::Property
            IL_2DA3: ldtoken    instance System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RolesViewModel::get_Items()
            IL_2DA8: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2DAD: castclass  System.Reflection.MethodInfo
            IL_2DB2: call       void System.Linq.Expressions.Expression::Property
            IL_2DB7: ldtoken    void System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>::get_Item
            IL_2DBC: ldtoken    System.Collections.Generic.List`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>
            IL_2DC1: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2DC6: castclass  System.Reflection.MethodInfo
            IL_2DCB: ldc.i4.1   
            IL_2DCC: newarr     System.Linq.Expressions.Expression
            IL_2DD1: dup        
            IL_2DD2: ldc.i4.0   
            IL_2DD3: ldarg.0    
            IL_2DD4: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_2DD9: ldtoken    AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0
            IL_2DDE: call       void System.Type::GetTypeFromHandle
            IL_2DE3: call       void System.Linq.Expressions.Expression::Constant
            IL_2DE8: ldtoken    Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0::ix
            IL_2DED: call       void System.Reflection.FieldInfo::GetFieldFromHandle
            IL_2DF2: call       void System.Linq.Expressions.Expression::Field
            IL_2DF7: stelem.ref 
            IL_2DF8: call       void System.Linq.Expressions.Expression::Call
            IL_2DFD: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel::get_ModuleId()
            IL_2E02: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_2E07: castclass  System.Reflection.MethodInfo
            IL_2E0C: call       void System.Linq.Expressions.Expression::Property
            IL_2E11: ldc.i4.1   
            IL_2E12: newarr     System.Linq.Expressions.ParameterExpression
            IL_2E17: dup        
            IL_2E18: ldc.i4.0   
            IL_2E19: ldloc.2    
            IL_2E1A: stelem.ref 
            IL_2E1B: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_2E20: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_2E25: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_2E2A: ldloc.1    
            IL_2E2B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2E30: ldstr      "asp-for"
            IL_2E35: ldloc.1    
            IL_2E36: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_2E3B: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_2E40: ldc.i4.0   
            IL_2E41: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_2E46: ldloc.1    
            IL_2E47: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_2E4C: ldloc.1    
            IL_2E4D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2E52: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_2E57: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2E5C: stloc.s    V_46
            IL_2E5E: ldloca.s   V_46
            IL_2E60: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2E65: brtrue.s   IL_2EA9
            IL_2E67: ldarg.0    
            IL_2E68: ldc.i4.s   40
            IL_2E6A: dup        
            IL_2E6B: stloc.0    
            IL_2E6C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2E71: ldarg.0    
            IL_2E72: ldloc.s    V_46
            IL_2E74: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2E79: ldarg.0    
            IL_2E7A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2E7F: ldloca.s   V_46
            IL_2E81: ldarg.0    
            IL_2E82: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_2E87: leave      IL_3BC2
            IL_2E8C: ldarg.0    
            IL_2E8D: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2E92: stloc.s    V_46
            IL_2E94: ldarg.0    
            IL_2E95: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2E9A: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2EA0: ldarg.0    
            IL_2EA1: ldc.i4.m1  
            IL_2EA2: dup        
            IL_2EA3: stloc.0    
            IL_2EA4: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2EA9: ldloca.s   V_46
            IL_2EAB: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2EB0: ldloc.1    
            IL_2EB1: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2EB6: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2EBB: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_2EC0: brtrue.s   IL_2F26
            IL_2EC2: ldloc.1    
            IL_2EC3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2EC8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_2ECD: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_2ED2: stloc.s    V_47
            IL_2ED4: ldloca.s   V_47
            IL_2ED6: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_2EDB: brtrue.s   IL_2F1F
            IL_2EDD: ldarg.0    
            IL_2EDE: ldc.i4.s   41
            IL_2EE0: dup        
            IL_2EE1: stloc.0    
            IL_2EE2: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2EE7: ldarg.0    
            IL_2EE8: ldloc.s    V_47
            IL_2EEA: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2EEF: ldarg.0    
            IL_2EF0: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_2EF5: ldloca.s   V_47
            IL_2EF7: ldarg.0    
            IL_2EF8: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_2EFD: leave      IL_3BC2
            IL_2F02: ldarg.0    
            IL_2F03: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2F08: stloc.s    V_47
            IL_2F0A: ldarg.0    
            IL_2F0B: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_2F10: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_2F16: ldarg.0    
            IL_2F17: ldc.i4.m1  
            IL_2F18: dup        
            IL_2F19: stloc.0    
            IL_2F1A: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_2F1F: ldloca.s   V_47
            IL_2F21: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_2F26: ldloc.1    
            IL_2F27: ldloc.1    
            IL_2F28: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2F2D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_2F32: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_2F37: ldloc.1    
            IL_2F38: ldloc.1    
            IL_2F39: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2F3E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_2F43: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_2F48: ldloc.1    
            IL_2F49: ldstr      "\r\n                                                                        <span class=\"slider round\"></span>\r\n                                                                    </label>\r\n                                                                </div>\r\n"
            IL_2F4E: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2F53: ldarg.0    
            IL_2F54: ldfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_2F59: callvirt   void System.Collections.IEnumerator::MoveNext
            IL_2F5E: brtrue     IL_270B
            IL_2F63: leave.s    IL_2F7D
            IL_2F65: ldloc.0    
            IL_2F66: ldc.i4.0   
            IL_2F67: bge.s      IL_2F7C
            IL_2F69: ldarg.0    
            IL_2F6A: ldfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_2F6F: brfalse.s  IL_2F7C
            IL_2F71: ldarg.0    
            IL_2F72: ldfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_2F77: callvirt   void System.IDisposable::Dispose
            IL_2F7C: endfinally 
            IL_2F7D: ldarg.0    
            IL_2F7E: ldnull     
            IL_2F7F: stfld      System.Collections.Generic.IEnumerator`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr2
            IL_2F84: ldloc.1    
            IL_2F85: ldstr      "                                                        </div>\r\n                                                    </fieldset>\r\n"
            IL_2F8A: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2F8F: ldarg.0    
            IL_2F90: ldfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_2F95: callvirt   void System.Collections.IEnumerator::MoveNext
            IL_2F9A: brtrue     IL_26A7
            IL_2F9F: leave.s    IL_2FB9
            IL_2FA1: ldloc.0    
            IL_2FA2: ldc.i4.0   
            IL_2FA3: bge.s      IL_2FB8
            IL_2FA5: ldarg.0    
            IL_2FA6: ldfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_2FAB: brfalse.s  IL_2FB8
            IL_2FAD: ldarg.0    
            IL_2FAE: ldfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_2FB3: callvirt   void System.IDisposable::Dispose
            IL_2FB8: endfinally 
            IL_2FB9: ldarg.0    
            IL_2FBA: ldnull     
            IL_2FBB: stfld      System.Collections.Generic.IEnumerator`1<System.Linq.IGrouping`2<String, class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel>> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_wr1
            IL_2FC0: ldloc.1    
            IL_2FC1: ldstr      "                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!--End roles -->\r\n                        <!--Open Session -->\r\n                        <div class=\"form-group mt-3\">\r\n                            <label>Hopex session</label>\r\n                            <div class=\"form-check ms-3\">\r\n                                "
            IL_2FC6: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_2FCB: ldloc.1    
            IL_2FCC: ldloc.1    
            IL_2FCD: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_2FD2: ldstr      "input"
            IL_2FD7: ldc.i4.2   
            IL_2FD8: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996063250"
            IL_2FDD: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_38
            IL_2FE2: dup        
            IL_2FE3: brtrue.s   IL_2FFC
            IL_2FE5: pop        
            IL_2FE6: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_2FEB: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_38()
            IL_2FF1: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_2FF6: dup        
            IL_2FF7: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_38
            IL_2FFC: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_3001: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3006: ldloc.1    
            IL_3007: ldloc.1    
            IL_3008: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_300D: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3012: ldloc.1    
            IL_3013: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3018: ldloc.1    
            IL_3019: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_301E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_3023: ldloc.1    
            IL_3024: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3029: ldloc.1    
            IL_302A: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_302F: ldloc.1    
            IL_3030: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_3035: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_303A: call       void System.Type::GetTypeFromHandle
            IL_303F: ldstr      "__model"
            IL_3044: call       void System.Linq.Expressions.Expression::Parameter
            IL_3049: stloc.2    
            IL_304A: ldloc.2    
            IL_304B: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_CanOpenSession()
            IL_3050: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_3055: castclass  System.Reflection.MethodInfo
            IL_305A: call       void System.Linq.Expressions.Expression::Property
            IL_305F: ldc.i4.1   
            IL_3060: newarr     System.Linq.Expressions.ParameterExpression
            IL_3065: dup        
            IL_3066: ldc.i4.0   
            IL_3067: ldloc.2    
            IL_3068: stelem.ref 
            IL_3069: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_306E: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_3073: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_3078: ldloc.1    
            IL_3079: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_307E: ldstr      "asp-for"
            IL_3083: ldloc.1    
            IL_3084: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3089: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_308E: ldc.i4.0   
            IL_308F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3094: ldloc.1    
            IL_3095: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_309A: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_309F: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_30A4: castclass  System.String
            IL_30A9: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_30AE: ldloc.1    
            IL_30AF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_30B4: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_30B9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_30BE: ldloc.1    
            IL_30BF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_30C4: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_9
            IL_30C9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_30CE: ldloc.1    
            IL_30CF: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_30D4: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_14
            IL_30D9: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_30DE: castclass  System.String
            IL_30E3: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value
            IL_30E8: ldloc.1    
            IL_30E9: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_30EE: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_14
            IL_30F3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_30F8: ldloc.1    
            IL_30F9: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_30FE: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_20
            IL_3103: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3108: ldloc.1    
            IL_3109: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_310E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_12
            IL_3113: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3118: ldloc.1    
            IL_3119: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_311E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_21
            IL_3123: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3128: ldloc.1    
            IL_3129: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_312E: ldloc.1    
            IL_312F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3134: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_3139: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_313E: stloc.s    V_48
            IL_3140: ldloca.s   V_48
            IL_3142: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3147: brtrue.s   IL_318B
            IL_3149: ldarg.0    
            IL_314A: ldc.i4.s   42
            IL_314C: dup        
            IL_314D: stloc.0    
            IL_314E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3153: ldarg.0    
            IL_3154: ldloc.s    V_48
            IL_3156: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_315B: ldarg.0    
            IL_315C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3161: ldloca.s   V_48
            IL_3163: ldarg.0    
            IL_3164: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3169: leave      IL_3BC2
            IL_316E: ldarg.0    
            IL_316F: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3174: stloc.s    V_48
            IL_3176: ldarg.0    
            IL_3177: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_317C: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3182: ldarg.0    
            IL_3183: ldc.i4.m1  
            IL_3184: dup        
            IL_3185: stloc.0    
            IL_3186: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_318B: ldloca.s   V_48
            IL_318D: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3192: ldloc.1    
            IL_3193: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3198: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_319D: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_31A2: brtrue.s   IL_3208
            IL_31A4: ldloc.1    
            IL_31A5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_31AA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_31AF: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_31B4: stloc.s    V_49
            IL_31B6: ldloca.s   V_49
            IL_31B8: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_31BD: brtrue.s   IL_3201
            IL_31BF: ldarg.0    
            IL_31C0: ldc.i4.s   43
            IL_31C2: dup        
            IL_31C3: stloc.0    
            IL_31C4: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_31C9: ldarg.0    
            IL_31CA: ldloc.s    V_49
            IL_31CC: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_31D1: ldarg.0    
            IL_31D2: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_31D7: ldloca.s   V_49
            IL_31D9: ldarg.0    
            IL_31DA: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_31DF: leave      IL_3BC2
            IL_31E4: ldarg.0    
            IL_31E5: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_31EA: stloc.s    V_49
            IL_31EC: ldarg.0    
            IL_31ED: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_31F2: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_31F8: ldarg.0    
            IL_31F9: ldc.i4.m1  
            IL_31FA: dup        
            IL_31FB: stloc.0    
            IL_31FC: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3201: ldloca.s   V_49
            IL_3203: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3208: ldloc.1    
            IL_3209: ldloc.1    
            IL_320A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_320F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_3214: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_3219: ldloc.1    
            IL_321A: ldloc.1    
            IL_321B: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_3220: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_3225: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_322A: ldloc.1    
            IL_322B: ldstr      "\r\n                                <label for=\"canOpenSessionYes\" class=\"form-check-label\">No session</label>\r\n                            </div>\r\n                            <div class=\"form-check ms-3\">\r\n                                "
            IL_3230: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3235: ldloc.1    
            IL_3236: ldloc.1    
            IL_3237: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_323C: ldstr      "input"
            IL_3241: ldc.i4.2   
            IL_3242: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996065818"
            IL_3247: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_40
            IL_324C: dup        
            IL_324D: brtrue.s   IL_3266
            IL_324F: pop        
            IL_3250: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_3255: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_40()
            IL_325B: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_3260: dup        
            IL_3261: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_40
            IL_3266: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_326B: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3270: ldloc.1    
            IL_3271: ldloc.1    
            IL_3272: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_3277: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_327C: ldloc.1    
            IL_327D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3282: ldloc.1    
            IL_3283: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3288: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_328D: ldloc.1    
            IL_328E: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3293: ldloc.1    
            IL_3294: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_3299: ldloc.1    
            IL_329A: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_329F: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_32A4: call       void System.Type::GetTypeFromHandle
            IL_32A9: ldstr      "__model"
            IL_32AE: call       void System.Linq.Expressions.Expression::Parameter
            IL_32B3: stloc.2    
            IL_32B4: ldloc.2    
            IL_32B5: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_CanOpenSession()
            IL_32BA: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_32BF: castclass  System.Reflection.MethodInfo
            IL_32C4: call       void System.Linq.Expressions.Expression::Property
            IL_32C9: ldc.i4.1   
            IL_32CA: newarr     System.Linq.Expressions.ParameterExpression
            IL_32CF: dup        
            IL_32D0: ldc.i4.0   
            IL_32D1: ldloc.2    
            IL_32D2: stelem.ref 
            IL_32D3: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_32D8: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_32DD: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_32E2: ldloc.1    
            IL_32E3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_32E8: ldstr      "asp-for"
            IL_32ED: ldloc.1    
            IL_32EE: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_32F3: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_32F8: ldc.i4.0   
            IL_32F9: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_32FE: ldloc.1    
            IL_32FF: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3304: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_3309: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_330E: castclass  System.String
            IL_3313: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_InputTypeName
            IL_3318: ldloc.1    
            IL_3319: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_331E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_8
            IL_3323: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3328: ldloc.1    
            IL_3329: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_332E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_9
            IL_3333: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3338: ldloc.1    
            IL_3339: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_333E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_10
            IL_3343: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_3348: castclass  System.String
            IL_334D: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_Value
            IL_3352: ldloc.1    
            IL_3353: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3358: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_10
            IL_335D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3362: ldloc.1    
            IL_3363: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3368: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_22
            IL_336D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3372: ldloc.1    
            IL_3373: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3378: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_12
            IL_337D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3382: ldloc.1    
            IL_3383: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3388: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_23
            IL_338D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3392: ldloc.1    
            IL_3393: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_3398: ldloc.1    
            IL_3399: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_339E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_33A3: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_33A8: stloc.s    V_50
            IL_33AA: ldloca.s   V_50
            IL_33AC: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_33B1: brtrue.s   IL_33F5
            IL_33B3: ldarg.0    
            IL_33B4: ldc.i4.s   44
            IL_33B6: dup        
            IL_33B7: stloc.0    
            IL_33B8: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_33BD: ldarg.0    
            IL_33BE: ldloc.s    V_50
            IL_33C0: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_33C5: ldarg.0    
            IL_33C6: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_33CB: ldloca.s   V_50
            IL_33CD: ldarg.0    
            IL_33CE: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_33D3: leave      IL_3BC2
            IL_33D8: ldarg.0    
            IL_33D9: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_33DE: stloc.s    V_50
            IL_33E0: ldarg.0    
            IL_33E1: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_33E6: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_33EC: ldarg.0    
            IL_33ED: ldc.i4.m1  
            IL_33EE: dup        
            IL_33EF: stloc.0    
            IL_33F0: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_33F5: ldloca.s   V_50
            IL_33F7: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_33FC: ldloc.1    
            IL_33FD: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3402: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_3407: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_340C: brtrue.s   IL_3472
            IL_340E: ldloc.1    
            IL_340F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3414: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_3419: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_341E: stloc.s    V_51
            IL_3420: ldloca.s   V_51
            IL_3422: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3427: brtrue.s   IL_346B
            IL_3429: ldarg.0    
            IL_342A: ldc.i4.s   45
            IL_342C: dup        
            IL_342D: stloc.0    
            IL_342E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3433: ldarg.0    
            IL_3434: ldloc.s    V_51
            IL_3436: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_343B: ldarg.0    
            IL_343C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3441: ldloca.s   V_51
            IL_3443: ldarg.0    
            IL_3444: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3449: leave      IL_3BC2
            IL_344E: ldarg.0    
            IL_344F: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3454: stloc.s    V_51
            IL_3456: ldarg.0    
            IL_3457: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_345C: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3462: ldarg.0    
            IL_3463: ldc.i4.m1  
            IL_3464: dup        
            IL_3465: stloc.0    
            IL_3466: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_346B: ldloca.s   V_51
            IL_346D: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3472: ldloc.1    
            IL_3473: ldloc.1    
            IL_3474: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3479: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_347E: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_3483: ldloc.1    
            IL_3484: ldloc.1    
            IL_3485: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_348A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_348F: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3494: ldloc.1    
            IL_3495: ldstr      "\r\n                                <label for=\"canOpenSessionNo\" class=\"form-check-label\">Open session</label>\r\n                            </div>\r\n                            <div class=\"panel-group ms-5 mt-2\" id=\"accordion\">\r\n                                <div class=\"panel panel-default\">\r\n                                    <div id=\"collapseSession\""
            IL_349A: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_349F: ldloc.1    
            IL_34A0: ldstr      "class"
            IL_34A5: ldstr      " class=\""
            IL_34AA: ldc.i4     9391
            IL_34AF: ldstr      "\""
            IL_34B4: ldc.i4     9475
            IL_34B9: ldc.i4.3   
            IL_34BA: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute
            IL_34BF: ldloc.1    
            IL_34C0: ldstr      ""
            IL_34C5: ldc.i4     9399
            IL_34CA: ldstr      "panel-collapse"
            IL_34CF: ldc.i4     9399
            IL_34D4: ldc.i4.s   14
            IL_34D6: ldc.i4.1   
            IL_34D7: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_34DC: ldloc.1    
            IL_34DD: ldstr      " "
            IL_34E2: ldc.i4     9413
            IL_34E7: ldstr      "collapse"
            IL_34EC: ldc.i4     9414
            IL_34F1: ldc.i4.s   9
            IL_34F3: ldc.i4.1   
            IL_34F4: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_34F9: ldloc.1    
            IL_34FA: ldstr      " "
            IL_34FF: ldc.i4     9422
            IL_3504: ldloc.1    
            IL_3505: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_350A: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_CanOpenSession()
            IL_350F: ldstr      "Y"
            IL_3514: call       void System.String::op_Equality
            IL_3519: brtrue.s   IL_3522
            IL_351B: ldsfld     String System.String::Empty
            IL_3520: br.s       IL_3527
            IL_3522: ldstr      "show"
            IL_3527: ldc.i4     9423
            IL_352C: ldc.i4.s   52
            IL_352E: ldc.i4.0   
            IL_352F: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_3534: ldloc.1    
            IL_3535: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute
            IL_353A: ldloc.1    
            IL_353B: ldstr      ">\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"UserName\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">HOPEX login<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                "
            IL_3540: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3545: ldloc.1    
            IL_3546: ldloc.1    
            IL_3547: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_354C: ldstr      "input"
            IL_3551: ldc.i4.1   
            IL_3552: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996069504"
            IL_3557: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_42
            IL_355C: dup        
            IL_355D: brtrue.s   IL_3576
            IL_355F: pop        
            IL_3560: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_3565: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_42()
            IL_356B: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_3570: dup        
            IL_3571: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_42
            IL_3576: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_357B: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3580: ldloc.1    
            IL_3581: ldloc.1    
            IL_3582: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>()
            IL_3587: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_358C: ldloc.1    
            IL_358D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3592: ldloc.1    
            IL_3593: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3598: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_359D: ldloc.1    
            IL_359E: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_35A3: ldloc.1    
            IL_35A4: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_35A9: ldloc.1    
            IL_35AA: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_35AF: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_35B4: call       void System.Type::GetTypeFromHandle
            IL_35B9: ldstr      "__model"
            IL_35BE: call       void System.Linq.Expressions.Expression::Parameter
            IL_35C3: stloc.2    
            IL_35C4: ldloc.2    
            IL_35C5: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_UserName()
            IL_35CA: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_35CF: castclass  System.Reflection.MethodInfo
            IL_35D4: call       void System.Linq.Expressions.Expression::Property
            IL_35D9: ldc.i4.1   
            IL_35DA: newarr     System.Linq.Expressions.ParameterExpression
            IL_35DF: dup        
            IL_35E0: ldc.i4.0   
            IL_35E1: ldloc.2    
            IL_35E2: stelem.ref 
            IL_35E3: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_35E8: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_35ED: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::set_For
            IL_35F2: ldloc.1    
            IL_35F3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_35F8: ldstr      "asp-for"
            IL_35FD: ldloc.1    
            IL_35FE: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper
            IL_3603: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper::get_For
            IL_3608: ldc.i4.0   
            IL_3609: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_360E: ldloc.1    
            IL_360F: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute
            IL_3614: ldloc.1    
            IL_3615: ldloc.1    
            IL_3616: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute
            IL_361B: stfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_3620: ldloc.1    
            IL_3621: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3626: ldstr      "checked"
            IL_362B: ldloc.1    
            IL_362C: call       instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Html()
            IL_3631: ldloc.1    
            IL_3632: ldfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_3637: callvirt   void Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::Raw
            IL_363C: ldc.i4.3   
            IL_363D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3642: ldloc.1    
            IL_3643: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3648: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_2
            IL_364D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3652: ldloc.1    
            IL_3653: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3658: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_24
            IL_365D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3662: ldloc.1    
            IL_3663: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_3668: ldloc.1    
            IL_3669: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_366E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_3673: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_3678: stloc.s    V_52
            IL_367A: ldloca.s   V_52
            IL_367C: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3681: brtrue.s   IL_36C5
            IL_3683: ldarg.0    
            IL_3684: ldc.i4.s   46
            IL_3686: dup        
            IL_3687: stloc.0    
            IL_3688: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_368D: ldarg.0    
            IL_368E: ldloc.s    V_52
            IL_3690: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3695: ldarg.0    
            IL_3696: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_369B: ldloca.s   V_52
            IL_369D: ldarg.0    
            IL_369E: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_36A3: leave      IL_3BC2
            IL_36A8: ldarg.0    
            IL_36A9: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_36AE: stloc.s    V_52
            IL_36B0: ldarg.0    
            IL_36B1: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_36B6: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_36BC: ldarg.0    
            IL_36BD: ldc.i4.m1  
            IL_36BE: dup        
            IL_36BF: stloc.0    
            IL_36C0: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_36C5: ldloca.s   V_52
            IL_36C7: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_36CC: ldloc.1    
            IL_36CD: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_36D2: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_36D7: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_36DC: brtrue.s   IL_3742
            IL_36DE: ldloc.1    
            IL_36DF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_36E4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_36E9: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_36EE: stloc.s    V_53
            IL_36F0: ldloca.s   V_53
            IL_36F2: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_36F7: brtrue.s   IL_373B
            IL_36F9: ldarg.0    
            IL_36FA: ldc.i4.s   47
            IL_36FC: dup        
            IL_36FD: stloc.0    
            IL_36FE: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3703: ldarg.0    
            IL_3704: ldloc.s    V_53
            IL_3706: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_370B: ldarg.0    
            IL_370C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3711: ldloca.s   V_53
            IL_3713: ldarg.0    
            IL_3714: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3719: leave      IL_3BC2
            IL_371E: ldarg.0    
            IL_371F: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3724: stloc.s    V_53
            IL_3726: ldarg.0    
            IL_3727: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_372C: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3732: ldarg.0    
            IL_3733: ldc.i4.m1  
            IL_3734: dup        
            IL_3735: stloc.0    
            IL_3736: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_373B: ldloca.s   V_53
            IL_373D: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3742: ldloc.1    
            IL_3743: ldloc.1    
            IL_3744: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3749: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_374E: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_3753: ldloc.1    
            IL_3754: ldloc.1    
            IL_3755: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_375A: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_375F: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3764: ldloc.1    
            IL_3765: ldstr      "\r\n                                                "
            IL_376A: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_376F: ldloc.1    
            IL_3770: ldloc.1    
            IL_3771: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_3776: ldstr      "span"
            IL_377B: ldc.i4.0   
            IL_377C: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996071586"
            IL_3781: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_44
            IL_3786: dup        
            IL_3787: brtrue.s   IL_37A0
            IL_3789: pop        
            IL_378A: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_378F: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_44()
            IL_3795: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_379A: dup        
            IL_379B: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_44
            IL_37A0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_37A5: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_37AA: ldloc.1    
            IL_37AB: ldloc.1    
            IL_37AC: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>()
            IL_37B1: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_37B6: ldloc.1    
            IL_37B7: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_37BC: ldloc.1    
            IL_37BD: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_37C2: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_37C7: ldloc.1    
            IL_37C8: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_37CD: ldloc.1    
            IL_37CE: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_37D3: ldloc.1    
            IL_37D4: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_37D9: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_37DE: call       void System.Type::GetTypeFromHandle
            IL_37E3: ldstr      "__model"
            IL_37E8: call       void System.Linq.Expressions.Expression::Parameter
            IL_37ED: stloc.2    
            IL_37EE: ldloc.2    
            IL_37EF: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_UserName()
            IL_37F4: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_37F9: castclass  System.Reflection.MethodInfo
            IL_37FE: call       void System.Linq.Expressions.Expression::Property
            IL_3803: ldc.i4.1   
            IL_3804: newarr     System.Linq.Expressions.ParameterExpression
            IL_3809: dup        
            IL_380A: ldc.i4.0   
            IL_380B: ldloc.2    
            IL_380C: stelem.ref 
            IL_380D: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_3812: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_3817: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::set_For
            IL_381C: ldloc.1    
            IL_381D: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3822: ldstr      "asp-validation-for"
            IL_3827: ldloc.1    
            IL_3828: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper
            IL_382D: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper::get_For
            IL_3832: ldc.i4.0   
            IL_3833: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3838: ldloc.1    
            IL_3839: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_383E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_1
            IL_3843: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3848: ldloc.1    
            IL_3849: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_384E: ldloc.1    
            IL_384F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3854: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_3859: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_385E: stloc.s    V_54
            IL_3860: ldloca.s   V_54
            IL_3862: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3867: brtrue.s   IL_38AB
            IL_3869: ldarg.0    
            IL_386A: ldc.i4.s   48
            IL_386C: dup        
            IL_386D: stloc.0    
            IL_386E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3873: ldarg.0    
            IL_3874: ldloc.s    V_54
            IL_3876: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_387B: ldarg.0    
            IL_387C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3881: ldloca.s   V_54
            IL_3883: ldarg.0    
            IL_3884: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3889: leave      IL_3BC2
            IL_388E: ldarg.0    
            IL_388F: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3894: stloc.s    V_54
            IL_3896: ldarg.0    
            IL_3897: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_389C: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_38A2: ldarg.0    
            IL_38A3: ldc.i4.m1  
            IL_38A4: dup        
            IL_38A5: stloc.0    
            IL_38A6: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_38AB: ldloca.s   V_54
            IL_38AD: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_38B2: ldloc.1    
            IL_38B3: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_38B8: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_38BD: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_38C2: brtrue.s   IL_3928
            IL_38C4: ldloc.1    
            IL_38C5: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_38CA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_38CF: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_38D4: stloc.s    V_55
            IL_38D6: ldloca.s   V_55
            IL_38D8: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_38DD: brtrue.s   IL_3921
            IL_38DF: ldarg.0    
            IL_38E0: ldc.i4.s   49
            IL_38E2: dup        
            IL_38E3: stloc.0    
            IL_38E4: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_38E9: ldarg.0    
            IL_38EA: ldloc.s    V_55
            IL_38EC: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_38F1: ldarg.0    
            IL_38F2: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_38F7: ldloca.s   V_55
            IL_38F9: ldarg.0    
            IL_38FA: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_38FF: leave      IL_3BC2
            IL_3904: ldarg.0    
            IL_3905: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_390A: stloc.s    V_55
            IL_390C: ldarg.0    
            IL_390D: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3912: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3918: ldarg.0    
            IL_3919: ldc.i4.m1  
            IL_391A: dup        
            IL_391B: stloc.0    
            IL_391C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3921: ldloca.s   V_55
            IL_3923: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3928: ldloc.1    
            IL_3929: ldloc.1    
            IL_392A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_392F: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_3934: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_3939: ldloc.1    
            IL_393A: ldloc.1    
            IL_393B: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_3940: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_3945: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_394A: ldloc.1    
            IL_394B: ldstr      "\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"EnvironmentId\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">EnvironmentId<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                "
            IL_3950: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3955: ldloc.1    
            IL_3956: ldloc.1    
            IL_3957: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_395C: ldstr      "select"
            IL_3961: ldc.i4.0   
            IL_3962: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996073772"
            IL_3967: ldloc.1    
            IL_3968: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_46()
            IL_396E: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_3973: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_3978: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_397D: ldloc.1    
            IL_397E: ldloc.1    
            IL_397F: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>()
            IL_3984: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_3989: ldloc.1    
            IL_398A: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_398F: ldloc.1    
            IL_3990: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_3995: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_399A: ldloc.1    
            IL_399B: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_39A0: ldloc.1    
            IL_39A1: call       instance class Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_ModelExpressionProvider()
            IL_39A6: ldloc.1    
            IL_39A7: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_ViewData
            IL_39AC: ldtoken    Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel
            IL_39B1: call       void System.Type::GetTypeFromHandle
            IL_39B6: ldstr      "__model"
            IL_39BB: call       void System.Linq.Expressions.Expression::Parameter
            IL_39C0: stloc.2    
            IL_39C1: ldloc.2    
            IL_39C2: ldtoken    instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_EnvironmentId()
            IL_39C7: call       void System.Reflection.MethodBase::GetMethodFromHandle
            IL_39CC: castclass  System.Reflection.MethodInfo
            IL_39D1: call       void System.Linq.Expressions.Expression::Property
            IL_39D6: ldc.i4.1   
            IL_39D7: newarr     System.Linq.Expressions.ParameterExpression
            IL_39DC: dup        
            IL_39DD: ldc.i4.0   
            IL_39DE: ldloc.2    
            IL_39DF: stelem.ref 
            IL_39E0: call       System.Linq.Expressions.Expression`1<!!0> System.Linq.Expressions.Expression::Lambda<System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>>(class System.Linq.Expressions.Expression, class System.Linq.Expressions.ParameterExpression[])
            IL_39E5: callvirt   instance class Microsoft.AspNetCore.Mvc.ViewFeatures.ModelExpression Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider::CreateModelExpression<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel, String>(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1<!!0>, System.Linq.Expressions.Expression`1<System.Func`2<!!0, !!1>>)
            IL_39EA: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::set_For
            IL_39EF: ldloc.1    
            IL_39F0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_39F5: ldstr      "asp-for"
            IL_39FA: ldloc.1    
            IL_39FB: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_3A00: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::get_For
            IL_3A05: ldc.i4.0   
            IL_3A06: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3A0B: ldloc.1    
            IL_3A0C: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_3A11: ldloc.1    
            IL_3A12: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_3A17: callvirt   instance System.Collections.Generic.IEnumerable`1<class Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel::get_Environments()
            IL_3A1C: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::set_Items
            IL_3A21: ldloc.1    
            IL_3A22: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3A27: ldstr      "asp-items"
            IL_3A2C: ldloc.1    
            IL_3A2D: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper
            IL_3A32: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper::get_Items
            IL_3A37: ldc.i4.0   
            IL_3A38: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_3A3D: ldloc.1    
            IL_3A3E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3A43: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_26
            IL_3A48: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_3A4D: ldloc.1    
            IL_3A4E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_3A53: ldloc.1    
            IL_3A54: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3A59: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_3A5E: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_3A63: stloc.s    V_56
            IL_3A65: ldloca.s   V_56
            IL_3A67: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3A6C: brtrue.s   IL_3AB0
            IL_3A6E: ldarg.0    
            IL_3A6F: ldc.i4.s   50
            IL_3A71: dup        
            IL_3A72: stloc.0    
            IL_3A73: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3A78: ldarg.0    
            IL_3A79: ldloc.s    V_56
            IL_3A7B: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3A80: ldarg.0    
            IL_3A81: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3A86: ldloca.s   V_56
            IL_3A88: ldarg.0    
            IL_3A89: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3A8E: leave      IL_3BC2
            IL_3A93: ldarg.0    
            IL_3A94: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3A99: stloc.s    V_56
            IL_3A9B: ldarg.0    
            IL_3A9C: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3AA1: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3AA7: ldarg.0    
            IL_3AA8: ldc.i4.m1  
            IL_3AA9: dup        
            IL_3AAA: stloc.0    
            IL_3AAB: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3AB0: ldloca.s   V_56
            IL_3AB2: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3AB7: ldloc.1    
            IL_3AB8: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3ABD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_3AC2: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_3AC7: brtrue.s   IL_3B2D
            IL_3AC9: ldloc.1    
            IL_3ACA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3ACF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_3AD4: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_3AD9: stloc.s    V_57
            IL_3ADB: ldloca.s   V_57
            IL_3ADD: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_3AE2: brtrue.s   IL_3B26
            IL_3AE4: ldarg.0    
            IL_3AE5: ldc.i4.s   51
            IL_3AE7: dup        
            IL_3AE8: stloc.0    
            IL_3AE9: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3AEE: ldarg.0    
            IL_3AEF: ldloc.s    V_57
            IL_3AF1: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3AF6: ldarg.0    
            IL_3AF7: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3AFC: ldloca.s   V_57
            IL_3AFE: ldarg.0    
            IL_3AFF: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_0>d>(!!0&, !!1&)
            IL_3B04: leave      IL_3BC2
            IL_3B09: ldarg.0    
            IL_3B0A: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3B0F: stloc.s    V_57
            IL_3B11: ldarg.0    
            IL_3B12: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_aw1
            IL_3B17: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_3B1D: ldarg.0    
            IL_3B1E: ldc.i4.m1  
            IL_3B1F: dup        
            IL_3B20: stloc.0    
            IL_3B21: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3B26: ldloca.s   V_57
            IL_3B28: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_3B2D: ldloc.1    
            IL_3B2E: ldloc.1    
            IL_3B2F: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3B34: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_3B39: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_3B3E: ldloc.1    
            IL_3B3F: ldloc.1    
            IL_3B40: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_3B45: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_3B4A: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_3B4F: ldloc.1    
            IL_3B50: ldstr      "\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"PersonGroups-group\">\r\n                                            <label for=\"PersonGroups\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Person<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"PersonGroups\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"Repositories-group\">\r\n                                            <label for=\"Repositories\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Repositories<span class=\"required\"> *</span></label>\r\n                                           "
            IL_3B55: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3B5A: ldloc.1    
            IL_3B5B: ldstr      " <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"Repositories\" name=\"Repositories\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\" id=\"Profiles-group\">\r\n                                            <label for=\"Profiles\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Profiles<span class=\"required\"> *</span></label>\r\n                                            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <select id=\"Profiles\" name=\"Profiles\" class=\"select2_single form-select\">\r\n                                                </select>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n   "
            IL_3B60: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3B65: ldloc.1    
            IL_3B66: ldstr      "                                         <label for=\"SessionMode\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Session Mode</label>\r\n                                            <p class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <label class=\"control-label\">Multi</label>\r\n                                                <input type=\"radio\" name=\"SessionMode\" id=\"SessionMode\" value=\"MS\" class=\"flat\" checked />\r\n                                                <label class=\"control-label\">Single</label>\r\n                                                <input type=\"radio\" name=\"SessionMode\" id=\"SessionMode\" value=\"SS\" class=\"flat\" />\r\n                                            </p>\r\n                                        </div>\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"ConnectionMode\" class=\"control-label col-md-3 col-sm-3 col-xs-12\">Connection Mode</label>\r\n                                 "
            IL_3B6B: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3B70: ldloc.1    
            IL_3B71: ldstr      "           <p class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                                                <label class=\"control-label\">Read/Write</label>\r\n                                                <input type=\"radio\" name=\"ConnectionMode\" id=\"ConnectionMode\" value=\"RW\" class=\"flat\" checked />\r\n                                                <label class=\"control-label\">Read only</label>\r\n                                                <input type=\"radio\" name=\"ConnectionMode\" id=\"ConnectionMode\" value=\"RO\" class=\"flat\" />\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"ln_solid\"></div>\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-6 col-sm-6 col-xs-12 col-md-offset-3\">\r\n                                <button class=\"btn btn"
            IL_3B76: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3B7B: ldloc.1    
            IL_3B7C: ldstr      "-primary pull-right\" type=\"submit\" id=\"btnSubmit\" disabled>\r\n                                    <span id=\"loading\" class=\"spinner-border spinner-border-sm\" role=\"status\" aria-hidden=\"true\"></span>\r\n                                    Submit\r\n                                </button>\r\n                            </div>\r\n                        </div>\r\n                    "
            IL_3B81: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_3B86: leave.s    IL_3BA8
            IL_3B88: stloc.s    V_58
            IL_3B8A: ldarg.0    
            IL_3B8B: ldc.i4.s   -2
            IL_3B8D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3B92: ldarg.0    
            IL_3B93: ldnull     
            IL_3B94: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_3B99: ldarg.0    
            IL_3B9A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3B9F: ldloc.s    V_58
            IL_3BA1: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_3BA6: leave.s    IL_3BC2
            IL_3BA8: ldarg.0    
            IL_3BA9: ldc.i4.s   -2
            IL_3BAB: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_state
            IL_3BB0: ldarg.0    
            IL_3BB1: ldnull     
            IL_3BB2: stfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_h1
            IL_3BB7: ldarg.0    
            IL_3BB8: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_3BBD: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_3BC2: ret        

            .try IL_26E5 to IL_2F65
                finally handler IL_2F65 to IL_2F7D
            .try IL_269B to IL_2FA1
                finally handler IL_2FA1 to IL_2FB9
            .try IL_000E to IL_3B88
                catch System.Exception handler IL_3B88 to IL_3BA8
        } // MoveNext

        // 0x06000919 RVA:0x0002BC60
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_0_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_0_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d
    // Token: 0x020000FB

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_1_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        // === METHODS ===
        // 0x0600091A RVA:0x0002BC70
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 2
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.1    
            IL_000F: ldstr      "\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"/uas/lib/jqueryui/themes/base/jquery-ui.min.css\" />\r\n<style>\r\n    .icon {\r\n        width: 16px;\r\n        height: 16px;\r\n        padding: 0;\r\n        margin: 0;\r\n        vertical-align: middle;\r\n    }\r\n</style>\r\n"
            IL_0014: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0019: leave.s    IL_0032
            IL_001B: stloc.2    
            IL_001C: ldarg.0    
            IL_001D: ldc.i4.s   -2
            IL_001F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_state
            IL_0024: ldarg.0    
            IL_0025: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
            IL_002A: ldloc.2    
            IL_002B: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_0030: leave.s    IL_0045
            IL_0032: ldarg.0    
            IL_0033: ldc.i4.s   -2
            IL_0035: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_state
            IL_003A: ldarg.0    
            IL_003B: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
            IL_0040: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_0045: ret        

            .try IL_000E to IL_001B
                catch System.Exception handler IL_001B to IL_0032
        } // MoveNext

        // 0x0600091B RVA:0x0002BCD4
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_1_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_1_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d
    // Token: 0x020000FC

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_2_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        .field private valuetype System.Runtime.CompilerServices.TaskAwaiter _aw1
        // === METHODS ===
        // 0x0600091C RVA:0x0002BCE4
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 7
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] valuetype System.Runtime.CompilerServices.TaskAwaiter, [3] valuetype System.Runtime.CompilerServices.TaskAwaiter, [4] valuetype System.Runtime.CompilerServices.TaskAwaiter, [5] valuetype System.Runtime.CompilerServices.TaskAwaiter, [6] valuetype System.Runtime.CompilerServices.TaskAwaiter, [7] valuetype System.Runtime.CompilerServices.TaskAwaiter, [8] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.0    
            IL_000F: switch     (IL_00EC, IL_015E, IL_02A7, IL_031C, IL_0424, IL_0496)
            IL_002C: ldloc.1    
            IL_002D: ldstr      "\r\n"
            IL_0032: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0037: ldloc.1    
            IL_0038: ldloc.1    
            IL_0039: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_003E: ldstr      "script"
            IL_0043: ldc.i4.0   
            IL_0044: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996084494"
            IL_0049: ldloc.1    
            IL_004A: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_56()
            IL_0050: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0055: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_005A: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_005F: ldloc.1    
            IL_0060: ldloc.1    
            IL_0061: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class HAS.Server.TagHelpers.NonceTagHelper>()
            IL_0066: stfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_006B: ldloc.1    
            IL_006C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0071: ldloc.1    
            IL_0072: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_0077: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_007C: ldloc.1    
            IL_007D: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_0082: ldc.i4.1   
            IL_0083: callvirt   void HAS.Server.TagHelpers.NonceTagHelper::set_AddNonce
            IL_0088: ldloc.1    
            IL_0089: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_008E: ldstr      "asp-add-nonce"
            IL_0093: ldloc.1    
            IL_0094: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_0099: callvirt   void HAS.Server.TagHelpers.NonceTagHelper::get_AddNonce
            IL_009E: box        System.Boolean
            IL_00A3: ldc.i4.0   
            IL_00A4: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_00A9: ldloc.1    
            IL_00AA: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_00AF: ldloc.1    
            IL_00B0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_00B5: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_00BA: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_00BF: stloc.2    
            IL_00C0: ldloca.s   V_2
            IL_00C2: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_00C7: brtrue.s   IL_0108
            IL_00C9: ldarg.0    
            IL_00CA: ldc.i4.0   
            IL_00CB: dup        
            IL_00CC: stloc.0    
            IL_00CD: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_00D2: ldarg.0    
            IL_00D3: ldloc.2    
            IL_00D4: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_00D9: ldarg.0    
            IL_00DA: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_00DF: ldloca.s   V_2
            IL_00E1: ldarg.0    
            IL_00E2: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_00E7: leave      IL_0515
            IL_00EC: ldarg.0    
            IL_00ED: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_00F2: stloc.2    
            IL_00F3: ldarg.0    
            IL_00F4: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_00F9: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_00FF: ldarg.0    
            IL_0100: ldc.i4.m1  
            IL_0101: dup        
            IL_0102: stloc.0    
            IL_0103: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0108: ldloca.s   V_2
            IL_010A: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_010F: ldloc.1    
            IL_0110: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0115: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_011A: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_011F: brtrue.s   IL_0181
            IL_0121: ldloc.1    
            IL_0122: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0127: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_012C: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0131: stloc.3    
            IL_0132: ldloca.s   V_3
            IL_0134: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0139: brtrue.s   IL_017A
            IL_013B: ldarg.0    
            IL_013C: ldc.i4.1   
            IL_013D: dup        
            IL_013E: stloc.0    
            IL_013F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0144: ldarg.0    
            IL_0145: ldloc.3    
            IL_0146: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_014B: ldarg.0    
            IL_014C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_0151: ldloca.s   V_3
            IL_0153: ldarg.0    
            IL_0154: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_0159: leave      IL_0515
            IL_015E: ldarg.0    
            IL_015F: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0164: stloc.3    
            IL_0165: ldarg.0    
            IL_0166: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_016B: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0171: ldarg.0    
            IL_0172: ldc.i4.m1  
            IL_0173: dup        
            IL_0174: stloc.0    
            IL_0175: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_017A: ldloca.s   V_3
            IL_017C: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0181: ldloc.1    
            IL_0182: ldloc.1    
            IL_0183: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0188: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_018D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_0192: ldloc.1    
            IL_0193: ldloc.1    
            IL_0194: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0199: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_019E: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01A3: ldloc.1    
            IL_01A4: ldstr      "\r\n<script src=\"/uas/lib/jqueryui/jquery-ui.min.js\"></script>\r\n"
            IL_01A9: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_01AE: ldloc.1    
            IL_01AF: ldloc.1    
            IL_01B0: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_01B5: ldstr      "script"
            IL_01BA: ldc.i4.0   
            IL_01BB: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996086040"
            IL_01C0: ldsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_57
            IL_01C5: dup        
            IL_01C6: brtrue.s   IL_01DF
            IL_01C8: pop        
            IL_01C9: ldsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_01CE: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_lm_ExecuteAsync_46_57()
            IL_01D4: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_01D9: dup        
            IL_01DA: stsfld     System.Func`1<class System.Threading.Tasks.Task> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cd_46_57
            IL_01DF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_01E4: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01E9: ldloc.1    
            IL_01EA: ldloc.1    
            IL_01EB: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>()
            IL_01F0: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
            IL_01F5: ldloc.1    
            IL_01F6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01FB: ldloc.1    
            IL_01FC: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
            IL_0201: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0206: ldloc.1    
            IL_0207: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
            IL_020C: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_29
            IL_0211: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_0216: castclass  System.String
            IL_021B: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::set_Src
            IL_0220: ldloc.1    
            IL_0221: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0226: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_29
            IL_022B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0230: ldloc.1    
            IL_0231: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
            IL_0236: ldc.i4.1   
            IL_0237: newobj     void System.Nullable`1<Boolean>::.ctor
            IL_023C: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::set_AppendVersion
            IL_0241: ldloc.1    
            IL_0242: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0247: ldstr      "asp-append-version"
            IL_024C: ldloc.1    
            IL_024D: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper
            IL_0252: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper::get_AppendVersion
            IL_0257: box        System.Nullable`1<Boolean>
            IL_025C: ldc.i4.0   
            IL_025D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0262: ldloc.1    
            IL_0263: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_0268: ldloc.1    
            IL_0269: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_026E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0273: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0278: stloc.s    V_4
            IL_027A: ldloca.s   V_4
            IL_027C: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0281: brtrue.s   IL_02C4
            IL_0283: ldarg.0    
            IL_0284: ldc.i4.2   
            IL_0285: dup        
            IL_0286: stloc.0    
            IL_0287: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_028C: ldarg.0    
            IL_028D: ldloc.s    V_4
            IL_028F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0294: ldarg.0    
            IL_0295: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_029A: ldloca.s   V_4
            IL_029C: ldarg.0    
            IL_029D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_02A2: leave      IL_0515
            IL_02A7: ldarg.0    
            IL_02A8: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_02AD: stloc.s    V_4
            IL_02AF: ldarg.0    
            IL_02B0: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_02B5: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_02BB: ldarg.0    
            IL_02BC: ldc.i4.m1  
            IL_02BD: dup        
            IL_02BE: stloc.0    
            IL_02BF: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_02C4: ldloca.s   V_4
            IL_02C6: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_02CB: ldloc.1    
            IL_02CC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_02D1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_02D6: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_02DB: brtrue.s   IL_0340
            IL_02DD: ldloc.1    
            IL_02DE: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_02E3: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_02E8: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_02ED: stloc.s    V_5
            IL_02EF: ldloca.s   V_5
            IL_02F1: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_02F6: brtrue.s   IL_0339
            IL_02F8: ldarg.0    
            IL_02F9: ldc.i4.3   
            IL_02FA: dup        
            IL_02FB: stloc.0    
            IL_02FC: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0301: ldarg.0    
            IL_0302: ldloc.s    V_5
            IL_0304: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0309: ldarg.0    
            IL_030A: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_030F: ldloca.s   V_5
            IL_0311: ldarg.0    
            IL_0312: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_0317: leave      IL_0515
            IL_031C: ldarg.0    
            IL_031D: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0322: stloc.s    V_5
            IL_0324: ldarg.0    
            IL_0325: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_032A: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0330: ldarg.0    
            IL_0331: ldc.i4.m1  
            IL_0332: dup        
            IL_0333: stloc.0    
            IL_0334: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0339: ldloca.s   V_5
            IL_033B: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0340: ldloc.1    
            IL_0341: ldloc.1    
            IL_0342: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0347: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_034C: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_0351: ldloc.1    
            IL_0352: ldloc.1    
            IL_0353: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0358: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_035D: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0362: ldloc.1    
            IL_0363: ldstr      "\r\n"
            IL_0368: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_036D: ldloc.1    
            IL_036E: ldloc.1    
            IL_036F: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0374: ldstr      "script"
            IL_0379: ldc.i4.0   
            IL_037A: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996087749"
            IL_037F: ldloc.1    
            IL_0380: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_58()
            IL_0386: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_038B: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0390: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0395: ldloc.1    
            IL_0396: ldloc.1    
            IL_0397: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class HAS.Server.TagHelpers.NonceTagHelper>()
            IL_039C: stfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_03A1: ldloc.1    
            IL_03A2: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_03A7: ldloc.1    
            IL_03A8: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_03AD: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_03B2: ldloc.1    
            IL_03B3: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_03B8: ldc.i4.1   
            IL_03B9: callvirt   void HAS.Server.TagHelpers.NonceTagHelper::set_AddNonce
            IL_03BE: ldloc.1    
            IL_03BF: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_03C4: ldstr      "asp-add-nonce"
            IL_03C9: ldloc.1    
            IL_03CA: ldfld      class HAS.Server.TagHelpers.NonceTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__HAS_Server_TagHelpers_NonceTagHelper
            IL_03CF: callvirt   void HAS.Server.TagHelpers.NonceTagHelper::get_AddNonce
            IL_03D4: box        System.Boolean
            IL_03D9: ldc.i4.0   
            IL_03DA: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_03DF: ldloc.1    
            IL_03E0: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_03E5: ldloc.1    
            IL_03E6: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_03EB: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_03F0: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_03F5: stloc.s    V_6
            IL_03F7: ldloca.s   V_6
            IL_03F9: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_03FE: brtrue.s   IL_0441
            IL_0400: ldarg.0    
            IL_0401: ldc.i4.4   
            IL_0402: dup        
            IL_0403: stloc.0    
            IL_0404: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0409: ldarg.0    
            IL_040A: ldloc.s    V_6
            IL_040C: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0411: ldarg.0    
            IL_0412: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_0417: ldloca.s   V_6
            IL_0419: ldarg.0    
            IL_041A: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_041F: leave      IL_0515
            IL_0424: ldarg.0    
            IL_0425: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_042A: stloc.s    V_6
            IL_042C: ldarg.0    
            IL_042D: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0432: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_0438: ldarg.0    
            IL_0439: ldc.i4.m1  
            IL_043A: dup        
            IL_043B: stloc.0    
            IL_043C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_0441: ldloca.s   V_6
            IL_0443: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_0448: ldloc.1    
            IL_0449: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_044E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0453: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_0458: brtrue.s   IL_04BA
            IL_045A: ldloc.1    
            IL_045B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0460: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0465: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_046A: stloc.s    V_7
            IL_046C: ldloca.s   V_7
            IL_046E: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0473: brtrue.s   IL_04B3
            IL_0475: ldarg.0    
            IL_0476: ldc.i4.5   
            IL_0477: dup        
            IL_0478: stloc.0    
            IL_0479: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_047E: ldarg.0    
            IL_047F: ldloc.s    V_7
            IL_0481: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_0486: ldarg.0    
            IL_0487: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_048C: ldloca.s   V_7
            IL_048E: ldarg.0    
            IL_048F: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_2>d>(!!0&, !!1&)
            IL_0494: leave.s    IL_0515
            IL_0496: ldarg.0    
            IL_0497: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_049C: stloc.s    V_7
            IL_049E: ldarg.0    
            IL_049F: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_aw1
            IL_04A4: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_04AA: ldarg.0    
            IL_04AB: ldc.i4.m1  
            IL_04AC: dup        
            IL_04AD: stloc.0    
            IL_04AE: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_04B3: ldloca.s   V_7
            IL_04B5: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_04BA: ldloc.1    
            IL_04BB: ldloc.1    
            IL_04BC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_04C1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_04C6: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_04CB: ldloc.1    
            IL_04CC: ldloc.1    
            IL_04CD: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_04D2: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_04D7: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_04DC: ldloc.1    
            IL_04DD: ldstr      "\r\n"
            IL_04E2: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_04E7: leave.s    IL_0502
            IL_04E9: stloc.s    V_8
            IL_04EB: ldarg.0    
            IL_04EC: ldc.i4.s   -2
            IL_04EE: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_04F3: ldarg.0    
            IL_04F4: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_04F9: ldloc.s    V_8
            IL_04FB: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_0500: leave.s    IL_0515
            IL_0502: ldarg.0    
            IL_0503: ldc.i4.s   -2
            IL_0505: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_state
            IL_050A: ldarg.0    
            IL_050B: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_0510: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_0515: ret        

            .try IL_000E to IL_04E9
                catch System.Exception handler IL_04E9 to IL_0502
        } // MoveNext

        // 0x0600091D RVA:0x0002C224
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_2_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_2_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d
    // Token: 0x020000FD

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_46_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        .field private valuetype System.Runtime.CompilerServices.TaskAwaiter _aw1
        // === METHODS ===
        // 0x0600091E RVA:0x0002C234
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 7
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] valuetype System.Runtime.CompilerServices.TaskAwaiter, [3] valuetype System.Runtime.CompilerServices.TaskAwaiter, [4] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.0    
            IL_000F: brfalse    IL_00D8
            IL_0014: ldloc.0    
            IL_0015: ldc.i4.1   
            IL_0016: beq        IL_0147
            IL_001B: ldloc.1    
            IL_001C: ldstr      "\r\n                                                    "
            IL_0021: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0026: ldloc.1    
            IL_0027: ldloc.1    
            IL_0028: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_002D: ldstr      "option"
            IL_0032: ldc.i4.0   
            IL_0033: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996074117"
            IL_0038: ldloc.1    
            IL_0039: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_55()
            IL_003F: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_0044: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_0049: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_004E: ldloc.1    
            IL_004F: ldloc.1    
            IL_0050: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>()
            IL_0055: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
            IL_005A: ldloc.1    
            IL_005B: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0060: ldloc.1    
            IL_0061: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
            IL_0066: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_006B: ldloc.1    
            IL_006C: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper
            IL_0071: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_25
            IL_0076: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_007B: castclass  System.String
            IL_0080: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper::set_Value
            IL_0085: ldloc.1    
            IL_0086: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_008B: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_25
            IL_0090: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0095: ldloc.1    
            IL_0096: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_009B: ldloc.1    
            IL_009C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_00A1: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_00A6: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_00AB: stloc.2    
            IL_00AC: ldloca.s   V_2
            IL_00AE: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_00B3: brtrue.s   IL_00F4
            IL_00B5: ldarg.0    
            IL_00B6: ldc.i4.0   
            IL_00B7: dup        
            IL_00B8: stloc.0    
            IL_00B9: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_00BE: ldarg.0    
            IL_00BF: ldloc.2    
            IL_00C0: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_00C5: ldarg.0    
            IL_00C6: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
            IL_00CB: ldloca.s   V_2
            IL_00CD: ldarg.0    
            IL_00CE: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_46>d>(!!0&, !!1&)
            IL_00D3: leave      IL_01C5
            IL_00D8: ldarg.0    
            IL_00D9: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_00DE: stloc.2    
            IL_00DF: ldarg.0    
            IL_00E0: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_00E5: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_00EB: ldarg.0    
            IL_00EC: ldc.i4.m1  
            IL_00ED: dup        
            IL_00EE: stloc.0    
            IL_00EF: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_00F4: ldloca.s   V_2
            IL_00F6: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_00FB: ldloc.1    
            IL_00FC: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0101: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0106: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_010B: brtrue.s   IL_016A
            IL_010D: ldloc.1    
            IL_010E: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0113: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_0118: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_011D: stloc.3    
            IL_011E: ldloca.s   V_3
            IL_0120: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0125: brtrue.s   IL_0163
            IL_0127: ldarg.0    
            IL_0128: ldc.i4.1   
            IL_0129: dup        
            IL_012A: stloc.0    
            IL_012B: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_0130: ldarg.0    
            IL_0131: ldloc.3    
            IL_0132: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_0137: ldarg.0    
            IL_0138: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
            IL_013D: ldloca.s   V_3
            IL_013F: ldarg.0    
            IL_0140: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<<ExecuteAsync>b__46_46>d>(!!0&, !!1&)
            IL_0145: leave.s    IL_01C5
            IL_0147: ldarg.0    
            IL_0148: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_014D: stloc.3    
            IL_014E: ldarg.0    
            IL_014F: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_aw1
            IL_0154: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_015A: ldarg.0    
            IL_015B: ldc.i4.m1  
            IL_015C: dup        
            IL_015D: stloc.0    
            IL_015E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_0163: ldloca.s   V_3
            IL_0165: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_016A: ldloc.1    
            IL_016B: ldloc.1    
            IL_016C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0171: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0176: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_017B: ldloc.1    
            IL_017C: ldloc.1    
            IL_017D: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0182: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_0187: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_018C: ldloc.1    
            IL_018D: ldstr      "\r\n                                                "
            IL_0192: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0197: leave.s    IL_01B2
            IL_0199: stloc.s    V_4
            IL_019B: ldarg.0    
            IL_019C: ldc.i4.s   -2
            IL_019E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_01A3: ldarg.0    
            IL_01A4: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
            IL_01A9: ldloc.s    V_4
            IL_01AB: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_01B0: leave.s    IL_01C5
            IL_01B2: ldarg.0    
            IL_01B3: ldc.i4.s   -2
            IL_01B5: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_state
            IL_01BA: ldarg.0    
            IL_01BB: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
            IL_01C0: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_01C5: ret        

            .try IL_000E to IL_0199
                catch System.Exception handler IL_0199 to IL_01B2
        } // MoveNext

        // 0x0600091F RVA:0x0002C424
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_46_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_46_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d
    // Token: 0x020000FE

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_55_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        // === METHODS ===
        // 0x06000920 RVA:0x0002C434
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 2
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.1    
            IL_000F: ldstr      "Select an environment..."
            IL_0014: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0019: leave.s    IL_0032
            IL_001B: stloc.2    
            IL_001C: ldarg.0    
            IL_001D: ldc.i4.s   -2
            IL_001F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_state
            IL_0024: ldarg.0    
            IL_0025: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
            IL_002A: ldloc.2    
            IL_002B: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_0030: leave.s    IL_0045
            IL_0032: ldarg.0    
            IL_0033: ldc.i4.s   -2
            IL_0035: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_state
            IL_003A: ldarg.0    
            IL_003B: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
            IL_0040: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_0045: ret        

            .try IL_000E to IL_001B
                catch System.Exception handler IL_001B to IL_0032
        } // MoveNext

        // 0x06000921 RVA:0x0002C498
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_55_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_55_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d
    // Token: 0x020000FF

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_56_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        // === METHODS ===
        // 0x06000922 RVA:0x0002C4A8
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 2
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.1    
            IL_000F: ldstr      "\r\n    var editMode = false;\r\n"
            IL_0014: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0019: leave.s    IL_0032
            IL_001B: stloc.2    
            IL_001C: ldarg.0    
            IL_001D: ldc.i4.s   -2
            IL_001F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_state
            IL_0024: ldarg.0    
            IL_0025: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
            IL_002A: ldloc.2    
            IL_002B: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_0030: leave.s    IL_0045
            IL_0032: ldarg.0    
            IL_0033: ldc.i4.s   -2
            IL_0035: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_state
            IL_003A: ldarg.0    
            IL_003B: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
            IL_0040: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_0045: ret        

            .try IL_000E to IL_001B
                catch System.Exception handler IL_001B to IL_0032
        } // MoveNext

        // 0x06000923 RVA:0x0002C50C
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_56_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_56_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d
    // Token: 0x02000100

    .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_58_d
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        // === METHODS ===
        // 0x06000924 RVA:0x0002C51C
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 2
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.1    
            IL_000F: ldstr      "\r\n    function copyToClipboard() {\r\n        var str = \""
            IL_0014: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0019: ldloc.1    
            IL_001A: ldloc.1    
            IL_001B: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_0020: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Password()
            IL_0025: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_002A: ldloc.1    
            IL_002B: ldstr      "\";\r\n        const el = document.createElement('textarea');  // Create a <textarea> element\r\n        el.value = str;                                 // Set its value to the string that you want copied\r\n        el.setAttribute('readonly', '');                // Make it readonly to be tamper-proof\r\n        el.style.position = 'absolute';\r\n        el.style.left = '-9999px';                      // Move outside the screen to make it invisible\r\n        document.body.appendChild(el);                  // Append the <textarea> element to the HTML document\r\n        const selected =\r\n            document.getSelection().rangeCount > 0        // Check if there is any content selected previously\r\n                ? document.getSelection().getRangeAt(0)     // Store selection if found\r\n                : false;                                    // Mark as false to know no selection existed before\r\n        el.select();                                    // Select the <textarea> content\r\n        document.execCommand('copy');  "
            IL_0030: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0035: ldloc.1    
            IL_0036: ldstr      "                 // Copy - only works as a result of a user action (e.g. click events)\r\n        document.body.removeChild(el);                  // Remove the <textarea> element\r\n        if (selected) {                                 // If a selection existed before copying\r\n            document.getSelection().removeAllRanges();    // Unselect everything on the HTML document\r\n            document.getSelection().addRange(selected);   // Restore the original selection\r\n        }\r\n    }\r\n"
            IL_003B: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0040: leave.s    IL_0059
            IL_0042: stloc.2    
            IL_0043: ldarg.0    
            IL_0044: ldc.i4.s   -2
            IL_0046: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_state
            IL_004B: ldarg.0    
            IL_004C: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
            IL_0051: ldloc.2    
            IL_0052: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_0057: leave.s    IL_006C
            IL_0059: ldarg.0    
            IL_005A: ldc.i4.s   -2
            IL_005C: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_state
            IL_0061: ldarg.0    
            IL_0062: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
            IL_0067: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_006C: ret        

            .try IL_000E to IL_0042
                catch System.Exception handler IL_0042 to IL_0059
        } // MoveNext

        // 0x06000925 RVA:0x0002C5A8
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/ExecuteAsync_b_46_58_d::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // ExecuteAsync_b_46_58_d

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc
    // Token: 0x02000101

    .class nested private sealed auto ansi beforefieldinit _cc
        extends System.Object
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === STATIC CTOR ===
        // 0x06000926 RVA:0x0002C5B6
        .method private static hidebysig specialname rtspecialname 
            Void .cctor() cil managed
        {
            .maxstack 8

            IL_0000: newobj     instance Void AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::.ctor()
            IL_0005: stsfld     class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc::_cds
            IL_000A: ret        
        } // .cctor

        // === FIELDS ===
        .field public static initonly class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc _cds
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_3
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_5
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_7
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_9
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_11
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_13
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_15
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_17
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_19
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_20
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_22
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_24
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_26
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_28
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_30
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_32
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_34
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_36
        .field public static System.Func`2<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel, String> _cd_46_48
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_49
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_51
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_53
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_38
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_40
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_42
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_44
        .field public static System.Func`1<class System.Threading.Tasks.Task> _cd_46_57
        // === METHODS ===
        // 0x06000927 RVA:0x0002C5C2
        .method public hidebysig specialname rtspecialname instance 
            Void .ctor() cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: call       void System.Object::.ctor
            IL_0006: ret        
        } // .ctor

        // 0x06000928 RVA:0x0002C5CC
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_3() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_3>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_3

        // 0x06000929 RVA:0x0002C608
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_5() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_5>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_5

        // 0x0600092A RVA:0x0002C644
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_7() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_7>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_7

        // 0x0600092B RVA:0x0002C680
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_9() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_9>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_9

        // 0x0600092C RVA:0x0002C6BC
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_11() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_11>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_11

        // 0x0600092D RVA:0x0002C6F8
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_13() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_13>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_13

        // 0x0600092E RVA:0x0002C734
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_15() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_15>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_15

        // 0x0600092F RVA:0x0002C770
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_17() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_17>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_17

        // 0x06000930 RVA:0x0002C7AC
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_19() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_19>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_19

        // 0x06000931 RVA:0x0002C7E8
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_20() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_20>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_20

        // 0x06000932 RVA:0x0002C824
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_22() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_22>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_22

        // 0x06000933 RVA:0x0002C860
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_24() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_24>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_24

        // 0x06000934 RVA:0x0002C89C
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_26() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_26>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_26

        // 0x06000935 RVA:0x0002C8D8
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_28() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_28>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_28

        // 0x06000936 RVA:0x0002C914
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_30() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_30>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_30

        // 0x06000937 RVA:0x0002C950
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_32() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_32>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_32

        // 0x06000938 RVA:0x0002C98C
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_34() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_34>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_34

        // 0x06000939 RVA:0x0002C9C8
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_36() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_36>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_36

        // 0x0600093A RVA:0x0002CA03
        .method assembly hidebysig instance 
            String _lm_ExecuteAsync_46_48(class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel r) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.1    
            IL_0001: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.RoleViewModel::get_ModuleId()
            IL_0006: ret        
        } // _lm_ExecuteAsync_46_48

        // 0x0600093B RVA:0x0002CA0C
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_49() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_49>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_49

        // 0x0600093C RVA:0x0002CA48
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_51() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_51>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_51

        // 0x0600093D RVA:0x0002CA84
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_53() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_53>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_53

        // 0x0600093E RVA:0x0002CAC0
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_38() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_38>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_38

        // 0x0600093F RVA:0x0002CAFC
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_40() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_40>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_40

        // 0x06000940 RVA:0x0002CB38
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_42() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_42>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_42

        // 0x06000941 RVA:0x0002CB74
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_44() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_44>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_44

        // 0x06000942 RVA:0x0002CBB0
        .method assembly hidebysig instance 
            class System.Threading.Tasks.Task _lm_ExecuteAsync_46_57() cil managed
        {
            .maxstack 2
            .locals init ([0] valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d)

            IL_0000: ldloca.s   V_0
            IL_0002: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create
            IL_0007: stfld      valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
            IL_000C: ldloca.s   V_0
            IL_000E: ldc.i4.m1  
            IL_000F: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_state
            IL_0014: ldloca.s   V_0
            IL_0016: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
            IL_001B: ldloca.s   V_0
            IL_001D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start<valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/<<ExecuteAsync>b__46_57>d>(!!0&)
            IL_0022: ldloca.s   V_0
            IL_0024: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
            IL_0029: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task
            IL_002E: ret        
        } // _lm_ExecuteAsync_46_57

        // === NESTED ===
        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d
        // Token: 0x02000295

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_11_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E38 RVA:0x0007153C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E39 RVA:0x0007158C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_11_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_11_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d
        // Token: 0x02000296

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_13_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E3A RVA:0x0007159C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E3B RVA:0x000715EC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_13_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_13_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d
        // Token: 0x02000297

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_15_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E3C RVA:0x000715FC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E3D RVA:0x0007164C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_15_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_15_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d
        // Token: 0x02000298

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_17_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E3E RVA:0x0007165C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E3F RVA:0x000716AC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_17_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_17_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d
        // Token: 0x02000299

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_19_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E40 RVA:0x000716BC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E41 RVA:0x0007170C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_19_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_19_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d
        // Token: 0x0200029A

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_20_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E42 RVA:0x0007171C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E43 RVA:0x0007176C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_20_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_20_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d
        // Token: 0x0200029B

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_22_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E44 RVA:0x0007177C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E45 RVA:0x000717CC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_22_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_22_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d
        // Token: 0x0200029C

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_24_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E46 RVA:0x000717DC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E47 RVA:0x0007182C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_24_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_24_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d
        // Token: 0x0200029D

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_26_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E48 RVA:0x0007183C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E49 RVA:0x0007188C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_26_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_26_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d
        // Token: 0x0200029E

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_28_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E4A RVA:0x0007189C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E4B RVA:0x000718EC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_28_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_28_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d
        // Token: 0x0200029F

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_30_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E4C RVA:0x000718FC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E4D RVA:0x0007194C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_30_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_30_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d
        // Token: 0x020002A0

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_32_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E4E RVA:0x0007195C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E4F RVA:0x000719AC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_32_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_32_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d
        // Token: 0x020002A1

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_34_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E50 RVA:0x000719BC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E51 RVA:0x00071A0C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_34_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_34_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d
        // Token: 0x020002A2

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_36_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E52 RVA:0x00071A1C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E53 RVA:0x00071A6C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_36_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_36_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d
        // Token: 0x020002A3

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_38_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E54 RVA:0x00071A7C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E55 RVA:0x00071ACC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_38_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_38_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d
        // Token: 0x020002A4

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_3_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E56 RVA:0x00071ADC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E57 RVA:0x00071B2C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_3_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_3_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d
        // Token: 0x020002A5

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_40_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E58 RVA:0x00071B3C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E59 RVA:0x00071B8C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_40_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_40_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d
        // Token: 0x020002A6

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_42_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E5A RVA:0x00071B9C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E5B RVA:0x00071BEC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_42_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_42_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d
        // Token: 0x020002A7

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_44_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E5C RVA:0x00071BFC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E5D RVA:0x00071C4C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_44_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_44_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d
        // Token: 0x020002A8

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_49_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E5E RVA:0x00071C5C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E5F RVA:0x00071CAC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_49_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_49_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d
        // Token: 0x020002A9

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_51_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E60 RVA:0x00071CBC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E61 RVA:0x00071D0C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_51_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_51_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d
        // Token: 0x020002AA

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_53_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E62 RVA:0x00071D1C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E63 RVA:0x00071D6C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_53_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_53_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d
        // Token: 0x020002AB

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_57_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E64 RVA:0x00071D7C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E65 RVA:0x00071DCC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_57_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_57_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d
        // Token: 0x020002AC

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_5_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E66 RVA:0x00071DDC
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E67 RVA:0x00071E2C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_5_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_5_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d
        // Token: 0x020002AD

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_7_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E68 RVA:0x00071E3C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E69 RVA:0x00071E8C
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_7_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_7_d

        // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d
        // Token: 0x020002AE

        .class nested private sealed auto ansi beforefieldinit ExecuteAsync_b_46_9_d
            extends System.ValueType
            implements
                System.Runtime.CompilerServices.IAsyncStateMachine
        {
            // === FIELDS ===
            .field public Int32 _state
            .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
            // === METHODS ===
            // 0x06000E6A RVA:0x00071E9C
            .method private final virtual hidebysig instance 
                Void MoveNext() cil managed
            {
                .maxstack 2
                .locals init ([0] Int32, [1] class System.Exception)

                IL_0000: ldarg.0    
                IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_state
                IL_0006: stloc.0    
                IL_0007: leave.s    IL_0020
                IL_0009: stloc.1    
                IL_000A: ldarg.0    
                IL_000B: ldc.i4.s   -2
                IL_000D: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_state
                IL_0012: ldarg.0    
                IL_0013: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
                IL_0018: ldloc.1    
                IL_0019: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
                IL_001E: leave.s    IL_0033
                IL_0020: ldarg.0    
                IL_0021: ldc.i4.s   -2
                IL_0023: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_state
                IL_0028: ldarg.0    
                IL_0029: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
                IL_002E: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
                IL_0033: ret        

                .try IL_0007 to IL_0009
                    catch System.Exception handler IL_0009 to IL_0020
            } // MoveNext

            // 0x06000E6B RVA:0x00071EEC
            .method private final virtual hidebysig instance 
                Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
            {
                .maxstack 8

                IL_0000: ldarg.0    
                IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_cc/ExecuteAsync_b_46_9_d::_builder
                IL_0006: ldarg.1    
                IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
                IL_000C: ret        
            } // SetStateMachine

        } // ExecuteAsync_b_46_9_d

    } // _cc

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_closure_46_0
    // Token: 0x02000102

    .class nested private sealed auto ansi beforefieldinit _closure_46_0
        extends System.Object
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 ix
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        // === METHODS ===
        // 0x06000943 RVA:0x0002CBEB
        .method public hidebysig specialname rtspecialname instance 
            Void .ctor() cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: call       void System.Object::.ctor
            IL_0006: ret        
        } // .ctor

    } // _closure_46_0

    // TYPE: AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46
    // Token: 0x02000103

    .class nested private sealed auto ansi beforefieldinit _sm_ExecuteAsync_46
        extends System.ValueType
        implements
            System.Runtime.CompilerServices.IAsyncStateMachine
    {
        .custom instance void System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor()
        // === FIELDS ===
        .field public Int32 _state
        .field public valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder _builder
        .field public class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create _this
        .field private valuetype System.Runtime.CompilerServices.TaskAwaiter _aw1
        // === METHODS ===
        // 0x06000944 RVA:0x0002CBF4
        .method private final virtual hidebysig instance 
            Void MoveNext() cil managed
        {
            .maxstack 7
            .locals init ([0] Int32, [1] class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create, [2] valuetype System.Runtime.CompilerServices.TaskAwaiter, [3] valuetype System.Runtime.CompilerServices.TaskAwaiter, [4] class System.Exception)

            IL_0000: ldarg.0    
            IL_0001: ldfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_0006: stloc.0    
            IL_0007: ldarg.0    
            IL_0008: ldfld      class AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_this
            IL_000D: stloc.1    
            IL_000E: ldloc.0    
            IL_000F: brfalse    IL_01B5
            IL_0014: ldloc.0    
            IL_0015: ldc.i4.1   
            IL_0016: beq        IL_0227
            IL_001B: ldloc.1    
            IL_001C: ldstr      "\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"x_panel\">\r\n            <div class=\"x_title\">\r\n                <h2>Api key <small>Create a new api key</small></h2>\r\n            </div>\r\n            <div class=\"x_content\">\r\n"
            IL_0021: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0026: ldloc.1    
            IL_0027: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_002C: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Password()
            IL_0031: brfalse.s  IL_0097
            IL_0033: ldloc.1    
            IL_0034: ldstr      "                    <div class=\"border m-5 p-2 rounded col-4 bg-white\">\r\n                        <h5 class=\"alert-success p-1 text-center\">Api key created</h5>\r\n                        <div class=\"form-group\">\r\n                            <div>\r\n                                Copy and save the api key to use with <b>x-api-key</b>. This api key will not\r\n                                be visible anymore.\r\n                            </div>\r\n                            <div class=\"form-group mt-2 p-2\">\r\n                                <small>Copy the api key by clicking on the following icon.</small>\r\n                                <div class=\"input-group\">\r\n                                    <input type=\"text\" class=\"form-control\" readonly"
            IL_0039: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_003E: ldloc.1    
            IL_003F: ldstr      "value"
            IL_0044: ldstr      " value=\""
            IL_0049: ldc.i4     1148
            IL_004E: ldstr      "\""
            IL_0053: ldc.i4     1171
            IL_0058: ldc.i4.1   
            IL_0059: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteAttribute
            IL_005E: ldloc.1    
            IL_005F: ldstr      ""
            IL_0064: ldc.i4     1156
            IL_0069: ldloc.1    
            IL_006A: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPage`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::get_Model
            IL_006F: callvirt   instance String Mega.Has.Modules.UAS.Areas.Admin.ViewModels.InputApiKeyViewModel::get_Password()
            IL_0074: ldc.i4     1156
            IL_0079: ldc.i4.s   15
            IL_007B: ldc.i4.0   
            IL_007C: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteAttributeValue
            IL_0081: ldloc.1    
            IL_0082: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteAttribute
            IL_0087: ldloc.1    
            IL_0088: ldstr      ">\r\n                                    <button class=\"btn btn-outline-secondary\" type=\"button\" onclick=\"copyToClipboard()\">\r\n                                        <i class=\"fa fa-clipboard\" aria-hidden=\"true\"></i>\r\n                                    </button>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"text-center\">\r\n                                <a class=\"btn btn-danger btn-ok\" href=\"/uas/admin/apikey\">Close</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n"
            IL_008D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0092: br         IL_0277
            IL_0097: ldloc.1    
            IL_0098: ldstr      "                    "
            IL_009D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_00A2: ldloc.1    
            IL_00A3: ldloc.1    
            IL_00A4: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_00A9: ldstr      "form"
            IL_00AE: ldc.i4.0   
            IL_00AF: ldstr      "f8babcf20db07b2c2260732237840ddcb48745929b89ca817a51aec4a7ab996017574"
            IL_00B4: ldloc.1    
            IL_00B5: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_0()
            IL_00BB: newobj     void System.Func`1<class System.Threading.Tasks.Task>::.ctor
            IL_00C0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::Begin
            IL_00C5: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_00CA: ldloc.1    
            IL_00CB: ldloc.1    
            IL_00CC: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>()
            IL_00D1: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
            IL_00D6: ldloc.1    
            IL_00D7: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_00DC: ldloc.1    
            IL_00DD: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
            IL_00E2: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_00E7: ldloc.1    
            IL_00E8: ldloc.1    
            IL_00E9: call       instance !!0 Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::CreateTagHelper<class Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>()
            IL_00EE: stfld      class Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
            IL_00F3: ldloc.1    
            IL_00F4: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_00F9: ldloc.1    
            IL_00FA: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper
            IL_00FF: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::Add
            IL_0104: ldloc.1    
            IL_0105: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::BeginWriteTagHelperAttribute
            IL_010A: ldloc.1    
            IL_010B: ldloc.1    
            IL_010C: call       void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::EndWriteTagHelperAttribute
            IL_0111: stfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_0116: ldloc.1    
            IL_0117: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_011C: ldstr      "data-parsley-validate"
            IL_0121: ldloc.1    
            IL_0122: call       instance Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel> AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get_Html()
            IL_0127: ldloc.1    
            IL_0128: ldfld      String AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperStringValueBuffer
            IL_012D: callvirt   void Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper`1<class Mega.Has.Modules.UAS.Areas.Admin.ViewModels.ApiKeyViewModel>::Raw
            IL_0132: ldc.i4.3   
            IL_0133: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_0138: ldloc.1    
            IL_0139: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_013E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_27
            IL_0143: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddHtmlAttribute
            IL_0148: ldloc.1    
            IL_0149: ldfld      class Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper
            IL_014E: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_28
            IL_0153: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute::get_Value
            IL_0158: castclass  System.String
            IL_015D: callvirt   void Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper::set_Method
            IL_0162: ldloc.1    
            IL_0163: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0168: ldsfld     class Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperAttribute_28
            IL_016D: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::AddTagHelperAttribute
            IL_0172: ldloc.1    
            IL_0173: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperRunner
            IL_0178: ldloc.1    
            IL_0179: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_017E: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner::RunAsync
            IL_0183: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_0188: stloc.2    
            IL_0189: ldloca.s   V_2
            IL_018B: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0190: brtrue.s   IL_01D1
            IL_0192: ldarg.0    
            IL_0193: ldc.i4.0   
            IL_0194: dup        
            IL_0195: stloc.0    
            IL_0196: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_019B: ldarg.0    
            IL_019C: ldloc.2    
            IL_019D: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_01A2: ldarg.0    
            IL_01A3: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
            IL_01A8: ldloca.s   V_2
            IL_01AA: ldarg.0    
            IL_01AB: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<ExecuteAsync>d__46>(!!0&, !!1&)
            IL_01B0: leave      IL_02DE
            IL_01B5: ldarg.0    
            IL_01B6: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_01BB: stloc.2    
            IL_01BC: ldarg.0    
            IL_01BD: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_01C2: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_01C8: ldarg.0    
            IL_01C9: ldc.i4.m1  
            IL_01CA: dup        
            IL_01CB: stloc.0    
            IL_01CC: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_01D1: ldloca.s   V_2
            IL_01D3: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_01D8: ldloc.1    
            IL_01D9: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01DE: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_01E3: callvirt   void Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput::get_IsContentModified
            IL_01E8: brtrue.s   IL_024A
            IL_01EA: ldloc.1    
            IL_01EB: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_01F0: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::SetOutputContentAsync
            IL_01F5: callvirt   void System.Threading.Tasks.Task::GetAwaiter
            IL_01FA: stloc.3    
            IL_01FB: ldloca.s   V_3
            IL_01FD: call       void System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted
            IL_0202: brtrue.s   IL_0243
            IL_0204: ldarg.0    
            IL_0205: ldc.i4.1   
            IL_0206: dup        
            IL_0207: stloc.0    
            IL_0208: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_020D: ldarg.0    
            IL_020E: ldloc.3    
            IL_020F: stfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_0214: ldarg.0    
            IL_0215: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
            IL_021A: ldloca.s   V_3
            IL_021C: ldarg.0    
            IL_021D: call       instance Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<valuetype System.Runtime.CompilerServices.TaskAwaiter, valuetype AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/<ExecuteAsync>d__46>(!!0&, !!1&)
            IL_0222: leave      IL_02DE
            IL_0227: ldarg.0    
            IL_0228: ldfld      valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_022D: stloc.3    
            IL_022E: ldarg.0    
            IL_022F: ldflda     valuetype System.Runtime.CompilerServices.TaskAwaiter AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_aw1
            IL_0234: initobj    System.Runtime.CompilerServices.TaskAwaiter
            IL_023A: ldarg.0    
            IL_023B: ldc.i4.m1  
            IL_023C: dup        
            IL_023D: stloc.0    
            IL_023E: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_0243: ldloca.s   V_3
            IL_0245: call       void System.Runtime.CompilerServices.TaskAwaiter::GetResult
            IL_024A: ldloc.1    
            IL_024B: ldloc.1    
            IL_024C: ldfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_0251: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext::get_Output
            IL_0256: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::Write
            IL_025B: ldloc.1    
            IL_025C: ldloc.1    
            IL_025D: call       instance class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::get___tagHelperScopeManager()
            IL_0262: callvirt   void Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager::End
            IL_0267: stfld      class Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::__tagHelperExecutionContext
            IL_026C: ldloc.1    
            IL_026D: ldstr      "\r\n"
            IL_0272: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0277: ldloc.1    
            IL_0278: ldstr      "            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n"
            IL_027D: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::WriteLiteral
            IL_0282: ldloc.1    
            IL_0283: ldstr      "styleSheets"
            IL_0288: ldloc.1    
            IL_0289: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_1()
            IL_028F: newobj     void Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate::.ctor
            IL_0294: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::DefineSection
            IL_0299: ldloc.1    
            IL_029A: ldstr      "Scripts"
            IL_029F: ldloc.1    
            IL_02A0: ldftn      instance class System.Threading.Tasks.Task AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create::_lm_ExecuteAsync_46_2()
            IL_02A6: newobj     void Microsoft.AspNetCore.Mvc.Razor.RenderAsyncDelegate::.ctor
            IL_02AB: callvirt   void Microsoft.AspNetCore.Mvc.Razor.RazorPageBase::DefineSection
            IL_02B0: leave.s    IL_02CB
            IL_02B2: stloc.s    V_4
            IL_02B4: ldarg.0    
            IL_02B5: ldc.i4.s   -2
            IL_02B7: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_02BC: ldarg.0    
            IL_02BD: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
            IL_02C2: ldloc.s    V_4
            IL_02C4: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException
            IL_02C9: leave.s    IL_02DE
            IL_02CB: ldarg.0    
            IL_02CC: ldc.i4.s   -2
            IL_02CE: stfld      Int32 AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_state
            IL_02D3: ldarg.0    
            IL_02D4: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
            IL_02D9: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult
            IL_02DE: ret        

            .try IL_000E to IL_02B2
                catch System.Exception handler IL_02B2 to IL_02CB
        } // MoveNext

        // 0x06000945 RVA:0x0002CEFC
        .method private final virtual hidebysig instance 
            Void SetStateMachine(class System.Runtime.CompilerServices.IAsyncStateMachine stateMachine) cil managed
        {
            .maxstack 8

            IL_0000: ldarg.0    
            IL_0001: ldflda     valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder AspNetCoreGeneratedDocument.Areas_Admin_Views_ApiKey_Create/_sm_ExecuteAsync_46::_builder
            IL_0006: ldarg.1    
            IL_0007: call       void System.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine
            IL_000C: ret        
        } // SetStateMachine

    } // _sm_ExecuteAsync_46

} // Areas_Admin_Views_ApiKey_Create
