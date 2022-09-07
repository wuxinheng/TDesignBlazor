using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDesignBlazor._6x.Core.Base
{
    public class TDesignComponentBase : ComponentBase, ITDesignComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
