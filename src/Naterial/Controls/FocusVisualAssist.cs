using System.Windows;
using System.Windows.Media;

namespace Naterial.Controls
{
    /// <summary>
    /// Provides attached properties for setting the focus visual style of an element.
    /// </summary>
    public static class FocusVisualAssist
    {
        #region Attached Property: BorderBrush
        /// <summary>
        /// Identifies the <see cref="FocusVisualAssist" />.BorderBrush attached property.
        /// </summary>
        public static readonly DependencyProperty BorderBrushProperty = DependencyProperty.RegisterAttached(
            "BorderBrush",
            typeof(Brush),
            typeof(FocusVisualAssist),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// Gets the value of the <see cref="FocusVisualAssist" />.BorderBrush attached property from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="FocusVisualAssist" />.BorderBrush attached property.
        /// </returns>
        public static Brush GetBorderBrush(UIElement element) => (Brush)element.GetValue(BorderBrushProperty);

        /// <summary>
        /// Sets the value of the <see cref="FocusVisualAssist" />.BorderBrush attached property to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="FocusVisualAssist" />.BorderBrush attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetBorderBrush(UIElement element, Brush value) => element.SetValue(BorderBrushProperty, value);
        #endregion


        #region Attached Property: BorderThickness
        /// <summary>
        /// Identifies the <see cref="FocusVisualAssist" />.BorderThickness attached property.
        /// </summary>
        public static readonly DependencyProperty BorderThicknessProperty = DependencyProperty.RegisterAttached(
            "BorderThickness",
            typeof(Thickness),
            typeof(FocusVisualAssist),
            new FrameworkPropertyMetadata(
                new Thickness(0),
                FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange));

        /// <summary>
        /// Gets the value of the <see cref="FocusVisualAssist" />.BorderThickness attached property from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="FocusVisualAssist" />.BorderThickness attached property.
        /// </returns>
        public static Thickness GetBorderThickness(UIElement element) => (Thickness)element.GetValue(BorderThicknessProperty);

        /// <summary>
        /// Sets the value of the <see cref="FocusVisualAssist" />.BorderThickness attached property to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="FocusVisualAssist" />.BorderThickness attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetBorderThickness(UIElement element, Thickness value) => element.SetValue(BorderThicknessProperty, value);
        #endregion


        #region Attached Property: CornerRadius
        /// <summary>
        /// Identifies the <see cref="FocusVisualAssist" />.CornerRadius attached property.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached(
            "CornerRadius",
            typeof(CornerRadius),
            typeof(FocusVisualAssist),
            new FrameworkPropertyMetadata(
                new CornerRadius(0),
                FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        /// <summary>
        /// Gets the value of the <see cref="FocusVisualAssist" />.CornerRadius attached property from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="FocusVisualAssist" />.CornerRadius attached property.
        /// </returns>
        public static CornerRadius GetCornerRadius(UIElement element) => (CornerRadius)element.GetValue(CornerRadiusProperty);

        /// <summary>
        /// Sets the value of the <see cref="FocusVisualAssist" />.CornerRadius attached property to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="FocusVisualAssist" />.CornerRadius attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetCornerRadius(UIElement element, CornerRadius value) => element.SetValue(CornerRadiusProperty, value);
        #endregion


        #region Attached Property: Margin
        /// <summary>
        /// Identifies the <see cref="FocusVisualAssist" />.Margin attached property.
        /// </summary>
        public static readonly DependencyProperty MarginProperty = DependencyProperty.RegisterAttached(
            "Margin",
            typeof(Thickness),
            typeof(FocusVisualAssist),
            new FrameworkPropertyMetadata(
                new Thickness(0),
                FrameworkPropertyMetadataOptions.AffectsMeasure));

        /// <summary>
        /// Gets the value of the <see cref="FocusVisualAssist" />.Margin attached property from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="FocusVisualAssist" />.Margin attached property.
        /// </returns>
        public static Thickness GetMargin(UIElement element) => (Thickness)element.GetValue(MarginProperty);

        /// <summary>
        /// Sets the value of the <see cref="FocusVisualAssist" />.Margin attached property to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="FocusVisualAssist" />.Margin attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetMargin(UIElement element, Thickness value) => element.SetValue(MarginProperty, value);
        #endregion
    }
}
