#pragma checksum "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00bffbdccb2ace52d2b73408d7f78932618a2f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contest_WorkPost), @"mvc.1.0.view", @"/Views/Contest/WorkPost.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\_ViewImports.cshtml"
using Competition_PRO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\_ViewImports.cshtml"
using Competition_PRO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bffbdccb2ace52d2b73408d7f78932618a2f34", @"/Views/Contest/WorkPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5174aea89f28a86a484e31be1197052ad41708f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Contest_WorkPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Competition_PRO.Models.WorkPostInputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/WorkPost.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "00bffbdccb2ace52d2b73408d7f78932618a2f344288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
   string[] categories = {
        "Освобождаване връзка включател - четкодържател",
        "Освобождаване връзка заден капак - четкодържател",
        "Демонтаж, монтаж заден капак и четкодържател",
        "Демонтаж, монтаж стартор и ротор",
        "Демонтаж, монтаж включвател и котва",
        "Демонтаж, монтаж редуктор",
        "Измерване ротор за късо съединение",
        "Оценка състояние четки",
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div id=\"accordion\">\n    <div class=\"card\">\n        <div class=\"card-header text-center\">\n            <a class=\"card-link \" data-toggle=\"collapse\" href=\"#collapseOne\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00bffbdccb2ace52d2b73408d7f78932618a2f346217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 23 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TeamName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 23 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                                                     Write(Model.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00bffbdccb2ace52d2b73408d7f78932618a2f348114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 24 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TeamNumber);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </a>
        </div>
        <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordion"">
            <div class=""cardInside"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col"" rowspan=""2"">Критерии</th>
                            <th scope=""col"" rowspan=""2"">Макс. бр. точки</th>
                            <th scope=""col"" colspan=""2"">Получени точки от състезателите</th>
                        </tr>
                        <tr>
");
#nullable restore
#line 37 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                              int index = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                             foreach (var item in Model.Participants)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>\n                                #");
#nullable restore
#line 41 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                             Write(index+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <input");
            BeginWriteAttribute("name", " name=\"", 1652, "\"", 1684, 3);
            WriteAttributeValue("", 1659, "Participants[", 1659, 13, true);
#nullable restore
#line 42 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 1672, index, 1672, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1678, "].Name", 1678, 6, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1699, "\"", 1717, 1);
#nullable restore
#line 42 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 1707, item.Name, 1707, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                                <input");
            BeginWriteAttribute("name", " name=\"", 1760, "\"", 1790, 3);
            WriteAttributeValue("", 1767, "Participants[", 1767, 13, true);
#nullable restore
#line 43 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 1780, index, 1780, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1786, "].Id", 1786, 4, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1805, "\"", 1821, 1);
#nullable restore
#line 43 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 1813, item.Id, 1813, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            </th>");
#nullable restore
#line 44 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                                 index++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n                    </thead>\n                    <tbody>\n");
#nullable restore
#line 49 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                         foreach (var category in categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 52 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                           Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td >10</td>\n                            <td ><input type=\"number\"");
            BeginWriteAttribute("name", " name=\"", 2243, "\"", 2283, 3);
            WriteAttributeValue("", 2250, "Participants[0].Points[", 2250, 23, true);
#nullable restore
#line 54 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 2273, category, 2273, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2282, "]", 2282, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                            <td ><input type=\"number\"");
            BeginWriteAttribute("name", " name=\"", 2346, "\"", 2386, 3);
            WriteAttributeValue("", 2353, "Participants[1].Points[", 2353, 23, true);
#nullable restore
#line 55 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
WriteAttributeValue("", 2376, category, 2376, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2385, "]", 2385, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /></td>\n                        </tr>\n");
#nullable restore
#line 57 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00bffbdccb2ace52d2b73408d7f78932618a2f3415761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 60 "C:\MyPrograms\Diplomen Proect\CompetitionPRO2-master\Views\Contest\WorkPost.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JuryMemberId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <input type=\"submit\" class=\"btn btn-primary\" />\n");
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""card"">
        <div class=""card-header text-center"">
            <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseTwo"">
                Collapsible Group Item #2
            </a>
        </div>
        <div id=""collapseTwo"" class=""collapse"" data-parent=""#accordion"">
            <div class=""card-body"">
                Lorem ipsum..
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Competition_PRO.Models.WorkPostInputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
