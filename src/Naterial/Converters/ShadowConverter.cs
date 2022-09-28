using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Effects;

namespace Naterial.Converters
{
    /// <summary>
    /// Represents a converter that converts the elevation depth into a drop shadow effect.
    /// </summary>
    [ValueConversion(typeof(int), typeof(DropShadowEffect))]
    public class ShadowConverter : IValueConverter
    {
        /// <summary>
        /// Provides a converter instance for access from XAML.
        /// </summary>
        public static IValueConverter Instance { get; } = new ShadowConverter();


        /// <summary>
        /// Converts the elevation depth into a drop shadow effect.
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
        /// The <see cref="DropShadowEffect" />.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int depth && ElevationInfo.s_shadows.ContainsKey(depth))
            {
                DropShadowEffect effect = ElevationInfo.s_shadows[depth];

                if (effect != null)
                {
                    effect.Freeze();
                }

                return effect;
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
