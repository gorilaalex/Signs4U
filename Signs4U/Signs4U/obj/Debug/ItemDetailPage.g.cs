﻿

#pragma checksum "E:\apps\signs4u\Signs4U\Signs4U\ItemDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB2480BA4C0BCD9372082C7EFA81C9F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Signs4U
{
    partial class ItemDetailPage : global::Signs4U.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 148 "..\..\ItemDetailPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 64 "..\..\ItemDetailPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.StartLayoutUpdates;
                 #line default
                 #line hidden
                #line 64 "..\..\ItemDetailPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Unloaded += this.StopLayoutUpdates;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


