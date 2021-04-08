// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

// DO NOT EDIT! This file was generated by CustomTasks.DependencyPropertyCodeGen

// Imported in uno on 2021/03/21 from commit 307bd99682cccaa128483036b764c0b7c862d666
// https://github.com/microsoft/microsoft-ui-xaml/blob/307bd99682cccaa128483036b764c0b7c862d666/dev/Generated/SwipeItem.properties.cpp

using System.Windows.Input;
using Windows.Foundation;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
	public partial class SwipeItem
	{
		//GlobalDependencyProperty s_BackgroundProperty{ null };
		//GlobalDependencyProperty s_BehaviorOnInvokedProperty{ null };
		//GlobalDependencyProperty s_CommandProperty{ null };
		//GlobalDependencyProperty s_CommandParameterProperty{ null };
		//GlobalDependencyProperty s_ForegroundProperty{ null };
		//GlobalDependencyProperty s_IconSourceProperty{ null };
		//GlobalDependencyProperty s_TextProperty{ null };

		//SwipeItemProperties()
		//    : m_invokedEventSource{(SwipeItem)(this)}
		//{
		//    EnsureProperties();
		//}

		//void EnsureProperties()
		//{
		//    if (!s_BackgroundProperty)
		//    {
		//        s_BackgroundProperty { get; } =
		//            InitializeDependencyProperty(
		//                "Background",
		//                name_of<Brush>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<Brush>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnBackgroundPropertyChanged));
		//    }
		//    if (!s_BehaviorOnInvokedProperty)
		//    {
		//        s_BehaviorOnInvokedProperty { get; } =
		//            InitializeDependencyProperty(
		//                "BehaviorOnInvoked",
		//                name_of<SwipeBehaviorOnInvoked>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<SwipeBehaviorOnInvoked>.BoxValueIfNecessary(SwipeBehaviorOnInvoked.Auto),
		//                PropertyChangedCallback(&OnBehaviorOnInvokedPropertyChanged));
		//    }
		//    if (!s_CommandProperty)
		//    {
		//        s_CommandProperty { get; } =
		//            InitializeDependencyProperty(
		//                "Command",
		//                name_of<ICommand>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<ICommand>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnCommandPropertyChanged));
		//    }
		//    if (!s_CommandParameterProperty)
		//    {
		//        s_CommandParameterProperty { get; } =
		//            InitializeDependencyProperty(
		//                "CommandParameter",
		//                name_of<DependencyObject>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<DependencyObject>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnCommandParameterPropertyChanged));
		//    }
		//    if (!s_ForegroundProperty)
		//    {
		//        s_ForegroundProperty { get; } =
		//            InitializeDependencyProperty(
		//                "Foreground",
		//                name_of<Brush>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<Brush>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnForegroundPropertyChanged));
		//    }
		//    if (!s_IconSourceProperty)
		//    {
		//        s_IconSourceProperty { get; } =
		//            InitializeDependencyProperty(
		//                "IconSource",
		//                name_of<IconSource>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<IconSource>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnIconSourcePropertyChanged));
		//    }
		//    if (!s_TextProperty)
		//    {
		//        s_TextProperty { get; } =
		//            InitializeDependencyProperty(
		//                "Text",
		//                name_of<hstring>(),
		//                name_of<SwipeItem>(),
		//                false /* isAttached */,
		//                ValueHelper<hstring>.BoxedDefaultValue(),
		//                PropertyChangedCallback(&OnTextPropertyChanged));
		//    }
		//}

		//void ClearProperties()
		//{
		//    s_BackgroundProperty { get; } = null;
		//    s_BehaviorOnInvokedProperty { get; } = null;
		//    s_CommandProperty { get; } = null;
		//    s_CommandParameterProperty { get; } = null;
		//    s_ForegroundProperty { get; } = null;
		//    s_IconSourceProperty { get; } = null;
		//    s_TextProperty { get; } = null;
		//}

		private static void OnBackgroundPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnBehaviorOnInvokedPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnCommandPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnCommandParameterPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnForegroundPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnIconSourcePropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		private static void OnTextPropertyChanged(
			DependencyObject sender,
			DependencyPropertyChangedEventArgs args)
		{
			var owner = ((SwipeItem)sender);
			owner.OnPropertyChanged(args);
		}

		// Uno workaround: Added "new" keyword
		public static
#if __IOS__ || __MACOS__ || __ANDROID__
			new
#endif
			DependencyProperty BackgroundProperty { get; } = DependencyProperty.Register(
			"Background", typeof(Brush), typeof(SwipeItem), new PropertyMetadata(default(Brush), OnBackgroundPropertyChanged));

		// Uno workaround: Added "new" keyword
		public
#if __IOS__ || __MACOS__ || __ANDROID__
			new
#endif
			Brush Background
		{
			get { return (Brush)GetValue(BackgroundProperty); }
			set { SetValue(BackgroundProperty, value); }
		}

		//void Background(Brush value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_BackgroundProperty, ValueHelper<Brush>.BoxValueIfNecessary(value));
		//    }
		//}

		//Brush Background()
		//{
		//    return ValueHelper<Brush>.CastOrUnbox((SwipeItem)(this).GetValue(s_BackgroundProperty));
		//}

		public static DependencyProperty BehaviorOnInvokedProperty { get; } = DependencyProperty.Register(
			"BehaviorOnInvoked", typeof(SwipeBehaviorOnInvoked), typeof(SwipeItem), new PropertyMetadata(default(SwipeBehaviorOnInvoked), OnBehaviorOnInvokedPropertyChanged));

		public SwipeBehaviorOnInvoked BehaviorOnInvoked
		{
			get { return (SwipeBehaviorOnInvoked)GetValue(BehaviorOnInvokedProperty); }
			set { SetValue(BehaviorOnInvokedProperty, value); }
		}

		//void BehaviorOnInvoked(SwipeBehaviorOnInvoked value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_BehaviorOnInvokedProperty, ValueHelper<SwipeBehaviorOnInvoked>.BoxValueIfNecessary(value));
		//    }
		//}

		//SwipeBehaviorOnInvoked BehaviorOnInvoked()
		//{
		//    return ValueHelper<SwipeBehaviorOnInvoked>.CastOrUnbox((SwipeItem)(this).GetValue(s_BehaviorOnInvokedProperty));
		//}

		public static DependencyProperty CommandProperty { get; } = DependencyProperty.Register(
			"Command", typeof(ICommand), typeof(SwipeItem), new PropertyMetadata(default(ICommand), OnCommandPropertyChanged));

		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		//void Command(ICommand value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_CommandProperty, ValueHelper<ICommand>.BoxValueIfNecessary(value));
		//    }
		//}

		//ICommand Command()
		//{
		//    return ValueHelper<ICommand>.CastOrUnbox((SwipeItem)(this).GetValue(s_CommandProperty));
		//}

		public static DependencyProperty CommandParameterProperty { get; } = DependencyProperty.Register(
			"CommandParameter", typeof(object), typeof(SwipeItem), new PropertyMetadata(default(object), OnCommandParameterPropertyChanged));

		public object CommandParameter
		{
			get { return (object)GetValue(CommandParameterProperty); }
			set { SetValue(CommandParameterProperty, value); }
		}

		//void CommandParameter(DependencyObject value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_CommandParameterProperty, ValueHelper<DependencyObject>.BoxValueIfNecessary(value));
		//    }
		//}

		//DependencyObject CommandParameter()
		//{
		//    return ValueHelper<DependencyObject>.CastOrUnbox((SwipeItem)(this).GetValue(s_CommandParameterProperty));
		//}

		public static DependencyProperty ForegroundProperty { get; } = DependencyProperty.Register(
			"Foreground", typeof(Brush), typeof(SwipeItem), new PropertyMetadata(default(Brush), OnForegroundPropertyChanged));

		public
#if __ANDROID__
			new
#endif
			Brush Foreground
		{
			get { return (Brush)GetValue(ForegroundProperty); }
			set { SetValue(ForegroundProperty, value); }
		}

		//void Foreground(Brush value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_ForegroundProperty, ValueHelper<Brush>.BoxValueIfNecessary(value));
		//    }
		//}

		//Brush Foreground()
		//{
		//    return ValueHelper<Brush>.CastOrUnbox((SwipeItem)(this).GetValue(s_ForegroundProperty));
		//}

		public static DependencyProperty IconSourceProperty { get; } = DependencyProperty.Register(
			"IconSource", typeof(IconSource), typeof(SwipeItem), new PropertyMetadata(default(IconSource), OnIconSourcePropertyChanged));

		public IconSource IconSource
		{
			get { return (IconSource)GetValue(IconSourceProperty); }
			set { SetValue(IconSourceProperty, value); }
		}

		//void IconSource(IconSource value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_IconSourceProperty, ValueHelper<IconSource>.BoxValueIfNecessary(value));
		//    }
		//}

		//IconSource IconSource()
		//{
		//    return ValueHelper<IconSource>.CastOrUnbox((SwipeItem)(this).GetValue(s_IconSourceProperty));
		//}

		public static DependencyProperty TextProperty { get; } = DependencyProperty.Register(
			"Text", typeof(string), typeof(SwipeItem), new PropertyMetadata(default(string), OnTextPropertyChanged));

		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

		//void Text(string value)
		//{
		//    [[gsl.suppress(con)]]
		//    {
		//    (SwipeItem)(this).SetValue(s_TextProperty, ValueHelper<hstring>.BoxValueIfNecessary(value));
		//    }
		//}

		//string Text()
		//{
		//    return ValueHelper<hstring>.CastOrUnbox((SwipeItem)(this).GetValue(s_TextProperty));
		//}


		public event TypedEventHandler<SwipeItem, SwipeItemInvokedEventArgs> Invoked
		{
			add
			{
				m_invokedEventSource += value;
			}
			remove
			{
				m_invokedEventSource -= value;
			}
		}
	}
}
