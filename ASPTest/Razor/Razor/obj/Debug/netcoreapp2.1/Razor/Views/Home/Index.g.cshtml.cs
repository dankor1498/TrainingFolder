#pragma checksum "E:\Documents\Предмети\Програмування\TrainingFolder\ASPTest\Razor\Razor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d6c2e8b43337b782d0e5ea1bbbc6da129082c3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6c2e8b43337b782d0e5ea1bbbc6da129082c3c", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Razor.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba65d5affd9475ca5963d734f4604f1", async() => {
                BeginContext(62, 70, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Створення сцени</title>\r\n    ");
                EndContext();
                BeginContext(132, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c0a8cc1aedfa402a9d32e22c4d3f932b", async() => {
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
                EndContext();
                BeginContext(178, 356, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <script src=""/js/three.min.js""></script>
    <script src=""/js/OrbitControls.js""></script>
    <script src=""/js/main.js""></script>
");
                EndContext();
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
            EndContext();
            BeginContext(541, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(543, 3274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0993d0741cb14c9e825169ad96c746ff", async() => {
                BeginContext(549, 3261, true);
                WriteLiteral(@"
    <script>  
        var width = window.innerWidth;
        var height = window.innerHeight;
        var canvas = document.getElementById('canvas');

        canvas.setAttribute('width', width);
        canvas.setAttribute('height', height);

        var renderer = new THREE.WebGLRenderer({ canvas: canvas });
        renderer.setClearColor(0x050505);

        var scene = new THREE.Scene();

        var camera = new THREE.PerspectiveCamera(35, width / height, 0.1, 5000);

        var light = new THREE.AmbientLight(0xffffff);
        scene.add(light);
        //Організація повороту камери, зміна масштабу
        var controls = new THREE.OrbitControls(camera, renderer.domElement);
        camera.position.set(300, 200, 1000);
        controls.update();
        //Створення куба
        var geometry = new THREE.BoxGeometry(100, 100, 100, 1);
        var material = new THREE.MeshBasicMaterial({ color: 0xffff00, wireframe: true });
        var cube = new THREE.Mesh(geometry, material);
  ");
                WriteLiteral(@"      cube.position.set(150, 150, 150);
        scene.add(cube);
    </script>
    <div class=""contain"">
        <canvas id=""canvas""></canvas>
        <div class=""form form-group"">
            <div class=""row"">
                <input type=""number"" class=""x11"" name=""11"" value=""1"" id=""11"" step=""0.01"" onfocus=""this.value=1"">
                <input type=""number"" name=""12"" value=""0"" id=""12"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""13"" value=""0"" id=""13"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" class=""x14"" name=""14"" value=""0"" id=""14"" step=""0.01"" onfocus=""this.value=0"">
            </div>
            <div class=""row"">
                <input type=""number"" name=""21"" value=""0"" id=""21"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""22"" value=""1"" id=""22"" step=""0.01"" onfocus=""this.value=1"">
                <input type=""number"" name=""23"" value=""0"" id=""23"" step=""0.01"" onfocus=""this.value=0"">
                <");
                WriteLiteral(@"input type=""number"" name=""24"" value=""0"" id=""24"" step=""0.01"" onfocus=""this.value=0"">
            </div>
            <div class=""row"">
                <input type=""number"" name=""31"" value=""0"" id=""31"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""32"" value=""0"" id=""32"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""33"" value=""1"" id=""33"" step=""0.01"" onfocus=""this.value=1"">
                <input type=""number"" name=""34"" value=""0"" id=""34"" step=""0.01"" onfocus=""this.value=0"">
            </div>
            <div class=""row"">
                <input type=""number"" class=""x41"" name=""41"" value=""0"" id=""41"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""42"" value=""0"" id=""42"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" name=""43"" value=""0"" id=""43"" step=""0.01"" onfocus=""this.value=0"">
                <input type=""number"" class=""x44"" name=""44"" value=""1"" id=""44"" step=""0.01"" onfocus=""this.value=1""");
                WriteLiteral(">\r\n            </div>\r\n            <button id=\"btn1\" class=\"btn btn-primary\">Apply matrix</button>\r\n            <h4>History</h4>\r\n            <p id=\"p1\"></p>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3817, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Razor.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
