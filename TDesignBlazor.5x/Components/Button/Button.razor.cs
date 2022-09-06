using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TDesignBlazor._5x.Components.Button
{
    public partial class Button: ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Text { get; set; }
        [Parameter]
        public string Color { get; set; }
        [Parameter]
        public string Width { get; set; }
        [Parameter]
        public string Height { get; set; }

        protected override void OnInitialized()
        {
            
            base.OnInitialized();
            Color = "color:red;";
            Width = "width:10px;";
            Height = "height:10px;";
        }
    }
}
