using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Naterial.Converters
{
    /// <summary>
    /// Represents a converter that converts the elevation depth into a semi-transparent overlay.
    /// </summary>
    [ValueConversion(typeof(int), typeof(double))]
    public class OverlayConverter : IValueConverter
    {
        /// <summary>
        /// Provides a converter instance for access from XAML.
        /// </summary>
        public static IValueConverter Instance { get; } = new OverlayConverter();


        /// <summary>
        /// Converts the elevation depth into a semi-transparent overlay.
        /// </summary>
        /// <param name="value">
        /// The elevation depth [<see cref="int" />].
        /// </param>
        /// <param name="targetType">
        /// This parameter is not used.
        /// </param>
        /// <param name="parameter">
        /// This parameter is not used.
        /// </param>
        /// <param name="culture">
        /// This parameter is not used.
        /// </param>
        /// <returns>
        /// The semi-transparent overlay [<see cref="double" />].
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int level && ElevationInfo.s_overlays.ContainsKey(level))
            {
                return ElevationInfo.s_overlays[level];
            }

            return DependencyProperty.UnsetValue;
        }

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="value">
        /// This parameter is not used.
        /// </param>
        /// <param name="targetType">
        /// This parameter is not used.
        /// </param>
        /// <param name="parameter">
        /// This parameter is not used.
        /// </param>
        /// <param name="culture">
        /// This parameter is not used.
        /// </param>
        /// <returns>
        /// Raise the <see cref="NotSupportedException" /> in all cases.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The method is called.
        /// </exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
