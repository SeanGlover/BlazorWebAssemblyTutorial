#pragma checksum "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "025f238971ea0f056df8a18dfaf2567ce151bcc821ae3638585a88f02b040dac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProject.Client.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using BlazorProject.Client.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\_Imports.razor"
using Syncfusion.Blazor

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
 using BlazorProject.Shared

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
 using Syncfusion.Blazor.Grids

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
      "/"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.BlazorProject.Client.Pages.Index.TypeInference.CreateSfGrid_0(__builder, 0, 1, 
#nullable restore
#line 7 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                     Employees

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumns>(3);
                __builder2.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(5);
                    __builder3.AddAttribute(6, "Field", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                           nameof(Employee.EmployeeId)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(7, "HeaderText", (object)("ID"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n        ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(9);
                    __builder3.AddAttribute(10, "Field", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 10 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                           nameof(Employee.FirstName)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(11, "HeaderText", (object)("First Name"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(13);
                    __builder3.AddAttribute(14, "Field", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                           nameof(Employee.LastName)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(15, "HeaderText", (object)(" Last Name"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(17);
                    __builder3.AddAttribute(18, "Field", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                           nameof(Employee.Email)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(19, "HeaderText", (object)("Email"));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
      
    protected List<Employee> Employees { get; set; }

    protected override void OnInitialized()
    {
        //Employees = LoadData();
        Console.WriteLine("OnInitialized");
    }
    protected override async Task OnInitializedAsync()
    {
        //SomeStartupMethod();
        //Task xx = SomeStartupTask();
        //await xx;
        //Employees = await SomeStartupTask();
        Employees = await Http.GetFromJsonAsync<List<Employee>>("api/employees");
    }
    void SomeStartupMethod()
    {
        // Do Some Work
    }
    private async Task<List<Employee>> SomeStartupTask()
    {
        // Do some task based work
        // return Task.CompletedTask;
        return await Http.GetFromJsonAsync<List<Employee>>("api/employees");
    }
    private List<Employee> LoadData()
    {
        Employee e1 = new Employee
        {
            EmployeeId = 1,
            FirstName = "John",
            LastName = "Hastings",
            Email = "john@pragimtech.com",
            DateOfBirth = new DateTime(1980, 10, 5),
            Gender = Gender.Male,
            Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
            PhotoPath = "images/john.png"
        };

        Employee e2 = new Employee
        {
            EmployeeId = 2,
            FirstName = "Sam",
            LastName = "Galloway",
            Email = "sam@pragimtech.com",
            DateOfBirth = new DateTime(1981, 12, 22),
            Gender = Gender.Male,
            Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
            PhotoPath = "images/sam.jpg"
        };

        Employee e3 = new Employee
        {
            EmployeeId = 3,
            FirstName = "Mary",
            LastName = "Smith",
            Email = "mary@pragimtech.com",
            DateOfBirth = new DateTime(1979, 11, 11),
            Gender = Gender.Female,
            Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
            PhotoPath = "images/mary.png"
        };

        Employee e4 = new Employee
        {
            EmployeeId = 3,
            FirstName = "Sara",
            LastName = "Longway",
            Email = "sara@pragimtech.com",
            DateOfBirth = new DateTime(1982, 9, 23),
            Gender = Gender.Female,
            Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
            PhotoPath = "images/sara.png"
        };

        return new List<Employee> { e1, e2, e3, e4 };
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
        HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                   Http

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\SeanGlover\source\repos\NET 5 REST API Tutorial\.NET 5 REST API Tutorial\BlazorWebAssemblyTutorial\BlazorProject\Client\Pages\Index.razor"
                   JsRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.BlazorProject.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", (object)__arg0);
        __builder.AddAttribute(__seq1, "ChildContent", (object)__arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
