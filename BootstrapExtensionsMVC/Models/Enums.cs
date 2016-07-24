using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BootstrapExtensionsMVC.Models
{
    internal enum BootstrapElements
    {
        [Display(Name = "")]
        None,

        [Display(Name = "alert")]
        Alert,

        [Display(Name = "tooltip")]
        ToolTip,

        [Display(Name = "popover")]
        PopOver,

        [Display(Name = "col")]
        Column,

        [Display(Name = "row")]
        Row,

        [Display(Name = "badge")]
        Badge,

        [Display(Name = "btn")]
        Button,

        //[Display(Name = "btn")]
        Link,

        [Display(Name = "well")]
        Well,

        [Display(Name = "label")]
        Label,

        [Display(Name = "panel")]
        Panel,

        [Display(Name = "modal")]
        Modal,

        [Display(Name = "text")]
        Text,

        [Display(Name = "bg")]
        Background,

        [Display(Name = "list-group")]
        ListGroup,

        [Display(Name = "list-group-item")]
        ListGroupItem,

        [Display(Name = "")]
        ListItem,

        [Display(Name = "")]
        Blockquote,

        [Display(Name = "dropdown")]
        Dropdown,

        [Display(Name= "nav")]
        Nav
    }

    internal enum Tags
    {
        [Display(Name = "a")]
        Anchor,

        [Display(Name = "span")]
        Span,

        [Display(Name = "div")]
        Div,

        [Display(Name = "label")]
        Label,

        [Display(Name = "button")]
        Button,

        [Display(Name = "ul")]
        List,

        [Display(Name = "li")]
        ListItem,

        [Display(Name = "blockquote")]
        Blockquote
    }

    public enum ButtonSizes
    {
        [Display(Name = "btn-xs")]
        XtraSmall,

        [Display(Name = "btn-sm")]
        Small,

        [Display(Name = "")]
        Default,

        [Display(Name = "btn-lg")]
        Large
    }

    public enum ButtonStyles
    {
        [Display(Name = "btn-default")]
        Default,

        [Display(Name = "btn-primary")]
        Primary,

        [Display(Name = "btn-info")]
        Info,

        [Display(Name = "btn-success")]
        Success,

        [Display(Name = "btn-warning")]
        Warning,

        [Display(Name = "btn-danger")]
        Danger,

        [Display(Name = "btn-link")]
        Link
    }

    public enum ButtonTypes
    {
        [Display(Name = "button")]
        Button,

        [Display(Name = "submit")]
        Submit
    }

    public enum Positions
    {
        [Display(Name = "auto")]
        Auto,

        [Display(Name = "top")]
        Top,

        [Display(Name = "bottom")]
        Bottom,

        [Display(Name = "left")]
        Left,

        [Display(Name = "right")]
        Right

    }

    public enum Triggers
    {
        [Display(Name = "click")]
        Click,

        [Display(Name = "hover")]
        Hover,

        [Display(Name = "focus")]
        Focus,

        [Display(Name = "manual")]
        Manual
    }

    public enum ColumnSizes
    {
        [Display(Name = "sm")]
        Small,

        [Display(Name = "md")]
        Medium,

        [Display(Name = "lg")]
        Large
    }

    public enum ColumnLengths
    {
        [Display(Name = "3", Order = 1)]
        Quarter,
        [Display(Name = "4", Order = 2)]
        Third,
        [Display(Name = "6", Order = 3)]
        Half,
        [Display(Name = "12", Order = 3)]
        Full,

        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three,
        [Display(Name = "4")]
        Four,
        [Display(Name = "5")]
        Five,
        [Display(Name = "6")]
        Six,
        [Display(Name = "7")]
        Seven,
        [Display(Name = "8")]
        Eight,
        [Display(Name = "9")]
        Nine,
        [Display(Name = "10")]
        Ten,
        [Display(Name = "11")]
        Eleven,
        [Display(Name = "12")]
        Twelve
    }

    public enum Colors
    {
        [Display(Name = "default")]
        Default,

        [Display(Name = "primary")]
        Primary,

        [Display(Name = "info")]
        Info,

        [Display(Name = "success")]
        Success,

        [Display(Name = "warning")]
        Warning,

        [Display(Name = "danger")]
        Danger,

        //[Display(Name="inverse")]
        //Inverse
    }

    public enum AlertStyles
    {
        [Display(Name = "alert-info")]
        Info,

        [Display(Name = "alert-success")]
        Success,

        [Display(Name = "alert-warning")]
        Warning,

        [Display(Name = "alert-danger")]
        Danger,
    }

    public enum Directions
    {
        Vertical,

        Horizontal
    }

    public enum HeadingTypes
    {
        [Display(Name = "h1")]
        H1,
        [Display(Name = "h2")]
        H2,
        [Display(Name = "h3")]
        H3,
        [Display(Name = "h4")]
        H4,
        [Display(Name = "h5")]
        H5,
        [Display(Name = "h6")]
        H6
    }

    public enum NavTypes
    {
        [Display(Name="nav-pills")]
        Pills,

        [Display(Name = "nav-pills nav-stacked")]
        PillsVertical,

        [Display(Name = "nav-tabs")]
        Tabs
        
        //,

        //[Display(Name="btn-group")]
        //ButtonGroup
    }

}
