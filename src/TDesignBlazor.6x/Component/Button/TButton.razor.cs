using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

using System;
using System.Collections.Generic;
using System.Linq;

namespace TDesignBlazor._6x.Component
{
    public partial class TButton : ComponentBase
    {
        /// <summary>
        /// 是否为块级元素
        /// </summary>
        [Parameter]
        public bool Block { get; set; } = false;
        /// <summary>
        /// 按钮内容
        /// </summary>
        [Parameter]
        public RenderFragment Content { get; set; }
        /// <summary>
        /// 按钮内容
        /// </summary>
        [Parameter]
        public object? @Default { get; set; }
        /// <summary>
        /// 是否禁用按钮
        /// </summary>
        [Parameter]
        public bool Disabled { get; set; } = false;
        /// <summary>
        /// 是否为幽灵按钮（镂空按钮）
        /// </summary>
        [Parameter]
        public bool Ghost { get; set; } = false;
        /// <summary>
        /// 跳转地址。href 存在时，按钮标签默认使用 <a> 渲染；如果指定了 tag 则使用指定的标签渲染
        /// </summary>
        [Parameter]
        public string Href { get; set; }
        /// <summary>
        /// 按钮内部图标，可完全自定义
        /// </summary>
        [Parameter]
        public object Icon { get; set; }
        /// <summary>
        /// 是否显示为加载状态
        /// </summary>
        [Parameter]
        public bool Loading { get; set; } = false;
        /// <summary>
        /// 按钮形状，有 4 种：长方形、正方形、圆角长方形、圆形。可选项：rectangle/square/round/circle
        /// </summary>
        [Parameter]
        public string Shape { get; set; } = "rectangle";
        /// <summary>
        /// 组件尺寸。可选项：small/medium/large
        /// </summary>
        [Parameter]
        public string Size { get; set; } = "medium";
        /// <summary>
        /// 渲染按钮的 HTML 标签，默认使用标签 <button> 渲染，可以自定义为 <a> <div> 等。透传全部 HTML 属性，如：href/target/data-* 等。⚠️ 禁用按钮 <button disabled>无法显示 Popup 浮层信息，可通过修改 tag=div 解决这个问题。可选项：button/a/div
        /// </summary>
        [Parameter]
        public string Tag { get; set; } = "button";
        /// <summary>
        /// 组件风格，依次为默认色、品牌色、危险色、警告色、成功色。可选项：default/primary/danger/warning/success
        /// </summary>
        [Parameter]
        public string Theme { get; set; } = "undefined";
        /// <summary>
        /// 按钮类型。可选项：submit/reset/button
        /// </summary>
        [Parameter]
        public string Type { get; set; } = "button";
        /// <summary>
        /// 按钮形式，基础、线框、虚线、文字。可选项：base/outline/dashed/text
        /// </summary>
        [Parameter]
        public string Variant { get; set; } = "base";
        [Parameter]
        public EventCallback<MouseEventArgs> Click { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected static readonly EventCallbackFactory CallbackFactory = new EventCallbackFactory();
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        private async Task OnClick(MouseEventArgs args)
        {
            if (Click.HasDelegate)
            {
                await Click.InvokeAsync(args);
            }
        }

        //RenderFragment GetRenderFragment()
        //{
        //    if (ChildContent.GetHashCode() == 0)
        //    {
        //    }
        //}

    }

}
