// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Semainier.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Semainier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using Semainier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\_Imports.razor"
using SshNet;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "N:\3eme\PR_Proj\P_Practice\realisation\Application_web_vsc2022\Semainier\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
