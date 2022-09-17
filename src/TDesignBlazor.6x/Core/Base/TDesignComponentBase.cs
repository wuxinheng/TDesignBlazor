using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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
        public string Id { get; set; }
        [Parameter]
        public string Class { get; set; }
        [Parameter]
        public string Style { get; set; }
        /// <summary>
        /// 标签类容
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        /// <summary>
        /// 点击委托
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> Click { get; set; }
        /// <summary>
        /// 点击执行
        /// </summary>
        private async Task OnClick(MouseEventArgs args)
        {
            if (Click.HasDelegate)
            {
                await Click.InvokeAsync(args);
            }
        }

        /// <summary>
        /// 全局配置上下文
        /// </summary>
        public TContext Context { get; set; }
    }
}
