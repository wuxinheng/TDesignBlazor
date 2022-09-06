using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;

namespace TDesignBlazor._6x.Component
{
    public partial class TButton : ComponentBase
    {
        private string _class;
        [Parameter]
        public string Class { get => _class; set => _class = value; }

        private string _style;
        [Parameter]
        public string Style { get => _style; set => _style = value; }

        private string _text;
        [Parameter]
        public string Text { get => _text; set => _text = value; }

        protected override void OnInitialized()
        {
            Class = "";
            Style = "color:red;";
            Text = "1234";
            base.OnInitialized();
        }
    }
}
