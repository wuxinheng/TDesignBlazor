# TDesignBlazor
<p align="center">
  <a href="https://tdesign.tencent.com/" target="_blank">
    <img alt="TDesign Logo" width="200" src="https://tdesign.gtimg.com/site/TDesign.png">
  </a>
</p>
<p align="center">
  <a href="https://github.com/wuxinheng/TDesignBlazor/blob/main/LICENSE">
    <img src="https://img.shields.io/npm/l/tdesign-vue.svg?sanitize=true" alt="License">
  </a>
</p>


TDesignBlazor Beta 依赖腾讯[TDesign](https://tdesign.tencent.com/)框架UI

# 🎉 特性

- 适配桌面端交互（开发中）
- 与其他框架实现版本 API、UI 最大程度上保持一致（开发中）
- 支持暗黑模式及其他主题定制（开发中）
- 支持按需加载（开发中）

# 安装

```shell
nstall-Package TDesign -Version 0.0.1-preview
```

# 基础使用

_Host.cshtml引入外部文件,前期建议先缓存下来，地址：

https://github.com/wuxinheng/TDesignBlazor/blob/main/samples/BlazorServerApp/wwwroot/tdesign.css

https://github.com/wuxinheng/TDesignBlazor/blob/main/samples/BlazorServerApp/wwwroot/tdesign.js

```html
<link href="~/tdesign.css" rel="stylesheet" />
<script src="~/tdesign.js"></script>
```

_Imports.razor中导入

```js
@using TDesignBlazor._6x.Component
```

更多使用建议或问题，可以在 [这里]([Issues · wuxinheng/TDesignBlazor (github.com)](https://github.com/wuxinheng/TDesignBlazor/issues)) 了解相关信息。

# 快速体验

可以访问官方提供的 [TDesign Starter](https://tdesign.tencent.com/starter/vue/) 项目体验使用 TDesign 组件快速搭建业务系统。

# 开源协议

TDesignBlazor 遵循 [MIT 协议]([TDesignBlazor/LICENSE at main · wuxinheng/TDesignBlazor (github.com)](https://github.com/wuxinheng/TDesignBlazor/blob/main/LICENSE))。

# 开发计划

第一步，优先考虑UI组件的基本使用。

第二步，完善不易实现的API

第三步，完善组件动效

第四步，编写单元测试

第五步，发布正式版

第六步，优化使用文档

开源不易，工作业余时间完成，有意向一起参加请联系我:email:934041144@qq.com
