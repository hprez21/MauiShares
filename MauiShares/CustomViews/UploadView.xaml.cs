using SkiaSharp.Extended.UI.Controls;
using System.Windows.Input;

namespace MauiShares.CustomViews;

public partial class UploadView : ContentView
{
    #region ViewBackground Bindable Property

    public static readonly BindableProperty ViewBackgroundProperty =
        BindableProperty.Create(
            nameof(ViewBackground),
            typeof(Color),
            typeof(UploadView),
            defaultValue: Colors.DarkRed,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if(bindable is UploadView instance)
                {
                    instance.BackgroundColor= (Color)newValue;
                }
            });    
    
    public Color ViewBackground
    {
        get => (Color)GetValue(ViewBackgroundProperty);
        set => SetValue(ViewBackgroundProperty, value);
    }

    #endregion

    #region TitleProperty
    public static readonly BindableProperty TitlePropertyProperty =
        BindableProperty.Create(
            nameof(TitleProperty),
            typeof(string),
            typeof(UploadView),
            defaultValue: "Upload your file",
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.TitleControl.Text = (string)newValue;
                }
            });

    public string TitleProperty
    {
        get => (string)GetValue(TitlePropertyProperty);
        set => SetValue(TitlePropertyProperty, value);
    }
    #endregion

    #region TitleColor
    public static readonly BindableProperty TitleColorProperty =
        BindableProperty.Create(
            nameof(TitleColor),
            typeof(Color),
            typeof(UploadView),
            defaultValue: Colors.White,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.TitleControl.TextColor = (Color)newValue;
                }
            });

    public Color TitleColor
    {
        get => (Color)GetValue(TitleColorProperty);
        set => SetValue(TitleColorProperty, value);
    }
    #endregion

    #region SubTitle
    public static readonly BindableProperty SubTitleProperty =
        BindableProperty.Create(
            nameof(SubTitle),
            typeof(string),
            typeof(UploadView),
            defaultValue: "Your gateway for easy sharing",
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.SubTitleControl.Text = (string)newValue;
                }
            });

    public string SubTitle
    {
        get => (string)GetValue(SubTitleProperty);
        set => SetValue(SubTitleProperty, value);
    }
    #endregion

    #region SubTitleColor
    public static readonly BindableProperty SubTitleColorProperty =
        BindableProperty.Create(
            nameof(SubTitleColor),
            typeof(Color),
            typeof(UploadView),
            defaultValue: Colors.White,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.SubTitleControl.TextColor = (Color)newValue;
                }
            });

    public Color SubTitleColor
    {
        get => (Color)GetValue(SubTitleColorProperty);
        set => SetValue(SubTitleColorProperty, value);
    }
    #endregion

    #region LottieFile
    public static readonly BindableProperty LottieFileProperty =
        BindableProperty.Create(
            nameof(LottieFile),
            typeof(string),
            typeof(UploadView),
            defaultValue: "",
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.LottieViewControl.Source = new SKFileLottieImageSource { File = (string)newValue  };
                }
            });

    public string LottieFile
    {
        get => (string)GetValue(LottieFileProperty);
        set => SetValue(LottieFileProperty, value);
    }
    #endregion

    #region ShowOverlay
    public static readonly BindableProperty ShowOverlayProperty =
        BindableProperty.Create(
            nameof(ShowOverlay),
            typeof(bool),
            typeof(UploadView),
            defaultValue: false,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance)
                {
                    instance.OverlayControl.IsVisible = (bool)newValue;
                    instance.ActivityControl.IsRunning = (bool)newValue;
                }
            });

    public bool ShowOverlay
    {
        get => (bool)GetValue(ShowOverlayProperty);
        set => SetValue(ShowOverlayProperty, value);
    }
    #endregion



    #region UploadCommand
    public static readonly BindableProperty UploadCommandProperty =
        BindableProperty.Create(
            nameof(UploadCommand),
            typeof(ICommand),
            typeof(UploadView),
            defaultValue: default(ICommand),
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                if (bindable is UploadView instance &&
                        instance.LottieViewControl.GestureRecognizers.FirstOrDefault() 
                            is TapGestureRecognizer recognizer)
                {
                    recognizer.Command = (ICommand)newValue;
                }
            });

    public ICommand UploadCommand
    {
        get => (ICommand)GetValue(UploadCommandProperty);
        set => SetValue(UploadCommandProperty, value);
    }
    #endregion

    public UploadView()
	{
		InitializeComponent();
	}
}