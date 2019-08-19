#pragma checksum "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b6602eb79b6cef7dbcb6cf453a246485349207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListeConcerts), @"mvc.1.0.view", @"/Views/Home/ListeConcerts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListeConcerts.cshtml", typeof(AspNetCore.Views_Home_ListeConcerts))]
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
#line 1 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\_ViewImports.cshtml"
using ReservationPlace;

#line default
#line hidden
#line 2 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\_ViewImports.cshtml"
using ReservationPlace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b6602eb79b6cef7dbcb6cf453a246485349207", @"/Views/Home/ListeConcerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69eeeefb838ebf427c235b28f55dce0d86ac0c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListeConcerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 463, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function dynamicLink(){
        var arg = document.getElementById('lieu').value;
        document.getElementById('dynamic').href += arg;
    }
</script>

<table style=""margin: 0 auto; border-collapse: separate; border-spacing: 25px; border-style: dotted;"">
    <tr>
        <th>Nom</th>
        <th>Artiste</th>
        <th>Date</th>
        <th>Lieu</th>
        <th>Nombre de places restantes</th>
    </tr>

");
            EndContext();
#line 17 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
     foreach (ReservationPlace.Models.Concert concert in ViewBag.Concerts as List<ReservationPlace.Models.Concert>)
        {

#line default
#line hidden
            BeginContext(591, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(630, 11, false);
#line 20 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
               Write(concert.Nom);

#line default
#line hidden
            EndContext();
            BeginContext(641, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(669, 15, false);
#line 21 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
               Write(concert.Artiste);

#line default
#line hidden
            EndContext();
            BeginContext(684, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(712, 33, false);
#line 22 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
               Write(concert.DateConcert.ToString("g"));

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 12, false);
#line 23 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
               Write(concert.Lieu);

#line default
#line hidden
            EndContext();
            BeginContext(785, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(813, 22, false);
#line 24 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
               Write(concert.NombreDePlaces);

#line default
#line hidden
            EndContext();
            BeginContext(835, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
        }   

#line default
#line hidden
            BeginContext(875, 44, true);
            WriteLiteral("</table>\r\n\r\n<br><br><br><br><br><br><br>\r\n\r\n");
            EndContext();
            BeginContext(920, 57, false);
#line 31 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
Write(Html.Label("lieu", "Effectuer une recherche par lieu : "));

#line default
#line hidden
            EndContext();
            BeginContext(977, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(980, 20, false);
#line 32 "C:\Users\Benjamin\Documents\sdz\ReservationPlace\Views\Home\ListeConcerts.cshtml"
Write(Html.TextBox("lieu"));

#line default
#line hidden
            EndContext();
            BeginContext(1000, 89, true);
            WriteLiteral("\r\n<a href=\"/Home/ListeConcerts/\" id=\"dynamic\" onclick=\"dynamicLink();\">Rechercher</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
