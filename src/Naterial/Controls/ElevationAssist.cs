using System.Windows;

namespace Naterial.Controls
{
    /// <summary>
    /// Provides attached properties for setting the elevation depth along the z-axis of an element.
    /// </summary>
    public static class ElevationAssist
    {
        #region Attached Property: Level
        /// <summary>
        /// Identifies the <see cref="ElevationAssist" />.Level attached property.
        /// </summary>
        public static readonly DependencyProperty LevelProperty = DependencyProperty.RegisterAttached(
            "Level",
            typeof(int),
            typeof(ElevationAssist),
            new FrameworkPropertyMetadata(
                0,
                FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// Gets the value of the <see cref="ElevationAssist" />.Level attached property from a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element from which to read the property value.
        /// </param>
        /// <returns>
        /// The value of the <see cref="ElevationAssist" />.Level attached property.
        /// </returns>
        public static int GetLevel(UIElement element) => (int)element.GetValue(LevelProperty);

        /// <summary>
        /// Sets the value of the <see cref="ElevationAssist" />.Level attached property to a given <see cref="UIElement" />.
        /// </summary>
        /// <param name="element">
        /// The element on which to set the <see cref="ElevationAssist" />.Level attached property.
        /// </param>
        /// <param name="value">
        /// The property value to set.
        /// </param>
        public static void SetLevel(UIElement element, int value) => element.SetValue(LevelProperty, value);
        #endregion
    }
}
