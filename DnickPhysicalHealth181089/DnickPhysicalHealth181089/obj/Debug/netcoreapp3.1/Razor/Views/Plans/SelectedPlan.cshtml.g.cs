#pragma checksum "C:\Users\stoja\source\repos\DnickPhysicalHealth181089\DnickPhysicalHealth181089\Views\Plans\SelectedPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bad3ec84598bb356ff95407a851b9c894f85fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plans_SelectedPlan), @"mvc.1.0.view", @"/Views/Plans/SelectedPlan.cshtml")]
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
#line 1 "C:\Users\stoja\source\repos\DnickPhysicalHealth181089\DnickPhysicalHealth181089\Views\_ViewImports.cshtml"
using DnickPhysicalHealth181089;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stoja\source\repos\DnickPhysicalHealth181089\DnickPhysicalHealth181089\Views\_ViewImports.cshtml"
using DnickPhysicalHealth181089.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stoja\source\repos\DnickPhysicalHealth181089\DnickPhysicalHealth181089\Views\Plans\SelectedPlan.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bad3ec84598bb356ff95407a851b9c894f85fd", @"/Views/Plans/SelectedPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4983a51f930b80e95903c3e329388ed5e15acb86", @"/Views/_ViewImports.cshtml")]
    public class Views_Plans_SelectedPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd4541", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.3/css/all.css"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.3/css/v4-shims.css"">

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h3>Program: ");
#nullable restore
#line 14 "C:\Users\stoja\source\repos\DnickPhysicalHealth181089\DnickPhysicalHealth181089\Views\Plans\SelectedPlan.cshtml"
        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'s plan</h3>
<br />
<h4 class=""text-warning"">Monday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/jkv-RMuigaA"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/UBMk30rjy0o"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Workout
            </div>
 ");
            WriteLiteral(@"       </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd7804", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<h4 class=""text-warning"">Tuesday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/-p0PA9Zt8zk"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe> <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/Y2eOW7XYWxc"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>  <div class=""card-body text-center text-warning"">
                Workout
            </div>
        </div>
    </div");
            WriteLiteral(@">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd10968", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<h4 class=""text-warning"">Wednesday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/GtFO7P8sr0E"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>   <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/jpizoUy4K9s"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>  <div class=""card-body text-center text-warning"">
                Workout
            </div>
        </div>
    <");
            WriteLiteral(@"/div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd14137", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<h4 class=""text-warning"">Thursday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/jkv-RMuigaA"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/UBMk30rjy0o"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Workout
            </div");
            WriteLiteral(@">
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd17330", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<h4 class=""text-warning"">Friday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/jkv-RMuigaA"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/Y2eOW7XYWxc"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>  <div class=""card-body text-center text-warning"">
                Workout
            </div>
        </d");
            WriteLiteral(@"iv>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd20509", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<h4 class=""text-warning"">Saturday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/GtFO7P8sr0E"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe> <div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/UBMk30rjy0o"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Workout
            </div>
        </di");
            WriteLiteral(@"v>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd23687", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>


<h4 class=""text-warning"">Sunday</h4>
<div class=""row"">
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">
            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/-p0PA9Zt8zk"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe><div class=""card-body text-center text-warning"">
                Warm up
            </div>
        </div>
    </div>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/jpizoUy4K9s"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe> <div class=""card-body text-center text-warning"">
                Workout
            </div>
        </div>
    </di");
            WriteLiteral(@"v>
    <div class=""col"">
        <div class=""card"" style=""width: 300px; height: 250px;"">

            <iframe width=""300"" height=""200"" src=""https://www.youtube.com/embed/72MQmD8Z9Zw"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
            <div class=""card-body text-center text-warning"">
                Stretch
            </div>
        </div>
    </div>
    <div class=""col"" style=""padding-top:10px"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bad3ec84598bb356ff95407a851b9c894f85fd26853", async() => {
                WriteLiteral(" Share with your friends <i class=\"fas fa-share-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<PHUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<PHUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plan> Html { get; private set; }
    }
}
#pragma warning restore 1591
